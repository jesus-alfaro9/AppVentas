using AppVentasNet.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppVentasNet.Models
{
    public class MantenimientoCliente:DBConexion
    {

        public List<Cliente> Lista()
        {

            List<Cliente> lstCliente = new List<Cliente>();

            using (SqlConnection cn=GetConexion())
            {
                SqlCommand cmd = new SqlCommand("ListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                Cliente ocliente;
                while (dr.Read())
                {
                    ocliente = new Cliente() { 
                    IdCliente= dr[0].ToString(),
                    NombreCompañia= dr[1].ToString(),
                    Direccion=dr[2].ToString(),
                    Ciudad=dr[3].ToString(),
                    País=dr[4].ToString(),
                    Telefono=dr[5].ToString()
                    };
                    lstCliente.Add(ocliente);
                }
            }
            return lstCliente;
        }

        public bool Registrar(Cliente oclient)
        {
            bool resul;
            using (SqlConnection cn= GetConexion())
            {
                SqlCommand cmd = new SqlCommand("RegistrarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCliente", oclient.IdCliente);
                cmd.Parameters.AddWithValue("@NombreCompañia", oclient.NombreCompañia);
                cmd.Parameters.AddWithValue("@Direccion", oclient.Direccion);
                cmd.Parameters.AddWithValue("@Ciudad", oclient.Ciudad);
                cmd.Parameters.AddWithValue("@País", oclient.País);
                cmd.Parameters.AddWithValue("@Telefono", oclient.Telefono);
                cn.Open();
                int fila = cmd.ExecuteNonQuery();
                if (fila>0)
                {
                    resul = true;
                }
                else
                {
                    resul = false;
                }
            }
            return resul;
        }

        
    }
}