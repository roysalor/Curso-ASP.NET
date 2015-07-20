using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlesWeb
{
    public partial class WebFormControles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cambia(object sender, EventArgs e)
        {
            etiqueta.Text = " El lenguaje que has seleccionado es: " + lista.SelectedItem.Text;
        }
    }
}