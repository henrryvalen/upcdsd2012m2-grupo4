using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ventas.BE;
using Ventas.DAL;
using Ventas.DAL.EF;

namespace Ventas.BL
{
    public class AdminServiceImpl : IAdminService
    {
        #region Dependencias

        ITipoPautaDAO tipoPautaDAO = new TipoPautaDAO();
        IEmpresaDAO empresaDAO = new EmpresaDAO();

        #endregion

        #region "Tipo de Pauta"

        public ICollection<TipoPauta> ListarTipoPauta()
        {
            return tipoPautaDAO.ListarTodos();
        }

        public TipoPauta RegistrarTipoPauta(int codigoTipoPauta, string nombre, string estado)
        {
            TipoPauta beTipoPauta = new TipoPauta();
            beTipoPauta.Descripcion = nombre;
            beTipoPauta.Estado = estado;
            return tipoPautaDAO.Crear(beTipoPauta);
        }

        public TipoPauta ObtenerTipoPauta(int codigoTipoPauta)
        {
            return tipoPautaDAO.Obtener(codigoTipoPauta);
        }

        public TipoPauta ModificarTipoPauta(int codigoTipoPauta, string nombre, string estado)
        {
            TipoPauta beTipoPauta = tipoPautaDAO.Obtener(codigoTipoPauta);
            beTipoPauta.Descripcion = nombre;
            beTipoPauta.Estado = estado;
            return tipoPautaDAO.Modificar(beTipoPauta);
        }

        public void EliminarTipoPauta(int codigoTipoPauta)
        {
            TipoPauta beTipoPauta = tipoPautaDAO.Obtener(codigoTipoPauta);
            tipoPautaDAO.Eliminar(beTipoPauta);
        }

        public ICollection<TipoPauta> ListarTipoPauta(int codigoTipoPauta)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region "Empresa"

        public ICollection<Empresa> ListarEmpresa()
        {
            return empresaDAO.ListarTodos();
        }

        public Empresa RegistrarEmpresa(int codigoEmpresa, string RUC, string nombrecomercial, string direccion, string telefono, string estado)
        {
            Empresa beEmpresa = new Empresa();
            beEmpresa.RUC = RUC;
            beEmpresa.nombrecomercial = nombrecomercial;
            beEmpresa.direccion = direccion;
            beEmpresa.telefono = telefono;
            beEmpresa.Estado = estado;

            return empresaDAO.Crear(beEmpresa);
        }

        public Empresa ObtenerEmpresa(int codigoEmpresa)
        {
            return empresaDAO.Obtener(codigoEmpresa);
        }

        public Empresa ModificarEmpresa(int codigoEmpresa, string RUC, string nombrecomercial, string direccion, string telefono, string estado)
        {
            Empresa beEmpresa = new Empresa();
            beEmpresa.RUC = RUC;
            beEmpresa.nombrecomercial = nombrecomercial;
            beEmpresa.direccion = direccion;
            beEmpresa.telefono = telefono;
            beEmpresa.Estado = estado;

            return empresaDAO.Modificar(beEmpresa);
        }

        public void EliminarEmpresa(int codigoEmpresa)
        {
            Empresa beEmpresa = empresaDAO.Obtener(codigoEmpresa);
            empresaDAO.Eliminar(beEmpresa);
        }

        public ICollection<Empresa> ListarEmpresa(int codigoEmpresa)
        {
            throw new NotImplementedException();
        }

        #endregion



    }
}


