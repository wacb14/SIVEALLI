using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
