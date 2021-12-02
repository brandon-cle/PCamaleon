using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCamaleonApp.Model;

namespace TCamaleonApp.Controller
{


    class cServicio
    {
        public static DataTable MostrarServicio()
        {
            return mServicio.MostrarServicio();
        }
        public static DataTable BuscarServicio(string info)
        {
            return mServicio.BuscarServicio(info);
        }
        public static string Insertar(string descripcion, string tipoMantenimiento, float precio)
        {
            mServicio Obj = new mServicio();
            Obj.Descripcion = descripcion;
            Obj.TipoMantenimiento = tipoMantenimiento;
            Obj.Precio = precio;
            
            return Obj.Insertar(Obj);
        }
        public static string Editar(int idServicio, string descripcion, string tipoMantenimiento, float precio)
        {
            mServicio Obj = new mServicio();
            Obj.IdServicio = idServicio;
            Obj.Descripcion = descripcion;
            Obj.TipoMantenimiento = tipoMantenimiento;
            Obj.Precio = precio;
            return Obj.Editar(Obj);
        }
    }
}

