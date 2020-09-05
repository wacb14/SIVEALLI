using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibClases
{
    public class CUsuario:CEntidad
    {
        public CUsuario() : base("TUsuario")
        {
        }

        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdUsuario", "Nombres", "Apellidos", "Direccion", 
                "Telefono", "Correo", "Contraseña", "Tipo", "Estado"
            };
        }

        public DataTable ListaUsuarios()
        {
            string CadenaListar = "exec ListaUsuariosSinContragna";
            aConexion.EjecutarSelect(CadenaListar);
            return aConexion.Datos.Tables[0];
        }

        public void ActualizarNoContraseña(params string[] Atributos)
        {
            string CadenaModificar = "exec spu_TUsuario_Modificar_SinContrsegna '";

            aValores = Atributos;

            for (int k = 0; k < aValores.Length; k++)
            {   //--Incluir los atributos en la consulta
                CadenaModificar += aValores[k];
                if (k == aValores.Length - 1)
                    //--Se concatena el ultimo atributo, Terminar la consulta
                    CadenaModificar += "'";
                else //dejar la consulta lista para el siguiente atributo
                    CadenaModificar += "','";
            }
            MessageBox.Show("CadenaModificar: " + CadenaModificar);
            //--Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(CadenaModificar);
        }

        public void RestaurarContrasegna(string codigoUsuario)
        {
            string Cadena = "exec RestaurarContrasegna '" + codigoUsuario +"'";

            //MessageBox.Show("CadenaModificar: " + Cadena);
            //--Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(Cadena);
        }

        public void CambiarContrasegna(string codigoUsuario, string nuevaContraseña)
        {
            string Cadena = "exec CambiarContrasegna '" + codigoUsuario + "', '" + nuevaContraseña + "'";

            //MessageBox.Show("CadenaModificar: " + Cadena);
            //--Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(Cadena);
        }

        public string ObtenerContrasegna(string codigoUsuario)
        {
            //--Formar la consulta
            string Cadena = "exec ObtenerContrasegna '" + codigoUsuario + "'";
            //--Ejecutar la consulta
            aConexion.EjecutarSelect(Cadena);
            //return aConexion.Datos.Tables[0];
            //DataTable dt = Registro(codigoUsuario);

            MessageBox.Show("CadenaModificar: " + Cadena);
            //--Ejecutar la consulta para insertar el registro
            return aConexion.Datos.Tables[0].Rows[0][0].ToString();
        }
    }
}
