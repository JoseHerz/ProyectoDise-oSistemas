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
    internal class UsuarioControl
    {

        public bool Crear_Usuario(UsuarioModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexionN())
                {
                    Con.Open();
                    string sql = "Insert Into USUARIOS(ID_USUARIO,USUARIO_USER,USUARIO_PASSWORD,ID_ROL_USUARIO,ESTATUS) select" +
                                " '" + Modelo.ID_USUARIO + "', '" + Modelo.USUARIO_USER + "','" + Modelo.USUARIO_PASSWORD + "','" + Modelo.ID_ROL_USUARIO + "','" + Modelo.ESTATUS + "'";

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


        public bool UpdateUsuario(UsuarioModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexionN())
                {
                    Con.Open();
                    string sql = "UPDATE USUARIOS " +
                        "SET USUARIO_USER = '" + Modelo.USUARIO_USER + "'" +
                        ",USUARIO_PASSWORD = '" + Modelo.USUARIO_PASSWORD + "' " +
                        ",ID_ROL_USUARIO = '" + Modelo.ID_ROL_USUARIO + "'" +
                        ",ESTATUS = '" + Modelo.ESTATUS + "'" +
                        " WHERE ID_EMPLEADO = '" + Modelo.ID_USUARIO + "';";


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

        public void ListarUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexionN();
                Con.Open();
                string sql = "Select * from USUARIOS";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UsuarioModel.GetUsuarios = dt;

        }

        public bool EliminarUsuario(UsuarioModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexionN())
                {
                    Con.Open();
                    string sql = "DELETE FROM USUARIOS WHERE ID_USUARIO = '" + Modelo.ID_USUARIO + "';";


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
