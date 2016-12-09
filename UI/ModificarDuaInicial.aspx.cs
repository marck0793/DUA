using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Entidad;
using System.Data;
using Microsoft.Reporting.WinForms;
using reportes;


namespace UI
{
    public partial class ModificarDuaInicial : System.Web.UI.Page
    {
        ClsConexion con;
        DataSet tablaDuaInicial;
        
       DataTable table;
        System.Data.DataRow row;
        DInicial duaInsertar;
     //   GridView gvListaDuaInicial;
        protected void Page_Load(object sender, EventArgs e)
        {
            con =new ClsConexion();
            table = con.mostrarListaInicialDua();
           // table.Columns.Add("ScNumeroDua", typeof(System.String));
          /* table.Columns.Add("ScModalidad", typeof(System.String));
            table.Columns.Add("ScIdRegimen", typeof(System.String));
            table.Columns.Add("ScIdAduana", typeof(System.String));
            table.Columns.Add("ScIdAduanaIngresoDestino", typeof(System.String));
            table.Columns.Add("ScTipoIdentificacion", typeof(System.String));
            table.Columns.Add("ScNumeroIdentificacion", typeof(System.String));
            table.Columns.Add("ScTipoIdentificadorDeclarante", typeof(System.String));
            table.Columns.Add("ScNumeroIdentificacionDeclarante", typeof(System.String));
            table.Columns.Add("ScSumatoriaCantidadBultos", typeof(System.String));
            table.Columns.Add("ScValidacionValorAduanero", typeof(System.String));
            table.Columns.Add("ScTotalPesoBruto", typeof(System.String));
        */
             //tablaDuaInicial.Rows.add()
           gvListaDuaInicial.DataSource=table;
            gvListaDuaInicial.DataBind();



        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e){
         //duaInsertar = new DInicial();
         Server.Transfer("DInicial.aspx", true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //llama al reporte
            //Application.Run(new Form1());
          reportes.Form1 form = new  reportes.Form1();
           // f.Show();
            //Server.Transfer("reportes.Form1.cs", true);
        }
    }
}