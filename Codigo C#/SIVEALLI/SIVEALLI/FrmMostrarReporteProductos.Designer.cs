namespace SIVEALLI
{
    partial class FrmMostrarReporteProductos
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
            this.spuListarProductosSinImagenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new SIVEALLI.DataSetPrincipal();
            this.spuNumeroDeProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spuListarProductosSinImagenTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuListarProductosSinImagenTableAdapter();
            this.spuNumeroDeProductosTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuNumeroDeProductosTableAdapter();
            this.spuReporteFechaHoyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spuReporteFechaHoyTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuReporteFechaHoyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spuListarProductosSinImagenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDeProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuReporteFechaHoyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spuListarProductosSinImagenBindingSource
            // 
            this.spuListarProductosSinImagenBindingSource.DataMember = "spuListarProductosSinImagen";
            this.spuListarProductosSinImagenBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spuNumeroDeProductosBindingSource
            // 
            this.spuNumeroDeProductosBindingSource.DataMember = "spuNumeroDeProductos";
            this.spuNumeroDeProductosBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetProductos";
            reportDataSource1.Value = this.spuListarProductosSinImagenBindingSource;
            reportDataSource2.Name = "DataSetNProductos";
            reportDataSource2.Value = this.spuNumeroDeProductosBindingSource;
            reportDataSource3.Name = "DataSetFecha";
            reportDataSource3.Value = this.spuReporteFechaHoyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIVEALLI.ReporteProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1070, 519);
            this.reportViewer1.TabIndex = 0;
            // 
            // spuListarProductosSinImagenTableAdapter
            // 
            this.spuListarProductosSinImagenTableAdapter.ClearBeforeFill = true;
            // 
            // spuNumeroDeProductosTableAdapter
            // 
            this.spuNumeroDeProductosTableAdapter.ClearBeforeFill = true;
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
            // FrmMostrarReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMostrarReporteProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmMostrarReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spuListarProductosSinImagenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDeProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuReporteFechaHoyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spuListarProductosSinImagenBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private System.Windows.Forms.BindingSource spuNumeroDeProductosBindingSource;
        private DataSetPrincipalTableAdapters.spuListarProductosSinImagenTableAdapter spuListarProductosSinImagenTableAdapter;
        private DataSetPrincipalTableAdapters.spuNumeroDeProductosTableAdapter spuNumeroDeProductosTableAdapter;
        private System.Windows.Forms.BindingSource spuReporteFechaHoyBindingSource;
        private DataSetPrincipalTableAdapters.spuReporteFechaHoyTableAdapter spuReporteFechaHoyTableAdapter;
    }
}