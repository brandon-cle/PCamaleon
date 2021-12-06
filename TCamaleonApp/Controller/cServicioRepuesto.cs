using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCamaleonApp.Model;

namespace TCamaleonApp.Controller
{
    internal class cServicioRepuesto
    {
        public static DataTable MostrarServcioRepuesto()
        {
            return mServicioRepuesto.MostrarServicioRepuesto();
        }
        public static DataTable BuscarServicioMantenimiento(string info)
        {
            return mServicioRepuesto.BuscarServicioRepuesto(info);
        }
    }
}
