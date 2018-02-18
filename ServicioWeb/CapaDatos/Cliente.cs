using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;


namespace ServicioWeb
{
    public class Cliente
    {
        #region Campos de la tabla
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        #endregion

        #region constructores de la clase
        public Cliente()
        {
            this.Id = 0;
            this.Nombre = "";
            this.Telefono = "";
        }
        public Cliente(int id, string nombre, string telefono)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Telefono = telefono;
        }
        #endregion


        #region Metodos para insertar un registro a la base de datos
        public int          InsertarRegistro(string nombre, string telefono)
        {

            SqlConnection con =  Conexion.ConectarSQL();
            con.Open();
            
            string sql = "INSERT INTO Clientes (Nombre, Telefono) VALUES (@nombre, @telefono)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@telefono", System.Data.SqlDbType.NVarChar).Value = telefono;
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public string       strListadoJSON()
        {
            SqlConnection con = Conexion.ConectarSQL();
            con.Open();

            string sql = "SELECT IdCliente, Nombre, Telefono FROM Clientes";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Cliente> lista = new List<Cliente>();
            while (reader.Read())
            {
                lista.Add(new Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }
            con.Close();
            return (new JavaScriptSerializer().Serialize(lista));
        }
        public Cliente[]    strListadoXML()
        {
            SqlConnection con = Conexion.ConectarSQL();
            con.Open();

            string sql = "SELECT IdCliente, Nombre, Telefono FROM Clientes";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Cliente> lista = new List<Cliente>();
            while (reader.Read())
            {
                lista.Add(new Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }
            con.Close();
            return lista.ToArray();
        }
        #endregion
    }
}