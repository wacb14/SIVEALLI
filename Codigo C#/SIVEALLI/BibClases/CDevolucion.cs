using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibClases
{
    public class CDevolucion:CEntidad
    {
        public CDevolucion() : base("TDevolucion")
        {
        }
        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdDevolucion", "IdVenta", "Razon", "Fecha"
            };
        }
        //------------------------------------------------------------------------------------------
        public DataTable IdMaximo()
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "select max(IdDevolucion) from TDevolucion";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable MostrarTodo()
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "select * from TDevolucion";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable MostrarVentas()
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "spuTraerHistorialVentas";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable MostrarDatosVentas(string IdVenta)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "spuDatosVenta '"+IdVenta+"'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
