<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.VentaPauta>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Registrar Venta
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server"> 
    <h2>
        Registrar Venta</h2>
    <div>
    <%  Html.EnableClientValidation(); %>
        <% using (Html.BeginForm())
           { %>
        <div class="editor-label">
            Empresa RUC
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(e => e.empresaRUC, new { style = "width:100px;" })%>
        </div> 
        <p>
            <input type="submit" value="Validar Empresa" />
        </p>
    </div>
    <% } %> 
    <p>
        <%: Html.ActionLink("Regresar", "Index") %>
    </p>
</asp:Content>
