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
            //comboBoxCodigoProducto.DataSource = proveedor.ListadoParaCombos();
            //comboBoxCodigoProducto.DisplayMember = "Nombre";
            //comboBoxCodigoProducto.ValueMember = "IdProveedor";
            //comboBoxCodigoProducto.SelectedIndex = -1;

            MessageBox.Show("esperando clase productos");
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
