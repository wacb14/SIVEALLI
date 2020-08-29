-------------------------------------------------------------------------------------------------------------- TProducto
-------------------------------------------------------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------Insertar
if exists (select * from sysobjects where name='spu_TProducto_Insertar') 
	drop procedure spu_TProducto_Insertar
go

create procedure spu_TProducto_Insertar
	@IdProducto varchar(8),
	@Nombre varchar(40),
	@Categoria varchar(20),
	@Descripcion varchar(500),
	@Marca varchar(20),
	@PrecioUnitario float,
	@Imagen varchar(MAX),
	@Estado varchar(10),
	@Cantidad int,
	@Maximo int,
	@Minimo int
as
begin  --verificacion de clave primaria
	if not exists (select * from TProducto where IdProducto = @IdProducto)
	begin
		insert into TProducto values (@IdProducto, @Nombre, @Categoria, @Descripcion, @Marca, @PrecioUnitario, @Imagen, @Estado, @Cantidad, @Maximo, @Minimo)
		select codError = 0, mensaje = 'TProducto insertado correctamente'
	end;
	else
		select codError = 1, mensaje = 'El objeto TProducto ya existe'
end;
go
-----------------------------------------------------------------------------------------------------Modificar
if exists (select * from sysobjects where name='spu_TProducto_Modificar') 
	drop procedure spu_TProducto_Modificar
go

create procedure spu_TProducto_Modificar
	@IdProducto varchar(8),
	@Nombre varchar(40),
	@Categoria varchar(20),
	@Descripcion varchar(500),
	@Marca varchar(20),
	@PrecioUnitario float,
	@Imagen varchar(MAX),
	@Estado varchar(10),
	@Cantidad int,
	@Maximo int,
	@Minimo int
as
begin  --verificacion de clave primaria
	if exists (select * from TProducto where IdProducto = @IdProducto)
	begin
		update TProducto
		set IdProducto = @IdProducto, Nombre = @Nombre, Categoria = @Categoria, Descripcion = @Descripcion, Marca = @Marca, PrecioUnitario = @PrecioUnitario, Imagen = @Imagen, Estado = @Estado, Cantidad = @Cantidad, Maximo = @Maximo, Minimo = @Minimo
		where IdProducto = @IdProducto
		select codError = 0, mensaje = 'TProducto actualizado correctamente'
	end;
	else
		select codError = 1, mensaje = 'El objeto TProducto no existe'
end;
go
------------------------------------------------------------------------------------------------------Eliminar
if exists (select * from sysobjects where name='spu_TProducto_Eliminar') 
	drop procedure spu_TProducto_Eliminar
go

create procedure spu_TProducto_Eliminar
	@IdProducto varchar(8)
as
begin  --verificacion de clave primaria
	if exists (select * from TProducto where IdProducto = @IdProducto)
	begin
		delete from TProducto
		where IdProducto = @IdProducto
	end;
	else
		select codError = 1, mensaje = 'El objeto TProducto no existe'
end;
go

--------------------------------------------------------------------------------------------------------Listar
if exists (select * from sysobjects where name='spu_TProducto_Listar') 
	drop procedure spu_TProducto_Listar
go

create procedure spu_TProducto_Listar
as
begin
	select * from TProducto
end;
go

-------------------------------------------------------------------------------------------------------------- TProveedor
-------------------------------------------------------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------Insertar
if exists (select * from sysobjects where name='spu_TProveedor_Insertar') 
	drop procedure spu_TProveedor_Insertar
go

create procedure spu_TProveedor_Insertar
	@IdProveedor varchar(5),
	@Nombre varchar(40),
	@Direccion varchar(25),
	@Telefono varchar(25),
	@Correo varchar(40),
	@Estado varchar(10)
as
begin  --verificacion de clave primaria
	if not exists (select * from TProveedor where IdProveedor = @IdProveedor)
	begin
		insert into TProveedor values (@IdProveedor, @Nombre, @Direccion, @Telefono, @Correo, @Estado)
		select codError = 0, mensaje = 'TProveedor insertado correctamente'
	end;
	else
		select codError = 1, mensaje = 'El objeto TProveedor ya existe'
end;
go
-----------------------------------------------------------------------------------------------------Modificar
if exists (select * from sysobjects where name='spu_TProveedor_Modificar') 
	drop procedure spu_TProveedor_Modificar
go

create procedure spu_TProveedor_Modificar
	@IdProveedor varchar(5),
	@Nombre varchar(40),
	@Direccion varchar(25),
	@Telefono varchar(25),
	@Correo varchar(40),
	@Estado varchar(10)
as
begin  --verificacion de clave primaria
	if exists (select * from TProveedor where IdProveedor = @IdProveedor)
	begin
		update TProveedor
		set IdProveedor = @IdProveedor, Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo, Estado = @Estado
		where IdProveedor = @IdProveedor
		select codError = 0, mensaje = 'TProveedor actualizado correctamente'
	end;
	else
		select codError = 1, mensaje = 'El objeto TProveedor no existe'
end;
go
------------------------------------------------------------------------------------------------------Eliminar
if exists (select * from sysobjects where name='spu_TProveedor_Eliminar') 
	drop procedure spu_TProveedor_Eliminar
go

create procedure spu_TProveedor_Eliminar
	@IdProveedor varchar(5)
as
begin  --verificacion de clave primaria
	if exists (select * from TProveedor where IdProveedor = @IdProveedor)
	begin
		delete from TProveedor
		where IdProveedor = @IdProveedor
	end;
	else
		select codError = 1, mensaje = 'El objeto TProveedor no existe'
end;
go

--------------------------------------------------------------------------------------------------------Listar
if exists (select * from sysobjects where name='spu_TProveedor_Listar') 
	drop procedure spu_TProveedor_Listar
go

create procedure spu_TProveedor_Listar
as
begin
	select * from TProveedor
end;
go

-------------------------------------------------------------------------------------------------------------- TUsuario
-------------------------------------------------------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------Insertar
if exists (select * from sysobjects where name='spu_TUsuario_Insertar') 
	drop procedure spu_TUsuario_Insertar
go

create procedure spu_TUsuario_Insertar
	@IdUsuario varchar(5),
	@Nombres varchar(20),
	@Apellidos varchar(20),
	@Direccion varchar(35),
	@Telefono varchar(12),
	@Correo varchar(40),
	@Contraseña varchar(12),
	@Tipo varchar(10),
	@Estado varchar(10)
as
begin  --verificacion de clave primaria
	if not exists (select * from TUsuario where IdUsuario = @IdUsuario)
	begin
		insert into TUsuario values (@IdUsuario, @Nombres, @Apellidos, @Direccion, @Telefono, @Correo, @Contraseña, @Tipo, @Estado)
		select codError = 0, mensaje = 'TUsuario insertado correctamente'
	end;
	else
		select codError = 1, mensaje = 'El objeto TUsuario ya existe'
end;
go
-----------------------------------------------------------------------------------------------------Modificar
if exists (select * from sysobjects where name='spu_TUsuario_Modificar') 
	drop procedure spu_TUsuario_Modificar
go

create procedure spu_TUsuario_Modificar
	@IdUsuario varchar(5),
	@Nombres varchar(20),
	@Apellidos varchar(20),
	@Direccion varchar(35),
	@Telefono varchar(12),
	@Correo varchar(40),
	@Contraseña varchar(12),
	@Tipo varchar(10),
	@Estado varchar(10)
as
begin  --verificacion de clave primaria
	if exists (select * from TUsuario where IdUsuario = @IdUsuario)
	begin
		update TUsuario
		set IdUsuario = @IdUsuario, Nombres = @Nombres, Apellidos = @Apellidos, Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo, Contraseña = @Contraseña, Tipo = @Tipo, Estado = @Estado
		where IdUsuario = @IdUsuario
		select codError = 0, mensaje = 'TUsuario actualizado correctamente'
	end;
	else
		select codError = 1, mensaje = 'El objeto TUsuario no existe'
end;
go
------------------------------------------------------------------------------------------------------Eliminar
if exists (select * from sysobjects where name='spu_TUsuario_Eliminar') 
	drop procedure spu_TUsuario_Eliminar
go

create procedure spu_TUsuario_Eliminar
	@IdUsuario varchar(5)
as
begin  --verificacion de clave primaria
	if exists (select * from TUsuario where IdUsuario = @IdUsuario)
	begin
		delete from TUsuario
		where IdUsuario = @IdUsuario
	end;
	else
		select codError = 1, mensaje = 'El objeto TUsuario no existe'
end;
go

--------------------------------------------------------------------------------------------------------Listar
if exists (select * from sysobjects where name='spu_TUsuario_Listar') 
	drop procedure spu_TUsuario_Listar
go

create procedure spu_TUsuario_Listar
as
begin
	select * from TUsuario
end;
go

-------------------------------------------------------------------------------------------------------------- TCliente
-------------------------------------------------------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------Insertar
if exists (select * from sysobjects where name='spu_TCliente_Insertar') 
	drop procedure spu_TCliente_Insertar
go

create procedure spu_TCliente_Insertar
	@IdCliente varchar(8),
	@Nombres varchar(20),
	@Apellidos varchar(20),
	@Direccion varchar(35),
	@Telefono varchar(12),
	@Correo varchar(40)
as
begin  --verificacion de clave primaria
	if not exists (select * from TCliente where IdCliente = @IdCliente)
	begin
		insert into TCliente values (@IdCliente, @Nombres, @Apellidos, @Direccion, @Telefono, @Correo)
		select codError = 0, mensaje = 'TCliente insertado correctamente'
	end;
	else
		select codError = 1, mensaje = 'El objeto TCliente ya existe'
end;
go
-----------------------------------------------------------------------------------------------------Modificar
if exists (select * from sysobjects where name='spu_TCliente_Modificar') 
	drop procedure spu_TCliente_Modificar
go

create procedure spu_TCliente_Modificar
	@IdCliente varchar(8),
	@Nombres varchar(20),
	@Apellidos varchar(20),
	@Direccion varchar(35),
	@Telefono varchar(12),
	@Correo varchar(40)
as
begin  --verificacion de clave primaria
	if exists (select * from TCliente where IdCliente = @IdCliente)
	begin
		update TCliente
		set IdCliente = @IdCliente, Nombres = @Nombres, Apellidos = @Apellidos, Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo
		where IdCliente = @IdCliente
		select codError = 0, mensaje = 'TCliente actualizado correctamente'
	end;
	else
		select codError = 1, mensaje = 'El objeto TCliente no existe'
end;
go
------------------------------------------------------------------------------------------------------Eliminar
if exists (select * from sysobjects where name='spu_TCliente_Eliminar') 
	drop procedure spu_TCliente_Eliminar
go

create procedure spu_TCliente_Eliminar
	@IdCliente varchar(8)
as
begin  --verificacion de clave primaria
	if exists (select * from TCliente where IdCliente = @IdCliente)
	begin
		delete from TCliente
		where IdCliente = @IdCliente
	end;
	else
		select codError = 1, mensaje = 'El objeto TCliente no existe'
end;
go

--------------------------------------------------------------------------------------------------------Listar
if exists (select * from sysobjects where name='spu_TCliente_Listar') 
	drop procedure spu_TCliente_Listar
go

create procedure spu_TCliente_Listar
as
begin
	select * from TCliente
end;
go

-------------------------------------------------------------------------------------------------------------- TPedido
-------------------------------------------------------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------Insertar
if exists (select * from sysobjects where name='spu_TPedido_Insertar') 
	drop procedure spu_TPedido_Insertar
go

create procedure spu_TPedido_Insertar
	@IdPedido varchar(8),
	@IdProveedor varchar(5),
	@IdUsuario varchar(5),
	@FechaPago datetime,
	@FechaPedido datetime,
	@TerminosEntrega varchar(15)
as
begin  --verificacion de clave primaria
	if not exists (select * from TPedido where IdPedido = @IdPedido and IdProveedor= @IdProveedor and IdUsuario= @IdUsuario)
	begin
		if exists (select * from TProveedor where IdProveedor = @IdProveedor)
		begin
			if exists (select * from TUsuario where IdUsuario = @IdUsuario)
			begin
				insert into TPedido values (@IdPedido, @IdProveedor, @IdUsuario, @FechaPago, @FechaPedido, @TerminosEntrega)
				select codError = 0, mensaje = 'TPedido insertado correctamente'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdUsuario no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdProveedor no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TPedido ya existe'
end;
go
-----------------------------------------------------------------------------------------------------Modificar
if exists (select * from sysobjects where name='spu_TPedido_Modificar') 
	drop procedure spu_TPedido_Modificar
go

create procedure spu_TPedido_Modificar
	@IdPedido varchar(8),
	@IdProveedor varchar(5),
	@IdUsuario varchar(5),
	@FechaPago datetime,
	@FechaPedido datetime,
	@TerminosEntrega varchar(15)
as
begin  --verificacion de clave primaria
	if exists (select * from TPedido where IdPedido = @IdPedido and IdProveedor= @IdProveedor and IdUsuario= @IdUsuario)
	begin
		if exists (select * from TProveedor where IdProveedor = @IdProveedor)
		begin
			if exists (select * from TUsuario where IdUsuario = @IdUsuario)
			begin
				update TPedido
				set IdPedido = @IdPedido, IdProveedor = @IdProveedor, IdUsuario = @IdUsuario, FechaPago = @FechaPago, FechaPedido = @FechaPedido, TerminosEntrega = @TerminosEntrega
				where IdPedido = @IdPedido and IdProveedor= @IdProveedor and IdUsuario= @IdUsuario
				select codError = 0, mensaje = 'TPedido actualizado correctamente'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdUsuario no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdProveedor no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TPedido no existe'
end;
go
------------------------------------------------------------------------------------------------------Eliminar
if exists (select * from sysobjects where name='spu_TPedido_Eliminar') 
	drop procedure spu_TPedido_Eliminar
go

create procedure spu_TPedido_Eliminar
	@IdPedido varchar(8),
	@IdProveedor varchar(5),
	@IdUsuario varchar(5)
as
begin  --verificacion de clave primaria
	if exists (select * from TPedido where IdPedido = @IdPedido and IdProveedor= @IdProveedor and IdUsuario= @IdUsuario)
	begin
		delete from TPedido
		where IdPedido = @IdPedido and IdProveedor= @IdProveedor and IdUsuario= @IdUsuario
	end;
	else
		select codError = 1, mensaje = 'El objeto TPedido no existe'
end;
go

--------------------------------------------------------------------------------------------------------Listar
if exists (select * from sysobjects where name='spu_TPedido_Listar') 
	drop procedure spu_TPedido_Listar
go

create procedure spu_TPedido_Listar
as
begin
	select * from TPedido
end;
go

-------------------------------------------------------------------------------------------------------------- TEntrada
-------------------------------------------------------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------Insertar
if exists (select * from sysobjects where name='spu_TEntrada_Insertar') 
	drop procedure spu_TEntrada_Insertar
go

create procedure spu_TEntrada_Insertar
	@IdEntrada varchar(8),
	@IdProveedor varchar(5),
	@IdUsuario varchar(5),
	@Fecha datetime
as
begin  --verificacion de clave primaria
	if not exists (select * from TEntrada where IdEntrada = @IdEntrada and IdProveedor= @IdProveedor and IdUsuario= @IdUsuario)
	begin
		if exists (select * from TProveedor where IdProveedor = @IdProveedor)
		begin
			if exists (select * from TUsuario where IdUsuario = @IdUsuario)
			begin
				insert into TEntrada values (@IdEntrada, @IdProveedor, @IdUsuario, @Fecha)
				select codError = 0, mensaje = 'TEntrada insertado correctamente'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdUsuario no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdProveedor no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TEntrada ya existe'
end;
go
-----------------------------------------------------------------------------------------------------Modificar
if exists (select * from sysobjects where name='spu_TEntrada_Modificar') 
	drop procedure spu_TEntrada_Modificar
go

create procedure spu_TEntrada_Modificar
	@IdEntrada varchar(8),
	@IdProveedor varchar(5),
	@IdUsuario varchar(5),
	@Fecha datetime
as
begin  --verificacion de clave primaria
	if exists (select * from TEntrada where IdEntrada = @IdEntrada and IdProveedor= @IdProveedor and IdUsuario= @IdUsuario)
	begin
		if exists (select * from TProveedor where IdProveedor = @IdProveedor)
		begin
			if exists (select * from TUsuario where IdUsuario = @IdUsuario)
			begin
				update TEntrada
				set IdEntrada = @IdEntrada, IdProveedor = @IdProveedor, IdUsuario = @IdUsuario, Fecha = @Fecha
				where IdEntrada = @IdEntrada and IdProveedor= @IdProveedor and IdUsuario= @IdUsuario
				select codError = 0, mensaje = 'TEntrada actualizado correctamente'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdUsuario no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdProveedor no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TEntrada no existe'
end;
go
------------------------------------------------------------------------------------------------------Eliminar
if exists (select * from sysobjects where name='spu_TEntrada_Eliminar') 
	drop procedure spu_TEntrada_Eliminar
go

create procedure spu_TEntrada_Eliminar
	@IdEntrada varchar(8),
	@IdProveedor varchar(5),
	@IdUsuario varchar(5)
as
begin  --verificacion de clave primaria
	if exists (select * from TEntrada where IdEntrada = @IdEntrada and IdProveedor= @IdProveedor and IdUsuario= @IdUsuario)
	begin
		delete from TEntrada
		where IdEntrada = @IdEntrada and IdProveedor= @IdProveedor and IdUsuario= @IdUsuario
	end;
	else
		select codError = 1, mensaje = 'El objeto TEntrada no existe'
end;
go

--------------------------------------------------------------------------------------------------------Listar
if exists (select * from sysobjects where name='spu_TEntrada_Listar') 
	drop procedure spu_TEntrada_Listar
go

create procedure spu_TEntrada_Listar
as
begin
	select * from TEntrada
end;
go

-------------------------------------------------------------------------------------------------------------- TPedidoDetalle
-------------------------------------------------------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------Insertar
if exists (select * from sysobjects where name='spu_TPedidoDetalle_Insertar') 
	drop procedure spu_TPedidoDetalle_Insertar
go

create procedure spu_TPedidoDetalle_Insertar
	@IdPedido varchar(8),
	@IdProducto varchar(8),
	@Cantidad int,
	@PrecioUnitario float
as
begin  --verificacion de clave primaria
	if not exists (select * from TPedidoDetalle where IdPedido = @IdPedido and IdProducto= @IdProducto)
	begin
		if exists (select * from TPedido where IdPedido = @IdPedido)
		begin
			if exists (select * from TProducto where IdProducto = @IdProducto)
			begin
				insert into TPedidoDetalle values (@IdPedido, @IdProducto, @Cantidad, @PrecioUnitario)
				select codError = 0, mensaje = 'TPedidoDetalle insertado correctamente'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdProducto no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdPedido no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TPedidoDetalle ya existe'
end;
go
-----------------------------------------------------------------------------------------------------Modificar
if exists (select * from sysobjects where name='spu_TPedidoDetalle_Modificar') 
	drop procedure spu_TPedidoDetalle_Modificar
go

create procedure spu_TPedidoDetalle_Modificar
	@IdPedido varchar(8),
	@IdProducto varchar(8),
	@Cantidad int,
	@PrecioUnitario float
as
begin  --verificacion de clave primaria
	if exists (select * from TPedidoDetalle where IdPedido = @IdPedido and IdProducto= @IdProducto)
	begin
		if exists (select * from TPedido where IdPedido = @IdPedido)
		begin
			if exists (select * from TProducto where IdProducto = @IdProducto)
			begin
				update TPedidoDetalle
				set IdPedido = @IdPedido, IdProducto = @IdProducto, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario
				where IdPedido = @IdPedido and IdProducto= @IdProducto
				select codError = 0, mensaje = 'TPedidoDetalle actualizado correctamente'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdProducto no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdPedido no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TPedidoDetalle no existe'
end;
go
------------------------------------------------------------------------------------------------------Eliminar
if exists (select * from sysobjects where name='spu_TPedidoDetalle_Eliminar') 
	drop procedure spu_TPedidoDetalle_Eliminar
go

create procedure spu_TPedidoDetalle_Eliminar
	@IdPedido varchar(8),
	@IdProducto varchar(8)
as
begin  --verificacion de clave primaria
	if exists (select * from TPedidoDetalle where IdPedido = @IdPedido and IdProducto= @IdProducto)
	begin
		delete from TPedidoDetalle
		where IdPedido = @IdPedido and IdProducto= @IdProducto
	end;
	else
		select codError = 1, mensaje = 'El objeto TPedidoDetalle no existe'
end;
go

--------------------------------------------------------------------------------------------------------Listar
if exists (select * from sysobjects where name='spu_TPedidoDetalle_Listar') 
	drop procedure spu_TPedidoDetalle_Listar
go

create procedure spu_TPedidoDetalle_Listar
as
begin
	select * from TPedidoDetalle
end;
go

-------------------------------------------------------------------------------------------------------------- TEntradaDetalle
-------------------------------------------------------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------Insertar
if exists (select * from sysobjects where name='spu_TEntradaDetalle_Insertar') 
	drop procedure spu_TEntradaDetalle_Insertar
go

create procedure spu_TEntradaDetalle_Insertar
	@IdEntrada varchar(8),
	@IdProducto varchar(8),
	@Cantidad int
as
begin  --verificacion de clave primaria
	if not exists (select * from TEntradaDetalle where IdEntrada = @IdEntrada and IdProducto= @IdProducto)
	begin
		if exists (select * from TEntrada where IdEntrada = @IdEntrada)
		begin
			if exists (select * from TProducto where IdProducto = @IdProducto)
			begin
				insert into TEntradaDetalle values (@IdEntrada, @IdProducto, @Cantidad)
				select codError = 0, mensaje = 'TEntradaDetalle insertado correctamente'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdProducto no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdEntrada no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TEntradaDetalle ya existe'
end;
go
-----------------------------------------------------------------------------------------------------Modificar
if exists (select * from sysobjects where name='spu_TEntradaDetalle_Modificar') 
	drop procedure spu_TEntradaDetalle_Modificar
go

create procedure spu_TEntradaDetalle_Modificar
	@IdEntrada varchar(8),
	@IdProducto varchar(8),
	@Cantidad int
as
begin  --verificacion de clave primaria
	if exists (select * from TEntradaDetalle where IdEntrada = @IdEntrada and IdProducto= @IdProducto)
	begin
		if exists (select * from TEntrada where IdEntrada = @IdEntrada)
		begin
			if exists (select * from TProducto where IdProducto = @IdProducto)
			begin
				update TEntradaDetalle
				set IdEntrada = @IdEntrada, IdProducto = @IdProducto, Cantidad = @Cantidad
				where IdEntrada = @IdEntrada and IdProducto= @IdProducto
				select codError = 0, mensaje = 'TEntradaDetalle actualizado correctamente'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdProducto no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdEntrada no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TEntradaDetalle no existe'
end;
go
------------------------------------------------------------------------------------------------------Eliminar
if exists (select * from sysobjects where name='spu_TEntradaDetalle_Eliminar') 
	drop procedure spu_TEntradaDetalle_Eliminar
go

create procedure spu_TEntradaDetalle_Eliminar
	@IdEntrada varchar(8),
	@IdProducto varchar(8)
as
begin  --verificacion de clave primaria
	if exists (select * from TEntradaDetalle where IdEntrada = @IdEntrada and IdProducto= @IdProducto)
	begin
		delete from TEntradaDetalle
		where IdEntrada = @IdEntrada and IdProducto= @IdProducto
	end;
	else
		select codError = 1, mensaje = 'El objeto TEntradaDetalle no existe'
end;
go

--------------------------------------------------------------------------------------------------------Listar
if exists (select * from sysobjects where name='spu_TEntradaDetalle_Listar') 
	drop procedure spu_TEntradaDetalle_Listar
go

create procedure spu_TEntradaDetalle_Listar
as
begin
	select * from TEntradaDetalle
end;
go

-------------------------------------------------------------------------------------------------------------- TVenta
-------------------------------------------------------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------Insertar
if exists (select * from sysobjects where name='spu_TVenta_Insertar') 
	drop procedure spu_TVenta_Insertar
go

create procedure spu_TVenta_Insertar
	@IdVenta varchar(8),
	@IdUsuario varchar(5),
	@IdCliente varchar(8),
	@Fecha datetime
as
begin  --verificacion de clave primaria
	if not exists (select * from TVenta where IdVenta = @IdVenta and IdUsuario= @IdUsuario and IdCliente= @IdCliente)
	begin
		if exists (select * from TUsuario where IdUsuario = @IdUsuario)
		begin
			if exists (select * from TCliente where IdCliente = @IdCliente)
			begin
				insert into TVenta values (@IdVenta, @IdUsuario, @IdCliente, @Fecha)
				select codError = 0, mensaje = 'TVenta insertado correctamente'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdCliente no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdUsuario no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TVenta ya existe'
end;
go
-----------------------------------------------------------------------------------------------------Modificar
if exists (select * from sysobjects where name='spu_TVenta_Modificar') 
	drop procedure spu_TVenta_Modificar
go

create procedure spu_TVenta_Modificar
	@IdVenta varchar(8),
	@IdUsuario varchar(5),
	@IdCliente varchar(8),
	@Fecha datetime
as
begin  --verificacion de clave primaria
	if exists (select * from TVenta where IdVenta = @IdVenta and IdUsuario= @IdUsuario and IdCliente= @IdCliente)
	begin
		if exists (select * from TUsuario where IdUsuario = @IdUsuario)
		begin
			if exists (select * from TCliente where IdCliente = @IdCliente)
			begin
				update TVenta
				set IdVenta = @IdVenta, IdUsuario = @IdUsuario, IdCliente = @IdCliente, Fecha = @Fecha
				where IdVenta = @IdVenta and IdUsuario= @IdUsuario and IdCliente= @IdCliente
				select codError = 0, mensaje = 'TVenta actualizado correctamente'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdCliente no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdUsuario no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TVenta no existe'
end;
go
------------------------------------------------------------------------------------------------------Eliminar
if exists (select * from sysobjects where name='spu_TVenta_Eliminar') 
	drop procedure spu_TVenta_Eliminar
go

create procedure spu_TVenta_Eliminar
	@IdVenta varchar(8),
	@IdUsuario varchar(5),
	@IdCliente varchar(8)
as
begin  --verificacion de clave primaria
	if exists (select * from TVenta where IdVenta = @IdVenta and IdUsuario= @IdUsuario and IdCliente= @IdCliente)
	begin
		delete from TVenta
		where IdVenta = @IdVenta and IdUsuario= @IdUsuario and IdCliente= @IdCliente
	end;
	else
		select codError = 1, mensaje = 'El objeto TVenta no existe'
end;
go

--------------------------------------------------------------------------------------------------------Listar
if exists (select * from sysobjects where name='spu_TVenta_Listar') 
	drop procedure spu_TVenta_Listar
go

create procedure spu_TVenta_Listar
as
begin
	select * from TVenta
end;
go

-------------------------------------------------------------------------------------------------------------- TVentaDetalle
-------------------------------------------------------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------Insertar
if exists (select * from sysobjects where name='spu_TVentaDetalle_Insertar') 
	drop procedure spu_TVentaDetalle_Insertar
go

create procedure spu_TVentaDetalle_Insertar
	@IdVenta varchar(8),
	@IdProducto varchar(8),
	@Cantidad int,
	@PrecioUnitario float
as
begin  --verificacion de clave primaria
	if not exists (select * from TVentaDetalle where IdVenta = @IdVenta and IdProducto= @IdProducto)
	begin
		if exists (select * from TVenta where IdVenta = @IdVenta)
		begin
			if exists (select * from TProducto where IdProducto = @IdProducto)
			begin
				insert into TVentaDetalle values (@IdVenta, @IdProducto, @Cantidad, @PrecioUnitario)
				select codError = 0, mensaje = 'TVentaDetalle insertado correctamente'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdProducto no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdVenta no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TVentaDetalle ya existe'
end;
go
-----------------------------------------------------------------------------------------------------Modificar
if exists (select * from sysobjects where name='spu_TVentaDetalle_Modificar') 
	drop procedure spu_TVentaDetalle_Modificar
go

create procedure spu_TVentaDetalle_Modificar
	@IdVenta varchar(8),
	@IdProducto varchar(8),
	@Cantidad int,
	@PrecioUnitario float
as
begin  --verificacion de clave primaria
	if exists (select * from TVentaDetalle where IdVenta = @IdVenta and IdProducto= @IdProducto)
	begin
		if exists (select * from TVenta where IdVenta = @IdVenta)
		begin
			if exists (select * from TProducto where IdProducto = @IdProducto)
			begin
				update TVentaDetalle
				set IdVenta = @IdVenta, IdProducto = @IdProducto, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario
				where IdVenta = @IdVenta and IdProducto= @IdProducto
				select codError = 0, mensaje = 'TVentaDetalle actualizado correctamente'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdProducto no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdVenta no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TVentaDetalle no existe'
end;
go
------------------------------------------------------------------------------------------------------Eliminar
if exists (select * from sysobjects where name='spu_TVentaDetalle_Eliminar') 
	drop procedure spu_TVentaDetalle_Eliminar
go

create procedure spu_TVentaDetalle_Eliminar
	@IdVenta varchar(8),
	@IdProducto varchar(8)
as
begin  --verificacion de clave primaria
	if exists (select * from TVentaDetalle where IdVenta = @IdVenta and IdProducto= @IdProducto)
	begin
		delete from TVentaDetalle
		where IdVenta = @IdVenta and IdProducto= @IdProducto
	end;
	else
		select codError = 1, mensaje = 'El objeto TVentaDetalle no existe'
end;
go

--------------------------------------------------------------------------------------------------------Listar
if exists (select * from sysobjects where name='spu_TVentaDetalle_Listar') 
	drop procedure spu_TVentaDetalle_Listar
go

create procedure spu_TVentaDetalle_Listar
as
begin
	select * from TVentaDetalle
end;
go

-------------------------------------------------------------------------------------------------------------- TDevolucion
-------------------------------------------------------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------Insertar
if exists (select * from sysobjects where name='spu_TDevolucion_Insertar') 
	drop procedure spu_TDevolucion_Insertar
go

create procedure spu_TDevolucion_Insertar
	@IdDevolucion varchar(8),
	@IdVenta varchar(8),
	@Fecha datetime
as
begin  --verificacion de clave primaria
	if not exists (select * from TDevolucion where IdDevolucion = @IdDevolucion and IdVenta= @IdVenta)
	begin
		if exists (select * from TVenta where IdVenta = @IdVenta)
		begin
			insert into TDevolucion values (@IdDevolucion, @IdVenta, @Fecha)
			select codError = 0, mensaje = 'TDevolucion insertado correctamente'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdVenta no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TDevolucion ya existe'
end;
go
-----------------------------------------------------------------------------------------------------Modificar
if exists (select * from sysobjects where name='spu_TDevolucion_Modificar') 
	drop procedure spu_TDevolucion_Modificar
go

create procedure spu_TDevolucion_Modificar
	@IdDevolucion varchar(8),
	@IdVenta varchar(8),
	@Fecha datetime
as
begin  --verificacion de clave primaria
	if exists (select * from TDevolucion where IdDevolucion = @IdDevolucion and IdVenta= @IdVenta)
	begin
		if exists (select * from TVenta where IdVenta = @IdVenta)
		begin
			update TDevolucion
			set IdDevolucion = @IdDevolucion, IdVenta = @IdVenta, Fecha = @Fecha
			where IdDevolucion = @IdDevolucion and IdVenta= @IdVenta
			select codError = 0, mensaje = 'TDevolucion actualizado correctamente'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdVenta no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TDevolucion no existe'
end;
go
------------------------------------------------------------------------------------------------------Eliminar
if exists (select * from sysobjects where name='spu_TDevolucion_Eliminar') 
	drop procedure spu_TDevolucion_Eliminar
go

create procedure spu_TDevolucion_Eliminar
	@IdDevolucion varchar(8),
	@IdVenta varchar(8)
as
begin  --verificacion de clave primaria
	if exists (select * from TDevolucion where IdDevolucion = @IdDevolucion and IdVenta= @IdVenta)
	begin
		delete from TDevolucion
		where IdDevolucion = @IdDevolucion and IdVenta= @IdVenta
	end;
	else
		select codError = 1, mensaje = 'El objeto TDevolucion no existe'
end;
go

--------------------------------------------------------------------------------------------------------Listar
if exists (select * from sysobjects where name='spu_TDevolucion_Listar') 
	drop procedure spu_TDevolucion_Listar
go

create procedure spu_TDevolucion_Listar
as
begin
	select * from TDevolucion
end;
go

-------------------------------------------------------------------------------------------------------------- TDevolucionDetalle
-------------------------------------------------------------------------------------------------------------- 
------------------------------------------------------------------------------------------------------Insertar
if exists (select * from sysobjects where name='spu_TDevolucionDetalle_Insertar') 
	drop procedure spu_TDevolucionDetalle_Insertar
go

create procedure spu_TDevolucionDetalle_Insertar
	@IdDevolucion varchar(8),
	@IdVenta varchar(8),
	@IdProducto varchar(8),
	@Cantidad int,
	@Estado varchar(12),
	@PrecioUnitario float
as
begin  --verificacion de clave primaria
	if not exists (select * from TDevolucionDetalle where IdDevolucion = @IdDevolucion and IdVenta= @IdVenta and IdProducto= @IdProducto)
	begin
		if exists (select * from TDevolucion where IdDevolucion = @IdDevolucion)
		begin
			if exists (select * from TVenta where IdVenta = @IdVenta)
			begin
				if exists (select * from TProducto where IdProducto = @IdProducto)
				begin
					insert into TDevolucionDetalle values (@IdDevolucion, @IdVenta, @IdProducto, @Cantidad, @Estado, @PrecioUnitario)
					select codError = 0, mensaje = 'TDevolucionDetalle insertado correctamente'
				end;
				else
					select codError = 1, mensaje = 'El objeto IdProducto no existe'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdVenta no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdDevolucion no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TDevolucionDetalle ya existe'
end;
go
-----------------------------------------------------------------------------------------------------Modificar
if exists (select * from sysobjects where name='spu_TDevolucionDetalle_Modificar') 
	drop procedure spu_TDevolucionDetalle_Modificar
go

create procedure spu_TDevolucionDetalle_Modificar
	@IdDevolucion varchar(8),
	@IdVenta varchar(8),
	@IdProducto varchar(8),
	@Cantidad int,
	@Estado varchar(12),
	@PrecioUnitario float
as
begin  --verificacion de clave primaria
	if exists (select * from TDevolucionDetalle where IdDevolucion = @IdDevolucion and IdVenta= @IdVenta and IdProducto= @IdProducto)
	begin
		if exists (select * from TDevolucion where IdDevolucion = @IdDevolucion)
		begin
			if exists (select * from TVenta where IdVenta = @IdVenta)
			begin
				if exists (select * from TProducto where IdProducto = @IdProducto)
				begin
					update TDevolucionDetalle
					set IdDevolucion = @IdDevolucion, IdVenta = @IdVenta, IdProducto = @IdProducto, Cantidad = @Cantidad, Estado = @Estado, PrecioUnitario = @PrecioUnitario
					where IdDevolucion = @IdDevolucion and IdVenta= @IdVenta and IdProducto= @IdProducto
					select codError = 0, mensaje = 'TDevolucionDetalle actualizado correctamente'
				end;
				else
					select codError = 1, mensaje = 'El objeto IdProducto no existe'
			end;
			else
				select codError = 1, mensaje = 'El objeto IdVenta no existe'
		end;
		else
			select codError = 1, mensaje = 'El objeto IdDevolucion no existe'
	end;
	else
		select codError = 1, mensaje = 'El objeto TDevolucionDetalle no existe'
end;
go
------------------------------------------------------------------------------------------------------Eliminar
if exists (select * from sysobjects where name='spu_TDevolucionDetalle_Eliminar') 
	drop procedure spu_TDevolucionDetalle_Eliminar
go

create procedure spu_TDevolucionDetalle_Eliminar
	@IdDevolucion varchar(8),
	@IdVenta varchar(8),
	@IdProducto varchar(8)
as
begin  --verificacion de clave primaria
	if exists (select * from TDevolucionDetalle where IdDevolucion = @IdDevolucion and IdVenta= @IdVenta and IdProducto= @IdProducto)
	begin
		delete from TDevolucionDetalle
		where IdDevolucion = @IdDevolucion and IdVenta= @IdVenta and IdProducto= @IdProducto
	end;
	else
		select codError = 1, mensaje = 'El objeto TDevolucionDetalle no existe'
end;
go

--------------------------------------------------------------------------------------------------------Listar
if exists (select * from sysobjects where name='spu_TDevolucionDetalle_Listar') 
	drop procedure spu_TDevolucionDetalle_Listar
go

create procedure spu_TDevolucionDetalle_Listar
as
begin
	select * from TDevolucionDetalle
end;
go

