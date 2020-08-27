
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

--spuListaProveedores
--spuCantidadMax 'PR000001'
--spuListarCatalogoProductos