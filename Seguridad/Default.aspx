﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LoginView ID="LoginView1" runat="server">
            <RoleGroups>
                <asp:RoleGroup Roles="Administradores">
                    <ContentTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/crearusu.aspx">Crear Usuarios</asp:LinkButton>
                    </ContentTemplate>
                </asp:RoleGroup>
                <asp:RoleGroup Roles="Usuarios">
                    <ContentTemplate>
                        &nbsp;Bienvenido Usuario<br />
                    </ContentTemplate>
                </asp:RoleGroup>
            </RoleGroups>
        </asp:LoginView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
    
    </div>
    </form>
</body>
</html>
