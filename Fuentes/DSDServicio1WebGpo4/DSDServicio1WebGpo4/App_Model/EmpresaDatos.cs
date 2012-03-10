using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSDServicio1WebGpo4.App_Entity;

namespace DSDServicio1WebGpo4.App_Model
{
    public class EmpresaDatos
    {
        List<Empresa> lstEmpresa = null;
        public EmpresaDatos() {
            lstEmpresa = new List<Empresa>();

            Empresa e1 = new Empresa();
            e1.setRuc("123456789012");
            e1.setRazonSocial("Empresa Peruana");
            e1.setDireccion("Ca. Las golondrinas 234 San Jose");
            e1.setTelefono("");
            e1.setRubro("");
            e1.setEmail("");
            e1.setFg_estado("");

            lstEmpresa.Add(e1);

        }

        public Empresa getEmpresaByRucNumber(String r) {
            Empresa e = null;
            foreach (Empresa emp in lstEmpresa)
            {
                if (emp.getRuc().Equals(r.ToString()))
                {
                    e = emp;
                }
            }
            return e;
        }
        public Empresa getEmpresaByCommercialName(String cn) {
            Empresa e = null;
            foreach (Empresa emp in lstEmpresa)
            {
                if (emp.getRazonSocial().Equals(cn.ToString()))
                {
                    e = emp;
                }
            }
            return e;
        }
    }
}