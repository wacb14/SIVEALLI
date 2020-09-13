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
        DataGridView DgvProd;
        bool aag;
        int afila;
        int aCantMax;
        public FormDevolucionCantidad(DataGridView ProDev,bool Ag,DataGridView devDet,int pfila,int cant,int NroObj=1,string Est="Nuevo")
        {
            InitializeComponent();
            DgvDevolucionsDetalle= devDet;
            afila = pfila;
            aCantMax = cant;

            NudCantidad.Value = NroObj;
            CbEstC.Text = Est;
            DgvProd = ProDev;
            aag = Ag;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (aCantMax >= NudCantidad.Value)
            {
                DgvDevolucionsDetalle.Rows[afila].Cells[5].Value = "0";
                DgvDevolucionsDetalle.Rows[afila].Cells[5].Value = NudCantidad.Value.ToString();
                DgvDevolucionsDetalle.Rows[afila].Cells[3].Value = CbEstC.Text;
                if (aag)
                {
                    string id = DgvDevolucionsDetalle.Rows[afila].Cells[1].Value.ToString();
                    string Estado = DgvDevolucionsDetalle.Rows[afila].Cells[3].Value.ToString();
                    string Cantidad = DgvDevolucionsDetalle.Rows[afila].Cells[5].Value.ToString();
                    string Total = DgvDevolucionsDetalle.Rows[afila].Cells[6].Value.ToString();
                    DgvProd.Rows.Add(id,Estado,Cantidad,Total);
                }
                else
                {
                    string Total = DgvDevolucionsDetalle.Rows[afila].Cells[6].Value.ToString();
                    string id = DgvDevolucionsDetalle.Rows[afila].Cells[1].Value.ToString();
                    for (int k = 0; k < DgvProd.Rows.Count; k++)
                        if (DgvProd.Rows[k].Cells[0].Value.ToString().Trim() == id.Trim())
                        {
                            DgvProd.Rows[k].Cells[2].Value = NudCantidad.Value.ToString();
                            DgvProd.Rows[k].Cells[3].Value = Total;
                        }
                }
                Close();
            }
            else
                MessageBox.Show("No se pueden devolver mas articulos de los que se compro", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
