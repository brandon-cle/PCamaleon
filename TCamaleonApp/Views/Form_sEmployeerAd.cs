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
    public partial class Form_sEmployeerAd : Form
    {
        

        public Form_sEmployeerAd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form_sEmployeerAd_Load(object sender, EventArgs e)
        {
            this.dgv_employeesS.DataSource = CEmployeer.MostrarEmpleadoAd_noUser();
            dgv_employeesS.AllowUserToAddRows = false;
        }

        private void dgv_employeesS_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            FormUsuario.globalID_toChange = (Convert.ToString(this.dgv_employeesS.CurrentRow.Cells["IDEmpleado"].Value));//
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dgv_employeesS.DataSource = CEmployeer.BuscarEmpleadoAd_noUser(this.textBox1.Text);
        }
    }
}
