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
    }
}
