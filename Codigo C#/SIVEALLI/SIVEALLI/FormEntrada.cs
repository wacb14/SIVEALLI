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
    public partial class FormEntrada : Form
    {
        CProveedor proveedor = new CProveedor();

        public FormEntrada()
        {
            InitializeComponent();

            EventosYValidaciones();
        }

        private void EventosYValidaciones()
        {
            this.Load += new EventHandler(LLenarDatosControles);
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
