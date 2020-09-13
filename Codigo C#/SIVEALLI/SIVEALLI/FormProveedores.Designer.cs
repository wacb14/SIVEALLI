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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbMostrar = new System.Windows.Forms.GroupBox();
            this.BtnCargarTabla = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblNumeroProveedores = new System.Windows.Forms.Label();
            this.DgvProveedores = new System.Windows.Forms.DataGridView();
            this.TxtValorBusqueda = new System.Windows.Forms.TextBox();
            this.Lbl10 = new System.Windows.Forms.Label();
            this.Lbl9 = new System.Windows.Forms.Label();
            this.CboBuscarPor = new System.Windows.Forms.ComboBox();
            this.GbProveedores = new System.Windows.Forms.GroupBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.BtnCambiarEstado = new System.Windows.Forms.Button();
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.GbBusqueda = new System.Windows.Forms.GroupBox();
            this.GbMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).BeginInit();
            this.GbProveedores.SuspendLayout();
            this.GbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbMostrar
            // 
            this.GbMostrar.Controls.Add(this.BtnCargarTabla);
            this.GbMostrar.Controls.Add(this.LblNumeroProveedores);
            this.GbMostrar.Controls.Add(this.DgvProveedores);
            this.GbMostrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbMostrar.Location = new System.Drawing.Point(363, 13);
            this.GbMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.GbMostrar.Name = "GbMostrar";
            this.GbMostrar.Padding = new System.Windows.Forms.Padding(4);
            this.GbMostrar.Size = new System.Drawing.Size(701, 405);
            this.GbMostrar.TabIndex = 62;
            this.GbMostrar.TabStop = false;
            this.GbMostrar.Text = "Lista de Proveedores";
            // 
            // BtnCargarTabla
            // 
            this.BtnCargarTabla.Location = new System.Drawing.Point(8, 359);
            this.BtnCargarTabla.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCargarTabla.Name = "BtnCargarTabla";
            this.BtnCargarTabla.Size = new System.Drawing.Size(195, 29);
            this.BtnCargarTabla.TabIndex = 67;
            this.BtnCargarTabla.Text = "Restaurar lista completa";
            this.BtnCargarTabla.UseVisualStyleBackColor = true;
            this.BtnCargarTabla.Click += new System.EventHandler(this.BtnCargarTabla_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(499, 60);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(145, 29);
            this.BtnBuscar.TabIndex = 65;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblNumeroProveedores
            // 
            this.LblNumeroProveedores.AutoSize = true;
            this.LblNumeroProveedores.Location = new System.Drawing.Point(242, 366);
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
            this.DgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvProveedores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProveedores.Location = new System.Drawing.Point(9, 27);
            this.DgvProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.DgvProveedores.Name = "DgvProveedores";
            this.DgvProveedores.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProveedores.Size = new System.Drawing.Size(684, 324);
            this.DgvProveedores.TabIndex = 37;
            this.DgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellContentClick);
            // 
            // TxtValorBusqueda
            // 
            this.TxtValorBusqueda.Location = new System.Drawing.Point(246, 63);
            this.TxtValorBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TxtValorBusqueda.Name = "TxtValorBusqueda";
            this.TxtValorBusqueda.Size = new System.Drawing.Size(187, 26);
            this.TxtValorBusqueda.TabIndex = 63;
            // 
            // Lbl10
            // 
            this.Lbl10.AutoSize = true;
            this.Lbl10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl10.Location = new System.Drawing.Point(242, 39);
            this.Lbl10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl10.Name = "Lbl10";
            this.Lbl10.Size = new System.Drawing.Size(171, 19);
            this.Lbl10.TabIndex = 62;
            this.Lbl10.Text = "Ingrese valor de búsqueda:";
            // 
            // Lbl9
            // 
            this.Lbl9.AutoSize = true;
            this.Lbl9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl9.Location = new System.Drawing.Point(8, 39);
            this.Lbl9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl9.Name = "Lbl9";
            this.Lbl9.Size = new System.Drawing.Size(160, 19);
            this.Lbl9.TabIndex = 64;
            this.Lbl9.Text = "Buscar Proveedores por:";
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
            this.CboBuscarPor.Location = new System.Drawing.Point(8, 62);
            this.CboBuscarPor.Margin = new System.Windows.Forms.Padding(4);
            this.CboBuscarPor.Name = "CboBuscarPor";
            this.CboBuscarPor.Size = new System.Drawing.Size(195, 27);
            this.CboBuscarPor.TabIndex = 66;
            // 
            // GbProveedores
            // 
            this.GbProveedores.Controls.Add(this.TxtCodigo);
            this.GbProveedores.Controls.Add(this.CboEstado);
            this.GbProveedores.Controls.Add(this.BtnCambiarEstado);
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
            this.GbProveedores.Location = new System.Drawing.Point(13, 13);
            this.GbProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.GbProveedores.Name = "GbProveedores";
            this.GbProveedores.Padding = new System.Windows.Forms.Padding(4);
            this.GbProveedores.Size = new System.Drawing.Size(342, 455);
            this.GbProveedores.TabIndex = 61;
            this.GbProveedores.TabStop = false;
            this.GbProveedores.Text = "Proveedor";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCodigo.Location = new System.Drawing.Point(13, 48);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(112, 26);
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
            this.CboEstado.Location = new System.Drawing.Point(94, 264);
            this.CboEstado.Margin = new System.Windows.Forms.Padding(4);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(195, 27);
            this.CboEstado.TabIndex = 57;
            // 
            // BtnCambiarEstado
            // 
            this.BtnCambiarEstado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarEstado.Location = new System.Drawing.Point(94, 337);
            this.BtnCambiarEstado.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCambiarEstado.Name = "BtnCambiarEstado";
            this.BtnCambiarEstado.Size = new System.Drawing.Size(195, 30);
            this.BtnCambiarEstado.TabIndex = 59;
            this.BtnCambiarEstado.Text = "Marcar como inactivo";
            this.BtnCambiarEstado.UseVisualStyleBackColor = true;
            this.BtnCambiarEstado.Click += new System.EventHandler(this.BtnCambiarEstado_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(94, 299);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(195, 30);
            this.BtnGuardar.TabIndex = 54;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Código  de Proveedor:";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(133, 47);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(153, 30);
            this.BtnNuevo.TabIndex = 56;
            this.BtnNuevo.Text = "Nuevo proveedor";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre:";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(94, 126);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(195, 26);
            this.TxtNombres.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 163);
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
            this.label8.Location = new System.Drawing.Point(16, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Estado:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(94, 160);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(195, 26);
            this.TxtDireccion.TabIndex = 43;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(94, 228);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(195, 26);
            this.TxtCorreo.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 197);
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
            this.label6.Location = new System.Drawing.Point(16, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Correo:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(94, 194);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(195, 26);
            this.TxtTelefono.TabIndex = 45;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(13, 517);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(155, 30);
            this.BtnLimpiar.TabIndex = 55;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // GbBusqueda
            // 
            this.GbBusqueda.Controls.Add(this.Lbl9);
            this.GbBusqueda.Controls.Add(this.BtnBuscar);
            this.GbBusqueda.Controls.Add(this.Lbl10);
            this.GbBusqueda.Controls.Add(this.TxtValorBusqueda);
            this.GbBusqueda.Controls.Add(this.CboBuscarPor);
            this.GbBusqueda.Location = new System.Drawing.Point(363, 426);
            this.GbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.GbBusqueda.Name = "GbBusqueda";
            this.GbBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.GbBusqueda.Size = new System.Drawing.Size(701, 116);
            this.GbBusqueda.TabIndex = 63;
            this.GbBusqueda.TabStop = false;
            this.GbBusqueda.Text = "Busqueda de proveedores";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.GbBusqueda);
            this.Controls.Add(this.GbMostrar);
            this.Controls.Add(this.GbProveedores);
            this.Controls.Add(this.BtnLimpiar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            this.GbMostrar.ResumeLayout(false);
            this.GbMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).EndInit();
            this.GbProveedores.ResumeLayout(false);
            this.GbProveedores.PerformLayout();
            this.GbBusqueda.ResumeLayout(false);
            this.GbBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbMostrar;
        private System.Windows.Forms.Button BtnCargarTabla;
        private System.Windows.Forms.TextBox TxtValorBusqueda;
        private System.Windows.Forms.Label Lbl10;
        private System.Windows.Forms.Label Lbl9;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CboBuscarPor;
        private System.Windows.Forms.Label LblNumeroProveedores;
        private System.Windows.Forms.DataGridView DgvProveedores;
        private System.Windows.Forms.GroupBox GbProveedores;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.Button BtnCambiarEstado;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.GroupBox GbBusqueda;
    }
}