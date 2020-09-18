using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibClases;

namespace SIVEALLI
{
    public partial class FormNotificaciones : FormPadre
    {
        CNotificaciones not = new CNotificaciones();
        public FormNotificaciones()
        {
            InitializeComponent();

            IniciarEntidad(new CNotificaciones());

            dgvNotificaciones.DataSource = not.ListaNoLeidos();
        }
    }
}
