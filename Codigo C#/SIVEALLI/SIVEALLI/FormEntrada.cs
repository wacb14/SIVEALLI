﻿using BibClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIVEALLI
{
    public partial class FormEntrada : FormPadre
    {
        CProveedor proveedor = new CProveedor();
        CProducto producto = new CProducto();
        CEntrada entrada = new CEntrada();
        CEntradaDetalle entDet = new CEntradaDetalle();

        string codigoUsuario;

        public FormEntrada(string usuario)
        {
            InitializeComponent();
            IniciarEntidad(new CEntrada());
            EventosYValidaciones();

            this.codigoUsuario = usuario;
        }

        private void EventosYValidaciones()
        {
            this.Load += new EventHandler(LLenarDatosControles);
            this.buttonNuevaEntrada.Click += new EventHandler(GenerarNuevoCodigoEntrada);
            this.buttonAniadir.Click += new EventHandler(AgregarProductoDetalle);
            this.buttonEditar.Click += new EventHandler(HabilitarEdicionDataGrid);
            this.buttonEliminarDetalle.Click += new EventHandler(EliminarEntradaDetalle);
            this.buttonListo.Click += new EventHandler(GuardarEntrada);
            this.cbCodigoEntrada.SelectionChangeCommitted += new EventHandler(CargarDatosEntrada);
            this.buttonLimpiar.Click += new EventHandler(LimpiarForm);

            this.comboBoxCodigoProducto.DropDown += new EventHandler(CargarDatosProductos);
            this.comboBoxCodigoProveedor.DropDown += new EventHandler(CargarDatosProveedores);
            this.cbCodigoEntrada.DropDown += new EventHandler(CargarCodigosEntrada);
        }

        private void CargarCodigosEntrada(object sender, EventArgs e)
        {
            LlenarCodigoEntradas();
        }

        private void CargarDatosProveedores(object sender, EventArgs e)
        {
            LlenarDatosProveedores();
        }

        private void CargarDatosProductos(object sender, EventArgs e)
        {
            LlenarCodigoProductos();
        }

        private void LimpiarForm(object sender, EventArgs e)
        {
            LimpiarDatosFormulario();
        }

        private void LimpiarDatosFormulario()
        {
            dtpFecha.Value = DateTime.Now;
            numericUpDownCantidad.Value = 1;
            dataGridViewDetalleEntrada.DataSource = null;
            dataGridViewDetalleEntrada.Rows.Clear();
            textBoxUsuario.Text = codigoUsuario;
            comboBoxCodigoProducto.SelectedIndex = -1;
            comboBoxCodigoProveedor.SelectedIndex = -1;
            cbCodigoEntrada.Text = "";
        }

        private void CargarDatosEntrada(object sender, EventArgs e)
        {
            string codEntrada = cbCodigoEntrada.SelectedValue.ToString();

            ProcesarClave();

            CargarDatosEntradaDetalle();
        }

        private void CargarDatosEntradaDetalle()
        {
            dataGridViewDetalleEntrada.DataSource = null;
            dataGridViewDetalleEntrada.Rows.Clear();
            
            DataTable detallesentrada = entDet.ListaGeneralCod(cbCodigoEntrada.SelectedValue.ToString());
            for (int i = 0; i < detallesentrada.Rows.Count; i++) 
            {
                DataTable dt = producto.DatosProductoEntrada(detallesentrada.Rows[i][1].ToString());
                string[] datos = new string[dt.Columns.Count + 1];

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    datos[j] = dt.Rows[0][j].ToString();
                }
                datos[dt.Columns.Count] = detallesentrada.Rows[i][2].ToString() + "";

                dataGridViewDetalleEntrada.Rows.Add(datos);
            }
        }

        private void GuardarEntrada(object sender, EventArgs e)
        {
            //Graba los datos generales de la entrada
            Grabar();

            //Guarda los datos de la tabla (dataGridView)
            GuardarEntradaDetalle();
        }

        private void GuardarEntradaDetalle()
        {
            string codEntrada = cbCodigoEntrada.Text;
            string codProducto;
            string cantidad;

            //eliminamos las antiguas entradas
            entDet.EliminarRegistros(codEntrada);

            for (int i=0; i < dataGridViewDetalleEntrada.Rows.Count; i++)
            {
                codProducto = dataGridViewDetalleEntrada.Rows[i].Cells[0].Value.ToString();
                cantidad = dataGridViewDetalleEntrada.Rows[i].Cells[5].Value.ToString();
                entDet.Insertar(new string[] { codEntrada, codProducto, cantidad });
            }
        }

        public override bool EsRegistroValido()
        {
            if (comboBoxCodigoProveedor.Text.Trim() != "" &&
                cbCodigoEntrada.Text.Trim() != "" &&
                dataGridViewDetalleEntrada.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public override string[] AsignarValoresAtributos()
        {
            
            string proveedor = "";
            if (comboBoxCodigoProveedor.SelectedValue == null)
                proveedor = "";
            else
                proveedor = comboBoxCodigoProveedor.SelectedValue.ToString();

            //validamos texto combo box entrada con el valor elegido
            //esto debido a que las operaciones de cargar entrada y nueva entrada
            //toman diferentes valores
            string codigoEntrada = "";
            if (cbCodigoEntrada.Text.Equals(""))
            {
                codigoEntrada = cbCodigoEntrada.SelectedValue.ToString();
            }
            else
                codigoEntrada = cbCodigoEntrada.Text;
            
            //MessageBox.Show(cbCodigoEntrada.SelectedValue.ToString());
            return new string[] { codigoEntrada,
                proveedor, codigoUsuario, 
                dtpFecha.Value.Date.ToString()};
        }

        public override void MostrarDatos()
        {

            //MessageBox.Show(aEntidad.ValorAtributo("IdProveedor"));
            comboBoxCodigoProveedor.SelectedValue = aEntidad.ValorAtributo("IdProveedor");
            textBoxUsuario.Text = aEntidad.ValorAtributo("IdUsuario");
            dtpFecha.Value = Convert.ToDateTime(aEntidad.ValorAtributo("Fecha"));
        }

        private void EliminarEntradaDetalle(object sender, EventArgs e)
        {
            try
            {
                //Averigüar la fila seleccionada
                int fila = dataGridViewDetalleEntrada.CurrentCell.RowIndex;

                //eliminar la fila 
                dataGridViewDetalleEntrada.Rows.RemoveAt(fila);
            }
            catch (Exception)
            {
                //Mostrar mensaje de error
                MessageBox.Show("Usuario ligado a operaciones o no seleccionó ninguna fila", "ATENCION");
            }
        }

        /// <summary>
        /// Habilita la modificación de los valores en la columna cantidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HabilitarEdicionDataGrid(object sender, EventArgs e)
        {
            dataGridViewDetalleEntrada.ReadOnly = false;
            dataGridViewDetalleEntrada.Columns[0].ReadOnly = true;
            dataGridViewDetalleEntrada.Columns[1].ReadOnly = true;
            dataGridViewDetalleEntrada.Columns[2].ReadOnly = true;
            dataGridViewDetalleEntrada.Columns[3].ReadOnly = true;
            dataGridViewDetalleEntrada.Columns[4].ReadOnly = true;
        }

        private void AgregarProductoDetalle(object sender, EventArgs e)
        {
            string codigoProducto = comboBoxCodigoProducto.Text;
            int cantidad = (int) numericUpDownCantidad.Value;

            //Validamos que se haya ingresado un codigo
            if (codigoProducto.Equals("") || cbCodigoEntrada.Text.Equals("") || comboBoxCodigoProveedor.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los datos de proveedor, nueva entrada y producto");
                return;
            }

            //Validamos que el codigo no se haya ingresado antes
            int numeroFilasDetalle = dataGridViewDetalleEntrada.Rows.Count;
            int i = 0;
            bool encontrado = false;
            while(i < numeroFilasDetalle && !encontrado)
            {
                if (codigoProducto.Equals(dataGridViewDetalleEntrada.Rows[i].Cells[0].Value.ToString()))
                    encontrado = true;
                i++;
            }

            if (encontrado)
            {
                MessageBox.Show("El producto ya ha sido agregado a la lista de entrada");
                return;
            }


            DataTable dt = producto.DatosProductoEntrada(codigoProducto);

            string[] datos = new string[dt.Columns.Count + 1];

            for (i = 0; i < dt.Columns.Count; i++)
            {
                datos[i] = dt.Rows[0][i].ToString();
            }

            datos[dt.Columns.Count] = cantidad+ "";

            dataGridViewDetalleEntrada.Rows.Add(datos);

            LimpiarFormularioNuevaEntradaDetalle();
        }

        private void LimpiarFormularioNuevaEntradaDetalle()
        {
            comboBoxCodigoProducto.SelectedIndex = -1;
            numericUpDownCantidad.Value = 1;

            comboBoxCodigoProducto.Focus();
        }

        private void GenerarNuevoCodigoEntrada(object sender, EventArgs e)
        {
            LimpiarDatosFormulario();

            int cant = aEntidad.NumeroRegistros();
            string cantCeros = "";
            if (cant < 9)
                cantCeros = "00000";
            else if (cant < 99)
                cantCeros = "0000";
            else if (cant < 999)
                cantCeros = "000";
            else if (cant < 9999)
                cantCeros = "00";
            else if (cant < 99999)
                cantCeros = "0";

            cbCodigoEntrada.Text = "EN" + cantCeros + (cant + 1);

            comboBoxCodigoProveedor.Focus();
        }

        private void LLenarDatosControles(object sender, EventArgs e)
        {
            LlenarDatosProveedores();
            LlenarCodigoProductos();
            LlenarCodigoEntradas();

            textBoxUsuario.Text = codigoUsuario;
        }

        private void LlenarCodigoEntradas()
        {
            cbCodigoEntrada.DataSource = entrada.ListadoParaCombos();
            cbCodigoEntrada.DisplayMember = "IdEntrada";
            cbCodigoEntrada.ValueMember = "IdEntrada";
            cbCodigoEntrada.SelectedIndex = -1;
        }

        private void LlenarCodigoProductos()
        {
            comboBoxCodigoProducto.DataSource = producto.ListadoCodigos();
            comboBoxCodigoProducto.DisplayMember = "IdProducto";
            comboBoxCodigoProducto.ValueMember = "IdProducto";
            comboBoxCodigoProducto.SelectedIndex = -1;
        }

        private void LlenarDatosProveedores()
        {
            comboBoxCodigoProveedor.DataSource = proveedor.ListadoParaCombos();
            comboBoxCodigoProveedor.DisplayMember = "Nombre";
            comboBoxCodigoProveedor.ValueMember = "IdProveedor";
            comboBoxCodigoProveedor.SelectedIndex = -1;
        }

    }
}
