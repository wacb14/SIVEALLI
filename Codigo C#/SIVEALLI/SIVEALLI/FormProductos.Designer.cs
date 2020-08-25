namespace SIVEALLI
{
    partial class FormProductos
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
            this.GbProducto = new System.Windows.Forms.GroupBox();
            this.BtnNuevaImagen = new System.Windows.Forms.Button();
            this.Lbl8 = new System.Windows.Forms.Label();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.Lbl7 = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.Lbl6 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.PctBImagen = new System.Windows.Forms.PictureBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.GbProductos = new System.Windows.Forms.GroupBox();
            this.LblTotalProductos = new System.Windows.Forms.Label();
            this.BtnImprimirLista = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CboBuscarPor = new System.Windows.Forms.ComboBox();
            this.Lbl9 = new System.Windows.Forms.Label();
            this.Lbl11 = new System.Windows.Forms.Label();
            this.TxtValorBusqueda = new System.Windows.Forms.TextBox();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.Lbl10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnRestaurarLista = new System.Windows.Forms.Button();
            this.GbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBImagen)).BeginInit();
            this.GbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbProducto
            // 
            this.GbProducto.Controls.Add(this.BtnNuevo);
            this.GbProducto.Controls.Add(this.BtnNuevaImagen);
            this.GbProducto.Controls.Add(this.Lbl8);
            this.GbProducto.Controls.Add(this.CboEstado);
            this.GbProducto.Controls.Add(this.Lbl7);
            this.GbProducto.Controls.Add(this.BtnModificar);
            this.GbProducto.Controls.Add(this.Lbl4);
            this.GbProducto.Controls.Add(this.BtnGuardar);
            this.GbProducto.Controls.Add(this.TxtPrecioUnitario);
            this.GbProducto.Controls.Add(this.Lbl6);
            this.GbProducto.Controls.Add(this.TxtMarca);
            this.GbProducto.Controls.Add(this.Lbl5);
            this.GbProducto.Controls.Add(this.TxtCategoria);
            this.GbProducto.Controls.Add(this.Lbl3);
            this.GbProducto.Controls.Add(this.TxtNombre);
            this.GbProducto.Controls.Add(this.Lbl2);
            this.GbProducto.Controls.Add(this.TxtIdProducto);
            this.GbProducto.Controls.Add(this.Lbl1);
            this.GbProducto.Controls.Add(this.PctBImagen);
            this.GbProducto.Controls.Add(this.TxtDescripcion);
            this.GbProducto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbProducto.Location = new System.Drawing.Point(5, 4);
            this.GbProducto.Name = "GbProducto";
            this.GbProducto.Size = new System.Drawing.Size(387, 513);
            this.GbProducto.TabIndex = 5;
            this.GbProducto.TabStop = false;
            this.GbProducto.Text = "Datos del producto";
            // 
            // BtnNuevaImagen
            // 
            this.BtnNuevaImagen.Location = new System.Drawing.Point(213, 313);
            this.BtnNuevaImagen.Name = "BtnNuevaImagen";
            this.BtnNuevaImagen.Size = new System.Drawing.Size(109, 27);
            this.BtnNuevaImagen.TabIndex = 22;
            this.BtnNuevaImagen.Text = "Nueva Imagen";
            this.BtnNuevaImagen.UseVisualStyleBackColor = true;
            // 
            // Lbl8
            // 
            this.Lbl8.AutoSize = true;
            this.Lbl8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl8.Location = new System.Drawing.Point(241, 37);
            this.Lbl8.Name = "Lbl8";
            this.Lbl8.Size = new System.Drawing.Size(53, 19);
            this.Lbl8.TabIndex = 17;
            this.Lbl8.Text = "Imagen";
            // 
            // CboEstado
            // 
            this.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "RETIRADO",
            "OTRO"});
            this.CboEstado.Location = new System.Drawing.Point(10, 314);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(148, 27);
            this.CboEstado.TabIndex = 16;
            // 
            // Lbl7
            // 
            this.Lbl7.AutoSize = true;
            this.Lbl7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl7.Location = new System.Drawing.Point(5, 292);
            this.Lbl7.Name = "Lbl7";
            this.Lbl7.Size = new System.Drawing.Size(51, 19);
            this.Lbl7.TabIndex = 15;
            this.Lbl7.Text = "Estado";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(144, 466);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(92, 27);
            this.BtnModificar.TabIndex = 14;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4.Location = new System.Drawing.Point(5, 343);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(81, 19);
            this.Lbl4.TabIndex = 6;
            this.Lbl4.Text = "Descripción";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(238, 466);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 27);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(10, 263);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(148, 26);
            this.TxtPrecioUnitario.TabIndex = 11;
            // 
            // Lbl6
            // 
            this.Lbl6.AutoSize = true;
            this.Lbl6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl6.Location = new System.Drawing.Point(6, 241);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(100, 19);
            this.Lbl6.TabIndex = 10;
            this.Lbl6.Text = "Precio Unitario";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(10, 161);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(150, 26);
            this.TxtMarca.TabIndex = 9;
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl5.Location = new System.Drawing.Point(6, 139);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(49, 19);
            this.Lbl5.TabIndex = 8;
            this.Lbl5.Text = "Marca";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(10, 212);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(149, 26);
            this.TxtCategoria.TabIndex = 5;
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(6, 190);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(68, 19);
            this.Lbl3.TabIndex = 4;
            this.Lbl3.Text = "Categoría";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(10, 110);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(150, 26);
            this.TxtNombre.TabIndex = 3;
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(6, 88);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(60, 19);
            this.Lbl2.TabIndex = 2;
            this.Lbl2.Text = "Nombre";
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Location = new System.Drawing.Point(10, 59);
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(152, 26);
            this.TxtIdProducto.TabIndex = 1;
            this.TxtIdProducto.Leave += new System.EventHandler(this.TxtIdProducto_Leave);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(6, 37);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(82, 19);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Id Producto";
            // 
            // PctBImagen
            // 
            this.PctBImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PctBImagen.Location = new System.Drawing.Point(182, 68);
            this.PctBImagen.Name = "PctBImagen";
            this.PctBImagen.Size = new System.Drawing.Size(172, 230);
            this.PctBImagen.TabIndex = 21;
            this.PctBImagen.TabStop = false;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(9, 365);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(361, 81);
            this.TxtDescripcion.TabIndex = 7;
            // 
            // GbProductos
            // 
            this.GbProductos.Controls.Add(this.BtnRestaurarLista);
            this.GbProductos.Controls.Add(this.LblTotalProductos);
            this.GbProductos.Controls.Add(this.BtnImprimirLista);
            this.GbProductos.Controls.Add(this.BtnBuscar);
            this.GbProductos.Controls.Add(this.CboBuscarPor);
            this.GbProductos.Controls.Add(this.Lbl9);
            this.GbProductos.Controls.Add(this.Lbl11);
            this.GbProductos.Controls.Add(this.TxtValorBusqueda);
            this.GbProductos.Controls.Add(this.DgvProductos);
            this.GbProductos.Controls.Add(this.Lbl10);
            this.GbProductos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbProductos.Location = new System.Drawing.Point(398, 5);
            this.GbProductos.Name = "GbProductos";
            this.GbProductos.Size = new System.Drawing.Size(660, 460);
            this.GbProductos.TabIndex = 6;
            this.GbProductos.TabStop = false;
            this.GbProductos.Text = "Lista de productos";
            // 
            // LblTotalProductos
            // 
            this.LblTotalProductos.AutoSize = true;
            this.LblTotalProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotalProductos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalProductos.Location = new System.Drawing.Point(569, 383);
            this.LblTotalProductos.Name = "LblTotalProductos";
            this.LblTotalProductos.Size = new System.Drawing.Size(19, 21);
            this.LblTotalProductos.TabIndex = 21;
            this.LblTotalProductos.Text = "0";
            // 
            // BtnImprimirLista
            // 
            this.BtnImprimirLista.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimirLista.Location = new System.Drawing.Point(461, 414);
            this.BtnImprimirLista.Name = "BtnImprimirLista";
            this.BtnImprimirLista.Size = new System.Drawing.Size(127, 27);
            this.BtnImprimirLista.TabIndex = 20;
            this.BtnImprimirLista.Text = "Imprimir Lista";
            this.BtnImprimirLista.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(270, 390);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(92, 26);
            this.BtnBuscar.TabIndex = 15;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CboBuscarPor
            // 
            this.CboBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBuscarPor.FormattingEnabled = true;
            this.CboBuscarPor.Items.AddRange(new object[] {
            "ID Producto",
            "Nombre",
            "Categoria",
            "Marca",
            "Precio Unitario",
            "Estado"});
            this.CboBuscarPor.Location = new System.Drawing.Point(23, 356);
            this.CboBuscarPor.Name = "CboBuscarPor";
            this.CboBuscarPor.Size = new System.Drawing.Size(219, 27);
            this.CboBuscarPor.TabIndex = 19;
            // 
            // Lbl9
            // 
            this.Lbl9.AutoSize = true;
            this.Lbl9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl9.Location = new System.Drawing.Point(19, 334);
            this.Lbl9.Name = "Lbl9";
            this.Lbl9.Size = new System.Drawing.Size(144, 19);
            this.Lbl9.TabIndex = 18;
            this.Lbl9.Text = "Buscar productos por:";
            // 
            // Lbl11
            // 
            this.Lbl11.AutoSize = true;
            this.Lbl11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl11.Location = new System.Drawing.Point(432, 385);
            this.Lbl11.Name = "Lbl11";
            this.Lbl11.Size = new System.Drawing.Size(131, 19);
            this.Lbl11.TabIndex = 17;
            this.Lbl11.Text = "Total de Productos :";
            // 
            // TxtValorBusqueda
            // 
            this.TxtValorBusqueda.Location = new System.Drawing.Point(23, 415);
            this.TxtValorBusqueda.Name = "TxtValorBusqueda";
            this.TxtValorBusqueda.Size = new System.Drawing.Size(219, 26);
            this.TxtValorBusqueda.TabIndex = 16;
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Location = new System.Drawing.Point(6, 25);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.Size = new System.Drawing.Size(648, 300);
            this.DgvProductos.TabIndex = 0;
            // 
            // Lbl10
            // 
            this.Lbl10.AutoSize = true;
            this.Lbl10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl10.Location = new System.Drawing.Point(19, 393);
            this.Lbl10.Name = "Lbl10";
            this.Lbl10.Size = new System.Drawing.Size(171, 19);
            this.Lbl10.TabIndex = 15;
            this.Lbl10.Text = "Ingrese valor de búsqueda:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(398, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 47);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(597, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Es importante cerrar el formulario al terminar de usarlo, para un mejor funcionam" +
    "iento del sistema.";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(50, 466);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(92, 27);
            this.BtnNuevo.TabIndex = 23;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnRestaurarLista
            // 
            this.BtnRestaurarLista.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestaurarLista.Location = new System.Drawing.Point(433, 342);
            this.BtnRestaurarLista.Name = "BtnRestaurarLista";
            this.BtnRestaurarLista.Size = new System.Drawing.Size(170, 27);
            this.BtnRestaurarLista.TabIndex = 22;
            this.BtnRestaurarLista.Text = "Restaurar Lista Completa";
            this.BtnRestaurarLista.UseVisualStyleBackColor = true;
            this.BtnRestaurarLista.Click += new System.EventHandler(this.BtnRestaurarLista_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbProductos);
            this.Controls.Add(this.GbProducto);
            this.Name = "FormProductos";
            this.Text = "Productos";
            this.GbProducto.ResumeLayout(false);
            this.GbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBImagen)).EndInit();
            this.GbProductos.ResumeLayout(false);
            this.GbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbProducto;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtPrecioUnitario;
        private System.Windows.Forms.Label Lbl6;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.TextBox TxtIdProducto;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.GroupBox GbProductos;
        private System.Windows.Forms.Button BtnImprimirLista;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CboBuscarPor;
        private System.Windows.Forms.Label Lbl9;
        private System.Windows.Forms.Label Lbl11;
        private System.Windows.Forms.TextBox TxtValorBusqueda;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Label Lbl10;
        private System.Windows.Forms.Button BtnNuevaImagen;
        private System.Windows.Forms.Label Lbl8;
        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.Label Lbl7;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.PictureBox PctBImagen;
        private System.Windows.Forms.Label LblTotalProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnRestaurarLista;
    }
}