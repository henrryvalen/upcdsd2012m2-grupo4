<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Ventas.BE.Empresa>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Empresas</h2>
     <p>
        <%: Html.ActionLink("Consultar Estado", "Find") %>
        <%: Html.ActionLink("Consultar INFOCORP", "FindInfocorp") %>
    </p>
    <table>
        <tr>
            <th>
            </th>
            <th>
                Codigo
            </th>
            <th>
                RUC
            </th>
            <th>
                Nombre Comercial
            </th>
            <th>
                Dirección
            </th>
            <th>
                Teléfono
            </th>
            <th>
                Estado
            </th>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: Html.ActionLink("Detalles", "Details", new {  id=item.Codigo})%>
                |
                <%: Html.ActionLink("Editar", "Edit", new {  id=item.Codigo }) %>
                |
                <%: Html.ActionLink("Eliminar", "Delete", new {  id=item.Codigo })%>
            </td>
            <td>
                <%: item.Codigo %>
            </td>
            <td>
                <%: item.RUC %>
            </td>
                      <td>
                <%: item.nombrecomercial %>
            </td>
                      <td>
                <%: item.direccion %>
            </td>
                      <td>
                <%: item.telefono %>
            </td>
            <td>
                <%: item.Estado %>
            </td>
        </tr>
        <% } %>
    </table> 
    <p>
        <%: Html.ActionLink("Agregar", "Create") %>
        
    </p>
	

</asp:Content>
