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
    public class EmpresaController : Controller
    {
        #region
        AdminServiceImpl AdminService = new AdminServiceImpl();
        #endregion

        public ActionResult Index()
        {
            ICollection<Empresa> modelo = AdminService.ListarEmpresa();
            return View(modelo);
        }

        public ActionResult Details(int id)
        {
            Empresa modelo = AdminService.ObtenerEmpresa(id);
            return View(modelo);
        }

        public ActionResult Create()
        {
            cargarEmpresa();
            cargarEstado(null);
            return View();
        }

        [HttpPost]
        public ActionResult Create(Empresa EmpresaACrear)
        {
            try
            {
                AdminService.RegistrarEmpresa(EmpresaACrear.Codigo, EmpresaACrear.RUC, EmpresaACrear.nombrecomercial, EmpresaACrear.direccion, EmpresaACrear.telefono, EmpresaACrear.Estado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            Empresa modelo = AdminService.ObtenerEmpresa(id);
            cargarEstado(modelo.Estado);
            return View(modelo);
        }

        [HttpPost]
        public ActionResult Edit(int id, Empresa EmpresaAModificar)
        {
            try
            {
                AdminService.ModificarEmpresa(id, EmpresaAModificar.RUC, EmpresaAModificar.nombrecomercial, EmpresaAModificar.direccion, EmpresaAModificar.telefono, EmpresaAModificar.Estado);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            Empresa modelo = AdminService.ObtenerEmpresa(id);
            cargarEstado(modelo.Estado);
            return View(modelo);
        }

        [HttpPost]
        public ActionResult Delete(int id, Empresa EmpresaAEliminar)
        {
            try
            {
                AdminService.EliminarEmpresa(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        #region "Metodos Utiles"

        public void cargarEmpresa()
        {
            ViewData["Empresa"] = new SelectList(AdminService.ListarEmpresa(), "Codigo", "NombreComercial");
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
