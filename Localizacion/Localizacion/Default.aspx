<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Localizacion._Default" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   <p>
    <asp:Label ID="Label1" runat="server" Text='<%$ Resources: Label1Resource1.Text %>'></asp:Label>
   </p>
   <br />

      <p>
    <asp:Label ID="Label3" runat="server" Text='<%$ Resources: RecursoGlobal, Label1 %>'></asp:Label>
   </p>
   <br />

        <asp:Label ID="Label2" runat="server" meta:resourcekey="Label1Resource1" 
        Text="Label"></asp:Label>
</asp:Content>
