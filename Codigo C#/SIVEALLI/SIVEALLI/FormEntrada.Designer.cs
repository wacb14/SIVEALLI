﻿namespace SIVEALLI
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
            this.TcNuevaEntrada = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonListo = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonEliminarDetalle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAniadir = new System.Windows.Forms.Button();
            this.CbCodigoProducto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvDetalleEntrada = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCodigoEntrada = new System.Windows.Forms.TextBox();
            this.BtnNuevaEntrada = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxCodigoProveedor = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GbBusqueda = new System.Windows.Forms.GroupBox();
            this.TbValorBusqueda = new System.Windows.Forms.TextBox();
            this.Lbl10 = new System.Windows.Forms.Label();
            this.Lbl9 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CbBuscarPor = new System.Windows.Forms.ComboBox();
            this.BtnGuardarH = new System.Windows.Forms.Button();
            this.BtnLimpiarH = new System.Windows.Forms.Button();
            this.BtnBorrarLineaH = new System.Windows.Forms.Button();
            this.DgvListaDellesH = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TbCodigoEntradaH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbProveedoresH = new System.Windows.Forms.ComboBox();
            this.TbSupervisor = new System.Windows.Forms.TextBox();
            this.DtpFechaH = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvBusquedaEntrada = new System.Windows.Forms.DataGridView();
            this.TcNuevaEntrada.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEntrada)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaDellesH)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusquedaEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // TcNuevaEntrada
            // 
            this.TcNuevaEntrada.Controls.Add(this.tabPage1);
            this.TcNuevaEntrada.Controls.Add(this.tabPage2);
            this.TcNuevaEntrada.Location = new System.Drawing.Point(12, 12);
            this.TcNuevaEntrada.Name = "TcNuevaEntrada";
            this.TcNuevaEntrada.SelectedIndex = 0;
            this.TcNuevaEntrada.Size = new System.Drawing.Size(1046, 531);
            this.TcNuevaEntrada.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonListo);
            this.tabPage1.Controls.Add(this.buttonLimpiar);
            this.tabPage1.Controls.Add(this.buttonEliminarDetalle);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvDetalleEntrada);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1038, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nueva entrada";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonListo
            // 
            this.buttonListo.Location = new System.Drawing.Point(883, 460);
            this.buttonListo.Name = "buttonListo";
            this.buttonListo.Size = new System.Drawing.Size(152, 33);
            this.buttonListo.TabIndex = 67;
            this.buttonListo.Text = "Guardar entrada";
            this.buttonListo.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(880, 421);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(152, 33);
            this.buttonLimpiar.TabIndex = 66;
            this.buttonLimpiar.Text = "Limpiar datos";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarDetalle
            // 
            this.buttonEliminarDetalle.Location = new System.Drawing.Point(880, 162);
            this.buttonEliminarDetalle.Name = "buttonEliminarDetalle";
            this.buttonEliminarDetalle.Size = new System.Drawing.Size(152, 33);
            this.buttonEliminarDetalle.TabIndex = 65;
            this.buttonEliminarDetalle.Text = "Borrar linea entrada";
            this.buttonEliminarDetalle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAniadir);
            this.groupBox1.Controls.Add(this.CbCodigoProducto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numericUpDownCantidad);
            this.groupBox1.Location = new System.Drawing.Point(454, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 84);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de producto";
            // 
            // BtnAniadir
            // 
            this.BtnAniadir.Location = new System.Drawing.Point(408, 30);
            this.BtnAniadir.Name = "BtnAniadir";
            this.BtnAniadir.Size = new System.Drawing.Size(152, 33);
            this.BtnAniadir.TabIndex = 6;
            this.BtnAniadir.Text = "Agregar producto";
            this.BtnAniadir.UseVisualStyleBackColor = true;
            // 
            // CbCodigoProducto
            // 
            this.CbCodigoProducto.FormattingEnabled = true;
            this.CbCodigoProducto.Location = new System.Drawing.Point(68, 34);
            this.CbCodigoProducto.Name = "CbCodigoProducto";
            this.CbCodigoProducto.Size = new System.Drawing.Size(162, 27);
            this.CbCodigoProducto.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Código";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cantidad";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(325, 35);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(53, 26);
            this.numericUpDownCantidad.TabIndex = 5;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvDetalleEntrada
            // 
            this.dgvDetalleEntrada.AllowUserToAddRows = false;
            this.dgvDetalleEntrada.AllowUserToDeleteRows = false;
            this.dgvDetalleEntrada.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetalleEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvDetalleEntrada.Location = new System.Drawing.Point(6, 144);
            this.dgvDetalleEntrada.Name = "dgvDetalleEntrada";
            this.dgvDetalleEntrada.ReadOnly = true;
            this.dgvDetalleEntrada.RowHeadersVisible = false;
            this.dgvDetalleEntrada.Size = new System.Drawing.Size(868, 349);
            this.dgvDetalleEntrada.TabIndex = 54;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 75;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCodigoEntrada);
            this.groupBox2.Controls.Add(this.BtnNuevaEntrada);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboBoxCodigoProveedor);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 132);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de documento de entrada";
            // 
            // tbCodigoEntrada
            // 
            this.tbCodigoEntrada.Enabled = false;
            this.tbCodigoEntrada.Location = new System.Drawing.Point(144, 41);
            this.tbCodigoEntrada.Name = "tbCodigoEntrada";
            this.tbCodigoEntrada.Size = new System.Drawing.Size(187, 26);
            this.tbCodigoEntrada.TabIndex = 2;
            // 
            // BtnNuevaEntrada
            // 
            this.BtnNuevaEntrada.Location = new System.Drawing.Point(337, 37);
            this.BtnNuevaEntrada.Name = "BtnNuevaEntrada";
            this.BtnNuevaEntrada.Size = new System.Drawing.Size(78, 33);
            this.BtnNuevaEntrada.TabIndex = 1;
            this.BtnNuevaEntrada.Text = "Nuevo";
            this.BtnNuevaEntrada.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Código entrada";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 78);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Proveedor";
            // 
            // comboBoxCodigoProveedor
            // 
            this.comboBoxCodigoProveedor.FormattingEnabled = true;
            this.comboBoxCodigoProveedor.Location = new System.Drawing.Point(144, 74);
            this.comboBoxCodigoProveedor.Name = "comboBoxCodigoProveedor";
            this.comboBoxCodigoProveedor.Size = new System.Drawing.Size(271, 27);
            this.comboBoxCodigoProveedor.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DgvBusquedaEntrada);
            this.tabPage2.Controls.Add(this.GbBusqueda);
            this.tabPage2.Controls.Add(this.BtnGuardarH);
            this.tabPage2.Controls.Add(this.BtnLimpiarH);
            this.tabPage2.Controls.Add(this.BtnBorrarLineaH);
            this.tabPage2.Controls.Add(this.DgvListaDellesH);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1038, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial entradas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GbBusqueda
            // 
            this.GbBusqueda.Controls.Add(this.TbValorBusqueda);
            this.GbBusqueda.Controls.Add(this.Lbl10);
            this.GbBusqueda.Controls.Add(this.Lbl9);
            this.GbBusqueda.Controls.Add(this.BtnBuscar);
            this.GbBusqueda.Controls.Add(this.CbBuscarPor);
            this.GbBusqueda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbBusqueda.Location = new System.Drawing.Point(6, 6);
            this.GbBusqueda.Name = "GbBusqueda";
            this.GbBusqueda.Size = new System.Drawing.Size(253, 195);
            this.GbBusqueda.TabIndex = 78;
            this.GbBusqueda.TabStop = false;
            this.GbBusqueda.Text = "Búsqueda de entradas";
            // 
            // TbValorBusqueda
            // 
            this.TbValorBusqueda.Location = new System.Drawing.Point(44, 122);
            this.TbValorBusqueda.Name = "TbValorBusqueda";
            this.TbValorBusqueda.Size = new System.Drawing.Size(165, 26);
            this.TbValorBusqueda.TabIndex = 17;
            // 
            // Lbl10
            // 
            this.Lbl10.AutoSize = true;
            this.Lbl10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl10.Location = new System.Drawing.Point(38, 100);
            this.Lbl10.Name = "Lbl10";
            this.Lbl10.Size = new System.Drawing.Size(171, 19);
            this.Lbl10.TabIndex = 15;
            this.Lbl10.Text = "Ingrese valor de búsqueda:";
            // 
            // Lbl9
            // 
            this.Lbl9.AutoSize = true;
            this.Lbl9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl9.Location = new System.Drawing.Point(38, 32);
            this.Lbl9.Name = "Lbl9";
            this.Lbl9.Size = new System.Drawing.Size(132, 19);
            this.Lbl9.TabIndex = 18;
            this.Lbl9.Text = "Buscar usuarios por:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(78, 163);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(92, 26);
            this.BtnBuscar.TabIndex = 18;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // CbBuscarPor
            // 
            this.CbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBuscarPor.FormattingEnabled = true;
            this.CbBuscarPor.ItemHeight = 19;
            this.CbBuscarPor.Items.AddRange(new object[] {
            "Id Entrada",
            "Id Proveedor",
            "Id Usuario",
            "Fecha"});
            this.CbBuscarPor.Location = new System.Drawing.Point(40, 54);
            this.CbBuscarPor.Name = "CbBuscarPor";
            this.CbBuscarPor.Size = new System.Drawing.Size(169, 27);
            this.CbBuscarPor.TabIndex = 19;
            // 
            // BtnGuardarH
            // 
            this.BtnGuardarH.Location = new System.Drawing.Point(880, 460);
            this.BtnGuardarH.Name = "BtnGuardarH";
            this.BtnGuardarH.Size = new System.Drawing.Size(152, 33);
            this.BtnGuardarH.TabIndex = 77;
            this.BtnGuardarH.Text = "Guardar entrada";
            this.BtnGuardarH.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiarH
            // 
            this.BtnLimpiarH.Location = new System.Drawing.Point(880, 421);
            this.BtnLimpiarH.Name = "BtnLimpiarH";
            this.BtnLimpiarH.Size = new System.Drawing.Size(152, 33);
            this.BtnLimpiarH.TabIndex = 76;
            this.BtnLimpiarH.Text = "Limpiar datos";
            this.BtnLimpiarH.UseVisualStyleBackColor = true;
            // 
            // BtnBorrarLineaH
            // 
            this.BtnBorrarLineaH.Location = new System.Drawing.Point(880, 382);
            this.BtnBorrarLineaH.Name = "BtnBorrarLineaH";
            this.BtnBorrarLineaH.Size = new System.Drawing.Size(152, 33);
            this.BtnBorrarLineaH.TabIndex = 75;
            this.BtnBorrarLineaH.Text = "Borrar linea entrada";
            this.BtnBorrarLineaH.UseVisualStyleBackColor = true;
            // 
            // DgvListaDellesH
            // 
            this.DgvListaDellesH.AllowUserToAddRows = false;
            this.DgvListaDellesH.AllowUserToDeleteRows = false;
            this.DgvListaDellesH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvListaDellesH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListaDellesH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaDellesH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.DgvListaDellesH.Location = new System.Drawing.Point(6, 333);
            this.DgvListaDellesH.Name = "DgvListaDellesH";
            this.DgvListaDellesH.ReadOnly = true;
            this.DgvListaDellesH.RowHeadersVisible = false;
            this.DgvListaDellesH.Size = new System.Drawing.Size(868, 160);
            this.DgvListaDellesH.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Código";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 130;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 75;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TbCodigoEntradaH);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.CbProveedoresH);
            this.groupBox4.Controls.Add(this.TbSupervisor);
            this.groupBox4.Controls.Add(this.DtpFechaH);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(6, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1026, 120);
            this.groupBox4.TabIndex = 68;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de documento de entrada";
            // 
            // TbCodigoEntradaH
            // 
            this.TbCodigoEntradaH.Location = new System.Drawing.Point(96, 40);
            this.TbCodigoEntradaH.Name = "TbCodigoEntradaH";
            this.TbCodigoEntradaH.Size = new System.Drawing.Size(187, 26);
            this.TbCodigoEntradaH.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "Supervisor";
            // 
            // CbProveedoresH
            // 
            this.CbProveedoresH.FormattingEnabled = true;
            this.CbProveedoresH.Location = new System.Drawing.Point(96, 72);
            this.CbProveedoresH.Name = "CbProveedoresH";
            this.CbProveedoresH.Size = new System.Drawing.Size(187, 27);
            this.CbProveedoresH.TabIndex = 3;
            // 
            // TbSupervisor
            // 
            this.TbSupervisor.Enabled = false;
            this.TbSupervisor.Location = new System.Drawing.Point(739, 76);
            this.TbSupervisor.Name = "TbSupervisor";
            this.TbSupervisor.Size = new System.Drawing.Size(100, 26);
            this.TbSupervisor.TabIndex = 73;
            // 
            // DtpFechaH
            // 
            this.DtpFechaH.Enabled = false;
            this.DtpFechaH.Location = new System.Drawing.Point(739, 44);
            this.DtpFechaH.Name = "DtpFechaH";
            this.DtpFechaH.Size = new System.Drawing.Size(281, 26);
            this.DtpFechaH.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "Fecha entrada";
            // 
            // DgvBusquedaEntrada
            // 
            this.DgvBusquedaEntrada.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvBusquedaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvBusquedaEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBusquedaEntrada.Location = new System.Drawing.Point(265, 6);
            this.DgvBusquedaEntrada.Name = "DgvBusquedaEntrada";
            this.DgvBusquedaEntrada.Size = new System.Drawing.Size(767, 195);
            this.DgvBusquedaEntrada.TabIndex = 79;
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.TcNuevaEntrada);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEntrada";
            this.Text = "Entrada";
            this.TcNuevaEntrada.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEntrada)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.GbBusqueda.ResumeLayout(false);
            this.GbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaDellesH)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBusquedaEntrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TcNuevaEntrada;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCodigoEntrada;
        private System.Windows.Forms.Button BtnNuevaEntrada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCodigoProveedor;
        private System.Windows.Forms.DataGridView dgvDetalleEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAniadir;
        private System.Windows.Forms.ComboBox CbCodigoProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Button buttonListo;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonEliminarDetalle;
        private System.Windows.Forms.Button BtnGuardarH;
        private System.Windows.Forms.Button BtnLimpiarH;
        private System.Windows.Forms.Button BtnBorrarLineaH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbSupervisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaH;
        private System.Windows.Forms.DataGridView DgvListaDellesH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TbCodigoEntradaH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbProveedoresH;
        private System.Windows.Forms.GroupBox GbBusqueda;
        private System.Windows.Forms.TextBox TbValorBusqueda;
        private System.Windows.Forms.Label Lbl10;
        private System.Windows.Forms.Label Lbl9;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CbBuscarPor;
        private System.Windows.Forms.DataGridView DgvBusquedaEntrada;
    }
}