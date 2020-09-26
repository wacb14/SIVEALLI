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
using System.Drawing.Printing;

namespace SIVEALLI
{
    public partial class FormVentas : Form
    {
        //--- Atributos ---
        CVenta Ventas = new CVenta();
        CCliente Cliente = new CCliente();
        CVentaDetalle VentasDetalle = new CVentaDetalle();
        CProducto Producto = new CProducto();
        CNegocio Negocio = new CNegocio();
        string aUsuario;
        string aFecha;
        public FormVentas(string Usuario, string Fecha)
        {
            InitializeComponent();
            aUsuario = Usuario;
            aFecha = Fecha;
            TxtIdVenta.Text = GenerarIdVenta();
            CboBuscarPor.SelectedIndex = 0;
            CboBuscarPor2.SelectedIndex = 0;
        }
        /*------------------ Formulario Nueva Venta --------------------*/
        /// <summary>
        /// Genera automaticamente un ID de Venta basado en el numero de registros de la BD
        /// </summary>
        /// <returns></returns>
        private string GenerarIdVenta()
        {
            string Id = "VE";
            string NumeroVentas = (Ventas.NumeroVentas() + 1).ToString();
            for (int i = 0; i < 6 - NumeroVentas.Length; i++)
                Id += "0";
            Id += NumeroVentas;
            return Id;
        }
        /// <summary>
        /// Busca una cadena dentro de otra, sin considerar si hay diferencias en mayusculas, minusculas ni tildes
        /// </summary>
        /// <param name="Palabra">La cadena a buscar</param>
        /// <param name="Cadena">La cadena donde vamos a buscar</param>
        /// <returns></returns>
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
        /// <summary>
        /// Comprueba si existe un registro repetido en la tabla detalle
        /// </summary>
        /// <param name="IdProducto">El identificador del producto</param>
        /// <returns></returns>
        private bool BuscarRepetidoEnDetalle(string IdProducto)
        {
            bool Encontrado = false;
            int i = 0;
            while (i < DgvVentaDetalle.Rows.Count && !Encontrado)
            {
                if (DgvVentaDetalle.Rows[i].Cells["colIdProducto"].Value.ToString() == IdProducto)
                    Encontrado = true;
                i++;
            }
            return Encontrado;
        }
        /// <summary>
        /// Calcula los campos descuento,impuesto y total de una venta
        /// </summary>
        private void CalcularTotal()
        {
            try
            {
                if (Negocio.ExisteClavePrimaria(new string[] { "1" }))
                {
                    float Impuesto = float.Parse(Negocio.ValorAtributo("IGV")); // En porcentaje (ejem 18.5%)
                    float Descuento = float.Parse(Negocio.ValorAtributo("PorcentajeDescuento")); ; // En porcentaje
                    float CantidadSuperada = float.Parse(Negocio.ValorAtributo("MontoSuperarDescuento"));
                    Lbl8.Text = "Impuesto (" + Impuesto + "%) :";
                    Lbl12.Text = "Descuento (" + Descuento + "%) :";
                    float Subtotal = 0;
                    for (int i = 0; i < DgvVentaDetalle.Rows.Count; i++)
                        Subtotal += float.Parse(DgvVentaDetalle.Rows[i].Cells["colSubtotal"].Value.ToString());
                    Subtotal = (float)Math.Round(Subtotal, 2);
                    LblSubtotal.Text = Subtotal.ToString();
                    float Dcto = 0;
                    if (Subtotal > CantidadSuperada)
                        Dcto = (float)Math.Round((Descuento / 100) * Subtotal, 2);
                    LblDescuento.Text = "-" + Dcto.ToString();
                    float SubtotalConDscto = Subtotal - Dcto;
                    float CantidadImpuesto = (float)Math.Round((SubtotalConDscto * (Impuesto / 100)), 2);
                    LblImpuesto.Text = CantidadImpuesto.ToString();
                    float Total = SubtotalConDscto + CantidadImpuesto;
                    LblTotal.Text = Total.ToString();
                }
                else
                    MessageBox.Show("Faltan definir los parametros del negocio");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        /// <summary>
        /// Permite reconstruir los campos descuento,impuesto y total de una venta
        /// </summary>
        /// <param name="fila">La fila del registro</param>
        private void CalcularTotal2(int fila)
        {
            try
            {
                float Impuesto = float.Parse(DgvListaVentas.Rows[fila].Cells["IGV"].Value.ToString()); // En porcentaje (ejem 18.5%)
                float Descuento = float.Parse(DgvListaVentas.Rows[fila].Cells["PorcentajeDescuento"].Value.ToString()); // En porcentaje
                float CantidadSuperada = float.Parse(DgvListaVentas.Rows[fila].Cells["MontoSuperarDescuento"].Value.ToString());
                Lbl16 .Text = "Impuesto (" + Impuesto + "%) :";
                Lbl15.Text = "Descuento (" + Descuento + "%) :";
                float Subtotal = 0;
                for (int i = 0; i < DgvDetallesVenta2.Rows.Count; i++)
                    Subtotal += float.Parse(DgvDetallesVenta2.Rows[i].Cells["Subtotal"].Value.ToString());
                Subtotal = (float)Math.Round(Subtotal, 2);
                LblSubtotal2.Text = Subtotal.ToString();
                float Dcto = 0;
                if (Subtotal > CantidadSuperada)
                    Dcto = (float)Math.Round((Descuento / 100) * Subtotal, 2);
                LblDescuento2.Text = "-" + Dcto.ToString();
                float SubtotalConDscto = Subtotal - Dcto;
                float CantidadImpuesto = (float)Math.Round((SubtotalConDscto * (Impuesto / 100)), 2);
                LblImpuesto2.Text = CantidadImpuesto.ToString();
                float Total = SubtotalConDscto + CantidadImpuesto;
                LblTotal2.Text = Total.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        /// <summary>
        /// Limpia completamente el formulario de Venta
        /// </summary>
        private void LimpiarFormulario()
        {
            TxtIdVenta.Text = GenerarIdVenta();
            TxtIdCliente.Clear();
            CboBuscarPor.SelectedIndex = 0;
            TxtValorBusqueda.Clear();
            DgvCatalogoBusqueda.Rows.Clear();
            DgvVentaDetalle.Rows.Clear();
            CalcularTotal();
        }
        /// <summary>
        /// Realiza el guardado de los datos de una venta
        /// </summary>
        private void GuardarDatosVenta()
        {
                // Guardamos los datos generales de la venta
                string IGV = Negocio.ValorAtributo("IGV");
                string MontoSuperar = Negocio.ValorAtributo("MontoSuperarDescuento");
                string PorcentajeDescuento = Negocio.ValorAtributo("PorcentajeDescuento");
                string HuboDcto = float.Parse(LblSubtotal.Text) > float.Parse(MontoSuperar) ? "1" : "0";
                Ventas.Insertar(new string[] { TxtIdVenta.Text.Trim(), aUsuario, TxtIdCliente.Text.Trim(), aFecha, HuboDcto, IGV, MontoSuperar, PorcentajeDescuento });

                // Guardamos los detalles de la venta
                for (int i = 0; i < DgvVentaDetalle.Rows.Count; i++)
                {
                    string IdProducto = DgvVentaDetalle.Rows[i].Cells["colIdProducto"].Value.ToString();
                    string Cantidad = DgvVentaDetalle.Rows[i].Cells["colCantidad"].Value.ToString();
                    string PrecioUnitario = DgvVentaDetalle.Rows[i].Cells["colPrecioUnitario"].Value.ToString();
                    VentasDetalle.Insertar(new string[] { TxtIdVenta.Text, IdProducto, Cantidad, PrecioUnitario });
                }
            
        }
        //------------------------ Eventos -------------------------
        /// <summary>
        /// Realiza la busqueda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DgvCatalogoBusqueda.Rows.Clear();
                DataTable Lista = Producto.ListaProductosActivos(); // Validamos que solo se muestren productos activos
                string Valor = string.Empty;
                switch (CboBuscarPor.Text)
                {
                    case "ID Producto":
                        Valor = "IdProducto";
                        break;
                    case "Nombre":
                        Valor = "Nombre";
                        break;
                    case "Categoria":
                        Valor = "Categoria";
                        break;
                    case "Marca":
                        Valor = "Marca";
                        break;
                }
                for (int i = 0; i < Lista.Rows.Count; i++)
                {
                    string ValorProd = Lista.Rows[i][Valor].ToString();
                    if (BuscarPalabraEnCadena(TxtValorBusqueda.Text, ValorProd))
                    {
                        string IdProd = Lista.Rows[i]["IdProducto"].ToString();
                        string Nombre = Lista.Rows[i]["Nombre"].ToString();
                        string Categoria = Lista.Rows[i]["Categoria"].ToString();
                        string Descripcion = Lista.Rows[i]["Descripcion"].ToString();
                        string Marca = Lista.Rows[i]["Marca"].ToString();
                        string PrecioUnitario = Lista.Rows[i]["PrecioUnitario"].ToString();
                        string Cantidad = Lista.Rows[i]["Cantidad"].ToString();
                        DgvCatalogoBusqueda.Rows.Add("+", IdProd, Nombre, Marca, Categoria, PrecioUnitario, Cantidad, Descripcion);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        /// <summary>
        /// Valida que el campo cliente no quede vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtIdCliente_Leave(object sender, EventArgs e)
        {
            if (TxtIdCliente.Text.Trim() == "")
                MessageBox.Show("Debe ingresar algún valor en el campo del Identificador del Cliente.\n(El campo IdCliente no debe quedar vacio)", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Permite ingresar un nuevo cliente directamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            FormClientes Clientes = new FormClientes();
            Clientes.ShowDialog();
        }
        /// <summary>
        /// Vacia la tabla de detalles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVaciarDetalles_Click(object sender, EventArgs e)
        {
            DgvVentaDetalle.Rows.Clear();
            CalcularTotal();
        }
        /// <summary>
        /// Valida que se haya guardado la venta en curso o permite descartarla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNuevaVenta_Click(object sender, EventArgs e)
        {
            if (!Producto.ExisteClavePrimaria(new string[] { TxtIdVenta.Text }))
            {
                DialogResult Resultado = MessageBox.Show("Esta venta aun no se ha registrado.\n¿Esta seguro de descartar los datos ingresados y realizar una nueva venta?", "CUIDADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.OK)
                    LimpiarFormulario();
            }
        }
        /// <summary>
        /// Imprime la boleta de venta, antes validando el registro de la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (!Ventas.ExisteClavePrimaria(new string[] { TxtIdVenta.Text })) // Validamos si ya existe una venta registrada con el mismo codigo
                MessageBox.Show("Por favor registre la venta antes de continuar con la impresión del comprobante", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                ImpNuevaVenta = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                ImpNuevaVenta.PrinterSettings = ps;
                ImpNuevaVenta.PrintPage += ImpNuevaVenta_PrintPage;
                PrevioImpresion.Document = ImpNuevaVenta;
                PrevioImpresion.ShowDialog();
            }
        }
        /// <summary>
        /// Valida y registra los datos de una venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ventas.ExisteClavePrimaria(new string[] { TxtIdVenta.Text })) // Validamos si ya existe una venta registrada con el mismo codigo
                    MessageBox.Show("Ya existe una venta registrada con este código.\n Si desea realizar una nueva venta presiones el boton Nueva Venta", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (TxtIdCliente.Text.Trim() == "")
                        MessageBox.Show("Debe ingresar algún valor en el campo del Identificador del Cliente.\n(El campo IdCliente no debe quedar vacio)", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (DgvVentaDetalle.Rows.Count < 1) // Validamos que al menos existe un producto en los detalles
                            MessageBox.Show("Seleccione al menos un producto para continuar con el registro de la venta", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            GuardarDatosVenta();
                            MessageBox.Show("Los datos de la venta se han registrado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        /// <summary>
        /// Eventos del boton + que permiten agregar un producto al detalle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCatalogoBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //-- Determinar las coordenadas de la celda que cambio
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            try
            {
                if (col == 0) //-- columna de botones de agregar
                {
                    string IdProd = DgvCatalogoBusqueda.Rows[fila].Cells["colIdProducto1"].Value.ToString();
                    if (!BuscarRepetidoEnDetalle(IdProd))
                    {                        
                        // Esta parte previene los cambios en el stock y en los datos de los productos que se hayan hecho en paralelo
                        if (Producto.ExisteClavePrimaria(new string[] { IdProd }))
                        {
                            string PrecioUnitario = Producto.ValorAtributo("PrecioUnitario");
                            int CantMaxima = int.Parse(Producto.ValorAtributo("Cantidad"));
                            string Nombre = Producto.ValorAtributo("Nombre");
                            FormVentasCantidad Cant = new FormVentasCantidad(CantMaxima);
                            DialogResult Resultado = Cant.ShowDialog();
                            if (Resultado == DialogResult.OK)
                            {
                                string Cantidad = Cant.GetCantidad.ToString();
                                string Subtotal = (float.Parse(PrecioUnitario) * Cant.GetCantidad).ToString();
                                DgvVentaDetalle.Rows.Add("X", IdProd, Nombre, PrecioUnitario, Cantidad, Subtotal);
                                CalcularTotal();
                            }
                        }
                    }
                    else
                        MessageBox.Show("El producto ya se encuentra agregado en los detalles, si desea modificar la cantidad haga click en el casillero CANTIDAD de la tabla detalles", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Eventos que permiten eliminar un producto del detalle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvVentaDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //-- Determinar las coordenadas de la celda que cambio
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            try
            {
                if (col == 0) //-- columna de botones de borrado
                {
                    DgvVentaDetalle.Rows.RemoveAt(fila);
                    CalcularTotal();
                }
                else
                {
                    if (col == 4) //-- columna de botones de cantidad
                    {
                        string IdProd = DgvVentaDetalle.Rows[fila].Cells["colIdProducto"].Value.ToString();
                        if (Producto.ExisteClavePrimaria(new string[] { IdProd }))
                        {
                            int CantMaxima = int.Parse(Producto.ValorAtributo("Cantidad"));
                            FormVentasCantidad Cant = new FormVentasCantidad(CantMaxima);
                            Cant.ShowDialog();
                            string Cantidad = Cant.GetCantidad.ToString();
                            DgvVentaDetalle.Rows[fila].Cells["colCantidad"].Value = Cantidad;
                            CalcularTotal();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Imposible eliminar fila sin información", "ERROR");
            }
        }
        /*---------------------- Formulario Historial Ventas -----------------*/
        /// <summary>
        /// Busca en el historial de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBuscar2_Click(object sender, EventArgs e)
        {
            try
            {
                switch (CboBuscarPor2.Text.Trim())
                {
                    case "ID Venta":
                        DgvListaVentas.DataSource = Ventas.BuscarPorAtributo(TxtValorBusqueda2.Text.Trim(), "IdVenta");
                        break;
                    case "ID Usuario":
                        DgvListaVentas.DataSource = Ventas.BuscarPorAtributo(TxtValorBusqueda2.Text.Trim(), "IdUsuario");
                        break;
                    case "ID Cliente":
                        DgvListaVentas.DataSource = Ventas.BuscarPorAtributo(TxtValorBusqueda2.Text.Trim(), "IdCliente");
                        break;
                    case "Fecha (DD/MM/AAAA)":
                        DgvListaVentas.DataSource = Ventas.BuscarPorAtributo(DtpFechaBusqueda.Value.ToString("dd-MM-yyyy"), "Fecha");
                        break;
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        /// <summary>
        /// Evento que permite la consulta de los detalles de una venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvListaVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //-- Determinar las coordenadas de la celda que cambio
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            try
            {
                string IdVenta = DgvListaVentas.Rows[fila].Cells["IdVenta"].Value.ToString();
                DgvDetallesVenta2.DataSource = VentasDetalle.ListarDetallesDeUnaVenta(IdVenta);
                CalcularTotal2(fila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Hace visible o invisible al datetimepicker de fecha para la busqueda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboBuscarPor2_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CboBuscarPor2.Text.Trim()== "Fecha (DD/MM/AAAA)")
            {
                TxtValorBusqueda2.Visible = false;
                DtpFechaBusqueda.Visible = true;
            }
            else
            {
                TxtValorBusqueda2.Visible = true;
                DtpFechaBusqueda.Visible = false;
            }
        }
        private void DibujarFila(string[] Valores, float x, float y, PrintPageEventArgs e)
        {
            Font FuenteCuerpo = new Font("Arial", 9);
            //-- Tamaño de la hoja 300x1165
            //-- Margenes 10
            //float Ancho = 280;
            float Altura = 18;
            //Texto
            e.Graphics.DrawString(Valores[0], FuenteCuerpo, Brushes.DarkBlue, new RectangleF(x, y, 25, Altura));
            e.Graphics.DrawString(Valores[1], FuenteCuerpo, Brushes.DarkBlue, new RectangleF(x + 25, y, 195, Altura));
            e.Graphics.DrawString(Valores[2], FuenteCuerpo, Brushes.DarkBlue, new RectangleF(x + 220, y, 60, Altura));
        }
        private void ImpNuevaVenta_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (Negocio.ExisteClavePrimaria("1"))
            {
                //-- Encabezado del documento
                Font FuenteTitulo = new Font("Arial", 16, FontStyle.Bold);
                Font FuenteSubTitulo = new Font("Arial", 12, FontStyle.Bold);
                Font FuenteCuerpo = new Font("Arial", 11, FontStyle.Bold);
                e.Graphics.DrawString("LIBRERIA", FuenteSubTitulo, Brushes.DarkBlue, new RectangleF(100, 10, 805, 25));
                e.Graphics.DrawString(Negocio.ValorAtributo("Nombre"), FuenteTitulo, Brushes.DarkBlue, new RectangleF(30, 35, 805, 35));
                e.Graphics.DrawString("-----------", FuenteSubTitulo, Brushes.DarkBlue, new RectangleF(100, 70, 805, 25));
                string[] Direc = Negocio.ValorAtributo("Direccion").Split('-');
                e.Graphics.DrawString(Direc[0] + "\n", FuenteCuerpo, Brushes.DarkBlue, new RectangleF(80, 95, 805, 45));
                e.Graphics.DrawString("R.U.C. N°" + Negocio.ValorAtributo("RUC") + "\nN° de serie 6802328", FuenteSubTitulo, Brushes.DarkBlue, new RectangleF(50, 140, 805, 50));
                e.Graphics.DrawString("5411077", FuenteSubTitulo, Brushes.DarkBlue, new RectangleF(170, 190, 150, 20));
                e.Graphics.DrawString(DateTime.Now.ToString("dd-MM-yyyy"), FuenteSubTitulo, Brushes.DarkBlue, new RectangleF(30, 210, 140, 20));
                e.Graphics.DrawString(DateTime.Now.ToString("hh:mm") + " Hrs", FuenteSubTitulo, Brushes.DarkBlue, new RectangleF(170, 210, 140, 20));

                //-- Cuerpo del documento (lista de detalles)
                for (int i = 0; i < DgvVentaDetalle.Rows.Count; i++)
                {
                    string Cantidad = DgvVentaDetalle.Rows[i].Cells["colCantidad"].Value.ToString();
                    string Nombre = DgvVentaDetalle.Rows[i].Cells["colNombre"].Value.ToString();
                    string Subtotal = DgvVentaDetalle.Rows[i].Cells["colSubtotal"].Value.ToString();
                    DibujarFila(new string[] { Cantidad, Nombre, Subtotal }, 10, 230 + ((i + 1) * 18), e);
                }
                float UltLinea = 230 + ((DgvVentaDetalle.Rows.Count) * 18);
                e.Graphics.DrawLine(Pens.DarkBlue, 10, UltLinea + 18, 290, UltLinea + 18);
                DibujarFila(new string[] { "*", "Subtotal", LblSubtotal.Text }, 10, UltLinea + 18, e);
                DibujarFila(new string[] { "*", "Descuento", LblDescuento.Text }, 10, UltLinea + 36, e);
                DibujarFila(new string[] { "*", "Impuesto", LblImpuesto.Text }, 10, UltLinea + 54, e);
                DibujarFila(new string[] { "+", "Total", LblTotal.Text }, 10, UltLinea + 72, e);
            }
        }

        private void ImpHistorialVenta_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (Negocio.ExisteClavePrimaria("1"))
            {
                //-- Encabezado del documento
                Font FuenteTitulo = new Font("Arial", 16, FontStyle.Bold);
                Font FuenteSubTitulo = new Font("Arial", 12, FontStyle.Bold);
                Font FuenteCuerpo = new Font("Arial", 11, FontStyle.Bold);
                e.Graphics.DrawString("LIBRERIA", FuenteSubTitulo, Brushes.DarkBlue, new RectangleF(100, 10, 805, 25));
                e.Graphics.DrawString(Negocio.ValorAtributo("Nombre"), FuenteTitulo, Brushes.DarkBlue, new RectangleF(30, 35, 805, 35));
                e.Graphics.DrawString("REIMPRESION", FuenteSubTitulo, Brushes.DarkBlue, new RectangleF(100, 70, 805, 25));
                string[] Direc = Negocio.ValorAtributo("Direccion").Split('-');
                //e.Graphics.DrawString(Direc[0]+"\n"+Direc[1], FuenteCuerpo, Brushes.DarkBlue, new RectangleF(80, 95, 805, 45));
                e.Graphics.DrawString(Direc[0]+"\n", FuenteCuerpo, Brushes.DarkBlue, new RectangleF(80, 95, 805, 45));
                e.Graphics.DrawString("R.U.C. N°"+Negocio.ValorAtributo("RUC") +"\nN° de serie 6802328", FuenteSubTitulo, Brushes.DarkBlue, new RectangleF(50, 140, 805, 50));
                e.Graphics.DrawString("5411077", FuenteSubTitulo, Brushes.DarkBlue, new RectangleF(170, 190, 150, 20));
                e.Graphics.DrawString(DateTime.Now.ToString("dd-MM-yyyy"), FuenteSubTitulo, Brushes.DarkBlue, new RectangleF(30, 210, 140, 20));
                e.Graphics.DrawString(DateTime.Now.ToString("hh:mm")+" Hrs", FuenteSubTitulo, Brushes.DarkBlue, new RectangleF(170, 210, 140, 20));

                //-- Cuerpo del documento (lista de detalles)
                for (int i = 0; i < DgvDetallesVenta2.Rows.Count; i++)
                {
                    string Cantidad = DgvDetallesVenta2.Rows[i].Cells["Cantidad"].Value.ToString();
                    string Nombre = DgvDetallesVenta2.Rows[i].Cells["Nombre"].Value.ToString();
                    string Subtotal = DgvDetallesVenta2.Rows[i].Cells["Subtotal"].Value.ToString();
                    DibujarFila(new string[] { Cantidad, Nombre, Subtotal }, 10, 230 + ((i + 1) * 18), e);
                }
                float UltLinea = 230 + ((DgvDetallesVenta2.Rows.Count) * 18);
                e.Graphics.DrawLine(Pens.DarkBlue, 10, UltLinea + 18, 290, UltLinea + 18);
                DibujarFila(new string[] { "*", "Subtotal", LblSubtotal2.Text }, 10, UltLinea + 18, e);
                DibujarFila(new string[] { "*", "Descuento", LblDescuento2.Text }, 10, UltLinea + 36, e);
                DibujarFila(new string[] { "*", "Impuesto", LblImpuesto2.Text}, 10, UltLinea + 54, e);
                DibujarFila(new string[] { "+", "Total", LblTotal2.Text }, 10, UltLinea + 72, e);
            }
        }

        private void BtnImprimirComprobante2_Click(object sender, EventArgs e)
        {
            if (DgvDetallesVenta2.Rows.Count == 0) // Validamos si ya existe una venta registrada con el mismo codigo
                MessageBox.Show("Cargue los detalles de la venta que desea imprimir.\n(Haga click en uno de los registros del historial) ", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                ImpHistorialVenta = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                ImpHistorialVenta.PrinterSettings = ps;
                ImpHistorialVenta.PrintPage += ImpHistorialVenta_PrintPage;
                PrevioImpresion.Document = ImpHistorialVenta;
                PrevioImpresion.ShowDialog();
            }
        }

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
