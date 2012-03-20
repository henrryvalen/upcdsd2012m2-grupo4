using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WebServiceSunat
{
    /// <summary>
    /// Descripción breve de ServicioSunat
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/", Name = "Servicio Web Consulta SUNAT", Description = "Por Grupo 4")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioSunat : System.Web.Services.WebService
    {
        [WebMethod]
        public string ConsultaRuc(string ruc)
        {
            String cadena = "Data Source=(local);Initial Catalog=Clinica;Integrated Security=True";
            SqlConnection Cn = new SqlConnection();

            String resultado = "";
            if (ruc == "20100017904")
            {
                resultado = "EL PACIFICO SEGUROS Y REASEGUROS";
            }
            return resultado;
        }
    }
}
