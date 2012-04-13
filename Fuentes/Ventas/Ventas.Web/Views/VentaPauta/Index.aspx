<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Ventas.BE.VentaPauta>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Registro de Ventas</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Codigo
            </th> 
            <th>
                Descripción Producto
            </th> 
            <th>
                Prioridad
            </th>
            <th>
                Transaccion
            </th>  
            <th>
                Monto Total
            </th>
            <th>
                Tipo de Pago
            </th> 
            <th>
                Estado
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%: Html.ActionLink("Detalles", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%: Html.ActionLink("Cancelar", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%: item.Codigo %>
            </td> 
            <td>
                <%: item.ventaDescripcionProducto %>
            </td> 
            <td>
                <%: item.ventaPrioridad %>
            </td>
            <td>
                <%: item.ventaTipoTransaccion %>
            </td> 
            <td>
                <%: String.Format("{0:F}", item.ventaMontoTotal) %>
            </td>
            <td>
                <%: item.ventaTipoPago %>
            </td> 
            <td>
                <%: item.ventaEstado %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Registrar Venta", "CreateIndex")%>
    </p>

</asp:Content>

