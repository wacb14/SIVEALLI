
alter procedure spuListarCatalogoProductos
as
begin
	select Tp.IdProducto,TP.Nombre,TP.Categoria,TP.Marca,TP.PrecioUnitario as Precio 
	from TProducto TP
	where TP.Estado ='ACTIVO'
end;
go

spuListarCatalogoProductos