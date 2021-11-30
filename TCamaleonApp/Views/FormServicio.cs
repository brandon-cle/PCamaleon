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
    public partial class FormServicio : Form
    {
        public FormServicio()
        {
            InitializeComponent();
        }

        private void dtServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            this.dtServicio.AllowUserToAddRows = false;
            this.MostrarServicio();

        }

        private void MostrarServicio()
        {
            this.dtServicio.DataSource = cServicio.MostrarServicio();

        }

 
    }
}
