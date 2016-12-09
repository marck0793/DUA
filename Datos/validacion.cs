using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;


namespace Datos
{
    public class validacion
    {

       // bool invalid = false;
       /* public void soloLetras(KeyPressEventArgs e) {
            try {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(Char.IsControl(e.KeyChar)){//tecla de control  como la tecla de borrar
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar)) //tecla para dar espaio
                {
                    e.Handled = false;
                }
                else {
                    e.Handled = true; //para que no se acepte numeros
                }
            }catch(Exception ex){

            }
        }
        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {//tecla de control  como la tecla de borrar
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar)) //tecla para dar espaio
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true; //para que no se acepte LETRAAS
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void noPermitirEspacios()
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {//tecla de control  como la tecla de borrar
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar)) //tecla para dar espaio
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true; //para que no se acepte LETRAAS
                }
            }
            catch (Exception ex)
            {

            }
        }
        **/

        public bool validarCorreo(string email)
        {

            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)\\.\\w+([-.]\\w+)";

            if(Regex.IsMatch(email,expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else { return false;
                }
            }
                else { 
                    return false;
            }
        }
    

    }
}
