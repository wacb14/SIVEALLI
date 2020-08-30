namespace SIVEALLI
{
    partial class FrmMostrarReporteClientes
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
            this.spu_TCliente_ListarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spu_TCliente_ListarTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spu_TCliente_ListarTableAdapter();
            this.spuNumeroDeClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spuNumeroDeClientesTableAdapter = new SIVEALLI.DataSetPrincipalTableAdapters.spuNumeroDeClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spu_TCliente_ListarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDeClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetClientes";
            reportDataSource1.Value = this.spu_TCliente_ListarBindingSource;
            reportDataSource2.Name = "DataSetNClientes";
            reportDataSource2.Value = this.spuNumeroDeClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIVEALLI.ReporteClientes.rdlc";
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
            // spu_TCliente_ListarBindingSource
            // 
            this.spu_TCliente_ListarBindingSource.DataMember = "spu_TCliente_Listar";
            this.spu_TCliente_ListarBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // spu_TCliente_ListarTableAdapter
            // 
            this.spu_TCliente_ListarTableAdapter.ClearBeforeFill = true;
            // 
            // spuNumeroDeClientesBindingSource
            // 
            this.spuNumeroDeClientesBindingSource.DataMember = "spuNumeroDeClientes";
            this.spuNumeroDeClientesBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // spuNumeroDeClientesTableAdapter
            // 
            this.spuNumeroDeClientesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMostrarReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMostrarReporteClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmMostrarReporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spu_TCliente_ListarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spuNumeroDeClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spu_TCliente_ListarBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private System.Windows.Forms.BindingSource spuNumeroDeClientesBindingSource;
        private DataSetPrincipalTableAdapters.spu_TCliente_ListarTableAdapter spu_TCliente_ListarTableAdapter;
        private DataSetPrincipalTableAdapters.spuNumeroDeClientesTableAdapter spuNumeroDeClientesTableAdapter;
    }
}