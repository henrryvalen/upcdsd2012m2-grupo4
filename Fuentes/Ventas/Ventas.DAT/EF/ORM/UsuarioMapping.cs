
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Ventas.BE;

namespace Ventas.DAL.EF.ORM
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
            : base()
        {
            ToTable("Usuario");
            HasKey(s => s.Codigo);
            Property(s => s.Codigo)
                .HasColumnName("usuarioCodigo")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.DatabaseGeneratedOption.None);
            Property(s => s.User)
                .HasColumnName("usuarioUser").IsRequired();
            Property(s => s.Password)
                .HasColumnName("usuarioPassword").IsRequired();         
            Property(s => s.Estado)
                .HasColumnName("usuarioEstado").IsRequired();
        }
    }


}
