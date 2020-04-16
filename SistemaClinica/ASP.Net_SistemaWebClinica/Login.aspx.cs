using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net_SistemaWebClinica
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtPassword.Text;
            string userName = "edsolano";
            string passName = "1234";
            if(user.Equals (userName) && password.Equals(passName))
            {
                Response.Write("<script>alert('USUARIO CORRECTO')</script>");
            }
            else
            {
                Response.Write("<script>alert('USUARIO INCORRECTO')</script>");
            }
        }
    }
}