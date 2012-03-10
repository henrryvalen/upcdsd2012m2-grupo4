using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace DSDServicio1WebGpo4.App_Entity
{
    [Serializable()]
    public class Empresa: ISerializable
    {
        String razonSocial, ruc, direccion, telefono, contacto, 
                rubro, email, fg_estado;
        
        public Empresa() {

        }

        public String getRazonSocial() { return this.razonSocial; }
        public void setRazonSocial(String rs) { this.razonSocial = rs; }

        public String getRuc() { return this.ruc; }
        public void setRuc(String rs) { this.ruc = rs; }

        public String getDireccion() { return this.direccion; }
        public void setDireccion(String rs) { this.direccion = rs; }

        public String getTelefono() { return this.telefono; }
        public void setTelefono(String rs) { this.telefono = rs; }

        public String getContacto() { return this.contacto; }
        public void setContacto(String rs) { this.contacto = rs; }

        public String getRubro() { return this.rubro; }
        public void setRubro(String rs) { this.rubro = rs; }

        public String getEmail() { return this.email; }
        public void setEmail(String rs) { this.email = rs; }

        public String getFg_estado() { return this.fg_estado; }
        public void setFg_estado(String rs) { this.fg_estado = rs; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}