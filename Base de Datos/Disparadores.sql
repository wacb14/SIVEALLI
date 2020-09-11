-------------------------------------------------------------------------- disparador entrada
create trigger triggerEntradaProducto on TEntradaDetalle for insert
as
declare @codigoProducto varchar(8)
declare @cantidadAumentada int
select @codigoProducto = IdProducto from inserted
select @cantidadAumentada = Cantidad from inserted
declare @cantidadAntes int
select @cantidadAntes = Cantidad from TProducto
where IdProducto = @codigoProducto

update TProducto
set Cantidad = @cantidadAntes + @cantidadAumentada
where IdProducto = @codigoProducto
go



-----------------------------------------------------------------
create trigger triggerAgregarModificacionTNegocio on TNegocio for insert
as
declare @Nombre varchar(25)
declare @Duegno varchar(40)
declare @RUC varchar(11)
declare @Telefono varchar(11)
declare @Correo varchar(30)
declare @Direccion varchar(35)
declare @IGV float
declare @MontoSuperarDescuento float
declare @Fecha date
declare @IdModificacion int
declare @PorcentajeDescuento float

select @Nombre  = Nombre from inserted
select @Duegno  = Duegno from inserted
select @RUC  = RUC from inserted
select @Telefono  = Telefono from inserted
select @Correo  =  Correo from inserted
select @Direccion  =  Direccion from inserted
select @IGV  =  IGV from inserted
select @MontoSuperarDescuento  =  MontoSuperarDescuento from inserted
select @PorcentajeDescuento  =  PorcentajeDescuento from inserted
select @Fecha  =  Fecha from inserted

update TNegocio
set Nombre  = @Nombre, Duegno  = @Duegno, RUC  = @RUC , Telefono  = @Telefono, Correo  =  @Correo, 
Direccion  =  @Direccion,  IGV  =  @IGV, MontoSuperarDescuento  =  @MontoSuperarDescuento ,Fecha =  @Fecha, 
PorcentajeDescuento  =  @PorcentajeDescuento
where IdModificacion = 1 --en el primer registro
go


------------------------------------------------------------------------------------------------------
