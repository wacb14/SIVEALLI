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
    public partial class FrmMostrarReporteProductos : Form
    {
        public FrmMostrarReporteProductos()
        {
            InitializeComponent();
        }

        private void FrmMostrarReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuReporteFechaHoy' Puede moverla o quitarla según sea necesario.
            this.spuReporteFechaHoyTableAdapter.Fill(this.DataSetPrincipal.spuReporteFechaHoy);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuListarProductosSinImagen' Puede moverla o quitarla según sea necesario.
            this.spuListarProductosSinImagenTableAdapter.Fill(this.DataSetPrincipal.spuListarProductosSinImagen);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuNumeroDeProductos' Puede moverla o quitarla según sea necesario.
            this.spuNumeroDeProductosTableAdapter.Fill(this.DataSetPrincipal.spuNumeroDeProductos);

            this.reportViewer1.RefreshReport();
        }
    }
}
