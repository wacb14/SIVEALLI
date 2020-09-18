namespace SIVEALLI
{
    partial class FormNotificaciones
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
            this.dgvNotificaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.AllowUserToAddRows = false;
            this.dgvNotificaciones.AllowUserToDeleteRows = false;
            this.dgvNotificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotificaciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNotificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Location = new System.Drawing.Point(13, 13);
            this.dgvNotificaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.ReadOnly = true;
            this.dgvNotificaciones.Size = new System.Drawing.Size(1007, 475);
            this.dgvNotificaciones.TabIndex = 0;
            // 
            // FormNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.dgvNotificaciones);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormNotificaciones";
            this.Text = "FormNotificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotificaciones;
    }
}