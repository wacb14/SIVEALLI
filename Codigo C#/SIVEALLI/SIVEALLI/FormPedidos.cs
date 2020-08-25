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
        public FormPedidos(string IdUsuario)
        {
            InitializeComponent();
            CargarCatalogoProductos();
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
            ChkMarcar.Name = "ColMarcar";
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

        }

        private void DgvCatalogoProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        { 
        }
        private void DarFormatoGridDetalle()
        {
            DataGridViewTextBoxColumn TxtCantidades = new DataGridViewTextBoxColumn();
            TxtCantidades.Name = "ColId";
            TxtCantidades.HeaderText = "Id Producto";
            TxtCantidades.Width = 80;
            DgvPedidosDetalle.Columns.Add(TxtCantidades);
            //--Columna de botones
            DataGridViewButtonColumn BtnBorrar = new DataGridViewButtonColumn();
            BtnBorrar.Name = "ColBorrar";
            BtnBorrar.HeaderText = "";
            BtnBorrar.Text = "X";
            BtnBorrar.UseColumnTextForButtonValue = true;
            BtnBorrar.Width = 40;
            DgvPedidosDetalle.Columns.Add(BtnBorrar);
        }

        private void DgvCatalogoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            if (col == 0)
            {  //--Si se activa el check box, se agrega el producto
                if (!Convert.ToBoolean(DgvCatalogoProductos.Rows[fila].Cells[0].Value))
                {
                    string Id = DgvCatalogoProductos.Rows[fila].Cells[1].Value.ToString();
                    string Nombre = DgvCatalogoProductos.Rows[fila].Cells[2].Value.ToString();
                    string Precio = DgvCatalogoProductos.Rows[fila].Cells[5].Value.ToString();
                    DgvPedidosDetalle.Rows.Add(Id, Nombre, Precio, "1", Precio, new Button());
                }//--Caso contrario, se elimina el producto del grid detalle
                else { }
                    //DgvPedidosDetalle.Rows.RemoveAt(DgvPedidosDetalle.Columns[0].IndexO(DgvCatalogoProductos.Rows[fila].Cells[1].Value.ToString()));
            }
            else
                MessageBox.Show("-->" + DgvCatalogoProductos.Rows[fila].Cells[0].Value.ToString());
        }
    }
}
