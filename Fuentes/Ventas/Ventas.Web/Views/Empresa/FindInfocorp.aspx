<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Ventas.BE.Empresa>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Consultar Estado en Infocorp
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server"> 
    <h2>
        Consultar Estado en Infocorp</h2>
    <div>
    <%  Html.EnableClientValidation(); %>
        <% using (Html.BeginForm())
           { %>
        <div class="editor-label">
            RUC
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(e => e.RUC, new { style = "width:100px;" })%>
        </div> 
        <p>
            <input type="submit" value="Buscar" />
        </p>
    </div>
    <% } %> 
    <p>
        <%: Html.ActionLink("Regresar", "Index") %>
    </p>
</asp:Content>
