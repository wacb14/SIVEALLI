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
    public partial class FormProveedores : FormPadre
    {
        #region Variables y inicio

        /// <summary>
        /// Variables: aProveedor Inicializa la tabla
        /// CargarRegistroValido se activa al hacer una busqueda pues genera columnas extra, luego se desactiva
        /// </summary>
        protected CProveedor aProveedor = new CProveedor();
        protected bool CargarRegistroValido = false;
        public FormProveedores()
        {
            InitializeComponent();
            IniciarEntidad(new CProveedor());
            EventosYValidaciones();
        }
        #endregion Variables y inicio

        #region Metodos

        /// <summary>
        /// Metodos de carga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        // Actualiza la tabla con un listado general
        private void CargarDatos(object sender, EventArgs e)
        {
            DgvProveedores.DataSource = aEntidad.ListaGeneral();
        }
        // Devuelve los valores de los text box
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodigo.Text,
                TxtNombres.Text, TxtDireccion.Text,
                TxtTelefono.Text, TxtCorreo.Text,
                CboEstado.Text};
        }
        // Muestra Datos
        public override void MostrarDatos()
        {
            TxtCodigo.Text = aEntidad.ValorAtributo("IdProveedor");
            TxtNombres.Text = aEntidad.ValorAtributo("Nombre");
            TxtDireccion.Text = aEntidad.ValorAtributo("Direccion");
            TxtTelefono.Text = aEntidad.ValorAtributo("Telefono");
            TxtCorreo.Text = aEntidad.ValorAtributo("Correo");
            CboEstado.Text = aEntidad.ValorAtributo("Estado");
        }
        // Inicializa el atributo clave (el codigo)
        public override void InicializarAtributoClave()
        {
            TxtCodigo.Text = "";
        }
        // Inicializa los atributos no clave
        public override void InicializarAtributosNoClave()
        {
            TxtNombres.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono.Text = "";
            TxtCorreo.Text = "";
            CboEstado.Text = "";

        }
        // Hace un listado con el numero de proveedores en la tabla
        public override void ListarRegistros()
        {
            DgvProveedores.DataSource = aEntidad.ListaGeneral();
            LblNumeroProveedores.Text = LblNumeroProveedores.Text.Split(':')[0] + ": " + DgvProveedores.Rows.Count.ToString();

        }
        // Valida que no haya registros en blanco
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
        /// <summary>
        /// Metodos de operacion
        /// </summary>
        /// <param name="n"></param>
        // Sirve para el boton guardar
        // Valida y agrega el registro a la BD
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
        // Sirve para el boton marcar inactivo, cambia el estado a "retirado" que es cuado esta inactivo
        // Valida y actualiza el registro de la BD
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
        // Sirve para el boton de Busqueda
        // Realiza una busqueda, lo hara incluso si el texto es incompleto o si esta en mayuscula o minuscula
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

        #endregion Metodos

        #region Eventos

        /// <summary>
        /// Eventos 
        /// </summary>
        // Al iniciar carga los datos
        private void EventosYValidaciones()
        {
            this.Load += new EventHandler(CargarDatos);
        }
        // Valida que el telefono sea solo numeros
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
        // Lista los registros que haya en la BD al iniciar
        private void FormProveedores_Load(object sender, EventArgs e)
        {
            ListarRegistros();
            CboBuscarPor.Text = "Id Proveedor";
        }
        // Mostrara la informacion del DGV a los text box, util para rellenar datos y ver o modificar
        private void DgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception l)
            {
                MessageBox.Show(l.ToString(), "Error al realizar la operacion");
            }

        }

        private void PrdDgv_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                // Crear el objeto
                Bitmap objetoBitmap = new Bitmap(this.DgvProveedores.Width, this.DgvProveedores.Height);
                // Colocar la lista
                DgvProveedores.DrawToBitmap(objetoBitmap, new Rectangle(0, 0, this.DgvProveedores.Width, this.DgvProveedores.Height));
                // 100 y 50 imprima 100 abajo y 50 a la derecha
                e.Graphics.DrawImage(objetoBitmap, 50, 100);
                // Colocar titulo a la lista con fuente TNR 20 negro en la parte superior
                e.Graphics.DrawString("Lista actual de Proveedores", new Font("Times new Roman", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            }
            catch (Exception l)
            {
                MessageBox.Show(l.ToString(), "Error al realizar la operacion");
            }

        }

        #endregion Eventos

        #region Botones

        /// <summary>
        /// Botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Cuando se agrega un nuevo proveedor
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // Coloca a los proveedores con el formato PR al inicio
                int cant = aEntidad.NumeroRegistros();
                string cantCeros = "";
                if (cant < 9)
                    cantCeros = "00";
                else if (cant < 99)
                    cantCeros = "0";
                InicializarAtributos();
                TxtCodigo.Text = "PR" + cantCeros + (cant + 1);
                // Despues de generar el codigo se enfoca en nombre
                TxtNombres.Focus();
            }
            catch (Exception l)
            {
                MessageBox.Show(l.ToString(), "Error al realizar la operacion");
            }

        }
        // Vacia los text box
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                InicializarAtributos();
            }
            catch (Exception l)
            {
                MessageBox.Show(l.ToString(), "Error al realizar la operacion");
            }

        }
        // Guarda los datos validados en la BD y en la tabla
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Existe una busqueda
                if (CargarRegistroValido)
                {
                    //Limpiar posibles datos sobrantes
                    DgvProveedores.Columns.Clear();
                    DgvProveedores.Rows.Clear();
                }
                Grabar(1);
                CargarRegistroValido = false;
            }
            catch (Exception l)
            {
                MessageBox.Show(l.ToString(), "Error al realizar la operacion");
            }

        }
        /*
        // Actualiza el estado a "retirado"
        private void BtnCambiarEstado_Click(object sender, EventArgs e)
        {
            //Existe una busqueda
            if (CargarRegistroValido)
            {
                //Limpiar posibles datos sobrantes
                DgvProveedores.Columns.Clear();
                DgvProveedores.Rows.Clear();
            }
            CambiarEstado(1);
            CargarRegistroValido = false;
        }
        */
        // Carga toda la tabla, util despues de realizar una busqueda
        private void BtnCargarTabla_Click(object sender, EventArgs e)
        {
            try
            {
                //Existe una busqueda
                if (CargarRegistroValido)
                {
                    //Limpiar posibles datos sobrantes
                    DgvProveedores.Columns.Clear();
                    DgvProveedores.Rows.Clear();
                }
                //Volver a estado base
                CargarRegistroValido = false;
                //Llenar tabla
                ListarRegistros();
                LblNumeroProveedores.Text = LblNumeroProveedores.Text.Split(':')[0] + ": " + DgvProveedores.Rows.Count.ToString();
            }
            catch (Exception l)
            {
                MessageBox.Show(l.ToString(), "Error al realizar la operacion");
            }


        }
        // Busca por atributo con mucha libertad de escritura
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se hizo una busqueda
                CargarRegistroValido = true;
                //Limpiar registro
                DgvProveedores.DataSource = null;
                DgvProveedores.Columns.Clear();
                DgvProveedores.Rows.Clear();
                // Generar lista de todos los elementos
                DataTable Lista = aEntidad.ListaGeneral();
                string Valor = string.Empty;
                // Varia dependiendo del atributo de busqueda marcado
                switch (CboBuscarPor.Text)
                {
                    case "ID Proveedor":
                        Valor = "IdProveedor";
                        break;
                    case "Nombre":
                        Valor = "Nombre";
                        break;
                    case "Direccion":
                        Valor = "Direccion";
                        break;
                    case "Telefono":
                        Valor = "Telefono";
                        break;
                    case "Correo":
                        Valor = "Correo";
                        break;
                    case "Estado":
                        Valor = "Estado";
                        break;
                }
                //Agregar nuevas columnas de busqueda
                DgvProveedores.Columns.Add("IdProveedor", "IdProveedor");
                DgvProveedores.Columns.Add("Nombre", "Nombre");
                DgvProveedores.Columns.Add("Direccion", "Direccion");
                DgvProveedores.Columns.Add("Telefono", "Telefono");
                DgvProveedores.Columns.Add("Correo", "Correo");
                DgvProveedores.Columns.Add("Estado", "Estado");
                // Buscar en la lista generada y agregar el valor al DGV
                for (int i = 0; i < Lista.Rows.Count; i++)
                {
                    string ValorProd = Lista.Rows[i][Valor].ToString();
                    if (BuscarPalabraEnCadena(TxtValorBusqueda.Text, ValorProd))
                    {
                        string IdProv = Lista.Rows[i]["IdProveedor"].ToString();
                        string Nombre = Lista.Rows[i]["Nombre"].ToString();
                        string Direccion = Lista.Rows[i]["Direccion"].ToString();
                        string Telefono = Lista.Rows[i]["Telefono"].ToString();
                        string Correo = Lista.Rows[i]["Correo"].ToString();
                        string Estado = Lista.Rows[i]["Estado"].ToString();
                        DgvProveedores.Rows.Add(IdProv, Nombre, Direccion, Telefono, Correo, Estado);
                    }
                }
                //Actualizar Numero total de proveedores
                LblNumeroProveedores.Text = LblNumeroProveedores.Text.Split(':')[0] + ": " + DgvProveedores.Rows.Count.ToString();
            }
            catch (Exception l)
            {
                MessageBox.Show(l.ToString(), "Error al realizar la operacion");
            }

        }
        // Procede a imprimir el DGV se aproya con el evento de PrdDgv
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                //Print preview Dialog
                Ppd1.Document = PrdDgv;
                Ppd1.ShowDialog();
            }
            catch (Exception l)
            {
                MessageBox.Show(l.ToString(), "Error al realizar la operacion");
            }

        }
        // Cierra el panel
        private void PbCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception l)
            {
                MessageBox.Show(l.ToString(), "Error al realizar la operacion");
            }

        }

        #endregion Botones

    }
}
