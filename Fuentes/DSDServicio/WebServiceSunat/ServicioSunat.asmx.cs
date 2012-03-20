using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using WebServiceSunat.Dominio;
using WebServiceSunat.Persistencia;

namespace WebServiceSunat
{
    /// <summary>
    /// Descripción breve de ServicioSunat
    /// </summary>
    [WebService(Namespace = "http://localhost/", Name = "Servicio Web Consulta SUNAT", Description = "Reazliado Por Grupo 4 - Desarrollo de Sistemas Distribuidos - EPE")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioSunat : System.Web.Services.WebService
    {
        [WebMethod]
        public Contribuyente ConsultaRuc(string ruc)
        {
            String cadena = "Data Source=(local);Initial Catalog=SUNAT;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();
            String query = "select * from contribuyentes where ruc='" + ruc + "'";
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataReader resultado = comando.ExecuteReader(); // Ejecuta y no devuelve valor
            // Capturar el resultado
            resultado.Read();

            Contribuyente contribuyenteObtenido = new Contribuyente();
            contribuyenteObtenido.Ruc = (String)resultado["ruc"];
            contribuyenteObtenido.RazonSocial = (String)resultado["razonsocial"];
            contribuyenteObtenido.FInscripcion = (String)resultado["finscripcion"];
            contribuyenteObtenido.Estado = (String)resultado["estado"];
            contribuyenteObtenido.Condicion = (String)resultado["condicion"];
            contribuyenteObtenido.Direccion = (String)resultado["direccion"];
            contribuyenteObtenido.Telefono = (String)resultado["telefono"];
            contribuyenteObtenido.Sistema = (String)resultado["sistema"];
           
            cn.Close();
           

            DTOContribuyente dto=new DTOContribuyente();
            return contribuyenteObtenido;
            
            
        }

        [WebMethod]
        public List<Contribuyente> obtenerTodos()
        {
            String cadena = "Data Source=(local);Initial Catalog=SUNAT;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();
            String query = "select * from contribuyentes";
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataReader resultado = comando.ExecuteReader(); // Ejecuta y no devuelve valor
            
            List<Contribuyente> lstCad = new List<Contribuyente>();
            // Capturar el resultado
            while (resultado.Read())
            {

                Contribuyente contribuyenteObtenido = new Contribuyente();
                contribuyenteObtenido.Ruc = (String)resultado["ruc"];
                contribuyenteObtenido.RazonSocial = (String)resultado["razonsocial"];
                contribuyenteObtenido.FInscripcion = (String)resultado["finscripcion"];
                contribuyenteObtenido.Estado = (String)resultado["estado"];
                contribuyenteObtenido.Condicion = (String)resultado["condicion"];
                contribuyenteObtenido.Direccion = (String)resultado["direccion"];
                contribuyenteObtenido.Telefono = (String)resultado["telefono"];
                contribuyenteObtenido.Sistema = (String)resultado["sistema"];

            
            DTOContribuyente dto = new DTOContribuyente();
            lstCad.Add(contribuyenteObtenido);

            }

            cn.Close();
             
            return lstCad;

            
        }

        [WebMethod]
        public List<Contribuyente> buscarPorrazonSocial(String razons)
        {
            String cadena = "Data Source=(local);Initial Catalog=SUNAT;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();
            String query = "SELECT * FROM contribuyentes WHERE (RazonSocial LIKE '%"+razons+"%')";
            SqlCommand comando = new SqlCommand(query, cn);
            SqlDataReader resultado = comando.ExecuteReader(); // Ejecuta y no devuelve valor

            List<Contribuyente> lstCad = new List<Contribuyente>();
            // Capturar el resultado
            while (resultado.Read())
            {

                Contribuyente contribuyenteObtenido = new Contribuyente();
                contribuyenteObtenido.Ruc = (String)resultado["ruc"];
                contribuyenteObtenido.RazonSocial = (String)resultado["razonsocial"];
                contribuyenteObtenido.FInscripcion = (String)resultado["finscripcion"];
                contribuyenteObtenido.Estado = (String)resultado["estado"];
                contribuyenteObtenido.Condicion = (String)resultado["condicion"];
                contribuyenteObtenido.Direccion = (String)resultado["direccion"];
                contribuyenteObtenido.Telefono = (String)resultado["telefono"];
                contribuyenteObtenido.Sistema = (String)resultado["sistema"];


                DTOContribuyente dto = new DTOContribuyente();
                lstCad.Add(contribuyenteObtenido);

            }

            cn.Close();

            return lstCad;


        }
    }
}
