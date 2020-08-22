namespace SIVEALLI
{
    partial class FrmEmpleado
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
            this.tabControlEmpleado = new System.Windows.Forms.TabControl();
            this.tabPageVentas = new System.Windows.Forms.TabPage();
            this.groupBoxBoleta = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxImpTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIGV = new System.Windows.Forms.TextBox();
            this.textBoxOpGravada = new System.Windows.Forms.TextBox();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.textBoxCodigoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.ColumnCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombresCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellidosCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxVenta = new System.Windows.Forms.GroupBox();
            this.buttonNuevaVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoVenta = new System.Windows.Forms.TextBox();
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            this.ColumnCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioUnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImporteProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageProductos = new System.Windows.Forms.TabPage();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.ColumnIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombreProductoProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarcaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreUnitProductoProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCodigoProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageClientes = new System.Windows.Forms.TabPage();
            this.tabPageInformes = new System.Windows.Forms.TabPage();
            this.tabPageProveedor = new System.Windows.Forms.TabPage();
            this.pictureBoxProducto = new System.Windows.Forms.PictureBox();
            this.tabControlEmpleado.SuspendLayout();
            this.tabPageVentas.SuspendLayout();
            this.groupBoxBoleta.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.groupBoxVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            this.tabPageProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlEmpleado
            // 
            this.tabControlEmpleado.Controls.Add(this.tabPageVentas);
            this.tabControlEmpleado.Controls.Add(this.tabPageProductos);
            this.tabControlEmpleado.Controls.Add(this.tabPageClientes);
            this.tabControlEmpleado.Controls.Add(this.tabPageInformes);
            this.tabControlEmpleado.Controls.Add(this.tabPageProveedor);
            this.tabControlEmpleado.Location = new System.Drawing.Point(12, 12);
            this.tabControlEmpleado.Multiline = true;
            this.tabControlEmpleado.Name = "tabControlEmpleado";
            this.tabControlEmpleado.SelectedIndex = 0;
            this.tabControlEmpleado.Size = new System.Drawing.Size(932, 493);
            this.tabControlEmpleado.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlEmpleado.TabIndex = 0;
            // 
            // tabPageVentas
            // 
            this.tabPageVentas.Controls.Add(this.groupBoxBoleta);
            this.tabPageVentas.Controls.Add(this.groupBoxCliente);
            this.tabPageVentas.Controls.Add(this.groupBoxVenta);
            this.tabPageVentas.Location = new System.Drawing.Point(4, 22);
            this.tabPageVentas.Name = "tabPageVentas";
            this.tabPageVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVentas.Size = new System.Drawing.Size(924, 467);
            this.tabPageVentas.TabIndex = 0;
            this.tabPageVentas.Text = "Ventas";
            this.tabPageVentas.UseVisualStyleBackColor = true;
            // 
            // groupBoxBoleta
            // 
            this.groupBoxBoleta.Controls.Add(this.textBoxImpTotal);
            this.groupBoxBoleta.Controls.Add(this.label3);
            this.groupBoxBoleta.Controls.Add(this.label4);
            this.groupBoxBoleta.Controls.Add(this.label5);
            this.groupBoxBoleta.Controls.Add(this.textBoxIGV);
            this.groupBoxBoleta.Controls.Add(this.textBoxOpGravada);
            this.groupBoxBoleta.Location = new System.Drawing.Point(533, 137);
            this.groupBoxBoleta.Name = "groupBoxBoleta";
            this.groupBoxBoleta.Size = new System.Drawing.Size(380, 303);
            this.groupBoxBoleta.TabIndex = 15;
            this.groupBoxBoleta.TabStop = false;
            this.groupBoxBoleta.Text = "Boleta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(315, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // textBoxImpTotal
            // 
            this.textBoxImpTotal.Location = new System.Drawing.Point(274, 71);
            this.textBoxImpTotal.Name = "textBoxImpTotal";
            this.textBoxImpTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxImpTotal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "OP. GRAVADA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOTAL IGV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "IMPORTE TOTAL VENTA";
            // 
            // textBoxIGV
            // 
            this.textBoxIGV.Location = new System.Drawing.Point(274, 45);
            this.textBoxIGV.Name = "textBoxIGV";
            this.textBoxIGV.Size = new System.Drawing.Size(100, 20);
            this.textBoxIGV.TabIndex = 9;
            // 
            // textBoxOpGravada
            // 
            this.textBoxOpGravada.Location = new System.Drawing.Point(274, 19);
            this.textBoxOpGravada.Name = "textBoxOpGravada";
            this.textBoxOpGravada.Size = new System.Drawing.Size(100, 20);
            this.textBoxOpGravada.TabIndex = 8;
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.textBoxCodigoCliente);
            this.groupBoxCliente.Controls.Add(this.label2);
            this.groupBoxCliente.Controls.Add(this.dataGridViewCliente);
            this.groupBoxCliente.Location = new System.Drawing.Point(533, 6);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(380, 125);
            this.groupBoxCliente.TabIndex = 14;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // textBoxCodigoCliente
            // 
            this.textBoxCodigoCliente.Location = new System.Drawing.Point(92, 21);
            this.textBoxCodigoCliente.Name = "textBoxCodigoCliente";
            this.textBoxCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoCliente.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código cliente";
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigoCliente,
            this.ColumnNombresCliente,
            this.ColumnApellidosCliente});
            this.dataGridViewCliente.Location = new System.Drawing.Point(6, 47);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.Size = new System.Drawing.Size(366, 62);
            this.dataGridViewCliente.TabIndex = 11;
            // 
            // ColumnCodigoCliente
            // 
            this.ColumnCodigoCliente.HeaderText = "Código";
            this.ColumnCodigoCliente.Name = "ColumnCodigoCliente";
            // 
            // ColumnNombresCliente
            // 
            this.ColumnNombresCliente.HeaderText = "Nombres";
            this.ColumnNombresCliente.Name = "ColumnNombresCliente";
            // 
            // ColumnApellidosCliente
            // 
            this.ColumnApellidosCliente.HeaderText = "Apellidos";
            this.ColumnApellidosCliente.Name = "ColumnApellidosCliente";
            // 
            // groupBoxVenta
            // 
            this.groupBoxVenta.Controls.Add(this.dateTimePicker1);
            this.groupBoxVenta.Controls.Add(this.buttonNuevaVenta);
            this.groupBoxVenta.Controls.Add(this.label1);
            this.groupBoxVenta.Controls.Add(this.textBoxCodigoVenta);
            this.groupBoxVenta.Controls.Add(this.dataGridViewVenta);
            this.groupBoxVenta.Location = new System.Drawing.Point(6, 6);
            this.groupBoxVenta.Name = "groupBoxVenta";
            this.groupBoxVenta.Size = new System.Drawing.Size(521, 434);
            this.groupBoxVenta.TabIndex = 13;
            this.groupBoxVenta.TabStop = false;
            this.groupBoxVenta.Text = "Venta";
            // 
            // buttonNuevaVenta
            // 
            this.buttonNuevaVenta.Location = new System.Drawing.Point(188, 19);
            this.buttonNuevaVenta.Name = "buttonNuevaVenta";
            this.buttonNuevaVenta.Size = new System.Drawing.Size(87, 23);
            this.buttonNuevaVenta.TabIndex = 2;
            this.buttonNuevaVenta.Text = "Nueva venta";
            this.buttonNuevaVenta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo venta";
            // 
            // textBoxCodigoVenta
            // 
            this.textBoxCodigoVenta.Location = new System.Drawing.Point(82, 21);
            this.textBoxCodigoVenta.Name = "textBoxCodigoVenta";
            this.textBoxCodigoVenta.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoVenta.TabIndex = 1;
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigoProducto,
            this.ColumnNombreProducto,
            this.ColumnPrecioUnProducto,
            this.ColumnImporteProducto});
            this.dataGridViewVenta.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.Size = new System.Drawing.Size(509, 380);
            this.dataGridViewVenta.TabIndex = 3;
            // 
            // ColumnCodigoProducto
            // 
            this.ColumnCodigoProducto.HeaderText = "Código";
            this.ColumnCodigoProducto.Name = "ColumnCodigoProducto";
            // 
            // ColumnNombreProducto
            // 
            this.ColumnNombreProducto.HeaderText = "Nombre";
            this.ColumnNombreProducto.Name = "ColumnNombreProducto";
            // 
            // ColumnPrecioUnProducto
            // 
            this.ColumnPrecioUnProducto.HeaderText = "Precio unitario";
            this.ColumnPrecioUnProducto.Name = "ColumnPrecioUnProducto";
            // 
            // ColumnImporteProducto
            // 
            this.ColumnImporteProducto.HeaderText = "Importe";
            this.ColumnImporteProducto.Name = "ColumnImporteProducto";
            // 
            // tabPageProductos
            // 
            this.tabPageProductos.Controls.Add(this.pictureBoxProducto);
            this.tabPageProductos.Controls.Add(this.dataGridViewProducto);
            this.tabPageProductos.Controls.Add(this.textBoxCodigoProducto);
            this.tabPageProductos.Controls.Add(this.label6);
            this.tabPageProductos.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductos.Name = "tabPageProductos";
            this.tabPageProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductos.Size = new System.Drawing.Size(924, 467);
            this.tabPageProductos.TabIndex = 1;
            this.tabPageProductos.Text = "Productos";
            this.tabPageProductos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdProducto,
            this.ColumnNombreProductoProductos,
            this.ColumnCategoriaProducto,
            this.ColumnMarcaProducto,
            this.ColumnDescripcionProducto,
            this.ColumnPreUnitProductoProductos});
            this.dataGridViewProducto.Location = new System.Drawing.Point(9, 32);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.Size = new System.Drawing.Size(662, 319);
            this.dataGridViewProducto.TabIndex = 2;
            // 
            // ColumnIdProducto
            // 
            this.ColumnIdProducto.HeaderText = "Identificación";
            this.ColumnIdProducto.Name = "ColumnIdProducto";
            // 
            // ColumnNombreProductoProductos
            // 
            this.ColumnNombreProductoProductos.HeaderText = "Nombre";
            this.ColumnNombreProductoProductos.Name = "ColumnNombreProductoProductos";
            // 
            // ColumnCategoriaProducto
            // 
            this.ColumnCategoriaProducto.HeaderText = "Categoría";
            this.ColumnCategoriaProducto.Name = "ColumnCategoriaProducto";
            // 
            // ColumnMarcaProducto
            // 
            this.ColumnMarcaProducto.HeaderText = "Marca";
            this.ColumnMarcaProducto.Name = "ColumnMarcaProducto";
            // 
            // ColumnDescripcionProducto
            // 
            this.ColumnDescripcionProducto.HeaderText = "Descripción";
            this.ColumnDescripcionProducto.Name = "ColumnDescripcionProducto";
            // 
            // ColumnPreUnitProductoProductos
            // 
            this.ColumnPreUnitProductoProductos.HeaderText = "Precio Unitario";
            this.ColumnPreUnitProductoProductos.Name = "ColumnPreUnitProductoProductos";
            // 
            // textBoxCodigoProducto
            // 
            this.textBoxCodigoProducto.Location = new System.Drawing.Point(136, 6);
            this.textBoxCodigoProducto.Name = "textBoxCodigoProducto";
            this.textBoxCodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoProducto.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ingrese Código Producto";
            // 
            // tabPageClientes
            // 
            this.tabPageClientes.Location = new System.Drawing.Point(4, 22);
            this.tabPageClientes.Name = "tabPageClientes";
            this.tabPageClientes.Size = new System.Drawing.Size(881, 446);
            this.tabPageClientes.TabIndex = 2;
            this.tabPageClientes.Text = "Clientes";
            this.tabPageClientes.UseVisualStyleBackColor = true;
            // 
            // tabPageInformes
            // 
            this.tabPageInformes.Location = new System.Drawing.Point(4, 22);
            this.tabPageInformes.Name = "tabPageInformes";
            this.tabPageInformes.Size = new System.Drawing.Size(881, 446);
            this.tabPageInformes.TabIndex = 3;
            this.tabPageInformes.Text = "Informes";
            this.tabPageInformes.UseVisualStyleBackColor = true;
            // 
            // tabPageProveedor
            // 
            this.tabPageProveedor.Location = new System.Drawing.Point(4, 22);
            this.tabPageProveedor.Name = "tabPageProveedor";
            this.tabPageProveedor.Size = new System.Drawing.Size(881, 446);
            this.tabPageProveedor.TabIndex = 4;
            this.tabPageProveedor.Text = "Proveedores";
            this.tabPageProveedor.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProducto
            // 
            this.pictureBoxProducto.Location = new System.Drawing.Point(677, 32);
            this.pictureBoxProducto.Name = "pictureBoxProducto";
            this.pictureBoxProducto.Size = new System.Drawing.Size(241, 261);
            this.pictureBoxProducto.TabIndex = 3;
            this.pictureBoxProducto.TabStop = false;
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 506);
            this.Controls.Add(this.tabControlEmpleado);
            this.Name = "FormEmpleado";
            this.Text = "Empleado";
            this.tabControlEmpleado.ResumeLayout(false);
            this.tabPageVentas.ResumeLayout(false);
            this.groupBoxBoleta.ResumeLayout(false);
            this.groupBoxBoleta.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.groupBoxVenta.ResumeLayout(false);
            this.groupBoxVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            this.tabPageProductos.ResumeLayout(false);
            this.tabPageProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEmpleado;
        private System.Windows.Forms.TabPage tabPageVentas;
        private System.Windows.Forms.TabPage tabPageProductos;
        private System.Windows.Forms.Button buttonNuevaVenta;
        private System.Windows.Forms.TextBox textBoxCodigoVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombresCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidosCliente;
        private System.Windows.Forms.TextBox textBoxImpTotal;
        private System.Windows.Forms.TextBox textBoxIGV;
        private System.Windows.Forms.TextBox textBoxOpGravada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioUnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImporteProducto;
        private System.Windows.Forms.TextBox textBoxCodigoCliente;
        private System.Windows.Forms.GroupBox groupBoxVenta;
        private System.Windows.Forms.GroupBox groupBoxBoleta;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TabPage tabPageClientes;
        private System.Windows.Forms.TabPage tabPageInformes;
        private System.Windows.Forms.TabPage tabPageProveedor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreProductoProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarcaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreUnitProductoProductos;
        private System.Windows.Forms.TextBox textBoxCodigoProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxProducto;
    }
}