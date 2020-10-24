namespace SIVEALLI
{
    partial class FormSupervisor
    {

        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ScVertical = new System.Windows.Forms.SplitContainer();
            this.BtnNotificaciones = new System.Windows.Forms.Button();
            this.btnNegocio = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.BtnDevoluciones = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnPedidos = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnEntrada = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ScHorizontal = new System.Windows.Forms.SplitContainer();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.timerNotificaciones = new System.Windows.Forms.Timer(this.components);
            this.TimHora = new System.Windows.Forms.Timer(this.components);
            this.PctBLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).BeginInit();
            this.ScVertical.Panel1.SuspendLayout();
            this.ScVertical.Panel2.SuspendLayout();
            this.ScVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScHorizontal)).BeginInit();
            this.ScHorizontal.Panel1.SuspendLayout();
            this.ScHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ScVertical
            // 
            this.ScVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScVertical.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScVertical.Location = new System.Drawing.Point(0, 0);
            this.ScVertical.Name = "ScVertical";
            // 
            // ScVertical.Panel1
            // 
            this.ScVertical.Panel1.BackColor = System.Drawing.Color.White;
            this.ScVertical.Panel1.Controls.Add(this.BtnNotificaciones);
            this.ScVertical.Panel1.Controls.Add(this.btnNegocio);
            this.ScVertical.Panel1.Controls.Add(this.BtnVentas);
            this.ScVertical.Panel1.Controls.Add(this.BtnDevoluciones);
            this.ScVertical.Panel1.Controls.Add(this.BtnReportes);
            this.ScVertical.Panel1.Controls.Add(this.BtnPedidos);
            this.ScVertical.Panel1.Controls.Add(this.BtnClientes);
            this.ScVertical.Panel1.Controls.Add(this.BtnUsuarios);
            this.ScVertical.Panel1.Controls.Add(this.BtnProductos);
            this.ScVertical.Panel1.Controls.Add(this.BtnEntrada);
            this.ScVertical.Panel1.Controls.Add(this.button2);
            // 
            // ScVertical.Panel2
            // 
            this.ScVertical.Panel2.Controls.Add(this.ScHorizontal);
            this.ScVertical.Size = new System.Drawing.Size(1264, 681);
            this.ScVertical.SplitterDistance = 174;
            this.ScVertical.TabIndex = 0;
            // 
            // BtnNotificaciones
            // 
            this.BtnNotificaciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotificaciones.Location = new System.Drawing.Point(12, 469);
            this.BtnNotificaciones.Name = "BtnNotificaciones";
            this.BtnNotificaciones.Size = new System.Drawing.Size(148, 34);
            this.BtnNotificaciones.TabIndex = 10;
            this.BtnNotificaciones.Text = "Notificaciones";
            this.BtnNotificaciones.UseVisualStyleBackColor = true;
            // 
            // btnNegocio
            // 
            this.btnNegocio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegocio.Location = new System.Drawing.Point(12, 429);
            this.btnNegocio.Name = "btnNegocio";
            this.btnNegocio.Size = new System.Drawing.Size(148, 34);
            this.btnNegocio.TabIndex = 9;
            this.btnNegocio.Text = "Datos negocio";
            this.btnNegocio.UseVisualStyleBackColor = true;
            this.btnNegocio.Click += new System.EventHandler(this.btnNegocio_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.Location = new System.Drawing.Point(12, 269);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(148, 34);
            this.BtnVentas.TabIndex = 5;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // BtnDevoluciones
            // 
            this.BtnDevoluciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDevoluciones.Location = new System.Drawing.Point(12, 349);
            this.BtnDevoluciones.Name = "BtnDevoluciones";
            this.BtnDevoluciones.Size = new System.Drawing.Size(148, 34);
            this.BtnDevoluciones.TabIndex = 7;
            this.BtnDevoluciones.Text = "Devoluciones";
            this.BtnDevoluciones.UseVisualStyleBackColor = true;
            this.BtnDevoluciones.Click += new System.EventHandler(this.BtnDevoluciones_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Location = new System.Drawing.Point(12, 509);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(148, 38);
            this.BtnReportes.TabIndex = 11;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidos.Location = new System.Drawing.Point(12, 309);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Size = new System.Drawing.Size(148, 34);
            this.BtnPedidos.TabIndex = 6;
            this.BtnPedidos.Text = "Pedidos";
            this.BtnPedidos.UseVisualStyleBackColor = true;
            this.BtnPedidos.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.Location = new System.Drawing.Point(12, 110);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(148, 34);
            this.BtnClientes.TabIndex = 1;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.Location = new System.Drawing.Point(12, 150);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(148, 34);
            this.BtnUsuarios.TabIndex = 2;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.Location = new System.Drawing.Point(12, 190);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(148, 34);
            this.BtnProductos.TabIndex = 3;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnEntrada
            // 
            this.BtnEntrada.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrada.Location = new System.Drawing.Point(12, 389);
            this.BtnEntrada.Name = "BtnEntrada";
            this.BtnEntrada.Size = new System.Drawing.Size(148, 34);
            this.BtnEntrada.TabIndex = 8;
            this.BtnEntrada.Text = "Entrada";
            this.BtnEntrada.UseVisualStyleBackColor = true;
            this.BtnEntrada.Click += new System.EventHandler(this.buttonEntrada_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Proveedores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ScHorizontal
            // 
            this.ScHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScHorizontal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScHorizontal.Location = new System.Drawing.Point(0, 0);
            this.ScHorizontal.Name = "ScHorizontal";
            this.ScHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScHorizontal.Panel1
            // 
            this.ScHorizontal.Panel1.BackColor = System.Drawing.Color.White;
            this.ScHorizontal.Panel1.Controls.Add(this.PctBLogo);
            this.ScHorizontal.Panel1.Controls.Add(this.LblTitulo);
            this.ScHorizontal.Panel1.Controls.Add(this.LblHora);
            this.ScHorizontal.Panel1.Controls.Add(this.BtnCerrarSesion);
            this.ScHorizontal.Panel1.Controls.Add(this.dtpFecha);
            this.ScHorizontal.Panel1.Controls.Add(this.labelUsuario);
            // 
            // ScHorizontal.Panel2
            // 
            this.ScHorizontal.Panel2.BackColor = System.Drawing.Color.White;
            this.ScHorizontal.Panel2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScHorizontal.Size = new System.Drawing.Size(1086, 681);
            this.ScHorizontal.SplitterDistance = 119;
            this.ScHorizontal.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(52, 24);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(232, 68);
            this.LblTitulo.TabIndex = 12;
            this.LblTitulo.Text = "SISTEMA DE VENTAS Y ALMACEN PARA LIBRERIAS (SIVEALLI)";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(720, 58);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(96, 27);
            this.LblHora.TabIndex = 11;
            this.LblHora.Text = "00:00:00";
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.Location = new System.Drawing.Point(933, 58);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(110, 26);
            this.BtnCerrarSesion.TabIndex = 10;
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(642, 18);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(263, 26);
            this.dtpFecha.TabIndex = 1;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(948, 24);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(78, 19);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "USUARIO";
            // 
            // timerNotificaciones
            // 
            this.timerNotificaciones.Enabled = true;
            this.timerNotificaciones.Interval = 4000;
            // 
            // TimHora
            // 
            this.TimHora.Enabled = true;
            this.TimHora.Tick += new System.EventHandler(this.TimHora_Tick);
            // 
            // PctBLogo
            // 
            this.PctBLogo.Location = new System.Drawing.Point(378, 5);
            this.PctBLogo.Name = "PctBLogo";
            this.PctBLogo.Size = new System.Drawing.Size(150, 110);
            this.PctBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBLogo.TabIndex = 13;
            this.PctBLogo.TabStop = false;
            // 
            // FormSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ScVertical);
            this.Name = "FormSupervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervisor";
            this.ScVertical.Panel1.ResumeLayout(false);
            this.ScVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).EndInit();
            this.ScVertical.ResumeLayout(false);
            this.ScHorizontal.Panel1.ResumeLayout(false);
            this.ScHorizontal.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScHorizontal)).EndInit();
            this.ScHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer ScVertical;
        protected System.Windows.Forms.SplitContainer ScHorizontal;
        protected System.Windows.Forms.Button BtnReportes;
        protected System.Windows.Forms.DateTimePicker dtpFecha;
        protected System.Windows.Forms.Label labelUsuario;
        protected System.Windows.Forms.Button BtnUsuarios;
        protected System.Windows.Forms.Button BtnProductos;
        protected System.Windows.Forms.Button BtnEntrada;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button BtnClientes;
        protected System.Windows.Forms.Button BtnPedidos;
        protected System.Windows.Forms.Button BtnDevoluciones;
        protected System.Windows.Forms.Button BtnVentas;
        protected System.Windows.Forms.Button btnNegocio;
        protected System.Windows.Forms.Button BtnCerrarSesion;
        protected System.Windows.Forms.Button BtnNotificaciones;
        private System.Windows.Forms.Timer timerNotificaciones;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer TimHora;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PctBLogo;
    }
}

