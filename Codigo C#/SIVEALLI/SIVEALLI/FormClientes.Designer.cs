namespace SIVEALLI
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
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.GbClientes = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PbCerrar = new System.Windows.Forms.PictureBox();
            this.LblCant = new System.Windows.Forms.Label();
            this.BtnMostrarTodo = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.CbNuevoPed = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbBusqueda = new System.Windows.Forms.GroupBox();
            this.PrevioImpresion = new System.Windows.Forms.PrintPreviewDialog();
            this.ImpresoraClientes = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.GbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).BeginInit();
            this.GbCliente.SuspendLayout();
            this.GbBusqueda.SuspendLayout();
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
            this.CbBuscar.Location = new System.Drawing.Point(24, 54);
            this.CbBuscar.Name = "CbBuscar";
            this.CbBuscar.Size = new System.Drawing.Size(141, 27);
            this.CbBuscar.TabIndex = 19;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(109, 435);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(153, 31);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Guardar datos";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TbCorreo
            // 
            this.TbCorreo.Location = new System.Drawing.Point(107, 283);
            this.TbCorreo.Name = "TbCorreo";
            this.TbCorreo.Size = new System.Drawing.Size(254, 26);
            this.TbCorreo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo";
            // 
            // TbTelefono
            // 
            this.TbTelefono.Location = new System.Drawing.Point(107, 242);
            this.TbTelefono.MaxLength = 9;
            this.TbTelefono.Name = "TbTelefono";
            this.TbTelefono.Size = new System.Drawing.Size(254, 26);
            this.TbTelefono.TabIndex = 9;
            this.TbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // TbValorBusqueda
            // 
            this.TbValorBusqueda.Location = new System.Drawing.Point(236, 54);
            this.TbValorBusqueda.Name = "TbValorBusqueda";
            this.TbValorBusqueda.Size = new System.Drawing.Size(227, 26);
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
            this.DgvClientes.Size = new System.Drawing.Size(648, 371);
            this.DgvClientes.TabIndex = 0;
            this.DgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // TbDireccion
            // 
            this.TbDireccion.Location = new System.Drawing.Point(107, 201);
            this.TbDireccion.Name = "TbDireccion";
            this.TbDireccion.Size = new System.Drawing.Size(254, 26);
            this.TbDireccion.TabIndex = 7;
            // 
            // TbApellidos
            // 
            this.TbApellidos.Location = new System.Drawing.Point(107, 160);
            this.TbApellidos.Name = "TbApellidos";
            this.TbApellidos.Size = new System.Drawing.Size(254, 26);
            this.TbApellidos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Buscar clientes por:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(232, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ingrese valor de busqueda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección";
            // 
            // TbNombres
            // 
            this.TbNombres.Location = new System.Drawing.Point(107, 119);
            this.TbNombres.Name = "TbNombres";
            this.TbNombres.Size = new System.Drawing.Size(254, 26);
            this.TbNombres.TabIndex = 3;
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imprimir.Location = new System.Drawing.Point(517, 400);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(137, 29);
            this.Btn_Imprimir.TabIndex = 20;
            this.Btn_Imprimir.Text = "Imprimir Lista";
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            this.Btn_Imprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // GbClientes
            // 
            this.GbClientes.Controls.Add(this.label8);
            this.GbClientes.Controls.Add(this.PbCerrar);
            this.GbClientes.Controls.Add(this.LblCant);
            this.GbClientes.Controls.Add(this.BtnMostrarTodo);
            this.GbClientes.Controls.Add(this.Btn_Imprimir);
            this.GbClientes.Controls.Add(this.DgvClientes);
            this.GbClientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbClientes.Location = new System.Drawing.Point(398, 12);
            this.GbClientes.Name = "GbClientes";
            this.GbClientes.Size = new System.Drawing.Size(660, 435);
            this.GbClientes.TabIndex = 5;
            this.GbClientes.TabStop = false;
            this.GbClientes.Text = "Lista de clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Numero de clientes: ";
            // 
            // PbCerrar
            // 
            this.PbCerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PbCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbCerrar.BackgroundImage")));
            this.PbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbCerrar.Location = new System.Drawing.Point(633, 0);
            this.PbCerrar.Name = "PbCerrar";
            this.PbCerrar.Size = new System.Drawing.Size(25, 25);
            this.PbCerrar.TabIndex = 7;
            this.PbCerrar.TabStop = false;
            this.PbCerrar.Click += new System.EventHandler(this.PbCerrar_Click);
            // 
            // LblCant
            // 
            this.LblCant.AutoSize = true;
            this.LblCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCant.Location = new System.Drawing.Point(372, 404);
            this.LblCant.Name = "LblCant";
            this.LblCant.Size = new System.Drawing.Size(19, 21);
            this.LblCant.TabIndex = 22;
            this.LblCant.Text = "0";
            // 
            // BtnMostrarTodo
            // 
            this.BtnMostrarTodo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarTodo.Location = new System.Drawing.Point(6, 400);
            this.BtnMostrarTodo.Name = "BtnMostrarTodo";
            this.BtnMostrarTodo.Size = new System.Drawing.Size(160, 29);
            this.BtnMostrarTodo.TabIndex = 21;
            this.BtnMostrarTodo.Text = "Restaurar lista completa";
            this.BtnMostrarTodo.UseVisualStyleBackColor = true;
            this.BtnMostrarTodo.Click += new System.EventHandler(this.BtnMostrarTodo_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(525, 51);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(92, 33);
            this.BtnBuscar.TabIndex = 15;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 122);
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
            this.TbId.Size = new System.Drawing.Size(105, 26);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(107, 398);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(155, 31);
            this.BtnLimpiar.TabIndex = 29;
            this.BtnLimpiar.Text = "Limpiar datos";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(227, 56);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(134, 29);
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
            // GbBusqueda
            // 
            this.GbBusqueda.Controls.Add(this.label9);
            this.GbBusqueda.Controls.Add(this.label7);
            this.GbBusqueda.Controls.Add(this.BtnBuscar);
            this.GbBusqueda.Controls.Add(this.TbValorBusqueda);
            this.GbBusqueda.Controls.Add(this.CbBuscar);
            this.GbBusqueda.Location = new System.Drawing.Point(399, 445);
            this.GbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.GbBusqueda.Name = "GbBusqueda";
            this.GbBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.GbBusqueda.Size = new System.Drawing.Size(659, 97);
            this.GbBusqueda.TabIndex = 64;
            this.GbBusqueda.TabStop = false;
            this.GbBusqueda.Text = "Busqueda de proveedores";
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
            // ImpresoraClientes
            // 
            this.ImpresoraClientes.DocumentName = "Productos";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.GbBusqueda);
            this.Controls.Add(this.GbClientes);
            this.Controls.Add(this.GbCliente);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.GbClientes.ResumeLayout(false);
            this.GbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).EndInit();
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.GbBusqueda.ResumeLayout(false);
            this.GbBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbBuscar;
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
        private System.Windows.Forms.Button Btn_Imprimir;
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
        private System.Windows.Forms.GroupBox GbBusqueda;
        private System.Windows.Forms.Label LblCant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PrintPreviewDialog PrevioImpresion;
        private System.Drawing.Printing.PrintDocument ImpresoraClientes;
    }
}