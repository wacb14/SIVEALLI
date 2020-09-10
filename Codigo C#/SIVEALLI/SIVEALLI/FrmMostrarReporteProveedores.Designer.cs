namespace SIVEALLI
{
    partial class FrmMostrarReporteProveedores
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spu_TProveedor_ListarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new SIVEALLI.DataSetPrincipal();
            this.spuNumeroDeProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spu_TProveedor_ListarTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spu_TProveedor_ListarTableAdapter();
            this.spuNumeroDeProveedoresTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuNumeroDeProveedoresTableAdapter();
            this.spuReporteFechaHoyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spuReporteFechaHoyTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuReporteFechaHoyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spu_TProveedor_ListarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDeProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuReporteFechaHoyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spu_TProveedor_ListarBindingSource
            // 
            this.spu_TProveedor_ListarBindingSource.DataMember = "spu_TProveedor_Listar";
            this.spu_TProveedor_ListarBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spuNumeroDeProveedoresBindingSource
            // 
            this.spuNumeroDeProveedoresBindingSource.DataMember = "spuNumeroDeProveedores";
            this.spuNumeroDeProveedoresBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetProveedores";
            reportDataSource1.Value = this.spu_TProveedor_ListarBindingSource;
            reportDataSource2.Name = "DataSetNProveedores";
            reportDataSource2.Value = this.spuNumeroDeProveedoresBindingSource;
            reportDataSource3.Name = "DataSetFecha";
            reportDataSource3.Value = this.spuReporteFechaHoyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIVEALLI.ReporteProveedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1070, 519);
            this.reportViewer1.TabIndex = 0;
            // 
            // spu_TProveedor_ListarTableAdapter
            // 
            this.spu_TProveedor_ListarTableAdapter.ClearBeforeFill = true;
            // 
            // spuNumeroDeProveedoresTableAdapter
            // 
            this.spuNumeroDeProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // spuReporteFechaHoyBindingSource
            // 
            this.spuReporteFechaHoyBindingSource.DataMember = "spuReporteFechaHoy";
            this.spuReporteFechaHoyBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // spuReporteFechaHoyTableAdapter
            // 
            this.spuReporteFechaHoyTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMostrarReporteProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMostrarReporteProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmMostrarReporteProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spu_TProveedor_ListarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDeProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuReporteFechaHoyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spu_TProveedor_ListarBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private System.Windows.Forms.BindingSource spuNumeroDeProveedoresBindingSource;
        private DataSetPrincipalTableAdapters.spu_TProveedor_ListarTableAdapter spu_TProveedor_ListarTableAdapter;
        private DataSetPrincipalTableAdapters.spuNumeroDeProveedoresTableAdapter spuNumeroDeProveedoresTableAdapter;
        private System.Windows.Forms.BindingSource spuReporteFechaHoyBindingSource;
        private DataSetPrincipalTableAdapters.spuReporteFechaHoyTableAdapter spuReporteFechaHoyTableAdapter;
    }
}