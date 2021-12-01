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

            }catch (Exception ex)
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

        public static DataTable InsertarEmpleado(string E_firstname, string E_secondname, string E_thirdname, string E_lastname, string E_identification, string E_numberphone, int E_IDworkstation, string E_status, string E_mail, string E_Address)
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

                SqlParameter E_firstnamep = new SqlParameter();
                E_firstnamep.ParameterName = "@E_firstname";
                E_firstnamep.SqlDbType = SqlDbType.VarChar;
                E_firstnamep.Size = 60;
                E_firstnamep.Value = E_firstname;
                sqlCmd.Parameters.Add(E_firstnamep);

                SqlParameter E_secondnamep = new SqlParameter();
                E_secondnamep.ParameterName = "@E_secondname";
                E_secondnamep.SqlDbType = SqlDbType.VarChar;
                E_secondnamep.Size = 60;
                E_secondnamep.Value = E_secondname;
                sqlCmd.Parameters.Add(E_secondnamep);

                SqlParameter E_thirdnamep = new SqlParameter();
                E_thirdnamep.ParameterName = "@E_thirdname";
                E_thirdnamep.SqlDbType = SqlDbType.VarChar;
                E_thirdnamep.Size = 60;
                E_thirdnamep.Value = E_thirdname;
                sqlCmd.Parameters.Add(E_thirdnamep);

                SqlParameter E_lastnamep = new SqlParameter();
                E_thirdnamep.ParameterName = "@E_lastname";
                E_thirdnamep.SqlDbType = SqlDbType.VarChar;
                E_thirdnamep.Size = 60;
                E_thirdnamep.Value = E_lastname;
                sqlCmd.Parameters.Add(E_lastnamep);

                SqlParameter E_identificationp = new SqlParameter();
                E_identificationp.ParameterName = "@E_identification";
                E_identificationp.SqlDbType = SqlDbType.VarChar;
                E_identificationp.Size = 60;
                E_identificationp.Value = E_identification;
                sqlCmd.Parameters.Add(E_identificationp);

                SqlParameter E_numberphonep = new SqlParameter();
                ParDato.ParameterName = "@E_numberphone";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = E_numberphone;
                sqlCmd.Parameters.Add(E_numberphonep);

                SqlParameter E_IDworkstationp = new SqlParameter();
                ParDato.ParameterName = "@E_IDworkstation";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = E_IDworkstation;
                sqlCmd.Parameters.Add(E_IDworkstationp);

                SqlParameter E_statusp = new SqlParameter();
                ParDato.ParameterName = "@E_status";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = E_status;
                sqlCmd.Parameters.Add(E_statusp);

                SqlParameter E_mailp = new SqlParameter();
                ParDato.ParameterName = "@E_mail";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = E_mail;
                sqlCmd.Parameters.Add(E_mailp);

                SqlParameter E_Addressp = new SqlParameter();
                ParDato.ParameterName = "@E_Address";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = E_Address;
                sqlCmd.Parameters.Add(E_Addressp);
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
    }
}
