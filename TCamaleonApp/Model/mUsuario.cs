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
    class mUsuario
    {
        public static DataTable ValidarAcceso(string usuario, string contraseña)
        {
            DataTable DtResultado = new DataTable("Inicio_Sesión");
            SqlConnection SqlCon = new SqlConnection();
            Connection conexión = new Connection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = conexión.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ValidarAcceso";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //   Cargando los parámetros del procedimiento almacenado
                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@usernameS";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = usuario;
                SqlCmd.Parameters.Add(ParDato);

                SqlParameter ParDato1 = new SqlParameter();
                ParDato1.ParameterName = "@userpasswordS";
                ParDato1.SqlDbType = SqlDbType.VarChar;
                ParDato1.Size = 100;
                ParDato1.Value = contraseña;
                SqlCmd.Parameters.Add(ParDato1);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static DataTable MostrarUsuarios()
        {
            DataTable DtResultado = new DataTable("MostrarUsuarios");
            SqlConnection SqlCon = new SqlConnection();
            Connection conexión = new Connection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = conexión.cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarUsuarios";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //   Cargando los parámetros del procedimiento almacenado

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

    }
}
}
