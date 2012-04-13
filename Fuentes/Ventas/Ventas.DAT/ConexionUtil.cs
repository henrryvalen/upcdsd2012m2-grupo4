using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Ventas.DAL
{
    public class ConexionUtil
    {
        private const string _NombreCadenaConexion = "VentasConnectionString";
        private static string _CadenaConexion = null;

        public static string ObtenerCadena()
        {
            if (_CadenaConexion == null)
            {
                //_CadenaConexion = "Server=VIRTUALXP-50904\\SQL2008; User ID=sa; Initial Catalog=Ventas; password=royal2008;";
                _CadenaConexion = "Data Source = (local); Initial Catalog = Ventas; Integrated Security = SSPI;";
            }
            return _CadenaConexion;
        }
    }
}

