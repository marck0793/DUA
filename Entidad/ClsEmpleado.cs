using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ClsEmpleado
    {

        #region "AtributosMetodos"
        public Int16 IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string Clave { get; set; }
        public String CorreoEmpleado { get; set; }
        #endregion
        #region "Constructor"
        public ClsEmpleado()
        {
            IdEmpleado = 0;
            NombreEmpleado = string.Empty;

            Clave = string.Empty;
            CorreoEmpleado = string.Empty;
        }
        #endregion

    }

}
