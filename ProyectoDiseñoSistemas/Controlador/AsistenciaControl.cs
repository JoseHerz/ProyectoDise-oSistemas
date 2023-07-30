using ProyectoDiseñoSistemas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiseñoSistemas.Controlador
{
    internal class AsistenciaControl
    {
        public bool Crear_Asistencia(AsistenciaModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexionN())
                {
                    Con.Open();
                    string sql = "Insert Into ASISTENCIA(ID_ASISTENCIA,ID_EMPLEADO,HORA_ENTRADA,HORA_SALIDA,ID_PERMISOS,ESTATUS) select" +
                                " '" + Modelo.ID_ASISTENCIA + "', '" + Modelo.ID_EMPLEADO + "','" + Modelo.HORA_ENTRADA + "','" + Modelo.HORA_SALIDA + "','" + Modelo.ID_PERMISOS + "','" + Modelo.ESTATUS + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        cmd.ExecuteNonQuery();
                    }

                    Con.Close();


                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }


        public bool UpdateAsistencia(AsistenciaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexionN())
                {
                    Con.Open();
                    string sql = "UPDATE ASISTENCIA " +
                        "SET ID_EMPLEADO = '" + Modelo.ID_EMPLEADO + "'" +
                        ",HORA_ENTRADA = '" + Modelo.HORA_ENTRADA + "' " +
                        ",HORA_SALIDA = '" + Modelo.HORA_SALIDA + "'" +
                        ",ID_PERMISOS = '" + Modelo.ID_PERMISOS + "'" +
                        ",ESTATUS = '" + Modelo.ESTATUS + "'" +
                        " WHERE ID_EMPLEADO = '" + Modelo.ID_ASISTENCIA + "';";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        cmd.ExecuteNonQuery();
                    }

                    Con.Close();


                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }

        public void ListarAsistencia()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexionN();
                Con.Open();
                string sql = "Select * from ASISTENCIA";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AsistenciaModel.GetAsistencia = dt;

        }

        public bool EliminarAsistencia(AsistenciaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexionN())
                {
                    Con.Open();
                    string sql = "DELETE FROM ASISTENCIA WHERE ID_HORARIO = '" + Modelo.ID_ASISTENCIA + "';";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        cmd.ExecuteNonQuery();
                    }

                    Con.Close();


                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }


    }
}
