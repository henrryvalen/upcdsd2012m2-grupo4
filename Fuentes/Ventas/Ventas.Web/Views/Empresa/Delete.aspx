<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.Empresa>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Eliminar Empresa</h2>

    <h3>Estas seguro de eliminar Empresa?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Codigo</div>
        <div class="display-field"><%: Model.Codigo %></div>
        <br />
        
        <div class="display-label">RUC</div>
        <div class="display-field"><%: Model.RUC %></div>
        <br />
        
        <div class="display-label">nombrecomercial</div>
        <div class="display-field"><%: Model.nombrecomercial %></div>
        <br />
        
        <div class="display-label">direccion</div>
        <div class="display-field"><%: Model.direccion %></div>
        <br />
        
        <div class="display-label">telefono</div>
        <div class="display-field"><%: Model.telefono %></div>
        <br />
        
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

