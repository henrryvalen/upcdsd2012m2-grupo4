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
    public class TipoPauta
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        [Required(ErrorMessage = "La descripción del tipo de pauta es obligatorio")]
        public string Descripcion { get; set; }



        [DataMember]
        [Required(ErrorMessage = "El estado es obligatorio")]
        public string Estado { get; set; }
    }
}
