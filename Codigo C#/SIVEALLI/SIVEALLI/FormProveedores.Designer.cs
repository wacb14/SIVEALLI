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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.GbProveedores = new System.Windows.Forms.GroupBox();
            this.GbMostrar = new System.Windows.Forms.GroupBox();
            this.LblNumeroProveedores = new System.Windows.Forms.Label();
            this.DgvProveedores = new System.Windows.Forms.DataGridView();
            this.BtnCambiarEstado = new System.Windows.Forms.Button();
            this.GbProveedores.SuspendLayout();
            this.GbMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.Location = new System.Drawing.Point(152, 80);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(45, 45);
            this.BtnNuevo.TabIndex = 56;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.Location = new System.Drawing.Point(21, 331);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(45, 45);
            this.BtnLimpiar.TabIndex = 55;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.Location = new System.Drawing.Point(261, 331);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(45, 45);
            this.BtnGuardar.TabIndex = 54;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Estado:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(106, 266);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(200, 26);
            this.TxtCorreo.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Correo:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(106, 234);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(200, 26);
            this.TxtTelefono.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Teléfono:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(106, 203);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(200, 26);
            this.TxtDireccion.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Dirección:";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(106, 171);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(200, 26);
            this.TxtNombres.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.GrayText;
            this.TxtCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCodigo.Location = new System.Drawing.Point(206, 90);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 26);
            this.TxtCodigo.TabIndex = 36;
            this.TxtCodigo.Leave += new System.EventHandler(this.TxtCodLibro_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Código Proveedor:";
            // 
            // CboEstado
            // 
            this.CboEstado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "RETIRADO",
            "OTRO"});
            this.CboEstado.Location = new System.Drawing.Point(106, 298);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(200, 27);
            this.CboEstado.TabIndex = 57;
            // 
            // GbProveedores
            // 
            this.GbProveedores.Controls.Add(this.TxtCodigo);
            this.GbProveedores.Controls.Add(this.CboEstado);
            this.GbProveedores.Controls.Add(this.label1);
            this.GbProveedores.Controls.Add(this.BtnNuevo);
            this.GbProveedores.Controls.Add(this.label2);
            this.GbProveedores.Controls.Add(this.BtnLimpiar);
            this.GbProveedores.Controls.Add(this.TxtNombres);
            this.GbProveedores.Controls.Add(this.BtnGuardar);
            this.GbProveedores.Controls.Add(this.label4);
            this.GbProveedores.Controls.Add(this.label8);
            this.GbProveedores.Controls.Add(this.TxtDireccion);
            this.GbProveedores.Controls.Add(this.TxtCorreo);
            this.GbProveedores.Controls.Add(this.label5);
            this.GbProveedores.Controls.Add(this.label6);
            this.GbProveedores.Controls.Add(this.TxtTelefono);
            this.GbProveedores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbProveedores.Location = new System.Drawing.Point(0, 41);
            this.GbProveedores.Name = "GbProveedores";
            this.GbProveedores.Size = new System.Drawing.Size(320, 419);
            this.GbProveedores.TabIndex = 58;
            this.GbProveedores.TabStop = false;
            this.GbProveedores.Text = "Insertar o Modificar Proveedor";
            // 
            // GbMostrar
            // 
            this.GbMostrar.Controls.Add(this.LblNumeroProveedores);
            this.GbMostrar.Controls.Add(this.DgvProveedores);
            this.GbMostrar.Controls.Add(this.BtnCambiarEstado);
            this.GbMostrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbMostrar.Location = new System.Drawing.Point(340, 41);
            this.GbMostrar.Name = "GbMostrar";
            this.GbMostrar.Size = new System.Drawing.Size(718, 419);
            this.GbMostrar.TabIndex = 61;
            this.GbMostrar.TabStop = false;
            this.GbMostrar.Text = "Lista de Proveedores";
            // 
            // LblNumeroProveedores
            // 
            this.LblNumeroProveedores.AutoSize = true;
            this.LblNumeroProveedores.Location = new System.Drawing.Point(538, 17);
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
            this.DgvProveedores.Location = new System.Drawing.Point(6, 39);
            this.DgvProveedores.Name = "DgvProveedores";
            this.DgvProveedores.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProveedores.Size = new System.Drawing.Size(706, 337);
            this.DgvProveedores.TabIndex = 37;
            this.DgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellContentClick);
            // 
            // BtnCambiarEstado
            // 
            this.BtnCambiarEstado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarEstado.Location = new System.Drawing.Point(480, 382);
            this.BtnCambiarEstado.Name = "BtnCambiarEstado";
            this.BtnCambiarEstado.Size = new System.Drawing.Size(232, 36);
            this.BtnCambiarEstado.TabIndex = 59;
            this.BtnCambiarEstado.Text = "Marcar Proveedor como inactivo";
            this.BtnCambiarEstado.UseVisualStyleBackColor = true;
            this.BtnCambiarEstado.Click += new System.EventHandler(this.BtnCambiarEstado_Click);
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
            this.GbProveedores.ResumeLayout(false);
            this.GbProveedores.PerformLayout();
            this.GbMostrar.ResumeLayout(false);
            this.GbMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BtnNuevo;
        protected System.Windows.Forms.Button BtnLimpiar;
        public System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.GroupBox GbProveedores;
        private System.Windows.Forms.GroupBox GbMostrar;
        private System.Windows.Forms.Label LblNumeroProveedores;
        private System.Windows.Forms.DataGridView DgvProveedores;
        private System.Windows.Forms.Button BtnCambiarEstado;
    }
}