
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

    }
}