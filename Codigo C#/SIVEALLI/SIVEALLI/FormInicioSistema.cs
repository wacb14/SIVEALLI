using BibClases;
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

        private CUsuario aUsuario = new CUsuario();
        private CNegocio aNegocio = new CNegocio();
        public FormInicioSistema()
        {
            InitializeComponent();

            Eventos();
        }

        private void Eventos()
        {
            this.btnNuevoUsuario.Click += new EventHandler(NuevoUsuario);
            this.btnNegocio.Click += new EventHandler(IngresarDatosNegocio);
            this.btLogin.Click += new EventHandler(AbrirLogin);
        }

        private void AbrirLogin(object sender, EventArgs e)
        {
            if (aUsuario.NumeroRegistros() == 0 || aNegocio.NumeroRegistros() == 0)
            {
                MessageBox.Show("Para continuar primero ingrese un usuario y los datos del negocio");
                return;
            }

            this.Hide();
            FormLogin fu = new FormLogin();
            fu.Closed += (s, args) => this.Close();
            fu.Show();
        }

        private void IngresarDatosNegocio(object sender, EventArgs e)
        {
            if (aUsuario.NumeroRegistros() == 0)
            {
                MessageBox.Show("Para continuar primero ingrese un usuario");
                return;
            }

            CNegocio negocio = new CNegocio();
            negocio.InsertarPrimeraVez("","","","","","","","","", dtpFecha.Value.Date.ToString());
            FormNegocio fu = new FormNegocio();
            fu.Show();
        }

        private void NuevoUsuario(object sender, EventArgs e)
        {
            FormUsuarios fu = new FormUsuarios("US001");
            fu.Show();
        }
    }
}
