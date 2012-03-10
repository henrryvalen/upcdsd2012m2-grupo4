using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DSDServicio1WebGpo4.App_Entity
{
     [Serializable()]
    public class Usuario: ISerializable
    {
        String nombre = null;
        String clave = null;
        String id = null;

        public Usuario() { 

        }
        public Usuario(String n,String c, String i)
        {
            this.nombre = n;
            this.clave = c;
            this.id = i;
        }
        public String getNombre() { return this.nombre; }
        public void setNombre(String n) { this.nombre = n; }

        public String getClave() { return this.clave; }
        public void setClave(String c) { this.clave = c; }

        public String getId() { return this.id; }
        public void setId(String i) { this.id = i; }

        //Deserialization constructor.
public Usuario(SerializationInfo info, StreamingContext ctxt)
{
    //Get the values from info and assign them to the appropriate properties
    nombre = (String)info.GetValue("nombre", typeof(String));
    clave = (String)info.GetValue("clave", typeof(string));
    id = (String)info.GetValue("id", typeof(string));
}
        
//Serialization function.
public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
{
    //You can use any custom name for your name-value pair. But make sure you
    // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
    // then you should read the same with "EmployeeId"
    info.AddValue("nombre", nombre);
    info.AddValue("clave", clave);
    info.AddValue("id", id);
}
    }
}