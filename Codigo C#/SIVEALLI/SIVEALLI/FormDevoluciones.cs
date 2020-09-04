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
        CDevolucion Devolucion = new CDevolucion();
        CDevolucionDetalle DevolucionDetalle=new CDevolucionDetalle();
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
            //--Se carga el historial de ventas
            CargarVentas();
            CargarHistorialDevoluciones();
        }
        //--Cargar el el id del pedido automaticamente
        public void CargarIdDevolucion()
        {
            string IdMax;
            if (Devolucion.IdMaximo().Rows.Count != 0)
                IdMax = Devolucion.IdMaximo().Rows[0][0].ToString();
            else
                IdMax = "DE000000";
            int ValorId = int.Parse(IdMax.Substring(2));
            IdMax = "DE";
            for (int k = 0; k < 6 - ValorId.ToString().Length; k++)
                IdMax += "0";
            TbId.Text = IdMax + (ValorId + 1).ToString();
        }
        public void CargarHistorialDevoluciones()
        {
            DgvDevoluciones.DataSource = Devolucion.MostrarTodo();
        }
        public void CargarVentas()
        {
            DgvVentas.DataSource = Devolucion.MostrarVentas();
        }
        /// <summary>
        /// evento del check box que indica si se trata o no de una nueva devolucion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Modulo que hace que se cargen los datos de la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbIdVenta_Leave(object sender, EventArgs e)
        {
            CargarDetallesVenta();
        }
        /// <summary>
        /// Evento que hace que se muestre los datos de la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            TbIdVenta.Text = DgvVentas.Rows[fila].Cells[0].Value.ToString();
            DgvDevolucionDetalle.Rows.Clear();
            CargarDetallesVenta();
        }/// <summary>
        /// Evento que hace que se carguen los datos de las anteriores devoluiconea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvDevoluciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Modulo que hace que se carguen los detalles de la venta
        /// </summary>
        public void CargarDetallesVenta()
        {
            DataTable Tabla= Devolucion.MostrarDatosVentas(TbIdVenta.Text);
            for(int k=0;k<Tabla.Rows.Count;k++)
                DgvDevolucionDetalle.Rows.Add(false,Tabla.Rows[k][0].ToString(),Tabla.Rows[k][1].ToString(), Tabla.Rows[k][2].ToString(), Tabla.Rows[k][3].ToString(), Tabla.Rows[k][4].ToString());
            DeterminarImporteTotal();        
        }
        //--Calcular el importe total a devolver
        public void DeterminarImporteTotal()
        {
            double Total = 0;
            for (int k = 0; k < DgvDevolucionDetalle.Rows.Count; k++)
            {
                Total += double.Parse(DgvDevolucionDetalle.Rows[k].Cells[5].Value.ToString());
            }
            //--Cololcar el total 
            LTotal.Text = LTotal.Text.Split('/')[0] + "/ " + Total.ToString();
        }
        private void BtnDevoluciones_Click(object sender, EventArgs e)
        {
            GbHistorialDevo.Visible = true;
            GbVentas.Visible = false;
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            CargarHistorialDevoluciones();
            GbVentas.Visible = true;
            GbHistorialDevo.Visible = false;
        }

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
