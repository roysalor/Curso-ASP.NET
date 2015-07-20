using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSaludaPersonas
{
    public partial class saludarA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre = (string)RouteData.Values["nombre"];
            TextBox1.Text = "Hola " + nombre;

            string listar = (string)RouteData.Values["listar"];

            if ("meses".Equals(listar)) 
            {
                Label1.Text = "Enero";
                Label2.Text = "Febrero";
                Label3.Text = "Marzo";
                Label4.Text = "Abril";
                Label5.Text = "Mayo";
                Label6.Text = "Junio";
            }else if("dias".Equals(listar))
            {
                Label1.Text = "Lunes";
                Label2.Text = "Martes";
                Label3.Text = "Miercoles";
                Label4.Text = "Jueves";
                Label5.Text = "Viernes";
                Label6.Text = "Sabado";
            }

        }
    }
}