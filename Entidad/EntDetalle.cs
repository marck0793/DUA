using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EntDetalle
    {
        #region
        public Int16 id_boleta { set; get; }
        public Int16 numLinea { set; get; }
        public String detalle { set; get; }
        #endregion

        #region // cnstructor
        public EntDetalle() {
            id_boleta = 0;
            numLinea = 0;
            detalle = "";


        }
        #endregion
    }
}
