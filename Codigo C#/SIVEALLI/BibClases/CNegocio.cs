using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibClases
{
    public class CNegocio:CEntidad
    {
        public CNegocio() : base("TNegocio")
        {

        }
        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdModificacion", "Nombre", "Duegno", "RUC","Telefono", "Correo","Direccion","IGV","MontoSuperarDescuento","PorcentajeDescuento","Fecha"
            };
        }

        public void InsertarPrimeraVez(params string[] Atributos)
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
    }
}
