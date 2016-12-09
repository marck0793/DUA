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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text))
                {
                    lblAlerta.Text = "Debe ingresar su usuario y contraseña";
                }
                else
                {
                    lblAlerta.Text = "";
                    ClsEmpleado empleado = new Datos.ClsConexion().ValidarUsuario(txtClave.Text,txtUsuario.Text);
                    if (empleado.NombreEmpleado != "")
                    {
                        lblAlerta.Text = "Bienvenido(a)" + empleado.NombreEmpleado;
                    }
                    else
                    {
                        lblAlerta.Text = "Verificar nombre y clave";
                    }
                }
            }
            catch (Exception ex)
            {
                lblAlerta.Text = ex.Message.ToString();
            }

        }
    }
}