﻿using System;
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
        public FormUsuarios()
        {
            InitializeComponent();
            IniciarEntidad(new CUsuario());

            EventosYValidaciones();
        }

        private void EventosYValidaciones()
        {
            this.Load += new EventHandler(CargarDatos);
            textBoxCodigo.Leave += new EventHandler(AbandonarTextBoxCodigo);
        }

        private void AbandonarTextBoxCodigo(object sender, EventArgs e)
        {
            //Recuperar atributos, el primer atributo es la clave
            string[] Atributos = AsignarValoresAtributos();
            //Verificar si existe clave primaria
            if (aEntidad.ExisteClavePrimaria(1, Atributos))
            {
                MostrarDatos();
                aEntidad.Nuevo = false;
            }
            else
            {
                //Registro nuevo, incializar atributos no clave
                InicializarAtributosNoClave();
            }
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            dataGridViewUsuarios.DataSource = aEntidad.ListaGeneral();
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
            //textBoxCodigo.Text = "";
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
                dataGridViewUsuarios.Rows[fila].Cells[3].Value.ToString(),
                dataGridViewUsuarios.Rows[fila].Cells[4].Value.ToString(),
                dataGridViewUsuarios.Rows[fila].Cells[5].Value.ToString(),
                dataGridViewUsuarios.Rows[fila].Cells[6].Value.ToString(),
                dataGridViewUsuarios.Rows[fila].Cells[7].Value.ToString(),
                "RETIRADO"};
                aEntidad.Actualizar(atributos);
                //aEntidad.Eliminar(aux);
                dataGridViewUsuarios.DataSource = aEntidad.ListaGeneral();

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
            int cant = aEntidad.NumeroRegistros();
            string cantCeros = "";
            if (cant < 10)
                cantCeros = "00";
            else if (cant < 100)
                cantCeros = "0";

            textBoxCodigo.Text = "US"+cantCeros+(cant+1);

            textBoxNombres.Focus();
        }
    }
}
