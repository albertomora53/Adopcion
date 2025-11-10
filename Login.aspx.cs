using Adopcion_Data; 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Adopcion
{
    public partial class Log : System.Web.UI.Page
    {
       

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Btn_INICIO_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_user.Text) && !string.IsNullOrWhiteSpace(Txt_password.Text))
            {
                DATABASE data = new DATABASE();
                string resultado = data.Iniciar(Txt_user.Text, Txt_password.Text);

                if (resultado == "OK")
                {
                    Session["usuario"] = Txt_user.Text;
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    Label2.Text = resultado; // "Usuario o contraseña incorrectos."
                }
            }
            else
            {
                Label2.Text = "Por favor, ingresa usuario y contraseña.";
            }
        }






        protected void link_registro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}