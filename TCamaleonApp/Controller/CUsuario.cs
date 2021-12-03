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


    }
}

