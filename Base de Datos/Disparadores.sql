--------------------------- Disparador Entrada ---------------------------------
create trigger triggerEntradaProducto on TEntradaDetalle for insert
as
declare @codigoProducto varchar(8)
declare @cantidadAumentada int
select @codigoProducto = IdProducto from inserted
select @cantidadAumentada = Cantidad from inserted
declare @cantidadAntes int
select @cantidadAntes = Cantidad from TProducto
where IdProducto = @codigoProducto

update TProducto
set Cantidad = @cantidadAntes + @cantidadAumentada
where IdProducto = @codigoProducto
go

--------------------------- Disparador Salida ----------------------------------
create trigger tr_SalidaProducto on TVentaDetalle for insert
as
	begin
		declare @IdVenta varchar(8)
		declare @IdProducto varchar(8)
		declare @Cantidad int

		select @IdVenta = IdVenta from inserted
		select @IdProducto = IdProducto from inserted
		select @Cantidad = Cantidad from inserted

		declare @CantidadAnterior int
		select @CantidadAnterior = Cantidad from TProducto where IdProducto = @IdProducto
		
		-- Validamos que existan suficientes productos para vender, sino se deshace las inserciones
		if @Cantidad>@CantidadAnterior
			ROLLBACK
		else
		begin
			set @CantidadAnterior = @CantidadAnterior - @Cantidad
			-- Inhabilitamos el producto si la cantidad llega a cero
			if @CantidadAnterior = 0
			begin
				UPDATE TProducto SET Cantidad = @CantidadAnterior, Estado = 'RETIRADO'
					where IdProducto = @IdProducto
			end;
			else
			begin
				UPDATE TProducto SET Cantidad = @CantidadAnterior
					where IdProducto = @IdProducto
			end;
				
		end;
		
	end;
go

-----------------------------------------------------------------
create trigger triggerAgregarModificacionTNegocio on TNegocio for insert
as
declare @Nombre varchar(25)
declare @Duegno varchar(40)
declare @RUC varchar(11)
declare @Telefono varchar(11)
declare @Correo varchar(30)
declare @Direccion varchar(35)
declare @IGV float
declare @MontoSuperarDescuento float
declare @Fecha date
declare @IdModificacion int
declare @PorcentajeDescuento float

select @Nombre  = Nombre from inserted
select @Duegno  = Duegno from inserted
select @RUC  = RUC from inserted
select @Telefono  = Telefono from inserted
select @Correo  =  Correo from inserted
select @Direccion  =  Direccion from inserted
select @IGV  =  IGV from inserted
select @MontoSuperarDescuento  =  MontoSuperarDescuento from inserted
select @PorcentajeDescuento  =  PorcentajeDescuento from inserted
select @Fecha  =  Fecha from inserted

update TNegocio
set Nombre  = @Nombre, Duegno  = @Duegno, RUC  = @RUC , Telefono  = @Telefono, Correo  =  @Correo, 
Direccion  =  @Direccion,  IGV  =  @IGV, MontoSuperarDescuento  =  @MontoSuperarDescuento ,Fecha =  @Fecha, 
PorcentajeDescuento  =  @PorcentajeDescuento
where IdModificacion = 1 --en el primer registro
go


------------------------------------------------------------------------------------------------------
set dateformat dmy
---------- DATOS PRODUCTO ----------------------
insert into TProducto values('PR000001','Portaminas Mars','Lapices y portaminas','Portaminas Mars Technico 780 HB con Clip','Staedtler',25.90,'Portaminas Mars.jpg','ACTIVO', 0, 100, 10)
insert into TProducto values('PR000002','Lápiz Grafito','Lapices y portaminas','Lápiz Grafito Escolar Fantasía','Artesco',0.90,'Lapiz_Grafito.jpg','ACTIVO', 0, 100, 10)
insert into TProducto values('PR000003','Diccionario Inglés - Español','Libros','Diccionario Tapa Dura Bilingüe Inglés - Español Plus','Norma',11.90,'DiccionarioIngles.jpg','ACTIVO', 0, 100, 10)
insert into TProducto values('PR000004','Papel Bulky A4','Papel y sobres','Papel Bulky A4 x 500 Hojas','Gallo',12.40,'Papel Bulky A4.jpg','ACTIVO', 0, 100, 10 )
insert into TProducto values('PR000005','Papel Bond Premium A4','Papel y sobres','Papel Bond Premium A4 80 g Paquete x 500 Hojas','Stanford',10.90,'PapelBond.jpg','ACTIVO', 0, 100, 10)

--------- DATOS PROVEEDOR ----------------------
 insert into TProveedor values('PR001','Organizacion Book SAC','Calle Santa Rosa 456','963157845','distribudirasBook@gmail.com','ACTIVO')
 insert into TProveedor values('PR002','Genesis Group SA','Jiron San Pedro 1225','930654879','genesisg@gmail.com','ACTIVO')
 insert into TProveedor values('PR003','Smart Letter SAC','Urb. Los Angeles 564','980709063','smartLetter@gmail.com','ACTIVO')
 insert into TProveedor values('PR004','Distribuciones Mark SA','Jiron San Sebastian 125','930656879','Mark@gmail.com','ACTIVO')
 insert into TProveedor values('PR005','Papeleria Rolf','Urb. Mariscal Gamarra','984409063','Rolf@gmail.com','ACTIVO')
--------- DATOS USUARIOS ----------------------
insert into TUsuario values('US001','Carlos','Carreta','Me la pelas','936686352','Mudos@15asoc.com','huevos1','SUPERVISOR','ACTIVO')
insert into TUsuario values('US002','Quispe','Huchija Luigi','Me la pelas','936686352','GAaaa@15asoc.com','huevos1','SUPERVISOR','ACTIVO')
insert into TUsuario values('US003','Dolores','Waywa','Me la pelas','936686352','Solores@15asoc.com','huevos1','EMPLEADO','ACTIVO')
insert into TUsuario values('US004','Carlos','Carreta','Me la pelas','936686352','Mudos@15asoc.com','huevos1','EMPLEADO','ACTIVO')
insert into TUsuario values('US005','Quispe','Huchija Luigi','Me la pelas','936686352','GAaaa@15asoc.com','huevos1','EMPLEADO','ACTIVO')
insert into TUsuario values('US006','Dolores','Waywa','Me la pelas','936686352','Solores@15asoc.com','huevos1','EMPLEADO','ACTIVO')
--------- DATOS CLIENTE ----------------------
insert into TCliente values('CL000001','Jose','Carreta','El valle de la felicidad','936683452','Jose@15asoc.com')
insert into TCliente values('CL000002','Marco','Sudado Pinto','Que te importa','936456352','GAaaa@15asoc.com')
insert into TCliente values('CL000003','Pedro','Waywa','El abismo','936645652','TengoSueño@15asoc.com')
insert into TCliente values('CL000004','Carlos','Ascci','Quien sabe pero hay wifi wiii...','936656752','ElAbismo@15asoc.com')
insert into TCliente values('CL000005','Martin','plin plin plon','Detras de ti prro','933456352','Lobo@15asoc.com')
insert into TCliente values('CL000006','Juan','gwyn','A ver, no se, san algo nro algo?','936678952','Espada@15asoc.com')
--------- DATOS PEDIDO, PEDIDO DETALLE ----------------------
insert into TPedido values ('PE000001','PR001', 'US001', '15/08/2020', '15/08/2020', 'Buen estado')
insert into TPedidoDetalle values ('PE000001','PR000001',20, 5)
insert into TPedidoDetalle values ('PE000001','PR000002',24, 50)
--------- DATOS ENTRADA, ENTRADA DETALLE ----------------------
insert into TEntrada values ('EN000001','PR001', 'US002', '15/08/2020')
insert into TEntradaDetalle values ('EN000001','PR000001',8)
insert into TEntradaDetalle values ('EN000001','PR000002',15)
insert into TEntradaDetalle values ('EN000001','PR000003',23)
--------- DATOS VENTA ----------------------
insert into TVenta values ('VE000001','US006','CL000002','20/08/2020',1,18,2000,1)
insert into TVentaDetalle values ('VE000001','PR000001',2,25.90)
insert into TVentaDetalle values ('VE000001','PR000003',1,11.90)

insert into TVenta values ('VE000002','US006','CL000005','20/08/2020',1,18,2000,1)
insert into TVentaDetalle values ('VE000002','PR000001',2,25.90)
insert into TVentaDetalle values ('VE000002','PR000003',1,11.90)

insert into TVenta values ('VE000003','US006','CL000005','20/08/2020',1,18,2000,1)
insert into TVentaDetalle values ('VE000003','PR000001',1,25.90)
insert into TVentaDetalle values ('VE000003','PR000002',1,11.90)
insert into TVentaDetalle values ('VE000003','PR000003',1,10.90)
--------- DATOS DEVOLUCION ----------------------
insert into TDevolucion values ('DE000001','US001','VE000001','No me gusto, no hacia plin plin plon','20/08/2020')
insert into TDevolucionDetalle values ('DE000001','PR000001',1,'NUEVO',25.90)
insert into TDevolucionDetalle values ('DE000001','PR000003',1,'NUEVO',25.90)

insert into TDevolucion values ('DE000002','US002','VE000002','No se podia ver el abismo en él','20/08/2020')
insert into TDevolucionDetalle values ('DE000002','PR000001',1,'DESGASTADO',10.90)
--------- DATOS NEGOCIO --------------------------
insert into TNegocio values ('LIBRERIA LAS VERGONIAS', 'Marcelo Choque Navarro','12345678910','987654321', 'ACM1PT@unsaac.edu.pe','Los vergales 123',18,2000,2,'05/09/2020')
