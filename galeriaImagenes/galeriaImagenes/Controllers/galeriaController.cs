using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//agregamos importacion del modelo para que sea utilizado
using galeriaImagenes.Models;

namespace galeriaImagenes.Controllers
{
    public class galeriaController : Controller
    {
        //
        // GET: /galeria/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /galeria/PorCategoria/ilustracion

        public ActionResult PorCategoria(string id)
        {
            //utilizamos el metodo creado en el modelo para que el controlador luego se lo envie a la vista
            var imagenes = new administradorGaleria().imagenesCategoria(id);
            return View(imagenes);
        }


    }
}
