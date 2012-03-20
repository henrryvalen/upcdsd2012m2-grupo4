<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.Empresa>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Eliminar Empresa
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Eliminar Empresa</h2>

    <h3>Está seguro que desea eliminar el registro?</h3>
    <fieldset>
        <legend>Fields</legend>
        
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
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Regresar", "Index") %>
        </p>
    <% } %>

</asp:Content>

