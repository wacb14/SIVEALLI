if exists (select * from sysobjects where name='spuListarCatalogoProductos') 
	drop procedure spuListarCatalogoProductos
go
create procedure spuListarCatalogoProductos
as
begin
	select Tp.IdProducto,TP.Nombre,TP.Categoria,TP.Marca,TP.PrecioUnitario as Precio,TP.Estado 
	from TProducto TP
	where TP.Estado ='ACTIVO'
end;
go

if exists (select * from sysobjects where name='spuCantidadMax') 
	drop procedure spuCantidadMax
go
create procedure spuCantidadMax @IdProducto varchar(8)
as
begin
	select TP.Maximo, TP.Cantidad
	from TProducto TP
	where TP.IdProducto=@IdProducto
end;
go

if exists (select * from sysobjects where name='spuListaProveedores') 
	drop procedure spuListaProveedores
go
create procedure spuListaProveedores 
as 
begin
	select P.IdProveedor,P.Nombre
	from TProveedor P
end;
go

if exists (select * from sysobjects where name='spuExisteClavePrimariaTPedido') 
	drop procedure spuExisteClavePrimariaTPedido
go
create procedure spuExisteClavePrimariaTPedido @IdPedido varchar(8)
as
begin
	select * from TPedido
	where IdPedido = @IdPedido
end;
go

if exists (select * from sysobjects where name='spuExisteClavePrimariaTPedidoDetalle') 
	drop procedure spuExisteClavePrimariaTPedidoDetalle
go
create procedure spuExisteClavePrimariaTPedidoDetalle @IdPedido varchar(8),@IdProducto varchar(8)
as
begin
	select * from TPedidoDetalle
	where IdPedido = @IdPedido and IdProducto=@IdProducto
end;
go

if exists (select * from sysobjects where name='spuExisteIdTPedido') 
	drop procedure spuExisteIdTPedido
go
create procedure spuExisteIdTPedido @IdPedido varchar(40)
as
begin
	select * from TPedido
	where IdPedido = @IdPedido
end;
go

if exists (select * from sysobjects where name='spuExisteIdTPedidoDetalle') 
	drop procedure spuExisteIdTPedidoDetalle
go
create procedure spuExisteIdTPedidoDetalle @IdPedido varchar(40)
as
begin
	select * from TPedidoDetalle
	where IdPedido = @IdPedido
end;
go