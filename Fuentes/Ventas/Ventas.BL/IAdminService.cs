
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ventas.BE;

namespace Ventas.BL
{
    public interface IAdminService
    {
        #region TipoPauta

        ICollection<TipoPauta> ListarTipoPauta();
        TipoPauta ObtenerTipoPauta(int codigoTipoPauta);
        TipoPauta RegistrarTipoPauta(int codigoTipoPauta, string Nombre, string Estado);
        TipoPauta ModificarTipoPauta(int codigoTipoPauta, string Nombre, string Estado);
        void EliminarTipoPauta(int codigoTipoPauta);
        ICollection<TipoPauta> ListarTipoPauta(int codigoTipoPauta);
        #endregion

        #region Empresa

        ICollection<Empresa> ListarEmpresa();
        Empresa ObtenerEmpresa(int codigoEmpresa);
        Empresa RegistrarEmpresa(int codigoEmpresa, string RUC, string nombrecomercial, string direccion, string telefono, string Estado);
        TipoPauta ModificarEmpresa(int codigoEmpresa, string RUC, string nombrecomercial, string direccion, string telefono, string Estado);
        void EliminarEmpresa(int codigoEmpresa);
        ICollection<Empresa> ListarEmpresa(int codigoEmpresa);

        #endregion

    }
}