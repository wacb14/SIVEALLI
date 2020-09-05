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
            this.label10 = new System.Windows.Forms.Label();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.TbfiltrarVentas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbNuevoDev = new System.Windows.Forms.CheckBox();
            this.TbRazon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PbCerrar = new System.Windows.Forms.PictureBox();
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.TbIdVenta = new System.Windows.Forms.TextBox();
            this.CbProveedores = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DgvDevolucionDetalle = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.LTotal = new System.Windows.Forms.Label();
            this.GbHistorialDevo = new System.Windows.Forms.GroupBox();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.DgvDevoluciones = new System.Windows.Forms.DataGridView();
            this.TbBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscarDevoluciones = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GbVentas = new System.Windows.Forms.GroupBox();
            this.BtnDevoluciones = new System.Windows.Forms.Button();
            this.BtnBuscarVentas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl12 = new System.Windows.Forms.Label();
            this.LblDescuento = new System.Windows.Forms.Label();
            this.LblSubtotalSinImpuesto = new System.Windows.Forms.Label();
            this.LblImpuesto = new System.Windows.Forms.Label();
            this.Lbl8 = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.ColBorrar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).BeginInit();
            this.GbCliente.SuspendLayout();
            this.CbProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDevolucionDetalle)).BeginInit();
            this.GbHistorialDevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDevoluciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GbVentas.SuspendLayout();
            this.SuspendLayout();
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
    "iento del sistema.\r\nSi desea ver todos las ventas, pulse buscar sin ningun texto" +
    ".";
            // 
            // DgvVentas
            // 
            this.DgvVentas.AllowUserToAddRows = false;
            this.DgvVentas.AllowUserToDeleteRows = false;
            this.DgvVentas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Location = new System.Drawing.Point(6, 18);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.RowHeadersVisible = false;
            this.DgvVentas.Size = new System.Drawing.Size(368, 226);
            this.DgvVentas.TabIndex = 22;
            this.DgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVentas_CellContentClick);
            // 
            // TbfiltrarVentas
            // 
            this.TbfiltrarVentas.Location = new System.Drawing.Point(10, 267);
            this.TbfiltrarVentas.Name = "TbfiltrarVentas";
            this.TbfiltrarVentas.Size = new System.Drawing.Size(148, 26);
            this.TbfiltrarVentas.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Buscar id de la venta:";
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
            this.CbNuevoDev.CheckedChanged += new System.EventHandler(this.CbNuevoDev_CheckedChanged);
            // 
            // TbRazon
            // 
            this.TbRazon.Location = new System.Drawing.Point(10, 146);
            this.TbRazon.Multiline = true;
            this.TbRazon.Name = "TbRazon";
            this.TbRazon.Size = new System.Drawing.Size(364, 84);
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
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.TbIdVenta);
            this.GbCliente.Controls.Add(this.CbNuevoDev);
            this.GbCliente.Controls.Add(this.TbRazon);
            this.GbCliente.Controls.Add(this.label4);
            this.GbCliente.Controls.Add(this.label2);
            this.GbCliente.Controls.Add(this.TbId);
            this.GbCliente.Controls.Add(this.label1);
            this.GbCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCliente.Location = new System.Drawing.Point(12, 12);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(380, 237);
            this.GbCliente.TabIndex = 27;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Datos de la devolución";
            // 
            // TbIdVenta
            // 
            this.TbIdVenta.Location = new System.Drawing.Point(9, 95);
            this.TbIdVenta.Name = "TbIdVenta";
            this.TbIdVenta.Size = new System.Drawing.Size(149, 26);
            this.TbIdVenta.TabIndex = 25;
            this.TbIdVenta.Leave += new System.EventHandler(this.TbIdVenta_Leave);
            // 
            // CbProveedores
            // 
            this.CbProveedores.Controls.Add(this.Lbl12);
            this.CbProveedores.Controls.Add(this.LblDescuento);
            this.CbProveedores.Controls.Add(this.LblSubtotalSinImpuesto);
            this.CbProveedores.Controls.Add(this.LblImpuesto);
            this.CbProveedores.Controls.Add(this.Lbl8);
            this.CbProveedores.Controls.Add(this.Lbl5);
            this.CbProveedores.Controls.Add(this.BtnGuardar);
            this.CbProveedores.Controls.Add(this.DgvDevolucionDetalle);
            this.CbProveedores.Controls.Add(this.button5);
            this.CbProveedores.Controls.Add(this.LTotal);
            this.CbProveedores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProveedores.Location = new System.Drawing.Point(398, 12);
            this.CbProveedores.Name = "CbProveedores";
            this.CbProveedores.Size = new System.Drawing.Size(660, 480);
            this.CbProveedores.TabIndex = 28;
            this.CbProveedores.TabStop = false;
            this.CbProveedores.Text = "Detalles de la venta";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(6, 436);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 37);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
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
            this.ColSubTotal});
            this.DgvDevolucionDetalle.Location = new System.Drawing.Point(6, 22);
            this.DgvDevolucionDetalle.Name = "DgvDevolucionDetalle";
            this.DgvDevolucionDetalle.RowHeadersVisible = false;
            this.DgvDevolucionDetalle.Size = new System.Drawing.Size(648, 302);
            this.DgvDevolucionDetalle.TabIndex = 21;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(562, 439);
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
            this.LTotal.Location = new System.Drawing.Point(416, 408);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(187, 19);
            this.LTotal.TabIndex = 17;
            this.LTotal.Text = "Importe total a devolver: s/ 0 ";
            // 
            // GbHistorialDevo
            // 
            this.GbHistorialDevo.Controls.Add(this.BtnVentas);
            this.GbHistorialDevo.Controls.Add(this.DgvDevoluciones);
            this.GbHistorialDevo.Controls.Add(this.TbBuscar);
            this.GbHistorialDevo.Controls.Add(this.BtnBuscarDevoluciones);
            this.GbHistorialDevo.Controls.Add(this.label7);
            this.GbHistorialDevo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbHistorialDevo.Location = new System.Drawing.Point(12, 248);
            this.GbHistorialDevo.Name = "GbHistorialDevo";
            this.GbHistorialDevo.Size = new System.Drawing.Size(380, 302);
            this.GbHistorialDevo.TabIndex = 34;
            this.GbHistorialDevo.TabStop = false;
            this.GbHistorialDevo.Text = "Historial de devoluciones";
            this.GbHistorialDevo.Visible = false;
            // 
            // BtnVentas
            // 
            this.BtnVentas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.Location = new System.Drawing.Point(282, 264);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(92, 32);
            this.BtnVentas.TabIndex = 23;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
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
            this.DgvDevoluciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDevoluciones_CellContentClick);
            // 
            // TbBuscar
            // 
            this.TbBuscar.Location = new System.Drawing.Point(10, 267);
            this.TbBuscar.Name = "TbBuscar";
            this.TbBuscar.Size = new System.Drawing.Size(148, 26);
            this.TbBuscar.TabIndex = 16;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(398, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 61);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones";
            // 
            // GbVentas
            // 
            this.GbVentas.Controls.Add(this.BtnDevoluciones);
            this.GbVentas.Controls.Add(this.DgvVentas);
            this.GbVentas.Controls.Add(this.BtnBuscarVentas);
            this.GbVentas.Controls.Add(this.TbfiltrarVentas);
            this.GbVentas.Controls.Add(this.label5);
            this.GbVentas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbVentas.Location = new System.Drawing.Point(12, 248);
            this.GbVentas.Name = "GbVentas";
            this.GbVentas.Size = new System.Drawing.Size(380, 302);
            this.GbVentas.TabIndex = 31;
            this.GbVentas.TabStop = false;
            this.GbVentas.Text = "Historial de ventas";
            // 
            // BtnDevoluciones
            // 
            this.BtnDevoluciones.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDevoluciones.Location = new System.Drawing.Point(276, 264);
            this.BtnDevoluciones.Name = "BtnDevoluciones";
            this.BtnDevoluciones.Size = new System.Drawing.Size(101, 32);
            this.BtnDevoluciones.TabIndex = 25;
            this.BtnDevoluciones.Text = "Devoluciones";
            this.BtnDevoluciones.UseVisualStyleBackColor = true;
            this.BtnDevoluciones.Click += new System.EventHandler(this.BtnDevoluciones_Click);
            // 
            // BtnBuscarVentas
            // 
            this.BtnBuscarVentas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarVentas.Location = new System.Drawing.Point(178, 263);
            this.BtnBuscarVentas.Name = "BtnBuscarVentas";
            this.BtnBuscarVentas.Size = new System.Drawing.Size(92, 32);
            this.BtnBuscarVentas.TabIndex = 24;
            this.BtnBuscarVentas.Text = "Buscar";
            this.BtnBuscarVentas.UseVisualStyleBackColor = true;
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
            // Lbl12
            // 
            this.Lbl12.AutoSize = true;
            this.Lbl12.Location = new System.Drawing.Point(6, 406);
            this.Lbl12.Name = "Lbl12";
            this.Lbl12.Size = new System.Drawing.Size(107, 19);
            this.Lbl12.TabIndex = 45;
            this.Lbl12.Text = "Descuento (%) :";
            // 
            // LblDescuento
            // 
            this.LblDescuento.AutoSize = true;
            this.LblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDescuento.Location = new System.Drawing.Point(170, 406);
            this.LblDescuento.Name = "LblDescuento";
            this.LblDescuento.Size = new System.Drawing.Size(19, 21);
            this.LblDescuento.TabIndex = 44;
            this.LblDescuento.Text = "0";
            // 
            // LblSubtotalSinImpuesto
            // 
            this.LblSubtotalSinImpuesto.AutoSize = true;
            this.LblSubtotalSinImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSubtotalSinImpuesto.Location = new System.Drawing.Point(170, 347);
            this.LblSubtotalSinImpuesto.Name = "LblSubtotalSinImpuesto";
            this.LblSubtotalSinImpuesto.Size = new System.Drawing.Size(19, 21);
            this.LblSubtotalSinImpuesto.TabIndex = 43;
            this.LblSubtotalSinImpuesto.Text = "0";
            // 
            // LblImpuesto
            // 
            this.LblImpuesto.AutoSize = true;
            this.LblImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblImpuesto.Location = new System.Drawing.Point(170, 375);
            this.LblImpuesto.Name = "LblImpuesto";
            this.LblImpuesto.Size = new System.Drawing.Size(19, 21);
            this.LblImpuesto.TabIndex = 41;
            this.LblImpuesto.Text = "0";
            // 
            // Lbl8
            // 
            this.Lbl8.AutoSize = true;
            this.Lbl8.Location = new System.Drawing.Point(6, 377);
            this.Lbl8.Name = "Lbl8";
            this.Lbl8.Size = new System.Drawing.Size(99, 19);
            this.Lbl8.TabIndex = 40;
            this.Lbl8.Text = "Impuesto (%) :";
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Location = new System.Drawing.Point(6, 349);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(158, 19);
            this.Lbl5.TabIndex = 38;
            this.Lbl5.Text = "Subtotal (sin impuesto) : ";
            // 
            // ColBorrar
            // 
            this.ColBorrar.HeaderText = "";
            this.ColBorrar.Name = "ColBorrar";
            this.ColBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColBorrar.Width = 40;
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
            this.ColNombre.Width = 150;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
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
            this.ColCantidad.Width = 90;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.HeaderText = "Total";
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            this.ColSubTotal.Width = 68;
            // 
            // FormDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.GbHistorialDevo);
            this.Controls.Add(this.PbCerrar);
            this.Controls.Add(this.GbCliente);
            this.Controls.Add(this.CbProveedores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbVentas);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDevoluciones";
            this.Text = "FormDevoluciones";
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).EndInit();
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.CbProveedores.ResumeLayout(false);
            this.CbProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDevolucionDetalle)).EndInit();
            this.GbHistorialDevo.ResumeLayout(false);
            this.GbHistorialDevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDevoluciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbVentas.ResumeLayout(false);
            this.GbVentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.TextBox TbfiltrarVentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CbNuevoDev;
        private System.Windows.Forms.TextBox TbRazon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbCerrar;
        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.GroupBox CbProveedores;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DgvDevolucionDetalle;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GbVentas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TbIdVenta;
        private System.Windows.Forms.GroupBox GbHistorialDevo;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.DataGridView DgvDevoluciones;
        private System.Windows.Forms.TextBox TbBuscar;
        private System.Windows.Forms.Button BtnBuscarDevoluciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnDevoluciones;
        private System.Windows.Forms.Button BtnBuscarVentas;
        private System.Windows.Forms.Label Lbl12;
        private System.Windows.Forms.Label LblDescuento;
        private System.Windows.Forms.Label LblSubtotalSinImpuesto;
        private System.Windows.Forms.Label LblImpuesto;
        private System.Windows.Forms.Label Lbl8;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
    }
}