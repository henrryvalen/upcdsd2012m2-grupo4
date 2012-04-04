using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Ventas.BE;
using Ventas.DAL.EF.ORM;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Ventas.DAL.EF
{
    public class EFContext : DbContext
    {
        public EFContext(string cadenaConexion)
            : base(cadenaConexion)
        {
            Database.SetInitializer<EFContext>(null);
        }

        public DbSet<TipoPauta> TipoPauta { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tarifa> Tarifa { get; set; }
        public DbSet<Radio> Radio { get; set; }
        public DbSet<VentaPauta> VentaPauta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {  
            modelBuilder.Configurations.Add(new TipoPautaMapping());
            modelBuilder.Configurations.Add(new EmpresaMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new TarifaMapping());
            modelBuilder.Configurations.Add(new RadioMapping());
            modelBuilder.Configurations.Add(new VentaPautaMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}