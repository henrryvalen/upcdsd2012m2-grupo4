<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.TipoPauta>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Eliminar Tipo de Pauta
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Eliminar Tipo de Pauta</h2>

    <h3>Está seguro que desea eliminar el registro?</h3>
    <fieldset>
        <legend>Campos</legend>
        
        <div class="display-label">Codigo</div>
        <div class="display-field"><%: Model.Codigo %></div>
        
        <div class="display-label">Nombre</div>
        <div class="display-field"><%: Model.Descripcion %></div>
        
        <div class="display-label">Estado</div>
        <div class="display-field"><%: Model.Estado %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar" /> |
		    <%: Html.ActionLink("Regresar", "Index") %>
        </p>
    <% } %>

</asp:Content>

