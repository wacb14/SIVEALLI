using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibClases
{
    public class CPedido : CEntidad
    {
        public CPedido() : base("TPedido")
        {
        }
        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdPedido", "IdProveedor", "IdUsuario", "FechaPago",
                "FechaPedido", "TerminosEntrega"
            };
        }
        //------------------------------------------------------------------------------------------
        public DataTable IdMaximo()
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "select max(IdPedido) from TPedido";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable CatalogoProductos()
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "spuListarCatalogoProductos";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable ListaProveedores()
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "spuListaProveedores";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable CantidadMaxProducto(string Id)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "spuCantidadMax '" + Id + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable MostrarTodo()
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "select * from TPedido";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable TraerDatosPedido(string id)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spuExisteId" + aNombreTabla + " '" + id + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable TraerDatosPedidoDetalle(string id)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spuExisteId" + aNombreTabla + "Detalle '" + id + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
