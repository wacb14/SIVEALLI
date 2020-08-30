namespace SIVEALLI
{
    partial class FrmMostrarReporteDevoluciones
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
            this.spuReporteDevolucionesPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new SIVEALLI.DataSetPrincipal();
            this.spuReporteDevolucionesPorFechaTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuReporteDevolucionesPorFechaTableAdapter();
            this.spuNumeroDeDevolucionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spuNumeroDeDevolucionesTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuNumeroDeDevolucionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spuReporteDevolucionesPorFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDeDevolucionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDevoluciones";
            reportDataSource1.Value = this.spuReporteDevolucionesPorFechaBindingSource;
            reportDataSource2.Name = "DataSetNDevoluciones";
            reportDataSource2.Value = this.spuNumeroDeDevolucionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIVEALLI.ReporteDevoluciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1054, 480);
            this.reportViewer1.TabIndex = 0;
            // 
            // spuReporteDevolucionesPorFechaBindingSource
            // 
            this.spuReporteDevolucionesPorFechaBindingSource.DataMember = "spuReporteDevolucionesPorFecha";
            this.spuReporteDevolucionesPorFechaBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spuReporteDevolucionesPorFechaTableAdapter
            // 
            this.spuReporteDevolucionesPorFechaTableAdapter.ClearBeforeFill = true;
            // 
            // spuNumeroDeDevolucionesBindingSource
            // 
            this.spuNumeroDeDevolucionesBindingSource.DataMember = "spuNumeroDeDevoluciones";
            this.spuNumeroDeDevolucionesBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // spuNumeroDeDevolucionesTableAdapter
            // 
            this.spuNumeroDeDevolucionesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMostrarReporteDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 480);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMostrarReporteDevoluciones";
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.FrmMostrarReporteDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spuReporteDevolucionesPorFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDeDevolucionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spuReporteDevolucionesPorFechaBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.spuReporteDevolucionesPorFechaTableAdapter spuReporteDevolucionesPorFechaTableAdapter;
        private System.Windows.Forms.BindingSource spuNumeroDeDevolucionesBindingSource;
        private DataSetPrincipalTableAdapters.spuNumeroDeDevolucionesTableAdapter spuNumeroDeDevolucionesTableAdapter;
    }
}