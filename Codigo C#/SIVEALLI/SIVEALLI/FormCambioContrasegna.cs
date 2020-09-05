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
    public partial class FormCambioContrasegna : Form
    {
        CUsuario aUsuario;
        protected string codigoUsuario;
        public FormCambioContrasegna(string usuario)
        {
            codigoUsuario = usuario;
            aUsuario = new CUsuario();

            InitializeComponent();

            Eventos();
        }

        private void Eventos()
        {
            this.Load += new EventHandler(MostrarCodigoUsuario);
            btnCancelar.Click += new EventHandler(CerrarVentana);
            btnCambiar.Click += new EventHandler(CambiarContrasegna);
        }

        private void CambiarContrasegna(object sender, EventArgs e)
        {
            string contraseña = aUsuario.ObtenerContrasegna(codigoUsuario);
            if (contraseña.Equals(tbActual.Text))
            {
                aUsuario.CambiarContrasegna(codigoUsuario, tbNueva.Text);
                MessageBox.Show("Contraseña modificada");
            }
            else
                MessageBox.Show("Contraseña actual incorrecta");
        }

        private void CerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarCodigoUsuario(object sender, EventArgs e)
        {
            lblUsuario.Text = codigoUsuario;
        }
    }
}
