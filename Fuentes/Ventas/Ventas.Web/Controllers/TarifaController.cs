using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ventas.BL;
using Ventas.BE;
using System.ComponentModel.DataAnnotations;

namespace Ventas.Web.Controllers
{
    [AuthorizeVentas]
    public class TarifaController : Controller
    {

        #region
        AdminServiceImpl AdminService = new AdminServiceImpl();
        #endregion

        public ActionResult Index()
        {
            ICollection<Tarifa> modelo = AdminService.ListarTarifa();
            return View(modelo);
        }

        public ActionResult Details(int id)
        {
            Tarifa modelo = AdminService.ObtenerTarifa(id);
            return View(modelo);
        }

        public ActionResult Create()
        {
            cargarRadio(null);
            cargarTipoTarifa(null);
            cargarEstado(null);
            return View();
        }

        [HttpPost]
        public ActionResult Create(Tarifa TarifaACrear)
        {
            try
            {
                AdminService.RegistrarTarifa(TarifaACrear.Codigo, TarifaACrear.CodigoRadio, TarifaACrear.CodigoTipoPauta, TarifaACrear.Precio, TarifaACrear.Bloque, TarifaACrear.Estado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            Tarifa modelo = AdminService.ObtenerTarifa(id);
            cargarEstado(modelo.Estado);
            cargarRadio(null);
            cargarTipoTarifa(null);
            return View(modelo);
        }

        [HttpPost]
        public ActionResult Edit(int id, Tarifa TarifaAModificar)
        {
            try
            {
                AdminService.ModificarTarifa(id, TarifaAModificar.CodigoRadio, TarifaAModificar.CodigoTipoPauta, TarifaAModificar.Precio, TarifaAModificar.Bloque, TarifaAModificar.Estado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            Tarifa modelo = AdminService.ObtenerTarifa(id);
            cargarEstado(modelo.Estado);
            return View(modelo);
        }

        [HttpPost]
        public ActionResult Delete(int id, Tarifa TarifaAEliminar)
        {
            try
            {
                AdminService.EliminarTarifa(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        #region "Metodos Utiles"

        public void cargarRadio(string seleccion)
        {
            ViewData["Radio"] = new SelectList(AdminService.ListarRadio(), "Codigo", "NombreComercial");
        }

        public void cargarTipoTarifa(string seleccion)
        {
            ViewData["TipoPauta"] = new SelectList(AdminService.ListarTipoPauta(), "Codigo", "Descripcion");
        }

        public void cargarEstado(string seleccion)
        {
            ViewData["Estado"] = new SelectList(new List<SelectListItem> { 
                                    new SelectListItem { Value = "A", Text = "Activo"}, 
                                    new SelectListItem { Value = "I", Text = "Inactivo" } 
                                   }, "Value", "Text", !string.IsNullOrEmpty(seleccion) ? seleccion : null);
        }

        #endregion

    }
}
