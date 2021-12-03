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
    public partial class frmBuscarServicio : Form
    {
        public frmBuscarServicio()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dtServicio.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dtServicio.DataSource = cServicio.BuscarServicio(textBox1.Text);
        }

        private void frmBuscarServicio_Load(object sender, EventArgs e)
        {
            this.dtServicio.DataSource = cServicio.MostrarServicio();
        }
    }
}
