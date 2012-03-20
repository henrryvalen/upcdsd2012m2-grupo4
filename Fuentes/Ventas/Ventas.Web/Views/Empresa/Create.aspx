<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.Empresa>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Crear una Empresa
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Crear una Empresa</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Campos</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Codigo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Codigo, new { style = "width:100px;" }) %>
                <%: Html.ValidationMessageFor(model => model.Codigo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.RUC) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.RUC, new { style = "width:150px;" }) %>
                <%: Html.ValidationMessageFor(model => model.RUC) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.nombrecomercial) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.nombrecomercial, new { style = "width:400px;" }) %>
                <%: Html.ValidationMessageFor(model => model.nombrecomercial) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.direccion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextAreaFor(model => model.direccion, new { style = "width:400px;" }) %>
                <%: Html.ValidationMessageFor(model => model.direccion) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.telefono) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.telefono, new { style = "width:100px;" }) %>
                <%: Html.ValidationMessageFor(model => model.telefono) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Estado) %>
            </div>
            <div class="editor-field">
            <%: Html.DropDownListFor(model => model.Estado, (SelectList)ViewData["Estado"], "-- Seleccione --", new { style = "width:200px;" })%>
            <%= Html.ValidationMessageFor(model => model.Estado)%>
            </div>
            
            <p>
                <input type="submit" value="Crear" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar", "Index") %>
    </div>

</asp:Content>

