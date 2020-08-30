
-- Para ventas
--------------- Mostrador
if exists (select * from sysobjects where name='spuReporteVentasPorFecha') 
	drop procedure spuReporteVentasPorFecha
go
create procedure spuReporteVentasPorFecha @Fecha date, @Fecha2 date
as
begin
	select TVenta.IdVenta, TVenta.IdUsuario, TUsuario.Apellidos, TUsuario.Nombres ,
	TVenta.IdCliente, TCliente.Apellidos ,TCliente.Nombres , 
	TVentaDetalle.IdProducto,TVentaDetalle.Cantidad,TVentaDetalle.PrecioUnitario ,TVenta.Fecha
	from TVenta
		inner join TVentaDetalle  on TVenta.IdVenta=TVentaDetalle.IdVenta
		inner join TCliente on TVenta.IdCliente=TCliente.IdCliente
		inner join TUsuario on TVenta.IdUsuario=TUsuario.IdUsuario
	
	where TVenta.Fecha between @Fecha and @Fecha2
end;
go
--------------- Contador
if exists (select * from sysobjects where name='spuNumeroDeVentas') 
	drop procedure spuNumeroDeVentas
go
create procedure spuNumeroDeVentas
as
begin
	select count(IdVenta) as NumeroVentas
		FROM TVenta
end;
go

-------------------------------------------------------------------------------------------------------
-- Para devoluciones
--------------- Mostrador
if exists (select * from sysobjects where name='spuReporteDevolucionesPorFecha') 
	drop procedure spuReporteDevolucionesPorFecha
go
create procedure spuReporteDevolucionesPorFecha @Fecha date, @Fecha2 date
as
begin
	select TDevolucion.IdDevolucion, TDevolucion.IdVenta,TDevolucionDetalle.IdProducto,TProducto.Nombre ,
	 TDevolucionDetalle.Cantidad,TDevolucionDetalle.Estado,TDevolucionDetalle.PrecioUnitario ,TDevolucion.Fecha
	from TDevolucionDetalle 
		inner join TDevolucion on TDevolucion.IdVenta=TDevolucionDetalle.IdVenta 
		inner join TProducto on TDevolucionDetalle.IdProducto=TProducto.IdProducto
	where TDevolucion.Fecha between @Fecha and @Fecha2
end;
go
--------------- Contador
if exists (select * from sysobjects where name='spuNumeroDeDevoluciones') 
	drop procedure spuNumeroDeDevoluciones
go
create procedure spuNumeroDeDevoluciones
as
begin
	select count(IdDevolucion) as NumeroDevoluciones
		FROM TDevolucion
end;
go

-------------------------------------------------------------------------------------------------------
-- Para Entradas
--------------- Mostrador
if exists (select * from sysobjects where name='spuReporteEntradasPorFecha') 
	drop procedure spuReporteEntradasPorFecha
go
create procedure spuReporteEntradasPorFecha @Fecha date, @Fecha2 date
as
begin
	select TEntrada.IdEntrada,TEntrada.IdProveedor, TProveedor.Nombre ,
	TEntrada.IdUsuario, TUsuario.Apellidos , TUsuario.Nombres ,
	TEntradaDetalle.IdProducto, TProducto.Nombre ,TEntradaDetalle.Cantidad,TEntrada.Fecha
	from TEntrada
		inner join TEntradaDetalle on TEntrada.IdEntrada=TEntradaDetalle.IdEntrada
		inner join TProveedor on TEntrada.IdProveedor=TProveedor.IdProveedor
		inner join TUsuario on TEntrada.IdUsuario=TUsuario.IdUsuario
		inner join TProducto on TEntradaDetalle.IdProducto= TProducto.IdProducto
	where TEntrada.Fecha between @Fecha and @Fecha2
end;
go
--------------- Contador
if exists (select * from sysobjects where name='spuNumeroDeEntradas') 
	drop procedure spuNumeroDeEntradas
go
create procedure spuNumeroDeEntradas
as
begin
	select count(IdEntrada) as NumeroEntradas
		FROM TEntrada
end;
go

-------------------------------------------------------------------------------------------------------
-- Para Pedidos
--------------- Mostrador
if exists (select * from sysobjects where name='spuReportePedidosPorFecha') 
	drop procedure spuReportePedidosPorFecha
go
create procedure spuReportePedidosPorFecha @Fecha date, @Fecha2 date
as
begin
	select TPedido.IdPedido,TPedido.IdProveedor, TProveedor.Nombre ,
	TPedido.IdUsuario, TUsuario.Apellidos , TUsuario.Nombres ,
	TPedidoDetalle.IdProducto, TProducto.Nombre ,TPedidoDetalle.Cantidad,TPedidoDetalle.PrecioUnitario ,
	TPedido.FechaPedido , TPedido.FechaPago ,TPedido.TerminosEntrega 
	from TPedido
		inner join TPedidoDetalle on TPedido.IdPedido=TPedidoDetalle.IdPedido
		inner join TProveedor on TPedido.IdProveedor=TProveedor.IdProveedor
		inner join TUsuario on TPedido.IdUsuario=TUsuario.IdUsuario
		inner join TProducto on TPedidoDetalle.IdProducto= TProducto.IdProducto
	where TPedido.FechaPedido between @Fecha and @Fecha2
end;
go

--------------- Contador
if exists (select * from sysobjects where name='spuNumeroDePedidos') 
	drop procedure spuNumeroDePedidos
go
create procedure spuNumeroDePedidos
as
begin
	select count(IdPedido) as NumeroPedidos
		FROM TPedido
end;
go
-------------------------------------------------------------------------------------------------------
-- Ya se tiene los metodos para listar para el resto de tablas
-------------------------------------------------------------------------------------------------------
-- Usuario spu_TUsuario_Listar
--------------- Contador
if exists (select * from sysobjects where name='spuNumeroDeUsuarios') 
	drop procedure spuNumeroDeUsuarios
go
create procedure spuNumeroDeUsuarios
as
begin
	select count(IdUsuario) as NumeroUsuarios
		FROM TUsuario
end;
go
-------------------------------------------------------------------------------------------------------
-- Proveedores spu_TProveedor_Listar
--------------- Contador
if exists (select * from sysobjects where name='spuNumeroDeProveedores') 
	drop procedure spuNumeroDeProveedores
go
create procedure spuNumeroDeProveedores
as
begin
	select count(IdProveedor) as NumeroProveedores
		FROM TProveedor
end;
go
-------------------------------------------------------------------------------------------------------
-- Clientes spu_TCliente_Listar
--------------- Contador
if exists (select * from sysobjects where name='spuNumeroDeClientes') 
	drop procedure spuNumeroDeClientes
go
create procedure spuNumeroDeClientes
as
begin
	select count(IdCliente) as NumeroClientes
		FROM TCliente
end;
go
-------------------------------------------------------------------------------------------------------
-- Productos spuListarProductosSinImagen
--------------- Contador
if exists (select * from sysobjects where name='spuNumeroDeProductos') 
	drop procedure spuNumeroDeProductos
go
create procedure spuNumeroDeProductos
as
begin
	select count(IdProducto) as NumeroProductos
		FROM TProducto
end;
go
-------------------------------------------------------------------------------------------------------


exec spuReporteVentasPorFecha '2020/07/20','2020/08/20'
exec spuReporteDevolucionesPorFecha '2020/07/20','2020/08/20'
exec spuReporteEntradasPorFecha '2020/07/20','2020/08/20'
exec spuReportePedidosPorFecha '2020/07/20','2020/08/20'
exec spuNumeroDeVentas
exec spuNumeroDeDevoluciones
exec spuNumeroDeEntradas
exec spuNumeroDePedidos

exec spu_TUsuario_Listar
exec spu_TProveedor_Listar
exec spu_TCliente_Listar
exec spuListarProductosSinImagen
/* CON NOMBES
-- Para ventas
if exists (select * from sysobjects where name='spuReporteVentasPorFecha') 
	drop procedure spuReporteVentasPorFecha
go
create procedure spuReporteVentasPorFecha @Fecha date, @Fecha2 date
as
begin
	select TVenta.IdVenta, TVenta.IdUsuario, TUsuario.Apellidos as 'Apellidos Supervisor', TUsuario.Nombres as 'Nombres Supervisor',
	TVenta.IdCliente, TCliente.Apellidos as 'Apellidos Cliente',TCliente.Nombres as 'Nombres Cliente', 
	TVentaDetalle.IdProducto,TVentaDetalle.Cantidad,TVentaDetalle.PrecioUnitario as 'Precio Unitario',TVenta.Fecha
	from TVenta
		inner join TVentaDetalle  on TVenta.IdVenta=TVentaDetalle.IdVenta
		inner join TCliente on TVenta.IdCliente=TCliente.IdCliente
		inner join TUsuario on TVenta.IdUsuario=TUsuario.IdUsuario
	
	where TVenta.Fecha between @Fecha and @Fecha2
end;
go

-- Para devoluciones
if exists (select * from sysobjects where name='spuReporteDevolucionesPorFecha') 
	drop procedure spuReporteDevolucionesPorFecha
go
create procedure spuReporteDevolucionesPorFecha @Fecha date, @Fecha2 date
as
begin
	select TDevolucion.IdDevolucion, TDevolucion.IdVenta,TDevolucionDetalle.IdProducto,TProducto.Nombre as 'Nombre de Producto',
	 TDevolucionDetalle.Cantidad,TDevolucionDetalle.Estado,TDevolucionDetalle.PrecioUnitario as 'Precio Unitario',TDevolucion.Fecha
	from TDevolucionDetalle 
		inner join TDevolucion on TDevolucion.IdVenta=TDevolucionDetalle.IdVenta 
		inner join TProducto on TDevolucionDetalle.IdProducto=TProducto.IdProducto
	where TDevolucion.Fecha between @Fecha and @Fecha2
end;
go

-- Para Entradas
if exists (select * from sysobjects where name='spuReporteEntradasPorFecha') 
	drop procedure spuReporteEntradasPorFecha
go
create procedure spuReporteEntradasPorFecha @Fecha date, @Fecha2 date
as
begin
	select TEntrada.IdEntrada,TEntrada.IdProveedor, TProveedor.Nombre as 'Nombre Proveedor',
	TEntrada.IdUsuario, TUsuario.Apellidos as 'Apellidos Supervisor', TUsuario.Nombres as 'Nombres Supervisor',
	TEntradaDetalle.IdProducto, TProducto.Nombre as 'Nombre de Producto',TEntradaDetalle.Cantidad,TEntrada.Fecha
	from TEntrada
		inner join TEntradaDetalle on TEntrada.IdEntrada=TEntradaDetalle.IdEntrada
		inner join TProveedor on TEntrada.IdProveedor=TProveedor.IdProveedor
		inner join TUsuario on TEntrada.IdUsuario=TUsuario.IdUsuario
		inner join TProducto on TEntradaDetalle.IdProducto= TProducto.IdProducto
	where TEntrada.Fecha between @Fecha and @Fecha2
end;
go

-- Para Pedidos
if exists (select * from sysobjects where name='spuReportePedidosPorFecha') 
	drop procedure spuReportePedidosPorFecha
go
create procedure spuReportePedidosPorFecha @Fecha date, @Fecha2 date
as
begin
	select TPedido.IdPedido,TPedido.IdProveedor, TProveedor.Nombre as 'Nombre Proveedor',
	TPedido.IdUsuario, TUsuario.Apellidos as 'Apellidos Supervisor', TUsuario.Nombres as 'Nombres Supervisor',
	TPedidoDetalle.IdProducto, TProducto.Nombre as 'Nombre de Producto',TPedidoDetalle.Cantidad,TPedidoDetalle.PrecioUnitario as 'Precio Unitario',
	TPedido.FechaPedido as 'Fecha de Pedido', TPedido.FechaPago as 'Fecha de Pago',TPedido.TerminosEntrega as 'Terminos de Entrega'
	from TPedido
		inner join TPedidoDetalle on TPedido.IdPedido=TPedidoDetalle.IdPedido
		inner join TProveedor on TPedido.IdProveedor=TProveedor.IdProveedor
		inner join TUsuario on TPedido.IdUsuario=TUsuario.IdUsuario
		inner join TProducto on TPedidoDetalle.IdProducto= TProducto.IdProducto
	where TPedido.FechaPedido between @Fecha and @Fecha2
end;
go

*/