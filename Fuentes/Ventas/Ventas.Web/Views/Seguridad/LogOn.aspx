<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Ventas.Web.Models.LogOnModel>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Loggin</title>
    <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
    <script src="../../Scripts/jquery-1.4.1.js" type="text/javascript"></script>
    <script src="../../Scripts/MicrosoftAjax.js" type="text/javascript"></script>
    <script src="../../Scripts/MicrosoftMvcAjax.js" type="text/javascript"></script>
    <script src="../../Scripts/MicrosoftMvcValidation.js" type="text/javascript"></script>
</head>
<body>
    <div class="page">
        <div id="">
            <div id="">
                <h1 style="color: white;">
                    Sistema de Ventas de Pautas Publicitarias</h1>
            </div>
        </div>
        <div id="main">
        <%  Html.EnableClientValidation(); %>
            <% using (Html.BeginForm())
               { %>
            <div>
                <fieldset>
                    <legend>Login</legend>
                    
                    <%: Html.ValidationSummary(true, "Error:") %>
                    <div class="editor-label">
                        <%: Html.LabelFor(m => m.User) %>
                    </div>
                    <div class="editor-field">
                        <%: Html.TextBoxFor(m => m.User, new { style = "width:100px;" }) %>
                        <%: Html.ValidationMessageFor(m => m.User) %>
                    </div>
                    <div class="editor-label">
                        <%: Html.LabelFor(m => m.Password) %>
                    </div>
                    <div class="editor-field">
                        <%: Html.PasswordFor(m => m.Password, new { style = "width:100px;" })%>
                        <%: Html.ValidationMessageFor(m => m.Password) %>
                    </div>
                    <div class="editor-label">
                        <%: Html.CheckBoxFor(m => m.Recordar) %>
                        <%: Html.LabelFor(m => m.Recordar) %>
                    </div>
                    <p>
                        <input type="submit" value="Log On" />
                    </p>
                </fieldset>
            </div>
            <% } %>
        </div>
    </div>
</body>
</html>
