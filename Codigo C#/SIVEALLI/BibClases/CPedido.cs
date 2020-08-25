using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibClases
{
    public class CPedido:CEntidad
    {
        public CPedido() : base("TPedido")
        {
        }
        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdPedido", "IdProveedor", "IdUsuario", "FechaPago",
                "FechaPedido", "TerminosEntrega"
            };
        }
        //------------------------------------------------------------------------------------------
        public DataTable CatalogoProductos()
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "spuListarCatalogoProductos";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
