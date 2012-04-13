using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ventas.BL;
using Ventas.BE;
using System.ComponentModel.DataAnnotations;
using System.Messaging;

namespace Ventas.Web.Controllers
{
    [AuthorizeVentas]
    public class VentaPautaController : Controller
    {
        #region
        AdminServiceImpl AdminService = new AdminServiceImpl();
        #endregion

        public ActionResult Index()
        {
            ICollection<VentaPauta> modelo = AdminService.ListarVentaPauta();
            return View(modelo);
        }

        public ActionResult Details(int id)
        {
            VentaPauta modelo = AdminService.ObtenerVentaPauta(id);
            return View(modelo);
        }

        public ActionResult CreateIndex()
        {
            return View("CreateIndex");
        }

        [HttpPost]
        public ActionResult CreateIndex(Empresa form)
        {

            string rutaColaEmpresas = @".\private$\Empresas";

            if (!MessageQueue.Exists(rutaColaEmpresas))
                MessageQueue.Create(rutaColaEmpresas);


            MessageQueue colaEmpresas = new MessageQueue(rutaColaEmpresas);
            colaEmpresas.Formatter = new XmlMessageFormatter(new Type[] { typeof(Empresa) });


            Message mensajeEmpresa = colaEmpresas.Receive();
            Empresa empresa = (Empresa)mensajeEmpresa.Body;
            VentaPauta venta = new VentaPauta();
            venta.empresaRUC = empresa.RUC;



            if (empresa.RUC == "123456")
            {
                return View("CreateDetail", venta);
            }
            else
            {
                return View("CreateIndex");
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                //AdminService.CancelarVentaPauta(id, "ADMIN", DateTime.Now);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        #region "Metodos Utiles"


        public void cargarEstado(string seleccion)
        {
            ViewData["Estado"] = new SelectList(new List<SelectListItem> { 
                                    new SelectListItem { Value = "A", Text = "Activo"}, 
                                    new SelectListItem { Value = "I", Text = "Inactivo" } 
                                   }, "Value", "Text", !string.IsNullOrEmpty(seleccion) ? seleccion : null);
        }

        public void cargarRadio(string seleccion)
        {
            ViewData["Radio"] = new SelectList(new List<SelectListItem> { 
                                    new SelectListItem { Value = "1", Text = "MODA"}, 
                                    new SelectListItem { Value = "2", Text = "PLANETA" } ,
                                    new SelectListItem { Value = "3", Text = "RITMO ROMANTICA" } 
                                   }, "Value", "Text", !string.IsNullOrEmpty(seleccion) ? seleccion : null);
        }

        public void cargarEmpresa()
        {
            ViewData["Empresa"] = new SelectList(AdminService.ListarEmpresa(), "empresaRUC", "empresaNombreComercial");
        }

        public void cargarPrioridad(string seleccion)
        {
            ViewData["Prioridad"] = new SelectList(new List<SelectListItem> { 
                                    new SelectListItem { Value = "1", Text = "BAJA"}, 
                                    new SelectListItem { Value = "2", Text = "MEDIA" } ,
                                    new SelectListItem { Value = "3", Text = "ALTA" } 
                                   }, "Value", "Text", !string.IsNullOrEmpty(seleccion) ? seleccion : null);
        }

        public void cargarTipoTransaccion(string seleccion)
        {
            ViewData["TipoTransaccion"] = new SelectList(new List<SelectListItem> { 
                                    new SelectListItem { Value = "1", Text = "CONTADO"}, 
                                    new SelectListItem { Value = "2", Text = "CREDITO" } ,
                                    new SelectListItem { Value = "3", Text = "BENÉFICO" } 
                                   }, "Value", "Text", !string.IsNullOrEmpty(seleccion) ? seleccion : null);
        }

        public void cargarTipoOrden(string seleccion)
        {
            ViewData["TipoOrden"] = new SelectList(new List<SelectListItem> { 
                                    new SelectListItem { Value = "1", Text = "BOLETO"}, 
                                    new SelectListItem { Value = "2", Text = "FACTURA" } 
                                   }, "Value", "Text", !string.IsNullOrEmpty(seleccion) ? seleccion : null);
        }

        public void cargarTipoPago(string seleccion)
        {
            ViewData["TipoPago"] = new SelectList(new List<SelectListItem> { 
                                    new SelectListItem { Value = "1", Text = "SOLES"}, 
                                    new SelectListItem { Value = "2", Text = "DOLARES" } 
                                   }, "Value", "Text", !string.IsNullOrEmpty(seleccion) ? seleccion : null);
        }

        #endregion

    }
}
