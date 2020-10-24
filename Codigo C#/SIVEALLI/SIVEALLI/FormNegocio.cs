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
using System.IO;

namespace SIVEALLI
{
    public partial class FormNegocio : FormPadre
    {
        CNegocio aNegocio = new CNegocio();
        string aFechaActual;
        string RutaCarpetaImagenes = "..\\Libreria";
        public FormNegocio(string FechaActual)
        {
            InitializeComponent();
            aFechaActual = FechaActual;
            EventosYValidaciones();
            MostrarDatos();
        }

        private void EventosYValidaciones()
        {
            this.btnGuardar.Click += new EventHandler(GuardarRegistro);
            this.BtnCerrar.Click += new EventHandler(CerrarVentana);
            this.tbIGV.KeyPress += new KeyPressEventHandler(Procesos.ValidarFloat);
            this.tbMontoSuperarDescuento.KeyPress += new KeyPressEventHandler(Procesos.ValidarFloat);
            this.tbPorcentajeDescuento.KeyPress += new KeyPressEventHandler(Procesos.ValidarFloat);
            this.tbPropietario.KeyPress += new KeyPressEventHandler(Procesos.ValidarTextBoxSoloLetras);
            this.tbRUC.KeyPress += new KeyPressEventHandler(Procesos.ValidarTextBoxSoloNumeros);
            this.tbTelefono.KeyPress += new KeyPressEventHandler(Procesos.ValidarTextBoxSoloNumeros);
        }

        private void CerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Actualiza la imagen del logo en la carpeta de imagenes
        /// </summary>
        /// <param name="NombreImagen"></param>
        public void ActualizarNuevaImagen(string NombreImagen)
        {
            try
            {
                // Guardamos la nueva imagen
                string RutaOrigenArchivo = OfdLogo.FileName;
                string RutaNueva = RutaCarpetaImagenes + "\\" + NombreImagen;
                File.Copy(RutaOrigenArchivo, RutaNueva, true);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        /// <summary>
        /// Guarda una nueva imagen del logo en la carpeta de imagenes
        /// </summary>
        /// <param name="NombreImagen"></param>
        public void GuardarNuevaImagen(string NombreImagen)
        {
            string RutaOrigenArchivo = OfdLogo.FileName;
            string RutaNueva = RutaCarpetaImagenes + "\\" + NombreImagen;
            try
            {
                File.Copy(RutaOrigenArchivo, RutaNueva, false);
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message + " (Ya existe una imagen con el mismo nombre, modifique el nombre de su imagen por favor)");
            }
        }

        public override void Grabar()
        {
            try
            {
                if (EsRegistroValido())
                {
                    // Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    // Verificar si existe clave primaria
                    aNegocio.Actualizar(Atributos);
                    // Copiar los archivos de imagen
                    if(File.Exists(RutaCarpetaImagenes + "\\" + "logo" + Path.GetExtension(OfdLogo.SafeFileName)))
                    {
                        // Cuando se reemplaza
                        ActualizarNuevaImagen("logo" + Path.GetExtension(OfdLogo.SafeFileName));
                    }
                    else
                    {
                        // Cuando se ingresa una imagen por primera vez
                        GuardarNuevaImagen("logo" + Path.GetExtension(OfdLogo.SafeFileName));
                    }
                    MessageBox.Show("Operacion realizada exitosamente", "CONFIRMACION");
                }
                else
                    MessageBox.Show("Debe completar el llenado del formulario", "ALERTA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al realizar la operacion");
            }
        }

        private void GuardarRegistro(object sender, EventArgs e)
        {
            if (!tbNombre.Text.Trim().Equals("") && !tbIGV.Text.Trim().Equals("") && !tbMontoSuperarDescuento.Text.Trim().Equals("")
                && !tbPorcentajeDescuento.Text.Trim().Equals("") && !tbRUC.Text.Trim().Equals(""))
                Grabar();
            else
                MessageBox.Show("Ingrese todos los datos del negocio por favor");
        }

        public override string[] AsignarValoresAtributos()
        {
            return new string[] {"0", tbNombre.Text.Trim(),"logo" + Path.GetExtension(OfdLogo.SafeFileName),
                tbPropietario.Text.Trim(), tbRUC.Text.Trim(),
                tbTelefono.Text.Trim(), tbCorreo.Text.Trim(),
                tbDireccion.Text.Trim(), tbIGV.Text.Trim(),
                tbMontoSuperarDescuento.Text.Trim(), tbPorcentajeDescuento.Text.Trim(),
            aFechaActual };
        }

        public string[] AsignarValoresAtributosSinClavePrimaria()
        {
            return new string[] {tbNombre.Text.Trim(),"logo" + Path.GetExtension(OfdLogo.SafeFileName),
                tbPropietario.Text.Trim(), tbRUC.Text.Trim(),
                tbTelefono.Text.Trim(), tbCorreo.Text.Trim(),
                tbDireccion.Text.Trim(), tbIGV.Text.Trim(),
                tbMontoSuperarDescuento.Text.Trim(), tbPorcentajeDescuento.Text.Trim(),
            aFechaActual };
        }

        public override void MostrarDatos()
        {
            if (aNegocio.ExisteClavePrimaria(new string[] { "0" }))
            {
                tbNombre.Text = aNegocio.ValorAtributo("Nombre");
                tbPropietario.Text = aNegocio.ValorAtributo("Duegno");
                tbRUC.Text = aNegocio.ValorAtributo("RUC");
                tbTelefono.Text = aNegocio.ValorAtributo("Telefono");
                tbCorreo.Text = aNegocio.ValorAtributo("Correo");
                tbDireccion.Text = aNegocio.ValorAtributo("Direccion");
                tbIGV.Text = aNegocio.ValorAtributo("IGV");
                tbMontoSuperarDescuento.Text = aNegocio.ValorAtributo("MontoSuperarDescuento");
                tbPorcentajeDescuento.Text = aNegocio.ValorAtributo("PorcentajeDescuento");
                dtpFecha.Value = DateTime.Parse(aNegocio.ValorAtributo("Fecha"));
                PctBLogo.ImageLocation = RutaCarpetaImagenes + "\\" + aNegocio.ValorAtributo("Logo");
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                OfdLogo.InitialDirectory = RutaCarpetaImagenes;
                DialogResult Resultado = OfdLogo.ShowDialog();
                if (Resultado == DialogResult.OK)
                {
                    string RutaImagen = OfdLogo.FileName;
                    PctBLogo.Load(RutaImagen);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
