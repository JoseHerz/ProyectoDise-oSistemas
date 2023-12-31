﻿using ProyectoDiseñoSistemas.Modelo;
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
                    string sql = "Insert Into ASISTENCIA(ID_EMPLEADO,MARCAJE_HORA,MARCAJE_FECHA,ESTATUS) select" +
                                " '" + Modelo.ID_EMPLEADO + "','" + Modelo.MARCAJE_HORA + "','" + Modelo.MARCAJE_FECHA + "','" + Modelo.ESTATUS + "'";

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
                        ",MARCAJE_FECHA = '" + Modelo.MARCAJE_FECHA + "' " +
                        ",MARCAJE_HORA = '" + Modelo.MARCAJE_HORA + "'" +
                       
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
                string sql = "SELECT A.ID_ASISTENCIA AS ID,CONCAT(E.PRIMER_NOMBRE, ' ', E.PRIMER_APELLIDO) AS NOMBRE,A.MARCAJE_FECHA AS Fecha,A.MARCAJE_HORA AS Hora,A.ESTATUS FROM EMPLEADOS E INNER JOIN ASISTENCIA A ON E.ID_EMPLEADO = A.ID_EMPLEADO WHERE CONVERT(DATE, A.MARCAJE_FECHA) = CONVERT(DATE, GETDATE()) ORDER BY A.MARCAJE_HORA DESC;";
                
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
                    string sql = "DELETE FROM ASISTENCIA WHERE ID_ASISTENCIA = '" + Modelo.ID_ASISTENCIA + "';";


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



        public string empleadoget(int id)
        {

            string nombreEmpleado = null;

            try
            {
                SqlConnection Con = new Conexion().GetConexionN();
                Con.Open();
                string sql = " Select CONCAT(E.PRIMER_NOMBRE, ' ', E.PRIMER_APELLIDO) AS NOMBRE_EMPLEADO FROM EMPLEADOS E WHERE ID_EMPLEADO = @id";

                SqlCommand command = new SqlCommand(sql, Con);
                command.Parameters.AddWithValue("@id", id);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nombreEmpleado = reader["NOMBRE_EMPLEADO"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return nombreEmpleado;
        }



    }
}
