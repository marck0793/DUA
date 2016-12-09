using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;


namespace Logica
{
   public  class logicaDetalle
    {
       public Boolean GuardarBoletaLN(ScDUAInicial duaInicial)
        {
            try
            {
                return dataDetalleDua.guardarDetalle(duaInicial);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
