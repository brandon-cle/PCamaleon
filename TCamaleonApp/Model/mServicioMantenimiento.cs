using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCamaleonApp.View;

namespace TCamaleonApp.Model
{
    internal class mServicioMantenimiento
    {
        private int idMantenimiento;
        private int idServicio;
        private int idEmpleado;
        private float costo;
        public int IdMantenimiento { get => idMantenimiento; set => idMantenimiento = value; }
        public int IdServicio { get => idServicio; set => idServicio = value; }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }

        public float Costo { get => costo; set => costo = value; }
        public static DataTable MostrarServicioMantenimiento()
        {
            DataTable DtResultado = new DataTable("MostrarServicioMantenimiento");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();

            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarServicioMantenimiento";
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
        //
        public static DataTable BuscarServicioMantenimiento(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarServicioMantenimiento");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {

                SqlCon.ConnectionString = connection.cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarServicioMantenimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@dato";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = dato;
                SqlCmd.Parameters.Add(ParDato);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public string Insertar(mServicioMantenimiento ServicioMantenimiento)
        {
            string repuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                //Código
                SqlCon.ConnectionString = connection.cn; ;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "InsertarServicioMantenimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdMantenimiento = new SqlParameter();
                ParIdMantenimiento.ParameterName = "@idMantenimiento";
                ParIdMantenimiento.SqlDbType = SqlDbType.Int;
                ParIdMantenimiento.Value = ServicioMantenimiento.IdMantenimiento;
                SqlCmd.Parameters.Add(ParIdMantenimiento);

                SqlParameter ParIdServicio = new SqlParameter();
                ParIdServicio.ParameterName = "@idServicio";
                ParIdServicio.SqlDbType = SqlDbType.Int;
                ParIdServicio.Value = ServicioMantenimiento.idServicio;
                SqlCmd.Parameters.Add(ParIdServicio);

                SqlParameter ParIdEmpleado= new SqlParameter();
                ParIdEmpleado.ParameterName = "@idEmpleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = ServicioMantenimiento.idEmpleado;
                SqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParCosto = new SqlParameter();
                ParCosto.ParameterName = "@costo";
                ParCosto.SqlDbType = SqlDbType.Float;
                ParCosto.Value = ServicioMantenimiento.costo;
                SqlCmd.Parameters.Add(ParCosto);


                repuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                repuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return repuesta;

        }
    }
}
