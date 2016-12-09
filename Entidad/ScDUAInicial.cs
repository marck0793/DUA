using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public  class ScDUAInicial
    {
        #region "AtributosMetodos"
        public DateTime ScFechaDua { get; set; }
        public Int32 ScAngoDua { get; set; }
        public Int32 ScNumeroDua { get; set; }
        public Int32 ScModalidad { get; set; }
        public Int32 ScIdRegimen { get; set; }
        public Int32 ScIdAduana { get; set; }
        public Int32 ScIdAduanaIngresoDestino { get; set; }
        public char ScTipoIdentificacion { get; set; }
        public string ScNumeroIdentificacion { get; set; }
        public string ScTipoIdentificadorDeclarante { get; set; }
        public Int32 ScNumeroIdentificacionDeclarante { get; set; }
        public Int32 ScIdTransporte { get; set; }
        public string ScSumatoriaCantidadBultos { get; set; }
        public string ScValidacionValorAduanero { get; set; }
        public Int32 ScTotalPesoBruto { get; set; }
        public Int32 ScTotalPesoNeto { get; set; }
        public decimal ScTipoCambioDolar { get; set; }
        public Int32 ScTotalMonedasColones { get; set; }
        public Int32 ScImpuestoTotal { get; set; }
        public string ScEstado { get; set; }
        public List<detalleDua> listaDetalleDua { get; set; }

        #endregion
        #region "Constructor"
        public ScDUAInicial()
        {
            ScAngoDua = 0;
            ScNumeroDua = 0;
            ScModalidad = 0;
            ScIdRegimen = 0;
            ScIdAduana = 0;
            ScIdAduanaIngresoDestino = 0;
            ScTipoIdentificacion =' ';
            ScNumeroIdentificacion = "";
            ScTipoIdentificadorDeclarante = "";
            ScNumeroIdentificacionDeclarante = 0;
            ScIdTransporte = 0;
            ScSumatoriaCantidadBultos = "";
            ScValidacionValorAduanero = "";
            ScTotalPesoNeto = 0;
            ScTipoCambioDolar = 0;
            ScTotalMonedasColones = 0;
            ScImpuestoTotal = 0;
            ScEstado = "";
            listaDetalleDua = new List<Entidad.detalleDua>();

        }
        #endregion
    }
}
