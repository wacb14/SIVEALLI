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
    public partial class FormVentas : Form
    {
        //--- Atributos ---
        CVenta Ventas = new CVenta();
        CCliente Cliente = new CCliente();
        CVentaDetalle VentasDetalle = new CVentaDetalle();
        public FormVentas()
        {
            InitializeComponent();
            TxtIdVenta.Text = GenerarIdVenta();
        }
        private string GenerarIdVenta()
        {
            string Id = "VE";
            string NumeroVentas = (Ventas.NumeroVentas() + 1).ToString();
            for (int i = 0; i < 6 - NumeroVentas.Length; i++)
                Id += "0";
            Id += NumeroVentas;
            return Id;
        }

        private void IngresoClienteObligatorio()
        {
            FormClientes Clientes = new FormClientes();
            Clientes.ShowDialog();
        }
        //------------------------ Eventos -------------------------

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }
        private void TxtIdCliente_Leave(object sender, EventArgs e)
        {
            if (!Cliente.ExisteClavePrimaria(new string[] { TxtIdCliente.Text }))
            {
                MessageBox.Show("El ID de cliente ingresado no existe, para continuar registre al cliente primero", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                IngresoClienteObligatorio();
            }
        }
        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            IngresoClienteObligatorio();
        }

        private void BtnVaciarDetalles_Click(object sender, EventArgs e)
        {
            DgvVentaDetalle.DataSource = null;
        }
    }
}
