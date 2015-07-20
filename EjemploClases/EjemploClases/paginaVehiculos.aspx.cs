using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using aplicacionVehiculosWeb;

namespace EjemploClases
{
    public partial class paginaVehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mostrar(object sender, EventArgs e) 
        {
            Vehiculo coche1 = new Vehiculo(5, "Reanult");

            Response.Write(coche1.getMarca() + "</br>");
            Response.Write("el numero de puertas es: " + coche1.getNumeroPuertas() + "</br>");

            
        }
    }
}