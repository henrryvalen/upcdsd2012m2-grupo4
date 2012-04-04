using System.Collections.Generic;

namespace Ventas.DAL
{
    public interface IBaseDAO<Entidad,Id>
    {
        Entidad Crear(Entidad entidad);
        Entidad Obtener(Id id);
        Entidad Modificar(Entidad entidad);
        //Entidad CancelarVentaPauta(Entidad entidad);
        void Eliminar(Entidad entidad);
        ICollection<Entidad> ListarTodos();
    }
}

