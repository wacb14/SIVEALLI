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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
            this.GbMostrar = new System.Windows.Forms.GroupBox();
            this.BtnCargarTabla = new System.Windows.Forms.Button();
            this.TxtValorBusqueda = new System.Windows.Forms.TextBox();
            this.Lbl10 = new System.Windows.Forms.Label();
            this.Lbl9 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CboBuscarPor = new System.Windows.Forms.ComboBox();
            this.LblNumeroProveedores = new System.Windows.Forms.Label();
            this.DgvProveedores = new System.Windows.Forms.DataGridView();
            this.GbProveedores = new System.Windows.Forms.GroupBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.BtnCambiarEstado = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.GbMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).BeginInit();
            this.GbProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbMostrar
            // 
            this.GbMostrar.Controls.Add(this.BtnCargarTabla);
            this.GbMostrar.Controls.Add(this.TxtValorBusqueda);
            this.GbMostrar.Controls.Add(this.Lbl10);
            this.GbMostrar.Controls.Add(this.Lbl9);
            this.GbMostrar.Controls.Add(this.BtnBuscar);
            this.GbMostrar.Controls.Add(this.CboBuscarPor);
            this.GbMostrar.Controls.Add(this.LblNumeroProveedores);
            this.GbMostrar.Controls.Add(this.DgvProveedores);
            this.GbMostrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbMostrar.Location = new System.Drawing.Point(340, 50);
            this.GbMostrar.Name = "GbMostrar";
            this.GbMostrar.Size = new System.Drawing.Size(718, 419);
            this.GbMostrar.TabIndex = 62;
            this.GbMostrar.TabStop = false;
            this.GbMostrar.Text = "Lista de Proveedores";
            // 
            // BtnCargarTabla
            // 
            this.BtnCargarTabla.Location = new System.Drawing.Point(6, 290);
            this.BtnCargarTabla.Name = "BtnCargarTabla";
            this.BtnCargarTabla.Size = new System.Drawing.Size(158, 42);
            this.BtnCargarTabla.TabIndex = 67;
            this.BtnCargarTabla.Text = "Cargar toda la tabla";
            this.BtnCargarTabla.UseVisualStyleBackColor = true;
            this.BtnCargarTabla.Click += new System.EventHandler(this.BtnCargarTabla_Click);
            // 
            // TxtValorBusqueda
            // 
            this.TxtValorBusqueda.Location = new System.Drawing.Point(364, 363);
            this.TxtValorBusqueda.Name = "TxtValorBusqueda";
            this.TxtValorBusqueda.Size = new System.Drawing.Size(219, 26);
            this.TxtValorBusqueda.TabIndex = 63;
            // 
            // Lbl10
            // 
            this.Lbl10.AutoSize = true;
            this.Lbl10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl10.Location = new System.Drawing.Point(360, 341);
            this.Lbl10.Name = "Lbl10";
            this.Lbl10.Size = new System.Drawing.Size(171, 19);
            this.Lbl10.TabIndex = 62;
            this.Lbl10.Text = "Ingrese valor de búsqueda:";
            // 
            // Lbl9
            // 
            this.Lbl9.AutoSize = true;
            this.Lbl9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl9.Location = new System.Drawing.Point(116, 341);
            this.Lbl9.Name = "Lbl9";
            this.Lbl9.Size = new System.Drawing.Size(160, 19);
            this.Lbl9.TabIndex = 64;
            this.Lbl9.Text = "Buscar Proveedores por:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(600, 353);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(107, 45);
            this.BtnBuscar.TabIndex = 65;
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
            "ID Proveedor",
            "Nombre",
            "Direccion",
            "Telefono",
            "Correo",
            "Estado"});
            this.CboBuscarPor.Location = new System.Drawing.Point(120, 363);
            this.CboBuscarPor.Name = "CboBuscarPor";
            this.CboBuscarPor.Size = new System.Drawing.Size(219, 27);
            this.CboBuscarPor.TabIndex = 66;
            // 
            // LblNumeroProveedores
            // 
            this.LblNumeroProveedores.AutoSize = true;
            this.LblNumeroProveedores.Location = new System.Drawing.Point(544, 287);
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
            this.DgvProveedores.Location = new System.Drawing.Point(6, 39);
            this.DgvProveedores.Name = "DgvProveedores";
            this.DgvProveedores.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvProveedores.Size = new System.Drawing.Size(706, 245);
            this.DgvProveedores.TabIndex = 37;
            this.DgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellContentClick);
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
            this.GbProveedores.Controls.Add(this.BtnLimpiar);
            this.GbProveedores.Controls.Add(this.TxtNombres);
            this.GbProveedores.Controls.Add(this.label4);
            this.GbProveedores.Controls.Add(this.label8);
            this.GbProveedores.Controls.Add(this.TxtDireccion);
            this.GbProveedores.Controls.Add(this.TxtCorreo);
            this.GbProveedores.Controls.Add(this.label5);
            this.GbProveedores.Controls.Add(this.label6);
            this.GbProveedores.Controls.Add(this.TxtTelefono);
            this.GbProveedores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbProveedores.Location = new System.Drawing.Point(12, 50);
            this.GbProveedores.Name = "GbProveedores";
            this.GbProveedores.Size = new System.Drawing.Size(308, 419);
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
            this.TxtCodigo.Location = new System.Drawing.Point(190, 81);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 26);
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
            this.CboEstado.Location = new System.Drawing.Point(90, 247);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(200, 27);
            this.CboEstado.TabIndex = 57;
            // 
            // BtnCambiarEstado
            // 
            this.BtnCambiarEstado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarEstado.Location = new System.Drawing.Point(89, 328);
            this.BtnCambiarEstado.Name = "BtnCambiarEstado";
            this.BtnCambiarEstado.Size = new System.Drawing.Size(201, 45);
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
            this.BtnGuardar.Location = new System.Drawing.Point(190, 280);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 45);
            this.BtnGuardar.TabIndex = 54;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 84);
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
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.Location = new System.Drawing.Point(10, 290);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(66, 66);
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
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(90, 280);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(94, 45);
            this.BtnLimpiar.TabIndex = 55;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(90, 120);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(200, 26);
            this.TxtNombres.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Estado:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(90, 152);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(200, 26);
            this.TxtDireccion.TabIndex = 43;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(90, 215);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(200, 26);
            this.TxtCorreo.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Correo:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(90, 183);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(200, 26);
            this.TxtTelefono.TabIndex = 45;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.GbMostrar);
            this.Controls.Add(this.GbProveedores);
            this.Name = "FormProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            this.GbMostrar.ResumeLayout(false);
            this.GbMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).EndInit();
            this.GbProveedores.ResumeLayout(false);
            this.GbProveedores.PerformLayout();
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
    }
}