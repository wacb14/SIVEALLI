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
                PctBImagen.Image = RecuperarImagen(TxtIdProducto.Text);
                OfdImagen.FileName = "";
            }
        }
        private Image RecuperarImagen(string IdProducto)
        {
            byte[] DataImagen = Producto.RecuperarImagen(IdProducto);

            Image newImage = null;
            // Trata la información de la imagen para poder trasladarla al picturebox
            using (MemoryStream ms = new MemoryStream(DataImagen, 0, DataImagen.Length))
            {
                ms.Write(DataImagen, 0, DataImagen.Length);
                newImage = Image.FromStream(ms, true);
            }
            return newImage;
        }
        private string GenerarIdProducto()
        {
            string Id = "PR";
            string NumeroProductos = (Producto.NumeroDeProductos() + 1).ToString();
            for (int i = 0; i < 6 - NumeroProductos.Length; i++)
                Id += "0";
            Id += NumeroProductos;
            return Id;
        }
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
            if (PctBImagen.Image != null)
            {
                if (TxtIdProducto.Text.Trim() != "" && TxtNombre.Text.Trim() != "" && TxtCategoria.Text.Trim() != "" && TxtDescripcion.Text.Trim() != "" && TxtMarca.Text.Trim() != "" && TxtPrecioUnitario.Text.Trim() != "" && CboEstado.Text.Trim() != "")
                {
                    if (Producto.ExisteClavePrimaria(new string[] { TxtIdProducto.Text }))
                    {
                        //Para mantener la cantidad
                        string Cantidad = Producto.ValorAtributo("Cantidad");
                        if (OfdImagen.FileName != "")
                        { //Este es el caso cuando hay un cambio de imagen
                            Producto.Actualizar(new string[] { TxtIdProducto.Text.Trim(), TxtNombre.Text.Trim(), TxtCategoria.Text.Trim(), TxtDescripcion.Text.Trim(), TxtMarca.Text.Trim(), TxtPrecioUnitario.Text.Trim(), null, CboEstado.Text.Trim(), Cantidad, NudMaximo.Value.ToString().Trim(), NudMinimo.Value.ToString().Trim() });
                            Producto.ActualizarImagen(TxtIdProducto.Text.Trim(), File.ReadAllBytes(OfdImagen.FileName));
                        }
                        else
                        { // Se mantiene la imagen anterior
                            byte[] Imagen = Producto.RecuperarImagen(TxtIdProducto.Text.Trim());
                            Producto.Actualizar(new string[] { TxtIdProducto.Text.Trim(), TxtNombre.Text.Trim(), TxtCategoria.Text.Trim(), TxtDescripcion.Text.Trim(), TxtMarca.Text.Trim(), TxtPrecioUnitario.Text.Trim(), null, CboEstado.Text.Trim(), Cantidad, NudMaximo.Value.ToString().Trim(), NudMinimo.Value.ToString().Trim() });
                            Producto.ActualizarImagen(TxtIdProducto.Text.Trim(), Imagen);
                        }
                    }
                    else
                    {
                        Producto.Insertar(new string[] { TxtIdProducto.Text.Trim(), TxtNombre.Text.Trim(), TxtCategoria.Text.Trim(), TxtDescripcion.Text.Trim(), TxtMarca.Text.Trim(), TxtPrecioUnitario.Text.Trim(), null, CboEstado.Text.Trim(), "0", NudMaximo.Value.ToString().Trim(), NudMinimo.Value.ToString().Trim() });
                        Producto.ActualizarImagen(TxtIdProducto.Text.Trim(), File.ReadAllBytes(OfdImagen.FileName));
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

        private void BtnRestaurarLista_Click(object sender, EventArgs e)
        {
            CargarListaProductos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            switch (CboBuscarPor.Text.Trim())
            {
                case "ID Producto":
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text, "IdProducto");
                    break;
                case "Nombre":
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text, "Nombre");
                    break;
                case "Categoria":
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text, "Categoria");
                    break;
                case "Marca":
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text, "Marca");
                    break;
                case "Precio Unitario":
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text, "PrecioUnitario");
                    break;
                case "Estado":
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text, "Estado");
                    break;
            }
            //-- Mostrar el numero de prodcutos disponibles
            LblTotalProductos.Text = DgvProductos.Rows.Count.ToString();
        }
        private void BtnNuevaImagen_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = OfdImagen.ShowDialog();
            if (Resultado == DialogResult.OK)
            {
                string RutaImagen = OfdImagen.FileName;
                PctBImagen.Load(RutaImagen);
            }
        }

        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = DgvProductos.CurrentCell.RowIndex;
            string Id = DgvProductos.Rows[fila].Cells["IdProducto"].Value.ToString();
            TxtIdProducto.Text = Id;
            CargarDatosProducto();
            BloquearCajas();
        }

        private void TxtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCadenaReales(sender, e);
        }
    }
}