﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    class DTrabajador
    {
        private string _Cedula;
        private string _Nombre;
        private string _Contraseña;
        private string _Direccion;
        private string _Telefono;
        private string _Correo;
        private int _Acceso;
        private string _TextoBuscar;

        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public int Acceso { get => _Acceso; set => _Acceso = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public DTrabajador()
        {

        }

        public DTrabajador(string Cedula, string Nombre, string Contraseña, string Direccion, string Telefono, string Correo, int Acceso, string TextoBuscar)
        {
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Contraseña = Contraseña;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Correo = Correo;
            this.Acceso = Acceso;
            this.TextoBuscar = TextoBuscar;
        }

        //Metodos

        //insertar
        public string Insertar(DTrabajador Trabajador)
        {
            string respuesta = "";
            SqlConnection SqlConectar = new SqlConnection();

            try
            {
                //conexion con la Base de Datos
                SqlConectar.ConnectionString = Conexion.CadenaConexion;
                SqlConectar.Open();

                //comandos
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConectar;
                SqlComando.CommandText = "Insertar_Trabajador";
                SqlComando.CommandType = CommandType.StoredProcedure;

                //parametros

                //parametro cedula
                SqlParameter Parametro_Id_Trabajador = new SqlParameter();
                Parametro_Id_Trabajador.ParameterName = "@Cedula";
                Parametro_Id_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Id_Trabajador.Size = 10;
                Parametro_Id_Trabajador.Value=Trabajador.Cedula;
                SqlComando.Parameters.Add(Parametro_Id_Trabajador);

                //parametro nombre
                SqlParameter Parametro_Nombre_Trabajador = new SqlParameter();
                Parametro_Nombre_Trabajador.ParameterName = "@Nombre";
                Parametro_Nombre_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Nombre_Trabajador.Size = 50;
                Parametro_Nombre_Trabajador.Value = Trabajador.Nombre;
                SqlComando.Parameters.Add(Parametro_Nombre_Trabajador);

                //parametro contraseña
                SqlParameter Parametro_Contraseña_Trabajador = new SqlParameter();
                Parametro_Contraseña_Trabajador.ParameterName = "@Password";
                Parametro_Contraseña_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Contraseña_Trabajador.Size = 30;
                Parametro_Contraseña_Trabajador.Value = Trabajador.Contraseña;
                SqlComando.Parameters.Add(Parametro_Contraseña_Trabajador);

                //parametro direccion
                SqlParameter Parametro_Direccion_Trabajador = new SqlParameter();
                Parametro_Direccion_Trabajador.ParameterName = "@Direccion";
                Parametro_Direccion_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Direccion_Trabajador.Size = 50;
                Parametro_Direccion_Trabajador.Value = Trabajador.Direccion;
                SqlComando.Parameters.Add(Parametro_Direccion_Trabajador);

                //parametro telefono
                SqlParameter Parametro_Telefono_Trabajador = new SqlParameter();
                Parametro_Telefono_Trabajador.ParameterName = "@Telefono";
                Parametro_Telefono_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Telefono_Trabajador.Size = 13;
                Parametro_Telefono_Trabajador.Value = Trabajador.Telefono;
                SqlComando.Parameters.Add(Parametro_Telefono_Trabajador);

                //parametro correo
                SqlParameter Parametro_Correo_Trabajador = new SqlParameter();
                Parametro_Correo_Trabajador.ParameterName = "@Correo";
                Parametro_Correo_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Correo_Trabajador.Size = 60;
                Parametro_Correo_Trabajador.Value = Trabajador.Correo;
                SqlComando.Parameters.Add(Parametro_Correo_Trabajador);

                //parametro acceso
                SqlParameter Parametro_Acceso_Trabajador = new SqlParameter();
                Parametro_Acceso_Trabajador.ParameterName = "@Acceso";
                Parametro_Acceso_Trabajador.SqlDbType = SqlDbType.Int;
                Parametro_Acceso_Trabajador.Value = Trabajador.Acceso;
                SqlComando.Parameters.Add(Parametro_Acceso_Trabajador);

                //ejecuta y lo envia en comentario
                respuesta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Registro del Trabajador";

            }
            catch (Exception excepcion)
            {
                respuesta = excepcion.Message;
            }

            //se cierra la conexion de la Base de Datos
            finally
            {
                if (SqlConectar.State == ConnectionState.Open)
                {
                    SqlConectar.Close();
                }
            }
            return respuesta;

        }

        //editar
        public string Editar(DTrabajador Trabajador)
        {
            string respuesta = "";
            SqlConnection SqlConectar = new SqlConnection();

            try
            {
                //conexion con la Base de Datos
                SqlConectar.ConnectionString = Conexion.CadenaConexion;
                SqlConectar.Open();

                //comandos
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConectar;
                SqlComando.CommandText = "Editar_Trabajador";
                SqlComando.CommandType = CommandType.StoredProcedure;

                //parametros

                //parametro cedula
                SqlParameter Parametro_Id_Trabajador = new SqlParameter();
                Parametro_Id_Trabajador.ParameterName = "@Cedula";
                Parametro_Id_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Id_Trabajador.Size = 10;
                Parametro_Id_Trabajador.Value = Trabajador.Cedula;
                SqlComando.Parameters.Add(Parametro_Id_Trabajador);

                //parametro nombre
                SqlParameter Parametro_Nombre_Trabajador = new SqlParameter();
                Parametro_Nombre_Trabajador.ParameterName = "@Nombre";
                Parametro_Nombre_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Nombre_Trabajador.Size = 50;
                Parametro_Nombre_Trabajador.Value = Trabajador.Nombre;
                SqlComando.Parameters.Add(Parametro_Nombre_Trabajador);

                //parametro contraseña
                SqlParameter Parametro_Contraseña_Trabajador = new SqlParameter();
                Parametro_Contraseña_Trabajador.ParameterName = "@Password";
                Parametro_Contraseña_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Contraseña_Trabajador.Size = 30;
                Parametro_Contraseña_Trabajador.Value = Trabajador.Contraseña;
                SqlComando.Parameters.Add(Parametro_Contraseña_Trabajador);

                //parametro direccion
                SqlParameter Parametro_Direccion_Trabajador = new SqlParameter();
                Parametro_Direccion_Trabajador.ParameterName = "@Direccion";
                Parametro_Direccion_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Direccion_Trabajador.Size = 50;
                Parametro_Direccion_Trabajador.Value = Trabajador.Direccion;
                SqlComando.Parameters.Add(Parametro_Direccion_Trabajador);

                //parametro telefono
                SqlParameter Parametro_Telefono_Trabajador = new SqlParameter();
                Parametro_Telefono_Trabajador.ParameterName = "@Telefono";
                Parametro_Telefono_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Telefono_Trabajador.Size = 13;
                Parametro_Telefono_Trabajador.Value = Trabajador.Telefono;
                SqlComando.Parameters.Add(Parametro_Telefono_Trabajador);

                //parametro correo
                SqlParameter Parametro_Correo_Trabajador = new SqlParameter();
                Parametro_Correo_Trabajador.ParameterName = "@Correo";
                Parametro_Correo_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Correo_Trabajador.Size = 60;
                Parametro_Correo_Trabajador.Value = Trabajador.Correo;
                SqlComando.Parameters.Add(Parametro_Correo_Trabajador);

                //parametro acceso
                SqlParameter Parametro_Acceso_Trabajador = new SqlParameter();
                Parametro_Acceso_Trabajador.ParameterName = "@Acceso";
                Parametro_Acceso_Trabajador.SqlDbType = SqlDbType.Int;
                Parametro_Acceso_Trabajador.Value = Trabajador.Acceso;
                SqlComando.Parameters.Add(Parametro_Acceso_Trabajador);

                //ejecuta y lo envia en comentario
                respuesta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se edito el registro del paciente";

            }
            catch (Exception excepcion)
            {
                respuesta = excepcion.Message;
            }

            //se cierra la conexion de la Base de Datos
            finally
            {
                if (SqlConectar.State == ConnectionState.Open)
                {
                    SqlConectar.Close();
                }
            }
            return respuesta;
        }



        //Eliminar
        public string Eliminar(DTrabajador Trabajador)
        {
            string respuesta = "";
            SqlConnection SqlConectar = new SqlConnection();

            try
            {
                //conexion con la Base de Datos
                SqlConectar.ConnectionString = Conexion.CadenaConexion;
                SqlConectar.Open();

                //comandos
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConectar;
                SqlComando.CommandText = "Eliminar_Trabajador";
                SqlComando.CommandType = CommandType.StoredProcedure;

                //parametros

                //parametro id
                SqlParameter Parametro_Id_Trabajador = new SqlParameter();
                Parametro_Id_Trabajador.ParameterName = "@Cedula";
                Parametro_Id_Trabajador.SqlDbType = SqlDbType.VarChar;
                Parametro_Id_Trabajador.Size = 10;
                Parametro_Id_Trabajador.Value = Trabajador.Cedula;
                SqlComando.Parameters.Add(Parametro_Id_Trabajador);

                //ejecuta y lo envia en comentario
                respuesta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el Registro del trabajador";

            }
            catch (Exception excepcion)
            {
                respuesta = excepcion.Message;
            }

            //se cierra la conexion de la Base de Datos
            finally
            {
                if (SqlConectar.State == ConnectionState.Open)
                {
                    SqlConectar.Close();
                }
            }
            return respuesta;

        }

        //Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Trabajador");
            SqlConnection SqlConectar = new SqlConnection();

            try
            {
                SqlConectar.ConnectionString = Conexion.CadenaConexion;
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConectar;
                SqlComando.CommandText = "Mostrar_Trabajador";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlData = new SqlDataAdapter(SqlComando);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        //Buscar
        public DataTable Buscar_Cedula(DTrabajador Trabajador)
        {
            DataTable DtResultado = new DataTable("Trabajador");
            SqlConnection SqlConectar = new SqlConnection();

            try
            {
                SqlConectar.ConnectionString = Conexion.CadenaConexion;
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConectar;
                SqlComando.CommandText = "Buscar_Trabajador_Cedula";
                SqlComando.CommandType = CommandType.StoredProcedure;

                //parametro buscar cedula
                SqlParameter Parametro_Texto_Buscar = new SqlParameter();
                Parametro_Texto_Buscar.ParameterName = "@TextoBuscar";
                Parametro_Texto_Buscar.SqlDbType = SqlDbType.VarChar;
                Parametro_Texto_Buscar.Size = 50;
                Parametro_Texto_Buscar.Value = Trabajador.TextoBuscar;
                SqlComando.Parameters.Add(Parametro_Texto_Buscar);

                SqlDataAdapter SqlData = new SqlDataAdapter(SqlComando);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}