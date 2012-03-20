<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>
<%  if(Request.IsAuthenticated) { %>
    <text>Welcome <strong><%: (HttpContext.Current.Session["BEUsuario"] as Ventas.BE.Usuario).User %></strong>!
    [ <%: Html.ActionLink("Salir", "LogOff", "Seguridad") %>]</text>
<% } %>

