using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Entidad;

namespace UI
{
    public partial class DuaInicial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String valorModalidad = DropDownList2.SelectedValue;
            string regimen = idModalidad.SelectedValue;
            string transporte = DropDownList3.SelectedValue;
            string modalidad = DropDownList2.SelectedValue;
            String aduana = DropDownList1.SelectedValue;

            Int16 idRegimen = Int16.Parse(regimen);
            Int16 idtransp = Int16.Parse(transporte);
            Int16 idM = Int16.Parse(modalidad);
            Int16 idAduan = Int16.Parse(aduana);
            string tipoIdentif = tbCodigoModalidad.Text;
            string idNumIdent = TextBox1.Text;
            String sumaCantidadBultos = sumatCantidadBultos.Text;
            Int16 numerDua = 1;
           // ScDUAInicial dua = new Datos.ClsConexion().insertarDua(numerDua, idM, idRegimen, idtransp, idAduan, tipoIdentif, sumaCantidadBultos);

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void idModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void sumatCantidadBultos_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tbCodigoModalidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}