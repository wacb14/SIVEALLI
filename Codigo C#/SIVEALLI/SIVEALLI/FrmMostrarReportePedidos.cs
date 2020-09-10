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
    public partial class FrmMostrarReportePedidos : Form
    {
        public FrmMostrarReportePedidos()
        {
            InitializeComponent();
        }

        private void FrmMostrarReportePedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuReporteFechaHoy' Puede moverla o quitarla según sea necesario.
            this.spuReporteFechaHoyTableAdapter.Fill(this.DataSetPrincipal.spuReporteFechaHoy);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuNumeroDePedidos' Puede moverla o quitarla según sea necesario.
            this.spuNumeroDePedidosTableAdapter.Fill(this.DataSetPrincipal.spuNumeroDePedidos);
            this.spuReportePedidosPorFechaTableAdapter.Fill(this.DataSetPrincipal.spuReportePedidosPorFecha, Fecha, Fecha2);
            this.reportViewer1.RefreshReport();
        }
        public DateTime Fecha { get; set; }
        public DateTime Fecha2 { get; set; }
    }
}
