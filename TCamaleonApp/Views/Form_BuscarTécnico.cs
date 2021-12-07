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
    public partial class Form_BuscarTécnico : Form
    {
        public string ID_extracted;
        public string name_extracted;
        public string name3_extracted;

        public Form_BuscarTécnico()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_BuscarTécnico_Load(object sender, EventArgs e)
        {
            this.dtMecanico.DataSource = CEmployeer.MostrarTécnicoA();
             dtMecanico.AllowUserToAddRows = false;
        }

        private void txt_searcher_TextChanged(object sender, EventArgs e)
        {
            this.dtMecanico.DataSource = CEmployeer.BuscarTécnicoA(txt_searcher.Text);
        }

        private void dgv_técnico_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void DtMecanico_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormMantenimiento.globalID_toChange = (Convert.ToString(this.dtMecanico.CurrentRow.Cells["IDEmpleado"].Value));//
            FormMantenimiento.globalNombre_toChange = (Convert.ToString(this.dtMecanico.CurrentRow.Cells["Primer Nombre"].Value));
            this.Close();
        }
    }
}
