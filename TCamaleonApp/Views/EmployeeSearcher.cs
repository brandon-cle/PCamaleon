﻿using System;
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
    public partial class EmployeeSearcher : Form
    {
        public EmployeeSearcher()
        {
            InitializeComponent();
            ShowToCmbCatWorks();
        }


        private void ShowEmployeer()
        {
            this.dgv_employees.DataSource = CEmployeer.ShowEmployeer();

        }

        private void ShowToCmbCatWorks()
        {
            DataTable distribuyer = new DataTable();
            distribuyer = CEmployeer.ShowToCmbCatWorks();
            int x = 0;
            string word = null;
            do
            {
                word = distribuyer.Rows[x][0].ToString();
                cmb_categories.Items.Add(word);
                x++;
            } while (x != 5);
        }

        private void EmployeeSearcher_Load(object sender, EventArgs e)
        {
            dgv_employees.AllowUserToAddRows = false;
            ShowEmployeer();
            
        }

        private void txt_employeeS_TextChanged(object sender, EventArgs e)
        {
            
            this.dgv_employees.DataSource = CEmployeer.SearchEmployeer(this.txt_employeeS.Text);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
