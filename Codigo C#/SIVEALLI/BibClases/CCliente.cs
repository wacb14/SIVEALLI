using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibClases
{
    public class CCliente : CEntidad
    {
        public CCliente() : base("TCliente")
        {
        }
        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdCliente", "Nombres", "Apellidos", "Direccion",
                "Telefono", "Correo"
            };
        }
    }
}
