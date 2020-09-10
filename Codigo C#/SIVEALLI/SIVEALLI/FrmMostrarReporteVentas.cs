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
    public partial class FrmMostrarReporteVentas : Form
    {
        public FrmMostrarReporteVentas()
        {
            InitializeComponent();
        }

        private void FrmMostrarReporteVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuReporteFechaHoy' Puede moverla o quitarla según sea necesario.
            this.spuReporteFechaHoyTableAdapter.Fill(this.DataSetPrincipal.spuReporteFechaHoy);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuNumeroDeVentas' Puede moverla o quitarla según sea necesario.
            this.spuNumeroDeVentasTableAdapter.Fill(this.DataSetPrincipal.spuNumeroDeVentas);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuReporteVentasPorFecha' Puede moverla o quitarla según sea necesario.
            this.spuReporteVentasPorFechaTableAdapter.Fill(this.DataSetPrincipal.spuReporteVentasPorFecha,Fecha,Fecha2);

            //this.spuReporteVentasPorFechaTableAdapter.Fill(this.DataSetPrincipal.spuReporteVentasPorFecha,Fecha,Fecha2);
            this.RwVentas.RefreshReport();

           
        }
        public DateTime Fecha { get; set; }
        public DateTime Fecha2 { get; set; }
    }
}
