using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista_Control
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                lblMensaje1.Text = "Primer Mesaje a guardar";
                lblMensaje2.Text = "Segundo Mesaje a guardar";
            }

        }
    }
}
