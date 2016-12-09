using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidad;
using System.Data.SqlClient;
//using System.Data;
using Datos;

namespace Logica
{
   public class logicaBoleta
    {
        #region
        public Boolean GuardarBoletaLN(EntBoleta entBoleta)

        {
            try
            {

                return dataBoleta.GuardarBoleta(entBoleta);

            }

            catch (Exception)

            {

                throw;
            }

        }
        #endregion

    }
}
