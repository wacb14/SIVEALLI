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
    public partial class FormProveedores : FormPadre
    {
        protected CProveedor aProveedor = new CProveedor();
        public FormProveedores()
        {
            InitializeComponent();
            IniciarEntidad(new CProveedor());
            EventosYValidaciones();
        }
        private void EventosYValidaciones()
        {
            this.Load += new EventHandler(CargarDatos);
            TxtCodigo.Leave += new EventHandler(AbandonarTextBoxCodigo);
        }
        private void AbandonarTextBoxCodigo(object sender, EventArgs e)
        {
            //Recuperar atributos, el primer atributo es la clave
            string[] Atributos = AsignarValoresAtributos();
            //Verificar si existe clave primaria
            if (aEntidad.ExisteClavePrimaria(1, Atributos))
            {
                MostrarDatos();
                aEntidad.Nuevo = false;
            }
            else
            {
                //Registro nuevo, incializar atributos no clave
                InicializarAtributosNoClave();
            }
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            DgvProveedores.DataSource = aEntidad.ListaGeneral();
        }
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodigo.Text,
                TxtNombres.Text, TxtDireccion.Text,
                TxtTelefono.Text, TxtCorreo.Text,
                CboEstado.Text};
        }
        public override void MostrarDatos()
        {
            TxtCodigo.Text = aEntidad.ValorAtributo("IdProveedor");
            TxtNombres.Text = aEntidad.ValorAtributo("Nombre");
            TxtDireccion.Text = aEntidad.ValorAtributo("Direccion");
            TxtTelefono.Text = aEntidad.ValorAtributo("Telefono");
            TxtCorreo.Text = aEntidad.ValorAtributo("Correo");
            CboEstado.Text = aEntidad.ValorAtributo("Estado");
        }
        public override void InicializarAtributoClave()
        {
            TxtCodigo.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            TxtNombres.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono.Text = "";
            TxtCorreo.Text = "";
            CboEstado.Text = "";

        }
        public override void ListarRegistros()
        {
            DgvProveedores.DataSource = aEntidad.ListaGeneral();
            LblNumeroProveedores.Text = LblNumeroProveedores.Text.Split(':')[0] + ": " + DgvProveedores.Rows.Count.ToString();

        }
        public override bool EsRegistroValido()
        {
            if (TxtCodigo.Text.Trim() != "" &&
                TxtNombres.Text.Trim() != "" &&
                TxtTelefono.Text.Trim() != "" &&
                TxtDireccion.Text.Trim() != "" &&
                TxtCorreo.Text.Trim() != "" &&
                CboEstado.Text.Trim() != "")
                return true;
            else
                return false;
        }
        // ========================= EVENTOS =======================
        private void TxtCodLibro_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            ListarRegistros();
            this.DgvProveedores.DefaultCellStyle.Font = new Font("Tahoma", 15);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            int cant = aEntidad.NumeroRegistros();
            string cantCeros = "";
            if (cant < 10)
                cantCeros = "00";
            else if (cant < 100)
                cantCeros = "0";
            InicializarAtributos();
            TxtCodigo.Text = "PR" + cantCeros + (cant + 1);

            TxtNombres.Focus();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            InicializarAtributos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Grabar(1);
        }
        public virtual void Grabar(int n)
        {
            try
            {
                if (EsRegistroValido())
                {
                    //Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //Verificar si existe clave primaria
                    if (aEntidad.ExisteClavePrimaria(n, Atributos))
                    {
                        aEntidad.Actualizar(Atributos);
                    }
                    else
                    {
                        aEntidad.Insertar(Atributos);
                    }
                    MessageBox.Show("Operacion realizada exitosamente", "Confirmacion");
                    InicializarAtributos();
                    ListarRegistros();
                }
                else
                    MessageBox.Show("Debe completar el llenado del formulario", "ALERTA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al realizar la operacion");
            }
        }

        public virtual void CambiarEstado(int n)
        {
            try
            {
                if (EsRegistroValido())
                {
                    //Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = { TxtCodigo.Text,
                    TxtNombres.Text, TxtDireccion.Text,
                    TxtTelefono.Text, TxtCorreo.Text,
                    "RETIRADO"};
                    //Verificar si existe clave primaria
                    if (aEntidad.ExisteClavePrimaria(n, Atributos))
                    {
                        aEntidad.Actualizar(Atributos);
                    }
                    else
                    {
                        aEntidad.Insertar(Atributos);
                    }
                    MessageBox.Show("Operacion realizada exitosamente", "Confirmacion");
                    InicializarAtributos();
                    ListarRegistros();
                }
                else
                    MessageBox.Show("Debe completar el llenado del formulario", "ALERTA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error al realizar la operacion");
            }
        }

        private void DgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (fila >= 0)
            {
                TxtCodigo.Text = DgvProveedores.Rows[fila].Cells[0].Value.ToString();
                TxtNombres.Text = DgvProveedores.Rows[fila].Cells[1].Value.ToString();
                TxtDireccion.Text = DgvProveedores.Rows[fila].Cells[2].Value.ToString();
                TxtTelefono.Text = DgvProveedores.Rows[fila].Cells[3].Value.ToString();
                TxtCorreo.Text = DgvProveedores.Rows[fila].Cells[4].Value.ToString();
                CboEstado.Text = DgvProveedores.Rows[fila].Cells[5].Value.ToString();
            }
        }

        private void BtnCambiarEstado_Click(object sender, EventArgs e)
        {
            CambiarEstado(1);
        }
    }
}
