
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Ventas.BE;

namespace Ventas.DAL.EF.ORM
{
    public class VentaPautaMapping : EntityTypeConfiguration<VentaPauta>
    {
        public VentaPautaMapping()
            : base()
        {
            ToTable("VentaPauta");
            HasKey(s => s.Codigo);
            Property(s => s.Codigo)
                .HasColumnName("ventaCodigo")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.DatabaseGeneratedOption.None);
            Property(s => s.radioCodigo)
                .HasColumnName("radioCodigo").IsRequired();
            Property(s => s.ventaNombreVendedor)
                .HasColumnName("ventaNombreVendedor").IsRequired();
            Property(s => s.ventaDescripcionProducto)
                .HasColumnName("ventaDescripcionProducto").IsRequired();
            Property(s => s.empresaRUC)
               .HasColumnName("empresaRuc").IsRequired();
            Property(s => s.tipoPautaCodigo)
               .HasColumnName("tipoPautaCodigo").IsRequired();
            Property(s => s.ventaNumeroDias)
               .HasColumnName("ventaNumeroDias").IsRequired();
            Property(s => s.ventaPrioridad)
               .HasColumnName("ventaPrioridad").IsRequired();
            Property(s => s.ventaTipoTransaccion)
               .HasColumnName("ventaTipoTransaccion").IsRequired();
            Property(s => s.ventaIGV)
               .HasColumnName("ventaIGV").IsRequired();
            Property(s => s.ventaTipoOrden)
              .HasColumnName("ventaTipoOrden").IsRequired();
            Property(s => s.ventaImporteTotal)
              .HasColumnName("ventaImporteTotal").IsRequired();
            Property(s => s.ventaMontoTotal)
              .HasColumnName("ventaMontoTotal").IsRequired();
            Property(s => s.ventaTipoPago)
             .HasColumnName("ventaTipoPago").IsRequired();
            Property(s => s.ventaFechaCreacion)
             .HasColumnName("ventaFechaCreacion").IsRequired();
            Property(s => s.ventaUsuarioCreacion)
             .HasColumnName("ventaUsuarioCreacion").IsRequired();
            Property(s => s.ventaFechaModif)
             .HasColumnName("ventaFechaModif").IsRequired();
            Property(s => s.ventaUsuarioModif)
            .HasColumnName("ventaUsuarioModif").IsRequired();
            Property(s => s.ventaEstado)
            .HasColumnName("ventaEstado").IsRequired(); 
        }
    }
}
