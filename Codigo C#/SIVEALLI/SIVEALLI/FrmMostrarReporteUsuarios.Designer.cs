namespace SIVEALLI
{
    partial class FrmMostrarReporteUsuarios
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetPrincipal = new SIVEALLI.DataSetPrincipal();
            this.spu_TUsuario_ListarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spu_TUsuario_ListarTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spu_TUsuario_ListarTableAdapter();
            this.spuNumeroDeUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spuNumeroDeUsuariosTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuNumeroDeUsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spu_TUsuario_ListarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDeUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetUsuarios";
            reportDataSource1.Value = this.spu_TUsuario_ListarBindingSource;
            reportDataSource2.Name = "DataSetNUsuarios";
            reportDataSource2.Value = this.spuNumeroDeUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIVEALLI.ReporteUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1070, 519);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spu_TUsuario_ListarBindingSource
            // 
            this.spu_TUsuario_ListarBindingSource.DataMember = "spu_TUsuario_Listar";
            this.spu_TUsuario_ListarBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // spu_TUsuario_ListarTableAdapter
            // 
            this.spu_TUsuario_ListarTableAdapter.ClearBeforeFill = true;
            // 
            // spuNumeroDeUsuariosBindingSource
            // 
            this.spuNumeroDeUsuariosBindingSource.DataMember = "spuNumeroDeUsuarios";
            this.spuNumeroDeUsuariosBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // spuNumeroDeUsuariosTableAdapter
            // 
            this.spuNumeroDeUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMostrarReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMostrarReporteUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmMostrarReporteUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spu_TUsuario_ListarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDeUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spu_TUsuario_ListarBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private System.Windows.Forms.BindingSource spuNumeroDeUsuariosBindingSource;
        private DataSetPrincipalTableAdapters.spu_TUsuario_ListarTableAdapter spu_TUsuario_ListarTableAdapter;
        private DataSetPrincipalTableAdapters.spuNumeroDeUsuariosTableAdapter spuNumeroDeUsuariosTableAdapter;
    }
}