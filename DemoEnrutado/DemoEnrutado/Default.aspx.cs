using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoEnrutado
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                string terminobuscado = "No se ha especificado ningun termino a buscar.";
                if (RouteData.Values["terminos"] != null) 
                {
                    terminobuscado = "Los terminos son '" + RouteData.Values["terminos"].ToString() + "'";
                }

                lblMostrar.Text = terminobuscado;
            }
        }
    }
}
