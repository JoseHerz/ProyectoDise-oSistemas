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
    internal class EmpleadoControl
    {
        public bool Crear_Empleado(EmpleadosModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexionN())
                {
                    Con.Open();
                    string sql = "Insert Into EMPLEADOS(ID_EMPLEADO,PRIMER_NOMBRE,SEGUNDO_NOMBRE,PRIMER_APELLIDO,SEGUNDO_APELLIDO,DNI,DIRECCION,TELEFONO,FECHA_NACIMIENTO,GENERO,FECHA_INGRESO,ID_CARGO,ID_HORARIO,ID_USUARIO,SALARIO_BASE,ID_TIPO_EMPLEADO,ID_TIPO_SALARIO,NUMERO_CUENTA,FOTO_EMPLEADO,ID_DEPARTAMENTO,ESTATUS) select" +
                                             " '" + Modelo.ID_EMPLEADO + "', '" + Modelo.PRIMER_NOMBRE + "','" + Modelo.SEGUNDO_NOMBRE + "','" + Modelo.PRIMER_APELLIDO + "','" + Modelo.SEGUNDO_APELLIDO + "','" + Modelo.DNI + "',,'" + Modelo.DIRECCION + "',,'" + Modelo.TELEFONO + "',,'" + Modelo.FECHA_NACIMIENTO + "',,'" + Modelo.GENERO + "',,'" + Modelo.FECHA_INGRESO + "',,'" + Modelo.ID_CARGO + "',,'" + Modelo.ID_HORARIO + "',,'" + Modelo.ID_USUARIO + "',,'" + Modelo.SALARIO_BASE + "',,'" + Modelo.ID_TIPO_EMPLEADO + "',,'" + Modelo.ID_TIPO_SALARIO + "',,'" + Modelo.NUMERO_CUENTA + "',,'" + Modelo.FOTO_EMPLEADO + "','" + Modelo.ID_DEPARTAMENTO + "','" + Modelo.ESTATUS + "'";

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
        

        public bool UpdateEmpleado(EmpleadosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexionN())
                {
                    Con.Open();
                    string sql = "UPDATE EMPLEADOS " +
                        "SET PRIMER_NOMBRE = '" + Modelo.PRIMER_NOMBRE + "'" +
                        ",SEGUNDO_NOMBRE = '" + Modelo.SEGUNDO_NOMBRE + "' " +
                        ",PRIMER_APELLIDO = '" + Modelo.PRIMER_APELLIDO + "'" +
                        ",SEGUNDO_APELLIDO = '" + Modelo.SEGUNDO_APELLIDO + "'" +
                        ",DNI = '" + Modelo.DNI + "'" +
                        ",DIRECCION = '" + Modelo.DIRECCION + "'" +
                        ",TELEFONO = '" + Modelo.TELEFONO + "'" +
                        ",FECHA_NACIMIENTO = '" + Modelo.FECHA_NACIMIENTO + "'" +
                        ",GENERO = '" + Modelo.GENERO + "'" +
                        ",FECHA_INGRESO = '" + Modelo.FECHA_INGRESO + "'" +
                        ",FECHA_SALIDA = '" + Modelo.FECHA_SALIDA + "'" +
                        ",ID_CARGO = '" + Modelo.ID_CARGO + "'" +
                        ",ID_HORARIO = '" + Modelo.ID_HORARIO + "'" +
                        ",ID_USUARIO = '" + Modelo.ID_USUARIO + "'" +
                        ",SALARIO_BASE = '" + Modelo.SALARIO_BASE + "'" +
                        ",ID_TIPO_EMPLEADO = '" + Modelo.ID_TIPO_EMPLEADO + "'" +
                        ",ID_TIPO_SALARIO = '" + Modelo.ID_TIPO_SALARIO + "'" +
                        ",NUMERO_CUENTA = '" + Modelo.NUMERO_CUENTA + "'" +
                        ",FOTO_EMPLEADO = '" + Modelo.FOTO_EMPLEADO + "'" +
                        ",ID_DEPARTAMENTO = '" + Modelo.ID_DEPARTAMENTO + "'" +
                        ",ESTATUS = '" + Modelo.ESTATUS + "'" +
                        " WHERE ID_EMPLEADO = '" + Modelo.ID_EMPLEADO + "';";


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

        public void ListarEmpleados()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexionN();
                Con.Open();
                string sql =  "SELECT E.ID_EMPLEADO," +
                              "CONCAT(E.PRIMER_NOMBRE, ' ', E.PRIMER_APELLIDO) AS NOMBRE," +
                              "E.DNI," +
                              "E.DIRECCION," +
                              "E.TELEFONO," +
                              "E.FECHA_NACIMIENTO," +
                              "E.GENERO," +
                              "E.FECHA_INGRESO,"+
                              "E.FECHA_SALIDA,"+
                              "C.DESCRIPCION_CARGO, --Nombre del cargo desde la tabla Tbl_Cargos"+
                              "H.DESCRIPCION AS HORARIO, --TABLA HORARIOS"+
                              "U.USUARIOS_USER AS USUARIO,"+
                              "E.SALARIO_BASE,"+
                              "T.DESCRIPCION_TIPOEMPLEADO AS TIPO_DE_EMPLEADO, --TABLA TIPO EMPLEADO"+
                              "TT.DESCRIPCION_TIPO_SALARIO AS PLANILLA, --TABLA TIPO SALARIO"+
                              "E.NUMERO_CUENTA,"+
                              "E.FOTO_EMPLEADO,"+
                              "D.DESCRIPCION_DEPARTAMENTO AS DEPARTAMENTO, --TABLA DEPARTAMENTO"+
                              "E.ESTATUS"+
                              "FROM"+
                              "EMPLEADOS E"+
                              "INNER JOIN CARGO C ON E.ID_CARGO = C.ID_CARGO"+
                              "INNER JOIN DEPARTAMENTO D ON E.ID_DEPARTAMENTO = D.ID_DEPARTAMENTO"+
                              "INNER JOIN HORARIOS H ON E.ID_HORARIO = H.ID_HORARIO"+
                              "INNER JOIN TIPO_EMPLEADO T ON E.ID_TIPO_EMPLEADO = T.ID_TIPO_EMPLEADO"+
                              "INNER JOIN TIPO_SALARIO TT ON E.ID_TIPO_SALARIO = TT.ID_TIPO_SALARIO"+
                              "INNER JOIN USUARIOS U ON E.ID_USUARIO = U.ID_USUARIO;";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            EmpleadosModel.GetEmpleado = dt;

        }

        public bool EliminarEmpleado (EmpleadosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexionN())
                {
                    Con.Open();
                    string sql = "DELETE FROM EMPLEADOS WHERE ID_EMPLEADO = '" + Modelo.ID_EMPLEADO + "';";


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

        public DataTable AlimentarCmbTurno()
        {
            SqlConnection Con = new Conexion().GetConexionW();
            Con.Open();
            string sql = "ALIMENTARCMBTURNO";
            SqlDataAdapter dat = new SqlDataAdapter(sql, Con);
            dat.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dat.Fill(dt);
            return dt;
        }

    }
}
