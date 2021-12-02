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
    class mServicio
    {
        private int idServicio;
        private string tipoMantenimiento;
        private string descripcion;
        private float precio;


        public int IdServicio { get => idServicio; set => idServicio = value; }

        public string TipoMantenimiento { get => tipoMantenimiento; set => tipoMantenimiento = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public float Precio { get => precio; set => precio = value; }

        public static DataTable MostrarServicio()
        {
            DataTable DtResultado = new DataTable("MostrarServicio");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();

            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarServicio";
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

        public static DataTable BuscarServicio(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarServicio");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {

                SqlCon.ConnectionString = connection.cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarServicio";
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
        public string Insertar(mServicio Servicio)
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
                SqlCmd.CommandText = "InsertarServicio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 60;
                ParDescripcion.Value = Servicio.descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParTipoMantenimiento = new SqlParameter();
                ParTipoMantenimiento.ParameterName = "@tipoMantenimiento";
                ParTipoMantenimiento.SqlDbType = SqlDbType.VarChar;
                ParTipoMantenimiento.Size = 60;
                ParTipoMantenimiento.Value = Servicio.tipoMantenimiento;
                SqlCmd.Parameters.Add(ParTipoMantenimiento);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.VarChar;
                ParPrecio.Size = 60;
                ParPrecio.Value = Servicio.precio;
                SqlCmd.Parameters.Add(ParPrecio);

                //Ejecutamos nuestro comando
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
        public string Editar(mServicio Servicio)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                //Código
                SqlCon.ConnectionString = connection.cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EditarServicio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlParameter ParIdServicio = new SqlParameter();
                ParIdServicio.ParameterName = "@idServicio";
                ParIdServicio.SqlDbType = SqlDbType.Int;
                ParIdServicio.Value = Servicio.idServicio;
                SqlCmd.Parameters.Add(ParIdServicio);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 60;
                ParDescripcion.Value = Servicio.descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParTipoMantenimiento = new SqlParameter();
                ParTipoMantenimiento.ParameterName = "@tipoMantenimiento";
                ParTipoMantenimiento.SqlDbType = SqlDbType.VarChar;
                ParTipoMantenimiento.Size = 60;
                ParTipoMantenimiento.Value = Servicio.tipoMantenimiento;
                SqlCmd.Parameters.Add(ParTipoMantenimiento);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.VarChar;
                ParPrecio.Size = 60;
                ParPrecio.Value = Servicio.precio;
                SqlCmd.Parameters.Add(ParPrecio);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
    }   
}
