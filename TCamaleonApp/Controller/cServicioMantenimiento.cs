using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCamaleonApp.Model;

namespace TCamaleonApp.Controller
{
    internal class cServicioMantenimiento
    {
        public static DataTable MostrarServcioMantenimiento()
        {
            return mServicioMantenimiento.MostrarServicioMantenimiento();
        }
        public static DataTable BuscarServicioMantenimiento(string info)
        {
            return mServicioMantenimiento.BuscarServicioMantenimiento(info);
        }

        public static string Insertar(int idMantenimiento, int idServicio, int idEmpleado, float costo)
        {
            mServicioMantenimiento Obj = new mServicioMantenimiento();
            Obj.IdMantenimiento = idMantenimiento;
            Obj.IdServicio = idServicio;
            Obj.IdEmpleado = idEmpleado;
            Obj.Costo = costo;
            return Obj.Insertar(Obj);
        }
    }
}
