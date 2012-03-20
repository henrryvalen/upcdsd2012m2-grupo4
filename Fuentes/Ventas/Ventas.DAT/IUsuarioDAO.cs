using System;
using Ventas.BE;
using System.Collections.Generic;

namespace Ventas.DAL
{
    public interface IUsuarioDAO : IBaseDAO<Usuario, int>
    {
        Usuario ObtenerPorParametros(Usuario UsuarioAObtener);
    }
}
