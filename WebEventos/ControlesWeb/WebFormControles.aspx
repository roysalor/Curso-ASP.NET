<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormControles.aspx.cs" Inherits="ControlesWeb.WebFormControles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="lista" runat="server">
            <asp:ListItem>Visual basic</asp:ListItem>
            <asp:ListItem>PHP</asp:ListItem>
            <asp:Listitem>JAVA</asp:Listitem>
        </asp:ListBox>

        <asp:Button ID="Button" Text="Elige el lenguaje" runat="server" OnClick="cambia"/>

        <asp:Label ID="etiqueta" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
