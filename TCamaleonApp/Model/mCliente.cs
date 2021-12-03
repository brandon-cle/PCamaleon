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
    class mCliente
    {
        private int idCliente;
        private string primerNombre;
        private string segundoNombre;
        private string primerApellido;
        private string segundoApellido;
        private string cedula;
        private string telefono;
        private string correo;
        private string direccion;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        
        public static DataTable BuscarCliente(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarCliente");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {
                
                SqlCon.ConnectionString = connection.cn;
                
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarCliente";
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
        // para mostrar cliente
        public static DataTable MostrarCliente()
        {
            DataTable DtResultado = new DataTable("MostrarCliente");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarCliente";
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

        /// this is insert
        public string Insertar(mCliente Cliente)
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
                SqlCmd.CommandText = "InsertarCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@primerNombre";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = Cliente.PrimerNombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@segundoNombre";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 60;
                ParSegundoNombre.Value = Cliente.SegundoNombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@primerApellido";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 60;
                ParPrimerApellido.Value = Cliente.PrimerApellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@segundoApellido";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 60;
                ParSegundoApellido.Value = Cliente.SegundoApellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 60;
                ParCedula.Value = Cliente.Cedula;
                SqlCmd.Parameters.Add(ParCedula);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 60;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 60;
                ParCorreo.Value = Cliente.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParDirección = new SqlParameter();
                ParDirección.ParameterName = "@direccion";
                ParDirección.SqlDbType = SqlDbType.VarChar;
                ParDirección.Size = 100;
                ParDirección.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDirección);

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


        public string Editar(mCliente Cliente)
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
                SqlCmd.CommandText = "EditarCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idCliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Cliente.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@primerNombre";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = Cliente.PrimerNombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@segundoNombre";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 60;
                ParSegundoNombre.Value = Cliente.SegundoNombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@primerApellido";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 60;
                ParPrimerApellido.Value = Cliente.PrimerApellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@segundoApellido";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 60;
                ParSegundoApellido.Value = Cliente.SegundoApellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Value = Cliente.Cedula;
                SqlCmd.Parameters.Add(ParCedula);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 60;
                ParCorreo.Value = Cliente.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParDirección = new SqlParameter();
                ParDirección.ParameterName = "@direccion";
                ParDirección.SqlDbType = SqlDbType.VarChar;
                ParDirección.Size = 100;
                ParDirección.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDirección);
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
