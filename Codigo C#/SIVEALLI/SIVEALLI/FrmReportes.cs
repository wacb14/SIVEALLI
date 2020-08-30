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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void BtnReporteVentas_Click(object sender, EventArgs e)
        {
            FrmMostrarReporteVentas Mostrar = new FrmMostrarReporteVentas();
            Mostrar.Fecha = DtpFecha.Value;
            Mostrar.Fecha2 = DtpFecha2.Value;
            Mostrar.ShowDialog();
        }

        private void BtnReporteEntradas_Click(object sender, EventArgs e)
        {
            FrmMostrarReporteEntradas Mostrar = new FrmMostrarReporteEntradas();
            Mostrar.Fecha = DtpFecha.Value;
            Mostrar.Fecha2 = DtpFecha2.Value;
            Mostrar.ShowDialog();
        }

        private void BtnReporteDevoluciones_Click(object sender, EventArgs e)
        {
            FrmMostrarReporteDevoluciones Mostrar = new FrmMostrarReporteDevoluciones();
            Mostrar.Fecha = DtpFecha.Value;
            Mostrar.Fecha2 = DtpFecha2.Value;
            Mostrar.ShowDialog();
        }

        private void BtnReportePedidos_Click(object sender, EventArgs e)
        {
            FrmMostrarReportePedidos Mostrar = new FrmMostrarReportePedidos();
            Mostrar.Fecha = DtpFecha.Value;
            Mostrar.Fecha2 = DtpFecha2.Value;
            Mostrar.ShowDialog();
        }

        private void BtnReporteClientes_Click(object sender, EventArgs e)
        {
            FrmMostrarReporteClientes Mostrar = new FrmMostrarReporteClientes();
            Mostrar.ShowDialog();
        }

        private void BtnReporteUsuarios_Click(object sender, EventArgs e)
        {
            FrmMostrarReporteUsuarios Mostrar = new FrmMostrarReporteUsuarios();
            Mostrar.ShowDialog();
        }

        private void BtnReporteProveedores_Click(object sender, EventArgs e)
        {
            FrmMostrarReporteProveedores Mostrar = new FrmMostrarReporteProveedores();
            Mostrar.ShowDialog();
        }

        private void BtnReporteProductos_Click(object sender, EventArgs e)
        {
            FrmMostrarReporteProductos Mostrar = new FrmMostrarReporteProductos();
            Mostrar.ShowDialog();
        }
    }
}
