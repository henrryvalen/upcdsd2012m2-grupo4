using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ventas.Web
{
    public class AuthorizeVentas : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            if (filterContext.Result == null)
            {
                if (filterContext.HttpContext.Session["BEUsuario"] == null)
                {
                    RouteValueDictionary rd = new RouteValueDictionary();
                    rd.Add("controller", "Seguridad");
                    rd.Add("action", "LogOn");
                    filterContext.Result = new RedirectToRouteResult("Default", rd);
                }
            }
        }
    }
}