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
    public class Radio
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        public string NombreComercial { get; set; }

        [DataMember]
        public string Estado { get; set; }

    }
}
