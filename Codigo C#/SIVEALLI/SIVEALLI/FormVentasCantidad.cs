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
    public partial class FormVentasCantidad : Form
    {
        int Cantidad = 1;
        int Maxim;
        public FormVentasCantidad(int Maximo)
        {
            InitializeComponent();
            NudCantidad.Minimum = 1;
            Maxim = Maximo;
        }
        public int GetCantidad
        {
            get { return Cantidad; }
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (NudCantidad.Value > Maxim)
                MessageBox.Show("La cantidad seleccionada supera a la cantidad disponible de este producto. Por favor seleccione otra cantidad ", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Cantidad = int.Parse(NudCantidad.Value.ToString());
        }

        private void NudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (NudCantidad.Value <= Maxim)
                BtnAceptar.DialogResult = DialogResult.OK;
            else
                BtnAceptar.DialogResult = DialogResult.None;
        }
    }
}
