create procedure spuExisteClavePrimariaTNegocio @IdModificacion varchar(10)
as
begin
	select *
	from TNegocio
	where IdModificacion = @IdModificacion
end;
go