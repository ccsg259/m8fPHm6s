using capaLogica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace capaDatos
{
    [Serializable]
    public class Pregunta
    {
        #region campos de la tabla
            string Id_Unico     {get; set;}
            string Id_Bloque    {get;set;}
            string ElementosXML {get; set;}
        #endregion

        #region procedimientos y funciones de la tabla
            public void ActualizarNuevo(string strId_Unico, string strId_Encuesta, string strTexto)
            {
                SqlConnection con = Conexion.ConectarSQL();
                SqlCommand cmd = new SqlCommand("spPregunta");
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
                SqlCommand cmd = new SqlCommand("spGetPregunta", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataAdapter da = new SqlDataAdapter(cmd); // se ejecuta el stored procedure y se traen los datos.
                //da.Fill(dt);
                return dt; // Regresamos el DataTable
            }

        #endregion



    }

   

}
