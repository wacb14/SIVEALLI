create procedure spuNumeroDeVentas
as
begin
	select count(IdVenta) as NumeroVentas
		FROM TVenta
end;
go