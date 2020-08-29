using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibClases
{
    public class CEntrada:CEntidad
    {
        public CEntrada() : base("TEntrada")
        {
        }

        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdEntrada", "IdProveedor", "IdUsuario", "Fecha"
            };
        }
    }
}
