using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

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

        public void ActualizarImagen(string IdProducto, byte[] Imagen)
        {
            aConexion.InsertarImagen(IdProducto, Imagen);
        }

        public byte[] RecuperarImagen(string IdProducto)
        {
            return aConexion.RecuperarImagen(IdProducto);
        }

        public override void Insertar(params string[] Atributos)
        {
            aNuevo = true;
            aValores = Atributos;
            //--Formar cadena de insercion 
            string CadenaInsertar = "exec spu_" + aNombreTabla + "_Insertar '";
            for (int k = 0; k < aValores.Length; k++)
            {
                // En esta clase se considera un caso especial, ya que las imagenes pueden tener valor NULL.
                // Aqui tenemos mucha consideracion por la posicion u orden en el que esta la imagen, esta validacion para
                // NULL no va funcionar con otros campos
                if (aValores[k] == null)
                {
                    CadenaInsertar = CadenaInsertar.Substring(0, CadenaInsertar.Length - 1);
                    CadenaInsertar += "NULL";
                    CadenaInsertar += ",'";
                }
                else
                {
                    //--Incluir los atributos en la consulta
                    CadenaInsertar += aValores[k];
                    if (k == aValores.Length - 1)
                        //--Se concatena el ultimo atributo, Terminar la consulta
                        CadenaInsertar += "'";
                    else //dejar la consulta lista para el siguiente atributo
                        CadenaInsertar += "','";
                }
                
            }
            //--Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(CadenaInsertar);
            aNuevo = false;
        }
        //----------------------------Actualizacion de registros------------
        public override void Actualizar(params string[] Atributos)
        {   //--Permite actuzalizar la informacion de un registro de la tabla
            //--Recuperar los nombres y valores de los atributos de la tabla
            aValores = Atributos;

            //--formar cadena actualizar
            string CadenaActualizar = "exec spu_" + aNombreTabla + "_Modificar '";
            for (int k = 0; k < aValores.Length; k++)
            {
                // En esta clase se considera un caso especial, ya que las imagenes pueden tener valor NULL.
                // Aqui tenemos mucha consideracion por la posicion u orden en el que esta la imagen, esta validacion para
                // NULL no va funcionar con otros campos
                if (aValores[k] == null)
                {
                    CadenaActualizar = CadenaActualizar.Substring(0, CadenaActualizar.Length - 1);
                    CadenaActualizar += "NULL";
                    CadenaActualizar += ",'";
                }
                else
                {
                    //--Incluir los atributos en la consulta
                    CadenaActualizar += aValores[k];
                    if (k == aValores.Length - 1)
                        //--Se concatena el ultimo atributo, Terminar la consulta
                        CadenaActualizar += "'";
                    else //dejar la consulta lista para el siguiente atributo
                        CadenaActualizar += "','";
                }
            }
            //--Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(CadenaActualizar);
        }

        public DataTable ListadoCodigos()
        {
            string CadenaConsulta = "exec spuListadoCodigoProductos";

            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
