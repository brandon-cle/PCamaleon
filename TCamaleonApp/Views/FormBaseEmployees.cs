﻿using System;
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
    public partial class FormBaseEmployees : Form
    {
        public FormBaseEmployees()
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
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
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

        private void btn_E_Insert_Click(object sender, EventArgs e)
        {
            //OpenSubForm<>()
        }

        private void btn_E_Searcher_Click(object sender, EventArgs e)
        {
            OpenSubForm<EmployeeSearcher>();
        }

    }

    
}
