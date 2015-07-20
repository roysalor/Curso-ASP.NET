using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHolaMundo.Controllers
{
    public class HolaController : Controller
    {
        //
        // GET: /Hola/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Saludar() 
        {
            ViewData["Mensaje"] = "Hola Mundo desde ASP.NET MVC";
            return View();
            //para hace que funcione se debe hacer con este enlace http://localhost:6235/Hola/Saludar
        }

    }
}
