using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class detalleDua
    {
        public DateTime ScFechaDua { set; get; }
        public Int32 ScAngoDua { set; get; }
        public Int32 ScNumeroDua { set; get; }
    public Int32 ScModalidad { set; get; }
        public Int32 ScIdAduana { set; get; }
        public string ScNombreConsignatorio { set; get; }
        public Int32 ScIdPaisOrigen { set; get; }
        public Int32 ScPaisDestino { set; get; } // deberia ser un int
        public Int32 ScPaisPuertoEmbarque { set; get; }
        public Int32 ScPuertoArribo { set; get; }
        public Int32 ScPuertoSalida { set; get; }
        public Int32 ScNumLinea { set; get; }
        public Int32 ScCantidadBultos { set; get; }
        public Int32 ScCantidadUnidades { set; get; }
        public string ScDescriProductoResumido { set; get; }
        public string ScDescriProductoDetallado { set; get; }
        public Int32 ScIdPartidaArancel { set; get; }
        public decimal ScValorSeguro { set; get; } // en la base esta como money
        public decimal ScValorFlete { set; get; }
        public decimal ScValorOtros { set; get; }
        public decimal ScValorFactura { set; get; }
        public string ScValorAduaneroCIF_FOB { set; get; }
        public int ScValorSeguroPesoBruto { set; get; }
        public int ScPesoNeto { set; get; }
        public Int32 ScIdMoneda { set; get; }
        public Int32 ScTratadoConvenioInternacional { set; get; }
        public Int32 ScImpuestoDAI { set; get; }
        public Int32 ScImpuestoSelectivoConsumo { set; get; }
        public Int32 ScImpuestoLey6946 { set; get; }
        public Int32 ScImpuestoIDA { set; get; }
        public Int32 ScImpuestoIFAM { set; get; }
        public Int32 ScImpuestoLey7922 { set; get; }
        public Int32 ScImpuestoLey8114 { set; get; }
        public Int32  ScImpuestoForestal { set; get; }
        public Int32 ScImpuestoCaldera { set; get; }
        public Int32 ScImpuestoVentas { set; get; }
        public Int32 ScImpuestoSalvaguarda { set; get; }
        public Int32 ScImpuestoGofito { set; get; }
        public Int32 ScCodigoExoneracion { set; get; }
        public string ScExoneracionDAI { set; get; }
        public string ScExoneracionSelectivoConsumo { set; get; }
        public string ScExoneracionVentas { set; get; }
        public string ScIdCondicionEntrega { set; get; }
        public string ScIdPaisAdquisicion { set; get; }

    public detalleDua() {

            ScFechaDua  =new DateTime();
            ScAngoDua = 0;
            ScNumeroDua = 0;
         ScModalidad = 0;
            ScIdAduana = 0;
            ScNombreConsignatorio = "";
         ScIdPaisOrigen = 0;
            ScPaisDestino =0;// deberia ser un int
            ScPaisPuertoEmbarque=0;
            ScPuertoArribo = 0;
            ScPuertoSalida = 0;
            ScNumLinea = 0;
            ScCantidadBultos = 0;
            ScCantidadUnidades = 0;
            ScDescriProductoResumido = "";
            ScDescriProductoDetallado = "";
            ScIdPartidaArancel = 0;
            ScValorSeguro = 0;// en la base esta como money
            ScValorFlete = 0;
            ScValorOtros = 0;
            ScValorFactura = 0;
            ScValorAduaneroCIF_FOB = "";
         ScValorSeguroPesoBruto = 0;
         ScPesoNeto = 0;
         ScIdMoneda = 0;
         ScTratadoConvenioInternacional = 0;
         ScImpuestoDAI = 0;
         ScImpuestoSelectivoConsumo = 0;
         ScImpuestoLey6946 = 0;
         ScImpuestoIDA = 0;
         ScImpuestoIFAM = 0;
         ScImpuestoLey7922 = 0;
         ScImpuestoLey8114 = 0;
         ScImpuestoForestal = 0;
         ScImpuestoCaldera = 0;
         ScImpuestoVentas = 0;
         ScImpuestoSalvaguarda = 0;
         ScImpuestoGofito = 0;
         ScCodigoExoneracion = 0;
         ScExoneracionDAI = "";
         ScExoneracionSelectivoConsumo = "";
         ScExoneracionVentas= "";
         ScIdCondicionEntrega = "";
         ScIdPaisAdquisicion = "";

    }
}

}
