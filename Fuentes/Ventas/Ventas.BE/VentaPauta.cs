using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace Ventas.BE
{
    [DataContract]
    public class VentaPauta
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        [Required(ErrorMessage = "El radio es obligatorio")]
        public int radioCodigo { get; set; }

        [DataMember]
        [Required(ErrorMessage = "El nombre del vendedor es obligatorio")]
        public string ventaNombreVendedor { get; set; }
        
        [DataMember]
        [Required(ErrorMessage = "La descripción del producto  es obligatorio")]
        public string ventaDescripcionProducto { get; set; }

        [DataMember]
        [Required(ErrorMessage = "El RUC de la empresa  es obligatorio")]
        public string empresaRUC { get; set; }

        [DataMember]
        [Required(ErrorMessage = "El tipo de Pauta es obligatorio")]
        public int tipoPautaCodigo { get; set; }

        [DataMember]
        [Required(ErrorMessage = "El número de días es obligatorio")]
        public string ventaNumeroDias { get; set; }

        [DataMember]
        public int ventaPrioridad { get; set; }

        [DataMember]
        [Required(ErrorMessage = "El tipo de transacción es obligatorio")]
        public int ventaTipoTransaccion { get; set; }

        [DataMember]
        public int ventaIGV { get; set; }

        [DataMember]
        public int ventaTipoOrden { get; set; }

        [DataMember]
        public decimal ventaImporteTotal { get; set; }

        [DataMember]
        public decimal ventaMontoTotal { get; set; }

        [DataMember]
        public int ventaTipoPago { get; set; }

        [DataMember]
        public DateTime ventaFechaCreacion { get; set; }

        [DataMember]
        public string ventaUsuarioCreacion { get; set; }

        [DataMember]
        public DateTime ventaFechaModif { get; set; }

        [DataMember]
        public string ventaUsuarioModif { get; set; }

        [DataMember]
        public string ventaEstado { get; set; }

    }
}
