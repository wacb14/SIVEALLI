using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BibClases
{
    public class CVenta : CEntidad
    {
        public CVenta() : base("TVenta")
        {
        }
        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdVenta", "IdUsuario", "IdCliente", "Fecha"
            };
        }
        public int NumeroVentas()
        {
            string CadenaConsulta = "exec spuNumeroDeVentas";
            aConexion.EjecutarSelect(CadenaConsulta);
            int NumeroVentas = int.Parse(aConexion.Datos.Tables[0].Rows[0]["NumeroVentas"].ToString());
            return NumeroVentas;
        }
        public DataTable BuscarPorAtributo(string Atributo, string NombreAtributo)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spuVentasListarPor" + NombreAtributo + " '" + Atributo + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
