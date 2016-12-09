using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidad;
using Datos;
using System.Data.SqlClient;

namespace Datos
{
    public class dataDetalleDua
    {
        ClsConexion conectar;
            /* public SqlConnection SQL()
          {
              try
              {
                  //instancia
                  return new SqlConnection (String.Format(@"Server=GRETTEL\ULATE;Initial Catalog=Dua;Integrated Security=True"));
              }
              catch (Exception ex)
              {
                  throw ex;
              }
          }*/

        #region   // obtener valor de paises

        public DataTable obtenerPaisOrigen()
        {
           // String descripcion = "Despacho";
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();
        

            DataTable dt = new DataTable();
           command.CommandText = "paObtenerPaises";
           command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Connection.Open();
            try
            {
                SqlDataAdapter daCMRegimen = new SqlDataAdapter(command);
                daCMRegimen.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State == System.Data.ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }


        #endregion

        #region   // obtener valor de PUEERTOS

        public DataTable obtenerPuerto()
        {
           // String descripcion = "Despacho";
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();


            DataTable dt = new DataTable();
            command.CommandText = "paObtenerPuertos";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Connection.Open();
            try
            {
                SqlDataAdapter daCMRegimen = new SqlDataAdapter(command);
                daCMRegimen.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State == System.Data.ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }

        #endregion

        #region   // obtener  monedas

        public DataTable obtenerMonedas()
        {
            //String descripcion = "Despacho";
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();


            DataTable dt = new DataTable();
            command.CommandText = "paObtenerMonedas";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Connection.Open();
            try
            {
                SqlDataAdapter daCMRegimen = new SqlDataAdapter(command);
                daCMRegimen.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State == System.Data.ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }



        #endregion

        #region   // obtener Unidades

        public DataTable obtenerUnidades()
        {
            //String descripcion = "Despacho";
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();


            DataTable dt = new DataTable();
            command.CommandText = "paObtenerUnidades";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Connection.Open();
            try
            {
                SqlDataAdapter daCMRegimen = new SqlDataAdapter(command);
                daCMRegimen.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State == System.Data.ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }

        #endregion

        #region   // obtener  arancel partidas

        public DataTable obtenerArancelPartidas()
        {
            //String descripcion = "Despacho";
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();


            DataTable dt = new DataTable();
            command.CommandText = "paObtenerArancelPartida";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Connection.Open();
            try
            {
                SqlDataAdapter daCMRegimen = new SqlDataAdapter(command);
                daCMRegimen.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State == System.Data.ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }


        #endregion
        #region   // obtener  condicioPruebas

        public DataTable obtenercatalogocondicionEntrega()
        {
            //String descripcion = "Despacho";
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();


            DataTable dt = new DataTable();
            command.CommandText = "paObtenerMonedas";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Connection.Open();
            try
            {
                SqlDataAdapter daCMRegimen = new SqlDataAdapter(command);
                daCMRegimen.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State == System.Data.ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }


        #endregion
        #region   // obtener  condicionEntrega
        public DataTable obtenerCatalogocondicionEntrega()
        {
            //String descripcion = "Despacho";
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();


            DataTable dt = new DataTable();
            command.CommandText = "paCondicEntrada";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Clear(); 
            command.Connection.Open();
            try
            {
                SqlDataAdapter daCMRegimen = new SqlDataAdapter(command);
                daCMRegimen.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State == System.Data.ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }
        #endregion
        #region   // obtener  TRATADO  CONVENCIONAL
        public DataTable obtenerTratadoConvencional()
        {
            //String descripcion = "Despacho";
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();


            DataTable dt = new DataTable();
            command.CommandText = "tratadoConvensional";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Connection.Open();
            try
            {
                SqlDataAdapter daCMRegimen = new SqlDataAdapter(command);
                daCMRegimen.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (command.Connection.State == System.Data.ConnectionState.Open)
                {
                    command.Connection.Close();
                }
                command.Dispose();
            }
        }


        #endregion

       

public static Boolean guardarDetalle(ScDUAInicial duaInicial)
{
//   SqlConnection conectar = new data().SQL();

//comando
SqlCommand comandoSQL = ClsConexion.GET_CONEXION().CreateCommand();
            // SqlCommand comandoSQL = new SqlCommand();
            // conectar.Open();
            //comandoSQL.CommandText = "paInsertarDetalle";
            comandoSQL.CommandText = "paInsertarActualizarDUAInicialyDetalle";
comandoSQL.CommandType = System.Data.CommandType.StoredProcedure;
// comandoSQL.Connection = conectar;

try
{
   comandoSQL.Parameters.Clear();
   DataTable dtTipoDetalle = new DataTable();
   dtTipoDetalle.Columns.Add("ScFechaDua", typeof(DateTime));
   dtTipoDetalle.Columns.Add("ScAngoDua", typeof(Int32));
 
   dtTipoDetalle.Columns.Add("ScNumeroDua", typeof(Int32));
   dtTipoDetalle.Columns.Add("ScModalidad", typeof(Int32));
                // dtTipoDetalle.Columns.Add("ScIdRegimen", typeof(Int32));
    dtTipoDetalle.Columns.Add("ScIdAduana", typeof(Int32));
  /* dtTipoDetalle.Columns.Add("ScIdAduanaIngresoDestino", typeof(Int32));
   dtTipoDetalle.Columns.Add("ScTipoIdentificacion", typeof(Int32));
   dtTipoDetalle.Columns.Add("ScNumeroIdentificacion", typeof(Int32));
   dtTipoDetalle.Columns.Add("ScTipoIdentificadorDeclarante", typeof(char));
   dtTipoDetalle.Columns.Add("ScNumeroIdentificacionDeclarante", typeof(string));
   dtTipoDetalle.Columns.Add("ScIdTransporte", typeof(Int32));
   dtTipoDetalle.Columns.Add("ScSumatoriaCantidadBultos", typeof(string));
   dtTipoDetalle.Columns.Add("ScValidacionValorAduanero", typeof(string));
   dtTipoDetalle.Columns.Add("ScTotalPesoBruto", typeof(Int32));
   dtTipoDetalle.Columns.Add("ScTotalPesoNeto", typeof(Int32));
   dtTipoDetalle.Columns.Add("ScTipoCambioDolar", typeof(decimal));
   dtTipoDetalle.Columns.Add("ScTotalMonedasColones", typeof(Int32));
   dtTipoDetalle.Columns.Add("ScImpuestoTotal", typeof(Int32));
   dtTipoDetalle.Columns.Add("ScEstado", typeof(string));*/

                ///------------------------------------
  dtTipoDetalle.Columns.Add("ScNombreConsignatorio",typeof(string));
                dtTipoDetalle.Columns.Add("ScIdPaisOrigen", typeof(string));
                dtTipoDetalle.Columns.Add("ScPaisDestino", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScPaisPuertoEmbarque", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScPuertoArribo", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScPuertoSalida", typeof(Int32));
               dtTipoDetalle.Columns.Add("ScNumLinea", typeof(Int32)); 
                dtTipoDetalle.Columns.Add("ScCantidadBultos", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScCantidadUnidades", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScDescriProductoResumido", typeof(string));
                dtTipoDetalle.Columns.Add("ScDescriProductoDetallado", typeof(string));
                dtTipoDetalle.Columns.Add("ScIdPartidaArancel", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScValorSeguro", typeof(decimal));
                dtTipoDetalle.Columns.Add("ScValorFlete", typeof(decimal));
                dtTipoDetalle.Columns.Add("ScValorOtros", typeof(decimal));
                dtTipoDetalle.Columns.Add("ScValorFactura", typeof(decimal));
                dtTipoDetalle.Columns.Add("ScValorAduaneroCIF_FOB", typeof(string));
                dtTipoDetalle.Columns.Add("ScValorSeguroPesoBruto", typeof(int));
                dtTipoDetalle.Columns.Add("ScPesoNeto", typeof(int));
                dtTipoDetalle.Columns.Add("ScIdMoneda", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScTratadoConvenioInternacional", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScImpuestoDAI", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScImpuestoSelectivoConsumo", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScImpuestoLey6946", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScImpuestoIDA", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScImpuestoIFAM", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScImpuestoLey7922", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScImpuestoLey8114", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScImpuestoForestal", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScImpuestoCaldera", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScImpuestoVentas", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScImpuestoSalvaguarda", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScImpuestoGofito", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScCodigoExoneracion", typeof(Int32));
                dtTipoDetalle.Columns.Add("ScExoneracionDAI", typeof(string));
                dtTipoDetalle.Columns.Add("ScExoneracionSelectivoConsumo", typeof(string));
                dtTipoDetalle.Columns.Add("ScExoneracionVentas", typeof(string));
                dtTipoDetalle.Columns.Add("ScIdCondicionEntrega", typeof(string));
                dtTipoDetalle.Columns.Add("ScIdPaisAdquisicion", typeof(string));



                foreach (detalleDua objDetalle in duaInicial.listaDetalleDua)
   {
       DataRow dr = dtTipoDetalle.NewRow();
       dr["ScFechaDua"] = objDetalle.ScFechaDua;
       dr["ScAngoDua"] = objDetalle.ScAngoDua;
       dr["ScNumeroDua"] = objDetalle.ScNumeroDua;

       dr["ScModalidad"] = objDetalle.ScModalidad;
       dr["ScIdAduana"] = objDetalle.ScIdAduana;
       dr["ScNombreConsignatorio"] = objDetalle.ScNombreConsignatorio;
       dr["ScIdPaisOrigen"] = objDetalle.ScIdPaisOrigen;
       dr["ScPaisDestino"] = objDetalle.ScPaisDestino;
       dr["ScPaisPuertoEmbarque"] = objDetalle.ScPaisPuertoEmbarque;
       dr["ScPuertoArribo"] = objDetalle.ScPuertoArribo;
       dr["ScPuertoSalida"] = objDetalle.ScPuertoSalida;
      dr["ScNumLinea"] = objDetalle.ScNumLinea;
       dr["ScCantidadBultos"] = objDetalle.ScCantidadBultos;
       dr["ScCantidadUnidades"] = objDetalle.ScCantidadUnidades;
       dr["ScDescriProductoResumido"] = objDetalle.ScDescriProductoResumido;
       dr["ScDescriProductoDetallado"] = objDetalle.ScDescriProductoDetallado;
       dr["ScIdPartidaArancel"] = objDetalle.ScIdPartidaArancel;
       dr["ScValorSeguro"] = objDetalle.ScValorSeguro;
       dr["ScValorFlete"] = objDetalle.ScValorFlete;
       dr["ScValorOtros"] = objDetalle.ScValorOtros;
       dr["ScValorFactura"] = objDetalle.ScValorFactura;
       dr["ScValorAduaneroCIF_FOB"] = objDetalle.ScValorAduaneroCIF_FOB;
       dr["ScValorSeguroPesoBruto"] = objDetalle.ScValorSeguroPesoBruto;
       dr["ScPesoNeto"] = objDetalle.ScPesoNeto;
       dr["ScIdMoneda"] = objDetalle.ScIdMoneda;
       dr["ScTratadoConvenioInternacional"] = objDetalle.ScTratadoConvenioInternacional;
       dr["ScImpuestoDAI"] = objDetalle.ScImpuestoDAI;
       dr["ScImpuestoSelectivoConsumo"] = objDetalle.ScImpuestoSelectivoConsumo;
       dr["ScImpuestoLey6946"] = objDetalle.ScImpuestoLey6946;
       dr["ScImpuestoIDA"] = objDetalle.ScImpuestoIDA;
       dr["ScImpuestoIFAM"] = objDetalle.ScImpuestoIFAM;
       dr["ScImpuestoLey7922"] = objDetalle.ScImpuestoLey7922;
       dr["ScImpuestoLey8114"] = objDetalle.ScImpuestoLey8114;
       dr["ScImpuestoForestal"] = objDetalle.ScImpuestoForestal;
       dr["ScImpuestoCaldera"] = objDetalle.ScImpuestoCaldera;
       dr["ScImpuestoVentas"] = objDetalle.ScImpuestoVentas;
       dr["ScImpuestoSalvaguarda"] = objDetalle.ScImpuestoSalvaguarda;
       dr["ScImpuestoGofito"] = objDetalle.ScImpuestoGofito;
       dr["ScCodigoExoneracion"] = objDetalle.ScCodigoExoneracion;
       dr["ScExoneracionDAI"] = objDetalle.ScExoneracionDAI;
       dr["ScExoneracionSelectivoConsumo"] = objDetalle.ScExoneracionSelectivoConsumo;
       dr["ScExoneracionVentas"] = objDetalle.ScExoneracionVentas;
       dr["ScIdCondicionEntrega"] = objDetalle.ScIdCondicionEntrega;
       dr["ScIdPaisAdquisicion"] = objDetalle.ScIdPaisAdquisicion;
      dtTipoDetalle.Rows.Add(dr);
   }
   comandoSQL.Parameters.Add(new SqlParameter("@listadetalleD", dtTipoDetalle));

   comandoSQL.Parameters.Add(new SqlParameter("@fecha", duaInicial.ScFechaDua));
   comandoSQL.Parameters.Add(new SqlParameter("@ango", duaInicial.ScAngoDua));
       comandoSQL.Parameters.Add(new SqlParameter("@modalidad", duaInicial.ScModalidad));
   comandoSQL.Parameters.Add(new SqlParameter("@numDua", duaInicial.ScNumeroDua));


   comandoSQL.Parameters.Add(new SqlParameter("@regimen", duaInicial.ScIdRegimen));

   comandoSQL.Parameters.Add(new SqlParameter("@aduana", duaInicial.ScIdAduana));
   comandoSQL.Parameters.Add(new SqlParameter("@aduanaIngresoDestino", duaInicial.ScIdAduanaIngresoDestino));

   comandoSQL.Parameters.Add(new SqlParameter("@tipoIdentif", duaInicial.ScTipoIdentificacion));
   comandoSQL.Parameters.Add(new SqlParameter("@numIdent", duaInicial.ScNumeroIdentificacion));
   comandoSQL.Parameters.Add(new SqlParameter("@tipoIdentificador", duaInicial.ScTipoIdentificacion));
   comandoSQL.Parameters.Add(new SqlParameter("@numeroIdentificante", duaInicial.ScNumeroIdentificacionDeclarante));
   comandoSQL.Parameters.Add(new SqlParameter("@IdTransporte", duaInicial.ScIdTransporte));
   comandoSQL.Parameters.Add(new SqlParameter("@cantBultos", duaInicial.ScSumatoriaCantidadBultos));
   comandoSQL.Parameters.Add(new SqlParameter("@validacion", duaInicial.ScValidacionValorAduanero));
   comandoSQL.Parameters.Add(new SqlParameter("@pesoBru", duaInicial.ScTotalPesoBruto));
   comandoSQL.Parameters.Add(new SqlParameter("@pesoNeto", duaInicial.ScTotalPesoNeto));
   comandoSQL.Parameters.Add(new SqlParameter("@cambDolar", duaInicial.ScTipoCambioDolar));
   comandoSQL.Parameters.Add(new SqlParameter("@monedasColones", duaInicial.ScTotalMonedasColones));
   comandoSQL.Parameters.Add(new SqlParameter("@impuesto", duaInicial.ScImpuestoTotal));
   comandoSQL.Parameters.Add(new SqlParameter("@estado", duaInicial.ScEstado));




                comandoSQL.Connection.Open();
                comandoSQL.ExecuteNonQuery();
   return true;
}
catch (Exception ex)
{
                Console.Write("ERROR: "+ ex.Message);
                return false;
}
finally
{
                //Cerrar conexión
                  if (comandoSQL.Connection.State == System.Data.ConnectionState.Open)
                  {
                    comandoSQL.Connection.Close();
                  }
              
                  comandoSQL = null;

            }
       }
    }
}
