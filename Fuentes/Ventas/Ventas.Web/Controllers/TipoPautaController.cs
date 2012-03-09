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
    public class TipoPautaController : Controller
    {
        #region
        AdminServiceImpl AdminService = new AdminServiceImpl();
        #endregion

        public ActionResult Index()
        {
            ICollection<TipoPauta> modelo = AdminService.ListarTipoPauta();
            return View(modelo);
        }

        public ActionResult Details(int id)
        {
            TipoPauta modelo = AdminService.ObtenerTipoPauta(id);
            return View(modelo);
        }

        public ActionResult Create()
        {
            cargarTipoPauta(); 
            cargarEstado(null);
            return View();
        }

        [HttpPost]
        public ActionResult Create(TipoPauta TipoPautaACrear)
        {
            try
            {
                AdminService.RegistrarTipoPauta(TipoPautaACrear.Codigo, TipoPautaACrear.Descripcion, TipoPautaACrear.Estado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            TipoPauta modelo = AdminService.ObtenerTipoPauta(id);
            cargarEstado(modelo.Estado);
            return View(modelo);
        }

        [HttpPost]
        public ActionResult Edit(int id, TipoPauta TipoPautaAModificar)
        {
            try
            {
                AdminService.ModificarTipoPauta(id, TipoPautaAModificar.Descripcion, TipoPautaAModificar.Estado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            TipoPauta modelo = AdminService.ObtenerTipoPauta(id);
            cargarEstado(modelo.Estado);
            return View(modelo);
        }

        [HttpPost]
        public ActionResult Delete(int id, TipoPauta TipoPautaAEliminar)
        {
            try
            {
                AdminService.EliminarTipoPauta(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        #region "Metodos Utiles"

        public void cargarTipoPauta()
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
