<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Página principal
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        Para obtener más información sobre ASP.NET MVC, visite el <a href="http://asp.net/mvc" title="sitio web de ASP.NET MVC">http://asp.net/mvc</a>.
    </p>

    <%=  Ajax.ActionLink("Realizar Actualizacion", "Actualizar", new AjaxOptions { UpdateTargetId="hora" }) %>

    <span id="hora"></span>

    <br /><br />

    <% using(Ajax.BeginForm("ActualizarFormulario", 
            new AjaxOptions{UpdateTargetId="textoIntroducido"}))
        
        {%>

            Nombre: <%= Html.TextBox("texBox1")%> <br/><br/>
            Apellidos: <%= Html.TextBox("texBox2")%>
            <br /><br />

            <input type="submit" value="Enviar" /> <br /><br />
            <span id="textoIntroducido"></span>
            <% }
         %>
</asp:Content>
