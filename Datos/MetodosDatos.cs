using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace Datos
{
    public class MetodosDatos
    {
       

        ////*****CONEXION SQL SERVER*********/////
        public static SqlCommand CrearComando_sql()
        {
            string _cadenaConexion = Configuracion.CadenaConexion_sql;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;

        }
        public static SqlCommand CrearComandoProc_sql(string procedimiento)
        {
            string _cadenaConexion = Configuracion.CadenaConexion_sql;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand(procedimiento, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;

        }
        public static int EjecutarComandoInsert_sql(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        public static int EjecutarComandoInsert_sql_r(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return Convert.ToInt32(comando.ExecuteReader());

                //return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        public static DataTable EjecutarComandoSelect_sql(SqlCommand comando)
        {


            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
               // SqlDataReader reader = comando.ExecuteReader();
                SqlDataAdapter adaptador = new SqlDataAdapter();
               adaptador.SelectCommand = comando;
               adaptador.Fill(_tabla);
               // _tabla.Load(reader);
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;


        }

        ////*****CONEXION SQL INTERFAZ*********/////
        public static SqlCommand CrearComando_interfaz()
        {


            string _cadenaConexion = Configuracion.CadenaConexion_interfaz;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;

        }
        public static SqlCommand CrearComandoProc_interfaz(string procedimiento)
        {
            string _cadenaConexion = Configuracion.CadenaConexion_interfaz;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand(procedimiento, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;

        }
        public static int EjecutarComandoInsert_interfaz(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        public static DataTable EjecutarComandoSelect_interfaz(SqlCommand comando)
        {


            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                // SqlDataReader reader = comando.ExecuteReader();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
                // _tabla.Load(reader);
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;


        }

        ////*****CONEXION SQL SAP*********/////

        public static SqlCommand CrearComando_sap()
        {


            string _cadenaConexion = Configuracion.CadenaConexion_sap;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;

        }
        public static SqlCommand CrearComandoProc_sap(string procedimiento)
        {
            string _cadenaConexion = Configuracion.CadenaConexion_sap;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand(procedimiento, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;

        }
        public static int EjecutarComandoInsert_sap(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        public static DataTable EjecutarComandoSelect_sap(SqlCommand comando)
        {


            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                // SqlDataReader reader = comando.ExecuteReader();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
                // _tabla.Load(reader);
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;


        }


        ////*****CONEXION SQL S10*********/////
        public static SqlCommand CrearComando_s10()
        {


            string _cadenaConexion = Configuracion.CadenaConexion_s10;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;

        }
        public static SqlCommand CrearComandoProc_s10(string procedimiento)
        {
            string _cadenaConexion = Configuracion.CadenaConexion_s10;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand(procedimiento, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;

        }
        public static int EjecutarComandoInsert_s10(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        public static DataTable EjecutarComandoSelect_s10(SqlCommand comando)
        {


            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                // SqlDataReader reader = comando.ExecuteReader();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
                // _tabla.Load(reader);
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;


        }

  

        #region STARSOFT
        public static SqlCommand CrearComando_starsoft()
        {


            string _cadenaConexion = Configuracion.CadenaConexion_starsoft;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;

        }
        public static SqlCommand CrearComandoProc_starsoft(string procedimiento)
        {
            string _cadenaConexion = Configuracion.CadenaConexion_starsoft;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand(procedimiento, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;

        }
        public static int EjecutarComandoInsert_starsoft(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        public static DataTable EjecutarComandoSelect_starsoft(SqlCommand comando)
        {


            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;


        }
        #endregion

        #region PLANILLAS

        public static SqlCommand CrearComando_planilla()
        {
            string _cadenaConexion = Configuracion.CadenaConexion_planilla;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;

        }
        public static SqlCommand CrearComandoProc_planilla(string procedimiento)
        {
            string _cadenaConexion = Configuracion.CadenaConexion_planilla;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand(procedimiento, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;

        }
        public static int EjecutarComandoInsert_planilla(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        public static DataTable EjecutarComandoSelect_planilla(SqlCommand comando)
        {


            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;
        }
        #endregion


        #region CONASIST
        public static SqlCommand CrearComando_conasist()
        {
            string _cadenaConexion = Configuracion.CadenaConexion_conasist;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;

        }
        public static SqlCommand CrearComandoProc_conasist(string procedimiento)
        {
            string _cadenaConexion = Configuracion.CadenaConexion_conasist;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand(procedimiento, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;

        }
        public static int EjecutarComandoInsert_conasist(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        public static DataTable EjecutarComandoSelect_conasist(SqlCommand comando)
        {


            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                // SqlDataReader reader = comando.ExecuteReader();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
                // _tabla.Load(reader);
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;


        }

        #endregion

        #region MCOP
        public static SqlCommand CrearComando_mcop()
        {
            string _cadenaConexion = Configuracion.CadenaConexion_mcop;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;

        }
        public static SqlCommand CrearComandoProc_mcop(string procedimiento)
        {
            string _cadenaConexion = Configuracion.CadenaConexion_mcop;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand(procedimiento, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;

        }
        public static int EjecutarComandoInsert_mcop(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        public static DataTable EjecutarComandoSelect_mcop(SqlCommand comando)
        {


            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                // SqlDataReader reader = comando.ExecuteReader();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
                // _tabla.Load(reader);
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;


        }

        #endregion

        #region SCIRERH
        public static SqlCommand CrearComando_SCIRERH()
        {
            string _cadenaConexion = Configuracion.CadenaConexion_SCIRERH;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;

        }
        public static SqlCommand CrearComandoProc_SCIRERH(string procedimiento)
        {
            string _cadenaConexion = Configuracion.CadenaConexion_SCIRERH;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand(procedimiento, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;

        }
        public static int EjecutarComandoInsert_SCIRERH(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
        public static DataTable EjecutarComandoSelect_SCIRERH(SqlCommand comando)
        {


            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                // SqlDataReader reader = comando.ExecuteReader();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
                // _tabla.Load(reader);
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;


        }

        #endregion


        public static MySqlCommand CrearComando_IMERP(string procedimiento)
        {
            string _cadenaConexion = Configuracion.cadenaConexion_imerp;
            MySqlConnection _conexion = new MySqlConnection(_cadenaConexion);
            MySqlCommand _comando = new MySqlCommand(procedimiento, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }

        public static DataTable EjecutarComandoSelect_IMERP(MySqlCommand comando)
        {            
            //MySqlCommand _comando = MetodosDatos.CrearComando();
            //_comando.CommandText = "SELECT DISTINCT num_ocom  AS os FROM d_ordsrv WHERE swt_est <> 'A' AND CONCAT(RIGHT(num_ord,3), '-', SUBSTRING(num_ord,3,2)) = " + "'" + num_ord + "'" + " AND num_ped = " + "'" + num_ped + "'";
            //return MetodosDatos.EjecutarComandoSelect(_comando);
            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;
        }

        //public static MySqlCommand CrearComando()
        //{
        //    string _cadenaConexion = Configuracion.CadenaConexion_imerp;
        //    MySqlConnection _conexion = new MySqlConnection();
        //    _conexion.ConnectionString = _cadenaConexion;
        //    MySqlCommand _comando = new MySqlCommand();
        //    _comando = _conexion.CreateCommand();
        //    _comando.CommandType = CommandType.Text;
        //    return _comando;
        //}

        //public static DataTable EjecutarComandoSelect(MySqlCommand comando)
        //{
        //    DataTable _tabla = new DataTable();
        //    try
        //    {
        //        comando.Connection.Open();
        //        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        //        adaptador.SelectCommand = comando;
        //        adaptador.Fill(_tabla);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        comando.Connection.Close();
        //    }
        //    return _tabla;
        //}

    }
}
