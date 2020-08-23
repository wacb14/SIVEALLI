using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibClases
{

    class Procesos
    {

        /// <summary>
        /// Validamos el solo ingreso de numeros y un solo signo separador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void ValidarFloat(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == ',' && textBox.Text.Contains(","))
                {
                    e.Handled = true;
                    return;
                }
                Keys key = (Keys)e.KeyChar;
                if (!(key == Keys.Back) && !(e.KeyChar == ','))
                {

                    e.Handled = true;
                }
            }
        }

        public static void ValidarTextBoxSoloNumeros(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!(char.IsDigit(e.KeyChar)))
            {
                Keys key = (Keys)e.KeyChar;
                if (!(key == Keys.Back))
                {
                    e.Handled = true;
                }
            }

        }

        /// <summary>
        /// Modulo sirve para el ingreso de solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void ValidarTextBoxSoloLetras(object sender, KeyPressEventArgs e)
        {
            //Validamos que el ingreso de datos sea una letra, retroceder, borrar o espacio
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Separator))
            {
                //Si quitamos esta validacion, no podra ser ingresado el espacio en el textBox
                if (!(char.IsDigit(e.KeyChar)))
                {
                    e.Handled = false;
                    return;
                }
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Modifica el texto a mayusuculas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void PonerEnMayusculas(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            textBox.Text = textBox.Text.ToUpper();
        }

        //Valida que en caso se escriba una coma en un textBox vacio, modificarlo
        //para que el formato sea correcto
        public static void ValidarComa(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            string contenido = textBox.Text;
            if (contenido.Equals(","))
            {
                textBox.Text = "0,";
            }
        }

    }
}
