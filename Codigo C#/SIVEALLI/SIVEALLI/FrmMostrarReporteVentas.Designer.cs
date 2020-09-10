namespace SIVEALLI
{
    partial class FrmMostrarReporteVentas
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
            this.spuReporteVentasPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new SIVEALLI.DataSetPrincipal();
            this.spuNumeroDeVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spuReporteVentasPorFechaTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuReporteVentasPorFechaTableAdapter();
            this.RwVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.spuNumeroDeVentasTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuNumeroDeVentasTableAdapter();
            this.spuReporteFechaHoyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spuReporteFechaHoyTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuReporteFechaHoyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spuReporteVentasPorFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDeVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuReporteFechaHoyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spuReporteVentasPorFechaBindingSource
            // 
            this.spuReporteVentasPorFechaBindingSource.DataMember = "spuReporteVentasPorFecha";
            this.spuReporteVentasPorFechaBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spuNumeroDeVentasBindingSource
            // 
            this.spuNumeroDeVentasBindingSource.DataMember = "spuNumeroDeVentas";
            this.spuNumeroDeVentasBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // spuReporteVentasPorFechaTableAdapter
            // 
            this.spuReporteVentasPorFechaTableAdapter.ClearBeforeFill = true;
            // 
            // RwVentas
            // 
            this.RwVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVentas";
            reportDataSource1.Value = this.spuReporteVentasPorFechaBindingSource;
            reportDataSource2.Name = "DataSetNVentas";
            reportDataSource2.Value = this.spuNumeroDeVentasBindingSource;
            reportDataSource3.Name = "DataSetFecha";
            reportDataSource3.Value = this.spuReporteFechaHoyBindingSource;
            this.RwVentas.LocalReport.DataSources.Add(reportDataSource1);
            this.RwVentas.LocalReport.DataSources.Add(reportDataSource2);
            this.RwVentas.LocalReport.DataSources.Add(reportDataSource3);
            this.RwVentas.LocalReport.ReportEmbeddedResource = "SIVEALLI.ReporteVentas.rdlc";
            this.RwVentas.Location = new System.Drawing.Point(0, 0);
            this.RwVentas.Name = "RwVentas";
            this.RwVentas.ServerReport.BearerToken = null;
            this.RwVentas.Size = new System.Drawing.Size(1070, 519);
            this.RwVentas.TabIndex = 0;
            // 
            // spuNumeroDeVentasTableAdapter
            // 
            this.spuNumeroDeVentasTableAdapter.ClearBeforeFill = true;
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
            // FrmMostrarReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.RwVentas);
            this.Name = "FrmMostrarReporteVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmMostrarReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spuReporteVentasPorFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDeVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuReporteFechaHoyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource spuReporteVentasPorFechaBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.spuReporteVentasPorFechaTableAdapter spuReporteVentasPorFechaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer RwVentas;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.BindingSource spuNumeroDeVentasBindingSource;
        private DataSetPrincipalTableAdapters.spuNumeroDeVentasTableAdapter spuNumeroDeVentasTableAdapter;
        private System.Windows.Forms.BindingSource spuReporteFechaHoyBindingSource;
        private DataSetPrincipalTableAdapters.spuReporteFechaHoyTableAdapter spuReporteFechaHoyTableAdapter;
    }
}