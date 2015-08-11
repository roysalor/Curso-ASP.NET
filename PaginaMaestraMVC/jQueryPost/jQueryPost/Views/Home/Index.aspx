<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Página principal
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        Para obtener más información sobre ASP.NET MVC, visite el <a href="http://asp.net/mvc" title="sitio web de ASP.NET MVC">http://asp.net/mvc</a>.
    </p>

    <script type="text/javascript">
        $(document).ready(function () {

            /*$.post('Controlador_Generico.ashx');

            $.post('Controlador_Generico.ashx',
                function (dato) {
                    alert(dato);
                });

            $.post('Controlador_Generico.ashx', { Empleado: "001", nombre: "juanito" },
                function (dato) {
                    alert(dato);
                });
            });*/

            $('#Enviar').click(function(){
                
                $.post('Controlador_Generico.ashx',{
                    operador1: $('#operador1').val(),
                    operador2: $('#operador2').val(),
                    operacion: $('#operacion').val(),
            }, 
                    function(datos){
                        $('#resultado').html(datos);
                    });
            });
       });        
    
    </script>
    
    Operador 1: <input type="text" id="operador1" value="0" />
    <br />
    <br />
    
    Operación:&nbsp;&nbsp;
    <select id="operacion" name="01" style="width: 113px; height: 22px">
        <option value="Suma">Suma</option>
        <option value="Resta">Resta</option>
        <option value="Multiplicacion">Multiplicacion</option>
        <option value="Division">Division</option>
    </select> <br /> <br />
        Operador 2: <input type="text" id="operador2" value="0" />
    <br />
    <br />
        <input type="button" id="Enviar" value="Resultado" />&nbsp;&nbsp;&nbsp;<span id="resultado" style="color:Red;font-size:12pt;"></span>
     

</asp:Content>
