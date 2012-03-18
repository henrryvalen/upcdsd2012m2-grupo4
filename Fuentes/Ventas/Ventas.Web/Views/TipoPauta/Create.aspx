<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.TipoPauta>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Agregar Tipo de Pauta
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Agregar Tipo de Pauta</h2>
    <% using (Html.BeginForm())
       {%>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Campos</legend>
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
            <input type="submit" value="Agregar" />
        </p>
    </fieldset>
    <% } %>
    <div>
        <%: Html.ActionLink("Regresar", "Index") %>
    </div>
</asp:Content>
