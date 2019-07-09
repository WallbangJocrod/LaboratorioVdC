﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DBioanalista : Conexion
    {
        private int _ID;
        private string _Cedula;
        private string _Nombre;
        private string _Colegio_Bioanalista;
        private string _Colegio_Codigo;

        public int ID { get => _ID; set => _ID = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Colegio_Bioanalista { get => _Colegio_Bioanalista; set => _Colegio_Bioanalista = value; }
        public string Colegio_Codigo { get => _Colegio_Codigo; set => _Colegio_Codigo = value; }

        public DBioanalista()
        {

        }

        public DBioanalista(int iD, string cedula, string nombre, string colegio_Bioanalista, string colegio_Codigo)
        {
            ID = iD;
            Cedula = cedula;
            Nombre = nombre;
            Colegio_Bioanalista = colegio_Bioanalista;
            Colegio_Codigo = colegio_Codigo;
        }


        //Metodos

        //insertar
        public string Insertar(DBioanalista Bioanalista)
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
                SqlComando.CommandText = "insertar_bioanalista";
                SqlComando.CommandType = CommandType.StoredProcedure;

                //parametros

                //parametro id
                SqlParameter Parametro_Id_Bioanalista = new SqlParameter();
                Parametro_Id_Bioanalista.ParameterName = "@ID";
                Parametro_Id_Bioanalista.SqlDbType = SqlDbType.Int;
                Parametro_Id_Bioanalista.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(Parametro_Id_Bioanalista);

                //parametro cedula
                SqlParameter Parametro_Cedula = new SqlParameter();
                Parametro_Cedula.ParameterName = "@cedula";
                Parametro_Cedula.SqlDbType = SqlDbType.VarChar;
                Parametro_Cedula.Size = 10;
                Parametro_Cedula.Value = Bioanalista.Cedula;
                SqlComando.Parameters.Add(Parametro_Cedula);

                //parametro cedula
                SqlParameter Parametro_Nombre = new SqlParameter();
                Parametro_Nombre.ParameterName = "@nombre";
                Parametro_Nombre.SqlDbType = SqlDbType.VarChar;
                Parametro_Nombre.Size = 50;
                Parametro_Nombre.Value = Bioanalista.Nombre;
                SqlComando.Parameters.Add(Parametro_Nombre);

                //parametro colegio bioanalista
                SqlParameter Parametro_Colegio_Bioanalista = new SqlParameter();
                Parametro_Colegio_Bioanalista.ParameterName = "@colegio_bioanalista";
                Parametro_Colegio_Bioanalista.SqlDbType = SqlDbType.VarChar;
                Parametro_Colegio_Bioanalista.Size = 150;
                Parametro_Colegio_Bioanalista.Value = Bioanalista.Colegio_Bioanalista;
                SqlComando.Parameters.Add(Parametro_Colegio_Bioanalista);

                //parametro colegio bioanalista codigo
                SqlParameter Parametro_Colegio_Bioanalista_Codigo = new SqlParameter();
                Parametro_Colegio_Bioanalista_Codigo.ParameterName = "@colegio_bioanalista_codigo";
                Parametro_Colegio_Bioanalista_Codigo.SqlDbType = SqlDbType.VarChar;
                Parametro_Colegio_Bioanalista_Codigo.Size = 30;
                Parametro_Colegio_Bioanalista_Codigo.Value = Bioanalista.Colegio_Codigo;
                SqlComando.Parameters.Add(Parametro_Colegio_Bioanalista_Codigo);

                //ejecuta y lo envia en comentario
                respuesta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Registro del bioanalista";

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
        public string Editar(DBioanalista Bioanalista)
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
                SqlComando.CommandText = "editar_bioanalista";
                SqlComando.CommandType = CommandType.StoredProcedure;

                //parametros

                //parametro id
                SqlParameter Parametro_Id_Bioanalista = new SqlParameter();
                Parametro_Id_Bioanalista.ParameterName = "@ID";
                Parametro_Id_Bioanalista.SqlDbType = SqlDbType.Int;
                Parametro_Id_Bioanalista.Value = Bioanalista.ID;
                SqlComando.Parameters.Add(Parametro_Id_Bioanalista);

                //parametro cedula
                SqlParameter Parametro_Cedula = new SqlParameter();
                Parametro_Cedula.ParameterName = "@cedula";
                Parametro_Cedula.SqlDbType = SqlDbType.VarChar;
                Parametro_Cedula.Size = 10;
                Parametro_Cedula.Value = Bioanalista.Cedula;
                SqlComando.Parameters.Add(Parametro_Cedula);

                //parametro cedula
                SqlParameter Parametro_Nombre = new SqlParameter();
                Parametro_Nombre.ParameterName = "@nombre";
                Parametro_Nombre.SqlDbType = SqlDbType.VarChar;
                Parametro_Nombre.Size = 50;
                Parametro_Nombre.Value = Bioanalista.Nombre;
                SqlComando.Parameters.Add(Parametro_Nombre);

                //parametro colegio bioanalista
                SqlParameter Parametro_Colegio_Bioanalista = new SqlParameter();
                Parametro_Colegio_Bioanalista.ParameterName = "@colegio_bioanalista";
                Parametro_Colegio_Bioanalista.SqlDbType = SqlDbType.VarChar;
                Parametro_Colegio_Bioanalista.Size = 150;
                Parametro_Colegio_Bioanalista.Value = Bioanalista.Colegio_Bioanalista;
                SqlComando.Parameters.Add(Parametro_Colegio_Bioanalista);

                //parametro colegio bioanalista codigo
                SqlParameter Parametro_Colegio_Bioanalista_Codigo = new SqlParameter();
                Parametro_Colegio_Bioanalista_Codigo.ParameterName = "@colegio_bioanalista_codigo";
                Parametro_Colegio_Bioanalista_Codigo.SqlDbType = SqlDbType.VarChar;
                Parametro_Colegio_Bioanalista_Codigo.Size = 30;
                Parametro_Colegio_Bioanalista_Codigo.Value = Bioanalista.Colegio_Codigo;
                SqlComando.Parameters.Add(Parametro_Colegio_Bioanalista_Codigo);


                //ejecuta y lo envia en comentario
                respuesta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se edito el Registro del bioanalista";

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
        public string Eliminar(DBioanalista Bioanalista)
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
                SqlComando.CommandText = "eliminar_bioanalista";
                SqlComando.CommandType = CommandType.StoredProcedure;

                //parametros

                //parametro id
                SqlParameter Parametro_Id_Grupo_Examen = new SqlParameter();
                Parametro_Id_Grupo_Examen.ParameterName = "@ID";
                Parametro_Id_Grupo_Examen.SqlDbType = SqlDbType.Int;
                Parametro_Id_Grupo_Examen.Value = Bioanalista.ID;
                SqlComando.Parameters.Add(Parametro_Id_Grupo_Examen);

                //ejecuta y lo envia en comentario
                respuesta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el Registro del bioanalista";

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

        //mostrar y buscar
        public List<DBioanalista> Mostrar(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("Bioanalista");
            SqlConnection SqlConectar = new SqlConnection();
            List<DBioanalista> ListaGenerica = new List<DBioanalista>();

            try
            {
                SqlConectar.ConnectionString = Conexion.CadenaConexion;
                SqlDataReader LeerFilas;
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConectar;
                SqlComando.CommandText = "mostrar_bioanalista";
                SqlComando.CommandType = CommandType.StoredProcedure;
                //esto es cuando tiene alguna condicion
                SqlComando.Parameters.AddWithValue("@TextoBuscar", TextoBuscar);

                SqlConectar.Open();

                LeerFilas = SqlComando.ExecuteReader();

                while (LeerFilas.Read())
                {
                    ListaGenerica.Add(new DBioanalista
                    {
                        ID = LeerFilas.GetInt32(0),
                        Cedula= LeerFilas.GetString(1),
                        Nombre = LeerFilas.GetString(2),
                        Colegio_Bioanalista = LeerFilas.GetString(3),
                        Colegio_Codigo = LeerFilas.GetString(4),
                    });
                }
                LeerFilas.Close();
                SqlConectar.Close();
            }
            catch (Exception ex)
            {
                ListaGenerica = null;
            }

            return ListaGenerica;

        }

    }
}

