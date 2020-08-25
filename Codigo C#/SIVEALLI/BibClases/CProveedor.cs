using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable ListadoParaCombos()
        {
            string CadenaConsulta = "exec spuCodigoNombreProveedores";

            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
    
