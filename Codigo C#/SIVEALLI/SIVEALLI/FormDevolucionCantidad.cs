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
    public partial class FormDevolucionCantidad : Form
    {
        DataGridView DgvDevolucionsDetalle;
        int afila;
        int aCantMax;
        public FormDevolucionCantidad(DataGridView devDet,int pfila,int cant)
        {
            InitializeComponent();
            DgvDevolucionsDetalle= devDet;
            afila = pfila;
            aCantMax = cant;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (aCantMax >= NudCantidad.Value)
            {
                DgvDevolucionsDetalle.Rows[afila].Cells[5].Value = "0";
                DgvDevolucionsDetalle.Rows[afila].Cells[5].Value = NudCantidad.Value.ToString();
                Close();
            }
            else
                MessageBox.Show("No se pueden devolver mas articulos de los que se compro", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
