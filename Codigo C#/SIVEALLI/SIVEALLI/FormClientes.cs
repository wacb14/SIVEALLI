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
using System.Text.RegularExpressions;

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
            CbNuevoPed.Checked = true;
        }
        //--Cargar el el id del pedido automaticamente
        public void CargarIdCliente()
        {
            string IdMax = Cliente.IdMaximo().Rows[0][0].ToString();
            int ValorId = int.Parse(IdMax.Substring(2));
            IdMax = "CL";
            for (int k = 0; k < 6 - ValorId.ToString().Length; k++)
                IdMax += "0";
            TbId.Text = IdMax + (ValorId + 1).ToString();
        }
        //--------------------------------------------------------------------------------------
        public void CargarDatos()
        {
            if (Cliente.ExisteClavePrimaria(new string[] { TbId.Text }))
            {
                TbId.Text = Cliente.ValorAtributo("IdCliente");
                TbNombres.Text = Cliente.ValorAtributo("Nombres");
                TbApellidos.Text = Cliente.ValorAtributo("Apellidos");
                TbDireccion.Text = Cliente.ValorAtributo("Direccion");
                TbTelefono.Text = Cliente.ValorAtributo("Telefono");
                TbCorreo.Text = Cliente.ValorAtributo("Correo");
            }
        }
        //----Validar techas
        private void DejarEnBlanco()
        {
            TbNombres.Text = "";
            TbApellidos.Text = "";
            TbDireccion.Text = "";
            TbCorreo.Text = "";
            TbTelefono.Text = "";
        }

        //--Procedimientos
        public void CargarListaClientes()
        {
            DgvClientes.DataSource = Cliente.ListaGeneral();
            //--Mostrar el numero de clientes
            LblCant.Text =  DgvClientes.Rows.Count.ToString();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TbId.Text.Trim() != "" && TbNombres.Text.Trim() != "" && TbApellidos.Text.Trim() != "" && TbTelefono.Text.Trim() != "" && TbDireccion.Text.Trim() != "" && TbCorreo.Text.Trim() != "")
            {
                if (Cliente.ExisteClavePrimaria(new string[] { TbId.Text }))
                    Cliente.Actualizar(new string[] { TbId.Text, TbNombres.Text, TbApellidos.Text, TbDireccion.Text, TbTelefono.Text, TbCorreo.Text });
                else
                    Cliente.Insertar(new string[] { TbId.Text, TbNombres.Text, TbApellidos.Text, TbDireccion.Text, TbTelefono.Text, TbCorreo.Text });
                MessageBox.Show("Los datos se guardaron exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaClientes();
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

        private void TbId_Leave(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DgvClientes.CurrentCell = null; 
            int Valor = 0;
            switch (CbBuscar.Text)
            {
                case "ID Cliente":
                    Valor = 0;
                    break;
                case "Nombres":
                    Valor = 1;
                    break;
                case "Apellidos":
                    Valor = 2;
                    break;
                case "Dirección":
                    Valor = 3;
                    break;
                case "Telefono":
                    Valor = 4;
                    break;
                case "Correo":
                    Valor = 5;
                    break;
            }
            for (int k = 0; k < DgvClientes.Rows.Count; k++)
            {
                if(BuscarPalabraEnCadena(TbValorBusqueda.Text,DgvClientes.Rows[k].Cells[Valor].Value.ToString()))
                    DgvClientes.Rows[k].Visible = true;
                else
                    DgvClientes.Rows[k].Visible = false;
            }
                //--Mostrar el numero de clientes
              LblCant.Text = ContarClientesVisibles().ToString();

        }
        private bool BuscarPalabraEnCadena(string Palabra, string Cadena)
        {
            // Convertimos la cadena en texto normalizado sin tildes y sin ñ
            Cadena = Regex.Replace(Cadena.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
            // Normalizamos a la palabra
            Palabra = Regex.Replace(Palabra.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
            // Convertimos la cadena en solo minusculas
            string Minusculas = Cadena.ToLower();
            // Convertimos la cadena en solo mayusculas
            string Mayusculas = Cadena.ToUpper();
            if (Cadena.Contains(Palabra))
                return true;
            else
            {
                if (Minusculas.Contains(Palabra.ToLower()))
                    return true;
                else
                {
                    if (Mayusculas.Contains(Palabra.ToUpper()))
                        return true;
                    else
                        return false;
                }
            }
        }
        public int ContarClientesVisibles()
        {
            int cont = 0;
            for (int k = 0; k < DgvClientes.Rows.Count; k++)
                if (DgvClientes.Rows[k].Visible)
                    cont++;
            return cont;
        }
        /// <summary>
        /// Evento que cargar los datos de dgv en los componentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//--Determinar la fila que cambío
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            if (fila >= 0)
            {
                TbId.Text = DgvClientes.Rows[fila].Cells[0].Value.ToString();
                TbNombres.Text = DgvClientes.Rows[fila].Cells[1].Value.ToString();
                TbApellidos.Text = DgvClientes.Rows[fila].Cells[2].Value.ToString();
                TbDireccion.Text = DgvClientes.Rows[fila].Cells[3].Value.ToString();
                TbTelefono.Text = DgvClientes.Rows[fila].Cells[4].Value.ToString();
                TbCorreo.Text = DgvClientes.Rows[fila].Cells[5].Value.ToString();

                CbNuevoPed.Enabled = true;
                CbNuevoPed.Checked = false;
            }
        }

        private void CbNuevoPed_CheckedChanged(object sender, EventArgs e)
        {
            if (CbNuevoPed.Checked)
            {
                CargarIdCliente();
                DejarEnBlanco();
                CbNuevoPed.Enabled = false;
            }
        }

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CbNuevoPed.Checked = true;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DejarEnBlanco();
        }

        private void BtnMostrarTodo_Click(object sender, EventArgs e)
        {
            DgvClientes.CurrentCell = null;
            for (int k = 0; k < DgvClientes.Rows.Count; k++)
            {
                DgvClientes.Rows[k].Visible = true;
            }
            //--Mostrar el numero de clientes
            LblCant.Text =  ContarClientesVisibles().ToString();
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            Keys key = (Keys)e.KeyChar;
            //--Sila tecla no es digito o borrar, no se escribe
            if (!(char.IsDigit(e.KeyChar)) && !(key == Keys.Back))
                e.Handled = true;
        }
    }
}

