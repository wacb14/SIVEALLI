using BibClases;
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
        CPedido aPedido;
        DataGridView DgvPedidosDetalle;
        DataGridView DgvCatalogoProductos;
        string IdProducto;
        string NombreProd;
        string PreciProd;
        int aFila;
        bool Añadiendo;
        Label LTotal;

        int aPos;
        bool aedi;
        public FormPedidosCantidad(CPedido Ped,DataGridView dgvPD, DataGridView dgvCP, string id, string nombre, string precio, int fila, bool Aña, Label Prec, int Pos = 0, bool edi = false)
        {
            InitializeComponent();
            aPedido = Ped;
            DgvPedidosDetalle = dgvPD;
            DgvCatalogoProductos = dgvCP;
            IdProducto = id;
            NombreProd = nombre;
            PreciProd = precio;
            aFila = fila;
            Añadiendo = Aña;
            LTotal = Prec;

            aPos = Pos;
            aedi = edi;
        }   

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCantidadMaxima())
            {
                if (aedi)
                {
                    DgvPedidosDetalle.Rows[aPos].Cells[3].Value = NudCantidad.Value.ToString();
                    this.Close();
                }
                else
                {
                    int Cantidad = int.Parse(NudCantidad.Value.ToString());
                    double precioMasDescuento = double.Parse(PreciProd) - double.Parse(PreciProd) / 5;
                    double subTotal = (precioMasDescuento) * Cantidad;

                    Añadiendo = true;
                    DgvPedidosDetalle.Rows.Add(IdProducto, NombreProd, precioMasDescuento, Cantidad, (subTotal).ToString(), "X", aFila.ToString());
                    Añadiendo = false;
                    DgvCatalogoProductos.Rows[aFila].Cells[0].ReadOnly = true;
                    //--Calcular el total del importe
                    double Total = double.Parse(LTotal.Text.Split('/')[1].ToString());
                    LTotal.Text = LTotal.Text.Split('/')[0] + "/ " + (Total + subTotal).ToString();
                    this.Close();
                }
            }
        }

        public bool ValidarCantidadMaxima()
        {
            bool Guardar = true;
            string idPro = IdProducto;
            DataTable Datos = aPedido.CantidadMaxProducto(idPro);
            if (int.Parse(Datos.Rows[0][0].ToString()) < (int.Parse(Datos.Rows[0][1].ToString()) +NudCantidad.Value))
            {
                MessageBox.Show("No se puede registrar ese valor, se eccedera el numero maximo de unidades de" + idPro, "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Guardar = false;
            }
            return Guardar;
        }
    }
}
