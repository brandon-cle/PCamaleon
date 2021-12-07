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
    public partial class Form_Lobby_GestionBcs : Form
    {
        public Form_Lobby_GestionBcs()
        {
            InitializeComponent();
            OpenForm<EmployeeSearcher>();
            this.WindowState = FormWindowState.Maximized;
        }
        private void OpenForm<myform>() where myform : Form, new()
        {
            Form form;
            form = panel_painting.Controls.OfType<myform>().FirstOrDefault(); //Search on the collection panel someone called form
            if (form == null)
            {
                form = new myform();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panel_painting.Controls.Add(form);
                panel_painting.Tag = form;
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
