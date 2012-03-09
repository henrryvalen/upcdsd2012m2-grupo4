<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Ventas.BE.TipoPauta>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Tipo de Pauta
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Tipo de Pauta</h2>
    <table>
        <tr>
            <th>
            </th>
            <th>
                Codigo
            </th>
            <th>
                Descripción
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
                <%: item.Descripcion %>
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
