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
    class mMantenimiento
    {
        private int idMantenimiento;
        private int idVehiculo;
        private string descripcion;
        private string estado;
        private string fechaSalida;
        private DateTime fechaIngreso;
        public int IdMantenimiento { get => idMantenimiento; set => idMantenimiento = value; }
        public int IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string  Estado { get => estado; set => estado = value; }
        public string FechaSalida { get => fechaSalida; set => fechaSalida = value; }

        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }

        public static DataTable CambioEstado(int idMantenimiento)
        {
            DataTable DtResultado = new DataTable("CambioEstado");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {   
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CambioEstado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //   Cargando el parámetro de Búsqueda
                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@IdMantenimiento";
                ParDato.SqlDbType = SqlDbType.Int;
                ParDato.Value = idMantenimiento;
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
        public static DataTable MostrarMantenimiento()
        {
            DataTable DtResultado = new DataTable("MostrarMantenimiento");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();

            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarMantenimiento";
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
        public static DataTable BuscarMantenimiento(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarMantenimiento");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {

                SqlCon.ConnectionString = connection.cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarMantenimiento";
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
        
        public string Insertar(mMantenimiento Mantenimiento)
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
                SqlCmd.CommandText = "InsertarMantenimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdVehiculo = new SqlParameter();
                ParIdVehiculo.ParameterName = "@idVehiculo";
                ParIdVehiculo.SqlDbType = SqlDbType.Int;
                ParIdVehiculo.Value = Mantenimiento.idVehiculo;
                SqlCmd.Parameters.Add(ParIdVehiculo);

                SqlParameter ParFechaIngreso = new SqlParameter();
                ParFechaIngreso.ParameterName = "@fechaIngreso";
                ParFechaIngreso.SqlDbType = SqlDbType.DateTime;
                //ParFechaIngreso.Size = 60;
                ParFechaIngreso.Value = Mantenimiento.fechaIngreso;
                SqlCmd.Parameters.Add(ParFechaIngreso);

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
       /* public string Editar(mMantenimiento Mantenimiento)
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
                SqlCmd.CommandText = "EditarMantenimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlParameter ParIdRepuesto = new SqlParameter();
                ParIdRepuesto.ParameterName = "@idRepuesto";
                ParIdRepuesto.SqlDbType = SqlDbType.Int;
                ParIdRepuesto.Value = Repuesto.idRepuesto;
                SqlCmd.Parameters.Add(ParIdRepuesto);

                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.VarChar;
                ParTitulo.Size = 60;
                ParTitulo.Value = Repuesto.titulo;
                SqlCmd.Parameters.Add(ParTitulo);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 60;
                ParDescripcion.Value = Repuesto.descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 60;
                ParMarca.Value = Repuesto.marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 60;
                ParModelo.Value = Repuesto.modelo;
                SqlCmd.Parameters.Add(ParModelo);


                SqlParameter ParStock = new SqlParameter();
                ParStock.ParameterName = "@stock";
                ParStock.SqlDbType = SqlDbType.VarChar;
                ParStock.Size = 60;
                ParStock.Value = Repuesto.modelo;
                SqlCmd.Parameters.Add(ParStock);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.VarChar;
                ParPrecio.Size = 60;
                ParPrecio.Value = Repuesto.precio;
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
        } */
    }
}
