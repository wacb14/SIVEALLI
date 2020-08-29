------------------- VALIDACION PROVEEDOR -------------------
create procedure spuExisteClavePrimariaTProveedor @IdProveedor varchar(8)
as
begin
	select * from TProveedor
	where IdProveedor = @IdProveedor
end;
go

create procedure spuRegistroTProveedor @IdProveedor varchar(8)
as
begin
	select * from TProveedor
	where IdProveedor = @IdProveedor
end;
go