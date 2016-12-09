using System;
using System.Collections.Generic;
using Datos;
using System.Data;
using Entidad;
using System.Reflection;
using Logica;

namespace UI
{
    public partial class guiDetalleDua : System.Web.UI.Page
    {
       logicaDetalle logica;
        ClsConexion con;
        DataTable dtPaisOrigen;

        dataDetalleDua detDua;
        DataTable dtArribo;
        DataTable dtMoneda;
        DataTable arancelPartida;
        DataTable dtUnidad;
        DataTable dtPaisAdq;
        DataTable dTCondEntrega;
        detalleDua detalleD;
        ScDUAInicial duaInicial;
        protected void Page_Load(object sender, EventArgs e)
        {
            detDua = new dataDetalleDua();
            con = new ClsConexion();
            duaInicial = new ScDUAInicial();

            //// -------------------------
            if (!IsPostBack)
            {

                /////------------------------------
                dtPaisOrigen = detDua.obtenerPaisOrigen();
                ddlPaisOrigen.DataSource = dtPaisOrigen.DefaultView;
                ddlPaisOrigen.DataTextField = "descripcion";
                ddlPaisOrigen.DataValueField = "codigo";
                ddlPaisOrigen.DataBind();
                ddlPaisOrigen.SelectedIndex = 0;
                ////--------------------------
                dtPaisOrigen = detDua.obtenerPaisOrigen();
                DropDownList1.DataSource = dtPaisOrigen.DefaultView;
                DropDownList1.DataTextField = "descripcion";
                DropDownList1.DataValueField = "codigo";
                DropDownList1.DataBind();
                DropDownList1.SelectedIndex = 0;
                ////--------------------------
                dtArribo = detDua.obtenerPuerto();
                DropDownList3.DataSource = dtArribo.DefaultView;
                DropDownList3.DataTextField = "descripcion";
                DropDownList3.DataValueField = "codigo";
                DropDownList3.DataBind();
                DropDownList3.SelectedIndex = 0;
                ////--------------------------
                dtArribo = detDua.obtenerPuerto();
                DropDownList2.DataSource = dtArribo.DefaultView;
                DropDownList2.DataTextField = "descripcion";
                DropDownList2.DataValueField = "codigo";
                DropDownList2.DataBind();
                DropDownList2.SelectedIndex = 0;
                /////------------------------------arribo
                dtArribo = detDua.obtenerPuerto();
                DropDownList4.DataSource = dtArribo.DefaultView;
                DropDownList4.DataTextField = "descripcion";
                DropDownList4.DataValueField = "codigo";
                DropDownList4.DataBind();
                DropDownList4.SelectedIndex = 0;

                /////------------------------------
                dtMoneda = detDua.obtenerMonedas();
                DropDownList5.DataSource = dtMoneda.DefaultView;
                DropDownList5.DataTextField = "descripcion";
                DropDownList5.DataValueField = "codigo";
                DropDownList5.DataBind();
                DropDownList5.SelectedIndex = 0;
                /////------------------------------arancelPartida
                arancelPartida = detDua.obtenerArancelPartidas();
                DropDownList6.DataSource = arancelPartida.DefaultView;
                DropDownList6.DataTextField = "descripcion";
                DropDownList6.DataValueField = "codigo";
                DropDownList6.DataBind();
                DropDownList6.SelectedIndex = 0;
                #region /////------------------------------ COND DDE entrega
              /*  arancelPartida = detDua.obtenerCatalogocondicionEntrega();
                DropDownList6.DataSource = arancelPartida.DefaultView;
                DropDownList6.DataTextField = "descripcion";
                DropDownList6.DataValueField = "codigo";
                DropDownList6.DataBind();
                DropDownList6.SelectedIndex = 0;*/
    #endregion
                #region /////------------------------------ unidad
                dtUnidad = detDua.obtenerUnidades();
                DropDownList7.DataSource = dtUnidad.DefaultView;
                DropDownList7.DataTextField = "descripcion";
                DropDownList7.DataValueField = "codigo";
                DropDownList7.DataBind();
                DropDownList7.SelectedIndex = 0;
    #endregion
                #region/////----------------------------- TRATADO CNVENCIONAL


                dtUnidad = detDua.obtenerUnidades();
                DropDownList8.DataSource = dtUnidad.DefaultView;
                DropDownList8.DataTextField = "descripcion";
                DropDownList8.DataValueField = "codigo";
                DropDownList8.DataBind();
                DropDownList8.SelectedIndex = 0;
    #endregion
                #region  /////////----------------------------ddlPaisAdq
                dtPaisAdq = detDua.obtenerPaisOrigen();
                ddlPaisAdq.DataSource = dtPaisAdq.DefaultView;
                ddlPaisAdq.DataTextField = "descripcion";
                ddlPaisAdq.DataValueField = "codigo";
                ddlPaisAdq.DataBind();
                ddlPaisAdq.SelectedIndex = 0;
                #endregion
                #region  ////////--------------------------------  ddlCondEntrega
                DataTable dtCondEntrega;
                dTCondEntrega = detDua.obtenerCatalogocondicionEntrega();
                ddlCondEntrega.DataSource = dTCondEntrega.DefaultView;
                ddlCondEntrega.DataTextField = "descripc";
                ddlCondEntrega.DataValueField = "codigo";
                ddlCondEntrega.DataBind();
                ddlCondEntrega.SelectedIndex = 0;
                #endregion

            
                if (Session["s_DuaInicial"] != null) {
                    ScDUAInicial dInicial = (ScDUAInicial)Session["s_DuaInicial"];
                    lNumDetalleDua.Text = dInicial.ScNumeroDua.ToString();
                    idModalidad.Text = dInicial.ScModalidad.ToString();
                    idAduana.Text = dInicial.ScIdAduana.ToString();
                    tbFechaD.Text = dInicial.ScFechaDua.ToString();
                    RefrescarGrid(dInicial.listaDetalleDua);
                }
                else {
                    Label1.Text = "No cargo ningun producto";
                }
            }
        }
        private void RefrescarGrid(List<detalleDua> listaDetalle) {
            DataTable table = ToDataTable(listaDetalle);
            GridView1.DataSource = table;
            GridView1.DataBind();
            table = null;
        }
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties       
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props) {
                //Setting column names as Property names    
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items) {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++) {
                    //inserting property values to datatable rows      
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            } //put a breakpoint here and check datatable   
            return dataTable;
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            ScDUAInicial duaInicial = (ScDUAInicial)Session["s_duaInicial"];
            //agregar nuevo detalle      
            detalleDua detalleNuevo = new detalleDua();

            detalleNuevo.ScFechaDua = Convert.ToDateTime(tbFechaD.Text);
            detalleNuevo.ScAngoDua = Convert.ToInt32(duaInicial.ScAngoDua.ToString());
            detalleNuevo.ScNumeroDua = Convert.ToInt32(lNumDetalleDua.Text.ToString());
            detalleNuevo.ScModalidad = Convert.ToInt32(duaInicial.ScModalidad.ToString());
            detalleNuevo.ScIdAduana = Convert.ToInt32(duaInicial.ScIdAduana.ToString());
            detalleNuevo.ScNombreConsignatorio = tbNombreConsig.Text;
            detalleNuevo.ScIdPaisOrigen = Convert.ToInt32(ddlPaisOrigen.SelectedValue.ToString());
            detalleNuevo.ScPaisDestino = Convert.ToInt32(DropDownList1.SelectedValue.ToString());// deberia ser un int
            detalleNuevo.ScPaisPuertoEmbarque = Convert.ToInt32(DropDownList2.SelectedValue.ToString());
            detalleNuevo.ScPuertoArribo = Convert.ToInt32(DropDownList3.SelectedValue.ToString());
            detalleNuevo.ScPuertoSalida = Convert.ToInt32(DropDownList4.SelectedValue.ToString());
            //detalleNuevo.ScNumLinea = Convert.ToInt16(duaInicial;
            detalleNuevo.ScCantidadBultos = Convert.ToInt32(tbcantBultos.Text.ToString());
            detalleNuevo.ScCantidadUnidades = Convert.ToInt32(DropDownList7.Text.ToString());
            detalleNuevo.ScDescriProductoResumido = tbDescripcionProducto.Text;
            detalleNuevo.ScDescriProductoDetallado = tbPartidaArancel.Text; //tbPartidaArancel
            detalleNuevo.ScIdPartidaArancel = Convert.ToInt32(DropDownList6.SelectedValue.ToString());
            detalleNuevo.ScValorSeguro = Convert.ToInt32(tbValorseguro.Text.ToString());// en la base esta como money
            detalleNuevo.ScValorFlete = Convert.ToInt32(tbFlete.Text.ToString());
            detalleNuevo.ScValorOtros = Convert.ToInt32(tbValorOtros.Text.ToString());
            detalleNuevo.ScValorFactura = Convert.ToInt32(tbFactura.Text.ToString());
            detalleNuevo.ScValorAduaneroCIF_FOB = tbValorAduanero.Text;
            detalleNuevo.ScValorSeguroPesoBruto = Convert.ToInt32(tbValorseguro.Text.ToString());
            detalleNuevo.ScPesoNeto = Convert.ToInt32(tbPesoNeto.Text.ToString());
            detalleNuevo.ScIdMoneda = Convert.ToInt32(DropDownList5.SelectedValue.ToString());
            detalleNuevo.ScTratadoConvenioInternacional = Convert.ToInt32(DropDownList8.SelectedValue.ToString());
            detalleNuevo.ScImpuestoDAI = Convert.ToInt32(tbimpDAI.Text.ToString());
            detalleNuevo.ScImpuestoSelectivoConsumo = Convert.ToInt32(tbimpDAI.Text.ToString());
            detalleNuevo.ScImpuestoLey6946 = Convert.ToInt32(tbimpDAI.Text.ToString());
            detalleNuevo.ScImpuestoIDA = Convert.ToInt32(tbimpDAI.Text.ToString());
            detalleNuevo.ScImpuestoIFAM = Convert.ToInt32(tbImpIFAM.Text.ToString());
            detalleNuevo.ScImpuestoLey7922 = Convert.ToInt32(tbImp7922.Text.ToString());
            detalleNuevo.ScImpuestoLey8114 = Convert.ToInt32(tbImp8114.Text.ToString());
            detalleNuevo.ScImpuestoForestal = Convert.ToInt32(tbImpForestal.Text.ToString());
            detalleNuevo.ScImpuestoCaldera = Convert.ToInt32(tbImpCaldera.Text.ToString());
            detalleNuevo.ScImpuestoVentas = Convert.ToInt32(tbImpVentas.Text.ToString());
            detalleNuevo.ScImpuestoSalvaguarda = Convert.ToInt32(tbImpSalvaguarda.Text.ToString());
            detalleNuevo.ScImpuestoGofito = Convert.ToInt32(tbImpGolfito.Text.ToString());
            detalleNuevo.ScCodigoExoneracion = Convert.ToInt32(tbCodExoneracion.Text.ToString());
            detalleNuevo.ScExoneracionDAI = tbCodExoneracion.Text;
            detalleNuevo.ScExoneracionSelectivoConsumo = tbExonSelectCons.Text;
            detalleNuevo.ScExoneracionVentas = tbExonVent.Text;
            detalleNuevo.ScIdCondicionEntrega = ddlCondEntrega.SelectedValue.ToString();
            detalleNuevo.ScIdPaisAdquisicion = ddlPaisAdq.SelectedValue.ToString();

            duaInicial.listaDetalleDua.Add(detalleNuevo);
            RefrescarGrid(duaInicial.listaDetalleDua);
            Session["s_DuaInicial"] = duaInicial;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ScDUAInicial duaInicial = (ScDUAInicial)Session["s_DuaInicial"];
            duaInicial.listaDetalleDua.RemoveAt(Convert.ToInt32(lNumDetalleDua.Text) - 1); //falta renumerar   
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            

            ScDUAInicial duaInicial = (ScDUAInicial)Session["s_DuaInicial"];

           // detalleDua detalleNuevo = new detalleDua();
                      
            Boolean insertar = new logicaDetalle().GuardarBoletaLN(duaInicial);
            if (insertar == true) { Mensage(); }
            Session["s_DuaInicial"] = duaInicial;
        }
        private void Mensage()
        {
            string message = "Successfully.";
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("<script type = 'text/javascript'>");          
            sb.Append("window.onload=function(){");         
            sb.Append("alert('");         
            sb.Append(message);         
            sb.Append("')};");          
            sb.Append("</script>");  
        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());   
   }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) {
        ScDUAInicial duaInicial = (ScDUAInicial)Session["s_DuaInicial"];
            lNumDetalleDua.Text = GridView1.SelectedRow.Cells[2].Text;
            lNumDetalleDua.Text = GridView1.SelectedRow.Cells[3].Text;
        Session["s_DuaInicial"] = duaInicial;
    }

        protected void DropDownList8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}