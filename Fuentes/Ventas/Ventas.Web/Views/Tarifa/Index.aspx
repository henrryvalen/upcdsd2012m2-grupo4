<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Ventas.BE.Tarifa>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Tarifa</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Codigo
            </th>
            <%--<th>
                CodigoRadio
            </th>
            <th>
                CodigoTipoPauta
            </th>--%>
            <th>
                Precio
            </th>
            <th>
                Bloque
            </th>
            <th>
                Estado
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id = item.Codigo }) %> |
                <%: Html.ActionLink("Detalles", "Details", new { id = item.Codigo })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { id = item.Codigo })%>
            </td>
            <td>
                <%: item.Codigo %>
            </td>
            <%--<td>
                <%: item.CodigoRadio %>
            </td>
            <td>
                <%: item.CodigoTipoPauta %>
            </td>--%>
            <td>
                <%: String.Format("{0:F}", item.Precio) %>
            </td>
            <td>
                <%: item.Bloque %>
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

