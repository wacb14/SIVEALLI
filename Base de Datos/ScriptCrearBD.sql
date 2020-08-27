/* Create DataBase */
Create DATABASE DBAlmacen  -- Creates the Almacenes DataBase

on
  (NAME = DBAlmacen,    -- Primary data file
  FILENAME = 'B:\DBAlmacen.mdf',
  SIZE = 5MB,
  FILEGROWTH = 1MB
  )
  LOG ON
  (NAME = DBAlmacen_Log,   -- Log file
  FILENAME = 'B:\DBAlmacen.ldf',
  SIZE = 5MB,
  FILEGROWTH = 1MB
  )
go

go
/* Activar Base de datos: DBAlmacen */
use DBAlmacen
go

CREATE TYPE TIdProducto FROM varchar(8) NOT NULL ;
go

CREATE TYPE TIdProveedor FROM varchar(5) NOT NULL;
go

CREATE TYPE TIdUsuario FROM varchar(5) NOT NULL ;
go

CREATE TYPE TIdCliente FROM varchar(8) ;
go

CREATE TYPE TIdPedido FROM varchar(8) NOT NULL ;
go

CREATE TYPE TIdEntrada FROM varchar(8) NOT NULL ;
go

CREATE TYPE TIdVenta FROM varchar(8) ;
go

CREATE TYPE TIdDevolucion FROM varchar(8) ;
go


/* Crear las tablas */

create table TProducto(
  IdProducto   TIdProducto NOT NULL,
  Nombre		varchar(40) NOT NULL,
  Categoria		varchar(20) NOT NULL,
  Descripcion	varchar(500) NOT NULL,
  Marca			varchar(20) NOT NULL,
  PrecioUnitario float NOT NULL,
  Imagen		varbinary(MAX),
  Estado        varchar(10) check (Estado in ('ACTIVO','RETIRADO','OTRO')),
  Cantidad 		int,
  Maximo		int,
  Minimo		int,
  PRIMARY KEY (IdProducto)
 )
 go
 /*Imagen		varbinary(MAX) NOT NULL,*/

create table TProveedor(
  IdProveedor  TIdProveedor NOT NULL,
  Nombre	varchar(40) NOT NULL,
  Direccion        varchar(25),
  Telefono        varchar(25),
  Correo        varchar(40),
  Estado          varchar(10) check (Estado in ('ACTIVO','RETIRADO','OTRO')),
  PRIMARY KEY (IdProveedor)
 )
 go

  create table TUsuario
 (
	IdUsuario	TIdUsuario NOT NULL,
	Nombres			varchar(20),
	Apellidos		varchar(20),
	Direccion		varchar(35),
	Telefono		varchar(12),
	Correo			varchar(40),
	Contraseña		varchar(12),
	Tipo		varchar(10) check (Tipo in ('EMPLEADO', 'SUPERVISOR')),
	Estado          varchar(10) check (Estado in ('RETIRADO','ACTIVO','OTRO')),
	PRIMARY KEY (IdUsuario)
 )
 go

  create table TCliente
 (
	IdCliente	TIdCliente,
	Nombres			varchar(20),
	Apellidos		varchar(20),
	Direccion		varchar(35),
	Telefono		varchar(12),
	Correo			varchar(40),
	PRIMARY KEY (IdCliente)
 )
 go
 
 create table TPedido
(
	IdPedido 	TIdPedido NOT NULL,
    IdProveedor 	TIdProveedor NOT NULL,
    IdUsuario 	TIdUsuario NOT NULL,
    FechaPago 	datetime not null,
	FechaPedido 	datetime not null,
    TerminosEntrega varchar(15),
	primary key(IdPedido),
    foreign key(IdProveedor) references TProveedor(IdProveedor),
    foreign key(IdUsuario) references TUsuario(IdUsuario)
)
go

create table TEntrada
(
	IdEntrada 	TIdEntrada NOT NULL,
    IdProveedor 	TIdProveedor NOT NULL,
    IdUsuario 	TIdUsuario NOT NULL,
	Fecha 		datetime not null,
	primary key(IdEntrada),
    foreign key(IdProveedor) references TProveedor(IdProveedor),
    foreign key(IdUsuario) references TUsuario(IdUsuario)
)
go
create table TPedidoDetalle
(
    IdPedido 	TIdPedido NOT NULL,
    IdProducto 	TIdProducto NOT NULL,
	Cantidad 	int not null,
	PrecioUnitario 	float not null,
	primary key (IdPedido, IdProducto),
	foreign key(IdPedido) references TPedido(IdPedido),
	foreign key(IdProducto) references TProducto(IdProducto)
)
go
create table TEntradaDetalle
(
	IdEntrada 	TIdEntrada NOT NULL,
	IdProducto 	TIdProducto NOT NULL,
	Cantidad 	int not null,
	primary key (IdEntrada, IdProducto),
	foreign key(IdEntrada) references TEntrada(IdEntrada),
	foreign key(IdProducto) references TProducto(IdProducto)
)
go
 -- Tabla Venta
create table TVenta
(
	IdVenta TIdventa,
	IdUsuario	TIdUsuario NOT NULL,
	IdCliente	TIdCliente,
	Fecha datetime,
	primary key(IdVenta),
	foreign key(IdUsuario) references TUsuario(IdUsuario),
	foreign key(IdCliente) references TCliente(IdCliente)
)
go
create table TVentaDetalle
(
	IdVenta TIdVenta,
	IdProducto TIdProducto,
	Cantidad int,
	PrecioUnitario float,
	primary key (IdVenta, IdProducto),
	foreign key(IdVenta) references TVenta(IdVenta),
	foreign key(IdProducto) references TProducto(IdProducto)
)
go
-- Tabla Devolucion
create table TDevolucion
(
	IdDevolucion TIdDevolucion,
	IdVenta TIdVenta,
	Fecha datetime,
	primary key(IdDevolucion),
	foreign key(IdVenta) references TVenta(IdVenta),
)
go
create table TDevolucionDetalle
(
	IdDevolucion TIdDevolucion,
	IdVenta TIdVenta,
	IdProducto TIdProducto,
	Cantidad int,
	Estado varchar(12),
	PrecioUnitario float,
	primary key (IdDevolucion, IdProducto),
	foreign key(IdVenta) references TVenta(IdVenta),
	foreign key(IdDevolucion) references TDevolucion(IdDevolucion),
	foreign key(IdProducto) references TProducto(IdProducto)
)
go

set dateformat dmy
---------- DATOS PRODUCTO ----------------------
insert into TProducto values('PR000001','Portaminas Mars','Lapices y portaminas','Portaminas Mars Technico 780 HB con Clip','Staedtler',25.90,NULL,'ACTIVO', 0, 100, 10)
insert into TProducto values('PR000002','Lápiz Grafito','Lapices y portaminas','Lápiz Grafito Escolar Fantasía','Artesco',0.90,NULL,'ACTIVO', 0, 100, 10)
insert into TProducto values('PR000003','Diccionario Inglés - Español','Libros','Diccionario Tapa Dura Bilingüe Inglés - Español Plus','Norma',11.90,NULL,'ACTIVO', 0, 100, 10)
insert into TProducto values('PR000004','Papel Bulky A4','Papel y sobres','Papel Bulky A4 x 500 Hojas','Gallo',12.40,NULL,'ACTIVO', 0, 100, 10)
insert into TProducto values('PR000005','Papel Bond Premium A4','Papel y sobres','Papel Bond Premium A4 80 g Paquete x 500 Hojas','Stanford',10.90,NULL,'ACTIVO', 0, 100, 10)

--------- DATOS PROVEEDOR ----------------------
 insert into TProveedor values('PR001','Organizacion Book SAC','Calle Santa Rosa 456','963157845','distribudirasBook@gmail.com','ACTIVO')
 insert into TProveedor values('PR002','Genesis Group SA','Jiron San Pedro 1225','930654879','genesisg@gmail.com','ACTIVO')
 insert into TProveedor values('PR003','Smart Letter SAC','Urb. Los Angeles 564','980709063','smartLetter@gmail.com','ACTIVO')
 insert into TProveedor values('PR004','Distribuciones Mark SA','Jiron San Sebastian 125','930656879','Mark@gmail.com','ACTIVO')
 insert into TProveedor values('PR005','Papeleria Rolf','Urb. Mariscal Gamarra','984409063','Rolf@gmail.com','ACTIVO')
--------- DATOS USUARIOS ----------------------
insert into TUsuario values('US001','Carlos','Carreta','Me la pelas','936686352','Mudos@15asoc.com','huevos1','SUPERVISOR','ACTIVO')
insert into TUsuario values('US002','Quispe','Huchija Luigi','Me la pelas','936686352','GAaaa@15asoc.com','huevos1','SUPERVISOR','ACTIVO')
insert into TUsuario values('US003','Dolores','Waywa','Me la pelas','936686352','Solores@15asoc.com','huevos1','EMPLEADO','ACTIVO')
insert into TUsuario values('US004','Carlos','Carreta','Me la pelas','936686352','Mudos@15asoc.com','huevos1','EMPLEADO','ACTIVO')
insert into TUsuario values('US005','Quispe','Huchija Luigi','Me la pelas','936686352','GAaaa@15asoc.com','huevos1','EMPLEADO','ACTIVO')
insert into TUsuario values('US006','Dolores','Waywa','Me la pelas','936686352','Solores@15asoc.com','huevos1','EMPLEADO','ACTIVO')
--------- DATOS CLIENTE ----------------------
insert into TCliente values('CL000001','Jose','Carreta','El valle de la felicidad','936683452','Jose@15asoc.com')
insert into TCliente values('CL000002','Marco','Sudado Pinto','Que te importa','936456352','GAaaa@15asoc.com')
insert into TCliente values('CL000003','Pedro','Waywa','El abismo','936645652','TengoSueño@15asoc.com')
insert into TCliente values('CL000004','Carlos','Ascci','Quien sabe pero hay wifi wiii...','936656752','ElAbismo@15asoc.com')
insert into TCliente values('CL000005','Martin','plin plin plon','Detras de ti prro','933456352','Lobo@15asoc.com')
insert into TCliente values('CL000006','Juan','gwyn','A ver, no se, san algo nro algo?','936678952','Espada@15asoc.com')
--------- DATOS PEDIDO, PEDIDO DETALLE ----------------------
insert into TPedido values ('PE000001','PR001', 'US001', '15/08/2020', '15/08/2020', 'Buen estado')
insert into TPedidoDetalle values ('PE000001','PR000001',20, 5)
insert into TPedidoDetalle values ('PE000001','PR000002',24, 50)
--------- DATOS ENTRADA, ENTRADA DETALLE ----------------------
insert into TEntrada values ('EN000001','PR001', 'US002', '15/08/2020')
insert into TEntradaDetalle values ('EN000001','PR000001',8)
insert into TEntradaDetalle values ('EN000001','PR000002',15)
insert into TEntradaDetalle values ('EN000001','PR000003',23)
--------- DATOS VENTA ----------------------
insert into TVenta values ('VE000001','US006','CL000002','20/08/2020')
insert into TVentaDetalle values ('VE000001','PR000001',2,25.90)
insert into TVentaDetalle values ('VE000001','PR000003',1,11.90)

insert into TVenta values ('VE000002','US006','CL000005','20/08/2020')
insert into TVentaDetalle values ('VE000002','PR000001',2,25.90)
insert into TVentaDetalle values ('VE000002','PR000003',1,11.90)
insert into TVentaDetalle values ('VE000002','PR000005',9,10.90)
--------- DATOS DEVOLUCION ----------------------
insert into TDevolucion values ('DE000001','VE000001','20/08/2020')
insert into TDevolucionDetalle values ('DE000001','VE000001','PR000001',1,'Nuevo',25.90)

insert into TDevolucion values ('DE000002','VE000002','20/08/2020')
insert into TDevolucionDetalle values ('DE000002','VE000002','PR000005',6,'Desgastado',10.90)
