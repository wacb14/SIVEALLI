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
using System.IO;

namespace SIVEALLI
{
    public partial class FormProductos : Form
    {
        //----------ATRIBUTOS--------------------
        CProducto Producto = new CProducto();
        string RutaCarpetaImagenes = "C:\\Users\\Lenovo\\Desktop\\Libreria";

        public FormProductos()
        {
            InitializeComponent();
            CargarListaProductos();
            TxtIdProducto.Text = GenerarIdProducto();
        }
        //--------------------------------------------------------------------------------------
        /// <summary>
        /// Recupera informacion de un producto en base al ID del producto
        /// </summary>
        public void CargarDatosProducto()
        {
            if (Producto.ExisteClavePrimaria(new string[] { TxtIdProducto.Text }))
            {
                TxtIdProducto.Text = Producto.ValorAtributo("IdProducto");
                TxtNombre.Text = Producto.ValorAtributo("Nombre");
                TxtCategoria.Text = Producto.ValorAtributo("Categoria");
                TxtDescripcion.Text = Producto.ValorAtributo("Descripcion");
                TxtMarca.Text = Producto.ValorAtributo("Marca");
                TxtPrecioUnitario.Text = Producto.ValorAtributo("PrecioUnitario");
                CboEstado.Text = Producto.ValorAtributo("Estado");
                NudMinimo.Value = decimal.Parse(Producto.ValorAtributo("Minimo"));
                NudMaximo.Value = decimal.Parse(Producto.ValorAtributo("Maximo"));
                PctBImagen.Load(RutaCarpetaImagenes +"\\"+ Producto.ValorAtributo("Imagen"));
                OfdImagen.FileName = "";
            }
        }
        /// <summary>
        /// Genera automaticamente el ID de un producto basado enlos registros de la base de datos
        /// </summary>
        /// <returns></returns>
        private string GenerarIdProducto()
        {
            string Id = "PR";
            string NumeroProductos = (Producto.NumeroDeProductos() + 1).ToString();
            for (int i = 0; i < 6 - NumeroProductos.Length; i++)
                Id += "0";
            Id += NumeroProductos;
            return Id;
        }
        
        /// <summary>
        /// Deja los campos del formulario del producto en blanco
        /// </summary>
        private void LimpiarCajas()
        {
            TxtIdProducto.Text = GenerarIdProducto();
            TxtNombre.Clear();
            TxtCategoria.Clear();
            TxtDescripcion.Clear();
            TxtMarca.Clear();
            TxtPrecioUnitario.Clear();
            PctBImagen.ImageLocation = "";
            CboEstado.Text = "";
            NudMinimo.Value = 0;
            NudMaximo.Value = 0;
            PctBImagen.Image = null;
            OfdImagen.FileName = "";
        }
        /// <summary>
        /// Bloquea los campos del formulario de producto
        /// </summary>
        private void BloquearCajas()
        {
            TxtNombre.Enabled = false;
            TxtCategoria.Enabled = false;
            TxtDescripcion.Enabled = false;
            TxtMarca.Enabled = false;
            TxtPrecioUnitario.Enabled = false;
            BtnNuevaImagen.Enabled = false;
            CboEstado.Enabled = false;
            NudMinimo.Enabled = false;
            NudMaximo.Enabled = false;
        }
        /// <summary>
        /// Desbloquea los campos del formulario de producto
        /// </summary>
        private void DesbloquearCajas()
        {
            TxtNombre.Enabled = true;
            TxtCategoria.Enabled = true;
            TxtDescripcion.Enabled = true;
            TxtMarca.Enabled = true;
            TxtPrecioUnitario.Enabled = true;
            BtnNuevaImagen.Enabled = true;
            CboEstado.Enabled = true;
            NudMinimo.Enabled = true;
            NudMaximo.Enabled = true;
        }
        /// <summary>
        /// Carga el DataGridview con la lista de productos
        /// </summary>
        public void CargarListaProductos()
        {
            DgvProductos.DataSource = Producto.ListaGeneralSinImagen();
            //--Mostrar el numero de productos disponibles
            LblTotalProductos.Text = DgvProductos.Rows.Count.ToString();
        }
        /// <summary>
        /// Actualiza la imagen del producto en la carpeta de imagenes
        /// </summary>
        /// <param name="NombreImagen"></param>
        public void ActualizarNuevaImagen(string NombreImagen)
        {
            // Guardamos la nueva imagen
            string RutaOrigenArchivo = OfdImagen.FileName;
            string RutaNueva = RutaCarpetaImagenes + "\\" + NombreImagen;
            File.Copy(RutaOrigenArchivo, RutaNueva, true);
        }
        /// <summary>
        /// Guarda una nueva imagen del producto en la carpeta de imagenes
        /// </summary>
        /// <param name="NombreImagen"></param>
        public void GuardarNuevaImagen(string NombreImagen)
        {
            string RutaOrigenArchivo = OfdImagen.FileName;
            string RutaNueva = RutaCarpetaImagenes + "\\" + NombreImagen;
            try
            {
                File.Copy(RutaOrigenArchivo, RutaNueva, false);
            }
            catch(IOException e)
            {
                MessageBox.Show(e.Message+" (Ya existe una imagen con el mismo nombre, modifique el nombre de su imagen por favor)");
            }
        }
        /// <summary>
        /// Deja el formulario listo para un nuevo ingreso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            DesbloquearCajas();
            LimpiarCajas();
        }

        /// <summary>
        /// Permite modificar los campos de un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            DesbloquearCajas();
        }

        /// <summary>
        /// Guarda o modifica los datos de un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (PctBImagen.Image != null)
                {
                    if (TxtIdProducto.Text.Trim() != "" && TxtNombre.Text.Trim() != "" && TxtCategoria.Text.Trim() != "" && TxtDescripcion.Text.Trim() != "" && TxtMarca.Text.Trim() != "" && TxtPrecioUnitario.Text.Trim() != "" && CboEstado.Text.Trim() != "")
                    {
                        if (Producto.ExisteClavePrimaria(new string[] { TxtIdProducto.Text }))
                        {
                            //Para mantener la cantidad
                            string Cantidad = Producto.ValorAtributo("Cantidad");
                            string NombreImagen = Producto.ValorAtributo("Nombre") + Path.GetExtension(OfdImagen.FileName);
                            if (OfdImagen.FileName != "")
                            { //Este es el caso cuando hay un cambio de imagen

                                Producto.Actualizar(new string[] { TxtIdProducto.Text.Trim(), TxtNombre.Text.Trim(), TxtCategoria.Text.Trim(), TxtDescripcion.Text.Trim(), TxtMarca.Text.Trim(), TxtPrecioUnitario.Text.Trim(), NombreImagen, CboEstado.Text.Trim(), Cantidad, NudMaximo.Value.ToString().Trim(), NudMinimo.Value.ToString().Trim() });
                                ActualizarNuevaImagen(NombreImagen);
                            }
                            else
                            { // Se mantiene la imagen anterior
                                string Imagen = Producto.ValorAtributo("Imagen");
                                Producto.Actualizar(new string[] { TxtIdProducto.Text.Trim(), TxtNombre.Text.Trim(), TxtCategoria.Text.Trim(), TxtDescripcion.Text.Trim(), TxtMarca.Text.Trim(), TxtPrecioUnitario.Text.Trim(), Imagen, CboEstado.Text.Trim(), Cantidad, NudMaximo.Value.ToString().Trim(), NudMinimo.Value.ToString().Trim() });
                            }
                        }
                        else
                        {
                            string NombreImagen = TxtNombre.Text.Trim() + Path.GetExtension(OfdImagen.FileName);
                            Producto.Insertar(new string[] { TxtIdProducto.Text.Trim(), TxtNombre.Text.Trim(), TxtCategoria.Text.Trim(), TxtDescripcion.Text.Trim(), TxtMarca.Text.Trim(), TxtPrecioUnitario.Text.Trim(), NombreImagen, CboEstado.Text.Trim(), "0", NudMaximo.Value.ToString().Trim(), NudMinimo.Value.ToString().Trim() });
                            GuardarNuevaImagen(NombreImagen);
                            OfdImagen.FileName = "";
                        }
                        MessageBox.Show("Los datos se guardaron exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarListaProductos();
                    }
                    else
                        MessageBox.Show("Todos los campos deben tener algun valor", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Seleccione una imagen para el producto", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        /// <summary>
        /// Restaura la lista completa de productos en el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRestaurarLista_Click(object sender, EventArgs e)
        {
            CargarListaProductos();
        }
        /// <summary>
        /// Realiza la busqueda en la base datos y muestra los resultados en el DataGridView de acuerdo al Buscar por
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            switch (CboBuscarPor.Text.Trim())
            {
                case "ID Producto":
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text.Trim(), "IdProducto");
                    break;
                case "Nombre":
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text.Trim(), "Nombre");
                    break;
                case "Categoria":
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text.Trim(), "Categoria");
                    break;
                case "Marca":
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text.Trim(), "Marca");
                    break;
                case "Precio Unitario":
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text.Trim(), "PrecioUnitario");
                    break;
                case "Estado":
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text.Trim(), "Estado");
                    break;
            }
            //-- Mostrar el numero de productos disponibles
            LblTotalProductos.Text = DgvProductos.Rows.Count.ToString();
        }
        /// <summary>
        /// Permite seleccionar una nueva imagen y la coloca en el picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNuevaImagen_Click(object sender, EventArgs e)
        {
            OfdImagen.InitialDirectory = RutaCarpetaImagenes;
            DialogResult Resultado = OfdImagen.ShowDialog();
            if (Resultado == DialogResult.OK)
            {
                string RutaImagen = OfdImagen.FileName;
                PctBImagen.Load(RutaImagen);
            }
        }
        /// <summary>
        /// Muestra la informacion del producto seleccionado en el formulario izquierdo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = DgvProductos.CurrentCell.RowIndex;
            string Id = DgvProductos.Rows[fila].Cells["IdProducto"].Value.ToString();
            TxtIdProducto.Text = Id;
            CargarDatosProducto();
            BloquearCajas();
        }
        /// <summary>
        /// Valida que se ingrese numeros reales en un textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidarCadenaReales(object sender, KeyPressEventArgs e)
        {
            TextBox Caja = sender as TextBox;

            if (!(char.IsDigit(e.KeyChar)))
            {
                //Aprobamos que teclas aparte de los digitos deseamos aceptar, excepto el punto que se cosidera una cifra numerica
                Keys key = (Keys)e.KeyChar;
                if (!(key == Keys.Back || key == Keys.Delete || key == Keys.Enter))
                {
                    //Esto indica que ya se ha procesado
                    e.Handled = true;
                }
                else
                {
                    //Casos espciales del punto
                    if (e.KeyChar == '.')
                    {
                        //Si la caja de texto está vacia no escribe el punto
                        if (Caja.Text == "")
                            e.Handled = true;
                        else
                        {
                            //Condicion en la que se comprueba si ya se ha escrito el punto
                            if (Caja.Text.IndexOf('.') != -1)
                            {
                                e.Handled = true;
                            }
                        }
                    }
                }
            }
            //Validamos que solo escriba cero despues de otro numero
            else
            {
                //Cuando la caja de texto este vacia no se puede escribir el cero
                if (Caja.Text == "0")
                {
                    //El cero solo se escribe luego de que exista otro numero en la caja de texto
                    if (e.KeyChar == '0')
                        e.Handled = true;
                }
            }
        }
        /// <summary>
        /// Se valida el ingreso de numeros reales en el campo de precio unitario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCadenaReales(sender, e);
        }
    }
}