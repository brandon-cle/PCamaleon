using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCamaleonApp
{
    public partial class Tester : Form
    {
        public Tester()
        {
            InitializeComponent();
        }

        private void Tester_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PuestosTable.Puesto' table. You can move, or remove it, as needed.
            this.PuestoTableAdapter.Fill(this.PuestosTable.Puesto);

            this.reportViewer1.RefreshReport();
        }
    }
}
