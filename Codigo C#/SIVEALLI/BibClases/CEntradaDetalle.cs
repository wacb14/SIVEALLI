using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibClases
{
    public class CEntradaDetalle:CEntidad
    {
        public CEntradaDetalle() : base("TEntradaDetalle")
        {
        }

        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdEntrada", "IdProducto", "Cantidad"
            };
        }

        public void EliminarRegistros(string id)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "delete from TEntradaDetalle where IdEntrada='" + id + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
        }
    }
}
