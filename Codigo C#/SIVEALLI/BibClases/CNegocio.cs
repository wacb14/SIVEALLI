using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibClases
{
    public class CNegocio:CEntidad
    {
        public CNegocio() : base("TNegocio")
        {

        }
        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdModificacion", "Nombre", "Duegno", "RUC","Telefono", "Correo","Direccion","IGV","MontoSuperarDescuento","PorcentajeDescuento","Fecha"
            };
        }
    }
}
