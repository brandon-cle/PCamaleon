using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCamaleonApp.Views;

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
            if(MessageBox.Show("¿Estás seguro que quieres cerrar el programa?", "Aviso",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
        //Opening form over panels
        private void OpenForm<myform>() where myform : Form, new()
        {
            Form form;
            form = panel_painting.Controls.OfType<myform>().FirstOrDefault(); //Search on the collection panel someone called form
            if(form == null)
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

        private void btn_Service_Click(object sender, EventArgs e)
        {
            OpenForm<FormServicio>();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            OpenForm<FormBaseEmployees>();
        }
    }
}
