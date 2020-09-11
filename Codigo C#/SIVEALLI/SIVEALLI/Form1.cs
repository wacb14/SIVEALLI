﻿using System;
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
        FormDevoluciones fd;
        FormVentas fv;
        FormNegocio fn;
        FormEntrada fe;
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
        private void buttonUsuarios_Click(object sender, EventArgs e)
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
                fe = new FormEntrada(labelUsuario.Text);
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
