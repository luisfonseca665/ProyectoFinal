CREATE DATABASE ventas;
USE ventas;

CREATE TABLE empleados(
	id INT AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(100) NOT NULL,
	apellidos VARCHAR(100) NOT NULL,
	telefono VARCHAR(20),
	correo VARCHAR(50),
	usuario VARCHAR(50) UNIQUE,
	password VARCHAR(100),
	tipo ENUM('admin','cajero'),
	foto LONGBLOB,
    activo BOOLEAN DEFAULT TRUE
);

CREATE TABLE productos(
	codigo VARCHAR(13) PRIMARY KEY,
	nombre VARCHAR(100),
	descripcion VARCHAR(200),
	precio DECIMAL(10,2),
	stock INT,
	descontinuado BOOLEAN DEFAULT FALSE,
	foto LONGBLOB
);

CREATE TABLE auditoriaproductos(
	id INT AUTO_INCREMENT PRIMARY KEY,
	codigo VARCHAR(13),
	accion ENUM('insert','update','delete'),
	valoranterior VARCHAR(500),
	valornuevo VARCHAR(1000),
	usuario VARCHAR(100),
	fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	FOREIGN KEY (codigo) REFERENCES productos(codigo)
);

CREATE TABLE ventas(
	id INT AUTO_INCREMENT PRIMARY KEY,
	fecha DATETIME DEFAULT CURRENT_TIMESTAMP,
	idempleado INT,
	total DECIMAL(10,2),
    FOREIGN KEY(idempleado) REFERENCES empleados(id)
);

CREATE TABLE detalleventas(
	id INT AUTO_INCREMENT PRIMARY KEY,
	idventa INT,
	codigoproducto VARCHAR(13),
	cantidad INT,
	precio DECIMAL(10,2),
	FOREIGN KEY(idventa) REFERENCES ventas(id),
	FOREIGN KEY(codigoproducto) REFERENCES productos(codigo)
);

CREATE USER IF NOT EXISTS 'usuario_cajero'@'localhost' IDENTIFIED BY 'cajero123';
GRANT SELECT, INSERT, UPDATE ON ventas.* TO 'usuario_cajero'@'localhost';
GRANT EXECUTE ON ventas.* TO 'usuario_cajero'@'localhost';

CREATE USER IF NOT EXISTS 'usuario_admin'@'localhost' IDENTIFIED BY 'admin123';
GRANT ALL PRIVILEGES ON ventas.* TO 'usuario_admin'@'localhost';

FLUSH PRIVILEGES;

DELIMITER $$

CREATE PROCEDURE spinsertempleado(
	in pnombre VARCHAR(100), in papellidos VARCHAR(100), in ptelefono VARCHAR(20),
	in pcorreo VARCHAR(50), in pusuario VARCHAR(50), in ppassword VARCHAR(100),
	in ptipo VARCHAR(10), in pfoto LONGBLOB
)
BEGIN
	IF ptipo NOT IN ('admin','cajero') THEN
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Tipo de empleado inválido';
	END IF;

	INSERT INTO empleados(nombre, apellidos, telefono, correo, usuario, password, tipo, foto)
	VALUES(pnombre,papellidos,ptelefono,pcorreo,pusuario,sha2(ppassword,256),ptipo,pfoto);
END$$

CREATE PROCEDURE spupdateempleado(
	in pid INT, in pnombre VARCHAR(100), in papellidos VARCHAR(100), in ptelefono VARCHAR(20),
	in pcorreo VARCHAR(50), in pusuario VARCHAR(50), in ppassword VARCHAR(100),
	in ptipo VARCHAR(10), in pfoto LONGBLOB, in pactivo BOOLEAN
)
BEGIN
	IF ptipo NOT IN ('admin','cajero') THEN
		SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Tipo de empleado inválido';
	END IF;

	IF ppassword = '' THEN
		UPDATE empleados SET nombre=pnombre, apellidos=papellidos, telefono=ptelefono, correo=pcorreo,
			usuario=pusuario, tipo=ptipo, foto=pfoto, activo=pactivo WHERE id=pid;
	ELSE
		UPDATE empleados SET nombre=pnombre, apellidos=papellidos, telefono=ptelefono, correo=pcorreo,
			usuario=pusuario, password=sha2(ppassword,256), tipo=ptipo, foto=pfoto, activo=pactivo WHERE id=pid;
	END IF;
END$$

CREATE PROCEDURE spdeleteempleado(in pid INT)
BEGIN
	UPDATE empleados SET activo = FALSE WHERE id = pid;
END$$

CREATE PROCEDURE spinsertproducto(
	IN pcodigo VARCHAR(13), IN pnombre VARCHAR(100), IN pdescripcion VARCHAR(200),
	IN pprecio DECIMAL(10,2), IN pstock INT, in pfoto LONGBLOB
)
BEGIN
	INSERT INTO productos(codigo, nombre, descripcion, precio, stock, foto)
	VALUES(pcodigo, pnombre, pdescripcion, pprecio, pstock, pfoto);
END$$

CREATE PROCEDURE spgetproductos()
BEGIN
	SELECT codigo, nombre, descripcion, precio, stock, descontinuado, foto
	FROM productos WHERE descontinuado = FALSE;
END$$

CREATE PROCEDURE spupdateproducto(
	IN pcodigo VARCHAR(13), IN pnombre VARCHAR(100), IN pdescripcion VARCHAR(200),
	IN pprecio DECIMAL(10,2), IN pstock INT, IN pdescontinuado BOOLEAN, IN pfoto LONGBLOB
)
BEGIN
	UPDATE productos SET nombre=pnombre, descripcion=pdescripcion, precio=pprecio,
		stock=pstock, descontinuado=pdescontinuado, foto=pfoto
	WHERE codigo=pcodigo;
END$$

CREATE PROCEDURE spdeleteproducto(IN pcodigo VARCHAR(13))
BEGIN
	UPDATE productos SET descontinuado = TRUE WHERE codigo = pcodigo;
END$$

CREATE TRIGGER trgprodinsert AFTER INSERT ON productos
FOR EACH ROW
BEGIN
	DECLARE usuario_tipo VARCHAR(50);
    SET usuario_tipo = IFNULL(@usuario_actual, 'admin');
    
	INSERT INTO auditoriaproductos(codigo, accion, valoranterior, valornuevo, usuario)
	VALUES(
		NEW.codigo,
		'insert',
		NULL,
		CONCAT(
			'nombre=', NEW.nombre,
			', descripcion=', NEW.descripcion,
			', precio=', NEW.precio,
			', stock=', NEW.stock
		),
		usuario_tipo
	);
END$$

CREATE TRIGGER trgprodupdate AFTER UPDATE ON productos
FOR EACH ROW
BEGIN
	DECLARE cambios VARCHAR(1000) DEFAULT '';
    DECLARE usuario_tipo VARCHAR(50);
    SET usuario_tipo = IFNULL(@usuario_actual, 'admin');

	IF OLD.nombre <> NEW.nombre THEN
		SET cambios = CONCAT(cambios, 'Nombre: "', OLD.nombre, '" → "', NEW.nombre, '". ');
	END IF;

	IF OLD.descripcion <> NEW.descripcion THEN
		SET cambios = CONCAT(cambios, 'Descripción: "', OLD.descripcion, '" → "', NEW.descripcion, '". ');
	END IF;

	IF OLD.precio <> NEW.precio THEN
		SET cambios = CONCAT(cambios, 'Precio: ', OLD.precio, ' → ', NEW.precio, '. ');
	END IF;

	IF OLD.stock <> NEW.stock THEN
		SET cambios = CONCAT(cambios, 'Stock: ', OLD.stock, ' → ', NEW.stock, '. ');
	END IF;

	IF OLD.descontinuado = FALSE AND NEW.descontinuado = TRUE THEN
		SET cambios = CONCAT(cambios, 'Producto se descontinuó. ');
	END IF;
	INSERT INTO auditoriaproductos(codigo, accion, valoranterior, valornuevo, usuario)
	VALUES(
		NEW.codigo,
		'update',
		CONCAT(
			'Antes => nombre=', OLD.nombre,
			', descripcion=', OLD.descripcion,
			', precio=', OLD.precio,
			', stock=', OLD.stock,
			', descontinuado=', OLD.descontinuado
		),
		cambios,
		usuario_tipo
	);
END$$

CREATE TRIGGER trgproddelete AFTER DELETE ON productos
FOR EACH ROW
BEGIN
	DECLARE usuario_tipo VARCHAR(50);
    SET usuario_tipo = IFNULL(@usuario_actual, 'admin');
	INSERT INTO auditoriaproductos(codigo, accion, valoranterior, valornuevo, usuario)
	VALUES(
		OLD.codigo,
		'delete',
		CONCAT('Producto "', OLD.nombre, '" fue eliminado.'),
		NULL,
		usuario_tipo
	);
END$$

DELIMITER ;

INSERT INTO empleados(nombre, apellidos, telefono, correo, usuario, password, tipo, foto, activo)
VALUES('Luis Enrique', 'Fonseca Sosa', '4451108686','i49483190@gmail.com', 'admin', sha2('12345678',256), 'admin', NULL, TRUE);

INSERT INTO productos (codigo, nombre, descripcion, precio, stock, descontinuado, foto) VALUES
('CC-001-2025-A', 'Crumbu Chispas Gourmet', 'Galleta con tres tipos de chocolate.', 35.00, 180, FALSE, NULL),
('CC-002-2025-B', 'Cheesecake de Limón', 'Base de galleta de vainilla.', 38.50, 90, FALSE, NULL);

select * from auditoriaproductos;


