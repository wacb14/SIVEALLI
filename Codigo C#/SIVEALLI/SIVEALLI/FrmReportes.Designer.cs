namespace SIVEALLI
{
    partial class FrmReportes
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
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReporteVentas = new System.Windows.Forms.Button();
            this.DtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.GbReportes = new System.Windows.Forms.GroupBox();
            this.BtnReportePedidos = new System.Windows.Forms.Button();
            this.BtnReporteEntradas = new System.Windows.Forms.Button();
            this.BtnReporteDevoluciones = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GbReportes2 = new System.Windows.Forms.GroupBox();
            this.BtnReporteProductos = new System.Windows.Forms.Button();
            this.BtnReporteProveedores = new System.Windows.Forms.Button();
            this.BtnReporteUsuarios = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnReporteClientes = new System.Windows.Forms.Button();
            this.GbReportes.SuspendLayout();
            this.GbReportes2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(13, 106);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(152, 26);
            this.DtpFecha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese rango de fechas:";
            // 
            // BtnReporteVentas
            // 
            this.BtnReporteVentas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporteVentas.Location = new System.Drawing.Point(143, 227);
            this.BtnReporteVentas.Name = "BtnReporteVentas";
            this.BtnReporteVentas.Size = new System.Drawing.Size(149, 35);
            this.BtnReporteVentas.TabIndex = 2;
            this.BtnReporteVentas.Text = "Ventas";
            this.BtnReporteVentas.UseVisualStyleBackColor = true;
            this.BtnReporteVentas.Click += new System.EventHandler(this.BtnReporteVentas_Click);
            // 
            // DtpFecha2
            // 
            this.DtpFecha2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha2.Location = new System.Drawing.Point(252, 106);
            this.DtpFecha2.Name = "DtpFecha2";
            this.DtpFecha2.Size = new System.Drawing.Size(157, 26);
            this.DtpFecha2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // GbReportes
            // 
            this.GbReportes.Controls.Add(this.BtnReportePedidos);
            this.GbReportes.Controls.Add(this.BtnReporteEntradas);
            this.GbReportes.Controls.Add(this.BtnReporteDevoluciones);
            this.GbReportes.Controls.Add(this.label4);
            this.GbReportes.Controls.Add(this.label1);
            this.GbReportes.Controls.Add(this.label2);
            this.GbReportes.Controls.Add(this.DtpFecha);
            this.GbReportes.Controls.Add(this.DtpFecha2);
            this.GbReportes.Controls.Add(this.BtnReporteVentas);
            this.GbReportes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbReportes.Location = new System.Drawing.Point(72, 32);
            this.GbReportes.Name = "GbReportes";
            this.GbReportes.Size = new System.Drawing.Size(432, 465);
            this.GbReportes.TabIndex = 5;
            this.GbReportes.TabStop = false;
            this.GbReportes.Text = "Con rango de Fechas";
            // 
            // BtnReportePedidos
            // 
            this.BtnReportePedidos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportePedidos.Location = new System.Drawing.Point(143, 335);
            this.BtnReportePedidos.Name = "BtnReportePedidos";
            this.BtnReportePedidos.Size = new System.Drawing.Size(149, 35);
            this.BtnReportePedidos.TabIndex = 9;
            this.BtnReportePedidos.Text = "Pedidos";
            this.BtnReportePedidos.UseVisualStyleBackColor = true;
            this.BtnReportePedidos.Click += new System.EventHandler(this.BtnReportePedidos_Click);
            // 
            // BtnReporteEntradas
            // 
            this.BtnReporteEntradas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporteEntradas.Location = new System.Drawing.Point(143, 281);
            this.BtnReporteEntradas.Name = "BtnReporteEntradas";
            this.BtnReporteEntradas.Size = new System.Drawing.Size(149, 35);
            this.BtnReporteEntradas.TabIndex = 8;
            this.BtnReporteEntradas.Text = "Entradas";
            this.BtnReporteEntradas.UseVisualStyleBackColor = true;
            this.BtnReporteEntradas.Click += new System.EventHandler(this.BtnReporteEntradas_Click);
            // 
            // BtnReporteDevoluciones
            // 
            this.BtnReporteDevoluciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporteDevoluciones.Location = new System.Drawing.Point(143, 391);
            this.BtnReporteDevoluciones.Name = "BtnReporteDevoluciones";
            this.BtnReporteDevoluciones.Size = new System.Drawing.Size(149, 35);
            this.BtnReporteDevoluciones.TabIndex = 7;
            this.BtnReporteDevoluciones.Text = "Devoluciones";
            this.BtnReporteDevoluciones.UseVisualStyleBackColor = true;
            this.BtnReporteDevoluciones.Click += new System.EventHandler(this.BtnReporteDevoluciones_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccione Opcion de reporte:";
            // 
            // GbReportes2
            // 
            this.GbReportes2.Controls.Add(this.BtnReporteProductos);
            this.GbReportes2.Controls.Add(this.BtnReporteProveedores);
            this.GbReportes2.Controls.Add(this.BtnReporteUsuarios);
            this.GbReportes2.Controls.Add(this.label3);
            this.GbReportes2.Controls.Add(this.BtnReporteClientes);
            this.GbReportes2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbReportes2.Location = new System.Drawing.Point(543, 32);
            this.GbReportes2.Name = "GbReportes2";
            this.GbReportes2.Size = new System.Drawing.Size(458, 465);
            this.GbReportes2.TabIndex = 6;
            this.GbReportes2.TabStop = false;
            this.GbReportes2.Text = "Sin Rango de Fechas";
            // 
            // BtnReporteProductos
            // 
            this.BtnReporteProductos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporteProductos.Location = new System.Drawing.Point(178, 345);
            this.BtnReporteProductos.Name = "BtnReporteProductos";
            this.BtnReporteProductos.Size = new System.Drawing.Size(149, 35);
            this.BtnReporteProductos.TabIndex = 14;
            this.BtnReporteProductos.Text = "Productos";
            this.BtnReporteProductos.UseVisualStyleBackColor = true;
            this.BtnReporteProductos.Click += new System.EventHandler(this.BtnReporteProductos_Click);
            // 
            // BtnReporteProveedores
            // 
            this.BtnReporteProveedores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporteProveedores.Location = new System.Drawing.Point(178, 273);
            this.BtnReporteProveedores.Name = "BtnReporteProveedores";
            this.BtnReporteProveedores.Size = new System.Drawing.Size(149, 35);
            this.BtnReporteProveedores.TabIndex = 13;
            this.BtnReporteProveedores.Text = "Proveedores";
            this.BtnReporteProveedores.UseVisualStyleBackColor = true;
            this.BtnReporteProveedores.Click += new System.EventHandler(this.BtnReporteProveedores_Click);
            // 
            // BtnReporteUsuarios
            // 
            this.BtnReporteUsuarios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporteUsuarios.Location = new System.Drawing.Point(178, 204);
            this.BtnReporteUsuarios.Name = "BtnReporteUsuarios";
            this.BtnReporteUsuarios.Size = new System.Drawing.Size(149, 35);
            this.BtnReporteUsuarios.TabIndex = 12;
            this.BtnReporteUsuarios.Text = "Usuarios";
            this.BtnReporteUsuarios.UseVisualStyleBackColor = true;
            this.BtnReporteUsuarios.Click += new System.EventHandler(this.BtnReporteUsuarios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccione Opcion de reporte:";
            // 
            // BtnReporteClientes
            // 
            this.BtnReporteClientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporteClientes.Location = new System.Drawing.Point(178, 136);
            this.BtnReporteClientes.Name = "BtnReporteClientes";
            this.BtnReporteClientes.Size = new System.Drawing.Size(149, 35);
            this.BtnReporteClientes.TabIndex = 10;
            this.BtnReporteClientes.Text = "Clientes";
            this.BtnReporteClientes.UseVisualStyleBackColor = true;
            this.BtnReporteClientes.Click += new System.EventHandler(this.BtnReporteClientes_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.GbReportes2);
            this.Controls.Add(this.GbReportes);
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            this.GbReportes.ResumeLayout(false);
            this.GbReportes.PerformLayout();
            this.GbReportes2.ResumeLayout(false);
            this.GbReportes2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReporteVentas;
        private System.Windows.Forms.DateTimePicker DtpFecha2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbReportes;
        private System.Windows.Forms.Button BtnReportePedidos;
        private System.Windows.Forms.Button BtnReporteEntradas;
        private System.Windows.Forms.Button BtnReporteDevoluciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GbReportes2;
        private System.Windows.Forms.Button BtnReporteProductos;
        private System.Windows.Forms.Button BtnReporteProveedores;
        private System.Windows.Forms.Button BtnReporteUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnReporteClientes;
    }
}