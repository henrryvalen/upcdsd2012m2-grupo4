
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
        Empresa ModificarEmpresa(int codigoEmpresa, string RUC, string nombrecomercial, string direccion, string telefono, string Estado);
        void EliminarEmpresa(int codigoEmpresa);
        ICollection<Empresa> ListarEmpresa(int codigoEmpresa);

        #endregion

        #region Usuario

        Usuario ValidarUsuario(string usuarioUser, string usuarioPassword);

        #endregion

        #region Tarifa

        ICollection<Tarifa> ListarTarifa();
        Tarifa ObtenerTarifa(int codigoTarifa);
        Tarifa RegistrarTarifa(int codigoTarifa, int codigoRadio, int CodigoTipoPauta, decimal? precio, string bloque, string estado);
        Tarifa ModificarTarifa(int codigoTarifa, int codigoRadio, int CodigoTipoPauta, decimal? precio, string bloque, string estado);
        void EliminarTarifa(int codigoTarifa);

        #endregion

        #region Tarifa

        ICollection<Radio> ListarRadio();

        #endregion

    }
}