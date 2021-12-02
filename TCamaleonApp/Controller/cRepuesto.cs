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
        
        public static string Insertar(string titulo, string descripcion, string marca, string modelo, float precio, int cantidad)
        {
            mRepuesto Obj = new mRepuesto();
            Obj.Titulo = titulo;
            Obj.Descripcion = descripcion;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Precio = precio;
            Obj.Cantidad = cantidad;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int idRepuesto, string titulo, string descripcion, string marca, string modelo, float precio, int cantidad)
        {
            mRepuesto Obj = new mRepuesto();
            Obj.IdRepuesto= idRepuesto;
            Obj.Titulo = titulo;
            Obj.Descripcion = descripcion;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Precio = precio;
            Obj.Cantidad = cantidad;
            return Obj.Editar(Obj);
        }
    }
}
