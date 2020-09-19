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
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLeerMensaje = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TcMensajes = new System.Windows.Forms.TabControl();
            this.TpMensajesNoLeidos = new System.Windows.Forms.TabPage();
            this.TpMensajesLeidos = new System.Windows.Forms.TabPage();
            this.BtnEliminarMensajesLeido = new System.Windows.Forms.Button();
            this.dgvMensajesLeidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.TcMensajes.SuspendLayout();
            this.TpMensajesNoLeidos.SuspendLayout();
            this.TpMensajesLeidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajesLeidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.AllowUserToAddRows = false;
            this.dgvNotificaciones.AllowUserToDeleteRows = false;
            this.dgvNotificaciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNotificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnMensaje,
            this.ColumnFecha,
            this.ColumnEstado,
            this.ColumnLeerMensaje});
            this.dgvNotificaciones.Location = new System.Drawing.Point(7, 7);
            this.dgvNotificaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.ReadOnly = true;
            this.dgvNotificaciones.Size = new System.Drawing.Size(1024, 346);
            this.dgvNotificaciones.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.FillWeight = 17.46843F;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 50;
            // 
            // ColumnMensaje
            // 
            this.ColumnMensaje.FillWeight = 33.52098F;
            this.ColumnMensaje.HeaderText = "Mensaje";
            this.ColumnMensaje.Name = "ColumnMensaje";
            this.ColumnMensaje.ReadOnly = true;
            this.ColumnMensaje.Width = 550;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.FillWeight = 65.86568F;
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.FillWeight = 129.3378F;
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            // 
            // ColumnLeerMensaje
            // 
            this.ColumnLeerMensaje.FillWeight = 253.8071F;
            this.ColumnLeerMensaje.HeaderText = "Marcar como leido";
            this.ColumnLeerMensaje.Name = "ColumnLeerMensaje";
            this.ColumnLeerMensaje.ReadOnly = true;
            this.ColumnLeerMensaje.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnLeerMensaje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnLeerMensaje.Width = 165;
            // 
            // TcMensajes
            // 
            this.TcMensajes.Controls.Add(this.TpMensajesNoLeidos);
            this.TcMensajes.Controls.Add(this.TpMensajesLeidos);
            this.TcMensajes.Location = new System.Drawing.Point(12, 12);
            this.TcMensajes.Name = "TcMensajes";
            this.TcMensajes.SelectedIndex = 0;
            this.TcMensajes.Size = new System.Drawing.Size(1046, 531);
            this.TcMensajes.TabIndex = 1;
            // 
            // TpMensajesNoLeidos
            // 
            this.TpMensajesNoLeidos.Controls.Add(this.dgvNotificaciones);
            this.TpMensajesNoLeidos.Location = new System.Drawing.Point(4, 28);
            this.TpMensajesNoLeidos.Name = "TpMensajesNoLeidos";
            this.TpMensajesNoLeidos.Padding = new System.Windows.Forms.Padding(3);
            this.TpMensajesNoLeidos.Size = new System.Drawing.Size(1038, 499);
            this.TpMensajesNoLeidos.TabIndex = 0;
            this.TpMensajesNoLeidos.Text = "Mensajes no leídos";
            this.TpMensajesNoLeidos.UseVisualStyleBackColor = true;
            // 
            // TpMensajesLeidos
            // 
            this.TpMensajesLeidos.Controls.Add(this.BtnEliminarMensajesLeido);
            this.TpMensajesLeidos.Controls.Add(this.dgvMensajesLeidos);
            this.TpMensajesLeidos.Location = new System.Drawing.Point(4, 28);
            this.TpMensajesLeidos.Name = "TpMensajesLeidos";
            this.TpMensajesLeidos.Padding = new System.Windows.Forms.Padding(3);
            this.TpMensajesLeidos.Size = new System.Drawing.Size(1038, 499);
            this.TpMensajesLeidos.TabIndex = 1;
            this.TpMensajesLeidos.Text = "Mensajes leidos";
            this.TpMensajesLeidos.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarMensajesLeido
            // 
            this.BtnEliminarMensajesLeido.Location = new System.Drawing.Point(6, 465);
            this.BtnEliminarMensajesLeido.Name = "BtnEliminarMensajesLeido";
            this.BtnEliminarMensajesLeido.Size = new System.Drawing.Size(176, 28);
            this.BtnEliminarMensajesLeido.TabIndex = 2;
            this.BtnEliminarMensajesLeido.Text = "Eliminar mensajes leidos";
            this.BtnEliminarMensajesLeido.UseVisualStyleBackColor = true;
            // 
            // dgvMensajesLeidos
            // 
            this.dgvMensajesLeidos.AllowUserToAddRows = false;
            this.dgvMensajesLeidos.AllowUserToDeleteRows = false;
            this.dgvMensajesLeidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMensajesLeidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMensajesLeidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensajesLeidos.Location = new System.Drawing.Point(4, 7);
            this.dgvMensajesLeidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMensajesLeidos.Name = "dgvMensajesLeidos";
            this.dgvMensajesLeidos.ReadOnly = true;
            this.dgvMensajesLeidos.Size = new System.Drawing.Size(948, 451);
            this.dgvMensajesLeidos.TabIndex = 1;
            // 
            // FormNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1070, 555);
            this.Controls.Add(this.TcMensajes);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNotificaciones";
            this.Text = "FormNotificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.TcMensajes.ResumeLayout(false);
            this.TpMensajesNoLeidos.ResumeLayout(false);
            this.TpMensajesLeidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajesLeidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotificaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnLeerMensaje;
        private System.Windows.Forms.TabControl TcMensajes;
        private System.Windows.Forms.TabPage TpMensajesNoLeidos;
        private System.Windows.Forms.TabPage TpMensajesLeidos;
        private System.Windows.Forms.Button BtnEliminarMensajesLeido;
        private System.Windows.Forms.DataGridView dgvMensajesLeidos;
    }
}