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
            if (textBoxCodigoUsuario.Text.Length != 5)
            {
                MessageBox.Show("Ingrese un codigo valido");
                return;
            }
            //Verificar si existe clave primaria
            if (aUsuario.ExisteClavePrimaria(1, textBoxCodigoUsuario.Text))
            {
                string usuarioActivo = aUsuario.ValorAtributo("Estado");
                
                if (!usuarioActivo.Equals("ACTIVO"))
                {
                    MessageBox.Show("Usted no es un usuario activo.");
                    return;
                }
                string tipoUsuario = aUsuario.ValorAtributo("Tipo");
                if (tipoUsuario.Equals("SUPERVISOR"))
                {
                    this.Hide();
                    FormSupervisor fu = new FormSupervisor(textBoxCodigoUsuario.Text);
                    fu.Closed += (s, args) => this.Close();
                    fu.Show();
                }
                else
                {
                    this.Hide();
                    FormEmpleado fe = new FormEmpleado(textBoxCodigoUsuario.Text);
                    fe.Closed += (s, args) => this.Close();
                    fe.Show();
                }
            }
            else
            {
                //Registro nuevo, incializar atributos no clave
                MessageBox.Show("Usuario no encontrado");
            }
        }
    }
}
