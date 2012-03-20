using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using Ventas.BL;
using Ventas.BE;
using Ventas.Web.Models;

namespace Ventas.Web.Controllers
{
    public class SeguridadController : Controller
    {
        #region
        AdminServiceImpl AdminService = new AdminServiceImpl();
        #endregion

        //
        // GET: /Seguridad/
        
        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel form)
        {
            Usuario BEUsuario = new Usuario();
            BEUsuario = AdminService.ValidarUsuario(form.User, form.Password);
            if (BEUsuario != null)
            {
                SetAuthenticationCookie(BEUsuario);
                Session["BEUsuario"] = BEUsuario;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "El Usuario y/o Password son incorrectos.");
                return View(form);
            }
            
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            Session.Remove("BEUsuario");
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("LogOn");
        }


        private void SetAuthenticationCookie(Usuario usuario)
        {
            var ticket = new FormsAuthenticationTicket(
                    1,
                    usuario.Codigo.ToString(),
                    DateTime.Now,
                    DateTime.Now.AddMinutes(FormsAuthentication.Timeout.TotalMinutes),
                    false,
                    usuario.ToString(),
                    FormsAuthentication.FormsCookiePath
                );
            var encryptedTicket = FormsAuthentication.Encrypt(ticket);
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket)
            {
                HttpOnly = FormsAuthentication.RequireSSL,
                Path = FormsAuthentication.FormsCookiePath,
                Domain = FormsAuthentication.CookieDomain
            };
            Response.AppendCookie(cookie);
            //FormsAuthentication.SetAuthCookie(usuario.User, false);
        }


    }
}
