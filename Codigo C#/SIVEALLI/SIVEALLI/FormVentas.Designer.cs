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
            this.GbDetalleVenta = new System.Windows.Forms.GroupBox();
            this.BtnNuevaVenta = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnVaciarDetalles = new System.Windows.Forms.Button();
            this.BtnRegistrarVenta = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.DgvVentaDetalle = new System.Windows.Forms.DataGridView();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GbDatosVenta = new System.Windows.Forms.GroupBox();
            this.TxtValorBusqueda = new System.Windows.Forms.TextBox();
            this.Lbl10 = new System.Windows.Forms.Label();
            this.Lbl9 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CboBuscarPor = new System.Windows.Forms.ComboBox();
            this.DgvCatalogoBusqueda = new System.Windows.Forms.DataGridView();
            this.BtnNuevoCliente = new System.Windows.Forms.Button();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.TxtIdVenta = new System.Windows.Forms.TextBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.TbpHistorialVentas = new System.Windows.Forms.TabPage();
            this.GbDetallesVenta = new System.Windows.Forms.GroupBox();
            this.DgvDetallesVenta2 = new System.Windows.Forms.DataGridView();
            this.colIdProducto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnBorrar2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnImprimir2 = new System.Windows.Forms.Button();
            this.GbListaVentas = new System.Windows.Forms.GroupBox();
            this.TxtValorBusqueda2 = new System.Windows.Forms.TextBox();
            this.Lbl7 = new System.Windows.Forms.Label();
            this.Lbl6 = new System.Windows.Forms.Label();
            this.BtnBuscar2 = new System.Windows.Forms.Button();
            this.CboBucarPor2 = new System.Windows.Forms.ComboBox();
            this.DgvListaVentas = new System.Windows.Forms.DataGridView();
            this.TbcVentas.SuspendLayout();
            this.TbpVentaNueva.SuspendLayout();
            this.GbDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentaDetalle)).BeginInit();
            this.GbDatosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogoBusqueda)).BeginInit();
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
            this.TbpVentaNueva.Controls.Add(this.GbDetalleVenta);
            this.TbpVentaNueva.Controls.Add(this.GbDatosVenta);
            this.TbpVentaNueva.Location = new System.Drawing.Point(4, 28);
            this.TbpVentaNueva.Name = "TbpVentaNueva";
            this.TbpVentaNueva.Padding = new System.Windows.Forms.Padding(3);
            this.TbpVentaNueva.Size = new System.Drawing.Size(1064, 486);
            this.TbpVentaNueva.TabIndex = 0;
            this.TbpVentaNueva.Text = "Nueva Venta";
            this.TbpVentaNueva.UseVisualStyleBackColor = true;
            // 
            // GbDetalleVenta
            // 
            this.GbDetalleVenta.Controls.Add(this.BtnNuevaVenta);
            this.GbDetalleVenta.Controls.Add(this.BtnImprimir);
            this.GbDetalleVenta.Controls.Add(this.BtnVaciarDetalles);
            this.GbDetalleVenta.Controls.Add(this.BtnRegistrarVenta);
            this.GbDetalleVenta.Controls.Add(this.LblTotal);
            this.GbDetalleVenta.Controls.Add(this.Lbl5);
            this.GbDetalleVenta.Controls.Add(this.DgvVentaDetalle);
            this.GbDetalleVenta.Location = new System.Drawing.Point(471, 3);
            this.GbDetalleVenta.Name = "GbDetalleVenta";
            this.GbDetalleVenta.Size = new System.Drawing.Size(590, 480);
            this.GbDetalleVenta.TabIndex = 1;
            this.GbDetalleVenta.TabStop = false;
            this.GbDetalleVenta.Text = "Detalles de Venta";
            // 
            // BtnNuevaVenta
            // 
            this.BtnNuevaVenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevaVenta.Location = new System.Drawing.Point(94, 435);
            this.BtnNuevaVenta.Name = "BtnNuevaVenta";
            this.BtnNuevaVenta.Size = new System.Drawing.Size(109, 26);
            this.BtnNuevaVenta.TabIndex = 26;
            this.BtnNuevaVenta.Text = "Nueva Venta";
            this.BtnNuevaVenta.UseVisualStyleBackColor = true;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(407, 435);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(92, 26);
            this.BtnImprimir.TabIndex = 27;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // BtnVaciarDetalles
            // 
            this.BtnVaciarDetalles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVaciarDetalles.Location = new System.Drawing.Point(45, 381);
            this.BtnVaciarDetalles.Name = "BtnVaciarDetalles";
            this.BtnVaciarDetalles.Size = new System.Drawing.Size(133, 26);
            this.BtnVaciarDetalles.TabIndex = 26;
            this.BtnVaciarDetalles.Text = "Vaciar lista detalles";
            this.BtnVaciarDetalles.UseVisualStyleBackColor = true;
            this.BtnVaciarDetalles.Click += new System.EventHandler(this.BtnVaciarDetalles_Click);
            // 
            // BtnRegistrarVenta
            // 
            this.BtnRegistrarVenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarVenta.Location = new System.Drawing.Point(249, 435);
            this.BtnRegistrarVenta.Name = "BtnRegistrarVenta";
            this.BtnRegistrarVenta.Size = new System.Drawing.Size(110, 26);
            this.BtnRegistrarVenta.TabIndex = 25;
            this.BtnRegistrarVenta.Text = "Registrar Venta";
            this.BtnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(482, 385);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(17, 19);
            this.LblTotal.TabIndex = 3;
            this.LblTotal.Text = "0";
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Location = new System.Drawing.Point(432, 385);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(50, 19);
            this.Lbl5.TabIndex = 2;
            this.Lbl5.Text = "Total : ";
            // 
            // DgvVentaDetalle
            // 
            this.DgvVentaDetalle.AllowUserToAddRows = false;
            this.DgvVentaDetalle.AllowUserToDeleteRows = false;
            this.DgvVentaDetalle.AllowUserToResizeColumns = false;
            this.DgvVentaDetalle.AllowUserToResizeRows = false;
            this.DgvVentaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvVentaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colNombre,
            this.colPrecioUnitario,
            this.colCantidad,
            this.colSubtotal,
            this.colBtnBorrar});
            this.DgvVentaDetalle.Location = new System.Drawing.Point(9, 32);
            this.DgvVentaDetalle.Name = "DgvVentaDetalle";
            this.DgvVentaDetalle.ReadOnly = true;
            this.DgvVentaDetalle.RowHeadersVisible = false;
            this.DgvVentaDetalle.Size = new System.Drawing.Size(573, 342);
            this.DgvVentaDetalle.TabIndex = 1;
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
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 89;
            // 
            // colSubtotal
            // 
            this.colSubtotal.Frozen = true;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 84;
            // 
            // colBtnBorrar
            // 
            this.colBtnBorrar.Frozen = true;
            this.colBtnBorrar.HeaderText = "";
            this.colBtnBorrar.Name = "colBtnBorrar";
            this.colBtnBorrar.ReadOnly = true;
            this.colBtnBorrar.Width = 5;
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
            this.GbDatosVenta.Size = new System.Drawing.Size(462, 480);
            this.GbDatosVenta.TabIndex = 0;
            this.GbDatosVenta.TabStop = false;
            this.GbDatosVenta.Text = "Datos de Venta";
            // 
            // TxtValorBusqueda
            // 
            this.TxtValorBusqueda.Location = new System.Drawing.Point(48, 207);
            this.TxtValorBusqueda.Name = "TxtValorBusqueda";
            this.TxtValorBusqueda.Size = new System.Drawing.Size(219, 26);
            this.TxtValorBusqueda.TabIndex = 21;
            // 
            // Lbl10
            // 
            this.Lbl10.AutoSize = true;
            this.Lbl10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl10.Location = new System.Drawing.Point(44, 185);
            this.Lbl10.Name = "Lbl10";
            this.Lbl10.Size = new System.Drawing.Size(171, 19);
            this.Lbl10.TabIndex = 20;
            this.Lbl10.Text = "Ingrese valor de búsqueda:";
            // 
            // Lbl9
            // 
            this.Lbl9.AutoSize = true;
            this.Lbl9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl9.Location = new System.Drawing.Point(44, 133);
            this.Lbl9.Name = "Lbl9";
            this.Lbl9.Size = new System.Drawing.Size(151, 19);
            this.Lbl9.TabIndex = 22;
            this.Lbl9.Text = "Ingresar productos por:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(307, 207);
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
            this.CboBuscarPor.Location = new System.Drawing.Point(48, 155);
            this.CboBuscarPor.Name = "CboBuscarPor";
            this.CboBuscarPor.Size = new System.Drawing.Size(219, 27);
            this.CboBuscarPor.TabIndex = 24;
            // 
            // DgvCatalogoBusqueda
            // 
            this.DgvCatalogoBusqueda.AllowUserToAddRows = false;
            this.DgvCatalogoBusqueda.AllowUserToDeleteRows = false;
            this.DgvCatalogoBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvCatalogoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCatalogoBusqueda.Location = new System.Drawing.Point(6, 252);
            this.DgvCatalogoBusqueda.Name = "DgvCatalogoBusqueda";
            this.DgvCatalogoBusqueda.ReadOnly = true;
            this.DgvCatalogoBusqueda.Size = new System.Drawing.Size(450, 209);
            this.DgvCatalogoBusqueda.TabIndex = 2;
            // 
            // BtnNuevoCliente
            // 
            this.BtnNuevoCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoCliente.Location = new System.Drawing.Point(298, 104);
            this.BtnNuevoCliente.Name = "BtnNuevoCliente";
            this.BtnNuevoCliente.Size = new System.Drawing.Size(109, 26);
            this.BtnNuevoCliente.TabIndex = 1;
            this.BtnNuevoCliente.Text = "Nuevo Cliente";
            this.BtnNuevoCliente.UseVisualStyleBackColor = true;
            this.BtnNuevoCliente.Click += new System.EventHandler(this.BtnNuevoCliente_Click);
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(48, 104);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(192, 26);
            this.TxtIdCliente.TabIndex = 7;
            this.TxtIdCliente.Leave += new System.EventHandler(this.TxtIdCliente_Leave);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(44, 82);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(68, 19);
            this.Lbl2.TabIndex = 6;
            this.Lbl2.Text = "Id Cliente";
            // 
            // TxtIdVenta
            // 
            this.TxtIdVenta.Enabled = false;
            this.TxtIdVenta.Location = new System.Drawing.Point(48, 53);
            this.TxtIdVenta.Name = "TxtIdVenta";
            this.TxtIdVenta.Size = new System.Drawing.Size(192, 26);
            this.TxtIdVenta.TabIndex = 3;
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(44, 31);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(60, 19);
            this.Lbl1.TabIndex = 2;
            this.Lbl1.Text = "Id Venta";
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
            this.GbDetallesVenta.Controls.Add(this.BtnImprimir2);
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
            this.DgvDetallesVenta2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto2,
            this.colNombre2,
            this.colPrecioUnitario2,
            this.colCantidad2,
            this.colSubtotal2,
            this.colBtnBorrar2});
            this.DgvDetallesVenta2.Location = new System.Drawing.Point(9, 25);
            this.DgvDetallesVenta2.Name = "DgvDetallesVenta2";
            this.DgvDetallesVenta2.ReadOnly = true;
            this.DgvDetallesVenta2.RowHeadersVisible = false;
            this.DgvDetallesVenta2.Size = new System.Drawing.Size(534, 315);
            this.DgvDetallesVenta2.TabIndex = 29;
            // 
            // colIdProducto2
            // 
            this.colIdProducto2.Frozen = true;
            this.colIdProducto2.HeaderText = "IdProducto";
            this.colIdProducto2.Name = "colIdProducto2";
            this.colIdProducto2.ReadOnly = true;
            this.colIdProducto2.Width = 103;
            // 
            // colNombre2
            // 
            this.colNombre2.Frozen = true;
            this.colNombre2.HeaderText = "Nombre";
            this.colNombre2.Name = "colNombre2";
            this.colNombre2.ReadOnly = true;
            this.colNombre2.Width = 85;
            // 
            // colPrecioUnitario2
            // 
            this.colPrecioUnitario2.Frozen = true;
            this.colPrecioUnitario2.HeaderText = "Precio Unitario";
            this.colPrecioUnitario2.Name = "colPrecioUnitario2";
            this.colPrecioUnitario2.ReadOnly = true;
            this.colPrecioUnitario2.Width = 125;
            // 
            // colCantidad2
            // 
            this.colCantidad2.Frozen = true;
            this.colCantidad2.HeaderText = "Cantidad";
            this.colCantidad2.Name = "colCantidad2";
            this.colCantidad2.ReadOnly = true;
            this.colCantidad2.Width = 89;
            // 
            // colSubtotal2
            // 
            this.colSubtotal2.Frozen = true;
            this.colSubtotal2.HeaderText = "Subtotal";
            this.colSubtotal2.Name = "colSubtotal2";
            this.colSubtotal2.ReadOnly = true;
            this.colSubtotal2.Width = 84;
            // 
            // colBtnBorrar2
            // 
            this.colBtnBorrar2.Frozen = true;
            this.colBtnBorrar2.HeaderText = "";
            this.colBtnBorrar2.Name = "colBtnBorrar2";
            this.colBtnBorrar2.ReadOnly = true;
            this.colBtnBorrar2.Width = 5;
            // 
            // BtnImprimir2
            // 
            this.BtnImprimir2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir2.Location = new System.Drawing.Point(225, 359);
            this.BtnImprimir2.Name = "BtnImprimir2";
            this.BtnImprimir2.Size = new System.Drawing.Size(92, 26);
            this.BtnImprimir2.TabIndex = 28;
            this.BtnImprimir2.Text = "Imprimir";
            this.BtnImprimir2.UseVisualStyleBackColor = true;
            // 
            // GbListaVentas
            // 
            this.GbListaVentas.Controls.Add(this.TxtValorBusqueda2);
            this.GbListaVentas.Controls.Add(this.Lbl7);
            this.GbListaVentas.Controls.Add(this.Lbl6);
            this.GbListaVentas.Controls.Add(this.BtnBuscar2);
            this.GbListaVentas.Controls.Add(this.CboBucarPor2);
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
            // 
            // CboBucarPor2
            // 
            this.CboBucarPor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBucarPor2.FormattingEnabled = true;
            this.CboBucarPor2.ItemHeight = 19;
            this.CboBucarPor2.Items.AddRange(new object[] {
            "ID Venta",
            "ID Usuario",
            "ID Cliente"});
            this.CboBucarPor2.Location = new System.Drawing.Point(84, 58);
            this.CboBucarPor2.Name = "CboBucarPor2";
            this.CboBucarPor2.Size = new System.Drawing.Size(219, 27);
            this.CboBucarPor2.TabIndex = 29;
            // 
            // DgvListaVentas
            // 
            this.DgvListaVentas.AllowUserToAddRows = false;
            this.DgvListaVentas.AllowUserToDeleteRows = false;
            this.DgvListaVentas.AllowUserToResizeColumns = false;
            this.DgvListaVentas.AllowUserToResizeRows = false;
            this.DgvListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaVentas.Location = new System.Drawing.Point(5, 164);
            this.DgvListaVentas.Name = "DgvListaVentas";
            this.DgvListaVentas.ReadOnly = true;
            this.DgvListaVentas.Size = new System.Drawing.Size(485, 221);
            this.DgvListaVentas.TabIndex = 2;
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
            this.GbDetalleVenta.ResumeLayout(false);
            this.GbDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentaDetalle)).EndInit();
            this.GbDatosVenta.ResumeLayout(false);
            this.GbDatosVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogoBusqueda)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnBorrar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.TextBox TxtValorBusqueda;
        private System.Windows.Forms.Label Lbl10;
        private System.Windows.Forms.Label Lbl9;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CboBuscarPor;
        private System.Windows.Forms.Button BtnImprimir;
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
        private System.Windows.Forms.ComboBox CboBucarPor2;
        private System.Windows.Forms.Button BtnImprimir2;
        private System.Windows.Forms.DataGridView DgvDetallesVenta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal2;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnBorrar2;
    }
}