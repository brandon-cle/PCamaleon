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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtUsuario.Text = String.Empty;
            this.txtTrabajador.Text = String.Empty;
            this.txtContrasena.Text = String.Empty;
            this.txtRepitaContrasena.Text = String.Empty;
      
        }
    }
}
