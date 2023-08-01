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
    internal class HorarioControl
    {

        public bool Crear_Horario(HorariosModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexionN())
                {
                    Con.Open();
                    string sql = "Insert Into HORARIOS(ID_HORARIO,DESCRIPCION_HORARIO,TIPO_TURNO,HORA_ENTRADA,HORA_SALIDA,HORAS_SEMANALES,ESTATUS, FECHAINICIO) select" +
                                " '" + Modelo.ID_HORARIO + "', '" + Modelo.DESCRIPCION_HORARIO + "','" + Modelo.TIPO_TURNO + "','" + Modelo.HORA_ENTRADA + "','" + Modelo.HORA_SALIDA + "','" + Modelo.HORAS_SEMANALES + "','" + Modelo.ESTATUS + "','" + Modelo.FECHAINICIO + "'";

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


        public bool UpdateHorario(HorariosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexionN())
                {
                    Con.Open();
                    string sql = "UPDATE HORARIOS " +
                        "SET DESCRIPCION_HORARIO = '" + Modelo.DESCRIPCION_HORARIO + "'" +
                        ",TIPO_TURNO = '" + Modelo.TIPO_TURNO + "' " +
                        ",HORA_ENTRADA = '" + Modelo.HORA_ENTRADA + "'" +
                        ",HORA_SALIDA = '" + Modelo.HORA_SALIDA + "'" +
                        ",HORAS_SEMANALES = '" + Modelo.HORAS_SEMANALES + "'" +
                        ",ESTATUS = '" + Modelo.ESTATUS + "'" +
                        " WHERE ID_EMPLEADO = '" + Modelo.ID_HORARIO + "';";


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

        public void ListarHorario()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexionN();
                Con.Open();
                string sql = "Select * from HORARIOS";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HorariosModel.GetHorarios = dt;

        }

        public bool EliminarHorario(HorariosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexionN())
                {
                    Con.Open();
                    string sql = "DELETE FROM HORARIOS WHERE ID_HORARIO = '" + Modelo.ID_HORARIO + "';";


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
