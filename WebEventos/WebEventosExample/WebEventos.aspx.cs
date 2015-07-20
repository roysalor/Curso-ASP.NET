using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEventosExample
{
    public partial class WebEventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                Label1.Text = DateTime.Now.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Write("Haz pulsado el boton 1 </br>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Write("Haz pulsado el boton 2 </br>");
            Page.Response.Write("La IP del host cliente es: "+ Page.Request.UserHostAddress );
        }
    }
}