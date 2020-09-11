namespace SIVEALLI
{
    partial class FormDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevoluciones));
            this.PbCerrar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GbVentas = new System.Windows.Forms.GroupBox();
            this.BtnMostrarTodo = new System.Windows.Forms.Button();
            this.CbBuscar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTotalPagar = new System.Windows.Forms.Label();
            this.Lbl12 = new System.Windows.Forms.Label();
            this.LblDescuento = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.LblImpuesto = new System.Windows.Forms.Label();
            this.Lbl8 = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.BtnBuscarVentas = new System.Windows.Forms.Button();
            this.TbBuscarVentas = new System.Windows.Forms.TextBox();
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCED = new System.Windows.Forms.Button();
            this.TbIdVenta = new System.Windows.Forms.TextBox();
            this.CbNuevoDev = new System.Windows.Forms.CheckBox();
            this.TbRazon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CbProveedores = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DgvDevolucionDetalle = new System.Windows.Forms.DataGridView();
            this.ColBorrar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidadDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTotal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpFechaDevo = new System.Windows.Forms.DateTimePicker();
            this.GbHistorialDevo = new System.Windows.Forms.GroupBox();
            this.DgvDevoluciones = new System.Windows.Forms.DataGridView();
            this.TbBuscarDevol = new System.Windows.Forms.TextBox();
            this.BtnBuscarDevoluciones = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            this.GbCliente.SuspendLayout();
            this.CbProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDevolucionDetalle)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.GbHistorialDevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDevoluciones)).BeginInit();
            this.SuspendLayout();
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
            this.PbCerrar.TabIndex = 33;
            this.PbCerrar.TabStop = false;
            this.PbCerrar.Click += new System.EventHandler(this.PbCerrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1092, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 30;
            this.button1.Text = "CED";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1072, 556);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GbVentas);
            this.tabPage1.Controls.Add(this.GbCliente);
            this.tabPage1.Controls.Add(this.CbProveedores);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1064, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nueva devolución";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GbVentas
            // 
            this.GbVentas.Controls.Add(this.BtnMostrarTodo);
            this.GbVentas.Controls.Add(this.CbBuscar);
            this.GbVentas.Controls.Add(this.label9);
            this.GbVentas.Controls.Add(this.label8);
            this.GbVentas.Controls.Add(this.label3);
            this.GbVentas.Controls.Add(this.LblTotalPagar);
            this.GbVentas.Controls.Add(this.Lbl12);
            this.GbVentas.Controls.Add(this.LblDescuento);
            this.GbVentas.Controls.Add(this.LblSubTotal);
            this.GbVentas.Controls.Add(this.LblImpuesto);
            this.GbVentas.Controls.Add(this.Lbl8);
            this.GbVentas.Controls.Add(this.Lbl5);
            this.GbVentas.Controls.Add(this.DgvVentas);
            this.GbVentas.Controls.Add(this.BtnBuscarVentas);
            this.GbVentas.Controls.Add(this.TbBuscarVentas);
            this.GbVentas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbVentas.Location = new System.Drawing.Point(669, 6);
            this.GbVentas.Name = "GbVentas";
            this.GbVentas.Size = new System.Drawing.Size(392, 515);
            this.GbVentas.TabIndex = 67;
            this.GbVentas.TabStop = false;
            this.GbVentas.Text = "Historial de ventas";
            // 
            // BtnMostrarTodo
            // 
            this.BtnMostrarTodo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarTodo.Location = new System.Drawing.Point(113, 127);
            this.BtnMostrarTodo.Name = "BtnMostrarTodo";
            this.BtnMostrarTodo.Size = new System.Drawing.Size(192, 32);
            this.BtnMostrarTodo.TabIndex = 78;
            this.BtnMostrarTodo.Text = "Mostrar todas las ventas";
            this.BtnMostrarTodo.UseVisualStyleBackColor = true;
            // 
            // CbBuscar
            // 
            this.CbBuscar.FormattingEnabled = true;
            this.CbBuscar.Items.AddRange(new object[] {
            "ID Venta",
            "ID Cliente",
            "Fecha"});
            this.CbBuscar.Location = new System.Drawing.Point(6, 41);
            this.CbBuscar.Name = "CbBuscar";
            this.CbBuscar.Size = new System.Drawing.Size(141, 27);
            this.CbBuscar.TabIndex = 77;
            this.CbBuscar.Text = "ID Venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 76;
            this.label9.Text = "Buscar Venta por:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 19);
            this.label8.TabIndex = 75;
            this.label8.Text = "Ingrese el valor de busqueda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "Total pagado en la venta (s/) :";
            // 
            // LblTotalPagar
            // 
            this.LblTotalPagar.AutoSize = true;
            this.LblTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotalPagar.Location = new System.Drawing.Point(207, 490);
            this.LblTotalPagar.Name = "LblTotalPagar";
            this.LblTotalPagar.Size = new System.Drawing.Size(19, 21);
            this.LblTotalPagar.TabIndex = 73;
            this.LblTotalPagar.Text = "0";
            // 
            // Lbl12
            // 
            this.Lbl12.AutoSize = true;
            this.Lbl12.Location = new System.Drawing.Point(6, 458);
            this.Lbl12.Name = "Lbl12";
            this.Lbl12.Size = new System.Drawing.Size(107, 19);
            this.Lbl12.TabIndex = 72;
            this.Lbl12.Text = "Descuento (%) :";
            // 
            // LblDescuento
            // 
            this.LblDescuento.AutoSize = true;
            this.LblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDescuento.Location = new System.Drawing.Point(207, 460);
            this.LblDescuento.Name = "LblDescuento";
            this.LblDescuento.Size = new System.Drawing.Size(19, 21);
            this.LblDescuento.TabIndex = 71;
            this.LblDescuento.Text = "0";
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSubTotal.Location = new System.Drawing.Point(207, 401);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(19, 21);
            this.LblSubTotal.TabIndex = 70;
            this.LblSubTotal.Text = "0";
            // 
            // LblImpuesto
            // 
            this.LblImpuesto.AutoSize = true;
            this.LblImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblImpuesto.Location = new System.Drawing.Point(207, 429);
            this.LblImpuesto.Name = "LblImpuesto";
            this.LblImpuesto.Size = new System.Drawing.Size(19, 21);
            this.LblImpuesto.TabIndex = 69;
            this.LblImpuesto.Text = "0";
            // 
            // Lbl8
            // 
            this.Lbl8.AutoSize = true;
            this.Lbl8.Location = new System.Drawing.Point(6, 429);
            this.Lbl8.Name = "Lbl8";
            this.Lbl8.Size = new System.Drawing.Size(99, 19);
            this.Lbl8.TabIndex = 68;
            this.Lbl8.Text = "Impuesto (%) :";
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Location = new System.Drawing.Point(6, 401);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(158, 19);
            this.Lbl5.TabIndex = 67;
            this.Lbl5.Text = "Subtotal (sin impuesto) : ";
            // 
            // DgvVentas
            // 
            this.DgvVentas.AllowUserToAddRows = false;
            this.DgvVentas.AllowUserToDeleteRows = false;
            this.DgvVentas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Location = new System.Drawing.Point(6, 165);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.RowHeadersVisible = false;
            this.DgvVentas.Size = new System.Drawing.Size(380, 226);
            this.DgvVentas.TabIndex = 22;
            this.DgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVentas_CellContentClick);
            // 
            // BtnBuscarVentas
            // 
            this.BtnBuscarVentas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarVentas.Location = new System.Drawing.Point(232, 89);
            this.BtnBuscarVentas.Name = "BtnBuscarVentas";
            this.BtnBuscarVentas.Size = new System.Drawing.Size(103, 32);
            this.BtnBuscarVentas.TabIndex = 24;
            this.BtnBuscarVentas.Text = "Buscar";
            this.BtnBuscarVentas.UseVisualStyleBackColor = true;
            this.BtnBuscarVentas.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TbBuscarVentas
            // 
            this.TbBuscarVentas.Location = new System.Drawing.Point(6, 94);
            this.TbBuscarVentas.Name = "TbBuscarVentas";
            this.TbBuscarVentas.Size = new System.Drawing.Size(170, 26);
            this.TbBuscarVentas.TabIndex = 16;
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.BtnNuevo);
            this.GbCliente.Controls.Add(this.BtnLimpiar);
            this.GbCliente.Controls.Add(this.BtnCED);
            this.GbCliente.Controls.Add(this.TbIdVenta);
            this.GbCliente.Controls.Add(this.CbNuevoDev);
            this.GbCliente.Controls.Add(this.TbRazon);
            this.GbCliente.Controls.Add(this.label4);
            this.GbCliente.Controls.Add(this.label2);
            this.GbCliente.Controls.Add(this.TbId);
            this.GbCliente.Controls.Add(this.label1);
            this.GbCliente.Controls.Add(this.BtnGuardar);
            this.GbCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCliente.Location = new System.Drawing.Point(3, 3);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(660, 215);
            this.GbCliente.TabIndex = 35;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Datos de la devolución";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(368, 73);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(92, 37);
            this.BtnNuevo.TabIndex = 75;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(479, 161);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(92, 37);
            this.BtnLimpiar.TabIndex = 67;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCED
            // 
            this.BtnCED.Location = new System.Drawing.Point(479, 18);
            this.BtnCED.Name = "BtnCED";
            this.BtnCED.Size = new System.Drawing.Size(92, 37);
            this.BtnCED.TabIndex = 65;
            this.BtnCED.Text = "CED";
            this.BtnCED.UseVisualStyleBackColor = true;
            // 
            // TbIdVenta
            // 
            this.TbIdVenta.Location = new System.Drawing.Point(9, 95);
            this.TbIdVenta.Name = "TbIdVenta";
            this.TbIdVenta.Size = new System.Drawing.Size(149, 26);
            this.TbIdVenta.TabIndex = 25;
            this.TbIdVenta.Leave += new System.EventHandler(this.TbIdVenta_Leave);
            // 
            // CbNuevoDev
            // 
            this.CbNuevoDev.AutoSize = true;
            this.CbNuevoDev.Location = new System.Drawing.Point(125, 18);
            this.CbNuevoDev.Name = "CbNuevoDev";
            this.CbNuevoDev.Size = new System.Drawing.Size(137, 23);
            this.CbNuevoDev.TabIndex = 24;
            this.CbNuevoDev.Text = "Nueva devolución";
            this.CbNuevoDev.UseVisualStyleBackColor = true;
            // 
            // TbRazon
            // 
            this.TbRazon.Location = new System.Drawing.Point(10, 146);
            this.TbRazon.Multiline = true;
            this.TbRazon.Name = "TbRazon";
            this.TbRazon.Size = new System.Drawing.Size(364, 63);
            this.TbRazon.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Razón de la devolución";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id venta";
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
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id devolución";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(479, 84);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 37);
            this.BtnGuardar.TabIndex = 54;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CbProveedores
            // 
            this.CbProveedores.Controls.Add(this.button2);
            this.CbProveedores.Controls.Add(this.DgvDevolucionDetalle);
            this.CbProveedores.Controls.Add(this.LTotal);
            this.CbProveedores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProveedores.Location = new System.Drawing.Point(3, 218);
            this.CbProveedores.Name = "CbProveedores";
            this.CbProveedores.Size = new System.Drawing.Size(660, 303);
            this.CbProveedores.TabIndex = 36;
            this.CbProveedores.TabStop = false;
            this.CbProveedores.Text = "Selecciones los articulos a devolver";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(510, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 32);
            this.button2.TabIndex = 57;
            this.button2.Text = "Imprimir documento";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DgvDevolucionDetalle
            // 
            this.DgvDevolucionDetalle.AllowUserToAddRows = false;
            this.DgvDevolucionDetalle.AllowUserToDeleteRows = false;
            this.DgvDevolucionDetalle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvDevolucionDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDevolucionDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDevolucionDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBorrar,
            this.ColId,
            this.ColNombre,
            this.ColEstado,
            this.ColPrecio,
            this.ColCantidad,
            this.ColSubTotal,
            this.ColCantidadDev});
            this.DgvDevolucionDetalle.Location = new System.Drawing.Point(6, 22);
            this.DgvDevolucionDetalle.Name = "DgvDevolucionDetalle";
            this.DgvDevolucionDetalle.RowHeadersVisible = false;
            this.DgvDevolucionDetalle.Size = new System.Drawing.Size(648, 221);
            this.DgvDevolucionDetalle.TabIndex = 21;
            this.DgvDevolucionDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDevolucionDetalle_CellContentClick);
            this.DgvDevolucionDetalle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDevolucionDetalle_CellValueChanged);
            // 
            // ColBorrar
            // 
            this.ColBorrar.HeaderText = "";
            this.ColBorrar.Name = "ColBorrar";
            this.ColBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColBorrar.Width = 30;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id producto";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 108;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 160;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Items.AddRange(new object[] {
            "Nuevo",
            "Defectuoso",
            "Roto"});
            this.ColEstado.Name = "ColEstado";
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio ";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 90;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 90;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.HeaderText = "Total";
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            this.ColSubTotal.Width = 68;
            // 
            // ColCantidadDev
            // 
            this.ColCantidadDev.HeaderText = "CantidadDev";
            this.ColCantidadDev.Name = "ColCantidadDev";
            this.ColCantidadDev.Visible = false;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.Location = new System.Drawing.Point(413, 246);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(187, 19);
            this.LTotal.TabIndex = 55;
            this.LTotal.Text = "Importe total a devolver: s/ 0 ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.DtpFechaDevo);
            this.tabPage2.Controls.Add(this.GbHistorialDevo);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1064, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial de devoluciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(640, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Fecha de la devolución";
            // 
            // DtpFechaDevo
            // 
            this.DtpFechaDevo.Enabled = false;
            this.DtpFechaDevo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaDevo.Location = new System.Drawing.Point(644, 206);
            this.DtpFechaDevo.Name = "DtpFechaDevo";
            this.DtpFechaDevo.Size = new System.Drawing.Size(110, 26);
            this.DtpFechaDevo.TabIndex = 40;
            this.DtpFechaDevo.Value = new System.DateTime(2000, 1, 1, 19, 27, 0, 0);
            // 
            // GbHistorialDevo
            // 
            this.GbHistorialDevo.Controls.Add(this.DgvDevoluciones);
            this.GbHistorialDevo.Controls.Add(this.TbBuscarDevol);
            this.GbHistorialDevo.Controls.Add(this.BtnBuscarDevoluciones);
            this.GbHistorialDevo.Controls.Add(this.label7);
            this.GbHistorialDevo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbHistorialDevo.Location = new System.Drawing.Point(191, 109);
            this.GbHistorialDevo.Name = "GbHistorialDevo";
            this.GbHistorialDevo.Size = new System.Drawing.Size(380, 302);
            this.GbHistorialDevo.TabIndex = 39;
            this.GbHistorialDevo.TabStop = false;
            this.GbHistorialDevo.Text = "Historial de devoluciones";
            this.GbHistorialDevo.Visible = false;
            // 
            // DgvDevoluciones
            // 
            this.DgvDevoluciones.AllowUserToAddRows = false;
            this.DgvDevoluciones.AllowUserToDeleteRows = false;
            this.DgvDevoluciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvDevoluciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDevoluciones.Location = new System.Drawing.Point(6, 18);
            this.DgvDevoluciones.Name = "DgvDevoluciones";
            this.DgvDevoluciones.RowHeadersVisible = false;
            this.DgvDevoluciones.Size = new System.Drawing.Size(368, 226);
            this.DgvDevoluciones.TabIndex = 22;
            this.DgvDevoluciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDevoluciones_CellContentClick);
            // 
            // TbBuscarDevol
            // 
            this.TbBuscarDevol.Location = new System.Drawing.Point(10, 267);
            this.TbBuscarDevol.Name = "TbBuscarDevol";
            this.TbBuscarDevol.Size = new System.Drawing.Size(148, 26);
            this.TbBuscarDevol.TabIndex = 16;
            // 
            // BtnBuscarDevoluciones
            // 
            this.BtnBuscarDevoluciones.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarDevoluciones.Location = new System.Drawing.Point(175, 263);
            this.BtnBuscarDevoluciones.Name = "BtnBuscarDevoluciones";
            this.BtnBuscarDevoluciones.Size = new System.Drawing.Size(92, 32);
            this.BtnBuscarDevoluciones.TabIndex = 15;
            this.BtnBuscarDevoluciones.Text = "Buscar";
            this.BtnBuscarDevoluciones.UseVisualStyleBackColor = true;
            this.BtnBuscarDevoluciones.Click += new System.EventHandler(this.BtnBuscarDevoluciones_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Buscar fecha de la devolucion: ";
            // 
            // FormDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 555);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PbCerrar);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDevoluciones";
            this.Text = "FormDevoluciones";
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.GbVentas.ResumeLayout(false);
            this.GbVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.CbProveedores.ResumeLayout(false);
            this.CbProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDevolucionDetalle)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GbHistorialDevo.ResumeLayout(false);
            this.GbHistorialDevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDevoluciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PbCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCED;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.TextBox TbIdVenta;
        private System.Windows.Forms.CheckBox CbNuevoDev;
        private System.Windows.Forms.TextBox TbRazon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CbProveedores;
        private System.Windows.Forms.DataGridView DgvDevolucionDetalle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidadDev;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpFechaDevo;
        private System.Windows.Forms.GroupBox GbHistorialDevo;
        private System.Windows.Forms.DataGridView DgvDevoluciones;
        private System.Windows.Forms.TextBox TbBuscarDevol;
        private System.Windows.Forms.Button BtnBuscarDevoluciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GbVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTotalPagar;
        private System.Windows.Forms.Label Lbl12;
        private System.Windows.Forms.Label LblDescuento;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label LblImpuesto;
        private System.Windows.Forms.Label Lbl8;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.Button BtnBuscarVentas;
        private System.Windows.Forms.TextBox TbBuscarVentas;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.ComboBox CbBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnMostrarTodo;
        private System.Windows.Forms.Button button2;
    }
}