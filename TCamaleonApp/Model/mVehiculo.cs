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
    class mVehiculo
    {
        private int idVehiculo;
        private string placa;
        private int idCliente;
        private string marca;
        private string modelo;
        private int ano;


        public int IdVehiculo { get => idVehiculo; set => idVehiculo = value; }

        public string Placa { get => placa; set => placa = value; }
        public int IdCliente { get => idCliente; set => idCliente= value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Ano { get => ano; set => ano = value; }
        public static DataTable BuscarVehiculo (string dato)
        {
            DataTable DtResultado = new DataTable("BuscarVehiculo");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {

                SqlCon.ConnectionString = connection.cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarVehiculo";
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
        public static DataTable MostrarVehiculo()
        {
            DataTable DtResultado = new DataTable("MostrarVehiculo");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarVehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public string Insertar(mVehiculo Vehiculo)
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
                SqlCmd.CommandText = "InsertarVehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlParameter ParPlaca = new SqlParameter();
                ParPlaca.ParameterName = "@placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 60;
                ParPlaca.Value = Vehiculo.IdCliente;
                SqlCmd.Parameters.Add(ParPlaca);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idCliente";
                ParIdCliente.SqlDbType = SqlDbType.VarChar;
                ParIdCliente.Size = 60;
                ParIdCliente.Value = Vehiculo.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 60;
                ParMarca.Value = Vehiculo.marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 60;
                ParModelo.Value = Vehiculo.modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParAno = new SqlParameter();
                ParAno.ParameterName = "@ano";
                ParAno.SqlDbType = SqlDbType.VarChar;
                ParAno.Size = 60;
                ParAno.Value = Vehiculo.ano;
                SqlCmd.Parameters.Add(ParAno);
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
        public string Editar(mVehiculo Vehiculo)
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
                SqlParameter ParIdVehiculo = new SqlParameter();
                ParIdVehiculo.ParameterName = "@idVehiculo";
                ParIdVehiculo.SqlDbType = SqlDbType.Int;
                ParIdVehiculo.Value = Vehiculo.IdVehiculo;
                SqlCmd.Parameters.Add(ParIdVehiculo);

                // Parámetros del Procedimiento Almacenado
                SqlParameter ParPlaca = new SqlParameter();
                ParPlaca.ParameterName = "@placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 60;
                ParPlaca.Value = Vehiculo.IdCliente;
                SqlCmd.Parameters.Add(ParPlaca);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idCliente";
                ParIdCliente.SqlDbType = SqlDbType.VarChar;
                ParIdCliente.Size = 60;
                ParIdCliente.Value = Vehiculo.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 60;
                ParMarca.Value = Vehiculo.marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 60;
                ParModelo.Value = Vehiculo.modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParAno = new SqlParameter();
                ParAno.ParameterName = "@ano";
                ParAno.SqlDbType = SqlDbType.VarChar;
                ParAno.Size = 60;
                ParAno.Value = Vehiculo.ano;
                SqlCmd.Parameters.Add(ParAno);

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
