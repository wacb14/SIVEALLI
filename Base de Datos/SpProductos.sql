create procedure spuListarProductosSinImagen
as
begin
	select IdProducto, Nombre, Categoria, Descripcion, Marca, PrecioUnitario, Estado, Cantidad, Minimo, Maximo
	from TProducto
end;
go

create procedure spuExisteClavePrimariaTProducto @IdProducto varchar(8)
as
begin
	select *
	from TProducto
	where IdProducto = @IdProducto
end;
go

create procedure spuListarPorIdProducto @IdProducto varchar(8)
as
begin
	select IdProducto, Nombre, Categoria, Descripcion, Marca, PrecioUnitario, Estado, Cantidad, Minimo, Maximo
	from TProducto
	where IdProducto = @IdProducto
end;
go

create procedure spuListarPorNombre @Nombre varchar(40)
as
begin
	select IdProducto, Nombre, Categoria, Descripcion, Marca, PrecioUnitario, Estado, Cantidad, Minimo, Maximo
	from TProducto
	where Nombre = @Nombre
end;
go

create procedure spuListarPorCategoria @Categoria varchar(20)
as
begin
	select IdProducto, Nombre, Categoria, Descripcion, Marca, PrecioUnitario, Estado, Cantidad, Minimo, Maximo
	from TProducto
	where Categoria = @Categoria
end;
go

create procedure spuListarPorMarca @Marca varchar(20)
as
begin
	select IdProducto, Nombre, Categoria, Descripcion, Marca, PrecioUnitario, Estado, Cantidad, Minimo, Maximo
	from TProducto
	where Marca = @Marca
end;
go

create procedure spuListarPorPrecioUnitario @PrecioUnitario float
as
begin
	select IdProducto, Nombre, Categoria, Descripcion, Marca, PrecioUnitario, Estado, Cantidad, Minimo, Maximo
	from TProducto
	where PrecioUnitario = @PrecioUnitario
end;
go

create procedure spuListarPorEstado @Estado varchar(10)
as
begin
	select IdProducto, Nombre, Categoria, Descripcion, Marca, PrecioUnitario, Estado, Cantidad, Minimo, Maximo
	from TProducto
	where Estado = @Estado
end;
go

create procedure spuNumeroDeProductos
as
begin
	select count(IdProducto) as NumeroProductos
		FROM TProducto
end;
go