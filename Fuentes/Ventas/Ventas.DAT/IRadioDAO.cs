using System;
using Ventas.BE;
using System.Collections.Generic;

namespace Ventas.DAL
{
    public interface IRadioDAO : IBaseDAO<Radio, int>
    {
        ICollection<Radio> ListarRadio(int ventaCodigo);
    }
}
