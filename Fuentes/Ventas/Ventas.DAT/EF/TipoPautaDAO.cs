using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ventas.BE;

namespace Ventas.DAL.EF
{
    public class TipoPautaDAO : ITipoPautaDAO
    {
        #region IBaseDAO<TipoPauta,int> Members

        /// <summary>
        /// Crear Tipo de Pauta
        /// </summary>
        /// <param name="TipoPautaACrear">Dominio Tipo de Pauta</param>
        /// <returns>Dominio Tipo de Pauta</returns>
        public TipoPauta Crear(TipoPauta TipoPautaACrear)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                int? codigo = db.TipoPauta.Select(l => (int?)l.Codigo).Max();
                TipoPautaACrear.Codigo = (codigo ?? 0) + 1;
                db.TipoPauta.Add(TipoPautaACrear);
                db.SaveChanges();
            }
            return Obtener(TipoPautaACrear.Codigo);
        }

        public TipoPauta Modificar(TipoPauta itemAModificar)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                TipoPauta tipoPauta = db.TipoPauta.Single(l => l.Codigo == itemAModificar.Codigo);
                tipoPauta.Descripcion = itemAModificar.Descripcion;
                tipoPauta.Estado = itemAModificar.Estado;
                db.SaveChanges();
                return tipoPauta;
            }
        }

        public void Eliminar(TipoPauta itemEliminar)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                TipoPauta tipoPauta = (from s in db.TipoPauta
                                       where s.Codigo == itemEliminar.Codigo
                                       select s).Single();
                db.TipoPauta.Remove(tipoPauta);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Obtener Tipo de Pauta
        /// </summary>
        /// <param name="Codigo">Codigo del Tipo de Pauta</param>
        /// <returns></returns>
        public TipoPauta Obtener(int Codigo)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                var cliente = from l in db.TipoPauta
                              where l.Codigo == Codigo
                              select l;
                return cliente.SingleOrDefault();
            }
        }

        public ICollection<TipoPauta> ListarTodos()
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                var resultado = from l in db.TipoPauta
                                select l;
                return resultado.ToList();
            }
        }

        #endregion

        public ICollection<TipoPauta> ListarTipoPauta(int codigoTipoPauta)
        {
            throw new NotImplementedException();
        }
    }
}