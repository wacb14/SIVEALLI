create procedure spuExisteClavePrimariaTVenta @IdVenta varchar(8)
as
begin
	select *
	from TVenta
	where IdVenta = @IdVenta
end;
go
create procedure spuNumeroDeVentas
as
begin
	select count(IdVenta) as NumeroVentas
		FROM TVenta
end;
go

create procedure spuVentasListarPorIdVenta @IdVenta varchar(8)
as
begin
	select IdVenta,IdUsuario,IdCliente,Fecha
	from TVenta
	where IdVenta = @IdVenta
end;
go
create procedure spuVentasListarPorIdUsuario @IdUsuario varchar(5)
as
begin
	select IdVenta,IdUsuario,IdCliente,Fecha
	from TVenta
	where IdUsuario = @IdUsuario
end;
go
create procedure spuVentasListarPorIdCliente @IdCliente varchar(8)
as
begin
	select IdVenta,IdUsuario,IdCliente,Fecha
	from TVenta
	where IdCliente = @IdCliente
end;
go
create procedure spuVentasListarPorFecha @Fecha varchar(10)
as
begin
	set dateformat dmy
	select IdVenta,IdUsuario,IdCliente,Fecha
	from TVenta
	where Fecha = @Fecha
end;
go
