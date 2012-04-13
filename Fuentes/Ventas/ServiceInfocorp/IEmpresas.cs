using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Infocorp
{
    [ServiceContract]
    public interface IEmpresas
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        string ObtenerEstadoEmpresa(string str_Ruc);

    }
}
