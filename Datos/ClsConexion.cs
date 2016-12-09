using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class ClsConexion
    {

        #region Get_Conexion()
        public static SqlConnection GET_CONEXION()
        {
            return new
            SqlConnection(String.Format(@"Server=GRETTEL;Initial Catalog=Dua;Integrated Security=True"));
        }
        #endregion


        #region ValidarEmpleado
        public ClsEmpleado ValidarUsuario(string clave, string nombre)
        {
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();
            try
            {
                ClsEmpleado empleado = new ClsEmpleado();
               command.CommandText = "paValidarEmpleado";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@nombreEmpleado", nombre));
                command.Parameters.Add(new SqlParameter("@Clave", clave));
                command.Connection.Open();
                SqlDataReader RESULTADO = ((SqlDataReader)command.ExecuteReader());
                if (RESULTADO.Read())
                {
                    empleado.Clave = clave;
                    empleado.NombreEmpleado = nombre;
                    empleado.IdEmpleado = Convert.ToInt16(RESULTADO["IdEmpleado"]);
                    empleado.CorreoEmpleado = RESULTADO["NombreEmpleado"].ToString();
                }
                return empleado;
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

        #region obtine el ultimo valor de la consulta
        public DataSet obtenerNumDua() {

            //obtenerNumDua
           // String numDua;
          //  int ultimoValorDua;
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();
           
            DataSet dt = new DataSet();

            command.CommandText = "obtenerNumDua";
    
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



        #region
        public string obenerNumD() {
        
            //  MySqlConnection conn = ;

            SqlCommand cmd = GET_CONEXION().CreateCommand();
            String valor ="";                       
            try
            {
                //Console.Write("------------------------entro al try de insertar-------------------------------------------------------------------------------");
                cmd.CommandText = "select top 1((ScNumeroDua)+1)from ScDUAInicial order by [ScNumeroDua] desc;";
                // cmd.CommandText = "INSERT INTO persona (nombre,apellido,telef) value ('andres','roman',123);";
                //conn.open();
               // Console.Write("fue a insertar");
                cmd.ExecuteNonQuery();
                //  System.Windows.Forms.MessageBox.Show("me esta retornando 1");
               
                cmd.Connection.Open();
                valor = cmd.CommandText;
                return valor ;
            } catch (Exception)  {
              //  Console.Write("cayo al catch -------------------------------------------------------");

               // MessageBox.Show("me esta retornando 0");
                return "error";
            }     
   
        }
        #endregion

        #region inserta

        // public ScDUAInicial insertarDua(Int16 numerDua, Int16 idM, Int16 idRegimen, Int16 idtransp, Int16 idAduan, string tipoIdentif, string sumaCantidadBultos)
        public void insertarDua(DateTime fecha, int ango, int modalidad, int numDua, int regimen, int aduana, int aduanaIngresoDestino,
           int tipoIdent, string numIdent, char tipoIdentificador, int numeroIdentificante,
   int IdTransporte, string cantBultos, string validacion, int pesBru, int pesoNeto, decimal cambioDolar, int monedasColones, int impuesto)
    {
          // string valor = "hola";
           char estado ='d';
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();
            try
            {
                ScDUAInicial dua = new ScDUAInicial();
                command.CommandText = "insertarDuaI";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@fecha", fecha));  //

                command.Parameters.Add(new SqlParameter("@ango", ango));
                command.Parameters.Add(new SqlParameter("@modalidad", modalidad));
                command.Parameters.Add(new SqlParameter("@numDua", numDua));
                command.Parameters.Add(new SqlParameter("@regimen", regimen));
                command.Parameters.Add(new SqlParameter("@aduana", aduana));
                command.Parameters.Add(new SqlParameter("@aduanaIngresoDestino",aduanaIngresoDestino));
                command.Parameters.Add(new SqlParameter("@tipoIdentif", tipoIdent));
                command.Parameters.Add(new SqlParameter("@numIdent", numIdent));
                command.Parameters.Add(new SqlParameter("@tipoIdentificador", tipoIdentificador));
                command.Parameters.Add(new SqlParameter("@numeroIdentificante", numeroIdentificante));
                command.Parameters.Add(new SqlParameter("@IdTransporte", IdTransporte));
                command.Parameters.Add(new SqlParameter("@cantBultos", cantBultos));
                command.Parameters.Add(new SqlParameter("@validacion", validacion));
                command.Parameters.Add(new SqlParameter("@pesoBru", pesBru));
                command.Parameters.Add(new SqlParameter("@pesoNeto", pesoNeto));
                command.Parameters.Add(new SqlParameter("@cambDolar", cambioDolar));
                command.Parameters.Add(new SqlParameter("@monedasColones", monedasColones));
                command.Parameters.Add(new SqlParameter("@impuesto", impuesto));
                command.Parameters.Add(new SqlParameter("@estado", estado));
                command.Connection.Open();
                SqlDataReader RESULTADO = ((SqlDataReader)command.ExecuteReader());
                /* if (RESULTADO.Read())
                 {
                     empleado.Clave = clave;
                     empleado.NombreEmpleado = nombre;
                     empleado.IdEmpleado = Convert.ToInt16(RESULTADO["IdEmpleado"]);
                     empleado.CorreoEmpleado = RESULTADO["NombreEmpleado"].ToString();
                 }*/
               // return dua;
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




        ///
        #region insertarDuaInicial
        /* public ScDUAInicial insertarDua() 
        {
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();
            try
            {
                ScDUAInicial duaInicial = new ScDUAInicial();
                command.CommandText = "paValidarEmpleado";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@nombreEmpleado", ScAngoDua));
                command.Parameters.Add(new SqlParameter("@Clave", clave));
                command.Connection.Open();
                SqlDataReader RESULTADO = ((SqlDataReader)command.ExecuteReader());
                if (RESULTADO.Read())
                {
                    duaInicial.Clave = clave;
                    duaInicial.NombreEmpleado = nombre;
                    duaInicial.IdEmpleado = Convert.ToInt16(RESULTADO["IdEmpleado"]);
                    duaInicial.CorreoEmpleado = RESULTADO["NombreEmpleado"].ToString();
                }
                return empleado;
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


        */
        public void insertarClientes(ScDUAInicial dua)
        {

            SqlTransaction trans1 = null;

            // SqlCommand comandoSQL = null;
            // SqlConnection conectar = null;
            SqlCommand comandoSQL = ClsConexion.GET_CONEXION().CreateCommand();
            try
            {
                // conectar = Conexion.GetConexion();
                // conectar.Open();
                // comandoSQL = conectar.CreateCommand();
                //trans1 = conectar.BeginTransaction();

                comandoSQL.CommandText = "pa_insertarClientes";

                comandoSQL.CommandType = System.Data.CommandType.StoredProcedure;
                //asociar comando a la transacción
                comandoSQL.Transaction = trans1;
                //  comandoSQL.Connection = conectar;

                //limpiar parámetros
                comandoSQL.Parameters.Clear();

                comandoSQL.Parameters.Add(new SqlParameter("@nombre", dua.ScAngoDua));
                comandoSQL.Parameters.Add(new SqlParameter("@apellido", dua.ScModalidad));
                comandoSQL.Parameters.Add(new SqlParameter("@genero", dua.ScIdAduana));

                comandoSQL.ExecuteNonQuery();

                trans1.Commit();
                //MessageBox.Show("Se ha insertado correctamente el cliente " + dua.nombre + dua.apellido);
                //   return true;
            }
            catch (Exception ex)
            {
                //confirmar negativamente transaccion
                trans1.Rollback();
                throw ex;

            }
            finally
            {


            }
        }
        #endregion
        #region   // obtener los valores del catalogModalidadRegimn y poder llenar el downdroplist

        public DataTable obtenerCMregimen()
        {
          //  String descripcion = "Despacho";
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();
           

                DataTable dt = new DataTable();
              //  String consulta = "select * from catalogoModalidadRegimen;";
                command.CommandText = "seleccion";
                    //"obtenerCMRegimen";
                //string consuta = 
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




        #region   // obtener los valores del catalogRegimn y poder llenar el downdroplist

        public DataTable obtenerRegimen()
        {
            
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();

            DataTable dt = new DataTable();
           //  String consulta = "select * from catalogoModalidadRegimen;";
             command.CommandText = "cargarRegim";
                //"obtenercatRegimen";
            //"obtenerCMRegimen";
            //string consuta = 
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Clear();
            //command.Parameters.Add(new SqlParameter(" @descripcion",descripcion));
                
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


        #region obtiene la aduana
        public DataTable obtenerAduana()
        {
            
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();

            DataTable dt = new DataTable();
            //  String consulta = "select * from catalogoModalidadRegimen;";
            command.CommandText = "obtenerCatAduanas";
            //"obtenerCMRegimen";
            //string consuta = 
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Clear();
           // command.Parameters.Add(new SqlParameter(" @descripcion",descripcion));
                
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

        #region
        public DataTable obtenerTransporte()
        {

            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();

            DataTable dt = new DataTable();
            //  String consulta = "select * from catalogoModalidadRegimen;";
            command.CommandText = "obtenerCatTransporte";
            //"obtenerCMRegimen";
            //string consuta = 
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Clear();
            // command.Parameters.Add(new SqlParameter(" @descripcion",descripcion));

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
        //obtener el web service
        #region
        public DataSet obtenerWebService() {
            string tbFecha = DateTime.Now.ToString("dd/MM/yyyy");
            cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos ws = new cr.fi.bccr.indicadoreseconomicos.wsIndicadoresEconomicos();
            try
            {
                DataSet cambioDolar = ws.ObtenerIndicadoresEconomicos("317", tbFecha, tbFecha, "grettel ulate", "N");
                  
                return cambioDolar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region mostrar lista de inicial dua


        public DataTable mostrarListaInicialDua()
        {

            //obtenerNumDua
           // String numDua;
           // int ultimoValorDua;
            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();

            DataTable dt = new DataTable();

            command.CommandText = "mostrarListaDuaInicial";

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








#region insertarDuaInicial
 public DataSet insertarDua() 
{
             SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();
            /* try
             {
                string num = "";
                 command.CommandText = "insertarUltimoNumDua";
                         command.CommandType = System.Data.CommandType.StoredProcedure;
                         command.Connection.Open();
                        // num = command.CommandType();
                 return num;
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
             }*/



            //    String query = "select top 1((ScNumeroDua)+1)from ScDUAInicial order by [ScNumeroDua] desc;";
       /* public DataTable obtenerAduana()
        {

            SqlCommand command = ClsConexion.GET_CONEXION().CreateCommand();
            */
            DataSet dt = new DataSet();
            //  String consulta = "select * from catalogoModalidadRegimen;";
            command.CommandText = "insertarUltimoNumDua";
            //"obtenerCMRegimen";
            //string consuta = 
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Clear();
            // command.Parameters.Add(new SqlParameter(" @descripcion",descripcion));

            command.Connection.Open();
            try
            {
                SqlDataAdapter daCMRegimen = new SqlDataAdapter(command);
                daCMRegimen.Fill(dt);
               // string num = Convert.ToString(dt).ToString();
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


















}
}
