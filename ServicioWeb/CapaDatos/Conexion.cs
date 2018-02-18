using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CapaDatos
{
    class Conexion
    {
        public static SqlConnection ConectarSQL()
        {
            return (new SqlConnection(@"Data Source=(local);Initial Catalog=DBECOSUR;Integrated Security=False;User Id=sa; Password='Entrar123';"));
        }

    }
}
