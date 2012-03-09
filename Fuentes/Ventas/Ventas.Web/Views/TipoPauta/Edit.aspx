<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.TipoPauta>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Editar Tipo de Pauta
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editar Tipo de Pauta</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Campos</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Codigo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Codigo) %>
                <%: Html.ValidationMessageFor(model => model.Codigo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Descripcion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Descripcion)%>
                <%: Html.ValidationMessageFor(model => model.Descripcion)%>
            </div>
            
            <div class="editor-label">
            <%: Html.LabelFor(model => model.Estado) %>
            </div>
            <div class="editor-field">
            <%: Html.DropDownListFor(model => model.Estado, (SelectList)ViewData["Estado"], "-- Seleccione --", new { style = "width:200px;" })%>
            <%= Html.ValidationMessageFor(model => model.Estado)%>
            </div>
            
            <p>
                <input type="submit" value="Grabar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar", "Index") %>
    </div>

</asp:Content>

