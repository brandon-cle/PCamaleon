using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCamaleonApp.Model;

namespace TCamaleonApp.Controller
{
    class cVehiculo
    {
        public static DataTable MostrarVehiculo()
        {
            return mVehiculo.MostrarVehiculo();
        }
        public static DataTable BuscarCliente(string dato)
        {
            return mVehiculo.BuscarVehiculo(dato);
        }
    }
}
