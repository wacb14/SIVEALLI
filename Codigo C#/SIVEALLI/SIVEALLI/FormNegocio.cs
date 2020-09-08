﻿using BibClases;
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
    public partial class FormNegocio : FormPadre
    {
        CNegocio aNegocio = new CNegocio();
        public FormNegocio()
        {
            InitializeComponent();
            IniciarEntidad(new CNegocio());

            EventosYValidaciones();
        }

        private void EventosYValidaciones()
        {
            this.Load += new EventHandler(CargarDatos);
            this.btnGuardar.Click += new EventHandler(GuardarRegistro);
        }

        public override void Grabar()
        {
            try
            {
                if (EsRegistroValido())
                {
                    //Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributosSinClavePrimaria();
                    //Verificar si existe clave primaria
                        aEntidad.Insertar(Atributos);
                    //MessageBox.Show("Operacion realizada exitosamente", "Confirmacion");
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
            Grabar();
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        public override string[] AsignarValoresAtributos()
        {

            return new string[] {"1", tbNombre.Text,
                tbPropietario.Text, tbRUC.Text,
                tbTelefono.Text, tbCorreo.Text,
                tbDireccion.Text, tbIGV.Text,
                tbMontoSuperarDescuento.Text, tbPorcentajeDescuento.Text,
            dtpFecha.Value.Date.ToString()};
        }

        public string[] AsignarValoresAtributosSinClavePrimaria()
        {

            return new string[] {tbNombre.Text,
                tbPropietario.Text, tbRUC.Text,
                tbTelefono.Text, tbCorreo.Text,
                tbDireccion.Text, tbIGV.Text,
                tbMontoSuperarDescuento.Text, tbPorcentajeDescuento.Text,
            dtpFecha.Value.Date.ToString()};
        }

        public override void MostrarDatos()
        {
            tbNombre.Text = aEntidad.ValorAtributo("Nombre");
            tbPropietario.Text = aEntidad.ValorAtributo("Duegno");
            tbRUC.Text = aEntidad.ValorAtributo("RUC");
            tbTelefono.Text = aEntidad.ValorAtributo("Telefono");
            tbCorreo.Text = aEntidad.ValorAtributo("Correo");
            tbDireccion.Text = aEntidad.ValorAtributo("Direccion");
            tbIGV.Text = aEntidad.ValorAtributo("IGV");
            tbMontoSuperarDescuento.Text = aEntidad.ValorAtributo("MontoSuperarDescuento");
            tbPorcentajeDescuento.Text= aEntidad.ValorAtributo("PorcentajeDescuento");
        }
    }
}
