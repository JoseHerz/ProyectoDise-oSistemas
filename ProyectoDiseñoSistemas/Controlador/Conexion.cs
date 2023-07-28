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
        public SqlConnection GetConexion()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DBPROYECTO"].ToString());
        }
    }
}
