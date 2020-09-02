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
            this.ScVertical = new System.Windows.Forms.SplitContainer();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnPedidos = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.buttonEntrada = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ScHorizontal = new System.Windows.Forms.SplitContainer();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.BtnVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).BeginInit();
            this.ScVertical.Panel1.SuspendLayout();
            this.ScVertical.Panel2.SuspendLayout();
            this.ScVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScHorizontal)).BeginInit();
            this.ScHorizontal.Panel1.SuspendLayout();
            this.ScHorizontal.SuspendLayout();
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
            this.ScVertical.Panel1.Controls.Add(this.BtnVentas);
            this.ScVertical.Panel1.Controls.Add(this.BtnReportes);
            this.ScVertical.Panel1.Controls.Add(this.BtnPedidos);
            this.ScVertical.Panel1.Controls.Add(this.BtnClientes);
            this.ScVertical.Panel1.Controls.Add(this.buttonUsuarios);
            this.ScVertical.Panel1.Controls.Add(this.BtnProductos);
            this.ScVertical.Panel1.Controls.Add(this.buttonEntrada);
            this.ScVertical.Panel1.Controls.Add(this.button2);
            // 
            // ScVertical.Panel2
            // 
            this.ScVertical.Panel2.Controls.Add(this.ScHorizontal);
            this.ScVertical.Size = new System.Drawing.Size(1264, 681);
            this.ScVertical.SplitterDistance = 174;
            this.ScVertical.TabIndex = 0;
            // 
            // BtnReportes
            // 
            this.BtnReportes.Location = new System.Drawing.Point(12, 631);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(148, 38);
            this.BtnReportes.TabIndex = 0;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidos.Location = new System.Drawing.Point(12, 190);
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
            this.BtnClientes.Location = new System.Drawing.Point(12, 30);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(148, 34);
            this.BtnClientes.TabIndex = 5;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.Location = new System.Drawing.Point(12, 70);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(148, 34);
            this.buttonUsuarios.TabIndex = 4;
            this.buttonUsuarios.Text = "Usuarios";
            this.buttonUsuarios.UseVisualStyleBackColor = true;
            this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.Location = new System.Drawing.Point(12, 110);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(148, 34);
            this.BtnProductos.TabIndex = 3;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // buttonEntrada
            // 
            this.buttonEntrada.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrada.Location = new System.Drawing.Point(12, 448);
            this.buttonEntrada.Name = "buttonEntrada";
            this.buttonEntrada.Size = new System.Drawing.Size(148, 34);
            this.buttonEntrada.TabIndex = 2;
            this.buttonEntrada.Text = "Entrada";
            this.buttonEntrada.UseVisualStyleBackColor = true;
            this.buttonEntrada.Click += new System.EventHandler(this.buttonEntrada_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 34);
            this.button2.TabIndex = 1;
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
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(462, 35);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(263, 26);
            this.dtpFecha.TabIndex = 1;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(158, 30);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(0, 19);
            this.labelUsuario.TabIndex = 0;
            // 
            // BtnVentas
            // 
            this.BtnVentas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.Location = new System.Drawing.Point(12, 230);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(148, 34);
            this.BtnVentas.TabIndex = 7;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ScVertical;
        private System.Windows.Forms.Button buttonUsuarios;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button buttonEntrada;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer ScHorizontal;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnPedidos;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button BtnVentas;
    }
}

