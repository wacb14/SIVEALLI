if exists (select * from sysobjects where name='spuTraerHistorialVentas') 
	drop procedure spuTraerHistorialVentas
go
create procedure spuTraerHistorialVentas
as
begin
	select tv.IdVenta,tv.IdUsuario,tv.IdCliente,(tc.Nombres +' '+ tc.Apellidos) as 'Nombres',tv.Fecha
	from TVenta tv inner join TCliente tc on tv.IdCliente=tc.IdCliente
end;
go
-----------------------------------------------------------------------------------------
if exists (select * from sysobjects where name='spuDatosVenta') 
	drop procedure spuDatosVenta
go
create procedure spuDatosVenta @IdVenta varchar(8)
as
begin
	select tvd.IdProducto,tp.Nombre,tvd.PrecioUnitario,tvd.Cantidad,(tvd.PrecioUnitario*tvd.Cantidad) as 'subTotal'
	from TVentaDetalle tvd inner join TProducto tp on tvd.IdProducto=tp.IdProducto 
	where IdVenta=@IdVenta
end;
go