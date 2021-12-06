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
    public partial class FormServicioRepuesto : Form
    {
        public FormServicioRepuesto()
        {
            InitializeComponent();
        }

        private void btnMecanico_Click(object sender, EventArgs e)
        {
            frmBuscarRepuesto fc = new frmBuscarRepuesto();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                this.txtIdServicio.Text = fc.dtRepuesto.Rows[fc.dtRepuesto.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescripcion.Text = fc.dtRepuesto.Rows[fc.dtRepuesto.CurrentRow.Index].Cells[1].Value.ToString();
                txtCosto.Text = fc.dtRepuesto.Rows[fc.dtRepuesto.CurrentRow.Index].Cells[3].Value.ToString();

            }
        }
    }
}
