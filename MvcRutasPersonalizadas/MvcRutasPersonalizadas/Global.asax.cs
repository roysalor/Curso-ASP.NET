using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcRutasPersonalizadas
{
    // Nota: para obtener instrucciones sobre cómo habilitar el modo clásico de IIS6 o IIS7, 
    // visite http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              "Producto",
              "Producto/{id}",
              new { controller = "Producto", action = "Detalles" },
              new { id = @"\d+" }
          );

            routes.MapRoute(
                "ProductoSinId",
                "Producto/{id}",
                new { controller = "Producto", action = "SinDetalles",  id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Default", // Nombre de ruta
                "{controller}/{action}/{id}", // URL con parámetros
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Valores predeterminados de parámetro
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
        }
    }
}