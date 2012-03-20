using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data; 
using System.Web.UI.MobileControls;

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
        public ICollection<Empresa> ConsultaEmpresa(string ruc, string nombreComercial)
        {
            //String cadena = "Data Source=(local);Initial Catalog=SUNAT;Integrated Security=True";
            //SqlConnection cn = new SqlConnection(cadena);
            //cn.Open();
            //String query = "select * from contribuyentes where ruc='" + ruc + "'";
            //SqlCommand comando = new SqlCommand(query, cn);
            //SqlDataReader resultado = comando.ExecuteReader(); // Ejecuta y no devuelve valor
            //// Capturar el resultado
            //resultado.Read();
            //cn.Close();

            List<Empresa> empresas = new List<Empresa>();
            Empresa empresa = new Empresa();
            empresa.RUC = "123";
            empresa.RUC = "Prueba";
            empresa.RUC = "Activo";
            empresas.Add(empresa); 
            empresa = new Empresa();
            empresa.RUC = "345";
            empresa.RUC = "Test";
            empresa.RUC = "Inactivo";
            empresas.Add(empresa);

            return empresas;
        }
    }
}
