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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }
        private void MostrarServicio()
        {

            this.dtCliente.DataSource = cCliente.MostrarCliente();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

            dtCliente.AllowUserToAddRows = false;
            MostrarServicio();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtCliente.DataSource = cCliente.BuscarCliente(txtBuscar.Text);
        }
    }
}
