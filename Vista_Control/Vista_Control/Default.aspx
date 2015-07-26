<%@ Page Title="Página principal" Language="C#" ViewStateMode="Disabled"  MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Vista_Control._Default" %>
  <%--   inabilitar el estado de la vista EnableViewState="false" desabilitar el estado de la vista de la pagina ViewStateMode="Disabled" --%>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        ASP.NET
    </h2>
    
    PRIMER MENSAJE:
    <asp:Label ID="lblMensaje1" runat="server" Text="Label" ViewStateMode="Enabled"></asp:Label>
    &nbsp;&nbsp; (ViewStateMode Enabled)<br />
    <br />
    SEGUNDO MENSAJE:
    <asp:Label ID="lblMensaje2" runat="server" Text="Label"></asp:Label>
    &nbsp;(ViewStateMode inherit lo herede de la pagina)<br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Aceptar" />
    <br />
    </asp:Content>
