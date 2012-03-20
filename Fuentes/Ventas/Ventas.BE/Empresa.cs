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
    public class Empresa
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        [Required(ErrorMessage = "El RUC de la empresa es obligatorio")]
        public string RUC { get; set; }

        [DataMember]
        [Required(ErrorMessage = "El nombre comercial de la empresa es obligatorio")]
        public string nombrecomercial { get; set; }

        [DataMember]
        [Required(ErrorMessage = "El direccion de la empresa es obligatorio")]
        public string direccion { get; set; }

        [DataMember]
        [Required(ErrorMessage = "El telefono de la empresa es obligatorio")]
        public string telefono { get; set; }

        [DataMember]
        [Required(ErrorMessage = "El estado es obligatorio")]
        public string Estado { get; set; }
    }
}
