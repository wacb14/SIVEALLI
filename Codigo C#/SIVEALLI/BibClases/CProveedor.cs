using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibClases
{
    public class CProveedor : CEntidad
    {
        public CProveedor() : base("TProveedor")
        {
        }
        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdProveedor", "Nombres", "Direccion", "Telefono", "Correo", "Estado"
            };
        }
    }
}
    
