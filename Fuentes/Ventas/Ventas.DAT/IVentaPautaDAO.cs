using System;
using Ventas.BE;
using System.Collections.Generic;

namespace Ventas.DAL
{
    public interface IVentaPautaDAO : IBaseDAO<VentaPauta, int>
    {
        ICollection<VentaPauta> ListarVentaPauta(int ventaCodigo);

    }
}
