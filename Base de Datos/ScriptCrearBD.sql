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
  Imagen		varchar(MAX)NOT NULL,
  Estado        varchar(10) check (Estado in ('ACTIVO','RETIRADO','OTRO')),
  Cantidad 		int,
  Maximo		int,
  Minimo		int,
  PRIMARY KEY (IdProducto)
 )
 go

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
	IdCliente	TIdCliente NOT NULL,
	Fecha datetime,
	Descuento bit,
	IGV float,
	MontoSuperarDescuento float,
	PorcentajeDescuento float,
	primary key(IdVenta),
	foreign key(IdUsuario) references TUsuario(IdUsuario)
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
	IdUsuario	TIdUsuario NOT NULL,
	IdVenta TIdVenta,
	Razon varchar(100),
	Fecha datetime,
	primary key(IdDevolucion),
	foreign key(IdVenta) references TVenta(IdVenta),
)
go
create table TDevolucionDetalle
(
	IdDevolucion TIdDevolucion,
	IdProducto TIdProducto,
	Cantidad int,
	Estado varchar(12),
	PrecioUnitario float,
	primary key (IdDevolucion, IdProducto),
	foreign key(IdDevolucion) references TDevolucion(IdDevolucion),
	foreign key(IdProducto) references TProducto(IdProducto)
)
go

create table TNegocio
(
	IdModificacion int identity(0,1) not null,
	Nombre varchar(25),
	Logo varchar(MAX),
	Duegno varchar(40),
	RUC varchar(11),
	Telefono varchar(11),
	Correo varchar(30),
	Direccion varchar(35),
	IGV float,
	MontoSuperarDescuento float,
	PorcentajeDescuento float,
	Fecha date,
	primary key (IdModificacion)
)


create table TNotificaciones
(
	IdNotificacion int identity (0,1) not null,
	Mensaje varchar(150),
	Fecha datetime,
	Estado varchar(8) check(Estado in ('LEIDO', 'NO LEIDO'))
	primary key(IdNotificacion)
)
go
