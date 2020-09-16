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
        protected FormUsuarios fu;
        FormProveedores P;
        FormProductos Fp;
        FrmReportes R;
        FormDevoluciones fd;
        FormVentas fv;
        FormNegocio fn;
        FormEntrada fe;

        protected FormUsuarioEmpleado fue;

        public FormSupervisor(string codigoUsuario)
        {
            InitializeComponent();
            //MessageBox.Show(ScHorizontal.Panel2.Width.ToString() + "--" + ScHorizontal.Panel2.Height.ToString());

            labelUsuario.Text = codigoUsuario;

            //Evento cerrar ventana
            this.BtnCerrarSesion.Click += new EventHandler(CerrarSesion);
            this.timerNotificaciones.Tick += new EventHandler(ComprobarNotificaciones);
            //this.BtnNotificaciones.Click += delegate (object sender, EventArgs e) { ComprobarNotificaciones(sender, e, nuevaNotificacion); };
        }

        private void ComprobarNotificaciones(object sender, EventArgs e)
        {
            //se revisara si hay nuevas notificaciones
            //aNotificaciones.ExisteNuevasNotificaciones();
            //MessageBox.Show("hola");
            Random rnd = new Random();
            int month = rnd.Next(1, 5);  // creates a number between 1 and 12
            if(month == 1)
                this.BtnNotificaciones.BackColor = Color.Red;
            else if (month == 2)
                this.BtnNotificaciones.BackColor = Color.Blue;
            else if (month == 3)
                this.BtnNotificaciones.BackColor = Color.Yellow;
            else if (month == 4)
                this.BtnNotificaciones.BackColor = Color.Green;

        }

        private void CerrarSesion(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fu = new FormLogin();
            fu.Closed += (s, args) => this.Close();
            fu.Show();
        }

        protected virtual void AbrirFormPanel(Form Ventana)
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
        public virtual void DeshabilitarVisible()
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
            if (ScHorizontal.Panel2.Controls.Contains(fd))
                fd.Visible = false;
            if (ScHorizontal.Panel2.Controls.Contains(fv))
                fv.Visible = false;
            if (ScHorizontal.Panel2.Controls.Contains(fe))
                fe.Visible = false;
            if (ScHorizontal.Panel2.Controls.Contains(fn))
                fn.Visible = false;
            if (ScHorizontal.Panel2.Controls.Contains(fu))
                fu.Visible = false;
        }
        protected virtual void buttonUsuarios_Click(object sender, EventArgs e)
        {
            DeshabilitarVisible();
            if (ScHorizontal.Panel2.Controls.Contains(fu))
                fu.Visible = true;
            else
            {
                fu = new FormUsuarios(labelUsuario.Text);
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
            DeshabilitarVisible();
            if (ScHorizontal.Panel2.Controls.Contains(fe))
                fe.Visible = true;
            else
            {
                fe = new FormEntrada(labelUsuario.Text, dtpFecha.Value.Date.ToString());
                //Fc.Show();
                AbrirFormPanel(fe);
            }

        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            DeshabilitarVisible();
            //FormPedidos fp = new FormPedidos(labelUsuario.Text, dtpFecha.Value.ToString().Split(' ')[0]);
            if (ScHorizontal.Panel2.Controls.Contains(fp))
                fp.Visible = true;
            else
            {
                fp = new FormPedidos(labelUsuario.Text, dtpFecha.Value.ToString().Split(' ')[0]);
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
            DeshabilitarVisible();
            if (ScHorizontal.Panel2.Controls.Contains(fd))
                fd.Visible = true;
            else
            {
                fd = new FormDevoluciones(labelUsuario.Text, dtpFecha.Value.ToString().Split(' ')[0]);
                AbrirFormPanel(fd);
            }
        }
        private void BtnVentas_Click(object sender, EventArgs e)
        {
            DeshabilitarVisible();
            if (ScHorizontal.Panel2.Controls.Contains(fv))
                fv.Visible = true;
            else
            {
                fv = new FormVentas(labelUsuario.Text, dtpFecha.Value.ToString("yyyy-MM-dd"));
                AbrirFormPanel(fv);
            }
        }

        private void btnNegocio_Click(object sender, EventArgs e)
        {
            DeshabilitarVisible();
            if (ScHorizontal.Panel2.Controls.Contains(fn))
                fn.Visible = true;
            else
            {
                fn = new FormNegocio();
                AbrirFormPanel(fn);
            }
        }
    }
}
