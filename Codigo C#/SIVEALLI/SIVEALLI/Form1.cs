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
            MessageBox.Show(ScHorizontal.Panel2.Width.ToString() + "--" + ScHorizontal.Panel2.Height.ToString());
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios fu = new FormUsuarios();
            fu.Show();
        }
    }
}
