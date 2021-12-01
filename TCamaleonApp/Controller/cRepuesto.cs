using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCamaleonApp.Model;

namespace TCamaleonApp.Controller
{
     class cRepuesto
    {
        public static DataTable MostrarRepuesto()
        {
            return mRepuesto.MostrarRepuesto();
        }
        public static DataTable BuscarRepuesto(string info)
        {
            return mRepuesto.BuscarRepuesto(info);
        }
    }
}
