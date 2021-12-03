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
    public partial class frmBuscarVehiculo : Form
    {
        public frmBuscarVehiculo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dtVehiculo.DataSource = cVehiculo.BuscarVehiculo(textBox1.Text);
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

        private void frmBuscarVehiculo_Load(object sender, EventArgs e)
        {
            this.dtVehiculo.DataSource = cVehiculo.MostrarVehiculo();
        }
    }
}
