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
            this.dgvUsuarios.CellClick += new DataGridViewCellEventHandler(MostrarDatosEnFormulario);
            this.btnRestaurarContra.Click += new EventHandler(RestaurarContraseña);
            this.btnCambioContra.Click += new EventHandler(CambiarContraseña);
            this.BtnLimpiar.Click += new EventHandler(LimpiarInterfaz);
            //this.btnDesactivar.Click += new EventHandler(DesactivarUsuario);
            this.BtnGuardar.Click += new EventHandler(GuardarRegistro);
            this.btnNuevoUsuario.Click += new EventHandler(GenerarCodigoNuevoUsuario);
            this.BtnRestaurarLista.Click += new EventHandler(RestaurarListaUsuarios);
            this.BtnBuscar.Click += new EventHandler(BuscarPorCampo);

            //Validaciones
            textBoxNombres.KeyPress += new KeyPressEventHandler(Procesos.ValidarTextBoxSoloLetras);
            textBoxApellidos.KeyPress += new KeyPressEventHandler(Procesos.ValidarTextBoxSoloLetras);
            textBoxTelefono.KeyPress += new KeyPressEventHandler(Procesos.ValidarTextBoxSoloNumeros);
        }

        private void BuscarPorCampo(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Rows.Clear();

            DataTable Lista = aUsuario.ListaUsuarios(); // Validamos que solo se muestren productos activos
            string Valor = string.Empty;
            switch (CboBuscarPor.Text)
            {
                case "ID Usuario":
                    Valor = "IdUsuario";
                    break;
                case "Nombre":
                    Valor = "Nombres";
                    break;
                case "Apellido":
                    Valor = "Apellidos";
                    break;
                case "Dirección":
                    Valor = "Direccion";
                    break;
                case "Teléfono":
                    Valor = "Telefono";
                    break;
                case "Correo":
                    Valor = "Correo";
                    break;
                case "Estado":
                    Valor = "Estado";
                    break;
                case "Tipo":
                    Valor = "Tipo";
                    break;
            }

            DataTable tablaMostrar = Lista.Clone();
            for (int i = 0; i < Lista.Rows.Count; i++)
            {
                string ValorProd = Lista.Rows[i][Valor].ToString();
                if (Procesos.BuscarPalabraEnCadena(TxtValorBusqueda.Text, ValorProd))
                {
                    tablaMostrar.ImportRow(Lista.Rows[i]); //.Rows.Add(Lista.Rows[i]);
                }
            }

            dgvUsuarios.DataSource = tablaMostrar;
            LblTotalUsuarios.Text = dgvUsuarios.Rows.Count.ToString();
        }

        private void RestaurarListaUsuarios(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = aUsuario.ListaUsuarios();
            LblTotalUsuarios.Text = dgvUsuarios.Rows.Count.ToString();
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

            DialogResult result = MessageBox.Show("Está operación restaurará la contraseña del usuario seleccionado. ¿Desea continuar?", "", MessageBoxButtons.YesNo);
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
                int fila = dgvUsuarios.CurrentCell.RowIndex;
                textBoxCodigo.Text = dgvUsuarios.Rows[fila].Cells[0].Value.ToString();
                textBoxNombres.Text = dgvUsuarios.Rows[fila].Cells[1].Value.ToString();
                textBoxApellidos.Text = dgvUsuarios.Rows[fila].Cells[2].Value.ToString();
                textBoxDireccion.Text = dgvUsuarios.Rows[fila].Cells[3].Value.ToString();
                textBoxTelefono.Text = dgvUsuarios.Rows[fila].Cells[4].Value.ToString();
                textBoxCorreo.Text = dgvUsuarios.Rows[fila].Cells[5].Value.ToString();
                comboBoxTipo.Text = dgvUsuarios.Rows[fila].Cells[7].Value.ToString();
                comboBoxEstado.Text = dgvUsuarios.Rows[fila].Cells[6].Value.ToString();
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
            dgvUsuarios.DataSource = aUsuario.ListaUsuarios();
            LblTotalUsuarios.Text = dgvUsuarios.Rows.Count.ToString();
            ProcesarClave();
        }

        public override string[] AsignarValoresAtributos()
        {
            string contraseña = "";
            //recuperamos contraseña
            if (aUsuario.ExisteClavePrimaria(textBoxCodigo.Text))
            {
                contraseña = aUsuario.ObtenerContrasegna(textBoxCodigo.Text);
            }
            else
            {
                contraseña = textBoxCodigo.Text;
            }

            return new string[] { textBoxCodigo.Text,
                textBoxNombres.Text, textBoxApellidos.Text,
                textBoxDireccion.Text, textBoxTelefono.Text,
                textBoxCorreo.Text, contraseña,
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
            dgvUsuarios.DataSource = aEntidad.ListaGeneral();
        }
        public override bool EsRegistroValido()
        {
            if (textBoxCodigo.Text.Trim() != "" &&
                textBoxApellidos.Text.Trim() != "" &&
                textBoxNombres.Text.Trim() != "" &&
                comboBoxTipo.Text.Trim() != "")
                return true;
            else
                return false;
        }
        // ========================= EVENTOS =======================

        private void FormUsuario_Load_1(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        /*Funcion boton desactivar usuario
        private void DesactivarUsuario(object sender, EventArgs e)
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

        */
        private void LimpiarInterfaz(object sender, EventArgs e)
        {
            InicializarAtributos();
        }

        private void GuardarRegistro(object sender, EventArgs e)
        {
            Grabar();
            LblTotalUsuarios.Text = dgvUsuarios.Rows.Count.ToString();
        }

        /// <summary>
        /// Guarda un registro en BD
        /// </summary>
        /// <param name="n"></param>
        public override void Grabar()
        {
            try
            {
                if (EsRegistroValido())
                {
                    //Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //Verificar si existe clave primaria
                    if (aEntidad.ExisteClavePrimaria(Atributos))
                    {
                        aEntidad.Actualizar(Atributos);
                    }
                    else
                    {
                        aEntidad.Insertar(Atributos);
                    }
                    MessageBox.Show("Operacion realizada exitosamente", "Confirmacion");
                    InicializarAtributos();
                    dgvUsuarios.DataSource = aUsuario.ListaUsuarios();
                }
                else
                    MessageBox.Show("Debe completar el llenado del formulario", "ALERTA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al realizar la operacion");
            }
        }
        

        private void GenerarCodigoNuevoUsuario(object sender, EventArgs e)
        {

            InicializarAtributosNoClave();
            int cant = aEntidad.NumeroRegistros();
            string cantCeros = "";
            if (cant < 9)
                cantCeros = "00";
            else if (cant < 99)
                cantCeros = "0";

            textBoxCodigo.Text = "US" + cantCeros + (cant + 1);

            textBoxNombres.Focus();

        }
    }
}
