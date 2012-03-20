using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ventas.BE;

namespace Ventas.DAL.EF
{
    public class TarifaDAO : ITarifaDAO
    {
        public Tarifa Crear(Tarifa TarifaACrear)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                int? codigo = db.Tarifa.Select(l => (int?)l.Codigo).Max();
                TarifaACrear.Codigo = (codigo ?? 0) + 1;
                db.Tarifa.Add(TarifaACrear);
                db.SaveChanges();
            }
            return Obtener(TarifaACrear.Codigo);
        }

        public Tarifa Obtener(int Codigo)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                var tarifa = from l in db.Tarifa
                              where l.Codigo == Codigo
                              select l;
                return tarifa.SingleOrDefault();
            }
        }

        public Tarifa Modificar(Tarifa itemAModificar)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                Tarifa tarifa = db.Tarifa.Single(l => l.Codigo == itemAModificar.Codigo);
                tarifa.CodigoRadio = itemAModificar.CodigoRadio;
                tarifa.CodigoTipoPauta = itemAModificar.CodigoTipoPauta;
                tarifa.Precio = itemAModificar.Precio;
                tarifa.Bloque = itemAModificar.Bloque;
                tarifa.Estado = itemAModificar.Estado;
                db.SaveChanges();
                return tarifa;
            }
        }

        public void Eliminar(Tarifa itemEliminar)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                Tarifa tarifa = (from s in db.Tarifa
                                       where s.Codigo == itemEliminar.Codigo
                                       select s).Single();
                db.Tarifa.Remove(tarifa);
                db.SaveChanges();
            }
        }

        public ICollection<Tarifa> ListarTodos()
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                var resultado = from l in db.Tarifa
                                select l;
                return resultado.ToList();
            }
        }
    }
}
