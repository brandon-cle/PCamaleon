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
        public static string Insertar(int idServicioMantenimiento, int idRepuesto, int cantidad, float costo)
        {
            mServicioRepuesto Obj = new mServicioRepuesto();
            Obj.IdServicioMantenimiento = idServicioMantenimiento;
            Obj.IdRepuesto = idRepuesto;
            Obj.Cantidad = cantidad;
            Obj.Costo = costo;
            return Obj.Insertar(Obj);
        }



    }
}
