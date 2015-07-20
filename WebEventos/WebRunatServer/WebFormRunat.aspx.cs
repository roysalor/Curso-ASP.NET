using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebRunatServer
{
    public partial class WebFormRunat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cambia(object sender, EventArgs e) 
        {
            form1.InnerText = Select1.Value;
        }
    }
}