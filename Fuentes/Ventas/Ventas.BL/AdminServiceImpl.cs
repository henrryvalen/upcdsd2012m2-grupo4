using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ventas.BE;
using Ventas.DAL;
using Ventas.DAL.EF;

namespace Ventas.BL
{
    public class AdminServiceImpl : IAdminService
    {
        #region Dependencias

        ITipoPautaDAO tipoPautaDAO = new TipoPautaDAO(); 

        #endregion

        #region "Tipo de Pauta"

        public ICollection<TipoPauta> ListarTipoPauta()
        {
            return tipoPautaDAO.ListarTodos();
        }

        public TipoPauta RegistrarTipoPauta(int codigoTipoPauta, string nombre, string estado)
        {
            TipoPauta beTipoPauta = new TipoPauta();
            beTipoPauta.Descripcion = nombre;
            beTipoPauta.Estado = "Activo";
            return tipoPautaDAO.Crear(beTipoPauta);
        }

        public TipoPauta ObtenerTipoPauta(int codigoTipoPauta)
        {
            return tipoPautaDAO.Obtener(codigoTipoPauta);
        }

        public TipoPauta ModificarTipoPauta(int codigoTipoPauta, string nombre, string estado)
        {
            TipoPauta beTipoPauta = tipoPautaDAO.Obtener(codigoTipoPauta);
            beTipoPauta.Descripcion = nombre;
            beTipoPauta.Estado = estado;
            return tipoPautaDAO.Modificar(beTipoPauta);
        }

        public void EliminarTipoPauta(int codigoTipoPauta)
        {
            TipoPauta beTipoPauta = tipoPautaDAO.Obtener(codigoTipoPauta);
            tipoPautaDAO.Eliminar(beTipoPauta);
        }

        #endregion

        public ICollection<TipoPauta> ListarTipoPauta(int codigoTipoPauta)
        {
            throw new NotImplementedException();
        }
    }
}


