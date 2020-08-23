using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibClases;

namespace SIVEALLI
{
    public partial class FormUsuarios : FormPadre
    {

        CUsuario u = new CUsuario();
        public FormUsuarios()
        {
            InitializeComponent();
            IniciarEntidad(new CUsuario());

            EventosYValidaciones();
        }

        private void EventosYValidaciones()
        {
            this.Load += new EventHandler(CargarDatos); 
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            dataGridViewUsuarios.DataSource = u.ListaGeneral();
        }

        public override string[] AsignarValoresAtributos()
        {
            return new string[] { textBoxCodigo.Text,
                textBoxNombres.Text, textBoxApellidos.Text,
                textBoxDireccion.Text, textBoxTelefono.Text,
                textBoxCorreo.Text, textBoxContrasegna.Text, 
                textBoxTipo.Text, textBoxEstado.Text};
        }
        public override void MostrarDatos()
        {
            textBoxCodigo.Text = aEntidad.ValorAtributo("IdUsuario");
            textBoxNombres.Text = aEntidad.ValorAtributo("Nombres");
            textBoxApellidos.Text = aEntidad.ValorAtributo("Apellidos");
            textBoxDireccion.Text = aEntidad.ValorAtributo("Direccion");
            textBoxTelefono.Text = aEntidad.ValorAtributo("Telefono");
            textBoxCorreo.Text = aEntidad.ValorAtributo("Correo");
            textBoxContrasegna.Text = aEntidad.ValorAtributo("Contraseña");
            textBoxTipo.Text = aEntidad.ValorAtributo("Tipo");
            textBoxEstado.Text = aEntidad.ValorAtributo("Estado");
        }
        public override void InicializarAtributoClave()
        {
            textBoxCodigo.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            textBoxCodigo.Text = "";
            textBoxNombres.Text = "";
            textBoxApellidos.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
            textBoxCorreo.Text = "";
            textBoxContrasegna.Text = "";
            textBoxTipo.Text = "";
            textBoxEstado.Text = "";
        }
        public override void ListarRegistros()
        {
            dataGridViewUsuarios.DataSource = aEntidad.ListaGeneral();
        }
        public override bool EsRegistroValido()
        {
            if (textBoxCodigo.Text.Trim() != "" && 
                textBoxApellidos.Text.Trim() != "" &&
                textBoxNombres.Text.Trim() != "" &&
                textBoxTipo.Text.Trim() != "" &&
                textBoxContrasegna.Text.Trim() != "")
                return true;
            else
                return false;
        }
        // ========================= EVENTOS =======================
        private void TxtCodLibro_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void FrmLibro_Load_1(object sender, EventArgs e)
        {
            ListarRegistros();
        }
    }
}
