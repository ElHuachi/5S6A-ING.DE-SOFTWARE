create database TOOLVIN;
use toolvin;

create table usuario(
	nombre 		varchar(50) 	primary key,
    usuario 	varchar(30) 	not null,
    password	varchar(30)		not null
);

create table proveedor(
	nombre 			varchar(50) 	not null,
    apellidos		varchar(50)		not null,
    correo 			varchar(100)	not null,
    nombreEmpresa	varchar(50)		not null,
    RFC				varchar(13)		primary key,
    direccion		varchar(50)		not null,
    tel				int				not null,
    idProducto		varchar(40)     not null
);

create table almacen(
	idP 			int 			primary key,
    nombreP 		varchar(50)		not null,
    descripcionP	varchar(150)	not null,
    precioN			double(10,2)	not null,
    precioMay		double(10,2)	not null,
    precioProv		double(10,2)	not null,
    RFC				varchar(13)		not null,
    foreign key	(RFC) references proveedor(RFC)
);

create table clientes(
	idCliente		varchar(4)		primary key,
    nombre			varchar(50)		not null,
    apellido		varchar(70)		not null,
    correo 			varchar(150)	not null,
    tel1			varchar(10)		not null,
    tel2			varchar(10)		null,
    direccion 		varchar(150)	not null,
    idProductos 	int,
    constraint fk_Productos foreign key (idProductos)references almacen(idP)
);

create table ventas(
	idVentas		int 			primary key auto_increment,
    idProducto		int				not null,
    nombre			varchar(50)		not null,
    descripcion		text			null,
	precioTotal		double			not null,
    fechaVenta		date			not null,
    constraint fk_Producto foreign key (idProducto) references almacen(idP),
    constraint fk_nombre foreign key (nombre) references usuario(nombre)
);