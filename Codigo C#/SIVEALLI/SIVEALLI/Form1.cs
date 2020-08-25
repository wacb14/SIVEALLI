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
    public partial class FormSupervisor : Form
    {
        public FormSupervisor()
        {
            InitializeComponent();
            //MessageBox.Show(ScHorizontal.Panel2.Width.ToString() + "--" + ScHorizontal.Panel2.Height.ToString());
        }
        protected void AbrirFormPanel(Form Ventana)
        {
            ScHorizontal.Panel2.Controls.Clear();
            Ventana.TopLevel = false;
            //--Se quitan los bordes
            Ventana.FormBorderStyle = FormBorderStyle.None;
            Ventana.Dock = DockStyle.Fill;
            //--Se agrega el form al panel
            ScHorizontal.Panel2.Controls.Add(Ventana);
            ScHorizontal.Panel2.Tag = Ventana;
            Ventana.Show();//--Se inicia el form
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios fu = new FormUsuarios();
            fu.Show();
            //AbrirFormPanel(fu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProveedores P = new FormProveedores();
            P.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FormClientes Fc = new FormClientes();
            //Fc.Show();
            AbrirFormPanel(Fc);
        }

        private void buttonEntrada_Click(object sender, EventArgs e)
        {
            FormEntrada fe = new FormEntrada();
            fe.Show();
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos fp = new FormPedidos("--");
            fp.Show();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FormProductos Fp = new FormProductos();
            //Fc.Show();
            AbrirFormPanel(Fp);
        }
    }
}
