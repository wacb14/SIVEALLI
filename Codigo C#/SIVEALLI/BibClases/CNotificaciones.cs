using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibClases
{
    public class CNotificaciones : CEntidad
    {

        public CNotificaciones() : base("TNotificaciones")
        {
        }

        public override string[] NombresAtributos()
        {
            return new string[]
            {
                "IdNotificacion", "Mensaje","Estado"
            };
        }

        public DataTable ListaNoLeidos()
        {
            string CadenaListar = "exec MensajesNoLeidos";
            aConexion.EjecutarSelect(CadenaListar);
            return aConexion.Datos.Tables[0];
        }
    }
}
