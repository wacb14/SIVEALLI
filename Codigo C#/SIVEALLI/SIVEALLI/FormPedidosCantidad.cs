using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIVEALLI
{
    public partial class FormPedidosCantidad : Form
    {
        DataGridView DgvPedidosDetalle;
        DataGridView DgvCatalogoProductos;
        string IdProducto;
        string NombreProd;
        string PreciProd;
        int aFila;
        bool Añadiendo;
        Label LTotal;
        public FormPedidosCantidad(DataGridView dgvPD, DataGridView dgvCP,string id,string nombre,string precio,int fila,bool Aña,Label Prec)
        {
            InitializeComponent();
            DgvPedidosDetalle = dgvPD;
            DgvCatalogoProductos = dgvCP;
            IdProducto = id;
            NombreProd = nombre;
            PreciProd = precio;
            aFila = fila;
            Añadiendo = Aña;
            LTotal = Prec;
        }   

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int Cantidad = int.Parse(NudCantidad.Value.ToString());
            double PrecioPro = double.Parse(PreciProd) * Cantidad;

            Añadiendo = true;
            DgvPedidosDetalle.Rows.Add(IdProducto, NombreProd, PreciProd, Cantidad, (PrecioPro).ToString(), "X", aFila.ToString());
            Añadiendo = false;
            DgvCatalogoProductos.Rows[aFila].Cells[0].ReadOnly = true;
            //--Calcular el total del importe
            double Total = double.Parse(LTotal.Text.Split('/')[1].ToString());
            LTotal.Text = LTotal.Text.Split('/')[0] + "/ " + (Total + PrecioPro).ToString();
            this.Close();
        }
    }
}
