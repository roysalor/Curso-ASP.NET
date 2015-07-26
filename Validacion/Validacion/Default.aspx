<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Validacion._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

<script type="text/javascript">
    // ejecucion de la validacion por parte del cliente
    //para que se active la validacion en el cliente debemosn habilitar en true EnabledClientScript
  
    function FuncionCliente(origen, argumento) {
        var numero = argumento.Value;
        if (numero % 2 == 0) {
            argumento.IsValid = true;
            alert("Validacion realizada en el Cliente: el numero " + numero + " es par.");

        } else {
            argumento.IsValid = false;
         }
     }
</script>

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtNombre" runat="server" ValidationGroup="Grupo1"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtNombre" ErrorMessage="Debe introducior nombre" 
        ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Primer Apellido:"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtApellido" runat="server" ValidationGroup="Grupo1"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtApellido" ErrorMessage="Debe introducir un apellido" 
        ValidationGroup="Grupo1"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Telefono:"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtTelefono" runat="server" ValidationGroup="Grupo1"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="txtTelefono" ErrorMessage="Numero no valido" 
        ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" 
        ValidationGroup="Grupo1"></asp:RegularExpressionValidator>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Edad:"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtEdad" runat="server" ValidationGroup="Grupo1"></asp:TextBox>
    <asp:RangeValidator ID="RangeValidator1" runat="server" 
        ControlToValidate="txtEdad" ErrorMessage="Edad debe ser entre 18 y 50 años" 
        MaximumValue="50" MinimumValue="8" Type="Integer" ValidationGroup="Grupo1"></asp:RangeValidator>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="E-mail:"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtEmail" runat="server" ValidationGroup="Grupo1"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ControlToValidate="txtEmail" ErrorMessage="Email no valido" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
        ValidationGroup="Grupo1"></asp:RegularExpressionValidator>
    <br />
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ValidationGroup="Grupo1" />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Aceptar" 
        ValidationGroup="Grupo1" />
    <br />

    <br />

    <asp:Label ID="Label6" runat="server" Text="Introduce numeros pares:"></asp:Label>&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtIntroduce"
        runat="server"></asp:TextBox>
    &nbsp;
    <asp:CustomValidator ID="ValidacionPersonalizada" runat="server" 
        ClientValidationFunction="FuncionCliente" ControlToValidate="txtIntroduce" 
        ErrorMessage="El numero no es par" EnableClientScript="False" 
        onservervalidate="ValidacionPersonalizada_ServerValidate"></asp:CustomValidator>
    <br />
    <asp:Button ID="Button2" runat="server" Text="Aceptar" />


</asp:Content>

