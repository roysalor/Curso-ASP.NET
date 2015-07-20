using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManejadoresHttpPersonalizado
{
    /// <summary>
    /// Summary description for HandlerControlador
    /// </summary>
    public class HandlerControlador : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Bienvenido");
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