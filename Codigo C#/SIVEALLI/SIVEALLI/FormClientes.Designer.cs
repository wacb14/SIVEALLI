﻿namespace SIVEALLI
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.CbBuscar = new System.Windows.Forms.ComboBox();
            this.LbNroClientes = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TbCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbTelefono = new System.Windows.Forms.TextBox();
            this.TbValorBusqueda = new System.Windows.Forms.TextBox();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TbDireccion = new System.Windows.Forms.TextBox();
            this.TbApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbNombres = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.GbClientes = new System.Windows.Forms.GroupBox();
            this.BtnMostrarTodo = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.CbNuevoPed = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PbCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.GbClientes.SuspendLayout();
            this.GbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // CbBuscar
            // 
            this.CbBuscar.FormattingEnabled = true;
            this.CbBuscar.Items.AddRange(new object[] {
            "ID Cliente",
            "Nombres",
            "Apellidos",
            "Dirección",
            "Telefono",
            "Correo"});
            this.CbBuscar.Location = new System.Drawing.Point(10, 445);
            this.CbBuscar.Name = "CbBuscar";
            this.CbBuscar.Size = new System.Drawing.Size(141, 27);
            this.CbBuscar.TabIndex = 19;
            this.CbBuscar.Text = "ID Cliente";
            // 
            // LbNroClientes
            // 
            this.LbNroClientes.AutoSize = true;
            this.LbNroClientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNroClientes.Location = new System.Drawing.Point(448, 423);
            this.LbNroClientes.Name = "LbNroClientes";
            this.LbNroClientes.Size = new System.Drawing.Size(141, 19);
            this.LbNroClientes.TabIndex = 17;
            this.LbNroClientes.Text = "Numero de clientes: 0";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(101, 433);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(153, 37);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Registrar cliente";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TbCorreo
            // 
            this.TbCorreo.Location = new System.Drawing.Point(88, 266);
            this.TbCorreo.Name = "TbCorreo";
            this.TbCorreo.Size = new System.Drawing.Size(273, 26);
            this.TbCorreo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo";
            // 
            // TbTelefono
            // 
            this.TbTelefono.Location = new System.Drawing.Point(88, 225);
            this.TbTelefono.MaxLength = 9;
            this.TbTelefono.Name = "TbTelefono";
            this.TbTelefono.Size = new System.Drawing.Size(273, 26);
            this.TbTelefono.TabIndex = 9;
            this.TbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // TbValorBusqueda
            // 
            this.TbValorBusqueda.Location = new System.Drawing.Point(10, 499);
            this.TbValorBusqueda.Name = "TbValorBusqueda";
            this.TbValorBusqueda.Size = new System.Drawing.Size(289, 26);
            this.TbValorBusqueda.TabIndex = 16;
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(10, 21);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.Size = new System.Drawing.Size(648, 399);
            this.DgvClientes.TabIndex = 0;
            this.DgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // TbDireccion
            // 
            this.TbDireccion.Location = new System.Drawing.Point(88, 184);
            this.TbDireccion.Name = "TbDireccion";
            this.TbDireccion.Size = new System.Drawing.Size(273, 26);
            this.TbDireccion.TabIndex = 7;
            // 
            // TbApellidos
            // 
            this.TbApellidos.Location = new System.Drawing.Point(88, 143);
            this.TbApellidos.Name = "TbApellidos";
            this.TbApellidos.Size = new System.Drawing.Size(273, 26);
            this.TbApellidos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Buscar clientes por:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ingrese valor de busqueda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección";
            // 
            // TbNombres
            // 
            this.TbNombres.Location = new System.Drawing.Point(88, 102);
            this.TbNombres.Name = "TbNombres";
            this.TbNombres.Size = new System.Drawing.Size(273, 26);
            this.TbNombres.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(452, 445);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 32);
            this.button5.TabIndex = 20;
            this.button5.Text = "Imprimir registros";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // GbClientes
            // 
            this.GbClientes.Controls.Add(this.BtnMostrarTodo);
            this.GbClientes.Controls.Add(this.button5);
            this.GbClientes.Controls.Add(this.BtnBuscar);
            this.GbClientes.Controls.Add(this.CbBuscar);
            this.GbClientes.Controls.Add(this.label9);
            this.GbClientes.Controls.Add(this.LbNroClientes);
            this.GbClientes.Controls.Add(this.TbValorBusqueda);
            this.GbClientes.Controls.Add(this.DgvClientes);
            this.GbClientes.Controls.Add(this.label7);
            this.GbClientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbClientes.Location = new System.Drawing.Point(398, 12);
            this.GbClientes.Name = "GbClientes";
            this.GbClientes.Size = new System.Drawing.Size(660, 537);
            this.GbClientes.TabIndex = 5;
            this.GbClientes.TabStop = false;
            this.GbClientes.Text = "Lista de clientes";
            // 
            // BtnMostrarTodo
            // 
            this.BtnMostrarTodo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarTodo.Location = new System.Drawing.Point(420, 496);
            this.BtnMostrarTodo.Name = "BtnMostrarTodo";
            this.BtnMostrarTodo.Size = new System.Drawing.Size(202, 32);
            this.BtnMostrarTodo.TabIndex = 21;
            this.BtnMostrarTodo.Text = "Mostrar todos los clientes";
            this.BtnMostrarTodo.UseVisualStyleBackColor = true;
            this.BtnMostrarTodo.Click += new System.EventHandler(this.BtnMostrarTodo_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(305, 496);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(92, 32);
            this.BtnBuscar.TabIndex = 15;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // TbId
            // 
            this.TbId.Enabled = false;
            this.TbId.Location = new System.Drawing.Point(10, 56);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(92, 26);
            this.TbId.TabIndex = 1;
            this.TbId.Leave += new System.EventHandler(this.TbId_Leave);
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.BtnLimpiar);
            this.GbCliente.Controls.Add(this.BtnNuevo);
            this.GbCliente.Controls.Add(this.CbNuevoPed);
            this.GbCliente.Controls.Add(this.BtnGuardar);
            this.GbCliente.Controls.Add(this.TbCorreo);
            this.GbCliente.Controls.Add(this.label6);
            this.GbCliente.Controls.Add(this.TbTelefono);
            this.GbCliente.Controls.Add(this.label5);
            this.GbCliente.Controls.Add(this.TbDireccion);
            this.GbCliente.Controls.Add(this.label4);
            this.GbCliente.Controls.Add(this.TbApellidos);
            this.GbCliente.Controls.Add(this.label3);
            this.GbCliente.Controls.Add(this.TbNombres);
            this.GbCliente.Controls.Add(this.label2);
            this.GbCliente.Controls.Add(this.TbId);
            this.GbCliente.Controls.Add(this.label1);
            this.GbCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCliente.Location = new System.Drawing.Point(12, 12);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(380, 537);
            this.GbCliente.TabIndex = 4;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Datos del cliente";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(206, 355);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(155, 37);
            this.BtnLimpiar.TabIndex = 29;
            this.BtnLimpiar.Text = "Limpiar datos";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(10, 355);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(155, 37);
            this.BtnNuevo.TabIndex = 28;
            this.BtnNuevo.Text = "Nuevo cliente";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // CbNuevoPed
            // 
            this.CbNuevoPed.AutoSize = true;
            this.CbNuevoPed.Location = new System.Drawing.Point(130, 30);
            this.CbNuevoPed.Name = "CbNuevoPed";
            this.CbNuevoPed.Size = new System.Drawing.Size(115, 23);
            this.CbNuevoPed.TabIndex = 25;
            this.CbNuevoPed.Text = "Cliente Nuevo";
            this.CbNuevoPed.UseVisualStyleBackColor = true;
            this.CbNuevoPed.Visible = false;
            this.CbNuevoPed.CheckedChanged += new System.EventHandler(this.CbNuevoPed_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id cliente";
            // 
            // PbCerrar
            // 
            this.PbCerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PbCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbCerrar.BackgroundImage")));
            this.PbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbCerrar.Location = new System.Drawing.Point(1060, 3);
            this.PbCerrar.Name = "PbCerrar";
            this.PbCerrar.Size = new System.Drawing.Size(25, 25);
            this.PbCerrar.TabIndex = 7;
            this.PbCerrar.TabStop = false;
            this.PbCerrar.Click += new System.EventHandler(this.PbCerrar_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.PbCerrar);
            this.Controls.Add(this.GbClientes);
            this.Controls.Add(this.GbCliente);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.GbClientes.ResumeLayout(false);
            this.GbClientes.PerformLayout();
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbBuscar;
        private System.Windows.Forms.Label LbNroClientes;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TbCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbTelefono;
        private System.Windows.Forms.TextBox TbValorBusqueda;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbDireccion;
        private System.Windows.Forms.TextBox TbApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbNombres;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox GbClientes;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CbNuevoPed;
        private System.Windows.Forms.PictureBox PbCerrar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnMostrarTodo;
    }
}