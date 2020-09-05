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
        public FormVentasCantidad(int Maximo)
        {
            InitializeComponent();
            NudCantidad.Maximum = Maximo;
            NudCantidad.Minimum = 1;
        }
        public int GetCantidad
        {
            get { return Cantidad; }
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Cantidad = int.Parse(NudCantidad.Value.ToString());
            this.Close();
        }
    }
}
