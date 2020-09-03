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
        FormClientes fc;
        FormPedidos fp;
        FormUsuarios fu;
        FormProveedores P;
        FormProductos Fp;
        FrmReportes R;
        public FormSupervisor(string codigoUsuario)
        {
            InitializeComponent();
            //MessageBox.Show(ScHorizontal.Panel2.Width.ToString() + "--" + ScHorizontal.Panel2.Height.ToString());

            labelUsuario.Text = codigoUsuario;
        }
        protected void AbrirFormPanel(Form Ventana)
        {
            Ventana.TopLevel = false;
            //--Se quitan los bordes
            Ventana.FormBorderStyle = FormBorderStyle.None;
            Ventana.Dock = DockStyle.Fill;
            //--Se agrega el form al panel
            ScHorizontal.Panel2.Controls.Add(Ventana);
            ScHorizontal.Panel2.Tag = Ventana;
            Ventana.Show();//--Se inicia el form
        }
        public void DeshabilitarVisible()
        {
            if (ScHorizontal.Panel2.Controls.Contains(fp))
                fp.Visible = false;
            if (ScHorizontal.Panel2.Controls.Contains(fc))
                fc.Visible = false;
            if (ScHorizontal.Panel2.Controls.Contains(fu))
                fu.Visible = false;
            if (ScHorizontal.Panel2.Controls.Contains(P))
                P.Visible = false;
            if (ScHorizontal.Panel2.Controls.Contains(Fp))
                Fp.Visible = false;
            if (ScHorizontal.Panel2.Controls.Contains(R))
                R.Visible = false;
        }
        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            DeshabilitarVisible();
            if (ScHorizontal.Panel2.Controls.Contains(fu))
                fu.Visible = true;
            else
            {
                fu = new FormUsuarios();
                AbrirFormPanel(fu);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeshabilitarVisible();
            if (ScHorizontal.Panel2.Controls.Contains(P))
                P.Visible = true;
            else
            {
                P = new FormProveedores();
                AbrirFormPanel(P);
            }
            //P.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            DeshabilitarVisible();
            if (ScHorizontal.Panel2.Controls.Contains(fc))
                fc.Visible = true;
            else
            {
                fc = new FormClientes();
                //Fc.Show();
                AbrirFormPanel(fc);
            }
        }

        private void buttonEntrada_Click(object sender, EventArgs e)
        {
            FormEntrada fe = new FormEntrada(labelUsuario.Text);
            fe.Show();
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            DeshabilitarVisible();
            //FormPedidos fp = new FormPedidos(labelUsuario.Text, dtpFecha.Value.ToString().Split(' ')[0]);
            if (ScHorizontal.Panel2.Controls.Contains(fp))
                fp.Visible = true;
            else
            {
                fp = new FormPedidos(labelUsuario.Text, "02/02/2020");
                AbrirFormPanel(fp);
            }
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            DeshabilitarVisible();
            if (ScHorizontal.Panel2.Controls.Contains(Fp))
                Fp.Visible = true;
            else
            {
                Fp = new FormProductos();
                //Fc.Show();
                AbrirFormPanel(Fp);
            }
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            DeshabilitarVisible();
            if (ScHorizontal.Panel2.Controls.Contains(R))
                R.Visible = true;
            else
            {
                R = new FrmReportes();
                AbrirFormPanel(R);
            }
        }

        private void BtnDevoluciones_Click(object sender, EventArgs e)
        {

        }
    }
}
