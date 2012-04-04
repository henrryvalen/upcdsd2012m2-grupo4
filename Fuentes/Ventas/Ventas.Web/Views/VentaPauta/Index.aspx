<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Ventas.BE.VentaPauta>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Codigo
            </th>
            <th>
                radioCodigo
            </th>
            <th>
                ventaNombreVendedor
            </th>
            <th>
                ventaDescripcionProducto
            </th>
            <th>
                empresaRUC
            </th>
            <th>
                tipoPautaCodigo
            </th>
            <th>
                ventaNumeroDias
            </th>
            <th>
                ventaPrioridad
            </th>
            <th>
                ventaTipoTransaccion
            </th>
            <th>
                ventaIGV
            </th>
            <th>
                ventaTipoOrden
            </th>
            <th>
                ventaImporteTotal
            </th>
            <th>
                ventaMontoTotal
            </th>
            <th>
                ventaTipoPago
            </th>
            <th>
                ventaFechaCreacion
            </th>
            <th>
                ventaUsuarioCreacion
            </th>
            <th>
                ventaFechaModif
            </th>
            <th>
                ventaUsuarioModif
            </th>
            <th>
                ventaEstado
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%: item.Codigo %>
            </td>
            <td>
                <%: item.radioCodigo %>
            </td>
            <td>
                <%: item.ventaNombreVendedor %>
            </td>
            <td>
                <%: item.ventaDescripcionProducto %>
            </td>
            <td>
                <%: item.empresaRUC %>
            </td>
            <td>
                <%: item.tipoPautaCodigo %>
            </td>
            <td>
                <%: item.ventaNumeroDias %>
            </td>
            <td>
                <%: item.ventaPrioridad %>
            </td>
            <td>
                <%: item.ventaTipoTransaccion %>
            </td>
            <td>
                <%: item.ventaIGV %>
            </td>
            <td>
                <%: item.ventaTipoOrden %>
            </td>
            <td>
                <%: String.Format("{0:F}", item.ventaImporteTotal) %>
            </td>
            <td>
                <%: String.Format("{0:F}", item.ventaMontoTotal) %>
            </td>
            <td>
                <%: item.ventaTipoPago %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.ventaFechaCreacion) %>
            </td>
            <td>
                <%: item.ventaUsuarioCreacion %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.ventaFechaModif) %>
            </td>
            <td>
                <%: item.ventaUsuarioModif %>
            </td>
            <td>
                <%: item.ventaEstado %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

