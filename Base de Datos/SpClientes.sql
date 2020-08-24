create procedure spuExisteClavePrimariaTCliente @IdCliente varchar(8)
as
begin
	select * from TCliente
	where Idcliente = @IdCliente
end;
go
create procedure spuExisteNombreTCliente @Nombres varchar(40)
as
begin
	select * from TCliente
	where Nombres = @Nombres
end;
go
create procedure spuExisteApellidoTCliente @Apellidos varchar(40)
as
begin
	select * from TCliente
	where Apellidos = @Apellidos
end;
go
create procedure spuExisteDireccionTCliente @Direccion varchar(40)
as
begin
	select * from TCliente
	where Direccion = @Direccion
end;
go