using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Ventas.BE;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace Sunat
{
    public class Empresas : IEmpresa
    {

        public ICollection<Empresa> ConsultarEmpresa(string RUC, string nombreComercial)
        {
            OleDbConnection obj_Conexion = new OleDbConnection();
            OleDbCommand obj_Comando = new OleDbCommand();
            OleDbDataAdapter obj_Adapter = new OleDbDataAdapter();
            DataSet obj_Data = new DataSet();
            obj_Conexion.ConnectionString = "Server=VIRTUALXP-50904\\SQL2008; Provider=SQLOLEDB; User ID=sa; Initial Catalog=Ventas; password=royal2008;";
            obj_Conexion.Open();
            obj_Comando.Connection = obj_Conexion;
            if (RUC == null && nombreComercial == null)
                obj_Comando.CommandText = "Select * From Contribuyentes";
            else if (RUC != null && nombreComercial == null)
                obj_Comando.CommandText = "Select * From Contribuyentes Where Ruc Like '%" + RUC + "%'";
            else
                obj_Comando.CommandText = "Select * From Contribuyentes Where RazonSocial Like '%" + nombreComercial + "%'";
            obj_Comando.CommandType = CommandType.Text;
            obj_Adapter.SelectCommand = obj_Comando;
            obj_Adapter.Fill(obj_Data);
            obj_Conexion.Close();

            List<Empresa> empresas = new List<Empresa>();
            Empresa empresa;
            foreach (var dr_Fila in obj_Data.Tables[0].Rows)
            {
                DataRow fila = (DataRow)dr_Fila;
                empresa = new Empresa();
                empresa.RUC = fila[0].ToString();
                empresa.nombrecomercial = fila[1].ToString();
                empresa.Estado = fila[3].ToString();
                empresas.Add(empresa);
            }

            return empresas;
        }

        public Empresa ObtenerEmpresa(string RUC)
        {
            OleDbConnection obj_Conexion = new OleDbConnection();
            OleDbCommand obj_Comando = new OleDbCommand();
            OleDbDataAdapter obj_Adapter = new OleDbDataAdapter();
            DataSet obj_Data = new DataSet();
            obj_Conexion.ConnectionString = "Server=VIRTUALXP-50904\\SQL2008; Provider=SQLOLEDB; User ID=sa; Initial Catalog=Ventas; password=royal2008;";
            obj_Conexion.Open();
            obj_Comando.Connection = obj_Conexion;
            obj_Comando.CommandText = "Select * From Contribuyentes Where Ruc ='" + RUC + "'";
            obj_Comando.CommandType = CommandType.Text;
            obj_Adapter.SelectCommand = obj_Comando;
            obj_Adapter.Fill(obj_Data);
            obj_Conexion.Close();

            Empresa empresa = new Empresa(); ;
            foreach (var dr_Fila in obj_Data.Tables[0].Rows)
            {
                DataRow fila = (DataRow)dr_Fila;
                empresa.RUC = fila[0].ToString();
                empresa.nombrecomercial = fila[1].ToString();
                empresa.direccion = fila[5].ToString();
                empresa.telefono = fila[6].ToString();
                empresa.Estado = fila[3].ToString();
            }

            return empresa;
        }
    }
}
