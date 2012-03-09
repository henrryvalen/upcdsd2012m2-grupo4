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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {  
            modelBuilder.Configurations.Add(new TipoPautaMapping()); 
            base.OnModelCreating(modelBuilder);
        }
    }
}