namespace SIVEALLI
{
    partial class FormInicioSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSistema));
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnNegocio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoUsuario.Image")));
            this.btnNuevoUsuario.Location = new System.Drawing.Point(13, 13);
            this.btnNuevoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(256, 256);
            this.btnNuevoUsuario.TabIndex = 35;
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnNegocio
            // 
            this.btnNegocio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNegocio.FlatAppearance.BorderSize = 0;
            this.btnNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegocio.Image = ((System.Drawing.Image)(resources.GetObject("btnNegocio.Image")));
            this.btnNegocio.Location = new System.Drawing.Point(277, 13);
            this.btnNegocio.Margin = new System.Windows.Forms.Padding(4);
            this.btnNegocio.Name = "btnNegocio";
            this.btnNegocio.Size = new System.Drawing.Size(256, 256);
            this.btnNegocio.TabIndex = 36;
            this.btnNegocio.UseVisualStyleBackColor = true;
            // 
            // FormInicioSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(562, 285);
            this.Controls.Add(this.btnNegocio);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormInicioSistema";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnNuevoUsuario;
        public System.Windows.Forms.Button btnNegocio;
    }
}