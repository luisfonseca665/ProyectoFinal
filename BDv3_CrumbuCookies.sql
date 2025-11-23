create database ventas;
use ventas;

-- Tabla empleados
create table empleados(
	id int AUTO_INCREMENT primary key,
	nombre varchar(100) not null,
	apellidos varchar(100) not null,
	telefono varchar(20),
	correo varchar(50),
	usuario varchar(50) unique,
	password varchar(100),
	tipo enum('admin','cajero'),	
	foto LONGBLOB,  -- ¡CAMBIO AQUÍ!
    activo boolean default true
);

-- Tabla productos
create table productos(
	codigo varchar(13) primary key,
	nombre varchar(100),
	descripcion varchar(200),
	precio decimal(10,2),
	stock int,
	descontinuado boolean default false,
	foto LONGBLOB -- Ya estaba correcto.
);


-- Tabla auditoriaproductos
create table auditoriaproductos(
	id int AUTO_INCREMENT primary key,
	codigo varchar(13),
	accion enum('insert','update','delete'),
	valoranterior varchar(500),
	valornuevo varchar(500),
	usuario varchar(100),
	fecha timestamp default CURRENT_TIMESTAMP,
	foreign key (codigo) references productos(codigo)
);

-- Tabla ventas
create table ventas(
	id int AUTO_INCREMENT primary key,
	fecha datetime default CURRENT_TIMESTAMP,
	idempleado int,
	total decimal(10,2),
    foreign key(idempleado) references empleados(id) 
);


-- Tabla detalleventas
create table detalleventas(
	id int AUTO_INCREMENT primary key,
	idventa int,
	codigoproducto varchar(13),
	cantidad int,
	precio decimal(10,2),
	foreign key(idventa) references ventas(id),
	foreign key(codigoproducto) references productos(codigo)
);


insert into empleados(nombre, apellidos, telefono, correo, usuario, password, tipo, foto, activo)	
values('Luis Enrique', 'Fonseca Sosa', '4451108686','i49483190@gmail.com', 'dickgrayson',sha2('12345678',256),'admin' ,null, true);



-- Procedimiento: spinsertempleado
delimiter $$
create procedure spinsertempleado(
	in pnombre varchar(100),
	in papellidos varchar(100),
	in ptelefono varchar(20),
	in pcorreo varchar(50),
	in pusuario varchar(50),
	in ppassword varchar(100),
	in ptipo varchar(10),	
	in pfoto LONGBLOB
)
begin
	insert into empleados(nombre, apellidos, telefono, correo, usuario, password, tipo, foto)	
	values(pnombre,papellidos,ptelefono, pcorreo, pusuario, ppassword, ptipo, pfoto);
end$$
delimiter ;


-- Procedimiento: spupdateempleado
delimiter $$
create procedure spupdateempleado(
	in pid int,
	in pnombre varchar(100),
	in papellidos varchar(100),
	in ptelefono varchar(20),
	in pcorreo varchar(50),
	in pusuario varchar(50),
	in ppassword varchar(100),
	in ptipo varchar(10),	
	in pfoto LONGBLOB, 
    in pactivo boolean
)
begin
	update empleados set
		nombre=pnombre,
		apellidos=papellidos,
		telefono=ptelefono,
		correo=pcorreo,
		usuario=pusuario,
		password=ppassword,
		tipo=ptipo,
		foto=pfoto,
        activo=pactivo
	where id=pid;
end$$
delimiter ;

-- Procedimiento: spdeleteempleado
delimiter $$
create procedure spdeleteempleado(in pid int)
begin
    delete dv
    from detalleventas dv
    join ventas v on dv.idventa = v.id
    where v.idempleado = pid;
    
    delete from ventas 
    where idempleado = pid;

    update empleados 
    set activo = false 
    where id = pid;
end$$
delimiter ;


-- Procedimiento: spinsertproducto
delimiter $$
CREATE PROCEDURE spinsertproducto(
	IN pcodigo VARCHAR(13),
	IN pnombre VARCHAR(100),
	IN pdescripcion VARCHAR(200),
	IN pprecio DECIMAL(10,2),
	IN pstock INT,
    in pfoto LONGBLOB  -- ¡CAMBIO AQUÍ!
)
BEGIN
	INSERT INTO productos(codigo, nombre, descripcion, precio, stock, foto)
	VALUES(pcodigo, pnombre, pdescripcion, pprecio, pstock, pfoto);
END$$
delimiter ;


-- Procedimiento: spgetproductos
delimiter $$
CREATE PROCEDURE spgetproductos()
BEGIN
	SELECT codigo, nombre, descripcion, precio, stock, descontinuado, foto
	FROM productos
	WHERE descontinuado = FALSE;
END$$
delimiter ;


-- Procedimiento: spupdateproducto 
delimiter $$
CREATE PROCEDURE spupdateproducto(
	IN pcodigo VARCHAR(13),
	IN pnombre VARCHAR(100),
	IN pdescripcion VARCHAR(200),
	IN pprecio DECIMAL(10,2),
	IN pstock INT,
	IN pdescontinuado BOOLEAN,
	IN pfoto LONGBLOB
)
BEGIN
	UPDATE productos SET
		nombre = pnombre,
		descripcion = pdescripcion,
		precio = pprecio,
		stock = pstock,
		descontinuado = pdescontinuado,
		foto = pfoto
	WHERE codigo = pcodigo;
END$$
delimiter ;

-- Procedimiento: spdeleteproducto
delimiter $$
CREATE PROCEDURE spdeleteproducto(IN pcodigo VARCHAR(13))
BEGIN
    UPDATE productos
    SET descontinuado = TRUE
    WHERE codigo = pcodigo;
END$$
delimiter ;


-- Trigger: trgprodinsert
delimiter $$
create trigger trgprodinsert
after insert on productos
for each row
begin
	insert into auditoriaproductos(codigo,accion,valoranterior,valornuevo,usuario)
	values(
		new.codigo,'insert',
		null, concat('nombre: ',new.nombre,', precio: ',new.precio,', stock: ',new.stock),
		CURRENT_USER()
	);
end$$
delimiter ;


-- Trigger: trgprodupdate
delimiter $$
create trigger trgprodupdate
after update on productos
for each row
begin
	insert into auditoriaproductos(codigo,accion,valoranterior,valornuevo,usuario)
	values(
		new.codigo,
		'update',
		concat('nombre: ',old.nombre,', precio: ',old.precio,', stock: ',old.stock),
		concat('nombre: ',new.nombre,', precio: ',new.precio,', stock: ',new.stock),
		CURRENT_USER()
	);
end$$
delimiter ;


-- Trigger: trgproddelete
delimiter $$
create trigger trgproddelete
after delete on productos
for each row
begin
	insert into auditoriaproductos(codigo,accion,valoranterior,valornuevo,usuario)
	values(
		old.codigo,
		'delete',
		concat('nombre: ',old.nombre,', precio: ',old.precio,', stock: ',old.stock),
		null,
		CURRENT_USER()
	);
end$$
delimiter ;

INSERT INTO productos (codigo, nombre, descripcion, precio, stock, descontinuado, foto) VALUES
('CC-001-2025-A', 'Crumbu Chispas Gourmet', 'Galleta con tres tipos de chocolate y sal marina.', 35.00, 180, false, NULL),
('CC-002-2025-B', 'Cheesecake de Limón', 'Base de galleta de vainilla rellena de crema ácida de limón.', 38.50, 90, false, NULL),
('CC-020-2025-T', 'Mapache de Arce', 'Galleta de sirope de arce con trozos de nuez pecana y glaseado.', 35.50, 90, false, NULL);


-- new ->>
DELIMITER $$
CREATE PROCEDURE spinsertventa(
    IN pidempleado INT,
    IN ptotal DECIMAL(10,2),
    OUT pidventa INT
)
BEGIN
    INSERT INTO ventas(idempleado, total) VALUES(pidempleado, ptotal);
    SET pidventa = LAST_INSERT_ID();
END$$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE spinsertdetalle_updatestock(
    IN pidventa INT,
    IN pcodigo VARCHAR(13),
    IN pcantidad INT,
    IN pprecio DECIMAL(10,2)
)
BEGIN
    INSERT INTO detalleventas(idventa, codigoproducto, cantidad, precio) 
    VALUES(pidventa, pcodigo, pcantidad, pprecio);

    UPDATE productos 
    SET stock = stock - pcantidad 
    WHERE codigo = pcodigo;
END$$
DELIMITER ;