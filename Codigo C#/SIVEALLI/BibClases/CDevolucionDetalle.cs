using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibClases
{
    public class CDevolucionDetalle:CEntidad
    {
        public CDevolucionDetalle() : base("TDevolucionDetalle")
        {
        }
        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdDevolucion", "IdProducto", "Cantidad", "Estado","PrecioUnitario"
            };
        }
        //------------------------------------------------------------------------------------------
        public void EliminarRegistros(string id)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "delete from TDevolucionDetalle where IdDevolucion='" + id + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
        }
    }
}
