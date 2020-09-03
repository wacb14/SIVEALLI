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
    public partial class FormDevoluciones : Form
    {
        /*ATRIBUTOS*/
        CDevolucion Devolucion;
        CDevolucionDetalle DevolucionDetalle;
        //--datos de entrada
        string aFecha;
        string aIdUsuario;
        public FormDevoluciones(string Fecha,string idUsuario)
        {
            InitializeComponent();
            aFecha = Fecha;
            aIdUsuario = idUsuario;
            //--Se carga el id del proximo pedido
            CbNuevoDev.Checked = true;
        }
        //--Cargar el el id del pedido automaticamente
        public void CargarIdDevolucion()
        {
            string IdMax = Devolucion.IdMaximo().Rows[0][0].ToString();
            int ValorId = int.Parse(IdMax.Substring(2));
            IdMax = "DE";
            for (int k = 0; k < 6 - ValorId.ToString().Length; k++)
                IdMax += "0";
            TbId.Text = IdMax + (ValorId + 1).ToString();
        }
        public void CargarHistorialPedidos()
        {
            DgvDevoluciones.DataSource = Devolucion.MostrarTodo();
        }

        private void CbNuevoDev_CheckedChanged(object sender, EventArgs e)
        {
            if (CbNuevoDev.Checked)
            {
                CargarIdDevolucion();
                DgvDevolucionDetalle.Rows.Clear();
                TbRazon.Text = "";
                TbIdVenta.Text = "";
                CbNuevoDev.Enabled = false;
            }
        }
    }
}
