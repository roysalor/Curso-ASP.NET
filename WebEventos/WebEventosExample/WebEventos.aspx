<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebEventos.aspx.cs" Inherits="WebEventosExample.WebEventos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
