﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManejadoresHttp
{
    /// <summary>
    /// Summary description for Controlador
    /// </summary>
    public class Controlador : IHttpHandler
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