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
    public partial class FormLogin : Form
    {

        CUsuario aUsuario = new CUsuario();

        public FormLogin()
        {
            InitializeComponent();

            this.buttonAceptar.Click += new EventHandler(VerificarUsuario);
            this.buttonCancelar.Click += new EventHandler(LimpiarFormulario);
        }

        private void LimpiarFormulario(object sender, EventArgs e)
        {
            this.textBoxCodigoUsuario.Clear();
        }

        private void VerificarUsuario(object sender, EventArgs e)
        {
            //Verificar si existe clave primaria
            if (aUsuario.ExisteClavePrimaria(1, textBoxCodigoUsuario.Text))
            {
                FormSupervisor fe = new FormSupervisor(textBoxCodigoUsuario.Text);
                fe.Show();
            }
            else
            {
                //Registro nuevo, incializar atributos no clave
                MessageBox.Show("Usuario no encontrado");
            }
        }
    }
}
