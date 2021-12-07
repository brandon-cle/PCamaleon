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
    public partial class Form_Lobby_Gestion_F : Form
    {
        public Form_Lobby_Gestion_F()
        {
            InitializeComponent();
            maximize();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        #region Funcionalidades del formulario
        public void maximize()
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Estás seguro que quieres cerrar el programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
        //Opening form over panels
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

        private void btn_Service_Click(object sender, EventArgs e)
        {
            OpenForm<FormServicio>();
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            OpenForm<EmployeeSearcher>();
        }

        private void panel_painting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenForm<FormUsuario>();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            OpenForm<FormVehiculo>();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            OpenForm<FormServicioRepuesto>();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            OpenForm<FormMantenimiento>();
        }

        private void btnRepuesto_Click(object sender, EventArgs e)
        {
            OpenForm<FormRepuesto>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm<FormCliente>();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            OpenForm<FormCliente>();
        }
    }
}
