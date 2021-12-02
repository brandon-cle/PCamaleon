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
        
        public static string Insertar(string titulo, string descripcion, string marca, string modelo, int stock, float precio)
        {
            mRepuesto Obj = new mRepuesto();
            Obj.Titulo = titulo;
            Obj.Descripcion = descripcion;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Stock = stock;
            Obj.Precio = precio;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int idRepuesto, string titulo, string descripcion, string marca, string modelo, int stock, float precio)
        {
            mRepuesto Obj = new mRepuesto();
            Obj.IdRepuesto= idRepuesto;
            Obj.Titulo = titulo;
            Obj.Descripcion = descripcion;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Stock = stock;
            Obj.Precio = precio;
            return Obj.Editar(Obj);
        }
    }
}
