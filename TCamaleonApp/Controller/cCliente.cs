using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCamaleonApp.Model;

namespace TCamaleonApp.Controller
{
    class cCliente
    {
        public static DataTable MostrarCliente()
        {
            return mCliente.MostrarCliente();
        }
        public static DataTable BuscarCliente(string dato)
        {
            return mCliente.BuscarCliente(dato);
        }
        public static string Insertar(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string cedula, string  telefono, string correo, string direccion)
        {
            mCliente Obj = new mCliente();
            Obj.PrimerNombre = primerNombre;
            Obj.SegundoNombre = segundoNombre;
            Obj.PrimerApellido = primerApellido;
            Obj.SegundoApellido = segundoApellido;
            Obj.Cedula = cedula;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Direccion = direccion;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int idCliente, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string cedula, string telefono, string correo, string direccion)
        {
            mCliente Obj = new mCliente();
            Obj.IdCliente = idCliente;
            Obj.PrimerNombre = primerNombre;
            Obj.SegundoNombre = segundoNombre;
            Obj.PrimerApellido = primerApellido;
            Obj.SegundoApellido = segundoApellido;
            Obj.Cedula = cedula;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Direccion = direccion;
            return Obj.Editar(Obj);
        }
    }
}
