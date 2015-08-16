<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        ASP.NET
    </h2>
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Alumnos.aspx">Alumnos</asp:HyperLink>
    <br />
    <br />
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Profesores.aspx">Profesores</asp:HyperLink>
    <br />
    <br />
    <br />
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
</asp:Content>
