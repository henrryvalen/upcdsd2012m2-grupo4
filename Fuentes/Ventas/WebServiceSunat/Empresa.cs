using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web; 
using System.Runtime.Serialization;

namespace WebServiceSunat
{
    [DataContract]
    public class Empresa
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember] 
        public string RUC { get; set; }

        [DataMember] 
        public string nombrecomercial { get; set; }

        [DataMember] 
        public string direccion { get; set; }

        [DataMember] 
        public string telefono { get; set; }

        [DataMember] 
        public string Estado { get; set; }
    }
}
