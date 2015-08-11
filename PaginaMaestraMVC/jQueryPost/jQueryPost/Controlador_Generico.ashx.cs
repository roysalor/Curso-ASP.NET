using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jQueryPost
{
    /// <summary>
    /// Descripción breve de Controlador_Generico
    /// </summary>
    public class Controlador_Generico : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Cadena de consulta: " + context.Request.Form);

            int op1 = int.Parse(context.Request.Form["operador1"]);
            int op2 = int.Parse(context.Request.Form["operador2"]);

            switch (context.Request.Form["operacion"]) 
            {
                case "Suma":
                    context.Response.Write(op1 + op2);
                    break;
                case "Resta":
                    context.Response.Write(op1 - op2);
                    break;
                case "Multiplicacion":
                    context.Response.Write(op1 * op2);
                    break;
                case "Division":
                    if (op2 > 0)
                    {
                        context.Response.Write(op1 / op2);
                    }
                    else 
                    {
                        context.Response.Write("Error: El divisor debe ser mayor a cero.");
                    }
                    break;

            }
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