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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrada));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerEntrada = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCodigoProveedor = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonAniadir = new System.Windows.Forms.Button();
            this.buttonNuevaEntrada = new System.Windows.Forms.Button();
            this.groupBoxDatosEntrada = new System.Windows.Forms.GroupBox();
            this.groupBoxEntradaProducto = new System.Windows.Forms.GroupBox();
            this.dataGridViewDetalleEntrada = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxDatosEntrada.SuspendLayout();
            this.groupBoxEntradaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código entrada";
            // 
            // textBoxCodigoEntrada
            // 
            this.textBoxCodigoEntrada.Location = new System.Drawing.Point(143, 54);
            this.textBoxCodigoEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCodigoEntrada.Name = "textBoxCodigoEntrada";
            this.textBoxCodigoEntrada.Size = new System.Drawing.Size(149, 26);
            this.textBoxCodigoEntrada.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código proveedor";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Enabled = false;
            this.textBoxUsuario.Location = new System.Drawing.Point(143, 122);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(149, 26);
            this.textBoxUsuario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código Usuario";
            // 
            // dateTimePickerEntrada
            // 
            this.dateTimePickerEntrada.Location = new System.Drawing.Point(792, 10);
            this.dateTimePickerEntrada.Name = "dateTimePickerEntrada";
            this.dateTimePickerEntrada.Size = new System.Drawing.Size(266, 26);
            this.dateTimePickerEntrada.TabIndex = 6;
            // 
            // comboBoxCodigoProveedor
            // 
            this.comboBoxCodigoProveedor.FormattingEnabled = true;
            this.comboBoxCodigoProveedor.Location = new System.Drawing.Point(143, 88);
            this.comboBoxCodigoProveedor.Name = "comboBoxCodigoProveedor";
            this.comboBoxCodigoProveedor.Size = new System.Drawing.Size(149, 27);
            this.comboBoxCodigoProveedor.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 26);
            this.textBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(443, 46);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 11;
            // 
            // buttonAniadir
            // 
            this.buttonAniadir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAniadir.FlatAppearance.BorderSize = 0;
            this.buttonAniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAniadir.Image = ((System.Drawing.Image)(resources.GetObject("buttonAniadir.Image")));
            this.buttonAniadir.Location = new System.Drawing.Point(570, 24);
            this.buttonAniadir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAniadir.Name = "buttonAniadir";
            this.buttonAniadir.Size = new System.Drawing.Size(68, 66);
            this.buttonAniadir.TabIndex = 33;
            this.buttonAniadir.UseVisualStyleBackColor = true;
            // 
            // buttonNuevaEntrada
            // 
            this.buttonNuevaEntrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNuevaEntrada.FlatAppearance.BorderSize = 0;
            this.buttonNuevaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevaEntrada.Image = ((System.Drawing.Image)(resources.GetObject("buttonNuevaEntrada.Image")));
            this.buttonNuevaEntrada.Location = new System.Drawing.Point(300, 33);
            this.buttonNuevaEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNuevaEntrada.Name = "buttonNuevaEntrada";
            this.buttonNuevaEntrada.Size = new System.Drawing.Size(68, 66);
            this.buttonNuevaEntrada.TabIndex = 34;
            this.buttonNuevaEntrada.UseVisualStyleBackColor = true;
            // 
            // groupBoxDatosEntrada
            // 
            this.groupBoxDatosEntrada.Controls.Add(this.buttonNuevaEntrada);
            this.groupBoxDatosEntrada.Controls.Add(this.label1);
            this.groupBoxDatosEntrada.Controls.Add(this.textBoxCodigoEntrada);
            this.groupBoxDatosEntrada.Controls.Add(this.label2);
            this.groupBoxDatosEntrada.Controls.Add(this.label3);
            this.groupBoxDatosEntrada.Controls.Add(this.textBoxUsuario);
            this.groupBoxDatosEntrada.Controls.Add(this.comboBoxCodigoProveedor);
            this.groupBoxDatosEntrada.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatosEntrada.Name = "groupBoxDatosEntrada";
            this.groupBoxDatosEntrada.Size = new System.Drawing.Size(372, 179);
            this.groupBoxDatosEntrada.TabIndex = 35;
            this.groupBoxDatosEntrada.TabStop = false;
            this.groupBoxDatosEntrada.Text = "Datos de documento de entrada";
            // 
            // groupBoxEntradaProducto
            // 
            this.groupBoxEntradaProducto.Controls.Add(this.textBox1);
            this.groupBoxEntradaProducto.Controls.Add(this.label4);
            this.groupBoxEntradaProducto.Controls.Add(this.buttonAniadir);
            this.groupBoxEntradaProducto.Controls.Add(this.label5);
            this.groupBoxEntradaProducto.Controls.Add(this.numericUpDown1);
            this.groupBoxEntradaProducto.Location = new System.Drawing.Point(404, 91);
            this.groupBoxEntradaProducto.Name = "groupBoxEntradaProducto";
            this.groupBoxEntradaProducto.Size = new System.Drawing.Size(654, 100);
            this.groupBoxEntradaProducto.TabIndex = 36;
            this.groupBoxEntradaProducto.TabStop = false;
            this.groupBoxEntradaProducto.Text = "Datos de producto";
            // 
            // dataGridViewDetalleEntrada
            // 
            this.dataGridViewDetalleEntrada.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDetalleEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDetalleEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleEntrada.Location = new System.Drawing.Point(12, 197);
            this.dataGridViewDetalleEntrada.Name = "dataGridViewDetalleEntrada";
            this.dataGridViewDetalleEntrada.Size = new System.Drawing.Size(1046, 310);
            this.dataGridViewDetalleEntrada.TabIndex = 37;
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.dataGridViewDetalleEntrada);
            this.Controls.Add(this.groupBoxEntradaProducto);
            this.Controls.Add(this.groupBoxDatosEntrada);
            this.Controls.Add(this.dateTimePickerEntrada);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEntrada";
            this.Text = "FormEntrada";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntrada;
        private System.Windows.Forms.ComboBox comboBoxCodigoProveedor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        protected System.Windows.Forms.Button buttonAniadir;
        protected System.Windows.Forms.Button buttonNuevaEntrada;
        private System.Windows.Forms.GroupBox groupBoxDatosEntrada;
        private System.Windows.Forms.GroupBox groupBoxEntradaProducto;
        private System.Windows.Forms.DataGridView dataGridViewDetalleEntrada;
    }
}