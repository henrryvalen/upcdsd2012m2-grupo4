using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Ventas.BE
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }

        public override string ToString()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Usuario));
            using (var stream = new System.IO.StringWriter())
            {
                serializer.Serialize(stream, this);
                return stream.ToString();
            }
        }
    }
}
