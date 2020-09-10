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
    public partial class FrmMostrarReporteProveedores : Form
    {
        public FrmMostrarReporteProveedores()
        {
            InitializeComponent();
        }

        private void FrmMostrarReporteProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuReporteFechaHoy' Puede moverla o quitarla según sea necesario.
            this.spuReporteFechaHoyTableAdapter.Fill(this.DataSetPrincipal.spuReporteFechaHoy);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spu_TProveedor_Listar' Puede moverla o quitarla según sea necesario.
            this.spu_TProveedor_ListarTableAdapter.Fill(this.DataSetPrincipal.spu_TProveedor_Listar);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuNumeroDeProveedores' Puede moverla o quitarla según sea necesario.
            this.spuNumeroDeProveedoresTableAdapter.Fill(this.DataSetPrincipal.spuNumeroDeProveedores);

            this.reportViewer1.RefreshReport();
        }
    }
}
