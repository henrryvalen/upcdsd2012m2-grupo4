using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using Ventas.BE;

namespace Ventas.DAL.EF.ORM
{
    public class EmpresaMapping : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMapping()
            : base()
        {
            ToTable("Empresa");
            HasKey(s => s.Codigo);
            Property(s => s.Codigo)
                .HasColumnName("empresaCodigo")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.DatabaseGeneratedOption.None);
            Property(s => s.RUC)
                .HasColumnName("empresaRUC").IsRequired();
            Property(s => s.nombrecomercial)
                .HasColumnName("empresaNombreComercial").IsRequired();
            Property(s => s.direccion)
                .HasColumnName("empresaDireccion").IsRequired();
            Property(s => s.telefono)
                .HasColumnName("empresaTelefono").IsRequired();           
            Property(s => s.Estado)
                .HasColumnName("empresaEstado").IsRequired();
        }

    }
}
