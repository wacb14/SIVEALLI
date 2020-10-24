create procedure MensajesNoLeidos
as
begin 
	select * from TNotificaciones
	where Estado = 'NO LEIDO'
end;

create procedure MarcarComoLeido @idNotificacion int
as
begin
	update TNotificaciones
	set Estado = 'LEIDO'
	where IdNotificacion = @idNotificacion
end;
go

create procedure MensajesLeidos
as begin
	select * from TNotificaciones
	where Estado = 'LEIDO'
end;
go


create procedure BorrarMensajeLeidos
as
begin
	delete from TNotificaciones
	where Estado = 'LEIDO'
end;
