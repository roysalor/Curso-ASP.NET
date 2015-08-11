﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jQueryAjax
{
    /// <summary>
    /// Descripción breve de Controlador_Generico
    /// </summary>
    public class Controlador_Generico : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Cadena de Consultas: " + context.Request.QueryString);
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