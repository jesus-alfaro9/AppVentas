using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppVentasNet.Data
{
    public class DBConexion
    {
        private static string con = ConfigurationManager.ConnectionStrings["conex"].ConnectionString;
       
        public SqlConnection GetConexion()
        {
            SqlConnection cn = new SqlConnection(con);
            return cn;
        }
    }
}