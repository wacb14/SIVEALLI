namespace SIVEALLI
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.btnCambioContra = new System.Windows.Forms.Button();
            this.btnRestaurarContra = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.gbDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.BtnRestaurarLista = new System.Windows.Forms.Button();
            this.LblTotalUsuarios = new System.Windows.Forms.Label();
            this.BtnImprimirLista = new System.Windows.Forms.Button();
            this.Lbl11 = new System.Windows.Forms.Label();
            this.GbBusqueda = new System.Windows.Forms.GroupBox();
            this.TbValorBusqueda = new System.Windows.Forms.TextBox();
            this.Lbl10 = new System.Windows.Forms.Label();
            this.Lbl9 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CboBuscarPor = new System.Windows.Forms.ComboBox();
            this.gbListaUsuarios = new System.Windows.Forms.GroupBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbDatosUsuarios.SuspendLayout();
            this.GbBusqueda.SuspendLayout();
            this.gbListaUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Usuario";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(24, 53);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(130, 26);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(7, 27);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(675, 361);
            this.dgvUsuarios.TabIndex = 2;
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(106, 118);
            this.textBoxNombres.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(195, 26);
            this.textBoxNombres.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(106, 156);
            this.textBoxApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(195, 26);
            this.textBoxApellidos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(106, 194);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(195, 26);
            this.textBoxDireccion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(106, 232);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(195, 26);
            this.textBoxTelefono.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teléfono";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(106, 270);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(195, 26);
            this.textBoxCorreo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 344);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 306);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tipo";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "RETIRADO",
            "OTRO"});
            this.comboBoxEstado.Location = new System.Drawing.Point(107, 341);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(195, 27);
            this.comboBoxEstado.TabIndex = 8;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "SUPERVISOR",
            "EMPLEADO"});
            this.comboBoxTipo.Location = new System.Drawing.Point(107, 303);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(195, 27);
            this.comboBoxTipo.TabIndex = 7;
            // 
            // btnCambioContra
            // 
            this.btnCambioContra.Location = new System.Drawing.Point(56, 444);
            this.btnCambioContra.Name = "btnCambioContra";
            this.btnCambioContra.Size = new System.Drawing.Size(194, 29);
            this.btnCambioContra.TabIndex = 11;
            this.btnCambioContra.Text = "Cambiar mi contraseña";
            this.btnCambioContra.UseVisualStyleBackColor = true;
            // 
            // btnRestaurarContra
            // 
            this.btnRestaurarContra.Location = new System.Drawing.Point(56, 409);
            this.btnRestaurarContra.Name = "btnRestaurarContra";
            this.btnRestaurarContra.Size = new System.Drawing.Size(195, 29);
            this.btnRestaurarContra.TabIndex = 10;
            this.btnRestaurarContra.Text = "Restaurar contraseña";
            this.btnRestaurarContra.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(56, 479);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(195, 29);
            this.BtnLimpiar.TabIndex = 12;
            this.BtnLimpiar.Text = "Limpiar formulario";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(56, 374);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(195, 29);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "Guardar datos";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(172, 50);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(130, 29);
            this.btnNuevoUsuario.TabIndex = 1;
            this.btnNuevoUsuario.Text = "Nuevo usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // gbDatosUsuarios
            // 
            this.gbDatosUsuarios.Controls.Add(this.btnNuevoUsuario);
            this.gbDatosUsuarios.Controls.Add(this.label1);
            this.gbDatosUsuarios.Controls.Add(this.BtnGuardar);
            this.gbDatosUsuarios.Controls.Add(this.BtnLimpiar);
            this.gbDatosUsuarios.Controls.Add(this.textBoxCodigo);
            this.gbDatosUsuarios.Controls.Add(this.label2);
            this.gbDatosUsuarios.Controls.Add(this.btnRestaurarContra);
            this.gbDatosUsuarios.Controls.Add(this.textBoxNombres);
            this.gbDatosUsuarios.Controls.Add(this.btnCambioContra);
            this.gbDatosUsuarios.Controls.Add(this.label3);
            this.gbDatosUsuarios.Controls.Add(this.comboBoxTipo);
            this.gbDatosUsuarios.Controls.Add(this.textBoxApellidos);
            this.gbDatosUsuarios.Controls.Add(this.comboBoxEstado);
            this.gbDatosUsuarios.Controls.Add(this.label4);
            this.gbDatosUsuarios.Controls.Add(this.label8);
            this.gbDatosUsuarios.Controls.Add(this.textBoxDireccion);
            this.gbDatosUsuarios.Controls.Add(this.label9);
            this.gbDatosUsuarios.Controls.Add(this.label5);
            this.gbDatosUsuarios.Controls.Add(this.textBoxCorreo);
            this.gbDatosUsuarios.Controls.Add(this.textBoxTelefono);
            this.gbDatosUsuarios.Controls.Add(this.label6);
            this.gbDatosUsuarios.Location = new System.Drawing.Point(12, 13);
            this.gbDatosUsuarios.Name = "gbDatosUsuarios";
            this.gbDatosUsuarios.Size = new System.Drawing.Size(337, 530);
            this.gbDatosUsuarios.TabIndex = 42;
            this.gbDatosUsuarios.TabStop = false;
            this.gbDatosUsuarios.Text = "Datos usuarios";
            // 
            // BtnRestaurarLista
            // 
            this.BtnRestaurarLista.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestaurarLista.Location = new System.Drawing.Point(7, 395);
            this.BtnRestaurarLista.Name = "BtnRestaurarLista";
            this.BtnRestaurarLista.Size = new System.Drawing.Size(170, 27);
            this.BtnRestaurarLista.TabIndex = 43;
            this.BtnRestaurarLista.Text = "Restaurar Lista Completa";
            this.BtnRestaurarLista.UseVisualStyleBackColor = true;
            // 
            // LblTotalUsuarios
            // 
            this.LblTotalUsuarios.AutoSize = true;
            this.LblTotalUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotalUsuarios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalUsuarios.Location = new System.Drawing.Point(409, 398);
            this.LblTotalUsuarios.Name = "LblTotalUsuarios";
            this.LblTotalUsuarios.Size = new System.Drawing.Size(19, 21);
            this.LblTotalUsuarios.TabIndex = 46;
            this.LblTotalUsuarios.Text = "0";
            // 
            // BtnImprimirLista
            // 
            this.BtnImprimirLista.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirLista.Location = new System.Drawing.Point(556, 395);
            this.BtnImprimirLista.Name = "BtnImprimirLista";
            this.BtnImprimirLista.Size = new System.Drawing.Size(127, 27);
            this.BtnImprimirLista.TabIndex = 44;
            this.BtnImprimirLista.Text = "Imprimir Lista";
            this.BtnImprimirLista.UseVisualStyleBackColor = true;
            // 
            // Lbl11
            // 
            this.Lbl11.AutoSize = true;
            this.Lbl11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl11.Location = new System.Drawing.Point(263, 398);
            this.Lbl11.Name = "Lbl11";
            this.Lbl11.Size = new System.Drawing.Size(122, 19);
            this.Lbl11.TabIndex = 45;
            this.Lbl11.Text = "Total de Usuarios :";
            // 
            // GbBusqueda
            // 
            this.GbBusqueda.Controls.Add(this.TbValorBusqueda);
            this.GbBusqueda.Controls.Add(this.Lbl10);
            this.GbBusqueda.Controls.Add(this.Lbl9);
            this.GbBusqueda.Controls.Add(this.BtnBuscar);
            this.GbBusqueda.Controls.Add(this.CboBuscarPor);
            this.GbBusqueda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbBusqueda.Location = new System.Drawing.Point(369, 446);
            this.GbBusqueda.Name = "GbBusqueda";
            this.GbBusqueda.Size = new System.Drawing.Size(689, 97);
            this.GbBusqueda.TabIndex = 47;
            this.GbBusqueda.TabStop = false;
            this.GbBusqueda.Text = "Búsqueda de Usuarios";
            // 
            // TbValorBusqueda
            // 
            this.TbValorBusqueda.Location = new System.Drawing.Point(293, 55);
            this.TbValorBusqueda.Name = "TbValorBusqueda";
            this.TbValorBusqueda.Size = new System.Drawing.Size(219, 26);
            this.TbValorBusqueda.TabIndex = 17;
            // 
            // Lbl10
            // 
            this.Lbl10.AutoSize = true;
            this.Lbl10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl10.Location = new System.Drawing.Point(289, 30);
            this.Lbl10.Name = "Lbl10";
            this.Lbl10.Size = new System.Drawing.Size(171, 19);
            this.Lbl10.TabIndex = 15;
            this.Lbl10.Text = "Ingrese valor de búsqueda:";
            // 
            // Lbl9
            // 
            this.Lbl9.AutoSize = true;
            this.Lbl9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl9.Location = new System.Drawing.Point(14, 32);
            this.Lbl9.Name = "Lbl9";
            this.Lbl9.Size = new System.Drawing.Size(132, 19);
            this.Lbl9.TabIndex = 18;
            this.Lbl9.Text = "Buscar usuarios por:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(560, 55);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(92, 26);
            this.BtnBuscar.TabIndex = 18;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // CboBuscarPor
            // 
            this.CboBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBuscarPor.FormattingEnabled = true;
            this.CboBuscarPor.ItemHeight = 19;
            this.CboBuscarPor.Items.AddRange(new object[] {
            "ID Usuario",
            "Nombre",
            "Apellido",
            "Dirección",
            "Teléfono",
            "Correo",
            "Estado",
            "Tipo"});
            this.CboBuscarPor.Location = new System.Drawing.Point(18, 54);
            this.CboBuscarPor.Name = "CboBuscarPor";
            this.CboBuscarPor.Size = new System.Drawing.Size(219, 27);
            this.CboBuscarPor.TabIndex = 19;
            // 
            // gbListaUsuarios
            // 
            this.gbListaUsuarios.Controls.Add(this.dgvUsuarios);
            this.gbListaUsuarios.Controls.Add(this.BtnRestaurarLista);
            this.gbListaUsuarios.Controls.Add(this.BtnImprimirLista);
            this.gbListaUsuarios.Controls.Add(this.LblTotalUsuarios);
            this.gbListaUsuarios.Controls.Add(this.Lbl11);
            this.gbListaUsuarios.Location = new System.Drawing.Point(369, 45);
            this.gbListaUsuarios.Name = "gbListaUsuarios";
            this.gbListaUsuarios.Size = new System.Drawing.Size(689, 395);
            this.gbListaUsuarios.TabIndex = 48;
            this.gbListaUsuarios.TabStop = false;
            this.gbListaUsuarios.Text = "Lista de usuarios";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1028, 9);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(33, 33);
            this.BtnCerrar.TabIndex = 63;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.gbListaUsuarios);
            this.Controls.Add(this.GbBusqueda);
            this.Controls.Add(this.gbDatosUsuarios);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormUsuario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbDatosUsuarios.ResumeLayout(false);
            this.gbDatosUsuarios.PerformLayout();
            this.GbBusqueda.ResumeLayout(false);
            this.GbBusqueda.PerformLayout();
            this.gbListaUsuarios.ResumeLayout(false);
            this.gbListaUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button btnCambioContra;
        private System.Windows.Forms.Button BtnRestaurarLista;
        private System.Windows.Forms.Label LblTotalUsuarios;
        private System.Windows.Forms.Button BtnImprimirLista;
        private System.Windows.Forms.Label Lbl11;
        private System.Windows.Forms.TextBox TbValorBusqueda;
        private System.Windows.Forms.Label Lbl10;
        private System.Windows.Forms.Label Lbl9;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CboBuscarPor;
        protected System.Windows.Forms.Button BtnCerrar;
        protected System.Windows.Forms.Button btnRestaurarContra;
        protected System.Windows.Forms.Button BtnLimpiar;
        protected System.Windows.Forms.Button BtnGuardar;
        protected System.Windows.Forms.Button btnNuevoUsuario;
        protected System.Windows.Forms.GroupBox gbDatosUsuarios;
        protected System.Windows.Forms.GroupBox GbBusqueda;
        protected System.Windows.Forms.GroupBox gbListaUsuarios;
    }
}