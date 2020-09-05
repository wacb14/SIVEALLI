delete from TVentaDetalle
delete from TVenta

alter table TVenta
add Descuento bit not null;
go

alter table TVenta
add IGV float not null;
go

--drop table TNegocio

create table TNegocio
(
	IdModificacion int identity(0,1) not null,
	Nombre varchar(25),
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
