using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRutasPersonalizadas.Controllers
{
    public class ProductoController : Controller
    {
        //
        // GET: /Producto/

        public ActionResult Detalles(int id)
        {
            ViewData["Mensaje"] = "El indice introducido es: " + (string)RouteData.Values["id"];
            return View();
        }


        public ActionResult SinDetalles()
        {
            ViewData["Mensaje"] = "No se ha especificado el indice";
            return View();
        }

    }
}
