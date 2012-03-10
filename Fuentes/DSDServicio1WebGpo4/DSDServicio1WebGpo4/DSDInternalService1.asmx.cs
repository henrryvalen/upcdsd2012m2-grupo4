using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DSDServicio1WebGpo4.App_Model;
using DSDServicio1WebGpo4.App_Entity;

namespace DSDServicio1WebGpo4
{
    /// <summary>
    /// Descripción breve de Service1
    /// </summary>
    [WebService(Namespace = "http://localhost",Name="DSDInternalService1",Description="Servicio web de uso interno, SUNAT")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
     [System.Web.Script.Services.ScriptService]
    public class DSDInternalService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public Usuario doLogin(String uname,String pwd)
        {
            String nombre = null, credencial = null;
            Usuario response = null;
            try
            {
                nombre = uname;
                credencial = pwd;               
            }catch(Exception ex){
                nombre = null;
                credencial = null;
                System.Console.Out.WriteLine(ex.ToString());
            }
            if ((nombre.Trim().Equals("")) || (credencial.Trim().Equals("")) ) {
                response = null;
            } else {
                response = (new UsuarioDatos().getUsuarioById(nombre));
            }
            return response;
        }

        [WebMethod]
        public Empresa doFindEmpresaByRuc(String r)
        {
            String ruc = null;
            Empresa response = null;
            try
            {
                
                ruc = r;
            }
            catch (Exception ex)
            {
                r = null;
                
            }
            if ((r.Trim().Equals("")))
            {
                response = null;
            }
            else
            {
                response = (new EmpresaDatos().getEmpresaByRucNumber(r));
            }
            return response;
        }

        [WebMethod]
        public Empresa doFindEmpresaByRazonSocial(String r)
        {
            String ruc = null;
            Empresa response = null;
            try
            {

                ruc = r;
            }
            catch (Exception ex)
            {
                r = null;

            }
            if ((r.Trim().Equals("")))
            {
                response = null;
            }
            else
            {
                response = (new EmpresaDatos().getEmpresaByCommercialName(r));
            }
            return response;
        }
    }
}