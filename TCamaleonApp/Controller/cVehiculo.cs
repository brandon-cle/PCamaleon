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
        public static DataTable BuscarVehiculo(string dato)
        {
            return mVehiculo.BuscarVehiculo(dato);
        }
        public static string Insertar( int idCliente, string marca, string modelo, int ano, string matricula)
        {
            mVehiculo Obj = new mVehiculo();
            
            Obj.IdCliente = idCliente;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Ano = ano;
            Obj.Matricula = matricula;

            return Obj.Insertar(Obj);
        }
        public static string Editar(int idVehiculo, int idCliente, string marca, string modelo, int ano, string matricula)
        {
            mVehiculo Obj = new mVehiculo();
            Obj.IdVehiculo = idVehiculo;
            Obj.IdCliente = idCliente;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Ano = ano;
            Obj.Matricula = matricula;
            return Obj.Editar(Obj);
        }
    }
}
