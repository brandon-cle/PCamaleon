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
    public partial class FormVehiculo : Form
    {
        public FormVehiculo()
        {
            InitializeComponent();
        }

        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            this.dtVehiculo.DataSource = cVehiculo.MostrarVehiculo();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtVehiculo.DataSource = cVehiculo.BuscarVehiculo(txtBuscar.Text);
        }
    }
}
