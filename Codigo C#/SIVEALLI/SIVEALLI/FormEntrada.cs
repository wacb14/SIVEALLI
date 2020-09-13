using BibClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIVEALLI
{
    public partial class FormEntrada : FormPadre
    {
        CProveedor proveedor = new CProveedor();
        CProducto producto = new CProducto();
        CEntrada entrada = new CEntrada();
        CEntradaDetalle entDet = new CEntradaDetalle();

        string codigoUsuario;
        string aFecha;

        public FormEntrada(string usuario, string fecha)
        {
            InitializeComponent();
            IniciarEntidad(new CEntrada());
            EventosYValidaciones();

            this.codigoUsuario = usuario;
            aFecha = fecha;
        }

        private void EventosYValidaciones()
        {
            this.Load += new EventHandler(LLenarDatosControles);
            this.BtnNuevaEntrada.Click += new EventHandler(GenerarNuevoCodigoEntrada);
            this.BtnAniadir.Click += new EventHandler(AgregarProductoDetalle);
            //this.buttonEditar.Click += new EventHandler(HabilitarEdicionDataGrid);
            this.buttonEliminarDetalle.Click += new EventHandler(EliminarEntradaDetalle);
            this.buttonListo.Click += new EventHandler(GuardarEntrada);
            this.TbCodigoEntradaH.Leave += new EventHandler(CargarDatosEntrada);
            //this.tbCodigoEntrada.selec += new EventHandler(CargarDatosEntrada);
            this.buttonLimpiar.Click += new EventHandler(LimpiarForm);
            this.dgvDetalleEntrada.CellClick += new DataGridViewCellEventHandler(EditarCantidad);
            this.BtnBuscar.Click += new EventHandler(BuscarPorCampo);
            this.DgvBusquedaEntrada.CellClick += new DataGridViewCellEventHandler(MostrarDetallesBusquedaEntrada);

            this.CbCodigoProducto.DropDown += new EventHandler(CargarDatosProductos);
            this.comboBoxCodigoProveedor.DropDown += new EventHandler(CargarDatosProveedores);
            //this.tbCodigoEntrada.DropDown += new EventHandler(CargarCodigosEntrada);
        }

        private void MostrarDetallesBusquedaEntrada(object sender, DataGridViewCellEventArgs e)
        {
            DgvListaDellesH.Rows.Clear();

            try
            {
                int fila = DgvBusquedaEntrada.CurrentCell.RowIndex;

                TbCodigoEntradaH.Text = DgvBusquedaEntrada.Rows[fila].Cells[0].Value.ToString();
                TbProveedorH.Text = DgvBusquedaEntrada.Rows[fila].Cells[1].Value.ToString();
                TbSupervisorH.Text = DgvBusquedaEntrada.Rows[fila].Cells[2].Value.ToString();
                DtpFechaH.Value = Convert.ToDateTime(DgvBusquedaEntrada.Rows[fila].Cells[3].Value.ToString());

                //Hallamos el codigo de entrada
                DataTable detallesBusqueda = entDet.ListaGeneralCod(DgvBusquedaEntrada.Rows[fila].Cells[0].Value.ToString());

                string nombre = "";
                string id = "";
                string categoria = "" , marca = "", precio = "";

                for (int i = 0; i < detallesBusqueda.Columns.Count; i++)
                {
                    DataTable dt = producto.DatosProductoEntrada(detallesBusqueda.Rows[i][1].ToString());
                    nombre = producto.ValorAtributo("Nombre");
                    id = producto.ValorAtributo("IdProducto");
                    categoria = producto.ValorAtributo("Categoria");
                    marca = producto.ValorAtributo("Marca");
                    precio = producto.ValorAtributo("PrecioUnitario");
                    DgvListaDellesH.Rows.Add(new string[] { id, nombre, categoria, marca, precio, 
                        detallesBusqueda.Rows[i][2].ToString() });
                }
            }
            catch(Exception)
            {

            }
        }

        private void BuscarPorCampo(object sender, EventArgs e)
        {
            DgvBusquedaEntrada.DataSource = null;
            DgvBusquedaEntrada.Rows.Clear();

            DataTable Lista =  aEntidad.ListaGeneral(); // Validamos que solo se muestren productos activos
            string Valor = string.Empty;
            switch (CbBuscarPor.Text)
            {
                case "Id Entrada":
                    Valor = "IdEntrada";
                    break;
                case "Id Proveedor":
                    Valor = "IdProveedor";
                    break;
                case "Id Usuario":
                    Valor = "IdUsuario";
                    break;
                case "Fecha":
                    Valor = "Fecha";
                    break;
            }

            
            DataTable tablaMostrar = Lista.Clone();
            for (int i = 0; i < Lista.Rows.Count; i++)
            {
                string ValorProd = Lista.Rows[i][Valor].ToString();
                if (Procesos.BuscarPalabraEnCadena(TbValorBusqueda.Text, ValorProd))
                {
                    tablaMostrar.ImportRow(Lista.Rows[i]);
                }
            }
            
            DgvBusquedaEntrada.DataSource = tablaMostrar;
            //DgvBusquedaEntrada.DataSource = Lista;
        }

        private void EditarCantidad(object sender, DataGridViewCellEventArgs e)
        {
            //-- Determinar las coordenadas de la celda que cambio
            try
            {
                int fila = e.RowIndex;
                int col = e.ColumnIndex;

                if (col == 5)
                {

                    FormVentasCantidad Cant = new FormVentasCantidad(1000000);
                    Cant.ShowDialog();
                    string Cantidad = Cant.GetCantidad.ToString();
                    dgvDetalleEntrada.Rows[fila].Cells[col].Value = Cantidad;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Imposible editar campo", "ERROR");
            }
        }

        /*
        private void CargarCodigosEntrada(object sender, EventArgs e)
        {
            LlenarCodigoEntradas();
        }
        */

        private void CargarDatosProveedores(object sender, EventArgs e)
        {
            LlenarDatosProveedores();
        }

        private void CargarDatosProductos(object sender, EventArgs e)
        {
            LlenarCodigoProductos();
        }

        private void LimpiarForm(object sender, EventArgs e)
        {
            LimpiarDatosFormulario();
        }

        private void LimpiarDatosFormulario()
        {
            //dtpFecha.Value = DateTime.Now;
            numericUpDownCantidad.Value = 1;
            dgvDetalleEntrada.DataSource = null;
            dgvDetalleEntrada.Rows.Clear();
            //textBoxUsuario.Text = codigoUsuario;
            CbCodigoProducto.SelectedIndex = -1;
            comboBoxCodigoProveedor.SelectedIndex = -1;
            tbCodigoEntrada.Text = "";
        }

        private void CargarDatosEntrada(object sender, EventArgs e)
        {
            if (aEntidad.ExisteClavePrimaria(TbCodigoEntradaH.Text))
            {
                ProcesarClave();

                CargarDatosEntradaDetalle();
            }
            else
            {
                tbCodigoEntrada.Text = "";
                LimpiarDatosFormulario();
                MessageBox.Show("Código de entrada no encontrado");
            }
        }

        private void CargarDatosEntradaDetalle()
        {
            DgvListaDellesH.DataSource = null;
            DgvListaDellesH.Rows.Clear();

            DataTable detallesentrada = entDet.ListaGeneralCod(TbCodigoEntradaH.Text.ToString());
            for (int i = 0; i < detallesentrada.Rows.Count; i++)
            {
                DataTable dt = producto.DatosProductoEntrada(detallesentrada.Rows[i][1].ToString());
                string[] datos = new string[dt.Columns.Count + 1];

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    datos[j] = dt.Rows[0][j].ToString();
                }
                datos[dt.Columns.Count] = detallesentrada.Rows[i][2].ToString() + "";

                DgvListaDellesH.Rows.Add(datos);
            }
        }

        private void GuardarEntrada(object sender, EventArgs e)
        {
            //Graba los datos generales de la entrada
            Grabar();

            //Guarda los datos de la tabla (dataGridView)
            GuardarEntradaDetalle();
        }

        private void GuardarEntradaDetalle()
        {
            string codEntrada = tbCodigoEntrada.Text;
            string codProducto;
            string cantidad;

            //eliminamos las antiguas entradas
            entDet.EliminarRegistros(codEntrada);

            for (int i = 0; i < dgvDetalleEntrada.Rows.Count; i++)
            {
                codProducto = dgvDetalleEntrada.Rows[i].Cells[0].Value.ToString();
                cantidad = dgvDetalleEntrada.Rows[i].Cells[5].Value.ToString();
                entDet.Insertar(new string[] { codEntrada, codProducto, cantidad });
            }
        }

        public override bool EsRegistroValido()
        {
            if (comboBoxCodigoProveedor.Text.Trim() != "" &&
                tbCodigoEntrada.Text.Trim() != "" &&
                dgvDetalleEntrada.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public override string[] AsignarValoresAtributos()
        {

            string proveedor = "";
            if (comboBoxCodigoProveedor.SelectedValue == null)
                proveedor = "";
            else
                proveedor = comboBoxCodigoProveedor.SelectedValue.ToString();

            //validamos texto combo box entrada con el valor elegido
            //esto debido a que las operaciones de cargar entrada y nueva entrada
            //toman diferentes valores
            string codigoEntrada = tbCodigoEntrada.Text;

            //MessageBox.Show(cbCodigoEntrada.SelectedValue.ToString());
            return new string[] { codigoEntrada,
                proveedor, codigoUsuario,
                aFecha
            };
        }

        public override void MostrarDatos()
        {

            //MessageBox.Show(aEntidad.ValorAtributo("IdProveedor"));
            TbProveedorH.Text = aEntidad.ValorAtributo("IdProveedor");
            TbSupervisorH.Text = aEntidad.ValorAtributo("IdUsuario");
            DtpFechaH.Value = Convert.ToDateTime(aEntidad.ValorAtributo("Fecha"));
        }

        private void EliminarEntradaDetalle(object sender, EventArgs e)
        {
            try
            {
                //No hay fil que seleccionar
                if (dgvDetalleEntrada.Rows.Count == 0)
                    return;
                //Averigüar la fila seleccionada
                int fila = dgvDetalleEntrada.CurrentCell.RowIndex;

                //eliminar la fila 
                dgvDetalleEntrada.Rows.RemoveAt(fila);
            }
            catch (Exception)
            {
                //Mostrar mensaje de error
                MessageBox.Show("No seleccionó ninguna fila", "ATENCION");
            }
        }

        /*Permite editar una determinada columna de un dgv
        /// <summary>
        /// Habilita la modificación de los valores en la columna cantidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HabilitarEdicionDataGrid(object sender, EventArgs e)
        {
            dgvDetalleEntrada.ReadOnly = false;
            dgvDetalleEntrada.Columns[0].ReadOnly = true;
            dgvDetalleEntrada.Columns[1].ReadOnly = true;
            dgvDetalleEntrada.Columns[2].ReadOnly = true;
            dgvDetalleEntrada.Columns[3].ReadOnly = true;
            dgvDetalleEntrada.Columns[4].ReadOnly = true;
        }
        */
        private void AgregarProductoDetalle(object sender, EventArgs e)
        {
            //validamos que se haya elegido un produto
            if (CbCodigoProducto.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el producto que quiere añadir.");
                return;
            }

            if (CbCodigoProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Producto no existente");
                return;
            }
            string codigoProducto = CbCodigoProducto.SelectedValue.ToString();
            //MessageBox.Show(CbCodigoProducto.SelectedIndex.ToString());

            int cantidad = (int)numericUpDownCantidad.Value;

            //Validamos que se haya ingresado un codigo
            if (tbCodigoEntrada.Text.Equals("") || comboBoxCodigoProveedor.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los datos de proveedor y codigo de nueva entrada.");
                return;
            }

            //Validamos que el codigo no se haya ingresado antes
            int numeroFilasDetalle = dgvDetalleEntrada.Rows.Count;
            int i = 0;
            bool encontrado = false;
            while (i < numeroFilasDetalle && !encontrado)
            {
                if (codigoProducto.Equals(dgvDetalleEntrada.Rows[i].Cells[0].Value.ToString()))
                    encontrado = true;
                i++;
            }

            if (encontrado)
            {
                MessageBox.Show("El producto ya ha sido agregado a la lista de entrada");
                return;
            }


            DataTable dt = producto.DatosProductoEntrada(codigoProducto);

            string[] datos = new string[dt.Columns.Count + 1];

            for (i = 0; i < dt.Columns.Count; i++)
            {
                datos[i] = dt.Rows[0][i].ToString();
            }

            datos[dt.Columns.Count] = cantidad + "";

            dgvDetalleEntrada.Rows.Add(datos);

            LimpiarFormularioNuevaEntradaDetalle();
        }

        private void LimpiarFormularioNuevaEntradaDetalle()
        {
            CbCodigoProducto.SelectedIndex = -1;
            numericUpDownCantidad.Value = 1;

            CbCodigoProducto.Focus();
        }

        private void GenerarNuevoCodigoEntrada(object sender, EventArgs e)
        {
            LimpiarDatosFormulario();

            int cant = aEntidad.NumeroRegistros();
            string cantCeros = "";
            if (cant < 9)
                cantCeros = "00000";
            else if (cant < 99)
                cantCeros = "0000";
            else if (cant < 999)
                cantCeros = "000";
            else if (cant < 9999)
                cantCeros = "00";
            else if (cant < 99999)
                cantCeros = "0";

            tbCodigoEntrada.Text = "EN" + cantCeros + (cant + 1);

            comboBoxCodigoProveedor.Focus();
        }

        private void LLenarDatosControles(object sender, EventArgs e)
        {
            LlenarDatosProveedores();
            LlenarCodigoProductos();
            //LlenarCodigoEntradas();

            //textBoxUsuario.Text = codigoUsuario;

            BtnNuevaEntrada.Focus();
        }

        /*Carga codigos de entrada en un comboBox
        private void LlenarCodigoEntradas()
        {
            tbCodigoEntrada.DataSource = entrada.ListadoParaCombos();
            tbCodigoEntrada.DisplayMember = "IdEntrada";
            tbCodigoEntrada.ValueMember = "IdEntrada";
            tbCodigoEntrada.SelectedIndex = -1;
        }
        */

        private void LlenarCodigoProductos()
        {
            CbCodigoProducto.DataSource = producto.ListadoCodigos();
            CbCodigoProducto.DisplayMember = "Nombre";
            CbCodigoProducto.ValueMember = "IdProducto";
            CbCodigoProducto.SelectedIndex = -1;
        }

        private void LlenarDatosProveedores()
        {
            comboBoxCodigoProveedor.DataSource = proveedor.ListadoParaCombos();
            comboBoxCodigoProveedor.DisplayMember = "Nombre";
            comboBoxCodigoProveedor.ValueMember = "IdProveedor";
            comboBoxCodigoProveedor.SelectedIndex = -1;
        }

    }
}
