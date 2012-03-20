using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Ventas.BE;

namespace Sunat
{
    [ServiceContract]
    public interface IEmpresa
    { 

        [OperationContract]
        ICollection<Empresa> ConsultarEmpresa(string RUC, string nombreComercial);

        [OperationContract]
        Empresa ObtenerEmpresa(string RUC); 

    } 
}
