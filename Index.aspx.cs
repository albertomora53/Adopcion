using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Adopcion
{
    public partial class Index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["usuario"] == null)
            {
                Response.Redirect("Login.aspx"); // Si no hay sesión, redirige al login
            }
            else
            {
                LabelBienvenida.Text = "Bienvenido, " + Session["usuario"].ToString();
            }
        }

        protected void LinkCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Clear(); // Limpia todos los datos de sesión
            Session.Abandon(); // Finaliza la sesión
            Response.Redirect("Login.aspx"); // Redirige al login
        }




    }
}
