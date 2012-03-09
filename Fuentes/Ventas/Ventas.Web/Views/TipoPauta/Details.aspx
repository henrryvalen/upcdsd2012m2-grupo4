<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.TipoPauta>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Detalles del Tipo de Pauta
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Detalles del Tipo de Pauta</h2>
    <fieldset>
        <legend>Campos</legend>
        <div class="display-label">
            Codigo</div>
        <div class="display-field">
            <%: Model.Codigo %></div>
        <div class="display-label">
            Nombre</div>
        <div class="display-field">
            <%: Model.Descripcion %></div>
        <div class="display-label">
            Estado</div>
        <div class="display-field">
            <%: Model.Estado %></div>
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Edit", new { /* id=Model.PrimaryKey */ }) %>
        |
        <%: Html.ActionLink("Regresar", "Index") %>
    </p>
</asp:Content>
