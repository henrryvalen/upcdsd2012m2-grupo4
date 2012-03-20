using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using Ventas.BE;

namespace Ventas.DAL.EF.ORM
{
    public class TarifaMapping : EntityTypeConfiguration<Tarifa>
    {
        public TarifaMapping()
            : base()
        {
            ToTable("Tarifa");
            HasKey(s => s.Codigo);
            Property(s => s.Codigo)
                .HasColumnName("tarifaCodigo")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.DatabaseGeneratedOption.None);
            Property(s => s.CodigoRadio)
                .HasColumnName("tarifaCodigoRadio").IsRequired();
            Property(s => s.CodigoTipoPauta)
                .HasColumnName("tarifaCodigoTipoPauta").IsRequired();
            Property(s => s.Precio)
                .HasColumnName("tarifaPrecio").IsRequired();
            Property(s => s.Bloque)
                .HasColumnName("tarifaBloque").IsRequired();
            Property(s => s.Estado)
                .HasColumnName("tarifaEstado").IsRequired();
        }
    }
}
