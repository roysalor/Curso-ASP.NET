<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Página principal
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        Para obtener más información sobre ASP.NET MVC, visite el <a href="http://asp.net/mvc" title="sitio web de ASP.NET MVC">http://asp.net/mvc</a>.
    </p>
    <script src="../../Scripts/jquery-1.4.1.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(document).ready(function () {

            $("#log").ajaxSend(function () {
                $(this).slideDown("fast").text("Cargando . . .");
            });


            $("#log").ajaxComplete(function () {
                $(this).slideUp("slow", function () {
                    $(this).text("");
                });
            });


            $("#enviar").click(function () {
                var msg = $("#texto").val();
                $("#resultado").load('<%= Url.Action("Mostrar") %>', msg)                
                //alert(msg);
            });


            $("#log").ajaxError(function () {
                alert("Se ha producido un error");
            });
        });

    </script>

    <input id="texto" type="text" />
    <input id="enviar" type="button" value="Cargar dato" />
    <div id="log"></div>
    <p id="resultado"></p>

</asp:Content>
