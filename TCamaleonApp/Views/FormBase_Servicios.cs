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
    public partial class FormBase_Servicios : Form
    {
        public FormBase_Servicios()
        {
            InitializeComponent();
        }

        public void OpenSubForm<mysubform>() where mysubform : Form, new()
        {
            Form form;
            form = pnl_openForm.Controls.OfType<mysubform>().FirstOrDefault();
            if (form == null)
            {
                form = new mysubform();
                form.TopLevel = false;
                pnl_openForm.Controls.Add(form);
                pnl_openForm.Tag = form;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.BringToFront();
            }
        }
    }
}
