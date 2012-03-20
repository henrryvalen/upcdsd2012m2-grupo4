using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
////////////
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace WebServiceSunat.Persistencia
{
    public class DTOContribuyente
    {

        public DTOContribuyente() { }


        public string ToXML(Object oObject)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(oObject.GetType());
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, oObject);
                xmlStream.Position = 0;
                xmlDoc.Load(xmlStream);
                return xmlDoc.InnerXml;
            }
        }

        public Object XMLToObject(string XMLString, Object oObject)
        {

            XmlSerializer oXmlSerializer = new XmlSerializer(oObject.GetType());
            oObject = oXmlSerializer.Deserialize(new StringReader(XMLString));
            return oObject;
        }
    }

}