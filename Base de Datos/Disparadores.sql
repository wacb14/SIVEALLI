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
