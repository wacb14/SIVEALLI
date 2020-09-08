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
    public partial class FormInicioSistema : Form
    {
        public FormInicioSistema()
        {
            InitializeComponent();

            Eventos();
        }

        private void Eventos()
        {
            this.btnNuevoUsuario.Click += new EventHandler(NuevoUsuario);
        }

        private void NuevoUsuario(object sender, EventArgs e)
        {
            FormUsuarios fu = new FormUsuarios("US001");
            fu.Show();
        }
    }
}
