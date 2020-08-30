create procedure spuListadoCodigoProductos
as
begin
select IdProducto from TProducto
end;
go

create procedure spuDatosProductoEntrada @IdProducto varchar(8)
as
begin
select IdProducto, Nombre, Categoria, Marca, PrecioUnitario from TProducto
where IdProducto = @IdProducto
end;
go

create procedure spuExisteClavePrimariaTUsuario @IdUsuario varchar(8)
as
begin
	select * from TUsuario 
	where IdUsuario = @IdUsuario
end;
go


create procedure spuCodigoNombreProveedor
as
begin
	select IdProveedor, Nombre from TProveedores
end;
go

create procedure spuExisteClavePrimariaTEntrada @IdEntrada varchar(8)
as
begin
	select * from TEntrada
	where IdEntrada = @IdEntrada 
end;
go
