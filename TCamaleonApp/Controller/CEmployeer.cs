﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TCamaleonApp.Model;

namespace TCamaleonApp.Controller
{
    class CEmployeer
    {
        public static DataTable ShowEmployeer()
        {
            return MEmployeer.ShowEmployeer();
        }

        public static DataTable SearchEmployeer(string info)
        {
            return MEmployeer.SearchEmployeer(info);
        }

        public static DataTable ShowToCmbCatWorks()
        {
            return MEmployeer.ShowToCmbCatWorks();
        }

        public static DataTable ShowToCmbCatWorks2()
        {
            return MEmployeer.ShowToCmbCatWorks2();
        }

        public static DataTable ShowJob(string category)
        {
            return MEmployeer.ShowJob(category);
        }

        public static DataTable ShowJobID()
        {
            return MEmployeer.ShowJobID();
        }

        public static void InsertarEmpleado(string E_firstname, string E_secondname, string E_thirdname, string E_lastname, string E_identification, string E_numberphone, int E_IDworkstation, string E_status, string E_mail, string E_Address)
        {
            MEmployeer.InsertarEmpleado(E_firstname, E_secondname, E_thirdname, E_lastname, E_identification, E_numberphone, E_IDworkstation, E_status, E_mail, E_Address);
        }


        public static void ActualizarEmpleado(int employeeID, string E_firstname, string E_secondname, string E_thirdname, string E_lastname, string E_identification, string E_numberphone, int E_IDworkstation, string E_status, string E_mail, string E_Address)
        {
            MEmployeer.ActualizarEmpleado(employeeID, E_firstname, E_secondname, E_thirdname, E_lastname, E_identification, E_numberphone, E_IDworkstation, E_status, E_mail, E_Address);
        }

        public static void ActualizarEmpleado_Administrativo(int employeeID, string E_firstname, string E_secondname, string E_thirdname, string E_lastname, string E_identification, string E_numberphone, int E_IDworkstation, string E_status, string E_mail, string E_Address)
        {
            MEmployeer.ActualizarEmpleado_Administrativo(employeeID, E_firstname, E_secondname, E_thirdname, E_lastname, E_identification, E_numberphone, E_IDworkstation, E_status, E_mail, E_Address);
        }

        public static DataTable MostrarEmpleadoAd_noUser()
        {
            return MEmployeer.MostrarEmpleadoAd_noUser();
        }

        public static DataTable BuscarEmpleadoAd_noUser(string info)
        {
            return MEmployeer.BuscarEmpleadoAd_noUser(info);
        }

        public static DataTable MostrarEmpleado_Administrativo(string info)
        {
            return MEmployeer.SearchEmployeerAd(info);
        }


        public static DataTable DataToShow()
        {
            return MEmployeer.DataToShow();
        }

        public static DataTable SearchEmployeerAd(string info)
        {
            return MEmployeer.SearchEmployeerAd(info);
        }

        public static DataTable MostrarTécnicoA()
        {
            return MEmployeer.MostrarTécnicoA();
        }

        public static DataTable BuscarTécnicoA(string info)
        {
            return MEmployeer.BuscarTénicoA(info);
        }

    }
}
