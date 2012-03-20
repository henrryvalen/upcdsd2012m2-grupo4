using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ventas.BE;

namespace Ventas.DAL.EF
{
    public class EmpresaDAO: IEmpresaDAO
    {
        #region IBaseDAO<Empresa,int> Members

        /// <summary>
        /// Crear Empresa
        /// </summary>
        /// <param name="EmpresaACrear">Dominio Empresa</param>
        /// <returns>Dominio Empresa</returns>
        public Empresa Crear(Empresa EmpresaACrear)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                int? codigo = db.Empresa.Select(l => (int?)l.Codigo).Max();
                EmpresaACrear.Codigo = (codigo ?? 0) + 1;
                db.Empresa.Add(EmpresaACrear);
                db.SaveChanges();
            }
            return Obtener(EmpresaACrear.Codigo);
        }

        public Empresa Modificar(Empresa itemAModificar)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                Empresa empresa = db.Empresa.Single(l => l.Codigo == itemAModificar.Codigo);
                empresa.RUC = itemAModificar.RUC;
                empresa.nombrecomercial = itemAModificar.nombrecomercial;
                empresa.direccion = itemAModificar.direccion;
                empresa.telefono = itemAModificar.telefono;
                empresa.Estado = itemAModificar.Estado;
                db.SaveChanges();
                return empresa;
            }
        }

        public void Eliminar(Empresa itemEliminar)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                Empresa empresa = (from s in db.Empresa
                                       where s.Codigo == itemEliminar.Codigo
                                       select s).Single();
                db.Empresa.Remove(empresa);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Obtener empresa
        /// </summary>
        /// <param name="Codigo">Codigo del Empresa</param>
        /// <returns></returns>
        public Empresa Obtener(int Codigo)
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                var empresa = from l in db.Empresa
                              where l.Codigo == Codigo
                              select l;
                return empresa.SingleOrDefault();
            }
        }

        public ICollection<Empresa> ListarTodos()
        {
            using (EFContext db = new EFContext(ConexionUtil.ObtenerCadena()))
            {
                var resultado = from l in db.Empresa
                                select l;
                return resultado.ToList();
            }
        }

        #endregion

        public ICollection<Empresa> ListarEmpresa(int codigoEmpresa)
        {
            throw new NotImplementedException();
        }

    }
}
