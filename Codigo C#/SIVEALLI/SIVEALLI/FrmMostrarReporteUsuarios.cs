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
    public partial class FrmMostrarReporteUsuarios : Form
    {
        public FrmMostrarReporteUsuarios()
        {
            InitializeComponent();
        }

        private void FrmMostrarReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spu_TUsuario_Listar' Puede moverla o quitarla según sea necesario.
            this.spu_TUsuario_ListarTableAdapter.Fill(this.DataSetPrincipal.spu_TUsuario_Listar);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spuNumeroDeUsuarios' Puede moverla o quitarla según sea necesario.
            this.spuNumeroDeUsuariosTableAdapter.Fill(this.DataSetPrincipal.spuNumeroDeUsuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
