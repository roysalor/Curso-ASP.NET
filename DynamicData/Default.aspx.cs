﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        System.Collections.IList visibleTables = ASP.global_asax.DefaultModel.VisibleTables;
        if (visibleTables.Count == 0) {
            throw new InvalidOperationException("No hay tablas accesibles. Asegúrese de que hay al menos un modelo de datos registrado en Global.asax y de que está habilitada la técnica scaffolding, o bien implemente páginas personalizadas.");
        }
        Menu1.DataSource = visibleTables;
        Menu1.DataBind();
    }

}
