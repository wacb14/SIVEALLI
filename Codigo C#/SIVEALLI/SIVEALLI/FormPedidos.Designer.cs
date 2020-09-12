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
            this.BtnLimpiar = new System.Windows.Forms.Button();
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GbHistotialPedidos = new System.Windows.Forms.GroupBox();
            this.BtnMostrarTodPedidos = new System.Windows.Forms.Button();
            this.CbBuscarPedido = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnFiltrarHistorial = new System.Windows.Forms.Button();
            this.TbfiltrarHistorial = new System.Windows.Forms.TextBox();
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
            this.BtnMostrarTodo = new System.Windows.Forms.Button();
            this.CbBuscar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbFiltrar = new System.Windows.Forms.TextBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvCatalogoProductos = new System.Windows.Forms.DataGridView();
            this.TbcVentas = new System.Windows.Forms.TabControl();
            this.TbpVentaNueva = new System.Windows.Forms.TabPage();
            this.TbpHistorialVentas = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblFechaPago = new System.Windows.Forms.Label();
            this.LblTerm = new System.Windows.Forms.Label();
            this.LbProveedor = new System.Windows.Forms.Label();
            this.LbId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DgvPedidosDetalle2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.LbTotal2 = new System.Windows.Forms.Label();
            this.PbCerrar = new System.Windows.Forms.PictureBox();
            this.BtnLimp2 = new System.Windows.Forms.Button();
            this.LblFechaPedido = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CbProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosDetalle)).BeginInit();
            this.GbHistotialPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
            this.GbCliente.SuspendLayout();
            this.GbCatalodoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogoProductos)).BeginInit();
            this.TbcVentas.SuspendLayout();
            this.TbpVentaNueva.SuspendLayout();
            this.TbpHistorialVentas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosDetalle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // CbProveedores
            // 
            this.CbProveedores.Controls.Add(this.BtnLimpiar);
            this.CbProveedores.Controls.Add(this.DgvPedidosDetalle);
            this.CbProveedores.Controls.Add(this.button5);
            this.CbProveedores.Controls.Add(this.LTotal);
            this.CbProveedores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProveedores.Location = new System.Drawing.Point(3, 191);
            this.CbProveedores.Name = "CbProveedores";
            this.CbProveedores.Size = new System.Drawing.Size(660, 330);
            this.CbProveedores.TabIndex = 11;
            this.CbProveedores.TabStop = false;
            this.CbProveedores.Text = "Detalles de pedido";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(5, 292);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(152, 32);
            this.BtnLimpiar.TabIndex = 36;
            this.BtnLimpiar.Text = "Limpiar registros";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
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
            this.DgvPedidosDetalle.Size = new System.Drawing.Size(648, 245);
            this.DgvPedidosDetalle.TabIndex = 21;
            this.DgvPedidosDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedidosDetalle_CellClick);
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
            this.ColCantidad.ReadOnly = true;
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
            this.button5.Location = new System.Drawing.Point(509, 292);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 32);
            this.button5.TabIndex = 20;
            this.button5.Text = "Imprimir documento";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.Location = new System.Drawing.Point(480, 270);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(120, 19);
            this.LTotal.TabIndex = 17;
            this.LTotal.Text = "Importe total: s/ 0 ";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(462, 111);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(152, 32);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Registrar pedido";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(462, 73);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(152, 32);
            this.BtnNuevo.TabIndex = 35;
            this.BtnNuevo.Text = "Nuevo pedido";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
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
            this.GbHistotialPedidos.Controls.Add(this.BtnMostrarTodPedidos);
            this.GbHistotialPedidos.Controls.Add(this.CbBuscarPedido);
            this.GbHistotialPedidos.Controls.Add(this.label8);
            this.GbHistotialPedidos.Controls.Add(this.DgvPedidos);
            this.GbHistotialPedidos.Controls.Add(this.label5);
            this.GbHistotialPedidos.Controls.Add(this.BtnFiltrarHistorial);
            this.GbHistotialPedidos.Controls.Add(this.TbfiltrarHistorial);
            this.GbHistotialPedidos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbHistotialPedidos.Location = new System.Drawing.Point(3, 3);
            this.GbHistotialPedidos.Name = "GbHistotialPedidos";
            this.GbHistotialPedidos.Size = new System.Drawing.Size(389, 518);
            this.GbHistotialPedidos.TabIndex = 24;
            this.GbHistotialPedidos.TabStop = false;
            this.GbHistotialPedidos.Text = "Lista de pedidos";
            // 
            // BtnMostrarTodPedidos
            // 
            this.BtnMostrarTodPedidos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarTodPedidos.Location = new System.Drawing.Point(101, 128);
            this.BtnMostrarTodPedidos.Name = "BtnMostrarTodPedidos";
            this.BtnMostrarTodPedidos.Size = new System.Drawing.Size(177, 32);
            this.BtnMostrarTodPedidos.TabIndex = 30;
            this.BtnMostrarTodPedidos.Text = "Mostrar todos los pedidos";
            this.BtnMostrarTodPedidos.UseVisualStyleBackColor = true;
            this.BtnMostrarTodPedidos.Click += new System.EventHandler(this.BtnMostrarTodPedidos_Click);
            // 
            // CbBuscarPedido
            // 
            this.CbBuscarPedido.FormattingEnabled = true;
            this.CbBuscarPedido.Items.AddRange(new object[] {
            "ID Pedido",
            "ID Proveedor",
            "ID Usuario",
            "Fecha de pedido"});
            this.CbBuscarPedido.Location = new System.Drawing.Point(44, 44);
            this.CbBuscarPedido.Name = "CbBuscarPedido";
            this.CbBuscarPedido.Size = new System.Drawing.Size(158, 27);
            this.CbBuscarPedido.TabIndex = 29;
            this.CbBuscarPedido.Text = "ID Pedido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "Buscar pedidos por:";
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidos.Location = new System.Drawing.Point(3, 166);
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.RowHeadersVisible = false;
            this.DgvPedidos.Size = new System.Drawing.Size(380, 346);
            this.DgvPedidos.TabIndex = 22;
            this.DgvPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedidos_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ingrese el valor de busqueda:";
            // 
            // BtnFiltrarHistorial
            // 
            this.BtnFiltrarHistorial.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrarHistorial.Location = new System.Drawing.Point(254, 93);
            this.BtnFiltrarHistorial.Name = "BtnFiltrarHistorial";
            this.BtnFiltrarHistorial.Size = new System.Drawing.Size(92, 32);
            this.BtnFiltrarHistorial.TabIndex = 15;
            this.BtnFiltrarHistorial.Text = "Buscar";
            this.BtnFiltrarHistorial.UseVisualStyleBackColor = true;
            this.BtnFiltrarHistorial.Click += new System.EventHandler(this.BtnFiltrarHistorial_Click);
            // 
            // TbfiltrarHistorial
            // 
            this.TbfiltrarHistorial.Location = new System.Drawing.Point(44, 96);
            this.TbfiltrarHistorial.Name = "TbfiltrarHistorial";
            this.TbfiltrarHistorial.Size = new System.Drawing.Size(204, 26);
            this.TbfiltrarHistorial.TabIndex = 16;
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.BtnLimp2);
            this.GbCliente.Controls.Add(this.CbNuevoPed);
            this.GbCliente.Controls.Add(this.BtnNuevo);
            this.GbCliente.Controls.Add(this.BtnGuardar);
            this.GbCliente.Controls.Add(this.TbTermEntrega);
            this.GbCliente.Controls.Add(this.label3);
            this.GbCliente.Controls.Add(this.DtpFechaPago);
            this.GbCliente.Controls.Add(this.CbProv);
            this.GbCliente.Controls.Add(this.label4);
            this.GbCliente.Controls.Add(this.label2);
            this.GbCliente.Controls.Add(this.TbId);
            this.GbCliente.Controls.Add(this.label1);
            this.GbCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCliente.Location = new System.Drawing.Point(3, 3);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(660, 183);
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
            this.CbNuevoPed.Visible = false;
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
            this.GbCatalodoProductos.Controls.Add(this.BtnMostrarTodo);
            this.GbCatalodoProductos.Controls.Add(this.CbBuscar);
            this.GbCatalodoProductos.Controls.Add(this.label9);
            this.GbCatalodoProductos.Controls.Add(this.TbFiltrar);
            this.GbCatalodoProductos.Controls.Add(this.BtnFiltrar);
            this.GbCatalodoProductos.Controls.Add(this.label7);
            this.GbCatalodoProductos.Controls.Add(this.DgvCatalogoProductos);
            this.GbCatalodoProductos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCatalodoProductos.Location = new System.Drawing.Point(669, 3);
            this.GbCatalodoProductos.Name = "GbCatalodoProductos";
            this.GbCatalodoProductos.Size = new System.Drawing.Size(389, 518);
            this.GbCatalodoProductos.TabIndex = 25;
            this.GbCatalodoProductos.TabStop = false;
            this.GbCatalodoProductos.Text = "Catalogo de productos";
            // 
            // BtnMostrarTodo
            // 
            this.BtnMostrarTodo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarTodo.Location = new System.Drawing.Point(101, 126);
            this.BtnMostrarTodo.Name = "BtnMostrarTodo";
            this.BtnMostrarTodo.Size = new System.Drawing.Size(192, 32);
            this.BtnMostrarTodo.TabIndex = 28;
            this.BtnMostrarTodo.Text = "Mostrar todos los productos";
            this.BtnMostrarTodo.UseVisualStyleBackColor = true;
            this.BtnMostrarTodo.Click += new System.EventHandler(this.BtnMostrarTodo_Click);
            // 
            // CbBuscar
            // 
            this.CbBuscar.FormattingEnabled = true;
            this.CbBuscar.Items.AddRange(new object[] {
            "ID Producto",
            "Nombre",
            "Categoria",
            "Marca",
            "Estado"});
            this.CbBuscar.Location = new System.Drawing.Point(6, 41);
            this.CbBuscar.Name = "CbBuscar";
            this.CbBuscar.Size = new System.Drawing.Size(141, 27);
            this.CbBuscar.TabIndex = 27;
            this.CbBuscar.Text = "ID Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Buscar Productos por:";
            // 
            // TbFiltrar
            // 
            this.TbFiltrar.Location = new System.Drawing.Point(6, 94);
            this.TbFiltrar.Name = "TbFiltrar";
            this.TbFiltrar.Size = new System.Drawing.Size(199, 26);
            this.TbFiltrar.TabIndex = 25;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.Location = new System.Drawing.Point(245, 91);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(92, 32);
            this.BtnFiltrar.TabIndex = 23;
            this.BtnFiltrar.Text = "Buscar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ingrese el valor de busqueda:";
            // 
            // DgvCatalogoProductos
            // 
            this.DgvCatalogoProductos.AllowUserToAddRows = false;
            this.DgvCatalogoProductos.AllowUserToDeleteRows = false;
            this.DgvCatalogoProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvCatalogoProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCatalogoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCatalogoProductos.Location = new System.Drawing.Point(6, 164);
            this.DgvCatalogoProductos.Name = "DgvCatalogoProductos";
            this.DgvCatalogoProductos.RowHeadersVisible = false;
            this.DgvCatalogoProductos.Size = new System.Drawing.Size(377, 348);
            this.DgvCatalogoProductos.TabIndex = 22;
            this.DgvCatalogoProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCatalogoProductos_CellContentClick_1);
            this.DgvCatalogoProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCatalogoProductos_CellValueChanged);
            // 
            // TbcVentas
            // 
            this.TbcVentas.Controls.Add(this.TbpVentaNueva);
            this.TbcVentas.Controls.Add(this.TbpHistorialVentas);
            this.TbcVentas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbcVentas.Location = new System.Drawing.Point(0, 0);
            this.TbcVentas.Name = "TbcVentas";
            this.TbcVentas.SelectedIndex = 0;
            this.TbcVentas.Size = new System.Drawing.Size(1072, 556);
            this.TbcVentas.TabIndex = 35;
            // 
            // TbpVentaNueva
            // 
            this.TbpVentaNueva.Controls.Add(this.GbCatalodoProductos);
            this.TbpVentaNueva.Controls.Add(this.GbCliente);
            this.TbpVentaNueva.Controls.Add(this.CbProveedores);
            this.TbpVentaNueva.Location = new System.Drawing.Point(4, 28);
            this.TbpVentaNueva.Name = "TbpVentaNueva";
            this.TbpVentaNueva.Padding = new System.Windows.Forms.Padding(3);
            this.TbpVentaNueva.Size = new System.Drawing.Size(1064, 524);
            this.TbpVentaNueva.TabIndex = 0;
            this.TbpVentaNueva.Text = "Nuevo pedido";
            this.TbpVentaNueva.UseVisualStyleBackColor = true;
            // 
            // TbpHistorialVentas
            // 
            this.TbpHistorialVentas.Controls.Add(this.groupBox1);
            this.TbpHistorialVentas.Controls.Add(this.GbHistotialPedidos);
            this.TbpHistorialVentas.Location = new System.Drawing.Point(4, 28);
            this.TbpHistorialVentas.Name = "TbpHistorialVentas";
            this.TbpHistorialVentas.Padding = new System.Windows.Forms.Padding(3);
            this.TbpHistorialVentas.Size = new System.Drawing.Size(1064, 524);
            this.TbpHistorialVentas.TabIndex = 1;
            this.TbpHistorialVentas.Text = "Historial pedidos";
            this.TbpHistorialVentas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblFechaPedido);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.LblFechaPago);
            this.groupBox1.Controls.Add(this.LblTerm);
            this.groupBox1.Controls.Add(this.LbProveedor);
            this.groupBox1.Controls.Add(this.LbId);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.DgvPedidosDetalle2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.LbTotal2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(398, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 518);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de pedido";
            // 
            // LblFechaPago
            // 
            this.LblFechaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFechaPago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaPago.Location = new System.Drawing.Point(370, 57);
            this.LblFechaPago.Name = "LblFechaPago";
            this.LblFechaPago.Size = new System.Drawing.Size(88, 21);
            this.LblFechaPago.TabIndex = 37;
            // 
            // LblTerm
            // 
            this.LblTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTerm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTerm.Location = new System.Drawing.Point(141, 92);
            this.LblTerm.Name = "LblTerm";
            this.LblTerm.Size = new System.Drawing.Size(317, 21);
            this.LblTerm.TabIndex = 36;
            // 
            // LbProveedor
            // 
            this.LbProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbProveedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProveedor.Location = new System.Drawing.Point(88, 57);
            this.LbProveedor.Name = "LbProveedor";
            this.LbProveedor.Size = new System.Drawing.Size(153, 21);
            this.LbProveedor.TabIndex = 35;
            // 
            // LbId
            // 
            this.LbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbId.Location = new System.Drawing.Point(88, 21);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(131, 21);
            this.LbId.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(247, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "Fecha de pago:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Terminos de pedido:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Proveedor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "Id pedido:";
            // 
            // DgvPedidosDetalle2
            // 
            this.DgvPedidosDetalle2.AllowUserToAddRows = false;
            this.DgvPedidosDetalle2.AllowUserToDeleteRows = false;
            this.DgvPedidosDetalle2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvPedidosDetalle2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPedidosDetalle2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidosDetalle2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewButtonColumn1,
            this.dataGridViewTextBoxColumn6});
            this.DgvPedidosDetalle2.Location = new System.Drawing.Point(6, 122);
            this.DgvPedidosDetalle2.Name = "DgvPedidosDetalle2";
            this.DgvPedidosDetalle2.RowHeadersVisible = false;
            this.DgvPedidosDetalle2.Size = new System.Drawing.Size(648, 330);
            this.DgvPedidosDetalle2.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio Uni.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Sub. Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "colPos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(506, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "Imprimir documento";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LbTotal2
            // 
            this.LbTotal2.AutoSize = true;
            this.LbTotal2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotal2.Location = new System.Drawing.Point(483, 458);
            this.LbTotal2.Name = "LbTotal2";
            this.LbTotal2.Size = new System.Drawing.Size(120, 19);
            this.LbTotal2.TabIndex = 17;
            this.LbTotal2.Text = "Importe total: s/ 0 ";
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
            this.PbCerrar.TabIndex = 36;
            this.PbCerrar.TabStop = false;
            this.PbCerrar.Click += new System.EventHandler(this.PbCerrar_Click);
            // 
            // BtnLimp2
            // 
            this.BtnLimp2.Location = new System.Drawing.Point(462, 25);
            this.BtnLimp2.Name = "BtnLimp2";
            this.BtnLimp2.Size = new System.Drawing.Size(152, 32);
            this.BtnLimp2.TabIndex = 37;
            this.BtnLimp2.Text = "Limpiar datos";
            this.BtnLimp2.UseVisualStyleBackColor = true;
            this.BtnLimp2.Click += new System.EventHandler(this.BtnLimp2_Click);
            // 
            // LblFechaPedido
            // 
            this.LblFechaPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFechaPedido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaPedido.Location = new System.Drawing.Point(370, 22);
            this.LblFechaPedido.Name = "LblFechaPedido";
            this.LblFechaPedido.Size = new System.Drawing.Size(88, 21);
            this.LblFechaPedido.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(247, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 19);
            this.label14.TabIndex = 38;
            this.label14.Text = "Fecha del pedido:";
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.PbCerrar);
            this.Controls.Add(this.TbcVentas);
            this.Controls.Add(this.button1);
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
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.GbCatalodoProductos.ResumeLayout(false);
            this.GbCatalodoProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogoProductos)).EndInit();
            this.TbcVentas.ResumeLayout(false);
            this.TbpVentaNueva.ResumeLayout(false);
            this.TbpHistorialVentas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosDetalle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CbProveedores;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPedidosDetalle;
        private System.Windows.Forms.ComboBox CbProv;
        private System.Windows.Forms.GroupBox GbHistotialPedidos;
        private System.Windows.Forms.DataGridView DgvPedidos;
        private System.Windows.Forms.TextBox TbfiltrarHistorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnFiltrarHistorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpFechaPago;
        private System.Windows.Forms.GroupBox GbCatalodoProductos;
        private System.Windows.Forms.DataGridView DgvCatalogoProductos;
        private System.Windows.Forms.TextBox TbTermEntrega;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CbNuevoPed;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TabControl TbcVentas;
        private System.Windows.Forms.TabPage TbpVentaNueva;
        private System.Windows.Forms.TabPage TbpHistorialVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvPedidosDetalle2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LbTotal2;
        private System.Windows.Forms.TextBox TbFiltrar;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnMostrarTodo;
        private System.Windows.Forms.ComboBox CbBuscarPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnMostrarTodPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPos;
        private System.Windows.Forms.Label LblFechaPago;
        private System.Windows.Forms.Label LblTerm;
        private System.Windows.Forms.Label LbProveedor;
        private System.Windows.Forms.Label LbId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox PbCerrar;
        private System.Windows.Forms.Button BtnLimp2;
        private System.Windows.Forms.Label LblFechaPedido;
        private System.Windows.Forms.Label label14;
    }
}