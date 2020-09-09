/*create procedure spuExisteClavePrimariaTNegocio @IdModificacion varchar(10)
as
begin
	select *
	from TNegocio
	where IdModificacion = @IdModificacion
end;
go*/

create procedure spuExisteClavePrimariaTNegocio @Id int
as
begin
select * 
	from TNegocio
	where IdModificacion = 0
end;
go