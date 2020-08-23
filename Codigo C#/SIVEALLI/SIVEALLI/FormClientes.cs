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
    public partial class FormClientes : Form
    {
        //----------ATRIBUTOS--------------------
        CCliente Cliente = new CCliente();
        public FormClientes()
        {
            InitializeComponent();
            CargarListaClientes();
        }
        //--------------------------------------------------------------------------------------
        public void CargarDatos()
        {
            if (Cliente.Registro(TbId.Text).Rows.Count > 0)
            {
                TbId.Text = Cliente.ValorAtributo("IdCliente");
                TbNombres.Text = Cliente.ValorAtributo("Nombres");
                TbApellidos.Text = Cliente.ValorAtributo("Apellidos");
                TbDireccion.Text = Cliente.ValorAtributo("Direccion");
                TbTelefono.Text = Cliente.ValorAtributo("Telefono");
                TbCorreo.Text = Cliente.ValorAtributo("Email");
            }
        }
        //----Validar techas
        private void DejarEnBlanco()
        {
            TbNombres.Text = "";
            TbApellidos.Text = "";
            TbDireccion.Text = "";
            TbCorreo.Text = "";
            TbId.Text = "";
            TbTelefono.Text = "";
        }

        //--Procedimientos
        public void CargarListaClientes()
        {
            DgvClientes.DataSource = Cliente.ListaGeneral();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TbId.Text.Trim() != "" && TbNombres.Text.Trim() != "" && TbApellidos.Text.Trim() != "" && TbTelefono.Text.Trim() != "" && TbDireccion.Text.Trim() != "" && TbCorreo.Text.Trim() != "")
            {
                if (Cliente.Registro(TbId.Text).Rows.Count > 0)
                    Cliente.Actualizar(new string[] { TbId.Text, TbNombres.Text, TbApellidos.Text, TbDireccion.Text, TbTelefono.Text, TbCorreo.Text });
                else
                    Cliente.Insertar(new string[] { TbId.Text, TbNombres.Text, TbApellidos.Text, TbDireccion.Text, TbTelefono.Text, TbCorreo.Text });
                MessageBox.Show("Los datos se guardaron exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Todos los campos deben tener algun valor", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {//--Validar datos
            if (TbApellidos.Text.Trim() != "" && TbDireccion.Text.Trim() != "" && TbId.Text.Trim() != "" && TbNombres.Text.Trim() != "" && TbTelefono.Text.Trim() != "")
            {
                Cliente.Actualizar(new string[] { TbId.Text, TbNombres.Text, TbApellidos.Text, TbDireccion.Text, TbTelefono.Text, TbCorreo.Text });
                MessageBox.Show("La modificacion fue realizada exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

