using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ventas.BL;
using Ventas.BE;
using System.ComponentModel.DataAnnotations;
using Ventas.Web.Models;

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
        
        public ActionResult Find()
        {
            return View("Find");
        }

        [HttpPost]
        public ActionResult Find(Empresa form)
        {
            ServicioSunat.Empresas servicio = new ServicioSunat.Empresas();
            ICollection<ServicioSunat.Empresa> modelo = servicio.ConsultarEmpresa(form.RUC, form.nombrecomercial);
            List<Empresa> empresas = new List<Empresa>();
            Empresa empresa;
            foreach (var item in modelo)
            {
                empresa = new Empresa();
                empresa.RUC = item.RUC;
                empresa.nombrecomercial = item.nombrecomercial;
                empresa.Estado = item.Estado;
                empresas.Add(empresa);
            }
            return View("FindDetail", empresas);
        }

        public ActionResult State(string RUC)
        {
            ServicioSunat.Empresas servicio = new ServicioSunat.Empresas();
            ServicioSunat.Empresa modelo = servicio.ObtenerEmpresa(RUC);
            Empresa empresa = new Empresa();
            empresa = new Empresa();
            empresa.Codigo = modelo.Codigo;
            empresa.RUC = modelo.RUC;
            empresa.nombrecomercial = modelo.nombrecomercial;
            empresa.direccion = modelo.direccion;
            empresa.telefono = modelo.telefono;
            empresa.Estado = modelo.Estado;
            return View(empresa);
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
