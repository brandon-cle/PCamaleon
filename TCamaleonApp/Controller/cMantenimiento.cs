using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCamaleonApp.Model;

namespace TCamaleonApp.Controller
{
     class cMantenimiento
    {
        public static DataTable MostrarMantenimiento()
        {
            return mMantenimiento.MostrarMantenimiento();
        }
        public static DataTable BuscarMantenimiento(string info)
        {
            return mMantenimiento.BuscarMantenimiento(info);
        }
    }
}
