create procedure spuExisteClavePrimariaTNegocio @Id int
as
begin
select * 
	from TNegocio
	where IdModificacion = @Id
end;
go