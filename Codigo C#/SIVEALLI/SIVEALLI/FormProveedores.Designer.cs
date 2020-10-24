namespace SIVEALLI
{
    partial class FormProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PbCerrar = new System.Windows.Forms.PictureBox();
            this.GbBusqueda = new System.Windows.Forms.GroupBox();
            this.Lbl9 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.Lbl10 = new System.Windows.Forms.Label();
            this.TxtValorBusqueda = new System.Windows.Forms.TextBox();
            this.CboBuscarPor = new System.Windows.Forms.ComboBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.GbProveedores = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.GbMostrar = new System.Windows.Forms.GroupBox();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnCargarTabla = new System.Windows.Forms.Button();
            this.LblNumeroProveedores = new System.Windows.Forms.Label();
            this.DgvProveedores = new System.Windows.Forms.DataGridView();
            this.PrevioImpresion = new System.Windows.Forms.PrintPreviewDialog();
            this.ImpresoraProveedores = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).BeginInit();
            this.GbBusqueda.SuspendLayout();
            this.GbProveedores.SuspendLayout();
            this.GbMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // PbCerrar
            // 
            this.PbCerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PbCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbCerrar.BackgroundImage")));
            this.PbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbCerrar.Location = new System.Drawing.Point(1038, 6);
            this.PbCerrar.Name = "PbCerrar";
            this.PbCerrar.Size = new System.Drawing.Size(25, 25);
            this.PbCerrar.TabIndex = 68;
            this.PbCerrar.TabStop = false;
            this.PbCerrar.Click += new System.EventHandler(this.PbCerrar_Click);
            // 
            // GbBusqueda
            // 
            this.GbBusqueda.Controls.Add(this.Lbl9);
            this.GbBusqueda.Controls.Add(this.BtnBuscar);
            this.GbBusqueda.Controls.Add(this.Lbl10);
            this.GbBusqueda.Controls.Add(this.TxtValorBusqueda);
            this.GbBusqueda.Controls.Add(this.CboBuscarPor);
            this.GbBusqueda.Location = new System.Drawing.Point(344, 432);
            this.GbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.GbBusqueda.Name = "GbBusqueda";
            this.GbBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.GbBusqueda.Size = new System.Drawing.Size(721, 116);
            this.GbBusqueda.TabIndex = 67;
            this.GbBusqueda.TabStop = false;
            this.GbBusqueda.Text = "Busqueda de proveedores";
            // 
            // Lbl9
            // 
            this.Lbl9.AutoSize = true;
            this.Lbl9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl9.Location = new System.Drawing.Point(37, 33);
            this.Lbl9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl9.Name = "Lbl9";
            this.Lbl9.Size = new System.Drawing.Size(160, 19);
            this.Lbl9.TabIndex = 64;
            this.Lbl9.Text = "Buscar Proveedores por:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(558, 71);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(109, 26);
            this.BtnBuscar.TabIndex = 65;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // Lbl10
            // 
            this.Lbl10.AutoSize = true;
            this.Lbl10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl10.Location = new System.Drawing.Point(292, 32);
            this.Lbl10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl10.Name = "Lbl10";
            this.Lbl10.Size = new System.Drawing.Size(171, 19);
            this.Lbl10.TabIndex = 62;
            this.Lbl10.Text = "Ingrese valor de búsqueda:";
            // 
            // TxtValorBusqueda
            // 
            this.TxtValorBusqueda.Location = new System.Drawing.Point(296, 71);
            this.TxtValorBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TxtValorBusqueda.Name = "TxtValorBusqueda";
            this.TxtValorBusqueda.Size = new System.Drawing.Size(187, 26);
            this.TxtValorBusqueda.TabIndex = 63;
            // 
            // CboBuscarPor
            // 
            this.CboBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBuscarPor.FormattingEnabled = true;
            this.CboBuscarPor.ItemHeight = 19;
            this.CboBuscarPor.Items.AddRange(new object[] {
            "ID Proveedor",
            "Nombre",
            "Direccion",
            "Telefono",
            "Correo",
            "Estado"});
            this.CboBuscarPor.Location = new System.Drawing.Point(37, 70);
            this.CboBuscarPor.Margin = new System.Windows.Forms.Padding(4);
            this.CboBuscarPor.Name = "CboBuscarPor";
            this.CboBuscarPor.Size = new System.Drawing.Size(195, 27);
            this.CboBuscarPor.TabIndex = 66;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCodigo.Location = new System.Drawing.Point(69, 43);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(141, 26);
            this.TxtCodigo.TabIndex = 36;
            // 
            // CboEstado
            // 
            this.CboEstado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "RETIRADO",
            "OTRO"});
            this.CboEstado.Location = new System.Drawing.Point(90, 286);
            this.CboEstado.Margin = new System.Windows.Forms.Padding(4);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(213, 27);
            this.CboEstado.TabIndex = 57;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(28, 350);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(129, 27);
            this.BtnLimpiar.TabIndex = 55;
            this.BtnLimpiar.Text = "Limpiar Datos";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // GbProveedores
            // 
            this.GbProveedores.Controls.Add(this.TxtCodigo);
            this.GbProveedores.Controls.Add(this.CboEstado);
            this.GbProveedores.Controls.Add(this.BtnLimpiar);
            this.GbProveedores.Controls.Add(this.BtnGuardar);
            this.GbProveedores.Controls.Add(this.label1);
            this.GbProveedores.Controls.Add(this.BtnNuevo);
            this.GbProveedores.Controls.Add(this.label2);
            this.GbProveedores.Controls.Add(this.TxtNombres);
            this.GbProveedores.Controls.Add(this.label4);
            this.GbProveedores.Controls.Add(this.label8);
            this.GbProveedores.Controls.Add(this.TxtDireccion);
            this.GbProveedores.Controls.Add(this.TxtCorreo);
            this.GbProveedores.Controls.Add(this.label5);
            this.GbProveedores.Controls.Add(this.label6);
            this.GbProveedores.Controls.Add(this.TxtTelefono);
            this.GbProveedores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbProveedores.Location = new System.Drawing.Point(6, 75);
            this.GbProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.GbProveedores.Name = "GbProveedores";
            this.GbProveedores.Padding = new System.Windows.Forms.Padding(4);
            this.GbProveedores.Size = new System.Drawing.Size(322, 422);
            this.GbProveedores.TabIndex = 65;
            this.GbProveedores.TabStop = false;
            this.GbProveedores.Text = "Datos Proveedor";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(180, 350);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(109, 27);
            this.BtnGuardar.TabIndex = 54;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Código";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(218, 43);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(95, 26);
            this.BtnNuevo.TabIndex = 56;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre:";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(90, 93);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(213, 26);
            this.TxtNombres.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Estado:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(90, 146);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(213, 26);
            this.TxtDireccion.TabIndex = 43;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(90, 239);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(213, 26);
            this.TxtCorreo.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Correo:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(90, 194);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(213, 26);
            this.TxtTelefono.TabIndex = 45;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // GbMostrar
            // 
            this.GbMostrar.Controls.Add(this.BtnImprimir);
            this.GbMostrar.Controls.Add(this.BtnCargarTabla);
            this.GbMostrar.Controls.Add(this.LblNumeroProveedores);
            this.GbMostrar.Controls.Add(this.DgvProveedores);
            this.GbMostrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbMostrar.Location = new System.Drawing.Point(344, 13);
            this.GbMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.GbMostrar.Name = "GbMostrar";
            this.GbMostrar.Padding = new System.Windows.Forms.Padding(4);
            this.GbMostrar.Size = new System.Drawing.Size(721, 420);
            this.GbMostrar.TabIndex = 66;
            this.GbMostrar.TabStop = false;
            this.GbMostrar.Text = "Lista de Proveedores";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(543, 379);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(139, 25);
            this.BtnImprimir.TabIndex = 68;
            this.BtnImprimir.Text = "Imprimir Lista";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnCargarTabla
            // 
            this.BtnCargarTabla.Location = new System.Drawing.Point(42, 378);
            this.BtnCargarTabla.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCargarTabla.Name = "BtnCargarTabla";
            this.BtnCargarTabla.Size = new System.Drawing.Size(195, 26);
            this.BtnCargarTabla.TabIndex = 67;
            this.BtnCargarTabla.Text = "Restaurar lista completa";
            this.BtnCargarTabla.UseVisualStyleBackColor = true;
            this.BtnCargarTabla.Click += new System.EventHandler(this.BtnCargarTabla_Click);
            // 
            // LblNumeroProveedores
            // 
            this.LblNumeroProveedores.AutoSize = true;
            this.LblNumeroProveedores.Location = new System.Drawing.Point(298, 383);
            this.LblNumeroProveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNumeroProveedores.Name = "LblNumeroProveedores";
            this.LblNumeroProveedores.Size = new System.Drawing.Size(174, 19);
            this.LblNumeroProveedores.TabIndex = 61;
            this.LblNumeroProveedores.Text = "Numero de Proveedores: 0";
            // 
            // DgvProveedores
            // 
            this.DgvProveedores.AllowUserToAddRows = false;
            this.DgvProveedores.AllowUserToDeleteRows = false;
            this.DgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProveedores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProveedores.Location = new System.Drawing.Point(20, 33);
            this.DgvProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.DgvProveedores.Name = "DgvProveedores";
            this.DgvProveedores.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvProveedores.Size = new System.Drawing.Size(684, 324);
            this.DgvProveedores.TabIndex = 37;
            this.DgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellContentClick);
            // 
            // PrevioImpresion
            // 
            this.PrevioImpresion.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrevioImpresion.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrevioImpresion.ClientSize = new System.Drawing.Size(400, 300);
            this.PrevioImpresion.Enabled = true;
            this.PrevioImpresion.Icon = ((System.Drawing.Icon)(resources.GetObject("PrevioImpresion.Icon")));
            this.PrevioImpresion.Name = "PrevioImpresion";
            this.PrevioImpresion.Visible = false;
            // 
            // ImpresoraProveedores
            // 
            this.ImpresoraProveedores.DocumentName = "Productos";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.PbCerrar);
            this.Controls.Add(this.GbBusqueda);
            this.Controls.Add(this.GbProveedores);
            this.Controls.Add(this.GbMostrar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).EndInit();
            this.GbBusqueda.ResumeLayout(false);
            this.GbBusqueda.PerformLayout();
            this.GbProveedores.ResumeLayout(false);
            this.GbProveedores.PerformLayout();
            this.GbMostrar.ResumeLayout(false);
            this.GbMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbCerrar;
        private System.Windows.Forms.GroupBox GbBusqueda;
        private System.Windows.Forms.Label Lbl9;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label Lbl10;
        private System.Windows.Forms.TextBox TxtValorBusqueda;
        private System.Windows.Forms.ComboBox CboBuscarPor;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.ComboBox CboEstado;
        protected System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.GroupBox GbProveedores;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.GroupBox GbMostrar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnCargarTabla;
        private System.Windows.Forms.Label LblNumeroProveedores;
        private System.Windows.Forms.DataGridView DgvProveedores;
        private System.Windows.Forms.PrintPreviewDialog PrevioImpresion;
        private System.Drawing.Printing.PrintDocument ImpresoraProveedores;
    }
}