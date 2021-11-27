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
    
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            maximize();
        }

        #region Funcionalidades del formulario
        public void maximize()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        //Opening form over panels
        private void OpenForm<myform>() where myform : Form, new()
        {
            Form form;
            form = ContentPanel.Controls.OfType<myform>().FirstOrDefault(); //Search on the collection panel someone called form
            if(form == null)
            {
                form = new Form();
                form.TopLevel = false;
                ContentPanel.Controls.Add(form);
                ContentPanel.Tag = form;
                form.Show();
            }
            else
            {
                form.BringToFront();
            }
        }
    }
}
