-------------------------------------------------------------------------------------
if exists (select * from sysobjects where name='spuTraerDatosDeLaVentas') 
	drop procedure spuTraerDatosDeLaVentas
go
create procedure spuTraerDatosDeLaVentas @IdVenta varchar(8)
as
begin
	select tv.IdVenta,tv.IdUsuario,tv.IdCliente,(tc.Nombres +' '+ tc.Apellidos) as 'Nombres',tv.Fecha,tv.Descuento,tv.IGV,tv.PorcentajeDescuento
	from TVenta tv inner join TCliente tc on tv.IdCliente=tc.IdCliente
	where tv.IdVenta=@IdVenta
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
----------------------------------------------------------------------------------------------------------
if exists (select * from sysobjects where name='spuExisteIdTDevolucion') 
	drop procedure spuExisteIdTDevolucion
go
create procedure spuExisteIdTDevolucion @IdDevolucion varchar(8)
as
begin
	select * from TDevolucion
	where IdDevolucion = @IdDevolucion
end;
go
----------------------------------------------------------------------------------
if exists (select * from sysobjects where name='spuExisteIdTDevolucionDetalle') 
	drop procedure spuExisteIdTDevolucionDetalle
go
create procedure spuExisteIdTDevolucionDetalle @IdDevolucion varchar(8)
as
begin
	select * from TDevolucionDetalle
	where IdDevolucion = @IdDevolucion
end;
go
---------------------------------------------------------------------------------------------

if exists (select * from sysobjects where name='spuExisteIdTDevolucionDetalle2') 
	drop procedure spuExisteIdTDevolucionDetalle2
go
create procedure spuExisteIdTDevolucionDetalle2 @IdDevolucion varchar(8)
as
begin
	declare @IdVenta varchar(8)
	select td.IdDevolucion,tdd.IdProducto,tdd.Cantidad,tdd.Estado,tdd.PrecioUnitario,td.IdVenta 
		into #TabTemp
		from TDevolucion td left outer join TDevolucionDetalle tdd on td.IdDevolucion=tdd.IdDevolucion
		where td.IdDevolucion=@IdDevolucion
	select @IdVenta=IdVenta from #TabTemp
	select tt.IdDevolucion,tvd.IdProducto,case when tt.Estado is NULL then tvd.Cantidad else tt.Cantidad end as 'Cantidad',tt.Estado,tvd.PrecioUnitario,tvd.Cantidad as Cant
		from #TabTemp tt right outer join TVentaDetalle tvd on tt.IdProducto=tvd.IdProducto
		where tvd.IdVenta=@IdVenta
end;
go
-----------------------------------------------------------------------------------------------------
if exists (select * from sysobjects where name='spuExisteClavePrimariaTDevolucion') 
	drop procedure spuExisteClavePrimariaTDevolucion
go
create procedure spuExisteClavePrimariaTDevolucion @IdDevolucion varchar(8)
as
begin
	select * from TDevolucion
	where IdDevolucion=@IdDevolucion
end;
go
------------------------------------------------------------------------------------------------
if exists (select * from sysobjects where name='spuExisteClavePrimariaTDevolucionDetalle') 
	drop procedure spuExisteClavePrimariaTDevolucionDetalle
go
create procedure spuExisteClavePrimariaTDevolucionDetalle @IdDevolucion varchar(8),@IdProducto varchar(8)
as
begin
	select * from TDevolucionDetalle
	where IdDevolucion = @IdDevolucion and IdProducto=@IdProducto
end;
go
