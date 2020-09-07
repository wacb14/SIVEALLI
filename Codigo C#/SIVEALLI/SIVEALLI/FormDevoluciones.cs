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
        //--Datos Detalle
        bool AgregandoRegistros = false;
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
            DgvVentas.Columns[5].Visible = false;
            DgvVentas.Columns[6].Visible = false;
            DgvVentas.Columns[7].Visible = false;
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
            TbRazon.Text = "";
            DgvDevolucionDetalle.Rows.Clear();
            CargarDetallesVenta();
            //--Se cargan los datos del descuento
            DeterminarImporteTotal();
            LblImpuesto.Text = DgvVentas.Rows[fila].Cells[6].Value.ToString();
            if (Convert.ToBoolean(DgvVentas.Rows[fila].Cells[5].Value))
                LblDescuento.Text = DgvVentas.Rows[fila].Cells[7].Value.ToString();
            else
                LblDescuento.Text = "0";
            //--Calcular el importe total que se pago
            double st = double.Parse(LblSubTotal.Text);
            LblTotalPagar.Text = (st+ (st*int.Parse(LblImpuesto.Text)/100)-(st*(int.Parse(LblDescuento.Text))/100)).ToString();
        }/// <summary>
         /// Evento que hace que se carguen los datos de las anteriores devoluiconea
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void DgvDevoluciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            TbId.Text = DgvDevoluciones.Rows[fila].Cells[0].Value.ToString();
            TbIdVenta.Text= DgvDevoluciones.Rows[fila].Cells[2].Value.ToString();
            TbRazon.Text = DgvDevoluciones.Rows[fila].Cells[3].Value.ToString();
            //--Se cargan los datos del descuento
            LblSubTotal.Text= Devolucion.TraerSubTotalVenta(TbIdVenta.Text);
            int filaVenta = DetFila(TbIdVenta.Text);
            LblImpuesto.Text = DgvVentas.Rows[filaVenta].Cells[6].Value.ToString();
            if (Convert.ToBoolean(DgvVentas.Rows[filaVenta].Cells[5].Value))
                LblDescuento.Text = DgvVentas.Rows[filaVenta].Cells[7].Value.ToString();
            else
                LblDescuento.Text = "0";
            //--Calcular el importe total que se pago
            double st = double.Parse(LblSubTotal.Text);
            LblTotalPagar.Text = (st + (st * int.Parse(LblImpuesto.Text) / 100) - (st * (int.Parse(LblDescuento.Text)) / 100)).ToString();
            //--Cargar los datos en data grid view
            DataTable TablaDevolucionDetalle = Devolucion.TraerDatosDevolucionDetalle(TbId.Text);
            DgvDevolucionDetalle.Rows.Clear();
            LTotal.Text = LTotal.Text.Split('/')[0] + "/ " + "0";
            for (int k = 0; k < TablaDevolucionDetalle.Rows.Count; k++)
            {
                string codProd = TablaDevolucionDetalle.Rows[k][1].ToString();
                string nombre = DetNombre(codProd);
                string precio = TablaDevolucionDetalle.Rows[k][4].ToString();
                string cantidad = TablaDevolucionDetalle.Rows[k][2].ToString();
                string Estado = TablaDevolucionDetalle.Rows[k][3].ToString();
                DgvDevolucionDetalle.Rows.Add(true,codProd, nombre,"",precio, cantidad, (double.Parse(precio) * int.Parse(cantidad)).ToString());
                //--Calcular el importe devuelto
                CalcularSub(k);
            }

            CbNuevoDev.Checked = false;
            CbNuevoDev.Enabled = true;
        }
        public string DetNombre(string IdPro)
        {
            DataTable Tab= Devolucion.TraerDatosProducto(IdPro);
            return Tab.Rows[0][1].ToString();
        }
        public int DetFila(string Cod)
        {
            int fila = -1;
            for (int k = 0; k < DgvVentas.Rows.Count; k++)
            {
                if (DgvVentas.Rows[k].Cells[0].Value.ToString().Trim() == Cod)
                {
                    return k;
                }
            }
            return fila;
        }
        /// <summary>
        /// Modulo que hace que se carguen los detalles de la venta
        /// </summary>
        public void CargarDetallesVenta()
        {
            DataTable Tabla= Devolucion.MostrarDatosVentas(TbIdVenta.Text);
            for (int k = 0; k < Tabla.Rows.Count; k++)
                DgvDevolucionDetalle.Rows.Add(false, Tabla.Rows[k][0].ToString(), Tabla.Rows[k][1].ToString(), "", Tabla.Rows[k][2].ToString(), Tabla.Rows[k][3].ToString(), Tabla.Rows[k][4].ToString(),"0");
            
        }
        //--Calcular el importe total 
        public void DeterminarImporteTotal()
        {
            double Total = 0;
            for (int k = 0; k < DgvDevolucionDetalle.Rows.Count; k++)
            {
                Total += double.Parse(DgvDevolucionDetalle.Rows[k].Cells[6].Value.ToString());
            }
            //--Cololcar el total 
            LblSubTotal.Text = Total.ToString();
        }
        private void BtnDevoluciones_Click(object sender, EventArgs e)
        {
            CargarHistorialDevoluciones();
            GbHistorialDevo.Visible = true;
            GbVentas.Visible = false;
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            LTotal.Text = LTotal.Text.Split('/')[0] + "/ " + "0";
            CargarVentas();
            GbVentas.Visible = true;
            GbHistorialDevo.Visible = false;
        }

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Evento que hace que registrara los datos de decolucion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvDevolucionDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            if (col == 0)
            {
                //MessageBox.Show(DgvDevolucionDetalle.Rows[fila].Cells[0].Value.ToString());
                //--Si se activa el check box, se agrega el producto
                if (!Convert.ToBoolean(DgvDevolucionDetalle.Rows[fila].Cells[0].Value))
                {
                    //--Se cambian los datos de la cantidad y dantidad a devolver
                    int cantMax = int.Parse(DgvDevolucionDetalle.Rows[fila].Cells[5].Value.ToString());
                    string Cant = DgvDevolucionDetalle.Rows[fila].Cells[5].Value.ToString();
                    string SubT = DgvDevolucionDetalle.Rows[fila].Cells[6].Value.ToString();
                    DgvDevolucionDetalle.Rows[fila].Cells[7].Value = Cant + "-" + SubT;
                    FormDevolucionCantidad fdc = new FormDevolucionCantidad(DgvDevolucionDetalle, fila, cantMax);
                    fdc.StartPosition = FormStartPosition.CenterScreen;
                    fdc.Show();
                    DgvDevolucionDetalle.Rows[fila].Cells[5].ReadOnly = false;
                }
                else
                {
                    DgvDevolucionDetalle.Rows[fila].Cells[5].ReadOnly = true;
                    string VaAux= DgvDevolucionDetalle.Rows[fila].Cells[7].Value.ToString();
                    DgvDevolucionDetalle.Rows[fila].Cells[5].Value = VaAux.Split('-')[0];
                    DgvDevolucionDetalle.Rows[fila].Cells[6].Value = VaAux.Split('-')[1];
                }
                BtnCED.PerformClick();
            }
        }
        public void CalcularSub(int fila)
        {
            string PreciUni = DgvDevolucionDetalle.Rows[fila].Cells[4].Value.ToString();
            string Cant = DgvDevolucionDetalle.Rows[fila].Cells[5].Value.ToString();
            double SubTot = double.Parse(PreciUni) * double.Parse(Cant);
            DgvDevolucionDetalle.Rows[fila].Cells[6].Value = (SubTot).ToString();
            //--Calcular el importe total a devolver
            double Total = (SubTot+SubTot*int.Parse(LblImpuesto.Text)/100-SubTot*int.Parse(LblDescuento.Text)/100)+ double.Parse(LTotal.Text.Split('/')[1]);
            LTotal.Text = LTotal.Text.Split('/')[0] + "/ " + Total.ToString();
        }

        private void DgvDevolucionDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            if (col == 5 && fila>=0)
            {
                CalcularSub(fila);
            }
        }
    }
}
