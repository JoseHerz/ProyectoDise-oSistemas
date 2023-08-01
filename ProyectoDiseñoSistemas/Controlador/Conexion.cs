    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProyectoDiseñoSistemas.Controlador
{
    internal class Conexion
    {
        public SqlConnection GetConexionW()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DBPROYECTO1"].ToString());
        }

        public SqlConnection GetConexionN()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DBPROYECTO"].ToString());
        }

    }
}
