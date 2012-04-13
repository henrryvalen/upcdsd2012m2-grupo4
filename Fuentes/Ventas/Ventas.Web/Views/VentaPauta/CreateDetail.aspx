<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.VentaPauta>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Registrar Venta
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Registrar Venta</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Campos</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.empresaRUC) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.empresaRUC, new { style = "width:100px;" })%>
                <%: Html.ValidationMessageFor(model => model.empresaRUC)%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.radioCodigo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.radioCodigo, new { style = "width:150px;" })%>
                <%: Html.ValidationMessageFor(model => model.radioCodigo)%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ventaDescripcionProducto) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ventaDescripcionProducto, new { style = "width:400px;" })%>
                <%: Html.ValidationMessageFor(model => model.ventaDescripcionProducto)%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ventaNombreVendedor) %>
            </div>
            <div class="editor-field">
                <%: Html.TextAreaFor(model => model.ventaNombreVendedor, new { style = "width:400px;" })%>
                <%: Html.ValidationMessageFor(model => model.ventaNombreVendedor)%>
            </div>             
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ventaEstado) %>
            </div>
            <div class="editor-field"> 
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

