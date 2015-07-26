using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validacion
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //ejecucion de la validacion por el servidor

        protected void ValidacionPersonalizada_ServerValidate(object source, ServerValidateEventArgs args)
        {
                      
            int numero = int.Parse(args.Value);
            if (numero % 2 == 0)
            {
                args.IsValid = true;
               

            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}
