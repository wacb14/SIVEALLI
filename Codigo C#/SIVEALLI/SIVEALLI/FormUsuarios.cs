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

        protected CUsuario aUsuario = new CUsuario();
        protected string codigoUsuario;
        public FormUsuarios(string usuario)
        {
            codigoUsuario = usuario;
            InitializeComponent();
            IniciarEntidad(new CUsuario());

            EventosYValidaciones();
        }

        private void EventosYValidaciones()
        {
            this.Load += new EventHandler(CargarDatos);
            textBoxCodigo.Leave += new EventHandler(AbandonarTextBoxCodigo);
            textBoxCodigo.TextChanged += new EventHandler(CambioCodigo);
            this.dataGridViewUsuarios.CellClick += new DataGridViewCellEventHandler(MostrarDatosEnFormulario);
            this.btnRestaurarContra.Click += new EventHandler(RestaurarContraseña);
            this.btnRestMiCont.Click += new EventHandler(RestaurarMiContraseña);
            this.btnCambioContra.Click += new EventHandler(CambiarContraseña);

            //Validaciones
            textBoxNombres.KeyPress += new KeyPressEventHandler(Procesos.ValidarTextBoxSoloLetras);
            textBoxApellidos.KeyPress += new KeyPressEventHandler(Procesos.ValidarTextBoxSoloLetras);
            textBoxTelefono.KeyPress += new KeyPressEventHandler(Procesos.ValidarTextBoxSoloNumeros);
        }

        private void RestaurarMiContraseña(object sender, EventArgs e)
        {

            aUsuario.RestaurarContrasegna(codigoUsuario);
            MessageBox.Show("Nueva contraseña (igual a la identificación): " + codigoUsuario);

        }

        private void CambiarContraseña(object sender, EventArgs e)
        {
            FormCambioContrasegna fu = new FormCambioContrasegna(codigoUsuario);
            fu.Show();
        }

        private void RestaurarContraseña(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text.Equals(""))
            {
                MessageBox.Show("Seleccione un codigo");
                return;
            }

            DialogResult result = MessageBox.Show("Esta operación guardará al usuario que la realizó y la fecha. ¿Desea continuar?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                aUsuario.RestaurarContrasegna(textBoxCodigo.Text);
                MessageBox.Show("Nueva contraseña (igual a la identificación): " + textBoxCodigo.Text);
            }
        }

        private void MostrarDatosEnFormulario(object sender, EventArgs e)
        {
            try
            {
                //Averigüar la fila seleccionada
                int fila = dataGridViewUsuarios.CurrentCell.RowIndex;
                textBoxCodigo.Text = dataGridViewUsuarios.Rows[fila].Cells[0].Value.ToString();
                textBoxNombres.Text = dataGridViewUsuarios.Rows[fila].Cells[1].Value.ToString();
                textBoxApellidos.Text = dataGridViewUsuarios.Rows[fila].Cells[2].Value.ToString();
                textBoxDireccion.Text = dataGridViewUsuarios.Rows[fila].Cells[7].Value.ToString();
                textBoxTelefono.Text = dataGridViewUsuarios.Rows[fila].Cells[3].Value.ToString();
                textBoxCorreo.Text = dataGridViewUsuarios.Rows[fila].Cells[4].Value.ToString();
                comboBoxTipo.Text = dataGridViewUsuarios.Rows[fila].Cells[6].Value.ToString();
                comboBoxEstado.Text = dataGridViewUsuarios.Rows[fila].Cells[5].Value.ToString();
                //aEntidad.Eliminar(aux);
            }
            catch (Exception)
            {
                //Mostrar mensaje de error
            }
        }

        private void CambioCodigo(object sender, EventArgs e)
        {
            InicializarAtributosNoClave();
        }

        private void AbandonarTextBoxCodigo(object sender, EventArgs e)
        {
            ProcesarClave();
        }


        private void CargarDatos(object sender, EventArgs e)
        {
            textBoxCodigo.Text = codigoUsuario;
            dataGridViewUsuarios.DataSource = aUsuario.ListaUsuarios();
            ProcesarClave();
        }

        public override string[] AsignarValoresAtributos()
        {
            return new string[] { textBoxCodigo.Text,
                textBoxNombres.Text, textBoxApellidos.Text,
                textBoxDireccion.Text, textBoxTelefono.Text,
                comboBoxTipo.Text, comboBoxEstado.Text};
        }
        public override void MostrarDatos()
        {
            textBoxCodigo.Text = aEntidad.ValorAtributo("IdUsuario");
            textBoxNombres.Text = aEntidad.ValorAtributo("Nombres");
            textBoxApellidos.Text = aEntidad.ValorAtributo("Apellidos");
            textBoxDireccion.Text = aEntidad.ValorAtributo("Direccion");
            textBoxTelefono.Text = aEntidad.ValorAtributo("Telefono");
            textBoxCorreo.Text = aEntidad.ValorAtributo("Correo");
            comboBoxTipo.Text = aEntidad.ValorAtributo("Tipo");
            comboBoxEstado.Text = aEntidad.ValorAtributo("Estado");
        }
        public override void InicializarAtributoClave()
        {
            textBoxCodigo.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            //textBoxCodigo.Text = "";
            textBoxNombres.Text = "";
            textBoxApellidos.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
            textBoxCorreo.Text = "";
            comboBoxEstado.Text = "";
            comboBoxTipo.Text = "";
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
                comboBoxTipo.Text.Trim() != "" )
                return true;
            else
                return false;
        }
        // ========================= EVENTOS =======================

        private void FormUsuario_Load_1(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Averigüar la fila seleccionada
                int fila = dataGridViewUsuarios.CurrentCell.RowIndex;

                //eliminar la fila 
                //string[] aux = { dataGridViewUsuarios.Rows[fila].Cells[0].Value.ToString() };
                string[] atributos = new string[] { 
                    dataGridViewUsuarios.Rows[fila].Cells[0].Value.ToString(),
                dataGridViewUsuarios.Rows[fila].Cells[1].Value.ToString(),
                dataGridViewUsuarios.Rows[fila].Cells[2].Value.ToString(),
                dataGridViewUsuarios.Rows[fila].Cells[7].Value.ToString(),
                dataGridViewUsuarios.Rows[fila].Cells[3].Value.ToString(),
                dataGridViewUsuarios.Rows[fila].Cells[4].Value.ToString(),
                dataGridViewUsuarios.Rows[fila].Cells[6].Value.ToString(),
                "RETIRADO"
                };
                aUsuario.ActualizarNoContraseña(atributos);
                //aEntidad.Eliminar(aux);
                dataGridViewUsuarios.DataSource = aUsuario.ListaUsuarios();

                InicializarAtributos();

                MessageBox.Show("Se ha cambiado el estado del usuario " + dataGridViewUsuarios.Rows[fila].Cells[1].Value.ToString());
            }
            catch (Exception)
            {
                //Mostrar mensaje de error
                MessageBox.Show("Usuario ligado a operaciones", "ATENCION");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            InicializarAtributos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Uso para tablas con claves compuestas
            /*int n = 1;
            if (aEntidad.ToString().Equals("BibClases.CUs"))
            {
                n = 2;
            }
            */
            Grabar(1);
        }

        /// <summary>
        /// Guarda un registro en BD
        /// </summary>
        /// <param name="n"></param>
        public virtual void Grabar(int n)
        {
            try
            {
                if (EsRegistroValido())
                {
                    //Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //Verificar si existe clave primaria
                    if (aEntidad.ExisteClavePrimaria(n, Atributos))
                    {
                        aEntidad.Actualizar(Atributos);
                    }
                    else
                    {
                        aEntidad.Insertar(Atributos);
                    }
                    MessageBox.Show("Operacion realizada exitosamente", "Confirmacion");
                    InicializarAtributos();
                    ListarRegistros();
                }
                else
                    MessageBox.Show("Debe completar el llenado del formulario", "ALERTA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al realizar la operacion");
            }
        }

        private void buttonNuevoUsuario_Click(object sender, EventArgs e)
        {

            InicializarAtributosNoClave();
            int cant = aEntidad.NumeroRegistros();
            string cantCeros = "";
            if (cant < 9)
                cantCeros = "00";
            else if (cant < 99)
                cantCeros = "0";

            textBoxCodigo.Text = "US"+cantCeros+(cant+1);

            textBoxNombres.Focus();

        }
    }
}
