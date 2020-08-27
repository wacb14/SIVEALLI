namespace SIVEALLI
{
    partial class FormPedidos
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
            this.CbProveedores = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DgvPedidosDetalle = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.LTotal = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.TbFiltrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.CbProv = new System.Windows.Forms.ComboBox();
            this.TbTermPedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvCatalogoProductos = new System.Windows.Forms.DataGridView();
            this.CbProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GbCliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // CbProveedores
            // 
            this.CbProveedores.Controls.Add(this.BtnGuardar);
            this.CbProveedores.Controls.Add(this.DgvPedidosDetalle);
            this.CbProveedores.Controls.Add(this.button5);
            this.CbProveedores.Controls.Add(this.LTotal);
            this.CbProveedores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProveedores.Location = new System.Drawing.Point(398, 12);
            this.CbProveedores.Name = "CbProveedores";
            this.CbProveedores.Size = new System.Drawing.Size(660, 428);
            this.CbProveedores.TabIndex = 11;
            this.CbProveedores.TabStop = false;
            this.CbProveedores.Text = "Detalles de pedido";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(6, 385);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 37);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DgvPedidosDetalle
            // 
            this.DgvPedidosDetalle.AllowUserToAddRows = false;
            this.DgvPedidosDetalle.AllowUserToDeleteRows = false;
            this.DgvPedidosDetalle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvPedidosDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPedidosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidosDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNombre,
            this.ColPrecio,
            this.ColCantidad,
            this.ColSubTotal,
            this.ColBorrar,
            this.ColPos});
            this.DgvPedidosDetalle.Location = new System.Drawing.Point(6, 22);
            this.DgvPedidosDetalle.Name = "DgvPedidosDetalle";
            this.DgvPedidosDetalle.RowHeadersVisible = false;
            this.DgvPedidosDetalle.Size = new System.Drawing.Size(648, 338);
            this.DgvPedidosDetalle.TabIndex = 21;
            this.DgvPedidosDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedidosDetalle_CellContentClick);
            this.DgvPedidosDetalle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPedidosDetalle_CellValueChanged);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id producto";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 105;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 200;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio Uni.";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 120;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Width = 80;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.HeaderText = "Sub. Total";
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.ReadOnly = true;
            // 
            // ColBorrar
            // 
            this.ColBorrar.HeaderText = "";
            this.ColBorrar.Name = "ColBorrar";
            this.ColBorrar.Width = 40;
            // 
            // ColPos
            // 
            this.ColPos.HeaderText = "colPos";
            this.ColPos.Name = "ColPos";
            this.ColPos.Visible = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(562, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 32);
            this.button5.TabIndex = 20;
            this.button5.Text = "Imprimir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.Location = new System.Drawing.Point(483, 363);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(120, 19);
            this.LTotal.TabIndex = 17;
            this.LTotal.Text = "Importe total: s/ 0 ";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.Location = new System.Drawing.Point(282, 268);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(92, 32);
            this.BtnFiltrar.TabIndex = 15;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // TbFiltrar
            // 
            this.TbFiltrar.Location = new System.Drawing.Point(10, 274);
            this.TbFiltrar.Name = "TbFiltrar";
            this.TbFiltrar.Size = new System.Drawing.Size(148, 26);
            this.TbFiltrar.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Filtrar busqueda por: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(398, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 61);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(597, 38);
            this.label10.TabIndex = 20;
            this.label10.Text = "Es importante cerrar el formulario al terminar de usarlo, para un mejor funcionam" +
    "iento del sistema.\r\nSi desea ver todos los productos, pulse filtrar sin ningun t" +
    "exto.";
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.CbProv);
            this.GbCliente.Controls.Add(this.TbTermPedido);
            this.GbCliente.Controls.Add(this.label4);
            this.GbCliente.Controls.Add(this.label2);
            this.GbCliente.Controls.Add(this.TbId);
            this.GbCliente.Controls.Add(this.label1);
            this.GbCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCliente.Location = new System.Drawing.Point(12, 12);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(380, 183);
            this.GbCliente.TabIndex = 10;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Datos del pedido";
            // 
            // CbProv
            // 
            this.CbProv.FormattingEnabled = true;
            this.CbProv.Location = new System.Drawing.Point(10, 94);
            this.CbProv.Name = "CbProv";
            this.CbProv.Size = new System.Drawing.Size(253, 27);
            this.CbProv.TabIndex = 8;
            // 
            // TbTermPedido
            // 
            this.TbTermPedido.Location = new System.Drawing.Point(10, 146);
            this.TbTermPedido.Name = "TbTermPedido";
            this.TbTermPedido.Size = new System.Drawing.Size(364, 26);
            this.TbTermPedido.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Terminos de pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proveedor";
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(9, 44);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(103, 26);
            this.TbId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvCatalogoProductos);
            this.groupBox2.Controls.Add(this.TbFiltrar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BtnFiltrar);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 306);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Catalogo de productos";
            // 
            // DgvCatalogoProductos
            // 
            this.DgvCatalogoProductos.AllowUserToAddRows = false;
            this.DgvCatalogoProductos.AllowUserToDeleteRows = false;
            this.DgvCatalogoProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvCatalogoProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCatalogoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCatalogoProductos.Location = new System.Drawing.Point(6, 18);
            this.DgvCatalogoProductos.Name = "DgvCatalogoProductos";
            this.DgvCatalogoProductos.RowHeadersVisible = false;
            this.DgvCatalogoProductos.Size = new System.Drawing.Size(368, 231);
            this.DgvCatalogoProductos.TabIndex = 22;
            this.DgvCatalogoProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCatalogoProductos_CellContentClick);
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CbProveedores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbCliente);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            this.CbProveedores.ResumeLayout(false);
            this.CbProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogoProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CbProveedores;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.TextBox TbFiltrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TbTermPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPedidosDetalle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvCatalogoProductos;
        private System.Windows.Forms.ComboBox CbProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPos;
    }
}