using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TCamaleonApp.View;
using TCamaleonApp.Model;

namespace TCamaleonApp.Controller
{
    class CUsuario
    {
        public static DataTable ValidarAcceso(string username, string password)
        {
            return mUsuario.ValidarAcceso(username, password);
        }

        public static DataTable MostrarUsuarios()
        {
            return mUsuario.MostrarUsuarios();
        }

        public static void InsertarUsuario(string username, string password, string employeeID)
        {
            mUsuario.InsertarUsuario(username, password, employeeID);
        }

        public static void ActualizarUsuario(string nu, string password, string status, string ID_user)
        {
            mUsuario.ActualizarUsuario(nu, password, status, ID_user);
        }

        public static DataTable BuscarUsuarios(string info)
        {
            return mUsuario.BuscarUsuarios(info);
        }
    }
}

