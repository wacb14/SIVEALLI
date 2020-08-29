using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibClases
{
    public class CPedidoDetalle : CEntidad
    {
        public CPedidoDetalle() : base("TPedidoDetalle")
        {
        }
        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdPedido", "IdProducto", "Cantidad", "PrecioUnitario"
            };
        }
        //------------------------------------------------------------------------------------------
        public void EliminarRegistros(string id)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "delete from TPedidoDetalle where IdPedido='" + id + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
        }
    }
}
