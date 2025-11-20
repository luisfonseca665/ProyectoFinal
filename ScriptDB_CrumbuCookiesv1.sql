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


-- Tabla auditoriaproductos (CORREGIDA)
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


-- Datos de Prueba ()
insert into productos values
('0001','café americano','vaso mediano',35,50, false, ''),
('0002','café latte','con leche entera',45,40, false, ''),
('0003','capuchino','espumoso',42,30, false, ''),
('0004','muffin chocolate','grande',28,20, false, ''),
('0005','galleta avena','integral',15,25, false, '');

Select * from productos;