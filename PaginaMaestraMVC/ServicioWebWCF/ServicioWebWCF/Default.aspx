<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ServicioWebWCF._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
        
        <script type="text/javascript">

            function saludarUsuario() {
                Saludo.MiMetodo(exito);
            }

            function exito(resultado) {
                alert(resultado);
            }

        </script>
        
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        ASP.NET
    </h2>
    <p>
        &nbsp;</p>
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="Saludo.svc" />
            </Services>
        </asp:ScriptManager>
    </p>
    <p>
        <input id="Button2" type="button" onclick="saludarUsuario()" value="button" />
        
    </p>
</asp:Content>
