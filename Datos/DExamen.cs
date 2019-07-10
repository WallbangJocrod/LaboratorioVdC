﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DExamen : Conexion
    {
        private int _ID;
        private string _Nombre;
        private string _Unidades;
        private double _Valor_Hombre;
        private double _Valor_Mujer;
        private double _Precio1;
        private double _Precio2;
        private string _Plazo_Entrega;
        private string _Observacion;
        private int _ID_Grupo_Examen;
        private int _Titulo;
        private int _Lab_Referencia;
        private int _Precio_Referencia;

        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Unidades { get => _Unidades; set => _Unidades = value; }
        public double Valor_Hombre { get => _Valor_Hombre; set => _Valor_Hombre = value; }
        public double Valor_Mujer { get => _Valor_Mujer; set => _Valor_Mujer = value; }
        public double Precio1 { get => _Precio1; set => _Precio1 = value; }
        public double Precio2 { get => _Precio2; set => _Precio2 = value; }
        public string Plazo_Entrega { get => _Plazo_Entrega; set => _Plazo_Entrega = value; }
        public string Observacion { get => _Observacion; set => _Observacion = value; }
        public int ID_Grupo_Examen { get => _ID_Grupo_Examen; set => _ID_Grupo_Examen = value; }
        public int Titulo { get => _Titulo; set => _Titulo = value; }
        public int Lab_Referencia { get => _Lab_Referencia; set => _Lab_Referencia = value; }
        public int Precio_Referencia { get => _Precio_Referencia; set => _Precio_Referencia = value; }

        public DExamen()
        {

        }

        public DExamen(int iD, string nombre, string unidades, double valor_Hombre, double valor_Mujer, double precio1, double precio2, string plazo_entrega, string observacion, int iD_Grupo_Examen, int titulo, int lab_Referencia, int precio_Referencia)
        {
            ID = iD;
            Nombre = nombre;
            Unidades = unidades;
            Valor_Hombre = valor_Hombre;
            Valor_Mujer = valor_Mujer;
            Precio1 = precio1;
            Precio2 = precio2;
            Plazo_Entrega = plazo_entrega;
            Observacion = observacion;
            ID_Grupo_Examen = iD_Grupo_Examen;
            Titulo = titulo;
            Lab_Referencia = lab_Referencia;
            Precio_Referencia = precio_Referencia;
        }

        //Metodos

        //insertar
        public string Insertar(DExamen Examen)
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
                SqlComando.CommandText = "insertar_examen";
                SqlComando.CommandType = CommandType.StoredProcedure;

                //parametros

                //parametro id
                SqlParameter Parametro_Id_Examen = new SqlParameter();
                Parametro_Id_Examen.ParameterName = "@ID";
                Parametro_Id_Examen.SqlDbType = SqlDbType.Int;
                Parametro_Id_Examen.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(Parametro_Id_Examen);

                //parametro nombre
                SqlParameter Parametro_Nombre_Examen = new SqlParameter();
                Parametro_Nombre_Examen.ParameterName = "@nombre";
                Parametro_Nombre_Examen.SqlDbType = SqlDbType.VarChar;
                Parametro_Nombre_Examen.Size = 20;
                Parametro_Nombre_Examen.Value = Examen.Nombre;
                SqlComando.Parameters.Add(Parametro_Nombre_Examen);

                //parametro unidades
                SqlParameter Parametro_Unidad_Examen = new SqlParameter();
                Parametro_Unidad_Examen.ParameterName = "@unidades";
                Parametro_Unidad_Examen.SqlDbType = SqlDbType.VarChar;
                Parametro_Unidad_Examen.Size = 20;
                Parametro_Unidad_Examen.Value = Examen.Unidades;
                SqlComando.Parameters.Add(Parametro_Unidad_Examen);

                //parametro valor normal hombre
                SqlParameter Parametro_Valor_Hombre = new SqlParameter();
                Parametro_Valor_Hombre.ParameterName = "@valornormalhombre";
                Parametro_Valor_Hombre.SqlDbType = SqlDbType.Float;
                Parametro_Valor_Hombre.Value = Examen.Valor_Hombre;
                SqlComando.Parameters.Add(Parametro_Valor_Hombre);

                //parametro valor normal mujer
                SqlParameter Parametro_Valor_Mujer = new SqlParameter();
                Parametro_Valor_Mujer.ParameterName = "@valornormalmujer";
                Parametro_Valor_Mujer.SqlDbType = SqlDbType.Float;
                Parametro_Valor_Mujer.Value = Examen.Valor_Mujer;
                SqlComando.Parameters.Add(Parametro_Valor_Mujer);

                //parametro precio 1
                SqlParameter Parametro_Precio_1 = new SqlParameter();
                Parametro_Precio_1.ParameterName = "@precio1";
                Parametro_Precio_1.SqlDbType = SqlDbType.Float;
                Parametro_Precio_1.Value = Examen.Precio1;
                SqlComando.Parameters.Add(Parametro_Precio_1);

                //parametro precio 2
                SqlParameter Parametro_Precio_2 = new SqlParameter();
                Parametro_Precio_2.ParameterName = "@precio2";
                Parametro_Precio_2.SqlDbType = SqlDbType.Float;
                Parametro_Precio_2.Value = Examen.Precio2;
                SqlComando.Parameters.Add(Parametro_Precio_2);

                //parametro plazo de entrega
                SqlParameter Parametro_Plazo_Entrega = new SqlParameter();
                Parametro_Plazo_Entrega.ParameterName = "@plazoentrega";
                Parametro_Plazo_Entrega.SqlDbType = SqlDbType.VarChar;
                Parametro_Plazo_Entrega.Size = 10;
                Parametro_Plazo_Entrega.Value = Examen.Plazo_Entrega;
                SqlComando.Parameters.Add(Parametro_Plazo_Entrega);

                //parametro Observacion
                SqlParameter Parametro_Observacion = new SqlParameter();
                Parametro_Observacion.ParameterName = "@observacion";
                Parametro_Observacion.SqlDbType = SqlDbType.VarChar;
                Parametro_Observacion.Size = 150;
                Parametro_Observacion.Value = Examen.Observacion;
                SqlComando.Parameters.Add(Parametro_Observacion);

                //parametro ID grupo examen
                SqlParameter Parametro_ID_Grupo_Examen = new SqlParameter();
                Parametro_ID_Grupo_Examen.ParameterName = "@IDgrupoexamen";
                Parametro_ID_Grupo_Examen.SqlDbType = SqlDbType.Int;
                Parametro_ID_Grupo_Examen.Value = Examen.ID_Grupo_Examen;
                SqlComando.Parameters.Add(Parametro_ID_Grupo_Examen);

                //parametro titulo
                SqlParameter Parametro_Titulo = new SqlParameter();
                Parametro_Titulo.ParameterName = "@titulo";
                Parametro_Titulo.SqlDbType = SqlDbType.Int;
                Parametro_Titulo.Value = Examen.Titulo;
                SqlComando.Parameters.Add(Parametro_Titulo);

                //parametro lab referencia
                SqlParameter Parametro_Lab_Referencia = new SqlParameter();
                Parametro_Lab_Referencia.ParameterName = "@lab_referencia";
                Parametro_Lab_Referencia.SqlDbType = SqlDbType.Int;
                Parametro_Lab_Referencia.Value = Examen.Lab_Referencia;
                SqlComando.Parameters.Add(Parametro_Lab_Referencia);

                //parametro precio referencia
                SqlParameter Parametro_Precio_Referencia = new SqlParameter();
                Parametro_Precio_Referencia.ParameterName = "@precio_referencia";
                Parametro_Precio_Referencia.SqlDbType = SqlDbType.Int;
                Parametro_Precio_Referencia.Value = Examen.Precio_Referencia;
                SqlComando.Parameters.Add(Parametro_Precio_Referencia);

                //ejecuta y lo envia en comentario
                respuesta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Registro del Examen";

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
        public string Editar(DExamen Examen)
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
                SqlComando.CommandText = "editar_examen";
                SqlComando.CommandType = CommandType.StoredProcedure;

                //parametros

                //parametro id
                SqlParameter Parametro_Id_Examen = new SqlParameter();
                Parametro_Id_Examen.ParameterName = "@ID";
                Parametro_Id_Examen.SqlDbType = SqlDbType.Int;
                Parametro_Id_Examen.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(Parametro_Id_Examen);

                //parametro nombre
                SqlParameter Parametro_Nombre_Examen = new SqlParameter();
                Parametro_Nombre_Examen.ParameterName = "@nombre";
                Parametro_Nombre_Examen.SqlDbType = SqlDbType.VarChar;
                Parametro_Nombre_Examen.Size = 20;
                Parametro_Nombre_Examen.Value = Examen.Nombre;
                SqlComando.Parameters.Add(Parametro_Nombre_Examen);

                //parametro unidades
                SqlParameter Parametro_Unidad_Examen = new SqlParameter();
                Parametro_Unidad_Examen.ParameterName = "@unidades";
                Parametro_Unidad_Examen.SqlDbType = SqlDbType.VarChar;
                Parametro_Unidad_Examen.Size = 20;
                Parametro_Unidad_Examen.Value = Examen.Unidades;
                SqlComando.Parameters.Add(Parametro_Unidad_Examen);

                //parametro valor normal hombre
                SqlParameter Parametro_Valor_Hombre = new SqlParameter();
                Parametro_Valor_Hombre.ParameterName = "@valornormalhombre";
                Parametro_Valor_Hombre.SqlDbType = SqlDbType.Float;
                Parametro_Valor_Hombre.Value = Examen.Valor_Hombre;
                SqlComando.Parameters.Add(Parametro_Valor_Hombre);

                //parametro valor normal mujer
                SqlParameter Parametro_Valor_Mujer = new SqlParameter();
                Parametro_Valor_Mujer.ParameterName = "@valornormalmujer";
                Parametro_Valor_Mujer.SqlDbType = SqlDbType.Float;
                Parametro_Valor_Mujer.Value = Examen.Valor_Mujer;
                SqlComando.Parameters.Add(Parametro_Valor_Mujer);

                //parametro precio 1
                SqlParameter Parametro_Precio_1 = new SqlParameter();
                Parametro_Precio_1.ParameterName = "@precio1";
                Parametro_Precio_1.SqlDbType = SqlDbType.Float;
                Parametro_Precio_1.Value = Examen.Precio1;
                SqlComando.Parameters.Add(Parametro_Precio_1);

                //parametro precio 2
                SqlParameter Parametro_Precio_2 = new SqlParameter();
                Parametro_Precio_2.ParameterName = "@precio2";
                Parametro_Precio_2.SqlDbType = SqlDbType.Float;
                Parametro_Precio_2.Value = Examen.Precio2;
                SqlComando.Parameters.Add(Parametro_Precio_2);

                //parametro plazo de entrega
                SqlParameter Parametro_Plazo_Entrega = new SqlParameter();
                Parametro_Plazo_Entrega.ParameterName = "@plazoentrega";
                Parametro_Plazo_Entrega.SqlDbType = SqlDbType.VarChar;
                Parametro_Plazo_Entrega.Size = 10;
                Parametro_Plazo_Entrega.Value = Examen.Plazo_Entrega;
                SqlComando.Parameters.Add(Parametro_Plazo_Entrega);

                //parametro Observacion
                SqlParameter Parametro_Observacion = new SqlParameter();
                Parametro_Observacion.ParameterName = "@observacion";
                Parametro_Observacion.SqlDbType = SqlDbType.VarChar;
                Parametro_Observacion.Size = 150;
                Parametro_Observacion.Value = Examen.Observacion;
                SqlComando.Parameters.Add(Parametro_Observacion);

                //parametro ID grupo examen
                SqlParameter Parametro_ID_Grupo_Examen = new SqlParameter();
                Parametro_ID_Grupo_Examen.ParameterName = "@IDgrupoexamen";
                Parametro_ID_Grupo_Examen.SqlDbType = SqlDbType.Int;
                Parametro_ID_Grupo_Examen.Value = Examen.ID_Grupo_Examen;
                SqlComando.Parameters.Add(Parametro_ID_Grupo_Examen);

                //parametro titulo
                SqlParameter Parametro_Titulo = new SqlParameter();
                Parametro_Titulo.ParameterName = "@titulo";
                Parametro_Titulo.SqlDbType = SqlDbType.Int;
                Parametro_Titulo.Value = Examen.Titulo;
                SqlComando.Parameters.Add(Parametro_Titulo);

                //parametro lab referencia
                SqlParameter Parametro_Lab_Referencia = new SqlParameter();
                Parametro_Lab_Referencia.ParameterName = "@lab_referencia";
                Parametro_Lab_Referencia.SqlDbType = SqlDbType.Int;
                Parametro_Lab_Referencia.Value = Examen.Lab_Referencia;
                SqlComando.Parameters.Add(Parametro_Lab_Referencia);

                //parametro precio referencia
                SqlParameter Parametro_Precio_Referencia = new SqlParameter();
                Parametro_Precio_Referencia.ParameterName = "@precio_referencia";
                Parametro_Precio_Referencia.SqlDbType = SqlDbType.Int;
                Parametro_Precio_Referencia.Value = Examen.Precio_Referencia;
                SqlComando.Parameters.Add(Parametro_Precio_Referencia);

                //ejecuta y lo envia en comentario
                respuesta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se edito el Registro del Examen";

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
        public string Eliminar(DExamen Examen)
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
                SqlComando.CommandText = "eliminar_examen";
                SqlComando.CommandType = CommandType.StoredProcedure;

                //parametros

                //parametro id
                SqlParameter Parametro_Id_Examen = new SqlParameter();
                Parametro_Id_Examen.ParameterName = "@ID";
                Parametro_Id_Examen.SqlDbType = SqlDbType.Int;
                Parametro_Id_Examen.Value = Examen.ID;
                SqlComando.Parameters.Add(Parametro_Id_Examen);

                //ejecuta y lo envia en comentario
                respuesta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el Registro del examen";

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
        public List<DExamen> Mostrar(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("Examen");
            SqlConnection SqlConectar = new SqlConnection();
            List<DExamen> ListaGenerica = new List<DExamen>();

            try
            {
                SqlConectar.ConnectionString = Conexion.CadenaConexion;
                SqlDataReader LeerFilas;
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConectar;
                SqlComando.CommandText = "mostrar_examen";
                SqlComando.CommandType = CommandType.StoredProcedure;
                //esto es cuando tiene alguna condicion
                SqlComando.Parameters.AddWithValue("@TextoBuscar", TextoBuscar);

                SqlConectar.Open();

                LeerFilas = SqlComando.ExecuteReader();

                while (LeerFilas.Read())
                {
                    ListaGenerica.Add(new DExamen
                    {
                        ID = LeerFilas.GetInt32(0),
                        Nombre = LeerFilas.GetString(1),
                        Unidades = LeerFilas.GetString(2),
                        Valor_Hombre = LeerFilas.GetFloat(3),
                        Valor_Mujer = LeerFilas.GetFloat(4),
                        Precio1 = LeerFilas.GetFloat(5),
                        Precio2 = LeerFilas.GetFloat(6),
                        Plazo_Entrega = LeerFilas.GetString(7),
                        Observacion = LeerFilas.GetString(8),
                        ID_Grupo_Examen = LeerFilas.GetInt32(9),
                        Titulo = LeerFilas.GetInt32(10),
                        Lab_Referencia = LeerFilas.GetInt32(11),
                        Precio_Referencia = LeerFilas.GetInt32(12),
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