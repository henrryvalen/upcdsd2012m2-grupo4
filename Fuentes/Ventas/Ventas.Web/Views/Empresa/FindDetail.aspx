<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Ventas.BE.Empresa>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Consultar Estado de Empresa
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Consultar Estado de Empresa</h2>
    <table>
        <tr>
            <th>
            </th>
            <th>
                RUC
            </th>
            <th>
                Razon Social
            </th>
            <th>
                Estado
            </th>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: Html.ActionLink("Detalles", "State", new { RUC=item.RUC })%>
            </td>
            <td>
                <%: item.RUC%>
            </td>
            <td>
                <%: item.nombrecomercial %>
            </td>
            <td>
                <%: item.Estado %>
            </td>
        </tr>
        <% } %>
    </table>
    <p>
        <%: Html.ActionLink("Regresar", "Find")%>
    </p>
</asp:Content>
