using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManejadorEvento.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "ASP.NET MVC";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public string Mostrar(string mensaje) 
        {
            if (mensaje == "Error")
                throw new ArgumentException();
            return "Escribio: " + mensaje + ", a las " + DateTime.Now;
        }
    }
}
