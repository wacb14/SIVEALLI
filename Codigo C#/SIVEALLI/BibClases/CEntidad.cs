using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BibClases
{
    public abstract class CEntidad
    {
        //************************* Atributos ************************
        protected CConexion aConexion;
        protected string aNombreTabla;
        protected string[] aValores = null; //Valores de los campos de la tabla
        protected bool aNuevo;
        //************************* METODOS **************************
        public CEntidad(string pNombreTabla)
        {
            //->Inicializar los atributos
            aNuevo = true;
            aNombreTabla = pNombreTabla;
            aConexion = new CConexion();
            aValores = null;
        }
        //---------------------- Propiedades -------------------------
        public bool Nuevo
        {
            get { return aNuevo; }
            set { aNuevo = value; }
        }
        public string NombreTabla()
        {
            return aNombreTabla;
        }


        //******************** METODOS DE SOPORTE DE BD ***********************
        //-> Metodo abstracto encargado de establecer los nombre de los campos
        //-> (atributos) de la tabla. 
        //-> Se deben implementar necesariamente en los herederos como arreglos de cadenas.
        //-> Estos atributos deben coincidir con los existentes  en LA BASE DE DATOS

        public abstract string[] NombresAtributos();

        public virtual void Insertar(params string[] Atributos)
        {
            aNuevo = true;
            aValores = Atributos;
            //--Formar cadena de insercion 
            string CadenaInsertar = "exec spu_" + aNombreTabla + "_Insertar '";
            for (int k = 0; k < aValores.Length; k++)
            {   //--Incluir los atributos en la consulta
                CadenaInsertar += aValores[k];
                if (k == aValores.Length - 1)
                    //--Se concatena el ultimo atributo, Terminar la consulta
                    CadenaInsertar += "'";
                else //dejar la consulta lista para el siguiente atributo
                    CadenaInsertar += "','";
            }
            //MessageBox.Show("Guardar: " + CadenaInsertar);
            //--Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(CadenaInsertar);
            aNuevo = false;
        }
        //----------------------------Actualizacion de registros------------
        public virtual void Actualizar(params string[] Atributos)
        {   //--Permite actuzalizar la informacion de un registro de la tabla
            //--Recuperar los nombres y valores de los atributos de la tabla
            aValores = Atributos;

            //--formar cadena actualizar
            string CadenaActualizar = "exec spu_" + aNombreTabla + "_Modificar '";
            for (int k = 0; k < aValores.Length; k++)
            {   //--Incluir los atributos en la consulta
                CadenaActualizar += aValores[k];
                if (k == aValores.Length - 1)
                    //--Se concatena el ultimo atributo, Terminar la consulta
                    CadenaActualizar += "'";
                else //dejar la consulta lista para el siguiente atributo
                    CadenaActualizar += "','";
            }
            //MessageBox.Show("Actualizar: "+CadenaActualizar);
            //--Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(CadenaActualizar);
        }
        //-----------------------------------------------------------------------
        //-------------------------------Eliminar registros----------------------
        public void Eliminar(params string[] Atributos)
        {//--Permite eliminar la informacion de un registro
            aValores = Atributos;
            //--Formar cadena eliminar
            string CadenaEliminar = "exec spu_" + aNombreTabla + "_Eliminar '" + aValores[0] + "'";
            //--Ejecutar la consulta paraeliminar el registro
            aConexion.EjecutarComando(CadenaEliminar);
        }
        //--------------------------------------------------------------------------------------
        public bool ExisteClavePrimaria(params string[] Atributos)
        {   //--> Verificar si un registro especifico existe
            aValores = Atributos;
            //--Formar la consulta
            string CadenaConsulta = "exec spuExisteClavePrimaria" + aNombreTabla + " '" + aValores[0] + "'";
            //--Ejecutar la consulta
            aConexion.EjecutarSelect(CadenaConsulta);
            //--Si existen registros en la tabla 0 del dataset, la clave primaria existe
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }
        //----------------------------------------------------------
        public virtual bool ExisteClavePrimaria(int n, params string[] Atributos)
        {
            //n para verificar varios parametros
            //verifica si un registro especifico existe
            //Recuperar los nombres y valores de lso atributos de la tabla
            aValores = Atributos;

            //formar la consulta
            string CadenaConsulta = "exec spuExisteClavePrimaria" + aNombreTabla + " ";
            for (int k = 0; k < n; k++)
            {
                CadenaConsulta += "'" + aValores[k] + "'";

                if (k != n - 1)
                    CadenaConsulta += ", ";
            }
            //Ejecutar la consulta
            aConexion.EjecutarSelect(CadenaConsulta);

            //Si existen registros en la tabla 0 del dataset, la clave primaria existe
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }
        //--------------------------------------------------------------------------------------
        public DataTable Registro(params string[] Atributos)
        {
            aValores = Atributos;
            //--Formar la consulta
            string CadenaConsulta = "exec spuRegistro" + aNombreTabla + " '" + aValores[0] + "'";
            //--Ejecutar la consulta
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //--------------------------------------------------------------------------------
        public string ValorAtributo(string pNombreCampo)
        {   //--Recuperar el valor de un atributo del dataset
            return aConexion.Datos.Tables[0].Rows[0][pNombreCampo].ToString();
        }
        //------------------------------------------------------------------------------------------
        public DataTable ListaGeneral()
        {   //--Retornar un tabla con la lista completa de  libros
            string CadenaConsulta = "exec spu_" + aNombreTabla + "_Listar";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------------------------------------------------
        public virtual DataTable ListaGeneralCod(string codigo)
        {
            //retornar una tabla con la lista completa de los libros
            string Consulta = "exec spu" + aNombreTabla + "ListaCod '"
                + codigo + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        //-------------------------------------------------------------------------
        //Luigi
        //------------------------------------------------------------------------------------------
        public virtual DataTable MarcarSalida_Detalle(string CodPedido)
        {
            //--Retornar un tabla con el producto
            string CadenaConsulta = "exec spuBuscar_Salida_Detalle_ID '" + CodPedido + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];

        }
        public virtual void CambiarEstadoSalida_Detalle(string CodPedido)
        {
            //--Retornar un tabla con el producto
            string CadenaConsulta = "exec spuActualizarEntregado_Salida_Detalle '" + CodPedido + "'";
            aConexion.EjecutarSelect(CadenaConsulta);
        }
        //------------------------------------------------------------------------------------------
        // MODIFICAR ======================================================= 
        public int NumeroRegistros()
        {
            //--Retornar un tabla con el producto
            string CadenaConsulta = "exec spu_" + aNombreTabla + "_Listar";
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0].Rows.Count;
        }
    }
}
