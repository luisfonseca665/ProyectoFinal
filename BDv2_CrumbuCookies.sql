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
	foto BLOB,
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
	foto BLOB not null
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

insert into productos values
('0001','café americano','vaso mediano',35,50, false, ''),
('0002','café latte','con leche entera',45,40, false, ''),
('0003','capuchino','espumoso',42,30, false, ''),
('0004','muffin chocolate','grande',28,20, false, ''),
('0005','galleta avena','integral',15,25, false, '');


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
	in pfoto BLOB	
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
	in pfoto BLOB,
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
	IN pstock INT
)
BEGIN
	INSERT INTO productos(codigo, nombre, descripcion, precio, stock, foto)
	VALUES(pcodigo, pnombre, pdescripcion, pprecio, pstock, '');
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
	IN pfoto BLOB
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

-- Verificación de datos insertados
Select * from empleados;
Select * from productos;

INSERT INTO productos (codigo, nombre, descripcion, precio, stock, descontinuado, foto) VALUES
('CC-001-2025-A', 'Crumbu Chispas Gourmet', 'Galleta con tres tipos de chocolate y sal marina.', 35.00, 180, false, 'Foto_CC-001-25A'),
('CC-002-2025-B', 'Cheesecake de Limón', 'Base de galleta de vainilla rellena de crema ácida de limón.', 38.50, 90, false, 'Foto_CC-002-25B'),
('CC-003-2025-C', 'Caramelo Salado Praliné', 'Galleta de azúcar moreno con toffee y nueces caramelizadas.', 40.00, 75, false, 'Foto_CC-003-25C'),
('CC-004-2025-D', 'Galleta de Miel y Canela', 'Suave galleta de especias con un glaseado de miel.', 30.00, 150, false, 'Foto_CC-004-25D'),
('CC-005-2025-E', 'Crumbu Doble Fudge Vegana', 'Opción vegana intensa de doble chocolate.', 42.00, 60, false, 'Foto_CC-005-25E');

INSERT INTO productos (codigo, nombre, descripcion, precio, stock, descontinuado, foto) VALUES
('CC-006-2025-F', 'Especias de Calabaza Chai', 'Galleta de temporada con puré de calabaza, especias chai y glaseado de cardamomo.', 36.50, 85, false, 'Foto_CC-006-25F'),
('CC-007-2025-G', 'Triple Berry Muffin', 'Galleta inspirada en muffin con arándanos, frambuesas y moras frescas.', 33.00, 110, false, 'Foto_CC-007-25G'),
('CC-008-2025-H', 'S\'mores Tostado', 'Galleta de graham con malvaviscos tostados y trozos de chocolate con leche.', 31.00, 130, false, 'Foto_CC-008-25H'),
('CC-009-2025-I', 'Almendras y Cerezas Secas', 'Galleta de mantequilla con trozos de almendra y cerezas secas.', 29.50, 95, false, 'Foto_CC-009-25I'),
('CC-010-2025-J', 'Café Moca Espresso', 'Galleta de moca con chocolate oscuro y un toque de café espresso.', 34.00, 105, false, 'Foto_CC-010-25J'),
('CC-011-2025-K', 'Pistacho y Chocolate Blanco', 'Galleta de pistacho con chocolate blanco derretido en el interior.', 41.00, 70, false, 'Foto_CC-011-25K'),
('CC-012-2025-L', 'Crumbu Key Lime Pie', 'Galleta sabor tarta de lima, con base de graham y relleno cítrico.', 39.50, 65, false, 'Foto_CC-012-25L'),
('CC-013-2025-M', 'Jengibre Melaza', 'Galleta de melaza y jengibre, clásica de invierno, suave y aromática.', 27.00, 140, false, 'Foto_CC-013-25M'),
('CC-014-2025-N', 'Avellana Ferrero', 'Galleta de chocolate rellena de crema de avellanas y trozos de barquillo.', 45.00, 50, false, 'Foto_CC-014-25N'),
('CC-015-2025-O', 'Coconut Dream', 'Galleta de coco rallado con cobertura de chocolate semi-amargo.', 30.50, 115, false, 'Foto_CC-015-25O'),
('CC-016-2025-P', 'Durazno Cobbler', 'Galleta de vainilla rellena de compota de durazno y un crumble de avena.', 37.00, 80, false, 'Foto_CC-016-25P'),
('CC-017-2025-Q', 'Churro Azúcar y Canela', 'Galleta frita con sabor a churro, cubierta con azúcar y canela.', 32.50, 125, false, 'Foto_CC-017-25Q'),
('CC-018-2025-R', 'Mantequilla Pura (Shortbread)', 'Galleta de mantequilla tradicional escocesa, simple y deliciosa.', 23.00, 200, false, 'Foto_CC-018-25R'),
('CC-019-2025-S', 'Tiramisú', 'Galleta de café con crema de mascarpone y un toque de cacao.', 43.00, 55, false, 'Foto_CC-019-25S'),
('CC-020-2025-T', 'Mapache de Arce', 'Galleta de sirope de arce con trozos de nuez pecana y glaseado.', 35.50, 90, false, 'Foto_CC-020-25T');

SET SQL_SAFE_UPDATES = 1;