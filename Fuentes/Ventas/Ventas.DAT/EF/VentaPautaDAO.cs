using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ventas.BE;

namespace Ventas.DAL.EF
{
    public class VentaPautaDAO:IVentaPautaDAO
    {

        #region IBaseDAO<VentaPauta,int> Members

        /// <summary>
        /// Crear VentaPauta
        /// </summary>
        /// <param name="EmpresaACrear">Dominio VentaPauta</param>
        /// <returns>Dominio VentaPauta</returns>
        public VentaPauta Crear(VentaPauta VentaPautaACrear)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                int? codigo = db.VentaPauta.Select(l => (int?)l.Codigo).Max();
                VentaPautaACrear.Codigo = (codigo ?? 0) + 1;
                db.VentaPauta.Add(VentaPautaACrear);
                db.SaveChanges();
            }
            return Obtener(VentaPautaACrear.Codigo);
        }

        public VentaPauta Modificar(VentaPauta itemAModificar)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                VentaPauta ventapauta = db.VentaPauta.Single(l => l.Codigo == itemAModificar.Codigo);
                ventapauta.Codigo = itemAModificar.Codigo;
                ventapauta.ventaEstado = itemAModificar.ventaEstado;
                ventapauta.ventaUsuarioModif = itemAModificar.ventaUsuarioModif;
                ventapauta.ventaFechaModif = itemAModificar.ventaFechaModif;
                ventapauta.ventaEstado = itemAModificar.ventaEstado;
                db.SaveChanges();
                return ventapauta;
            }
        }

       

        /// <summary>
        /// Obtener ventapauta
        /// </summary>
        /// <param name="Codigo">Codigo de ventapauta</param>
        /// <returns></returns>
        public VentaPauta Obtener(int Codigo)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                var ventapauta = from l in db.VentaPauta
                              where l.Codigo == Codigo
                              select l;
                return ventapauta.SingleOrDefault();
            }
        }

        public ICollection<VentaPauta> ListarTodos()
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                var resultado = from l in db.VentaPauta
                                select l;
                return resultado.ToList();
            }
        }

        #endregion

        public ICollection<VentaPauta> ListarVentaPauta(int ventaCodigo)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(BE.VentaPauta entidad)
        {
            throw new NotImplementedException();
        }

    }
}
