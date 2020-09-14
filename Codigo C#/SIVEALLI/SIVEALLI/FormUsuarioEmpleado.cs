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
    public partial class FormUsuarioEmpleado : FormUsuarios
    {
        public FormUsuarioEmpleado(string usuario) : base(usuario)
        {
            this.gbListaUsuarios.Visible = false;
            this.GbBusqueda.Visible = false;

            this.btnRestaurarContra.Visible = false;
            this.BtnLimpiar.Visible = false;
            this.btnNuevoUsuario.Visible = false;
        }
    }
}
