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
    internal class mServicioRepuesto
    {
        private int idServicioMantenimiento;
        private int idRepuesto;
        private int cantidad;
        private float costo;
        public int IdServicioMantenimiento { get => idServicioMantenimiento; set => idServicioMantenimiento = value; }

        public int IdRepuesto { get => idRepuesto; set => idRepuesto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Costo { get => costo; set => costo = value; }
        public static DataTable MostrarServicioRepuesto()
        {
            DataTable DtResultado = new DataTable("MostrarServicioRepuesto");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();

            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarServicioRepuesto";
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
        public static DataTable BuscarServicioRepuesto(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarServicioRepuesto");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                SqlCon.ConnectionString = connection.cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarServicioRepuesto";
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

        public string Insertar(mServicioRepuesto ServicioRepuesto)
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
                SqlCmd.CommandText = "InsertarServicioRepuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdServicioMantenimiento = new SqlParameter();
                ParIdServicioMantenimiento.ParameterName = "@idServicioMantenimiento";
                ParIdServicioMantenimiento.SqlDbType = SqlDbType.Int;
                ParIdServicioMantenimiento.Value = ServicioRepuesto.idServicioMantenimiento;
                SqlCmd.Parameters.Add(ParIdServicioMantenimiento);

                SqlParameter ParIdRepuesto = new SqlParameter();
                ParIdRepuesto.ParameterName = "@idRepuesto";
                ParIdRepuesto.SqlDbType = SqlDbType.Int;
                ParIdRepuesto.Value = ServicioRepuesto.idRepuesto;
                SqlCmd.Parameters.Add(ParIdRepuesto);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = ServicioRepuesto.cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParCosto = new SqlParameter();
                ParCosto.ParameterName = "@costo";
                ParCosto.SqlDbType = SqlDbType.Float;
                ParCosto.Value = ServicioRepuesto.costo;
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
