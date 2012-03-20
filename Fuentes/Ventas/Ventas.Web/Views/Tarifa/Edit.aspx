<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.Tarifa>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editar Tipo de Pauta</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Campos</legend>
            <div class="editor-field">
                <%: Html.HiddenFor(model => model.Codigo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CodigoRadio) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownListFor(model => model.CodigoRadio, (SelectList)ViewData["Radio"], "-- Seleccione --", new { style = "width:200px;" })%>
                <%: Html.ValidationMessageFor(model => model.CodigoRadio) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CodigoTipoPauta) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownListFor(model => model.CodigoTipoPauta, (SelectList)ViewData["TipoPauta"], "-- Seleccione --", new { style = "width:200px;" })%>
                <%: Html.ValidationMessageFor(model => model.CodigoTipoPauta) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Precio) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Precio, new { style = "width:150px;" }) %>
                <%: Html.ValidationMessageFor(model => model.Precio) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Bloque) %>
            </div>
            <div class="editor-field">
               <%: Html.TextAreaFor(model => model.Bloque, new { style = "width:250px;" }) %>
                <%: Html.ValidationMessageFor(model => model.Bloque) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Estado) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownListFor(model => model.Estado, (SelectList)ViewData["Estado"], "-- Seleccione --", new { style = "width:200px;" })%>
                <%= Html.ValidationMessageFor(model => model.Estado)%>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar", "Index") %>
    </div>

</asp:Content>

