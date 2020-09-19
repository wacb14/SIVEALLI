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

            DataTable dt = not.ListaNoLeidos();

            for(int i=0; i<dt.Rows.Count; i++)
            {
                dgvNotificaciones.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), "Marcar como leído");
            }


            //eventos
            this.dgvNotificaciones.CellClick += new DataGridViewCellEventHandler(MarcarMensajeComoLeido);
            this.BtnEliminarMensajesLeido.Click += new EventHandler(EliminarMensajesLeidos);
            this.TcMensajes.SelectedIndexChanged += new EventHandler(CambioPagina);
        }

        private void CambioPagina(object sender, EventArgs e)
        {
            if (TcMensajes.SelectedTab.Text.Equals("Mensajes leidos"))
            {
                dgvMensajesLeidos.DataSource = not.ListaLeidos();
                dgvMensajesLeidos.Columns[0].Width = 100;
                dgvMensajesLeidos.Columns[1].Width = 500;
                dgvMensajesLeidos.Columns[2].Width = 100;
                dgvMensajesLeidos.Columns[3].Width = 100;
            }
            else
            {
                dgvNotificaciones.Rows.Clear();
                DataTable dt = not.ListaNoLeidos();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvNotificaciones.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), "Marcar como leído");
                }
            }
        }

        private void EliminarMensajesLeidos(object sender, EventArgs e)
        {
            not.EliminarMensajesLeidos();
            dgvMensajesLeidos.DataSource = null;
        }

        private void MarcarMensajeComoLeido(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            try
            {
                if (col == 4)
                {
                    not.MarcarMensajeComoLeido(dgvNotificaciones.Rows[fila].Cells[0].Value.ToString());
                    dgvNotificaciones.Rows.Remove(dgvNotificaciones.Rows[fila]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
