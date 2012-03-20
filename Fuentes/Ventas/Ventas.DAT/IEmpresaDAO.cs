using System;
using Ventas.BE;
using System.Collections.Generic;

namespace Ventas.DAL
{
    public interface IEmpresaDAO: IBaseDAO<Empresa, int>
    {
        ICollection<Empresa> ListarEmpresa(int codigoEmpresa);
  
    }
}
