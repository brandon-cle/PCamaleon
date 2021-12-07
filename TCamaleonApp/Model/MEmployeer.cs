﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TCamaleonApp.View;
using TCamaleonApp.Views;

namespace TCamaleonApp.Model
{
    class MEmployeer
    {
        public static DataTable ShowEmployeer()
        {
            DataTable DtResultado = new DataTable("MostrarEmpleado");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();

            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarEmpleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                SqlCon.Close();
            }
            return DtResultado;
        }

        public static DataTable ShowEmployeerAd()
        {
            DataTable DtResultado = new DataTable("MostrarEmpleado_Administrativo");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();

            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarEmpleado_Administrativo";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                SqlCon.Close();
            }
            return DtResultado;
        }


        public static DataTable SearchEmployeer(string info)
        {
            DataTable DtResultado = new DataTable("BuscarEmpleado");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarEmpleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@info";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = info;
                SqlCmd.Parameters.Add(ParDato);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                SqlCon.Close();
            }

            return DtResultado;

        }

        public static DataTable ShowToCmbCatWorks()
        {
            DataTable goingcmb = new DataTable("ShowMeCategories");
            SqlConnection sqlconnection = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                sqlconnection.ConnectionString = connection.cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlconnection;
                sqlCmd.CommandText = "ShowMeCategories";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCmd);
                sqlData.Fill(goingcmb);

            }
            catch (Exception ex)
            {
                goingcmb = null;
            }
            finally
            {
                sqlconnection.Close();
            }

            return goingcmb;
        }

        public static DataTable ShowToCmbCatWorks2()
        {
            DataTable goingcmb = new DataTable("ShowMeCategoriesAd");
            SqlConnection sqlconnection = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                sqlconnection.ConnectionString = connection.cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlconnection;
                sqlCmd.CommandText = "ShowMeCategoriesAd";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCmd);
                sqlData.Fill(goingcmb);

            }
            catch (Exception ex)
            {
                goingcmb = null;
            }
            finally
            {
                sqlconnection.Close();
            }

            return goingcmb;
        }


        public static DataTable ShowJob(string option)
        {
            DataTable goingcmb = new DataTable("ShowJob");
            SqlConnection sqlconnection = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                sqlconnection.ConnectionString = connection.cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlconnection;
                sqlCmd.CommandText = "ShowJob";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@category";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = option;
                sqlCmd.Parameters.Add(ParDato);

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCmd);
                sqlData.Fill(goingcmb);

            }
            catch (Exception ex)
            {
                goingcmb = null;
            }
            finally
            {
                sqlconnection.Close();
            }

            return goingcmb;
        }


        public static DataTable ShowJobID()
        {
            DataTable goingcmb = new DataTable("ShowJobID");
            SqlConnection sqlconnection = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                sqlconnection.ConnectionString = connection.cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlconnection;
                sqlCmd.CommandText = "ShowJobID";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCmd);
                sqlData.Fill(goingcmb);

            }
            catch (Exception ex)
            {
                goingcmb = null;
            }
            finally
            {
                sqlconnection.Close();
            }

            return goingcmb;
        }

        public static void InsertarEmpleado(string E_firstname, string E_secondname, string E_thirdname, string E_lastname, string E_identification, string E_numberphone, int E_IDworkstation, string E_status, string E_mail, string E_Address)
        {

            Console.WriteLine(E_firstname + " " + E_thirdname + " " + E_IDworkstation + " " + E_Address);
            SqlConnection sqlconnection = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                sqlconnection.ConnectionString = connection.cn;

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlconnection;
                sqlCmd.CommandText = "InsertarEmpleado";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                //------------------------------------------------------------------------------------
                //------------------------------------------------------------------------------------

                sqlCmd.Parameters.Add(new SqlParameter("@n1", SqlDbType.VarChar) { Value = E_firstname });
                sqlCmd.Parameters.Add(new SqlParameter("@n2", SqlDbType.VarChar) { Value = E_secondname });
                sqlCmd.Parameters.Add(new SqlParameter("@n3", SqlDbType.VarChar) { Value = E_thirdname });
                sqlCmd.Parameters.Add(new SqlParameter("@n4", SqlDbType.VarChar) { Value = E_lastname });
                sqlCmd.Parameters.Add(new SqlParameter("@IDc", SqlDbType.VarChar) { Value = E_identification });
                sqlCmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.VarChar) { Value = E_numberphone });
                sqlCmd.Parameters.Add(new SqlParameter("@IDw", SqlDbType.Int) { Value = E_IDworkstation });
                sqlCmd.Parameters.Add(new SqlParameter("@sts", SqlDbType.VarChar) { Value = E_status });
                sqlCmd.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar) { Value = E_mail });
                sqlCmd.Parameters.Add(new SqlParameter("@adrs", SqlDbType.VarChar) { Value = E_Address });

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


        public static void ActualizarEmpleado(int E_IDEmpleado, string E_firstname, string E_secondname, string E_thirdname, string E_lastname, string E_identification, string E_numberphone, int E_IDworkstation, string E_status, string E_mail, string E_Address)
        {
            if (EmployeeSearcher.modify_complete)
            {
                Console.WriteLine(E_firstname + " " + E_thirdname + " " + E_IDworkstation + " " + E_Address);
                SqlConnection sqlconnection = new SqlConnection();
                Connection connection = new Connection();
                try
                {
                    sqlconnection.ConnectionString = connection.cn;

                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = sqlconnection;
                    sqlCmd.CommandText = "ActualizarEmpleado";
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    //------------------------------------------------------------------------------------
                    //------------------------------------------------------------------------------------
                    sqlCmd.Parameters.Add(new SqlParameter("@employeeID", SqlDbType.Int) { Value = E_IDEmpleado });
                    sqlCmd.Parameters.Add(new SqlParameter("@n1", SqlDbType.VarChar) { Value = E_firstname });
                    sqlCmd.Parameters.Add(new SqlParameter("@n2", SqlDbType.VarChar) { Value = E_secondname });
                    sqlCmd.Parameters.Add(new SqlParameter("@n3", SqlDbType.VarChar) { Value = E_thirdname });
                    sqlCmd.Parameters.Add(new SqlParameter("@n4", SqlDbType.VarChar) { Value = E_lastname });
                    sqlCmd.Parameters.Add(new SqlParameter("@IDc", SqlDbType.VarChar) { Value = E_identification });
                    sqlCmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.VarChar) { Value = E_numberphone });
                    sqlCmd.Parameters.Add(new SqlParameter("@IDw", SqlDbType.Int) { Value = E_IDworkstation });
                    sqlCmd.Parameters.Add(new SqlParameter("@sts", SqlDbType.VarChar) { Value = E_status });
                    sqlCmd.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar) { Value = E_mail });
                    sqlCmd.Parameters.Add(new SqlParameter("@adrs", SqlDbType.VarChar) { Value = E_Address });

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
            else
            {
                ActualizarEmpleado_Alter(E_IDEmpleado, E_firstname, E_secondname, E_thirdname, E_lastname, E_identification, E_numberphone, E_status, E_mail, E_Address);
            }


        }


        public static void ActualizarEmpleado_Administrativo(int E_IDEmpleado, string E_firstname, string E_secondname, string E_thirdname, string E_lastname, string E_identification, string E_numberphone, int E_IDworkstation, string E_status, string E_mail, string E_Address)
        {
            if (EmployeeSearcher.modify_complete)
            {

                SqlConnection sqlconnection = new SqlConnection();
                Connection connection = new Connection();
                try
                {
                    sqlconnection.ConnectionString = connection.cn;

                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = sqlconnection;
                    sqlCmd.CommandText = "ActualizarEmpleado_Administrativo";
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    //------------------------------------------------------------------------------------
                    //------------------------------------------------------------------------------------
                    sqlCmd.Parameters.Add(new SqlParameter("@employeeID", SqlDbType.Int) { Value = E_IDEmpleado });
                    sqlCmd.Parameters.Add(new SqlParameter("@n1", SqlDbType.VarChar) { Value = E_firstname });
                    sqlCmd.Parameters.Add(new SqlParameter("@n2", SqlDbType.VarChar) { Value = E_secondname });
                    sqlCmd.Parameters.Add(new SqlParameter("@n3", SqlDbType.VarChar) { Value = E_thirdname });
                    sqlCmd.Parameters.Add(new SqlParameter("@n4", SqlDbType.VarChar) { Value = E_lastname });
                    sqlCmd.Parameters.Add(new SqlParameter("@IDc", SqlDbType.VarChar) { Value = E_identification });
                    sqlCmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.VarChar) { Value = E_numberphone });
                    sqlCmd.Parameters.Add(new SqlParameter("@IDw", SqlDbType.Int) { Value = E_IDworkstation });
                    sqlCmd.Parameters.Add(new SqlParameter("@sts", SqlDbType.VarChar) { Value = E_status });
                    sqlCmd.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar) { Value = E_mail });
                    sqlCmd.Parameters.Add(new SqlParameter("@adrs", SqlDbType.VarChar) { Value = E_Address });

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
            else
            {
                ActualizarEmpleado_Administrativo_Alter(E_IDEmpleado, E_firstname, E_secondname, E_thirdname, E_lastname, E_identification, E_numberphone, E_status, E_mail, E_Address);
            }


        }


        public static void ActualizarEmpleado_Alter(int E_IDEmpleado, string E_firstname, string E_secondname, string E_thirdname, string E_lastname, string E_identification, string E_numberphone, string E_status, string E_mail, string E_Address)
        {
            Console.WriteLine(E_firstname + " " + E_thirdname + " " + E_Address);
            SqlConnection sqlconnection = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                sqlconnection.ConnectionString = connection.cn;

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlconnection;
                sqlCmd.CommandText = "ActualizarEmpleado_Alter";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                //------------------------------------------------------------------------------------
                //------------------------------------------------------------------------------------
                sqlCmd.Parameters.Add(new SqlParameter("@employeeID", SqlDbType.Int) { Value = E_IDEmpleado });
                sqlCmd.Parameters.Add(new SqlParameter("@n1", SqlDbType.VarChar) { Value = E_firstname });
                sqlCmd.Parameters.Add(new SqlParameter("@n2", SqlDbType.VarChar) { Value = E_secondname });
                sqlCmd.Parameters.Add(new SqlParameter("@n3", SqlDbType.VarChar) { Value = E_thirdname });
                sqlCmd.Parameters.Add(new SqlParameter("@n4", SqlDbType.VarChar) { Value = E_lastname });
                sqlCmd.Parameters.Add(new SqlParameter("@IDc", SqlDbType.VarChar) { Value = E_identification });
                sqlCmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.VarChar) { Value = E_numberphone });
                sqlCmd.Parameters.Add(new SqlParameter("@sts", SqlDbType.VarChar) { Value = E_status });
                sqlCmd.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar) { Value = E_mail });
                sqlCmd.Parameters.Add(new SqlParameter("@adrs", SqlDbType.VarChar) { Value = E_Address });

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


        public static void ActualizarEmpleado_Administrativo_Alter(int E_IDEmpleado, string E_firstname, string E_secondname, string E_thirdname, string E_lastname, string E_identification, string E_numberphone, string E_status, string E_mail, string E_Address)
        {

            SqlConnection sqlconnection = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                sqlconnection.ConnectionString = connection.cn;

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlconnection;
                sqlCmd.CommandText = "ActualizarEmpleado_Administrativo_Alter";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                //------------------------------------------------------------------------------------
                //------------------------------------------------------------------------------------
                sqlCmd.Parameters.Add(new SqlParameter("@employeeID", SqlDbType.Int) { Value = E_IDEmpleado });
                sqlCmd.Parameters.Add(new SqlParameter("@n1", SqlDbType.VarChar) { Value = E_firstname });
                sqlCmd.Parameters.Add(new SqlParameter("@n2", SqlDbType.VarChar) { Value = E_secondname });
                sqlCmd.Parameters.Add(new SqlParameter("@n3", SqlDbType.VarChar) { Value = E_thirdname });
                sqlCmd.Parameters.Add(new SqlParameter("@n4", SqlDbType.VarChar) { Value = E_lastname });
                sqlCmd.Parameters.Add(new SqlParameter("@IDc", SqlDbType.VarChar) { Value = E_identification });
                sqlCmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.VarChar) { Value = E_numberphone });
                sqlCmd.Parameters.Add(new SqlParameter("@sts", SqlDbType.VarChar) { Value = E_status });
                sqlCmd.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar) { Value = E_mail });
                sqlCmd.Parameters.Add(new SqlParameter("@adrs", SqlDbType.VarChar) { Value = E_Address });

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

        public static DataTable MostrarEmpleadoAd_noUser()
        {
            DataTable DtResultado = new DataTable("MostrarEmpleadoAd_noUser");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();

            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarEmpleadoAd_noUser";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                SqlCon.Close();
            }
            return DtResultado;
        }

        public static DataTable BuscarEmpleadoAd_noUser(string info)
        {
            DataTable DtResultado = new DataTable("BuscarEmpleadoAd_noUSer");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarEmpleadoAd_noUser";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@info";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = info;
                SqlCmd.Parameters.Add(ParDato);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                SqlCon.Close();
            }

            return DtResultado;
        }


        public static DataTable DataToShow()
        {
            DataTable DtResultado = new DataTable("Givemedata");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();

            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Givemedata";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                SqlCon.Close();
            }
            return DtResultado;
        }

        public static DataTable SearchEmployeerAd(string info)
        {
            DataTable DtResultado = new DataTable("BuscarEmpleado_Administrativp");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarEmpleado_Administrativo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@info";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = info;
                SqlCmd.Parameters.Add(ParDato);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                SqlCon.Close();
            }

            return DtResultado;

        }






        public static DataTable BuscarTécnicoA(string info)
        {
            DataTable DtResultado = new DataTable("BuscarTécnicoA");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarTécnicoA";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@info";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = info;
                SqlCmd.Parameters.Add(ParDato);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                SqlCon.Close();
            }

            return DtResultado;

        }


        public static DataTable MostrarTécnicoA()
        {
            DataTable DtResultado = new DataTable("MostrarTécnicoA");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();

            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarTécnicoA";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                SqlCon.Close();
            }
            return DtResultado;
        }

    }
}
