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
    public partial class FormServicio : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FormServicio()
        {
            InitializeComponent();
        }

        private void FormServicio_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtBuscar.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
        }
    }
}
