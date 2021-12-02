using System.Windows.Forms;
using TCamaleonApp.Controller;

namespace TCamaleonApp.Views
{
    public partial class FormRepuesto : Form
    {
        public FormRepuesto()
        {
            InitializeComponent();
        }

        private void FormRepuesto_Load(object sender, System.EventArgs e)
        {
            this.dtRepuesto.DataSource = cServicio.MostrarServicio();
        }
    }
}
