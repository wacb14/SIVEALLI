namespace SIVEALLI
{
    partial class FrmMostrarReportePedidos
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
            this.spuReportePedidosPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new SIVEALLI.DataSetPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spuReportePedidosPorFechaTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuReportePedidosPorFechaTableAdapter();
            this.spuNumeroDePedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spuNumeroDePedidosTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuNumeroDePedidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spuReportePedidosPorFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDePedidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spuReportePedidosPorFechaBindingSource
            // 
            this.spuReportePedidosPorFechaBindingSource.DataMember = "spuReportePedidosPorFecha";
            this.spuReportePedidosPorFechaBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPedidos";
            reportDataSource1.Value = this.spuReportePedidosPorFechaBindingSource;
            reportDataSource2.Name = "DataSetNPedidos";
            reportDataSource2.Value = this.spuNumeroDePedidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIVEALLI.ReportePedidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1054, 480);
            this.reportViewer1.TabIndex = 0;
            // 
            // spuReportePedidosPorFechaTableAdapter
            // 
            this.spuReportePedidosPorFechaTableAdapter.ClearBeforeFill = true;
            // 
            // spuNumeroDePedidosBindingSource
            // 
            this.spuNumeroDePedidosBindingSource.DataMember = "spuNumeroDePedidos";
            this.spuNumeroDePedidosBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // spuNumeroDePedidosTableAdapter
            // 
            this.spuNumeroDePedidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMostrarReportePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 480);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMostrarReportePedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmMostrarReportePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spuReportePedidosPorFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDePedidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spuReportePedidosPorFechaBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.spuReportePedidosPorFechaTableAdapter spuReportePedidosPorFechaTableAdapter;
        private System.Windows.Forms.BindingSource spuNumeroDePedidosBindingSource;
        private DataSetPrincipalTableAdapters.spuNumeroDePedidosTableAdapter spuNumeroDePedidosTableAdapter;
    }
}