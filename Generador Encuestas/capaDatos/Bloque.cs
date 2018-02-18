using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace capaDatos
{
    public class Bloque
    {
        #region campos de la tabla
            string Id_Unico { get; set; }
            string Id_Encuesta {get; set;}
            string Texto {get; set;}
            
        #endregion

        #region procedimientos y funciones de la tabla

        public void ActualizarNuevo(string strId_Unico, string strId_Encuesta, string strTexto)
        {
            SqlConnection con = Conexion.ConectarSQL();
            SqlCommand cmd = new SqlCommand("spBloque");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pIdUnico",    strId_Unico.ToUpper());
            cmd.Parameters.AddWithValue("@pIdEncuesta", strId_Encuesta.ToUpper());
            cmd.Parameters.AddWithValue("@PTexto",      strTexto);
            this.Id_Unico = cmd.ExecuteScalar().ToString().ToUpper(); // regresa else IdUnico Insertado
        }
        public DataTable GetDatos()
        {
            DataTable dt = new DataTable();
            SqlConnection con = Conexion.ConectarSQL();
            con.Open();
            SqlCommand cmd = new SqlCommand("spGetBloque", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd); // se ejecuta el stored procedure y se traen los datos.
            da.Fill(dt);
            return dt; // Regresamos el DataTable
        }

        

        #endregion



    }
}
