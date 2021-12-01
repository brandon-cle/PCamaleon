using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCamaleonApp.Views
{
    public partial class frmBuscarVehiculo : Form
    {
        public frmBuscarVehiculo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dtVehiculo.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
