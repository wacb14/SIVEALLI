using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIVEALLI
{
    public partial class FrmMostrarReporteDevoluciones : Form
    {
        public FrmMostrarReporteDevoluciones()
        {
            InitializeComponent();
        }

        private void FrmMostrarReporteDevoluciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuNumeroDeDevoluciones' Puede moverla o quitarla según sea necesario.
            this.spuNumeroDeDevolucionesTableAdapter.Fill(this.DataSetPrincipal.spuNumeroDeDevoluciones);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuReporteDevolucionesPorFecha' Puede moverla o quitarla según sea necesario.
            this.spuReporteDevolucionesPorFechaTableAdapter.Fill(this.DataSetPrincipal.spuReporteDevolucionesPorFecha,Fecha,Fecha2);
            
            //this.spuReporteDevolucionesPorFechaTableAdapter.Fill(this.DataSetPrincipal.spuReporteDevolucionesPorFecha, Fecha, Fecha2);
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public DateTime Fecha { get; set; }
        public DateTime Fecha2 { get; set; }
    }
}
