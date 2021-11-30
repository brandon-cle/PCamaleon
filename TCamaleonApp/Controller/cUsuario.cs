using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCamaleonApp.Model;

namespace TCamaleonApp.Controller
{
    class cUsuario
    {
        public static DataTable MostrarUSuario()
        {
            return mUsuario.MostrarUsuario();
        }

        public static DataTable BuscarUsuario(string dato)
        {
            return mUsuario.BuscarUsuario(dato);
        }
    } 
}
