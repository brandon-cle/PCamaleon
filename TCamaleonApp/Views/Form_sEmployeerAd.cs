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
    public partial class Form_sEmployeerAd : Form
    {
        public Form_sEmployeerAd()
        {
            InitializeComponent();
        }

        private void Form_sEmployeerAd_Load(object sender, EventArgs e)
        {
            CEmployeer.MostrarEmpleadoAd_noUser();

        }
    }
}
