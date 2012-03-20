using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceSunat.Dominio
{
    public class Contribuyente
    {
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public string FInscripcion { get; set; }
        public string Estado { get; set; }
        public string Condicion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Sistema { get; set; }
    }
}