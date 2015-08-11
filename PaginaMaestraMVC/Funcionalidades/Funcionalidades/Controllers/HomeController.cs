using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Funcionalidades.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "ASP.NET MVC";

            return View();
        }

        public string Actualizar() 
        {
            return "Hora de actualización: " + DateTime.Now.ToLongTimeString();
        }

        public string ActualizarFormulario(string texBox1, string texBox2) 
        {
            return "Se a introducido el usuario: \"" + texBox1.ToString() + " "
                + texBox2.ToString() + "\" a las " + DateTime.Now.ToLongTimeString(); 
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
