using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jQueryGet
{
    /// <summary>
    /// Descripción breve de Controlador_Generico
    /// </summary>
    public class Controlador_Generico : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            context.Response.Write("Cadena de consulta: " + context.Request.QueryString + "\n");

            if(context.Request.QueryString["Empleado"] == "001")
            {
                context.Response.Write("El empleado " + context.Request.QueryString["nombre"] + " es gerente.");
            }
            context.Response.Write("Operacion realizada con éxito");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}