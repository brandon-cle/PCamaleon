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
        bool modify = false;
        public EmployeeSearcher()
        {
            InitializeComponent();
            ShowToCmbCatWorks();
            cmb_categories.SelectedIndex = 0;

        }


        private void ShowEmployeer()
        {
            this.dgv_employees.DataSource = CEmployeer.ShowEmployeer();

        }
        private void ShowJob(string category)
        {
            cmb_job.Items.Clear();
            DataTable distribuyer = new DataTable();
            distribuyer = CEmployeer.ShowJob(category);
            int x = 0;
            int c = distribuyer.Rows.Count;
            string word = null;
            do
            {
                word = distribuyer.Rows[x][1].ToString();
                cmb_job.Items.Add(word);
                x++;
            } while (x != c);
            cmb_job.SelectedIndex = 0;
        }
        private void ShowToCmbCatWorks()
        {
            DataTable distribuyer = new DataTable();
            distribuyer = CEmployeer.ShowToCmbCatWorks();
            int x = 0;
            int c = distribuyer.Rows.Count;
            string word = null;
            do
            {
                word = distribuyer.Rows[x][0].ToString();
                cmb_categories.Items.Add(word);
                x++;
            } while (x != c);
        }

        private int Idjobpass(string puesto)
        {
            int idxdb = 0;
            bool puesto_searcher = false;
            DataTable showering = new DataTable();  
            showering = CEmployeer.ShowJobID();
            int x = 0;
            int c = showering.Rows.Count;
            string word = null;
            do
            {
                word = showering.Rows[x][1].ToString();
                if (puesto == word )
                {
                    
                    idxdb = Int32.Parse(showering.Rows[x][0].ToString());
                    Console.WriteLine(idxdb);
                    return idxdb;
                }
                
                x++;
            } while (x != c);

            return 0;
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
        #region trash to delete
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
        #endregion
        private void cmb_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowJob(cmb_categories.SelectedItem.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (modify)
            {

            }
            else
            {
               // string E_firstname, string E_secondname, string E_thirdname, string E_lastname, string E_identification, string E_numberphone, int E_IDworkstation, string E_status, string E_mail, string E_Address
                CEmployeer.InsertarEmpleado(
                    txt_name.Text, 
                    txt_name2.Text, 
                    txt_name3.Text, 
                    txt_name4.Text,
                    txt_id.Text, 
                    txt_phone.Text, 
                    Idjobpass(cmb_job.Text), 
                    "Laborando", 
                    txt_mail.Text, 
                    txt_Address.Text);

                Console.WriteLine("I'M IN, BUT IDK");
            }

        }
    }
}
