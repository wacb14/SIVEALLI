namespace SIVEALLI
{
    partial class FormVentasCantidad
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
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.Lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(85, 105);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(81, 26);
            this.BtnAceptar.TabIndex = 6;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // NudCantidad
            // 
            this.NudCantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudCantidad.Location = new System.Drawing.Point(85, 58);
            this.NudCantidad.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.NudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.Size = new System.Drawing.Size(81, 26);
            this.NudCantidad.TabIndex = 5;
            this.NudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCantidad.ValueChanged += new System.EventHandler(this.NudCantidad_ValueChanged);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(15, 16);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(206, 19);
            this.Lbl1.TabIndex = 4;
            this.Lbl1.Text = "Ingrese la cantidad del producto:";
            // 
            // FormVentasCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 152);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.NudCantidad);
            this.Controls.Add(this.Lbl1);
            this.Name = "FormVentasCantidad";
            this.Text = "Cantidad Producto";
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.NumericUpDown NudCantidad;
        private System.Windows.Forms.Label Lbl1;
    }
}