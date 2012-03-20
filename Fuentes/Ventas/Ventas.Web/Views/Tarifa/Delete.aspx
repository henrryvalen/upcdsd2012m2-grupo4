<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.Tarifa>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Eliminar Tarifa</h2>

    <h3>Estas seguro de eliminar la tarifa?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Codigo</div>
        <div class="display-field"><%: Model.Codigo %></div>
        <br />
        <%--<div class="display-label">CodigoRadio</div>
        <div class="display-field"><%: Model.CodigoRadio %></div>
        
        <div class="display-label">CodigoTipoPauta</div>
        <div class="display-field"><%: Model.CodigoTipoPauta %></div>
        --%>
        <div class="display-label">Precio</div>
        <div class="display-field"><%: String.Format("{0:F}", Model.Precio) %></div>
        <br />
        <div class="display-label">Bloque</div>
        <div class="display-field"><%: Model.Bloque %></div>
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

