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
        public FormDevoluciones(string idUsuario, string Fecha)
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
        public bool BuscarVenta()
        {
            return false;
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
            int Pos=DetFilaDeVenta(TbIdVenta.Text);
            if (Pos == -1)
            {
                CbNuevoDev.Checked=true;
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
                double stD = st - (st * (int.Parse(LblDescuento.Text)) / 100);
                LblTotalPagar.Text = (stD + (st * int.Parse(LblImpuesto.Text) / 100)).ToString();
            }
            else
            {
                MessageBox.Show("La venta ya se encuentra en un registro de devolucion","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Information);
                CargarDatosDeDevolucion(Pos);
            }
        }/// <summary>
         /// Evento que hace que se carguen los datos de las anteriores devoluiconea
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void DgvDevoluciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            CargarDatosDeDevolucion(fila);
        }
        public void CargarDatosDeDevolucion(int fila)
        {
            TbId.Text = DgvDevoluciones.Rows[fila].Cells[0].Value.ToString();
            TbIdVenta.Text = DgvDevoluciones.Rows[fila].Cells[2].Value.ToString();
            TbRazon.Text = DgvDevoluciones.Rows[fila].Cells[3].Value.ToString();
            DtpFechaDevo.Text = DgvDevoluciones.Rows[fila].Cells[4].Value.ToString();
            //--Se cargan los datos del descuento
            LblSubTotal.Text = Devolucion.TraerSubTotalVenta(TbIdVenta.Text);
            int filaVenta = DetFila(TbIdVenta.Text);
            LblImpuesto.Text = DgvVentas.Rows[filaVenta].Cells[6].Value.ToString();
            if (Convert.ToBoolean(DgvVentas.Rows[filaVenta].Cells[5].Value))
                LblDescuento.Text = DgvVentas.Rows[filaVenta].Cells[7].Value.ToString();
            else
                LblDescuento.Text = "0";
            //--Calcular el importe total que se pago
            double st = double.Parse(LblSubTotal.Text);
            double stD = st - (st * (int.Parse(LblDescuento.Text)) / 100);
            LblTotalPagar.Text = (stD + (st * int.Parse(LblImpuesto.Text) / 100)).ToString();
            //--Cargar los datos en data grid view
            DataTable TablaDevolucionDetalle = Devolucion.TraerDatosDevolucionDetalle2(TbId.Text);
            DgvDevolucionDetalle.Rows.Clear();
            LTotal.Text = LTotal.Text.Split('/')[0] + "/ " + "0";
            for (int k = 0; k < TablaDevolucionDetalle.Rows.Count; k++)
            {
                string codProd = TablaDevolucionDetalle.Rows[k][1].ToString();
                string nombre = DetNombre(codProd);
                string precio = TablaDevolucionDetalle.Rows[k][4].ToString();
                string cantidad = TablaDevolucionDetalle.Rows[k][2].ToString();
                string Estado;
                if (TablaDevolucionDetalle.Rows[k][3] != null)
                    Estado = TablaDevolucionDetalle.Rows[k][3].ToString();
                //--Determinar si esta agregado o no
                bool Agregado = true; string cad = "1";
                if (TablaDevolucionDetalle.Rows[k][0].ToString().Trim() == "")
                {
                    Agregado = false; cad = "0";
                }
                DgvDevolucionDetalle.Rows.Add(Agregado, codProd, nombre, "", precio, cantidad, (double.Parse(precio) * int.Parse(cantidad)).ToString(), TablaDevolucionDetalle.Rows[k][5] + "-" + cad);

            }//--Calcular el importe devuelto
            CalcularSub();

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
        public int DetFilaDeVenta(string Cod)
        {
            int fila = -1;
            for (int k = 0; k < DgvDevoluciones.Rows.Count; k++)
            {
                if (DgvDevoluciones.Rows[k].Cells[2].Value.ToString().Trim() == Cod)
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
                DgvDevolucionDetalle.Rows.Add(false, Tabla.Rows[k][0].ToString(), Tabla.Rows[k][1].ToString(), "", Tabla.Rows[k][2].ToString(), Tabla.Rows[k][3].ToString(), Tabla.Rows[k][4].ToString(),"0-0");
            
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
                    DgvDevolucionDetalle.Rows[fila].Cells[7].Value = Cant+"-1";
                    FormDevolucionCantidad fdc = new FormDevolucionCantidad(DgvDevolucionDetalle, fila, cantMax);
                    fdc.StartPosition = FormStartPosition.CenterScreen;
                    fdc.Show();
                    DgvDevolucionDetalle.Rows[fila].Cells[5].ReadOnly = false;
                }
                else
                {
                    DgvDevolucionDetalle.Rows[fila].Cells[5].ReadOnly = true;
                    string VaAux= DgvDevolucionDetalle.Rows[fila].Cells[7].Value.ToString();
                    DgvDevolucionDetalle.Rows[fila].Cells[5].Value = "0";
                    //--
                    DgvDevolucionDetalle.Rows[fila].Cells[7].Value = VaAux.Split('-')[0] + "-0";
                    DgvDevolucionDetalle.Rows[fila].Cells[5].Value = VaAux.Split('-')[0];
                }
                BtnCED.PerformClick();
            }
        }
        public void CalcularSub()
        {
            double Total=0;
            for (int k = 0; k < DgvDevolucionDetalle.Rows.Count; k++)
            {
                string PreciUni = DgvDevolucionDetalle.Rows[k].Cells[4].Value.ToString();
                string Cant = DgvDevolucionDetalle.Rows[k].Cells[5].Value.ToString();
                double SubTot = double.Parse(PreciUni) * double.Parse(Cant);
                DgvDevolucionDetalle.Rows[k].Cells[6].Value = (SubTot).ToString();
                if (DgvDevolucionDetalle.Rows[k].Cells[7].Value.ToString().Split('-')[1].Trim() == "1")
                {
                    //--Calcular el importe total a devolver
                    double SubTotalDes = SubTot - SubTot * int.Parse(LblDescuento.Text) / 100;
                    Total += (SubTotalDes + SubTot * int.Parse(LblImpuesto.Text) / 100);
                }

            }
            LTotal.Text = LTotal.Text.Split('/')[0] + "/ " + Total.ToString();
            
        }

        private void DgvDevolucionDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            if (col == 5 && fila>=0)
            {
                CalcularSub();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TbId.Text.Trim() != "" && TbIdVenta.Text.Trim() != "" && TbRazon.Text.Trim() != "")
            {
                //MessageBox.Show("--"+DtpFechaPago.Text + "--" + aFecha+"--");
                if (Devolucion.ExisteClavePrimaria(new string[] { TbId.Text }))
                {//--Primero se agrega el elmento a la tabla TPedido
                    Devolucion.Actualizar(new string[] { TbId.Text, aIdUsuario, TbIdVenta.Text, TbRazon.Text, aFecha });
                    //--Se eliminan los productos del pedido
                    DevolucionDetalle.EliminarRegistros(TbId.Text);
                    //--Luego se guarda pedido detalle
                    for (int k = 0; k < DgvDevolucionDetalle.Rows.Count; k++)
                    {
                        if (DgvDevolucionDetalle.Rows[k].Cells[7].Value.ToString().Split('-')[1].Trim() == "1")
                        {
                            string id = DgvDevolucionDetalle.Rows[k].Cells[1].Value.ToString();
                            string Cant = DgvDevolucionDetalle.Rows[k].Cells[5].Value.ToString();
                            string Estado = DgvDevolucionDetalle.Rows[k].Cells[3].Value.ToString();
                            string precUni = DgvDevolucionDetalle.Rows[k].Cells[4].Value.ToString();
                            if (DevolucionDetalle.ExisteClavePrimaria(2, new string[] { TbId.Text, id }))
                                DevolucionDetalle.Actualizar(new string[] { TbId.Text, id, Cant, Estado, precUni });
                            else
                                DevolucionDetalle.Insertar(new string[] { TbId.Text, id, Cant, Estado, precUni });
                        }
                    }
                }
                else
                {//--Primero se agrega el elmento a la tabla TPedido
                    Devolucion.Insertar(new string[] { TbId.Text, aIdUsuario, TbIdVenta.Text, TbRazon.Text, aFecha });
                    //--Luego se guarda pedido detalle
                    for (int k = 0; k < DgvDevolucionDetalle.Rows.Count; k++)
                    {
                        if (DgvDevolucionDetalle.Rows[k].Cells[7].Value.ToString().Split('-')[1].Trim() == "1")
                        {
                            string id = DgvDevolucionDetalle.Rows[k].Cells[1].Value.ToString();
                            string Cant = DgvDevolucionDetalle.Rows[k].Cells[5].Value.ToString();
                            string Estado = DgvDevolucionDetalle.Rows[k].Cells[3].Value.ToString();
                            string precUni = DgvDevolucionDetalle.Rows[k].Cells[4].Value.ToString();
                            DevolucionDetalle.Insertar(new string[] { TbId.Text, id, Cant, Estado, precUni });
                        }
                    }
                }
                MessageBox.Show("Los datos se guardaron exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHistorialDevoluciones();
                
            }
            else MessageBox.Show("Todos los campos deben tener algun valor", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnBuscarDevoluciones_Click(object sender, EventArgs e)
        {
            DgvDevoluciones.CurrentCell = null;
            for (int k = DgvDevoluciones.Rows.Count - 1; k >= 0; k--)
            {
                if (DgvDevoluciones.Rows[k].Cells[0].Value.ToString().Contains(TbBuscarDevol.Text))
                    DgvDevoluciones.Rows[k].Visible = true;
                else
                {
                    DgvDevoluciones.Rows[k].Visible = false;
                }
            }
        }

        private void BtnBuscarVentas_Click(object sender, EventArgs e)
        {
            //CurrencyManager cm = (CurrencyManager)BindingContext[DgvCatalogoProductos.DataSource];
            //cm.SuspendBinding();
            DgvVentas.CurrentCell = null;
            for (int k = DgvVentas.Rows.Count - 1; k >= 0; k--)
            {
                if (DgvVentas.Rows[k].Cells[0].Value.ToString().Contains(TbBuscarVentas.Text))
                    DgvVentas.Rows[k].Visible = true;
                else
                {
                    DgvVentas.Rows[k].Visible = false;
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CbNuevoDev.Checked = true;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbIdVenta.Text = "";
            TbBuscarDevol.Text = "";
            TbBuscarVentas.Text = "";
            TbRazon.Text = "";
            DgvDevolucionDetalle.Rows.Clear();
        }

    }
}
