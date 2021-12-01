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
    public partial class EmployeeSearcher : Form
    {
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
            int indexdb = 0;
            string Iwant = null;
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
                    puesto_searcher = Int32.TryParse(showering.Rows[x][1].ToString(), out indexdb);
                    return indexdb;
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
            bool modify = false;
            if (modify)
            {

            }
            else
            {
                
                    
            }

        }
    }
}
