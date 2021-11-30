using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCamaleonApp.Controller;

namespace TCamaleonApp.Views
{
    public partial class EmployeeSearcher : Form
    {
        public EmployeeSearcher()
        {
            InitializeComponent();
        }


        private void ShowEmployeer()
        {
            this.dgv_employees.DataSource = CEmployeer.ShowEmployeer();

        }

        private void EmployeeSearcher_Load(object sender, EventArgs e)
        {
            dgv_employees.AllowUserToAddRows = false;
            ShowEmployeer();
        }

        private void txt_employeeS_TextChanged(object sender, EventArgs e)
        {
            
            this.dgv_employees.DataSource = CEmployeer.SearchEmployeer(this.txt_employeeS.Text);
        }
    }
}
