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
    public partial class FormProductos : Form
    {
        //----------ATRIBUTOS--------------------
        CProducto Producto = new CProducto();
        
        public FormProductos()
        {
            InitializeComponent();
            CargarListaProductos();
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
                PctBImagen.ImageLocation = Producto.ValorAtributo("Imagen");
                CboEstado.Text = Producto.ValorAtributo("Estado");
            }
        }
        /// <summary>
        /// Deja los campos del formulario del producto en blanco
        /// </summary>
        private void LimpiarCajas()
        {
            TxtIdProducto.Clear();
            TxtNombre.Clear();
            TxtCategoria.Clear();
            TxtDescripcion.Clear();
            TxtMarca.Clear();
            TxtPrecioUnitario.Clear();
            PctBImagen.ImageLocation = "";
            CboEstado.Text = "";
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
        }

        /// <summary>
        /// Desbloquea los campos del formulario de producto
        /// </summary>
        private void DesbloquearCajas()
        {
            TxtNombre.Enabled = true;
            TxtCategoria.Enabled = true;
            TxtDescripcion.Enabled = true;
            TxtMarca.Enabled =true;
            TxtPrecioUnitario.Enabled = true;
            BtnNuevaImagen.Enabled = true;
            CboEstado.Enabled = true;
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

        //------ Eventos ------
        /// <summary>
        /// Carga los datos de un producto en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtIdProducto_Leave(object sender, EventArgs e)
        {
            CargarDatosProducto();
            BloquearCajas();
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
            if (TxtIdProducto.Text.Trim() != "" && TxtNombre.Text.Trim() != "" && TxtCategoria.Text.Trim() != "" && TxtDescripcion.Text.Trim() != "" && TxtMarca.Text.Trim() != "" && TxtPrecioUnitario.Text.Trim() != "" && PctBImagen.ImageLocation.Trim() != "" && CboEstado.Text.Trim() != "")
            {
                if (Producto.ExisteClavePrimaria(new string[] { TxtIdProducto.Text }))
                    Producto.Actualizar(new string[] { TxtIdProducto.Text.Trim(), TxtNombre.Text.Trim(), TxtCategoria.Text.Trim(), TxtDescripcion.Text.Trim(), TxtMarca.Text.Trim(), TxtPrecioUnitario.Text.Trim(), PctBImagen.ImageLocation.Trim(), CboEstado.Text.Trim() });
                else
                    Producto.Insertar(new string[] { TxtIdProducto.Text.Trim(), TxtNombre.Text.Trim(), TxtCategoria.Text.Trim(), TxtDescripcion.Text.Trim(), TxtMarca.Text.Trim(), TxtPrecioUnitario.Text.Trim(), PctBImagen.ImageLocation.Trim(), CboEstado.Text.Trim() });
                MessageBox.Show("Los datos se guardaron exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListaProductos();
            }
            else MessageBox.Show("Todos los campos deben tener algun valor", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

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
                    DgvProductos.DataSource = Producto.BuscarPorAtributo(TxtValorBusqueda.Text,"IdProducto");
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
    }
}
