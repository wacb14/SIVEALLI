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
    public partial class FormPadre : Form
    {
        protected CEntidad aEntidad;

        public FormPadre()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo VIRTUAL que permite indicar que valores del formulario deben 
        /// ir a la tabla relacionada.Los valores deben ser definidos en el 
        /// mismo orden en que estan considerados en la base de datos.
        /// Es obligarorio redefinir este metodo en todos los herederos de FrmPadre
        /// </summary>
        /// <returns>Arreglo de strings con los valores que deben ir al a tabla</returns>
        public virtual string[] AsignarValoresAtributos()
        {
            return null;
        }

        /// <summary>
        /// Metodo void que inicia el parametro pasado
        /// </summary>
        /// <param name="pEntidad"></param>
        public void IniciarEntidad(CEntidad pEntidad)
        {
            //Indicar con que entidad trabajará el formulario
            aEntidad = pEntidad;
        }

        public virtual void InicializarAtributoClave()
        {
            //Dar valores a los controles realacionados al atributo clave
        }

        public virtual void InicializarAtributosNoClave()
        {
            //Dar valores a los controles relacionados a los atributos no clave
        }

        public virtual void InicializarAtributos()
        {
            //Dar valor inicial a todos los atributos del formulario
            InicializarAtributoClave();
            InicializarAtributosNoClave();
        }

        public virtual void MostrarDatos()
        {
            //Visualiza la informacion de un registro en el formulario
        }

        public virtual void ListarRegistros()
        {
            //Visualiza la informacion de un registro en el formulario
        }

        public virtual bool EsRegistroValido()
        {
            //Verifica que los datos esten completos en el formulario
            return true;
        }

        public virtual void ProcesarClave()
        {
            //Recuperar atributos, el primer atributo es la clave
            string[] Atributos = AsignarValoresAtributos();
            //Verificar si existe clave primaria
            if (aEntidad.ExisteClavePrimaria(Atributos))
            {
                //MessageBox.Show("hola 1");
                MostrarDatos();
                aEntidad.Nuevo = false;
            }
            else
            {
                //Registro nuevo, incializar atributos no clave
                InicializarAtributosNoClave();
            }
        }

        public virtual void Grabar()
        {
            try
            {
                if (EsRegistroValido())
                {
                    //Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //Verificar si existe clave primaria
                    if (aEntidad.ExisteClavePrimaria(Atributos))
                        aEntidad.Actualizar(Atributos);
                    else
                        aEntidad.Insertar(Atributos);
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

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            InicializarAtributos();
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Grabar();
        }
    }
}