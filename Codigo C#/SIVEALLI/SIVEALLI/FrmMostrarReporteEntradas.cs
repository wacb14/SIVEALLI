using System;
using System.Windows.Forms;

namespace SIVEALLI
{
    public partial class FrmMostrarReporteEntradas : Form
    {
        public FrmMostrarReporteEntradas()
        {
            InitializeComponent();
        }

        private void FrmMostrarReporteEntradas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuNumeroDeEntradas' Puede moverla o quitarla según sea necesario.
            this.spuNumeroDeEntradasTableAdapter.Fill(this.DataSetPrincipal.spuNumeroDeEntradas);
            this.spuReporteEntradasPorFechaTableAdapter.Fill(this.DataSetPrincipal.spuReporteEntradasPorFecha, Fecha, Fecha2);
            this.reportViewer1.RefreshReport();
        }
        public DateTime Fecha { get; set; }
        public DateTime Fecha2 { get; set; }
    }
}
