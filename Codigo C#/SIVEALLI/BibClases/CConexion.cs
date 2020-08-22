using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibClases
{
    public class CConexion
    {
        //===============================ATRIBUTOS==========================
        public SqlConnection aConexion;
        public SqlDataAdapter aAdaptador;
        public DataSet aDatos;
        //=============================METODOS=============================
        //------------------------Constructores-----------------------------------
        public CConexion()
        {   //--Iniciar la conexion
            aDatos = new DataSet();
            aAdaptador = new SqlDataAdapter();
            //--Realizar conexion
            string CadenaConexion = "Data Source=CED;Initial Catalog = DBAlmacen;Integrated Security = SSPI; ";
            aConexion = new SqlConnection(CadenaConexion);
        }
        //-----------------------Propiedades------------------------------------
        public SqlConnection Conexion
        {
            get { return aConexion; }
        }
        //_------------------------------------------------------
        public SqlDataAdapter Adaptador
        {
            get { return aAdaptador; }
        }
        //-----------------------------------------------------------------
        public DataSet Datos
        {
            get { return aDatos; }
        }
        //-------------------------Servicios--------------------------------------------------
        //--Comando que ejecuta comandos sql server
        //--Devuelve el resultado en la tabla cero del dataset
        public virtual DataSet EjecutarSelect(string pConsulta)
        {//--Metodo para ejecutar consultas del tipo SELECT
            aAdaptador.SelectCommand = new SqlCommand(pConsulta, aConexion);
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }
        //------------------------------------------------------------------------------------
        //--Metodo para ejecutar instrucciones DML. No retorna resultados
        //----------------------------------------------------------------------------------
        public virtual void EjecutarComando(string pComando)
        {   //--Metodo para ejecutar instrucciones del tipo INSERT, UPDATE, DELETE
            SqlCommand oComando = new SqlCommand(pComando, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
    }
}
