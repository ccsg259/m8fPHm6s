using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace capaDatos
{
    public class Encuesta
    {
        #region campos de la tabla
            string IdUnico  {get; set;}
            string Titulo   {get; set;}
            string Fecha    {get; set;}
        #endregion

        #region procedimientos y funciones de la tabla

        public void ActualizarNuevo(string IdUnico, string Titulo, string Usee, string Pass)
        {
            SqlConnection con = Conexion.ConectarSQL();
            SqlCommand cmd = new SqlCommand("spEncuesta");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pIdUnico", IdUnico.ToUpper());
            cmd.Parameters.AddWithValue("@pTitulo", Titulo);
            this.IdUnico = cmd.ExecuteScalar().ToString().ToUpper(); // regresa else IdUnico Insertado
        }
        public DataTable GetDatos()
        {
            DataTable dt = new DataTable();
            SqlConnection con = Conexion.ConectarSQL();
            con.Open();
            SqlCommand cmd = new SqlCommand("spGetEncuesta", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd); // se ejecuta el stored procedure y se traen los datos.
            da.Fill(dt);
            return dt; // Regresamos el DataTable
        }

        #endregion

        #region procedimientos para el tratamiento de componentes
        public void llenar()
        {
            DataSet ds = new DataSet();



        }
        #endregion




    }
}
