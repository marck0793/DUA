using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class EntBoleta
    {
        #region
        public Int16 id_boleta { set; get; }
        public String desc_boleta { set; get; }
        public List<Entidad.EntDetalle> listDetalle { set; get; }

        public EntBoleta() {
            id_boleta = 0;
          listDetalle = new List<Entidad.EntDetalle>();
        }
        #endregion
    }
}
