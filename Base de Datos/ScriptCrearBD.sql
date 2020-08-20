/* Create DataBase */
Create DATABASE DBAlmacen  -- Creates the Almacenes DataBase
on
  (NAME = DBAlmacen,    -- Primary data file
  FILENAME = 'D:\DBAlmacen.mdf',
  SIZE = 5MB,
  FILEGROWTH = 1MB
  )
  LOG ON
  (NAME = DBAlmacen_Log,   -- Log file
  FILENAME = 'D:\DBAlmacen.ldf',
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


/* Activar la Base de datos DBAlmacenes */
use DBAlmacen
go

/* Crear las tablas */

create table TProducto(
  IdProducto   TIdProducto NOT NULL,
  Nombre		varchar(40) NOT NULL,
  Categoria		varchar(20) NOT NULL,
  Descripcion	varchar(500) NOT NULL,
  Marca			varchar(20) NOT NULL,
  PrecioUnitario float NOT NULL,
  Imagen		varchar(40) NOT NULL,
  Estado          varchar(10) check (Estado in ('ACTIVO','RETIRADO','OTRO')),
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

---------- DATOS PRODUCTO ----------------------
insert into TProducto values('PR000001','Portaminas Mars','Lapices y portaminas','Portaminas Mars Technico 780 HB con Clip','Staedtler',25.90,'--','ACTIVO')
insert into TProducto values('PR000002','Lápiz Grafito','Lapices y portaminas','Lápiz Grafito Escolar Fantasía','Artesco',0.90,'--','ACTIVO')
insert into TProducto values('PR000003','Diccionario Inglés - Español','Libros','Diccionario Tapa Dura Bilingüe Inglés - Español Plus','Norma',11.90,'--','ACTIVO')
insert into TProducto values('PR000004','Papel Bulky A4','Papel y sobres','Papel Bulky A4 x 500 Hojas','Gallo',12.40','--','ACTIVO')
insert into TProducto values('PR000005','Papel Bond Premium A4','Papel y sobres','Papel Bond Premium A4 80 g Paquete x 500 Hojas','Stanford',10.90,'--','ACTIVO')
--------- DATOS PROVEEDOR ----------------------
 insert into TProveedor values('PR001','Organizacion Book SAC','Calle Santa Rosa 456','963157845','distribudirasBook@gmail.com','ACTIVO')
 insert into TProveedor values('PR002','Genesis Group SA','Jiron San Pedro 1225','930654879','genesisg@gmail.com','ACTIVO')
 insert into TProveedor values('PR003','Smart Letter SAC','Urb. Los Angeles 564','980709063','smartLetter@gmail.com','ACTIVO')
 insert into TProveedor values('PR004','Distribuciones Mark SA','Jiron San Sebastian 125','930656879','Mark@gmail.com','ACTIVO')
 insert into TProveedor values('PR005','Papeleria Rolf','Urb. Mariscal Gamarra','984409063','Rolf@gmail.com','ACTIVO')
--------- DATOS USUARIOS ----------------------
insert into TUsuario values('US001','Carlos','Carreta','Me la pelas','936686352','Mudos@15asoc.com','huevos1','ACTIVO')
insert into TUsuario values('US002','Quispe','Huchija Luigi','Me la pelas','936686352','GAaaa@15asoc.com','huevos1','ACTIVO')
insert into TUsuario values('US003','Dolores','Waywa','Me la pelas','936686352','Solores@15asoc.com','huevos1','ACTIVO')
insert into TUsuario values('US004','Carlos','Carreta','Me la pelas','936686352','Mudos@15asoc.com','huevos1','ACTIVO')
insert into TUsuario values('US005','Quispe','Huchija Luigi','Me la pelas','936686352','GAaaa@15asoc.com','huevos1','ACTIVO')
insert into TUsuario values('US006','Dolores','Waywa','Me la pelas','936686352','Solores@15asoc.com','huevos1','ACTIVO')
--------- DATOS CLIENTE ----------------------
insert into TCliente values('CL000001','Jose','Carreta','El valle de la felicidad','936683452','Jose@15asoc.com')
insert into TCliente values('CL000002','Marco','Sudado Pinto','Que te importa','936456352','GAaaa@15asoc.com')
insert into TCliente values('CL000003','Pedro','Waywa','El abismo','936645652','TengoSueño@15asoc.com')
insert into TCliente values('CL000004','Carlos','Ascci','Quien sabe pero hay wifi wiii...','936656752','ElAbismo@15asoc.com')
insert into TCliente values('CL000005','Martin','plin plin plon','Detras de ti prro','933456352','Lobo@15asoc.com')
insert into TCliente values('CL000006','Juan','gwyn','A ver, no se, san algo nro algo?','936678952','Espada@15asoc.com')
