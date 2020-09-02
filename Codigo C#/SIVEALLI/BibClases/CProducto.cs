using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BibClases
{
    public class CProducto : CEntidad
    {
        public CProducto() : base("TProducto")
        {
        }
        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdProducto", "Nombre", "Categoria", "Descripcion", "Marca", "PrecioUnitario", "Imagen", "Estado","Cantidad", "Maximo","Minimo"
            };
        }
        public DataTable ListaGeneralSinImagen()
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spuListarProductosSinImagen";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable BuscarPorAtributo(string Atributo, string NombreAtributo)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spuListarPor"+NombreAtributo+" '"+Atributo+"'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable DatosProductoEntrada(string codigoProducto)
        {
            string CadenaConsulta = "exec spuDatosProductoEntrada '" + codigoProducto + "'";
            //--Ejecutar la consulta
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        public int NumeroDeProductos()
        {
            string CadenaConsulta = "exec spuNumeroDeProductos";
            aConexion.EjecutarSelect(CadenaConsulta);
            int NumeroProductos = int.Parse(aConexion.Datos.Tables[0].Rows[0]["NumeroProductos"].ToString());
            return NumeroProductos;
        }
        public DataTable ListadoCodigos()
        {
            string CadenaConsulta = "exec spuListadoCodigoProductos";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
