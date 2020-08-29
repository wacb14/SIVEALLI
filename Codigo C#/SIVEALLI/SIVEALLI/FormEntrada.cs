using BibClases;
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

        public FormEntrada()
        {
            InitializeComponent();
            IniciarEntidad(new CEntrada());
            EventosYValidaciones();
        }

        private void EventosYValidaciones()
        {
            this.Load += new EventHandler(LLenarDatosControles);
            this.buttonNuevaEntrada.Click += new EventHandler(GenerarNuevoCodigoEntrada);
            this.buttonAniadir.Click += new EventHandler(AgregarProductoDetalle);
            this.buttonEditar.Click += new EventHandler(HabilitarEdicionDataGrid);
        }

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
            if (codigoProducto.Equals("") || textBoxCodigoEntrada.Text.Equals("") || comboBoxCodigoProveedor.Text.Equals(""))
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
            int cant = aEntidad.NumeroRegistros();
            string cantCeros = "";
            if (cant < 10)
                cantCeros = "00000";
            else if (cant < 100)
                cantCeros = "0000";
            else if (cant < 1000)
                cantCeros = "000";
            else if (cant < 10000)
                cantCeros = "00";
            else if (cant < 100000)
                cantCeros = "0";

            textBoxCodigoEntrada.Text = "EN" + cantCeros + (cant + 1);

            comboBoxCodigoProveedor.Focus();
        }

        private void LLenarDatosControles(object sender, EventArgs e)
        {
            LlenarDatosProveedores();
            LlenarCodigoProductos();
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
