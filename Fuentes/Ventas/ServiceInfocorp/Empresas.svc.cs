using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Infocorp
{
    public class Empresas : IEmpresas
    {
        public string ObtenerEstadoEmpresa(string str_Ruc)
        { 
            if (str_Ruc == "121212121212")
                return "Habilitada";
            else
                return "No Habilitada";
        }

    }
}
