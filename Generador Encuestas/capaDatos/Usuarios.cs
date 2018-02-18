
using System.Data.SqlClient;

namespace capaDatos
{
    public class Usuarios
    {
        #region Campos de la tabla
        public string IdUnico   { get; set; }
        public string Nombre    { get; set; }
        public string Usee      { get; set; }
        public string Pass      { get; set; }
        #endregion


        public void usrLogin(string Username, string Clave)
        {
            SqlConnection con =  Conexion.ConectarSQL();
            SqlCommand cmd = new SqlCommand("spLogin", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pUsee", Username);
            cmd.Parameters.AddWithValue("@pPass", Clave);
            this.IdUnico = cmd.ExecuteScalar().ToString().ToUpper(); // se usa ExecuteScaar cuando se regresan datos.   
        }

        public void usrActualizarNuevo(string IdUnico, string Nombre, string Usee, string Pass)
        {
            SqlConnection   con = Conexion.ConectarSQL();
            SqlCommand cmd = new SqlCommand("spUsuario");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();

            cmd.Parameters.AddWithValue("@pIdUnico", IdUnico.ToUpper());
            cmd.Parameters.AddWithValue("@pNombre", Nombre);
            cmd.Parameters.AddWithValue("@pUsee", Usee);
            cmd.Parameters.AddWithValue("@pPass", Pass);
            this.IdUnico = cmd.ExecuteScalar().ToString().ToUpper(); // regresa else IdUnico Insertado

         

        }

    }

}
