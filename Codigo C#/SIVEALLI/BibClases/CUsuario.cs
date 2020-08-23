using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibClases
{
    public class CUsuario:CEntidad
    {
        public CUsuario() : base("TUsuario")
        {
        }

        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdUsuario", "Nombres", "Apellidos", "Direccion", 
                "Telefono", "Correo", "Contraseña", "Tipo", "Estado"
            };
        }
    }
}
