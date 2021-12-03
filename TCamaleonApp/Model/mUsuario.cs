using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TCamaleonApp.View;

namespace TCamaleonApp.Model
{
    class mUsuario
    {
        public static DataTable ValidarAcceso(string usuario, string contraseña)
        {
            DataTable DtResultado = new DataTable("Inicio_Sesión");
            SqlConnection SqlCon = new SqlConnection();
            Connection conexión = new Connection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = conexión.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ValidarAcceso";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //   Cargando los parámetros del procedimiento almacenado
                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@usernameS";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = usuario;
                SqlCmd.Parameters.Add(ParDato);

                SqlParameter ParDato1 = new SqlParameter();
                ParDato1.ParameterName = "@userpasswordS";
                ParDato1.SqlDbType = SqlDbType.VarChar;
                ParDato1.Size = 100;
                ParDato1.Value = contraseña;
                SqlCmd.Parameters.Add(ParDato1);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static DataTable MostrarUsuarios()
        {
            DataTable DtResultado = new DataTable("MostrarUsuarios");
            SqlConnection SqlCon = new SqlConnection();
            Connection conexión = new Connection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = conexión.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarUsuarios";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //   Cargando los parámetros del procedimiento almacenado

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static void InsertarUsuario(string username, string password, string employeeID)
        {

            SqlConnection sqlconnection = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                sqlconnection.ConnectionString = connection.cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlconnection;
                sqlCmd.CommandText = "InsertarUsuario";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                //------------------------------------------------------------------------------------
                //------------------------------------------------------------------------------------

                sqlCmd.Parameters.Add(new SqlParameter("@usernameI", SqlDbType.VarChar) { Value = username });
                sqlCmd.Parameters.Add(new SqlParameter("@userpasswordI", SqlDbType.VarChar) { Value = password });
                sqlCmd.Parameters.Add(new SqlParameter("@username_IDemployeeI", SqlDbType.VarChar) { Value = employeeID });


                sqlconnection.Open();
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlconnection.Close();
            }

        }


        public static void ActualizarUsuario(string nu, string password, string status, string ID_user)
        {


            SqlConnection sqlconnection = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                sqlconnection.ConnectionString = connection.cn;

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlconnection;
                sqlCmd.CommandText = "ActualizarUsuario";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                //------------------------------------------------------------------------------------
                //------------------------------------------------------------------------------------
                if (password == "" || password == null)
                {
                    ActualizarUsuario_Alter(nu, status, ID_user);
                }
                else
                {
                    sqlCmd.Parameters.Add(new SqlParameter("@IDUser", SqlDbType.Int) { Value = ID_user });
                    sqlCmd.Parameters.Add(new SqlParameter("@un", SqlDbType.VarChar) { Value = nu });
                    sqlCmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarChar) { Value = password });
                    sqlCmd.Parameters.Add(new SqlParameter("@sts", SqlDbType.VarChar) { Value = status });
                }
                


                sqlconnection.Open();
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlconnection.Close();
            }

        }


        public static void ActualizarUsuario_Alter(string nu, string status, string ID_user)
        {


            SqlConnection sqlconnection = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                sqlconnection.ConnectionString = connection.cn;

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlconnection;
                sqlCmd.CommandText = "ActualizarUsuario_Alter";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                //------------------------------------------------------------------------------------
                //------------------------------------------------------------------------------------

                sqlCmd.Parameters.Add(new SqlParameter("@IDUser", SqlDbType.Int) { Value = ID_user });
                sqlCmd.Parameters.Add(new SqlParameter("@un", SqlDbType.VarChar) { Value = nu });
                sqlCmd.Parameters.Add(new SqlParameter("@sts", SqlDbType.VarChar) { Value = status });


                sqlconnection.Open();
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlconnection.Close();
            }
        }
    }
}

