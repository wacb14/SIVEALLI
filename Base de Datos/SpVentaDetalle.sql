create procedure spuVentaDetalleListarDetallesDeUnaVenta @IdVenta varchar(8)
as
begin
	select V.IdProducto,P.Nombre,V.PrecioUnitario,V.Cantidad,ROUND(V.Cantidad*V.PrecioUnitario,2)as Subtotal
	from TVentaDetalle V INNER JOIN TProducto P on V.IdProducto=P.IdProducto
	where V.IdVenta=@IdVenta
end;
go