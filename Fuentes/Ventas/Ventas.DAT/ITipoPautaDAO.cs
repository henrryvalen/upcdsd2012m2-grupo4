using System;
using Ventas.BE;
using System.Collections.Generic;

namespace Ventas.DAL
{
    public interface ITipoPautaDAO : IBaseDAO<TipoPauta, int>
    {
        ICollection<TipoPauta> ListarTipoPauta(int codigoTipoPauta);
    }
}
