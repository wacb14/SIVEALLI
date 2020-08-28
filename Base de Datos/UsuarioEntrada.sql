use DBAlmacen

create procedure spuExisteClavePrimariaTUsuario @IdUsuario varchar(8)
as
begin
	select * from TUsuario 
	where IdUsuario = @IdUsuario
end;
go


create procedure spuCodigoNombreProveedor
as
begin
	select IdProveedor, Nombre from TProveedores
end;
go
