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
    internal class mRepuesto
    {
        private int idRepuesto;
        private string titulo;
        private string descripcion;
        private string marca;
        private string modelo;
       
        private float precio;
        private int cantidad;
        public int IdRepuesto { get => idRepuesto; set => idRepuesto = value; }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
       
        public float Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public static DataTable MostrarRepuesto()
        {
            DataTable DtResultado = new DataTable("MostrarRepuesto");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();

            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = connection.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarRepuesto";
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
        public static DataTable BuscarRepuesto(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarRepuesto");
            SqlConnection SqlCon = new SqlConnection();
            Connection connection = new Connection();
            try
            {

                SqlCon.ConnectionString = connection.cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarRepuesto";
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
        public string Insertar(mRepuesto Repuesto)
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
                SqlCmd.CommandText = "InsertarRespuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                // Parámetros del Procedimiento Almacenado

                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.VarChar;
                ParTitulo.Size = 60;
                ParTitulo.Value =Repuesto.titulo;
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

               /* SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 60;
                ParModelo.Value = Repuesto.modelo;
                SqlCmd.Parameters.Add(ParModelo);*/

                SqlParameter ParMo = new SqlParameter();
                ParMo.ParameterName = "@modelo";
                ParMo.SqlDbType = SqlDbType.VarChar;
                ParMo.Size = 60;
                ParMo.Value = Repuesto.modelo;
                SqlCmd.Parameters.Add(ParMo);


                /*SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.VarChar;
                ParPrecio.Size = 60;
                ParPrecio.Value = Repuesto.precio;
                SqlCmd.Parameters.Add(ParPrecio);*/

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.Float;
                ParPrecio.Value = Repuesto.idRepuesto;
                SqlCmd.Parameters.Add(ParPrecio);

                /* SqlParameter ParCantidad = new SqlParameter();
                 ParCantidad.ParameterName = "@cantidad";
                 ParCantidad.SqlDbType = SqlDbType.VarChar;
                 ParCantidad.Size = 60;
                 ParCantidad.Value = Repuesto.modelo;
                 SqlCmd.Parameters.Add(ParCantidad);
                */
                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Repuesto.idRepuesto;
                SqlCmd.Parameters.Add(ParCantidad);

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
        public string Editar(mRepuesto Repuesto)
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
                SqlCmd.CommandText = "EditarRepuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlParameter ParIdRepuesto= new SqlParameter();
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

                SqlParameter ParMo = new SqlParameter();
                ParMo.ParameterName = "@modelo";
                ParMo.SqlDbType = SqlDbType.VarChar;
                ParMo.Size = 60;
                ParMo.Value = Repuesto.modelo;
                SqlCmd.Parameters.Add(ParMo);


                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.Float;
                ParPrecio.Value = Repuesto.idRepuesto;
                SqlCmd.Parameters.Add(ParPrecio);
      
                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Repuesto.idRepuesto;
                SqlCmd.Parameters.Add(ParCantidad);

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
