create procedure spuListadoCodigoProductos
as
begin
select IdProducto from TProducto
end;
go

create procedure spuDatosProductoEntrada @IdProducto varchar(8)
as
begin
select IdProducto, Nombre, Categoria, Marca, PrecioUnitario from TProducto
where IdProducto = @IdProducto
end;
go

create procedure spuExisteClavePrimariaTUsuario @IdUsuario varchar(8)
as
begin
	select * from TUsuario 
	where IdUsuario = @IdUsuario
end;
go

create procedure spuCodigoNombreProveedores
as
begin
	select IdProveedor, Nombre from TProveedor
end;
go

create procedure spuExisteClavePrimariaTEntrada @IdEntrada varchar(8)
as
begin
	select * from TEntrada
	where IdEntrada = @IdEntrada 
end;
go

create procedure spuListadoCodigoEntradas
as
begin
select IdEntrada from TEntrada
end;
go

create procedure spuTEntradaDetalleListaCod @IdEntrada varchar(8)
as
begin
select * from TEntradaDetalle
where IdEntrada = @IdEntrada
end;
go

create procedure ListaUsuariosSinContragna
as
begin
select IdUsuario, Nombres, Apellidos, Telefono, Correo, Estado, Tipo, Direccion 
	from TUsuario
end;
go

create procedure spu_TUsuario_Modificar_SinContrsegna
	@IdUsuario varchar(5),
	@Nombres varchar(20),
	@Apellidos varchar(20),
	@Direccion varchar(35),
	@Telefono varchar(12),
	@Correo varchar(40),
	@Tipo varchar(10),
	@Estado varchar(10)
as
begin  --verificacion de clave primaria
	if exists (select * from TUsuario where IdUsuario = @IdUsuario)
	begin
		update TUsuario
		set IdUsuario = @IdUsuario, Nombres = @Nombres, Apellidos = @Apellidos, Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo, Tipo = @Tipo, Estado = @Estado
		where IdUsuario = @IdUsuario
		select codError = 0, mensaje = 'TUsuario actualizado correctamente'
	end;
	else
		select codError = 1, mensaje = 'El objeto TUsuario no existe'
	end;
go


create procedure RestaurarContrasegna @IdUsuario varchar(5)
as
begin
	if exists (select * from TUsuario where IdUsuario = @IdUsuario)
	begin
		update TUsuario
		set Contraseña = @IdUsuario
		where IdUsuario = @IdUsuario
		select codError = 0, mensaje = 'No se pudo realizar la operacion'
	end;
	else
		select codError = 1, mensaje = 'El objeto TUsuario no existe'
	end;
go

create procedure ObtenerContrasegna @IdUsuario varchar(5)
as
begin
	if exists (select * from TUsuario where IdUsuario = @IdUsuario)
	begin
		select Contraseña from TUsuario
		where IdUsuario = @IdUsuario
	end;
	else
		select codError = 1, mensaje = 'El objeto TUsuario no existe'
end;
go



create procedure CambiarContrasegna @IdUsuario varchar(5), @Contrasegna varchar(12)
as
begin
	if exists (select * from TUsuario where IdUsuario = @IdUsuario)
	begin
		update TUsuario
		set Contraseña = @Contrasegna
		where IdUsuario = @IdUsuario
		select codError = 0, mensaje = 'No se pudo realizar la operacion'
	end;
	else
		select codError = 1, mensaje = 'El objeto TUsuario no existe'
end;
go

