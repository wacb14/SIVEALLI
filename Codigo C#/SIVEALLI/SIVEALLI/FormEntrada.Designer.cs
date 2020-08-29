namespace SIVEALLI
{
    partial class FormEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrada));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerEntrada = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCodigoProveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.buttonAniadir = new System.Windows.Forms.Button();
            this.buttonNuevaEntrada = new System.Windows.Forms.Button();
            this.groupBoxDatosEntrada = new System.Windows.Forms.GroupBox();
            this.groupBoxEntradaProducto = new System.Windows.Forms.GroupBox();
            this.comboBoxCodigoProducto = new System.Windows.Forms.ComboBox();
            this.dataGridViewDetalleEntrada = new System.Windows.Forms.DataGridView();
            this.ColumnCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioUnitacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.groupBoxDatosEntrada.SuspendLayout();
            this.groupBoxEntradaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código entrada";
            // 
            // textBoxCodigoEntrada
            // 
            this.textBoxCodigoEntrada.Location = new System.Drawing.Point(152, 41);
            this.textBoxCodigoEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodigoEntrada.Name = "textBoxCodigoEntrada";
            this.textBoxCodigoEntrada.Size = new System.Drawing.Size(188, 26);
            this.textBoxCodigoEntrada.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código proveedor";
            // 
            // dateTimePickerEntrada
            // 
            this.dateTimePickerEntrada.Location = new System.Drawing.Point(792, 12);
            this.dateTimePickerEntrada.Name = "dateTimePickerEntrada";
            this.dateTimePickerEntrada.Size = new System.Drawing.Size(266, 26);
            this.dateTimePickerEntrada.TabIndex = 6;
            // 
            // comboBoxCodigoProveedor
            // 
            this.comboBoxCodigoProveedor.FormattingEnabled = true;
            this.comboBoxCodigoProveedor.Location = new System.Drawing.Point(152, 75);
            this.comboBoxCodigoProveedor.Name = "comboBoxCodigoProveedor";
            this.comboBoxCodigoProveedor.Size = new System.Drawing.Size(188, 27);
            this.comboBoxCodigoProveedor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(442, 42);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(72, 26);
            this.numericUpDownCantidad.TabIndex = 5;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAniadir
            // 
            this.buttonAniadir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAniadir.FlatAppearance.BorderSize = 0;
            this.buttonAniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAniadir.Image = ((System.Drawing.Image)(resources.GetObject("buttonAniadir.Image")));
            this.buttonAniadir.Location = new System.Drawing.Point(521, 20);
            this.buttonAniadir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAniadir.Name = "buttonAniadir";
            this.buttonAniadir.Size = new System.Drawing.Size(68, 66);
            this.buttonAniadir.TabIndex = 6;
            this.buttonAniadir.UseVisualStyleBackColor = true;
            // 
            // buttonNuevaEntrada
            // 
            this.buttonNuevaEntrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNuevaEntrada.FlatAppearance.BorderSize = 0;
            this.buttonNuevaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevaEntrada.Image = ((System.Drawing.Image)(resources.GetObject("buttonNuevaEntrada.Image")));
            this.buttonNuevaEntrada.Location = new System.Drawing.Point(357, 20);
            this.buttonNuevaEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNuevaEntrada.Name = "buttonNuevaEntrada";
            this.buttonNuevaEntrada.Size = new System.Drawing.Size(68, 66);
            this.buttonNuevaEntrada.TabIndex = 1;
            this.buttonNuevaEntrada.UseVisualStyleBackColor = true;
            // 
            // groupBoxDatosEntrada
            // 
            this.groupBoxDatosEntrada.Controls.Add(this.buttonNuevaEntrada);
            this.groupBoxDatosEntrada.Controls.Add(this.label1);
            this.groupBoxDatosEntrada.Controls.Add(this.textBoxCodigoEntrada);
            this.groupBoxDatosEntrada.Controls.Add(this.label2);
            this.groupBoxDatosEntrada.Controls.Add(this.comboBoxCodigoProveedor);
            this.groupBoxDatosEntrada.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatosEntrada.Name = "groupBoxDatosEntrada";
            this.groupBoxDatosEntrada.Size = new System.Drawing.Size(435, 132);
            this.groupBoxDatosEntrada.TabIndex = 35;
            this.groupBoxDatosEntrada.TabStop = false;
            this.groupBoxDatosEntrada.Text = "Datos de documento de entrada";
            // 
            // groupBoxEntradaProducto
            // 
            this.groupBoxEntradaProducto.Controls.Add(this.comboBoxCodigoProducto);
            this.groupBoxEntradaProducto.Controls.Add(this.label4);
            this.groupBoxEntradaProducto.Controls.Add(this.buttonAniadir);
            this.groupBoxEntradaProducto.Controls.Add(this.label5);
            this.groupBoxEntradaProducto.Controls.Add(this.numericUpDownCantidad);
            this.groupBoxEntradaProducto.Location = new System.Drawing.Point(453, 44);
            this.groupBoxEntradaProducto.Name = "groupBoxEntradaProducto";
            this.groupBoxEntradaProducto.Size = new System.Drawing.Size(605, 100);
            this.groupBoxEntradaProducto.TabIndex = 36;
            this.groupBoxEntradaProducto.TabStop = false;
            this.groupBoxEntradaProducto.Text = "Datos de producto";
            // 
            // comboBoxCodigoProducto
            // 
            this.comboBoxCodigoProducto.FormattingEnabled = true;
            this.comboBoxCodigoProducto.Location = new System.Drawing.Point(139, 42);
            this.comboBoxCodigoProducto.Name = "comboBoxCodigoProducto";
            this.comboBoxCodigoProducto.Size = new System.Drawing.Size(188, 27);
            this.comboBoxCodigoProducto.TabIndex = 4;
            // 
            // dataGridViewDetalleEntrada
            // 
            this.dataGridViewDetalleEntrada.AllowUserToAddRows = false;
            this.dataGridViewDetalleEntrada.AllowUserToDeleteRows = false;
            this.dataGridViewDetalleEntrada.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDetalleEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetalleEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigoProducto,
            this.ColumnNombre,
            this.ColumnCategoria,
            this.ColumnMarca,
            this.ColumnPrecioUnitacio,
            this.ColumnCantidad});
            this.dataGridViewDetalleEntrada.Location = new System.Drawing.Point(12, 150);
            this.dataGridViewDetalleEntrada.Name = "dataGridViewDetalleEntrada";
            this.dataGridViewDetalleEntrada.ReadOnly = true;
            this.dataGridViewDetalleEntrada.Size = new System.Drawing.Size(939, 357);
            this.dataGridViewDetalleEntrada.TabIndex = 37;
            // 
            // ColumnCodigoProducto
            // 
            this.ColumnCodigoProducto.HeaderText = "Código";
            this.ColumnCodigoProducto.Name = "ColumnCodigoProducto";
            this.ColumnCodigoProducto.ReadOnly = true;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 200;
            // 
            // ColumnCategoria
            // 
            this.ColumnCategoria.HeaderText = "Categoría";
            this.ColumnCategoria.Name = "ColumnCategoria";
            this.ColumnCategoria.ReadOnly = true;
            this.ColumnCategoria.Width = 200;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.HeaderText = "Marca";
            this.ColumnMarca.Name = "ColumnMarca";
            this.ColumnMarca.ReadOnly = true;
            // 
            // ColumnPrecioUnitacio
            // 
            this.ColumnPrecioUnitacio.HeaderText = "Precio Unitario";
            this.ColumnPrecioUnitacio.Name = "ColumnPrecioUnitacio";
            this.ColumnPrecioUnitacio.ReadOnly = true;
            this.ColumnPrecioUnitacio.Width = 200;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.ReadOnly = true;
            this.ColumnCantidad.Width = 80;
            // 
            // buttonEditar
            // 
            this.buttonEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditar.Image")));
            this.buttonEditar.Location = new System.Drawing.Point(958, 179);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(68, 66);
            this.buttonEditar.TabIndex = 38;
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewDetalleEntrada);
            this.Controls.Add(this.groupBoxEntradaProducto);
            this.Controls.Add(this.groupBoxDatosEntrada);
            this.Controls.Add(this.dateTimePickerEntrada);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEntrada";
            this.Text = "Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.groupBoxDatosEntrada.ResumeLayout(false);
            this.groupBoxDatosEntrada.PerformLayout();
            this.groupBoxEntradaProducto.ResumeLayout(false);
            this.groupBoxEntradaProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleEntrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntrada;
        private System.Windows.Forms.ComboBox comboBoxCodigoProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        protected System.Windows.Forms.Button buttonAniadir;
        protected System.Windows.Forms.Button buttonNuevaEntrada;
        private System.Windows.Forms.GroupBox groupBoxDatosEntrada;
        private System.Windows.Forms.GroupBox groupBoxEntradaProducto;
        private System.Windows.Forms.DataGridView dataGridViewDetalleEntrada;
        private System.Windows.Forms.ComboBox comboBoxCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioUnitacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        protected System.Windows.Forms.Button buttonEditar;
    }
}