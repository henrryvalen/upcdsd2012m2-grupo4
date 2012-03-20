using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ventas.BE;

namespace Ventas.DAL.EF
{
    public class UsuarioDAO : IUsuarioDAO
    {
        #region IBaseDAO<TipoPauta,int> Members

        public Usuario Crear(Usuario entidad)
        {
            throw new NotImplementedException();
        }

        public Usuario Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Modificar(Usuario entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Usuario entidad)
        {
            throw new NotImplementedException();
        }

        public ICollection<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }

        #endregion

        public Usuario ObtenerPorParametros(Usuario UsuarioAObtener)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                var usuario = from l in db.Usuario
                              where l.User == UsuarioAObtener.User &&
                                    l.Password == UsuarioAObtener.Password &&
                                    l.Estado == "A"
                              select l;
                return usuario.SingleOrDefault();
            }
        }
    }
}
