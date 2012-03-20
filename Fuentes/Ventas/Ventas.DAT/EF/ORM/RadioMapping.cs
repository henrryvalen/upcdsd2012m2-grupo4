using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using Ventas.BE;

namespace Ventas.DAL.EF.ORM
{
    public class RadioMapping : EntityTypeConfiguration<Radio>
    {
        public RadioMapping()
            : base()
        {
            ToTable("Radio");
            HasKey(s => s.Codigo);
            Property(s => s.Codigo)
                .HasColumnName("radioCodigo")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.DatabaseGeneratedOption.None);
            Property(s => s.NombreComercial)
                .HasColumnName("radioNombreComercial").IsRequired();
            Property(s => s.Estado)
                .HasColumnName("radioEstado").IsRequired();
        }
    }
}
