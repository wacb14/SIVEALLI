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
            this.btLogin = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoUsuario.Image")));
            this.btnNuevoUsuario.Location = new System.Drawing.Point(20, 66);
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
            this.btnNegocio.Location = new System.Drawing.Point(284, 66);
            this.btnNegocio.Margin = new System.Windows.Forms.Padding(4);
            this.btnNegocio.Name = "btnNegocio";
            this.btnNegocio.Size = new System.Drawing.Size(256, 256);
            this.btnNegocio.TabIndex = 36;
            this.btnNegocio.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Image = ((System.Drawing.Image)(resources.GetObject("btLogin.Image")));
            this.btLogin.Location = new System.Drawing.Point(548, 66);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(256, 256);
            this.btLogin.TabIndex = 37;
            this.btLogin.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(527, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(277, 26);
            this.dtpFecha.TabIndex = 38;
            // 
            // FormInicioSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(828, 335);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btnNegocio);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInicioSistema";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnNuevoUsuario;
        public System.Windows.Forms.Button btnNegocio;
        public System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}