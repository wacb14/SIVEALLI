using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BibClases
{
    public class CVentaDetalle:CEntidad
    {
        public CVentaDetalle() : base("TVentaDetalle")
        {
        }
        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdVenta", "IdProducto", "Cantidad", "PrecioUnitario"
            };
        }
        public DataTable ListarDetallesDeUnaVenta(string IdVenta)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spuVentaDetalleListarDetallesDeUnaVenta '" + IdVenta + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
