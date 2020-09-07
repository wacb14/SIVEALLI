namespace SIVEALLI
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbcVentas = new System.Windows.Forms.TabControl();
            this.TbpVentaNueva = new System.Windows.Forms.TabPage();
            this.GbRegistrarVenta = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl13 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.Lbl12 = new System.Windows.Forms.Label();
            this.LblDescuento = new System.Windows.Forms.Label();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.LblImpuesto = new System.Windows.Forms.Label();
            this.Lbl8 = new System.Windows.Forms.Label();
            this.BtnNuevaVenta = new System.Windows.Forms.Button();
            this.BtnImprimirComprobante = new System.Windows.Forms.Button();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.BtnRegistrarVenta = new System.Windows.Forms.Button();
            this.GbDatosVenta = new System.Windows.Forms.GroupBox();
            this.TxtValorBusqueda = new System.Windows.Forms.TextBox();
            this.Lbl10 = new System.Windows.Forms.Label();
            this.Lbl9 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CboBuscarPor = new System.Windows.Forms.ComboBox();
            this.DgvCatalogoBusqueda = new System.Windows.Forms.DataGridView();
            this.colBtnAgregar1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colIdProducto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNuevoCliente = new System.Windows.Forms.Button();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.TxtIdVenta = new System.Windows.Forms.TextBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.GbDetalleVenta = new System.Windows.Forms.GroupBox();
            this.BtnVaciarDetalles = new System.Windows.Forms.Button();
            this.DgvVentaDetalle = new System.Windows.Forms.DataGridView();
            this.colBtnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbpHistorialVentas = new System.Windows.Forms.TabPage();
            this.GbDetallesVenta = new System.Windows.Forms.GroupBox();
            this.DgvDetallesVenta2 = new System.Windows.Forms.DataGridView();
            this.BtnImprimirComprobante2 = new System.Windows.Forms.Button();
            this.GbListaVentas = new System.Windows.Forms.GroupBox();
            this.TxtValorBusqueda2 = new System.Windows.Forms.TextBox();
            this.Lbl7 = new System.Windows.Forms.Label();
            this.Lbl6 = new System.Windows.Forms.Label();
            this.BtnBuscar2 = new System.Windows.Forms.Button();
            this.CboBuscarPor2 = new System.Windows.Forms.ComboBox();
            this.DgvListaVentas = new System.Windows.Forms.DataGridView();
            this.TbcVentas.SuspendLayout();
            this.TbpVentaNueva.SuspendLayout();
            this.GbRegistrarVenta.SuspendLayout();
            this.GbDatosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogoBusqueda)).BeginInit();
            this.GbDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentaDetalle)).BeginInit();
            this.TbpHistorialVentas.SuspendLayout();
            this.GbDetallesVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetallesVenta2)).BeginInit();
            this.GbListaVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcVentas
            // 
            this.TbcVentas.Controls.Add(this.TbpVentaNueva);
            this.TbcVentas.Controls.Add(this.TbpHistorialVentas);
            this.TbcVentas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbcVentas.Location = new System.Drawing.Point(0, 0);
            this.TbcVentas.Name = "TbcVentas";
            this.TbcVentas.SelectedIndex = 0;
            this.TbcVentas.Size = new System.Drawing.Size(1072, 518);
            this.TbcVentas.TabIndex = 0;
            // 
            // TbpVentaNueva
            // 
            this.TbpVentaNueva.Controls.Add(this.GbRegistrarVenta);
            this.TbpVentaNueva.Controls.Add(this.GbDatosVenta);
            this.TbpVentaNueva.Controls.Add(this.GbDetalleVenta);
            this.TbpVentaNueva.Location = new System.Drawing.Point(4, 28);
            this.TbpVentaNueva.Name = "TbpVentaNueva";
            this.TbpVentaNueva.Padding = new System.Windows.Forms.Padding(3);
            this.TbpVentaNueva.Size = new System.Drawing.Size(1064, 486);
            this.TbpVentaNueva.TabIndex = 0;
            this.TbpVentaNueva.Text = "Nueva Venta";
            this.TbpVentaNueva.UseVisualStyleBackColor = true;
            // 
            // GbRegistrarVenta
            // 
            this.GbRegistrarVenta.Controls.Add(this.label1);
            this.GbRegistrarVenta.Controls.Add(this.Lbl13);
            this.GbRegistrarVenta.Controls.Add(this.LblTotal);
            this.GbRegistrarVenta.Controls.Add(this.Lbl12);
            this.GbRegistrarVenta.Controls.Add(this.LblDescuento);
            this.GbRegistrarVenta.Controls.Add(this.LblSubtotal);
            this.GbRegistrarVenta.Controls.Add(this.LblImpuesto);
            this.GbRegistrarVenta.Controls.Add(this.Lbl8);
            this.GbRegistrarVenta.Controls.Add(this.BtnNuevaVenta);
            this.GbRegistrarVenta.Controls.Add(this.BtnImprimirComprobante);
            this.GbRegistrarVenta.Controls.Add(this.Lbl5);
            this.GbRegistrarVenta.Controls.Add(this.BtnRegistrarVenta);
            this.GbRegistrarVenta.Location = new System.Drawing.Point(591, 248);
            this.GbRegistrarVenta.Name = "GbRegistrarVenta";
            this.GbRegistrarVenta.Size = new System.Drawing.Size(470, 235);
            this.GbRegistrarVenta.TabIndex = 28;
            this.GbRegistrarVenta.TabStop = false;
            this.GbRegistrarVenta.Text = "Registrar Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "--------------------------------------";
            // 
            // Lbl13
            // 
            this.Lbl13.AutoSize = true;
            this.Lbl13.Location = new System.Drawing.Point(28, 179);
            this.Lbl13.Name = "Lbl13";
            this.Lbl13.Size = new System.Drawing.Size(46, 19);
            this.Lbl13.TabIndex = 35;
            this.Lbl13.Text = "Total :";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotal.Location = new System.Drawing.Point(192, 179);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(19, 21);
            this.LblTotal.TabIndex = 34;
            this.LblTotal.Text = "0";
            // 
            // Lbl12
            // 
            this.Lbl12.AutoSize = true;
            this.Lbl12.Location = new System.Drawing.Point(28, 96);
            this.Lbl12.Name = "Lbl12";
            this.Lbl12.Size = new System.Drawing.Size(107, 19);
            this.Lbl12.TabIndex = 33;
            this.Lbl12.Text = "Descuento (%) :";
            // 
            // LblDescuento
            // 
            this.LblDescuento.AutoSize = true;
            this.LblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDescuento.Location = new System.Drawing.Point(192, 96);
            this.LblDescuento.Name = "LblDescuento";
            this.LblDescuento.Size = new System.Drawing.Size(25, 21);
            this.LblDescuento.TabIndex = 32;
            this.LblDescuento.Text = "-0";
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSubtotal.Location = new System.Drawing.Point(192, 60);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(19, 21);
            this.LblSubtotal.TabIndex = 31;
            this.LblSubtotal.Text = "0";
            // 
            // LblImpuesto
            // 
            this.LblImpuesto.AutoSize = true;
            this.LblImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblImpuesto.Location = new System.Drawing.Point(192, 131);
            this.LblImpuesto.Name = "LblImpuesto";
            this.LblImpuesto.Size = new System.Drawing.Size(19, 21);
            this.LblImpuesto.TabIndex = 29;
            this.LblImpuesto.Text = "0";
            // 
            // Lbl8
            // 
            this.Lbl8.AutoSize = true;
            this.Lbl8.Location = new System.Drawing.Point(28, 131);
            this.Lbl8.Name = "Lbl8";
            this.Lbl8.Size = new System.Drawing.Size(99, 19);
            this.Lbl8.TabIndex = 28;
            this.Lbl8.Text = "Impuesto (%) :";
            // 
            // BtnNuevaVenta
            // 
            this.BtnNuevaVenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevaVenta.Location = new System.Drawing.Point(328, 154);
            this.BtnNuevaVenta.Name = "BtnNuevaVenta";
            this.BtnNuevaVenta.Size = new System.Drawing.Size(109, 26);
            this.BtnNuevaVenta.TabIndex = 26;
            this.BtnNuevaVenta.Text = "Nueva Venta";
            this.BtnNuevaVenta.UseVisualStyleBackColor = true;
            this.BtnNuevaVenta.Click += new System.EventHandler(this.BtnNuevaVenta_Click);
            // 
            // BtnImprimirComprobante
            // 
            this.BtnImprimirComprobante.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirComprobante.Location = new System.Drawing.Point(296, 106);
            this.BtnImprimirComprobante.Name = "BtnImprimirComprobante";
            this.BtnImprimirComprobante.Size = new System.Drawing.Size(161, 26);
            this.BtnImprimirComprobante.TabIndex = 27;
            this.BtnImprimirComprobante.Text = "Imprimir Comprobante";
            this.BtnImprimirComprobante.UseVisualStyleBackColor = true;
            this.BtnImprimirComprobante.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Location = new System.Drawing.Point(28, 60);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(66, 19);
            this.Lbl5.TabIndex = 2;
            this.Lbl5.Text = "Subtotal :";
            // 
            // BtnRegistrarVenta
            // 
            this.BtnRegistrarVenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarVenta.Location = new System.Drawing.Point(327, 58);
            this.BtnRegistrarVenta.Name = "BtnRegistrarVenta";
            this.BtnRegistrarVenta.Size = new System.Drawing.Size(110, 26);
            this.BtnRegistrarVenta.TabIndex = 25;
            this.BtnRegistrarVenta.Text = "Registrar Venta";
            this.BtnRegistrarVenta.UseVisualStyleBackColor = true;
            this.BtnRegistrarVenta.Click += new System.EventHandler(this.BtnRegistrarVenta_Click);
            // 
            // GbDatosVenta
            // 
            this.GbDatosVenta.Controls.Add(this.TxtValorBusqueda);
            this.GbDatosVenta.Controls.Add(this.Lbl10);
            this.GbDatosVenta.Controls.Add(this.Lbl9);
            this.GbDatosVenta.Controls.Add(this.BtnBuscar);
            this.GbDatosVenta.Controls.Add(this.CboBuscarPor);
            this.GbDatosVenta.Controls.Add(this.DgvCatalogoBusqueda);
            this.GbDatosVenta.Controls.Add(this.BtnNuevoCliente);
            this.GbDatosVenta.Controls.Add(this.TxtIdCliente);
            this.GbDatosVenta.Controls.Add(this.Lbl2);
            this.GbDatosVenta.Controls.Add(this.TxtIdVenta);
            this.GbDatosVenta.Controls.Add(this.Lbl1);
            this.GbDatosVenta.Location = new System.Drawing.Point(3, 3);
            this.GbDatosVenta.Name = "GbDatosVenta";
            this.GbDatosVenta.Size = new System.Drawing.Size(1058, 244);
            this.GbDatosVenta.TabIndex = 0;
            this.GbDatosVenta.TabStop = false;
            this.GbDatosVenta.Text = "Datos de Venta";
            // 
            // TxtValorBusqueda
            // 
            this.TxtValorBusqueda.Location = new System.Drawing.Point(22, 201);
            this.TxtValorBusqueda.Name = "TxtValorBusqueda";
            this.TxtValorBusqueda.Size = new System.Drawing.Size(219, 26);
            this.TxtValorBusqueda.TabIndex = 21;
            // 
            // Lbl10
            // 
            this.Lbl10.AutoSize = true;
            this.Lbl10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl10.Location = new System.Drawing.Point(18, 179);
            this.Lbl10.Name = "Lbl10";
            this.Lbl10.Size = new System.Drawing.Size(171, 19);
            this.Lbl10.TabIndex = 20;
            this.Lbl10.Text = "Ingrese valor de búsqueda:";
            // 
            // Lbl9
            // 
            this.Lbl9.AutoSize = true;
            this.Lbl9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl9.Location = new System.Drawing.Point(18, 127);
            this.Lbl9.Name = "Lbl9";
            this.Lbl9.Size = new System.Drawing.Size(151, 19);
            this.Lbl9.TabIndex = 22;
            this.Lbl9.Text = "Ingresar productos por:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(279, 175);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(92, 26);
            this.BtnBuscar.TabIndex = 23;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CboBuscarPor
            // 
            this.CboBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBuscarPor.FormattingEnabled = true;
            this.CboBuscarPor.ItemHeight = 19;
            this.CboBuscarPor.Items.AddRange(new object[] {
            "ID Producto",
            "Nombre",
            "Categoria",
            "Marca"});
            this.CboBuscarPor.Location = new System.Drawing.Point(22, 149);
            this.CboBuscarPor.Name = "CboBuscarPor";
            this.CboBuscarPor.Size = new System.Drawing.Size(219, 27);
            this.CboBuscarPor.TabIndex = 24;
            // 
            // DgvCatalogoBusqueda
            // 
            this.DgvCatalogoBusqueda.AllowUserToAddRows = false;
            this.DgvCatalogoBusqueda.AllowUserToDeleteRows = false;
            this.DgvCatalogoBusqueda.AllowUserToResizeRows = false;
            this.DgvCatalogoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCatalogoBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBtnAgregar1,
            this.colIdProducto1,
            this.colNombre1,
            this.colMarca1,
            this.colCategoria1,
            this.colPrecioUnitario1,
            this.colCantidad1,
            this.colDescripcion1});
            this.DgvCatalogoBusqueda.Location = new System.Drawing.Point(400, 17);
            this.DgvCatalogoBusqueda.Name = "DgvCatalogoBusqueda";
            this.DgvCatalogoBusqueda.ReadOnly = true;
            this.DgvCatalogoBusqueda.RowHeadersVisible = false;
            this.DgvCatalogoBusqueda.Size = new System.Drawing.Size(627, 210);
            this.DgvCatalogoBusqueda.TabIndex = 2;
            this.DgvCatalogoBusqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCatalogoBusqueda_CellClick);
            // 
            // colBtnAgregar1
            // 
            this.colBtnAgregar1.HeaderText = "+";
            this.colBtnAgregar1.Name = "colBtnAgregar1";
            this.colBtnAgregar1.ReadOnly = true;
            this.colBtnAgregar1.Text = "+";
            this.colBtnAgregar1.Width = 24;
            // 
            // colIdProducto1
            // 
            this.colIdProducto1.HeaderText = "IdProducto";
            this.colIdProducto1.Name = "colIdProducto1";
            this.colIdProducto1.ReadOnly = true;
            this.colIdProducto1.Width = 103;
            // 
            // colNombre1
            // 
            this.colNombre1.HeaderText = "Nombre";
            this.colNombre1.Name = "colNombre1";
            this.colNombre1.ReadOnly = true;
            this.colNombre1.Width = 85;
            // 
            // colMarca1
            // 
            this.colMarca1.HeaderText = "Marca";
            this.colMarca1.Name = "colMarca1";
            this.colMarca1.ReadOnly = true;
            this.colMarca1.Width = 74;
            // 
            // colCategoria1
            // 
            this.colCategoria1.HeaderText = "Categoria";
            this.colCategoria1.Name = "colCategoria1";
            this.colCategoria1.ReadOnly = true;
            this.colCategoria1.Width = 93;
            // 
            // colPrecioUnitario1
            // 
            this.colPrecioUnitario1.HeaderText = "Precio U";
            this.colPrecioUnitario1.Name = "colPrecioUnitario1";
            this.colPrecioUnitario1.ReadOnly = true;
            this.colPrecioUnitario1.Width = 88;
            // 
            // colCantidad1
            // 
            this.colCantidad1.HeaderText = "Cantidad";
            this.colCantidad1.Name = "colCantidad1";
            this.colCantidad1.ReadOnly = true;
            this.colCantidad1.Width = 89;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.HeaderText = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.ReadOnly = true;
            this.colDescripcion1.Width = 106;
            // 
            // BtnNuevoCliente
            // 
            this.BtnNuevoCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoCliente.Location = new System.Drawing.Point(272, 98);
            this.BtnNuevoCliente.Name = "BtnNuevoCliente";
            this.BtnNuevoCliente.Size = new System.Drawing.Size(109, 26);
            this.BtnNuevoCliente.TabIndex = 1;
            this.BtnNuevoCliente.Text = "Nuevo Cliente";
            this.BtnNuevoCliente.UseVisualStyleBackColor = true;
            this.BtnNuevoCliente.Click += new System.EventHandler(this.BtnNuevoCliente_Click);
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(22, 98);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(192, 26);
            this.TxtIdCliente.TabIndex = 7;
            this.TxtIdCliente.Leave += new System.EventHandler(this.TxtIdCliente_Leave);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(18, 76);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(68, 19);
            this.Lbl2.TabIndex = 6;
            this.Lbl2.Text = "Id Cliente";
            // 
            // TxtIdVenta
            // 
            this.TxtIdVenta.Enabled = false;
            this.TxtIdVenta.Location = new System.Drawing.Point(22, 47);
            this.TxtIdVenta.Name = "TxtIdVenta";
            this.TxtIdVenta.Size = new System.Drawing.Size(192, 26);
            this.TxtIdVenta.TabIndex = 3;
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(18, 25);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(60, 19);
            this.Lbl1.TabIndex = 2;
            this.Lbl1.Text = "Id Venta";
            // 
            // GbDetalleVenta
            // 
            this.GbDetalleVenta.Controls.Add(this.BtnVaciarDetalles);
            this.GbDetalleVenta.Controls.Add(this.DgvVentaDetalle);
            this.GbDetalleVenta.Location = new System.Drawing.Point(5, 248);
            this.GbDetalleVenta.Name = "GbDetalleVenta";
            this.GbDetalleVenta.Size = new System.Drawing.Size(580, 235);
            this.GbDetalleVenta.TabIndex = 1;
            this.GbDetalleVenta.TabStop = false;
            this.GbDetalleVenta.Text = "Detalles de Venta";
            // 
            // BtnVaciarDetalles
            // 
            this.BtnVaciarDetalles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVaciarDetalles.Location = new System.Drawing.Point(220, 207);
            this.BtnVaciarDetalles.Name = "BtnVaciarDetalles";
            this.BtnVaciarDetalles.Size = new System.Drawing.Size(133, 26);
            this.BtnVaciarDetalles.TabIndex = 26;
            this.BtnVaciarDetalles.Text = "Vaciar lista detalles";
            this.BtnVaciarDetalles.UseVisualStyleBackColor = true;
            this.BtnVaciarDetalles.Click += new System.EventHandler(this.BtnVaciarDetalles_Click);
            // 
            // DgvVentaDetalle
            // 
            this.DgvVentaDetalle.AllowUserToAddRows = false;
            this.DgvVentaDetalle.AllowUserToDeleteRows = false;
            this.DgvVentaDetalle.AllowUserToResizeRows = false;
            this.DgvVentaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBtnBorrar,
            this.colIdProducto,
            this.colNombre,
            this.colPrecioUnitario,
            this.colCantidad,
            this.colSubtotal});
            this.DgvVentaDetalle.Location = new System.Drawing.Point(31, 20);
            this.DgvVentaDetalle.Name = "DgvVentaDetalle";
            this.DgvVentaDetalle.RowHeadersVisible = false;
            this.DgvVentaDetalle.Size = new System.Drawing.Size(520, 183);
            this.DgvVentaDetalle.TabIndex = 1;
            this.DgvVentaDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVentaDetalle_CellClick);
            // 
            // colBtnBorrar
            // 
            this.colBtnBorrar.Frozen = true;
            this.colBtnBorrar.HeaderText = "X";
            this.colBtnBorrar.Name = "colBtnBorrar";
            this.colBtnBorrar.Width = 30;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Frozen = true;
            this.colIdProducto.HeaderText = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            this.colIdProducto.Width = 103;
            // 
            // colNombre
            // 
            this.colNombre.Frozen = true;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 85;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.Frozen = true;
            this.colPrecioUnitario.HeaderText = "Precio Unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            this.colPrecioUnitario.Width = 125;
            // 
            // colCantidad
            // 
            this.colCantidad.Frozen = true;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colSubtotal
            // 
            this.colSubtotal.Frozen = true;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 84;
            // 
            // TbpHistorialVentas
            // 
            this.TbpHistorialVentas.Controls.Add(this.GbDetallesVenta);
            this.TbpHistorialVentas.Controls.Add(this.GbListaVentas);
            this.TbpHistorialVentas.Location = new System.Drawing.Point(4, 28);
            this.TbpHistorialVentas.Name = "TbpHistorialVentas";
            this.TbpHistorialVentas.Padding = new System.Windows.Forms.Padding(3);
            this.TbpHistorialVentas.Size = new System.Drawing.Size(1064, 486);
            this.TbpHistorialVentas.TabIndex = 1;
            this.TbpHistorialVentas.Text = "Historial Ventas";
            this.TbpHistorialVentas.UseVisualStyleBackColor = true;
            // 
            // GbDetallesVenta
            // 
            this.GbDetallesVenta.Controls.Add(this.DgvDetallesVenta2);
            this.GbDetallesVenta.Controls.Add(this.BtnImprimirComprobante2);
            this.GbDetallesVenta.Location = new System.Drawing.Point(506, 44);
            this.GbDetallesVenta.Name = "GbDetallesVenta";
            this.GbDetallesVenta.Size = new System.Drawing.Size(554, 403);
            this.GbDetallesVenta.TabIndex = 2;
            this.GbDetallesVenta.TabStop = false;
            this.GbDetallesVenta.Text = "Detalles de Venta";
            // 
            // DgvDetallesVenta2
            // 
            this.DgvDetallesVenta2.AllowUserToAddRows = false;
            this.DgvDetallesVenta2.AllowUserToDeleteRows = false;
            this.DgvDetallesVenta2.AllowUserToResizeColumns = false;
            this.DgvDetallesVenta2.AllowUserToResizeRows = false;
            this.DgvDetallesVenta2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDetallesVenta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetallesVenta2.Location = new System.Drawing.Point(9, 25);
            this.DgvDetallesVenta2.Name = "DgvDetallesVenta2";
            this.DgvDetallesVenta2.ReadOnly = true;
            this.DgvDetallesVenta2.RowHeadersVisible = false;
            this.DgvDetallesVenta2.Size = new System.Drawing.Size(534, 315);
            this.DgvDetallesVenta2.TabIndex = 29;
            // 
            // BtnImprimirComprobante2
            // 
            this.BtnImprimirComprobante2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirComprobante2.Location = new System.Drawing.Point(201, 359);
            this.BtnImprimirComprobante2.Name = "BtnImprimirComprobante2";
            this.BtnImprimirComprobante2.Size = new System.Drawing.Size(160, 26);
            this.BtnImprimirComprobante2.TabIndex = 28;
            this.BtnImprimirComprobante2.Text = "Imprimir Comprobante";
            this.BtnImprimirComprobante2.UseVisualStyleBackColor = true;
            // 
            // GbListaVentas
            // 
            this.GbListaVentas.Controls.Add(this.TxtValorBusqueda2);
            this.GbListaVentas.Controls.Add(this.Lbl7);
            this.GbListaVentas.Controls.Add(this.Lbl6);
            this.GbListaVentas.Controls.Add(this.BtnBuscar2);
            this.GbListaVentas.Controls.Add(this.CboBuscarPor2);
            this.GbListaVentas.Controls.Add(this.DgvListaVentas);
            this.GbListaVentas.Location = new System.Drawing.Point(3, 44);
            this.GbListaVentas.Name = "GbListaVentas";
            this.GbListaVentas.Size = new System.Drawing.Size(497, 403);
            this.GbListaVentas.TabIndex = 1;
            this.GbListaVentas.TabStop = false;
            this.GbListaVentas.Text = "Lista de Ventas";
            // 
            // TxtValorBusqueda2
            // 
            this.TxtValorBusqueda2.Location = new System.Drawing.Point(84, 117);
            this.TxtValorBusqueda2.Name = "TxtValorBusqueda2";
            this.TxtValorBusqueda2.Size = new System.Drawing.Size(219, 26);
            this.TxtValorBusqueda2.TabIndex = 26;
            // 
            // Lbl7
            // 
            this.Lbl7.AutoSize = true;
            this.Lbl7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl7.Location = new System.Drawing.Point(80, 95);
            this.Lbl7.Name = "Lbl7";
            this.Lbl7.Size = new System.Drawing.Size(171, 19);
            this.Lbl7.TabIndex = 25;
            this.Lbl7.Text = "Ingrese valor de búsqueda:";
            // 
            // Lbl6
            // 
            this.Lbl6.AutoSize = true;
            this.Lbl6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl6.Location = new System.Drawing.Point(80, 36);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(121, 19);
            this.Lbl6.TabIndex = 27;
            this.Lbl6.Text = "Buscar ventas por:";
            // 
            // BtnBuscar2
            // 
            this.BtnBuscar2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar2.Location = new System.Drawing.Point(347, 117);
            this.BtnBuscar2.Name = "BtnBuscar2";
            this.BtnBuscar2.Size = new System.Drawing.Size(92, 26);
            this.BtnBuscar2.TabIndex = 28;
            this.BtnBuscar2.Text = "Buscar";
            this.BtnBuscar2.UseVisualStyleBackColor = true;
            this.BtnBuscar2.Click += new System.EventHandler(this.BtnBuscar2_Click);
            // 
            // CboBuscarPor2
            // 
            this.CboBuscarPor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBuscarPor2.FormattingEnabled = true;
            this.CboBuscarPor2.ItemHeight = 19;
            this.CboBuscarPor2.Items.AddRange(new object[] {
            "ID Venta",
            "ID Usuario",
            "ID Cliente",
            "Fecha (DD/MM/AAAA)"});
            this.CboBuscarPor2.Location = new System.Drawing.Point(84, 58);
            this.CboBuscarPor2.Name = "CboBuscarPor2";
            this.CboBuscarPor2.Size = new System.Drawing.Size(219, 27);
            this.CboBuscarPor2.TabIndex = 29;
            // 
            // DgvListaVentas
            // 
            this.DgvListaVentas.AllowUserToAddRows = false;
            this.DgvListaVentas.AllowUserToDeleteRows = false;
            this.DgvListaVentas.AllowUserToResizeColumns = false;
            this.DgvListaVentas.AllowUserToResizeRows = false;
            this.DgvListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaVentas.Location = new System.Drawing.Point(5, 164);
            this.DgvListaVentas.Name = "DgvListaVentas";
            this.DgvListaVentas.ReadOnly = true;
            this.DgvListaVentas.Size = new System.Drawing.Size(485, 221);
            this.DgvListaVentas.TabIndex = 2;
            this.DgvListaVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaVentas_CellClick);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.TbcVentas);
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.TbcVentas.ResumeLayout(false);
            this.TbpVentaNueva.ResumeLayout(false);
            this.GbRegistrarVenta.ResumeLayout(false);
            this.GbRegistrarVenta.PerformLayout();
            this.GbDatosVenta.ResumeLayout(false);
            this.GbDatosVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogoBusqueda)).EndInit();
            this.GbDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentaDetalle)).EndInit();
            this.TbpHistorialVentas.ResumeLayout(false);
            this.GbDetallesVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetallesVenta2)).EndInit();
            this.GbListaVentas.ResumeLayout(false);
            this.GbListaVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcVentas;
        private System.Windows.Forms.TabPage TbpVentaNueva;
        private System.Windows.Forms.TabPage TbpHistorialVentas;
        private System.Windows.Forms.GroupBox GbDetalleVenta;
        private System.Windows.Forms.GroupBox GbDatosVenta;
        private System.Windows.Forms.DataGridView DgvVentaDetalle;
        private System.Windows.Forms.TextBox TxtIdVenta;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Button BtnNuevoCliente;
        private System.Windows.Forms.DataGridView DgvCatalogoBusqueda;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.TextBox TxtValorBusqueda;
        private System.Windows.Forms.Label Lbl10;
        private System.Windows.Forms.Label Lbl9;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CboBuscarPor;
        private System.Windows.Forms.Button BtnImprimirComprobante;
        private System.Windows.Forms.Button BtnVaciarDetalles;
        private System.Windows.Forms.Button BtnRegistrarVenta;
        private System.Windows.Forms.Button BtnNuevaVenta;
        private System.Windows.Forms.GroupBox GbDetallesVenta;
        private System.Windows.Forms.GroupBox GbListaVentas;
        private System.Windows.Forms.DataGridView DgvListaVentas;
        private System.Windows.Forms.TextBox TxtValorBusqueda2;
        private System.Windows.Forms.Label Lbl7;
        private System.Windows.Forms.Label Lbl6;
        private System.Windows.Forms.Button BtnBuscar2;
        private System.Windows.Forms.ComboBox CboBuscarPor2;
        private System.Windows.Forms.Button BtnImprimirComprobante2;
        private System.Windows.Forms.DataGridView DgvDetallesVenta2;
        private System.Windows.Forms.GroupBox GbRegistrarVenta;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnAgregar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion1;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl13;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label Lbl12;
        private System.Windows.Forms.Label LblDescuento;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.Label LblImpuesto;
        private System.Windows.Forms.Label Lbl8;
    }
}