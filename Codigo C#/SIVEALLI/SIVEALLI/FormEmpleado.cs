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
    public partial class FormEmpleado : FormSupervisor
    {
        public FormEmpleado(string CodigoEmpleado) : base(CodigoEmpleado)
        {
            InitializeComponent();

            ModificandoOcultandoControles();
        }

        private void ModificandoOcultandoControles()
        {
            this.BtnUsuarios.Text = "Mi perfil";

            this.btnNegocio.Visible = false;
            this.BtnPedidos.Visible = false;
            this.BtnEntrada.Visible = false;
            this.BtnNotificaciones.Visible = false;
        }

        protected override void buttonUsuarios_Click(object sender, EventArgs e)
        {
            DeshabilitarVisible();
            if (ScHorizontal.Panel2.Controls.Contains(fu))
                fu.Visible = true;
            else
            {
                fue = new FormUsuarioEmpleado(labelUsuario.Text);
                AbrirFormPanel(fue);
            }
        }
    }
}
