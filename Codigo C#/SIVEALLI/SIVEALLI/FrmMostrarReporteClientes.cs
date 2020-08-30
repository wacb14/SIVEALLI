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
    public partial class FrmMostrarReporteClientes : Form
    {
        public FrmMostrarReporteClientes()
        {
            InitializeComponent();
        }

        private void FrmMostrarReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spu_TCliente_Listar' Puede moverla o quitarla según sea necesario.
            this.spu_TCliente_ListarTableAdapter.Fill(this.DataSetPrincipal.spu_TCliente_Listar);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuNumeroDeClientes' Puede moverla o quitarla según sea necesario.
            this.spuNumeroDeClientesTableAdapter.Fill(this.DataSetPrincipal.spuNumeroDeClientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
