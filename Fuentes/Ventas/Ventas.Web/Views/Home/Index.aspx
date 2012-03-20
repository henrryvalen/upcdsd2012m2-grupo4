<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   Bienvenido :: Sistema de Ventas de Pautas Publicitarias
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        Bienvenidos, Usted podra registrar las ventas de pautas publicitarias. También, podrá consultar el estado de las empresas.
    </p>
</asp:Content>
