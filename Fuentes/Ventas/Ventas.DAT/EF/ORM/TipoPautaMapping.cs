using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using Ventas.BE;

namespace Ventas.DAL.EF.ORM
{
    public class TipoPautaMapping : EntityTypeConfiguration<TipoPauta>
    {
        public TipoPautaMapping()
            : base()
        {
            ToTable("TipoPauta");
            HasKey(s => s.Codigo);
            Property(s => s.Codigo)
                .HasColumnName("tipoPautaCodigo")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.DatabaseGeneratedOption.None);
            Property(s => s.Descripcion)
                .HasColumnName("tipoPautaNombre").IsRequired();
            Property(s => s.Estado)
                .HasColumnName("tipoPautaEstado").IsRequired();
        }
    }
}