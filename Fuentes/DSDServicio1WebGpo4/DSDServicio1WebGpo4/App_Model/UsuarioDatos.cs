using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSDServicio1WebGpo4.App_Entity;

namespace DSDServicio1WebGpo4.App_Model
{
    public class UsuarioDatos
    {
        Usuario u1, u2;
        List<Usuario> lstUsuarios = null;
        public UsuarioDatos() {
            u1 = new Usuario("Rolando Palomino","123456","rpalomino");
            u2 = new Usuario("Jonathan Gamba","654321","jgamba");
            lstUsuarios = new List<Usuario>();
            lstUsuarios.Add(u1);
            lstUsuarios.Add(u2);
        }

        public Usuario getUsuarioById(String id) {
            Usuario u = null;
            if (id.Trim().Equals("")) { u = null; }

            foreach (Usuario user in lstUsuarios)
            {
                if (user.getId().Equals(id)) { u = user; }
            }
            return u;
        }
    }
}