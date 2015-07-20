<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<galeriaImagenes.Models.imagenes>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>PorCategoria</title>
</head>
<body>
    <table style="width: 100%;" border="2">
        <tr>
            <th>
               id_imagen</th>
            <th>
                nombre</th>
            <th>
                muestra&nbsp;</th>
                <th>tam</th>
                <th>alto</th>
                <th>ancho</th>
                <th>categoria</th>                
                <th>palabrasClaves</th>
        </tr>
        <% foreach(var item in Model) {%>
        <tr>
           <%-- <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.id_imagen }) %> |
                 <%: Html.ActionLink("Details", "Details", new { id=item.id_imagen }) %> |
                  <%: Html.ActionLink("Delete", "Delete", new { id=item.id_imagen }) %>                
            </td>--%>
            <td>
                <%: item.id_imagen %>
            </td>
            <td>
                <%: item.nombre %>
            </td>
            <td>
               <img id="Img1" src="<%: item.ruta %>" style="height:200px;width:200px;" alt="<%: item.descripcion %>" >      
            </td>
            <td>
                <%: item.tam %>
            </td>
            <td>
                <%: item.alto %>
            </td>
            <td>
                <%: item.ancho %>
            </td>
            <td>
                <%: item.categoria %>
            </td>
            <%--<td>
                <%: item.descripcion %>
            </td>--%>
            <td>
                <%: item.palabrasClaves %>
            </td>
        </tr>
        <% } %>
        
    </table>


</body>
</html>
