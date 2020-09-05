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
    public partial class FormVentas : Form
    {
        //--- Atributos ---
        CVenta Ventas = new CVenta();
        CCliente Cliente = new CCliente();
        CVentaDetalle VentasDetalle = new CVentaDetalle();
        CProducto Producto = new CProducto();
        public FormVentas()
        {
            InitializeComponent();
            TxtIdVenta.Text = GenerarIdVenta();
            CboBuscarPor.SelectedIndex = 0;
        }
        /*------------------ Formulario Nueva Venta --------------------*/
        /// <summary>
        /// 
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
        private void IngresoClienteObligatorio()
        {
            FormClientes Clientes = new FormClientes();
            Clientes.ShowDialog();
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
        private void CalcularTotal()
        {
            float Impuesto = 18;
            float Descuento = 3;
            float CantidadSuperada = 10;
            Lbl8.Text = "Impuesto (" + Impuesto + "%) :";
            Lbl12.Text = "Descuento (" + Descuento + "%) :";
            float Total = 0;
            for (int i = 0; i < DgvVentaDetalle.Rows.Count; i++)
            {
                Total += float.Parse(DgvVentaDetalle.Rows[i].Cells["colSubtotal"].Value.ToString());
            }
            LblSubtotalSinImpuesto.Text = Math.Round(Total,2).ToString();
            LblImpuesto.Text = Math.Round((Total * (Impuesto / 100)),2).ToString();
            float Subtotal = (Total * (Impuesto / 100)) + Total;
            LblSubtotal.Text = Math.Round(Subtotal,2).ToString();
            float Dcto = 0;
            if (Subtotal > CantidadSuperada)
            {
                Dcto = (Descuento / 100) * Subtotal;
                LblDescuento.Text = Math.Round(Dcto,2).ToString();
            }
            else
                LblDescuento.Text = "0".ToString();
            LblTotal.Text = Math.Round((Subtotal - Dcto),2).ToString();
        }
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
        //------------------------ Eventos -------------------------

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DgvCatalogoBusqueda.Rows.Clear();
            DataTable Lista = Producto.ListaProductosActivos(); // Validamos que solo se muestren productos activos
            string Valor=string.Empty;
            switch(CboBuscarPor.Text)
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
                    DgvCatalogoBusqueda.Rows.Add("+",IdProd, Nombre, Marca, Categoria, PrecioUnitario, Cantidad, Descripcion);
                }
            }
        }
        private void TxtIdCliente_Leave(object sender, EventArgs e)
        {
            if (!Cliente.ExisteClavePrimaria(new string[] { TxtIdCliente.Text }))
            {
                MessageBox.Show("El ID de cliente ingresado no existe, para continuar registre al cliente primero", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                IngresoClienteObligatorio();
            }
        }
        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            IngresoClienteObligatorio();
        }

        private void BtnVaciarDetalles_Click(object sender, EventArgs e)
        {
            DgvVentaDetalle.Rows.Clear();
            CalcularTotal();
        }

        private void BtnNuevaVenta_Click(object sender, EventArgs e)
        {
            if(!Producto.ExisteClavePrimaria(new string[] { TxtIdVenta.Text }))
            {
                DialogResult Resultado = MessageBox.Show("Esta venta aun no se ha registrado.\n¿Esta seguro de descartar los datos ingresados y realizar una nueva venta?", "CUIDADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.OK)
                    LimpiarFormulario();
            }      
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
        {

        }
        
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
                            Cant.ShowDialog();
                            string Cantidad = Cant.GetCantidad.ToString();
                            string Subtotal = (float.Parse(PrecioUnitario) * Cant.GetCantidad).ToString();
                            DgvVentaDetalle.Rows.Add("X", IdProd, Nombre, PrecioUnitario, Cantidad, Subtotal);
                            CalcularTotal();
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
                        DgvListaVentas.DataSource = Ventas.BuscarPorAtributo(TxtValorBusqueda2.Text.Trim(), "Fecha");
                        break;
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void DgvListaVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //-- Determinar las coordenadas de la celda que cambio
            int fila = e.RowIndex;
            int col = e.ColumnIndex;
            try
            {
                string IdVenta = DgvListaVentas.Rows[fila].Cells["IdVenta"].Value.ToString();
                DgvDetallesVenta2.DataSource = VentasDetalle.ListarDetallesDeUnaVenta(IdVenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
