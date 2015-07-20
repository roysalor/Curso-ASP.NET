using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace galeriaImagenes.Models
{
    public class administradorGaleria
    {
        //conecto a base de datos
        TestClassEntities datos = new TestClassEntities();

        public List<imagenes> imagenesCategoria(string categoria) 
        {
            //consulta linq
            var rutas = from c in datos.imagenes
                        where c.categoria == categoria
                        select c;
            //retorno los datos en una lista
            return rutas.ToList();

        }
    }
}