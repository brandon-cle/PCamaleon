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
    public partial class frmBuscarMantenimiento : Form
    {
        public frmBuscarMantenimiento()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtMantenimiento.DataSource = cMantenimiento.BuscarMantenimiento(textBox1.Text);
        }

        private void frmBuscarMantenimiento_Load(object sender, EventArgs e)
        {
            dtMantenimiento.DataSource = cMantenimiento.MostrarMantenimiento();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dtMantenimiento.Rows.Count == 0)
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
