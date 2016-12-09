using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;

namespace UI
{
    public partial class GuiBoleta : System.Web.UI.Page
    {
        EntBoleta boleta;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBoleta_Click(object sender, EventArgs e)
        {
            boleta = new EntBoleta();
            try
            {

                boleta.id_boleta = Convert.ToInt16(codBoleta.Text.ToString());
                boleta.desc_boleta= codigoBoleta.Text.ToString();
                List<EntDetalle> listaDetalle = new List<EntDetalle>();

                boleta.listDetalle = listaDetalle;
                Session["s_Boleta"] = boleta; // que es esto de session 

                Response.Redirect("~/Default3.aspx");

            }

            catch (Exception ex)

            {

             //   Label1.Text = "Error..." + ex.Message.ToString();
            }
        }
    }
}