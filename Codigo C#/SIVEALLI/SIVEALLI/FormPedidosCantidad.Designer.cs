namespace SIVEALLI
{
    partial class FormPedidosCantidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnAceptar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la cantidad de producto:";
            // 
            // NudCantidad
            // 
            this.NudCantidad.Location = new System.Drawing.Point(16, 31);
            this.NudCantidad.Maximum = new decimal(new int[] {
            1000,
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
            this.NudCantidad.TabIndex = 2;
            this.NudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(74, 63);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(81, 32);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnAceptar2
            // 
            this.BtnAceptar2.Location = new System.Drawing.Point(74, 63);
            this.BtnAceptar2.Name = "BtnAceptar2";
            this.BtnAceptar2.Size = new System.Drawing.Size(81, 32);
            this.BtnAceptar2.TabIndex = 4;
            this.BtnAceptar2.Text = "Aceptar";
            this.BtnAceptar2.UseVisualStyleBackColor = true;
            this.BtnAceptar2.Visible = false;
            this.BtnAceptar2.Click += new System.EventHandler(this.BtnAceptar2_Click);
            // 
            // FormPedidosCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 104);
            this.Controls.Add(this.BtnAceptar2);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.NudCantidad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPedidosCantidad";
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudCantidad;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnAceptar2;
    }
}