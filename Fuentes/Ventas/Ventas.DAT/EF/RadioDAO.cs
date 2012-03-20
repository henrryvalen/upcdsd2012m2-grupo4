using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ventas.DAL.EF
{
    public class RadioDAO : IRadioDAO
    {
        public BE.Radio Crear(BE.Radio entidad)
        {
            throw new NotImplementedException();
        }

        public BE.Radio Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public BE.Radio Modificar(BE.Radio entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(BE.Radio entidad)
        {
            throw new NotImplementedException();
        }

        public ICollection<BE.Radio> ListarTodos()
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                var resultado = from l in db.Radio
                                select l;
                return resultado.ToList();
            }
        }
    }
}
