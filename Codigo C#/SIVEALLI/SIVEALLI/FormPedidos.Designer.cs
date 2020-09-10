namespace SIVEALLI
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            this.CbProveedores = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DgvPedidosDetalle = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.LTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GbHistotialPedidos = new System.Windows.Forms.GroupBox();
            this.BtnCatalogo = new System.Windows.Forms.Button();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.TbfiltrarHistorial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnFiltrarHistorial = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.CbNuevoPed = new System.Windows.Forms.CheckBox();
            this.TbTermEntrega = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.CbProv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbCatalodoProductos = new System.Windows.Forms.GroupBox();
            this.BtnHistorial = new System.Windows.Forms.Button();
            this.DgvCatalogoProductos = new System.Windows.Forms.DataGridView();
            this.TbFiltrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PbCerrar = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.CbProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosDetalle)).BeginInit();
            this.GbHistotialPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GbCliente.SuspendLayout();
            this.GbCatalodoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogoProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // CbProveedores
            // 
            this.CbProveedores.Controls.Add(this.BtnLimpiar);
            this.CbProveedores.Controls.Add(this.BtnGuardar);
            this.CbProveedores.Controls.Add(this.BtnNuevo);
            this.CbProveedores.Controls.Add(this.DgvPedidosDetalle);
            this.CbProveedores.Controls.Add(this.button5);
            this.CbProveedores.Controls.Add(this.LTotal);
            this.CbProveedores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProveedores.Location = new System.Drawing.Point(398, 12);
            this.CbProveedores.Name = "CbProveedores";
            this.CbProveedores.Size = new System.Drawing.Size(660, 479);
            this.CbProveedores.TabIndex = 11;
            this.CbProveedores.TabStop = false;
            this.CbProveedores.Text = "Detalles de pedido";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(6, 436);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 37);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DgvPedidosDetalle
            // 
            this.DgvPedidosDetalle.AllowUserToAddRows = false;
            this.DgvPedidosDetalle.AllowUserToDeleteRows = false;
            this.DgvPedidosDetalle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvPedidosDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPedidosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidosDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNombre,
            this.ColPrecio,
            this.ColCantidad,
            this.ColSubTotal,
            this.ColBorrar,
            this.ColPos});
            this.DgvPedidosDetalle.Location = new System.Drawing.Point(6, 22);
            this.DgvPedidosDetalle.Name = "DgvPedidosDetalle";
            this.DgvPedidosDetalle.RowHeadersVisible = false;
            this.DgvPedidosDetalle.Size = new System.Drawing.Size(648, 389);
            this.DgvPedidosDetalle.TabIndex = 21;
            this.DgvPedidosDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedidosDetalle_CellContentClick);
            this.DgvPedidosDetalle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedidosDetalle_CellValueChanged);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id producto";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 105;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 200;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio Uni.";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 120;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Width = 80;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.HeaderText = "Sub. Total";
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            // 
            // ColBorrar
            // 
            this.ColBorrar.HeaderText = "";
            this.ColBorrar.Name = "ColBorrar";
            this.ColBorrar.Width = 40;
            // 
            // ColPos
            // 
            this.ColPos.HeaderText = "colPos";
            this.ColPos.Name = "ColPos";
            this.ColPos.Visible = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(562, 436);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 32);
            this.button5.TabIndex = 20;
            this.button5.Text = "Imprimir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.Location = new System.Drawing.Point(483, 414);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(120, 19);
            this.LTotal.TabIndex = 17;
            this.LTotal.Text = "Importe total: s/ 0 ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1092, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "CED";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GbHistotialPedidos
            // 
            this.GbHistotialPedidos.Controls.Add(this.BtnCatalogo);
            this.GbHistotialPedidos.Controls.Add(this.DgvPedidos);
            this.GbHistotialPedidos.Controls.Add(this.TbfiltrarHistorial);
            this.GbHistotialPedidos.Controls.Add(this.label5);
            this.GbHistotialPedidos.Controls.Add(this.BtnFiltrarHistorial);
            this.GbHistotialPedidos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbHistotialPedidos.Location = new System.Drawing.Point(12, 196);
            this.GbHistotialPedidos.Name = "GbHistotialPedidos";
            this.GbHistotialPedidos.Size = new System.Drawing.Size(380, 354);
            this.GbHistotialPedidos.TabIndex = 24;
            this.GbHistotialPedidos.TabStop = false;
            this.GbHistotialPedidos.Text = "Historial de pedidos";
            this.GbHistotialPedidos.Visible = false;
            // 
            // BtnCatalogo
            // 
            this.BtnCatalogo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCatalogo.Location = new System.Drawing.Point(282, 316);
            this.BtnCatalogo.Name = "BtnCatalogo";
            this.BtnCatalogo.Size = new System.Drawing.Size(92, 32);
            this.BtnCatalogo.TabIndex = 23;
            this.BtnCatalogo.Text = "Catalogo";
            this.BtnCatalogo.UseVisualStyleBackColor = true;
            this.BtnCatalogo.Click += new System.EventHandler(this.BtnCatalogo_Click);
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidos.Location = new System.Drawing.Point(6, 18);
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.RowHeadersVisible = false;
            this.DgvPedidos.Size = new System.Drawing.Size(368, 272);
            this.DgvPedidos.TabIndex = 22;
            this.DgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedidos_CellContentClick);
            // 
            // TbfiltrarHistorial
            // 
            this.TbfiltrarHistorial.Location = new System.Drawing.Point(10, 319);
            this.TbfiltrarHistorial.Name = "TbfiltrarHistorial";
            this.TbfiltrarHistorial.Size = new System.Drawing.Size(148, 26);
            this.TbfiltrarHistorial.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Filtrar busqueda por: ";
            // 
            // BtnFiltrarHistorial
            // 
            this.BtnFiltrarHistorial.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrarHistorial.Location = new System.Drawing.Point(175, 316);
            this.BtnFiltrarHistorial.Name = "BtnFiltrarHistorial";
            this.BtnFiltrarHistorial.Size = new System.Drawing.Size(92, 32);
            this.BtnFiltrarHistorial.TabIndex = 15;
            this.BtnFiltrarHistorial.Text = "Filtrar";
            this.BtnFiltrarHistorial.UseVisualStyleBackColor = true;
            this.BtnFiltrarHistorial.Click += new System.EventHandler(this.BtnFiltrarHistorial_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.Location = new System.Drawing.Point(175, 310);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(92, 32);
            this.BtnFiltrar.TabIndex = 15;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(398, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 61);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(597, 38);
            this.label10.TabIndex = 20;
            this.label10.Text = "Es importante cerrar el formulario al terminar de usarlo, para un mejor funcionam" +
    "iento del sistema.\r\nSi desea ver todos los productos, pulse filtrar sin ningun t" +
    "exto.";
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.CbNuevoPed);
            this.GbCliente.Controls.Add(this.TbTermEntrega);
            this.GbCliente.Controls.Add(this.label3);
            this.GbCliente.Controls.Add(this.DtpFechaPago);
            this.GbCliente.Controls.Add(this.CbProv);
            this.GbCliente.Controls.Add(this.label4);
            this.GbCliente.Controls.Add(this.label2);
            this.GbCliente.Controls.Add(this.TbId);
            this.GbCliente.Controls.Add(this.label1);
            this.GbCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCliente.Location = new System.Drawing.Point(12, 12);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(380, 183);
            this.GbCliente.TabIndex = 10;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Datos del pedido";
            // 
            // CbNuevoPed
            // 
            this.CbNuevoPed.AutoSize = true;
            this.CbNuevoPed.Location = new System.Drawing.Point(125, 18);
            this.CbNuevoPed.Name = "CbNuevoPed";
            this.CbNuevoPed.Size = new System.Drawing.Size(116, 23);
            this.CbNuevoPed.TabIndex = 24;
            this.CbNuevoPed.Text = "Pedido Nuevo";
            this.CbNuevoPed.UseVisualStyleBackColor = true;
            this.CbNuevoPed.CheckedChanged += new System.EventHandler(this.CbNuevoPed_CheckedChanged);
            // 
            // TbTermEntrega
            // 
            this.TbTermEntrega.Location = new System.Drawing.Point(10, 146);
            this.TbTermEntrega.Name = "TbTermEntrega";
            this.TbTermEntrega.Size = new System.Drawing.Size(364, 26);
            this.TbTermEntrega.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha de pago";
            // 
            // DtpFechaPago
            // 
            this.DtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaPago.Location = new System.Drawing.Point(264, 44);
            this.DtpFechaPago.Name = "DtpFechaPago";
            this.DtpFechaPago.Size = new System.Drawing.Size(110, 26);
            this.DtpFechaPago.TabIndex = 11;
            this.DtpFechaPago.Value = new System.DateTime(2000, 1, 1, 19, 27, 0, 0);
            // 
            // CbProv
            // 
            this.CbProv.FormattingEnabled = true;
            this.CbProv.Location = new System.Drawing.Point(10, 94);
            this.CbProv.Name = "CbProv";
            this.CbProv.Size = new System.Drawing.Size(253, 27);
            this.CbProv.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Terminos de pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proveedor";
            // 
            // TbId
            // 
            this.TbId.Enabled = false;
            this.TbId.Location = new System.Drawing.Point(9, 44);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(103, 26);
            this.TbId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id pedido";
            // 
            // GbCatalodoProductos
            // 
            this.GbCatalodoProductos.Controls.Add(this.BtnHistorial);
            this.GbCatalodoProductos.Controls.Add(this.DgvCatalogoProductos);
            this.GbCatalodoProductos.Controls.Add(this.TbFiltrar);
            this.GbCatalodoProductos.Controls.Add(this.BtnFiltrar);
            this.GbCatalodoProductos.Controls.Add(this.label7);
            this.GbCatalodoProductos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCatalodoProductos.Location = new System.Drawing.Point(12, 196);
            this.GbCatalodoProductos.Name = "GbCatalodoProductos";
            this.GbCatalodoProductos.Size = new System.Drawing.Size(380, 354);
            this.GbCatalodoProductos.TabIndex = 25;
            this.GbCatalodoProductos.TabStop = false;
            this.GbCatalodoProductos.Text = "Catalogo de productos";
            // 
            // BtnHistorial
            // 
            this.BtnHistorial.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistorial.Location = new System.Drawing.Point(282, 311);
            this.BtnHistorial.Name = "BtnHistorial";
            this.BtnHistorial.Size = new System.Drawing.Size(92, 32);
            this.BtnHistorial.TabIndex = 23;
            this.BtnHistorial.Text = "Historial";
            this.BtnHistorial.UseVisualStyleBackColor = true;
            this.BtnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // DgvCatalogoProductos
            // 
            this.DgvCatalogoProductos.AllowUserToAddRows = false;
            this.DgvCatalogoProductos.AllowUserToDeleteRows = false;
            this.DgvCatalogoProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvCatalogoProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCatalogoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCatalogoProductos.Location = new System.Drawing.Point(6, 18);
            this.DgvCatalogoProductos.Name = "DgvCatalogoProductos";
            this.DgvCatalogoProductos.RowHeadersVisible = false;
            this.DgvCatalogoProductos.Size = new System.Drawing.Size(368, 272);
            this.DgvCatalogoProductos.TabIndex = 22;
            this.DgvCatalogoProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCatalogoProductos_CellContentClick_1);
            this.DgvCatalogoProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCatalogoProductos_CellValueChanged);
            // 
            // TbFiltrar
            // 
            this.TbFiltrar.Location = new System.Drawing.Point(10, 314);
            this.TbFiltrar.Name = "TbFiltrar";
            this.TbFiltrar.Size = new System.Drawing.Size(148, 26);
            this.TbFiltrar.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Filtrar busqueda por: ";
            // 
            // PbCerrar
            // 
            this.PbCerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PbCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbCerrar.BackgroundImage")));
            this.PbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PbCerrar.Image")));
            this.PbCerrar.Location = new System.Drawing.Point(1060, 3);
            this.PbCerrar.Name = "PbCerrar";
            this.PbCerrar.Size = new System.Drawing.Size(25, 25);
            this.PbCerrar.TabIndex = 34;
            this.PbCerrar.TabStop = false;
            this.PbCerrar.Click += new System.EventHandler(this.PbCerrar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(238, 436);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(92, 37);
            this.BtnLimpiar.TabIndex = 36;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(122, 436);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(92, 37);
            this.BtnNuevo.TabIndex = 35;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.PbCerrar);
            this.Controls.Add(this.GbCatalodoProductos);
            this.Controls.Add(this.GbHistotialPedidos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CbProveedores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbCliente);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            this.CbProveedores.ResumeLayout(false);
            this.CbProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosDetalle)).EndInit();
            this.GbHistotialPedidos.ResumeLayout(false);
            this.GbHistotialPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.GbCatalodoProductos.ResumeLayout(false);
            this.GbCatalodoProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogoProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CbProveedores;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPedidosDetalle;
        private System.Windows.Forms.ComboBox CbProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPos;
        private System.Windows.Forms.GroupBox GbHistotialPedidos;
        private System.Windows.Forms.Button BtnCatalogo;
        private System.Windows.Forms.DataGridView DgvPedidos;
        private System.Windows.Forms.TextBox TbfiltrarHistorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnFiltrarHistorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpFechaPago;
        private System.Windows.Forms.GroupBox GbCatalodoProductos;
        private System.Windows.Forms.Button BtnHistorial;
        private System.Windows.Forms.DataGridView DgvCatalogoProductos;
        private System.Windows.Forms.TextBox TbFiltrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbTermEntrega;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CbNuevoPed;
        private System.Windows.Forms.PictureBox PbCerrar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnNuevo;
    }
}