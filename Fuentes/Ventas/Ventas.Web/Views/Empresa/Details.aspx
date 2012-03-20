<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.Empresa>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Detalle de la Empresa
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalle de la Empresa</h2>

    <fieldset>
        <legend>Campos</legend>
        
        <div class="display-label">Codigo</div>
        <div class="display-field"><%: Model.Codigo %></div>
        
        <div class="display-label">RUC</div>
        <div class="display-field"><%: Model.RUC %></div>
        
        <div class="display-label">Nombre Comercial</div>
        <div class="display-field"><%: Model.nombrecomercial %></div>
        
        <div class="display-label">Direccion</div>
        <div class="display-field"><%: Model.direccion %></div>
        
        <div class="display-label">Telefono</div>
        <div class="display-field"><%: Model.telefono %></div>
        
        <div class="display-label">Estado</div>
        <div class="display-field"><%: Model.Estado %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Edit", new { id=Model.Codigo }) %> |
        <%: Html.ActionLink("Regresar", "Index") %>
    </p>

</asp:Content>

