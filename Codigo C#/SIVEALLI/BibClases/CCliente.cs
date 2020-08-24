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
        //------------------------------------------------------------------------------------------
        public DataTable BuscarPorNombres(string Nombres)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spuExisteNombre" + aNombreTabla + " '"+Nombres+"'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable BuscarPorApellidos(string Apellidos)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spuExisteApellido" + aNombreTabla + " '" + Apellidos + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable BuscarPorDireccion(string Direccion)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spuExisteDireccion" + aNombreTabla + " '" + Direccion + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
