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
                _CadenaConexion = "Server=localhost; Integrated Security=True; Initial Catalog=Ventas;";
            }
            return _CadenaConexion;
        }
    }
}

