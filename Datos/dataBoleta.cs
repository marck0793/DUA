using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class dataBoleta
    {
       // SqlCommand comandoSQL;
        #region Guardar Boleta
        public static Boolean GuardarBoleta(EntBoleta entBoleta)
        {
            //SqlConnection conectar = new SqlConnection(ADConexion.ConexionR2()); conectar.Open();
            SqlCommand comandoSQL = ClsConexion.GET_CONEXION().CreateCommand();
            //  comando  SqlCommand comandoSQL = new SqlCommand();  
            comandoSQL.CommandText = "paInsertarBoletaDetalle";
            comandoSQL.CommandType = System.Data.CommandType.StoredProcedure;
           // comandoSQL.Connection = conectar;
            try { comandoSQL.Parameters.Clear();
                DataTable dtTipoDetalle = new DataTable();
                dtTipoDetalle.Columns.Add("id_boleta", typeof(int));
                dtTipoDetalle.Columns.Add("num_linea", typeof(int));
                dtTipoDetalle.Columns.Add("detalle", typeof(string));
                foreach (EntDetalle objDetalle in entBoleta.listDetalle) {
                    DataRow dr = dtTipoDetalle.NewRow();
                    dr["id_boleta"] = objDetalle.id_boleta;
                    dr["num_linea"] = objDetalle.numLinea;
                    dr["detalle"] = objDetalle.detalle;
                    dtTipoDetalle.Rows.Add(dr); }
                comandoSQL.Parameters.Add(new SqlParameter("@listatipoDetalle", dtTipoDetalle));
                comandoSQL.Parameters.Add(new SqlParameter("@id_boleta", entBoleta.id_boleta));
                comandoSQL.Parameters.Add(new SqlParameter("@descri_boleta", entBoleta.desc_boleta));
                comandoSQL.ExecuteNonQuery(); return true;
            }
            catch (Exception ex) { throw ex;
            }
            finally
            {
                if (comandoSQL.Connection.State == System.Data.ConnectionState.Open)
                {
                    comandoSQL.Connection.Close();
                }
                comandoSQL.Dispose();
            }
        }
        #endregion


        #region 

        #endregion


    }
}
