<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormRunat.aspx.cs" Inherits="WebRunatServer.WebFormRunat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <select id="Select1" runat="server">
            <option selected>Azul</option>
            <option>Rojo</option>
            <option>Verde</option>
            <option>Blanco</option>
        </select>
        <input id="Button1" type="button" value="Seleccione un color" runat="server" onserverclick="cambia" /></div>
    </form>
</body>
</html>
