
create procedure spuListarCatalogoProductos
as
begin
	select Tp.IdProducto,TP.Nombre,TP.Categoria,TP.Marca,TP.PrecioUnitario as Precio 
	from TProducto TP
	where TP.Estado ='ACTIVO'
end;
go

create procedure spuCantidadMax @IdProducto varchar(8)
as
begin
	select TP.Maximo, TP.Cantidad
	from TProducto TP
	where TP.IdProducto=@IdProducto
end;
go

create procedure spuListaProveedores 
as 
begin
	select P.IdProveedor,P.Nombre
	from TProveedor P
end;
go

create procedure spuExisteClavePrimariaTPedido @IdPedido varchar(8)
as
begin
	select * from TPedido
	where IdPedido = @IdPedido
end;
go

create procedure spuExisteIdTPedido @IdPedido varchar(40)
as
begin
	select * from TPedido
	where IdPedido = @IdPedido
end;
go

create procedure spuExisteIdTPedidoDetalle @IdPedido varchar(40)
as
begin
	select * from TPedidoDetalle
	where IdPedido = @IdPedido
end;
go

--spuListaProveedores
--spuCantidadMax 'PR000001'
--spuListarCatalogoProductos