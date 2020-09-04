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
    public partial class FormPedidos : Form
    {
        //----------ATRIBUTOS--------------------
        CPedido Pedido = new CPedido();
        CPedidoDetalle PedidoDetalle = new CPedidoDetalle();
        bool Añadiendo = true;
        //--datos de entrada
        string aFecha;
        string aIdUsuario;
        //--
        DialogResult dr;
        public FormPedidos(string IdUsuario, string Fecha)
        {
            InitializeComponent();
            aIdUsuario = IdUsuario;
            aFecha = Fecha;
            CargarCatalogoProductos();
            CargarCbProveedores();
            //--Se carga el id del proximo pedido
            CbNuevoPed.Checked = true;
        }
        //--------------------------------------------
        public void CargarCbProveedores()
        {
            CbProv.DataSource = Pedido.ListaProveedores();
            CbProv.DisplayMember = "Nombre";
            CbProv.ValueMember = "IdProveedor";
            CbProv.SelectedIndex = 0;
        }
        //--Cargar el el id del pedido automaticamente
        public void CargarIdPedido()
        {
            string IdMax;
            if (Pedido.IdMaximo().Rows.Count != 0)
                IdMax = Pedido.IdMaximo().Rows[0][0].ToString();
            else
                IdMax = "PE000000";
            int ValorId = int.Parse(IdMax.Substring(2));
            IdMax = "PE";
            for (int k = 0; k < 6 - ValorId.ToString().Length; k++)
                IdMax += "0";
            TbId.Text = IdMax+(ValorId + 1).ToString();
        }
        public void CargarHistorialPedidos()
        {
            DgvPedidos.DataSource = Pedido.MostrarTodo();
        }
        //--Procedimientos
        public void CargarCatalogoProductos()
        {
            DgvCatalogoProductos.DataSource = Pedido.CatalogoProductos();
            DgvCatalogoProductos.Columns[0].Visible = false;
            DgvCatalogoProductos.Columns[2].Width = 101;
            DgvCatalogoProductos.Columns[3].Width = 70;
            DgvCatalogoProductos.Columns[4].Width = 55;
            //--Columna para agregar los productos a los detalles
            DataGridViewCheckBoxColumn ChkMarcar = new DataGridViewCheckBoxColumn();
            ChkMarcar.Name = "ColAgregar";
            ChkMarcar.HeaderText = "";
            ChkMarcar.Width = 40;
            DgvCatalogoProductos.Columns.Insert(0, ChkMarcar);
            //--Inhabilitar edicion de datos
            DgvCatalogoProductos.Columns[1].ReadOnly = true;
            DgvCatalogoProductos.Columns[2].ReadOnly = true;
            DgvCatalogoProductos.Columns[3].ReadOnly = true;
            DgvCatalogoProductos.Columns[4].ReadOnly = true;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TbId.Text.Trim() != "" && CbProv.Text.Trim() != "" && TbTermEntrega.Text.Trim() != "")
            {//--Se valida que el pedido no exceda la cantidad maxima de los productos
                if (ValidarCantidadMaxima())
                {
                    //MessageBox.Show("--"+DtpFechaPago.Text + "--" + aFecha+"--");
                    if (Pedido.ExisteClavePrimaria(new string[] { TbId.Text }))
                    {//--Primero se agrega el elmento a la tabla TPedido
                        Pedido.Actualizar(new string[] { TbId.Text, CbProv.SelectedValue.ToString(), aIdUsuario, DtpFechaPago.Text, aFecha, TbTermEntrega.Text });
                        //--Se eliminan los productos del pedido
                        PedidoDetalle.EliminarRegistros(TbId.Text);
                        //--Luego se guarda pedido detalle
                        for (int k = 0; k < DgvPedidosDetalle.Rows.Count; k++)
                        {
                            string id = DgvPedidosDetalle.Rows[k].Cells[0].Value.ToString();
                            string Cant = DgvPedidosDetalle.Rows[k].Cells[3].Value.ToString();
                            string precUni = DgvPedidosDetalle.Rows[k].Cells[2].Value.ToString();
                            if (PedidoDetalle.ExisteClavePrimaria(2, new string[] { TbId.Text, id }))
                                PedidoDetalle.Actualizar(new string[] { TbId.Text, id, Cant, precUni });
                            else
                                PedidoDetalle.Insertar(new string[] { TbId.Text, id, Cant, precUni });
                        }
                    }
                    else
                    {//--Primero se agrega el elmento a la tabla TPedido
                        Pedido.Insertar(new string[] { TbId.Text, CbProv.SelectedValue.ToString(), aIdUsuario, DtpFechaPago.Text, aFecha, TbTermEntrega.Text });
                        //--Luego se guarda pedido detalle
                        for (int k = 0; k < DgvPedidosDetalle.Rows.Count; k++)
                        {
                            string id = DgvPedidosDetalle.Rows[k].Cells[0].Value.ToString();
                            string Cant = DgvPedidosDetalle.Rows[k].Cells[3].Value.ToString();
                            string precUni = DgvPedidosDetalle.Rows[k].Cells[2].Value.ToString();
                            PedidoDetalle.Insertar(new string[] { TbId.Text, id, Cant, precUni });
                        }
                    }
                    MessageBox.Show("Los datos se guardaron exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Todos los campos deben tener algun valor", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public bool ValidarCantidadMaxima()
        {
            bool Guardar = true;
            for (int k = 0; k < DgvPedidosDetalle.Rows.Count; k++)
            {
                string idPro = DgvPedidosDetalle.Rows[k].Cells[0].Value.ToString();
                DataTable Datos = Pedido.CantidadMaxProducto(idPro);
                if (int.Parse(Datos.Rows[0][0].ToString()) < (int.Parse(Datos.Rows[0][1].ToString()) + int.Parse(DgvPedidosDetalle.Rows[k].Cells[3].Value.ToString())))
                {
                    MessageBox.Show("Se si se realiza el pedido, se exsedera el numero maximo de unidades de" + idPro, "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Guardar = false;
                }
            }
            return Guardar;
        }

        /// <summary>
        /// Evento que añade nuevos elementos del cattalogo al los detalles del pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCatalogoProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            if (col == 0)
            {  //--Si se activa el check box, se agrega el producto
                if (!Convert.ToBoolean(DgvCatalogoProductos.Rows[fila].Cells[0].Value))
                {//--Ver el estado del producto
                    string Estado = DgvCatalogoProductos.Rows[fila].Cells[6].Value.ToString();
                    dr = DialogResult.None;
                    if (Estado.Trim() != "ACTIVO")
                        dr = MessageBox.Show("El producto no se encuentra ACTIVADO, ¿esta seguro de que desea agregarlo?", "CUIDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //--Si se presiono si, se agrega el producto
                    if (dr == DialogResult.Yes || dr == DialogResult.None)
                    {
                        string Id = DgvCatalogoProductos.Rows[fila].Cells[1].Value.ToString();
                        string Nombre = DgvCatalogoProductos.Rows[fila].Cells[2].Value.ToString();
                        string Precio = DgvCatalogoProductos.Rows[fila].Cells[5].Value.ToString();
                        //--Abrir el form que pedira la cantidad del producto
                        FormPedidosCantidad fc = new FormPedidosCantidad(DgvPedidosDetalle, DgvCatalogoProductos, Id, Nombre, Precio, fila, Añadiendo, LTotal);
                        fc.StartPosition = FormStartPosition.CenterScreen;
                        fc.Show();
                    }
                }
            }
            button1.PerformClick();
        }
        /// <summary>
        /// Evento que hace que se desactive el check box, cuando no se desea agregar un elemento al dgvDetalle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCatalogoProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            if (dr == DialogResult.No)
            {
                DgvCatalogoProductos.Rows[fila].Cells[0].Value = false;
            }
        }
        //--Evento auxiliar, solo hace que se desencadene el evento de change de arriba
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void DgvPedidosDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            //--En caso de que se presione el boton, se elimina el producto de los detalles
            if (col == 5)
            {
                //--Se recupera la posicion del elemnto 
                int filaProducto = int.Parse(DgvPedidosDetalle.Rows[fila].Cells[6].Value.ToString());
                //--Se elimina la fila
                DgvPedidosDetalle.Rows.RemoveAt(fila);
                //--Se desmarca el check box
                DgvCatalogoProductos.Rows[filaProducto].Cells[0].Value = false;
                DgvCatalogoProductos.Rows[filaProducto].Cells[0].ReadOnly = false;
                //--Se vuelve a calcular el importe total
                DeterminarImporteTotal();
            }
        }
        private void DgvPedidosDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            if (!Añadiendo && col == 3)
            {
                int Cantidad = int.Parse(DgvPedidosDetalle.Rows[fila].Cells[3].Value.ToString());
                double PreUni = double.Parse(DgvPedidosDetalle.Rows[fila].Cells[2].Value.ToString());
                DgvPedidosDetalle.Rows[fila].Cells[4].Value = (Cantidad * PreUni).ToString();
            }
            else if (col == 4)
                DeterminarImporteTotal();
        }
        //--Calcular la cantidad total
        public void DeterminarImporteTotal()
        {
            double Total = 0;
            for (int k = 0; k < DgvPedidosDetalle.Rows.Count; k++)
            {
                Total += double.Parse(DgvPedidosDetalle.Rows[k].Cells[4].Value.ToString());
            }
            //--Cololcar el total 
            LTotal.Text = LTotal.Text.Split('/')[0] + "/ " + Total.ToString();
            Añadiendo = false;
        }
        /// <summary>
        /// Evento que filtrara el contenido del catalogo de producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            //CurrencyManager cm = (CurrencyManager)BindingContext[DgvCatalogoProductos.DataSource];
            //cm.SuspendBinding();
            DgvCatalogoProductos.CurrentCell = null;
            for (int k = DgvCatalogoProductos.Rows.Count - 1; k >= 0; k--)
            {
                if (DgvCatalogoProductos.Rows[k].Cells[2].Value.ToString().Contains(TbFiltrar.Text))
                    DgvCatalogoProductos.Rows[k].Visible = true;
                else
                {
                    DgvCatalogoProductos.Rows[k].Visible = false;
                }
            }
        }
        private void BtnFiltrarHistorial_Click(object sender, EventArgs e)
        {
            DgvCatalogoProductos.CurrentCell = null;
            for (int k = DgvPedidos.Rows.Count - 1; k >= 0; k--)
            {
                if (DgvPedidos.Rows[k].Cells[0].Value.ToString().Contains(TbfiltrarHistorial.Text))
                    DgvPedidos.Rows[k].Visible = true;
                else
                {
                    DgvPedidos.Rows[k].Visible = false;
                }
            }
        }
        //--Cambiar la vista de productos y pedidos
        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            GbHistotialPedidos.Visible = true;
            GbCatalodoProductos.Visible = false;
            CargarHistorialPedidos();
        }

        private void BtnCatalogo_Click(object sender, EventArgs e)
        {
            GbHistotialPedidos.Visible = false;
            GbCatalodoProductos.Visible = true;
        }
        //--cargar los datos de los pedidos hechos
        private void DgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            if (fila >= 0)
            {
                DataTable TablaPedido = Pedido.TraerDatosPedido(DgvPedidos.Rows[fila].Cells[0].Value.ToString());
                TbId.Text = TablaPedido.Rows[0][0].ToString();
                //CbProv.Text = TablaPedido.Rows[0][1].ToString();
                CbProv.SelectedIndex = int.Parse(TablaPedido.Rows[0][1].ToString().Substring(2));
                TbTermEntrega.Text = TablaPedido.Rows[0][5].ToString();
                //--Cargar los datos en data grid view
                DataTable TablaPedidoDetalle = Pedido.TraerDatosPedidoDetalle(DgvPedidos.Rows[fila].Cells[0].Value.ToString());
                DgvPedidosDetalle.Rows.Clear();
                DejarEnCatalogoBlanco();
                for (int k = 0; k < TablaPedidoDetalle.Rows.Count; k++)
                {
                    string codProd = TablaPedidoDetalle.Rows[k][1].ToString();
                    string nombre = DetNombre(codProd);
                    string precio = TablaPedidoDetalle.Rows[k][3].ToString();
                    string cantidad = TablaPedidoDetalle.Rows[k][2].ToString();
                    DgvPedidosDetalle.Rows.Add(codProd, nombre.Split('#')[0], precio, cantidad, (double.Parse(precio) * int.Parse(cantidad)).ToString(), "X", nombre.Split('#')[1]);
                }
                DeterminarImporteTotal();
                CbNuevoPed.Checked = false;
                CbNuevoPed.Enabled = true;
            }
        }
        public void DejarEnCatalogoBlanco()
        {
            for (int k = 0; k < DgvCatalogoProductos.Rows.Count; k++)
            {
                DgvCatalogoProductos.Rows[k].Cells[0].Value = false;
                DgvCatalogoProductos.Rows[k].Cells[0].ReadOnly = false;
            }
        }
        public string DetNombre(string Cod)
        {
            string nombre = "";
            for (int k = 0; k < DgvCatalogoProductos.Rows.Count; k++)
            {
                if (DgvCatalogoProductos.Rows[k].Cells[1].Value.ToString().Trim() == Cod)
                {
                    DgvCatalogoProductos.Rows[k].Cells[0].Value = true;
                    DgvCatalogoProductos.Rows[k].Cells[0].ReadOnly = true;
                    return DgvCatalogoProductos.Rows[k].Cells[2].Value.ToString() + "#" + k.ToString();
                }
            }
            return nombre;
        }
        /// <summary>
        /// Evento que se activa si se agregara un producto nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbNuevoPed_CheckedChanged(object sender, EventArgs e)
        {
            if (CbNuevoPed.Checked)
            {
                CargarIdPedido();
                DgvPedidosDetalle.Rows.Clear();
                CbProv.SelectedIndex = 0;
                TbTermEntrega.Text = "";
                CbNuevoPed.Enabled = false;
                DejarEnCatalogoBlanco();
            }
        }

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
