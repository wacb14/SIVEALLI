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
        bool Añadiendo = true;
        //--datos de entrada
        DateTime aFecha;
        string aIdUsuario;
        public FormPedidos(string IdUsuario,DateTime Fecha)
        {
            InitializeComponent();
            aIdUsuario = IdUsuario;
            aFecha = Fecha;
            CargarCatalogoProductos();
            CargarCbProveedores();
        }
        //--------------------------------------------
        public void CargarCbProveedores()
        {
            CbProv.DataSource = Pedido.ListaProveedores();
            CbProv.DisplayMember = "Nombre";
            CbProv.ValueMember = "IdProveedor";
            CbProv.SelectedIndex = 0;
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
            DgvCatalogoProductos.Columns.Insert(0,ChkMarcar);
            //--Inhabilitar edicion de datos
            DgvCatalogoProductos.Columns[1].ReadOnly = true;
            DgvCatalogoProductos.Columns[2].ReadOnly = true;
            DgvCatalogoProductos.Columns[3].ReadOnly = true;
            DgvCatalogoProductos.Columns[4].ReadOnly = true;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TbId.Text.Trim()!="" && CbProv.Text.Trim()!="" && TbTermPedido.Text.Trim() != "")
            {//--Se valida que el pedido no exceda la cantidad maxima de los productos
                if (ValidarCantidadMaxima())
                {/*/--Primero se agrega el elmento a la tabla TPedido
                    if (Pedido.ExisteClavePrimaria(new string[] { TbId.Text }))//?
                        Pedido.Actualizar(new string[] { TbId.Text, CbProv.Text, aIdUsuario, });
                            l
                    //--Luego se guarda pedido detalle
                    for (int k = 0; k < DgvPedidosDetalle.Rows.Count; k++)
                    {
                        string id = DgvCatalogoProductos.Rows[k].Cells[0].Value.ToString();
                        string Cant = DgvCatalogoProductos.Rows[k].Cells[3].Value.ToString();
                        string prec = DgvCatalogoProductos.Rows[k].Cells[2].Value.ToString();
                        if (Pedido.ExisteClavePrimaria(new string[] { TbId.Text }))//?
                            Pedido.Actualizar(new string[] { TbId.Text, id, Cant,prec });
                        else
                            Pedido.Insertar(new string[] { TbId.Text, id, Cant, prec });
                        MessageBox.Show("Los datos se guardaron exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }*/
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
        private void DgvCatalogoProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            if (col == 0)
            {  //--Si se activa el check box, se agrega el producto
                if (!Convert.ToBoolean(DgvCatalogoProductos.Rows[fila].Cells[0].Value))
                {
                    //DgvCatalogoProductos.Rows[fila].Cells[0].Value = true;
                    string Id = DgvCatalogoProductos.Rows[fila].Cells[1].Value.ToString();
                    string Nombre = DgvCatalogoProductos.Rows[fila].Cells[2].Value.ToString();
                    string Precio = DgvCatalogoProductos.Rows[fila].Cells[5].Value.ToString();
                    //--Abrir el form que pedira la cantidad del producto
                    FormPedidosCantidad fc = new FormPedidosCantidad(DgvPedidosDetalle,DgvCatalogoProductos,Id,Nombre,Precio,fila,Añadiendo,LTotal);
                    fc.StartPosition= FormStartPosition.CenterScreen;
                    fc.Show();

                    /*Añadiendo = true;
                    DgvPedidosDetalle.Rows.Add(Id, Nombre, Precio, "1", Precio, "X",fila.ToString());
                    Añadiendo = false;
                    DgvCatalogoProductos.Rows[fila].Cells[0].ReadOnly = true;
                    //--Calcular el total del importe
                    double Total = double.Parse(LTotal.Text.Split('/')[1].ToString());
                    double PrecioPro = double.Parse(Precio);
                    LTotal.Text = LTotal.Text.Split('/')[0] + "/ " + (Total+PrecioPro).ToString();*/
                }
            }
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
            for(int k = 0; k < DgvPedidosDetalle.Rows.Count; k++)
            {
                Total += double.Parse(DgvPedidosDetalle.Rows[k].Cells[4].Value.ToString());
            }
            //--Cololcar el total 
            LTotal.Text = LTotal.Text.Split('/')[0] + "/ " + Total.ToString();
            Añadiendo= false;
        }
        /// <summary>
        /// Evento que filtrara el contenido del catalogo de producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[DgvCatalogoProductos.DataSource];
            cm.SuspendBinding();
            for (int k = DgvCatalogoProductos.Rows.Count-1; k>=0; k--)
            {
                if (DgvCatalogoProductos.Rows[k].Cells[2].Value.ToString().Contains(TbFiltrar.Text))
                    DgvCatalogoProductos.Rows[k].Visible = true;
                else
                {
                    DgvCatalogoProductos.Rows[k].Visible = false;
                }
            }
        }
    }
}
