﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace BibClases
{
    public class CDevolucion : CEntidad
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
        public DataTable MostrarVenta(string IdVenta)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "spuTraerDatosDeLaVentas '"+IdVenta+"'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable MostrarDatosVentas(string IdVenta)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "spuDatosVenta '" + IdVenta + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable TraerDatosDevolucion(string id)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spuExisteId" + aNombreTabla + " '" + id + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable TraerDatosDevolucionDetalle(string id)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spuExisteId" + aNombreTabla + "Detalle '" + id + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable TraerDatosDevolucionDetalle2(string id)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spuExisteId" + aNombreTabla + "Detalle2 '" + id + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public DataTable TraerDatosProducto(string id)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "select * from TProducto where IdProducto = '" + id + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public string TraerSubTotalVenta(string id)
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "select sum(PrecioUnitario*Cantidad) as Total from TVentaDetalle where IdVenta='" + id + "' group by IdVenta";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0].Rows[0][0].ToString();
        }
        //--Guardar stock
        public void GuardarStockProducto(string id,string Cant)
        {
            string CadenaConsulta = "select Cantidad from TProducto where IdProducto = '"+id+"'";
            aConexion.EjecutarSelect(CadenaConsulta);
            int Stock= int.Parse(aConexion.Datos.Tables[0].Rows[0][0].ToString());
            //--Retornar un tabla con la lista completa de  libros
            CadenaConsulta = "update TProducto set Cantidad = '"+(int.Parse(Cant)+Stock).ToString()+"' where IdProducto = '"+id+"'";
            aConexion.EjecutarSelect(CadenaConsulta);
        }
    }
}
