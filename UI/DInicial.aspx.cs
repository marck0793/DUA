using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Entidad;
using System.Data;
using System.Web.Optimization;
namespace UI
{
    public partial class DInicial : System.Web.UI.Page
    {
        ClsConexion con;
        ScDUAInicial duaInicial;

           DataTable dt;
        DataTable dtA;
        DataTable dtIDestino;
         DataTable dtTransporte;
         DataSet cambioDolar;
         DataTable dtRegimen;
         DataSet num;

        protected void Page_Load(object sender, EventArgs e)
        {

            
            con = new ClsConexion();

            if (!IsPostBack)
            {

                tbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                cambioDolar = con.obtenerWebService();
                //  tbFecha.ReadOnly = true;
                tbCambioDolar.Text = cambioDolar.Tables[0].Rows[0][2].ToString();
                num = con.insertarDua();
                TextBox10.Text = num.Tables[0].Rows[0][0].ToString();

                // string cantidad = num.Tables[0].Rows[0][0].ToString();
                //  int numero = 1 + int.Parse(cantidad);
                //TextBox10.Text = con.insertarDua();


                // string nombre="hola";
                dt = con.obtenerCMregimen();
                DataColumn dc = new DataColumn("descripcion", Type.GetType("System.String"));
                //dc.Expression = "codigo+' '+regimen";
                // dt.Columns.Add(dc);
                //  DropDownList1.DataSource = 
                //  DropDownList1.DataTextField = "name";
                // DropDownList1.DataBind();


                DropDownList1.DataSource = dt.DefaultView;
                DropDownList1.DataTextField = "descripcion";
                DropDownList1.DataValueField = "codigo";

                // Bind the data to the control.
                DropDownList1.DataBind();

                // Set the default selected item, if desired.
                DropDownList1.SelectedIndex = 1;

                // el que me llena el drop de aduana
                dtA = con.obtenerAduana();
                ddlIdAduana.DataSource = dtA.DefaultView;
                ddlIdAduana.DataTextField = "descripcion";

                ddlIdAduana.DataValueField = "codigoEntero";
                ddlIdAduana.DataBind();
                ddlIdAduana.SelectedIndex = 0;
                // indica cual en el la ingreso destino
                dtIDestino = con.obtenerAduana();
                ddlIdIngresoDestino.DataSource = dtIDestino.DefaultView;
                ddlIdIngresoDestino.DataTextField = "descripcion";

                ddlIdIngresoDestino.DataValueField = "codigoEntero";
                ddlIdIngresoDestino.DataBind();
                ddlIdIngresoDestino.SelectedIndex = 0;
                ///transporte

                dtTransporte = con.obtenerTransporte();
                ddlIDTransporte.DataSource = dtTransporte.DefaultView;
                ddlIDTransporte.DataTextField = "descripcion";

                ddlIDTransporte.DataValueField = "id";
                ddlIDTransporte.DataBind();
                ddlIDTransporte.SelectedIndex = 0;
                //regimen
                // String regimen = ddLRegimen.Text;


                dtRegimen = con.obtenerRegimen();
                DataColumn regimen = new DataColumn("descripcion", Type.GetType("System.String"));

                ddLRegimen.DataSource = dtRegimen.DefaultView;
                ddLRegimen.DataTextField = "descripcion";
                ddLRegimen.DataValueField = "codigo";


                ddLRegimen.DataBind();
                ddLRegimen.SelectedIndex = 0;
            }
        }

        protected void gaurdarDInicial_Click(object sender, EventArgs e)
        {
            duaInicial = new ScDUAInicial();

            try
            {


              
                DateTime fech = DateTime.Parse(tbFecha.Text);
                int f = fech.Year;
                duaInicial.ScFechaDua = DateTime.Parse(tbFecha.Text);

                duaInicial.ScAngoDua = Convert.ToInt32(f.ToString());
                duaInicial.ScModalidad = Convert.ToInt32(TextBox10.Text.ToString());
                duaInicial.ScNumeroDua = Convert.ToInt32(TextBox10.Text.ToString());
                duaInicial.ScIdRegimen = Convert.ToInt32(ddLRegimen.SelectedValue.ToString());
                duaInicial.ScIdAduana = Convert.ToInt32(ddlIdAduana.SelectedValue.ToString());
                duaInicial.ScIdAduanaIngresoDestino = Convert.ToInt32(ddlIdIngresoDestino.SelectedValue.ToString());
                duaInicial.ScTipoIdentificacion = Convert.ToChar(ddlTipoIdentificacion.SelectedValue.ToString());
                duaInicial.ScNumeroIdentificacion = tbNumIdentif.Text;
                duaInicial.ScTipoIdentificadorDeclarante = ddlTipoDeclarante.SelectedValue.ToString();
                duaInicial.ScNumeroIdentificacionDeclarante = Convert.ToInt32(TextBox2.Text.ToString());
                duaInicial.ScIdTransporte = Convert.ToInt32(ddlIDTransporte.SelectedValue.ToString());
                duaInicial.ScSumatoriaCantidadBultos = TextBox3.Text.ToString();
                duaInicial.ScValidacionValorAduanero = TextBox4.Text.ToString();
                duaInicial.ScTotalPesoBruto = Convert.ToInt32(TextBox5.Text.ToString());
                duaInicial.ScTotalPesoNeto = Convert.ToInt32(TextBox6.Text.ToString());
                duaInicial.ScTipoCambioDolar = Convert.ToDecimal(tbCambioDolar.Text.ToString());
                duaInicial.ScTotalMonedasColones = Convert.ToInt32(TextBox8.Text.ToString());
                duaInicial.ScImpuestoTotal = Convert.ToInt32(TextBox9.Text.ToString());
                duaInicial.ScEstado = "A";
                List<detalleDua> listaDetalle = new List<detalleDua>();
                duaInicial.listaDetalleDua = listaDetalle;
                Session["s_DuaInicial"] = duaInicial;
                Response.Redirect("~/guiDetalleDua.aspx",true);

            }
            catch (Exception ex)
            {
                Label1.Text = "Error..." + ex.Message.ToString();
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddLRegimen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void ddlIdIngresoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Server.Transfer("ModificarDuaInicial.aspx",true);
            Server.Transfer("guiDetalleDua.aspx", true);
        }

        protected void TextBox10_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void ddlIdIngresoDestino_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlIdAduana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}