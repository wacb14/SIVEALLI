--Cambio ventas (igv, descuento)
--Adicion tabla TNegocio

delete from TVentaDetalle
delete from TVenta

alter table TVenta
add Descuento bit not null;
go

alter table TVenta
add IGV float not null;
go


create table TNegocio
(
	Nombre varchar(25),
	FechaInicio date,
	Duegno varchar(40),
	RUC varchar(11),
	Telefono varchar(11),
	Correo varchar(30),
	Direccion varchar(35),
	IGV float,
	MontoDescuento float,
)
-----------------------------------------------------------
-----------------------------------------------------------
--Modificacion tabla negocio

alter table TNegocio
add IdModificacion int identity(0,1) not null;
go

alter table TNegocio
drop column FechaInicio;
go

alter table TNegocio
add Fecha date not null;
go

alter table TNegocio
add primary key (IdModificacion);
go
