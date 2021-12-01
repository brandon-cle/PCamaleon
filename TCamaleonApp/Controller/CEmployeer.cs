using System;
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
    }
}
