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
using TCamaleonApp.Model;

namespace TCamaleonApp.Views
{
    public partial class EmployeeSearcher : Form
    {
        bool modify = false;
        public static bool modify_complete = false;
        int IDglobalmodify;
        public EmployeeSearcher()
        {
            InitializeComponent();
            cb_cat_search.SelectedIndex = 1;
            cb_job.Visible = false;
           

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
            int id = 0;
            string word = null;
            do
            {
                word = distribuyer.Rows[x][1].ToString();
                id = Int32.Parse(distribuyer.Rows[x][2].ToString());

                //CATEGORÍA ADMINISTRACIÓN Y ALTO MANDO

               
                //Condcionales

                if (cb_cat_search.SelectedItem.ToString() == "Administración y Alto Mando" && cmb_categories.SelectedItem.ToString() == "Colisión")
                {
                    if (id == 74 || id == 74 )
                    {
                        cmb_job.Items.Add(word);
                    }
                   
                }


                if (cb_cat_search.SelectedItem.ToString() == "Administración y Alto Mando" && cmb_categories.SelectedItem.ToString() == "Mecánico")
                {
                    if (id == 78 || id == 79)
                    {
                        cmb_job.Items.Add(word);
                    }

                }



                if (cb_cat_search.SelectedItem.ToString() == "Administración y Alto Mando" && cmb_categories.SelectedItem.ToString() == "Repuestos")
                {
                    
                    
                       cmb_job.Items.Add(word);
                    

                }



                if (cb_cat_search.SelectedItem.ToString() == "Administración y Alto Mando" && cmb_categories.SelectedItem.ToString() == "Administrativo")
                {


                    cmb_job.Items.Add(word);


                }



                if (cb_cat_search.SelectedItem.ToString() == "Administración y Alto Mando" && cmb_categories.SelectedItem.ToString() == "Alto mando")
                {


                    cmb_job.Items.Add(word);


                }


                /////////////////////////////
                //SECCIÓN MECÁNICA




                //Condicionales

                if (cb_cat_search.SelectedItem.ToString() == "Sección Mecánica" && cmb_categories.SelectedItem.ToString() == "Mecánico")
                {
                    if (id != 78)
                    {
                        cmb_job.Items.Add(word);
                    }

                }
                

                if (cb_cat_search.SelectedItem.ToString() == "Sección Mecánica" && cmb_categories.SelectedItem.ToString() == "Colisión")
                {
                    if (id != 74)
                    {
                        cmb_job.Items.Add(word);
                    }
                }

                


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

        private void ShowToCmbCatWorks2()
        {
            DataTable distribuyer = new DataTable();
            distribuyer = CEmployeer.ShowToCmbCatWorks2();
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
                if (puesto == word)
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

            if (cb_cat_search.SelectedItem.ToString() == "Administración y Alto Mando")
            {
                this.dgv_employees.DataSource = MEmployeer.SearchEmployeerAd(txt_employeeS.Text);

            }
            else
            {
                this.dgv_employees.DataSource = MEmployeer.SearchEmployeer(txt_employeeS.Text);
            }
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
                if (cb_cat_search.Text == "Administración y Alto Mando")
                {
                    CEmployeer.ActualizarEmpleado(
                   IDglobalmodify,
                   txt_name.Text,
                   txt_name2.Text,
                   txt_name3.Text,
                   txt_name4.Text,
                   txt_id.Text,
                   txt_phone.Text,
                   Idjobpass(cmb_job.Text),
                   status_parameter(),
                   txt_mail.Text,
                   txt_Address.Text);
                    this.dgv_employees.DataSource = MEmployeer.ShowEmployeerAd();

                }

                if(cb_cat_search.Text == "Sección Mecánica")
                {
                    CEmployeer.ActualizarEmpleado_Administrativo(
                   IDglobalmodify,
                   txt_name.Text,
                   txt_name2.Text,
                   txt_name3.Text,
                   txt_name4.Text,
                   txt_id.Text,
                   txt_phone.Text,
                   Idjobpass(cmb_job.Text),
                   status_parameter(),
                   txt_mail.Text,
                   txt_Address.Text);
                    ShowEmployeer();
                }
               
                
                clean();
                cb_job.Visible = false;



                //ACTIVATE
                button3.Enabled = true;
                dgv_employees.ClearSelection();
                cb_cat_search.Enabled = true;

                //DESACTIVATE

                //CB
                cb_job.Visible = false;
                btn_cancel.Enabled = false;

                //TXT
                txt_id.Enabled = false;
                txt_name.Enabled = false;
                txt_name2.Enabled = false;
                txt_name3.Enabled = false;
                txt_name4.Enabled = false;
                txt_phone.Enabled = false;
                txt_mail.Enabled = false;
                txt_Address.Enabled = false;




                //CMB
                cmb_categories.Enabled = false;
                cmb_job.Enabled = false;


                cmb_categories.Items.Clear();
                cmb_job.Items.Clear();

                //RBTN
                rbtn_working.Enabled = false;
                rbtn_vac.Enabled = false;
                rbtn_fired.Enabled = false;

                //BTN
                btn_save.Enabled = false;
                btn_modify.Enabled = false;

                btn_save.Text = "Guardar empleado";

                //CLEAN
                clean();
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
                    status_parameter(),
                    txt_mail.Text,
                    txt_Address.Text);

                Console.WriteLine("I'M IN, BUT IDK");
                ShowEmployeer();
                clean();
                cb_job.Visible = false;

                //ACTIVATE
                button3.Enabled = true;
                dgv_employees.ClearSelection();

                //DESACTIVATE

                //CB
                cb_job.Visible = false;
                btn_cancel.Enabled = false;

                //TXT
                txt_id.Enabled = false;
                txt_name.Enabled = false;
                txt_name2.Enabled = false;
                txt_name3.Enabled = false;
                txt_name4.Enabled = false;
                txt_phone.Enabled = false;
                txt_mail.Enabled = false;
                txt_Address.Enabled = false;




                //CMB
                cmb_categories.Enabled = false;
                cmb_job.Enabled = false;


                cmb_categories.Items.Clear();
                cmb_job.Items.Clear();

                //RBTN
                rbtn_working.Enabled = false;
                rbtn_vac.Enabled = false;
                rbtn_fired.Enabled = false;

                //BTN
                btn_save.Enabled = false;
                btn_modify.Enabled = false;

                btn_save.Text = "Guardar empleado";

                //CLEAN
                clean();



            }

        }


        public string status_parameter()
        {
            string status = null;
            if (rbtn_working.Checked) status = "Laborando";
            if (rbtn_vac.Checked) status = "Vacaciones";
            if (rbtn_fired.Checked) status = "Despedido";
            return status;
        }

        public void clean()
        {
            txt_name.Text = "";
            txt_name2.Text = "";
            txt_name3.Text = "";
            txt_name4.Text = "";
            txt_id.Text = "";
            txt_phone.Text = "";
            txt_mail.Text = "";
            txt_Address.Text = "";
        }

        private void modify_option(object sender, EventArgs e)
        {

           
            modify = true;
            cb_job.Visible = true;
            //DESACTIVATE
            button3.Enabled = false;
            //ACTIVATE
            txt_id.Enabled = true;
            txt_name.Enabled = true;
            txt_name2.Enabled = true;
            txt_name3.Enabled = true;
            txt_name4.Enabled = true;
            txt_phone.Enabled = true;
            txt_mail.Enabled = true;
            txt_Address.Enabled = true;


            //BTN
            btn_save.Text = "Guadar modificación";
            btn_modify.Enabled = false;
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;

            //CMB
            cmb_categories.Enabled = false;
            cmb_job.Enabled = false;


            //RBTN
            rbtn_vac.Enabled = true;
            rbtn_fired.Enabled = true;
            rbtn_working.Enabled = true;



            if (this.dgv_employees.SelectedRows.Count == 1)
            {
                IDglobalmodify = Int32.Parse(Convert.ToString(this.dgv_employees.CurrentRow.Cells["IDEmpleado"].Value));
                this.txt_name.Text = Convert.ToString(this.dgv_employees.CurrentRow.Cells["Primer Nombre"].Value);
                this.txt_name2.Text = Convert.ToString(this.dgv_employees.CurrentRow.Cells["Segundo Nombre"].Value);
                this.txt_name3.Text = Convert.ToString(this.dgv_employees.CurrentRow.Cells["Primer Apellido"].Value);
                this.txt_name4.Text = Convert.ToString(this.dgv_employees.CurrentRow.Cells["Segundo Apellido"].Value);
                this.txt_id.Text = Convert.ToString(this.dgv_employees.CurrentRow.Cells["Cédula"].Value);
                this.txt_phone.Text = Convert.ToString(this.dgv_employees.CurrentRow.Cells["Teléfono"].Value);
                this.cmb_job.Text = "Seleccionar";
                this.cmb_categories.Text = "Seleccionar";
                this.txt_Address.Text = Convert.ToString(this.dgv_employees.CurrentRow.Cells["Dirección"].Value);
                this.txt_mail.Text = Convert.ToString(this.dgv_employees.CurrentRow.Cells["Correo"].Value);
                if ((Convert.ToString(this.dgv_employees.CurrentRow.Cells["Estado"].Value) == "Laborando")) rbtn_working.Checked = true ;
                if ((Convert.ToString(this.dgv_employees.CurrentRow.Cells["Estado"].Value) == "Vacaciones")) rbtn_vac.Checked = true;
                if ((Convert.ToString(this.dgv_employees.CurrentRow.Cells["Estado"].Value) == "Despedido")) rbtn_fired.Checked = true;
                
                
                cmb_job.Text = Convert.ToString(this.dgv_employees.CurrentRow.Cells["Puesto"].Value);

            }
            else
            {
                MessageBox.Show("Seleccione solo una fila para el procedimiento", "Su buen mecánico le dice", MessageBoxButtons.OK);
                dgv_employees.ClearSelection();
            }
            
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DESACTIVATE

            cb_cat_search.Enabled = false;
            
            //ACTIVATE
            txt_id.Enabled = true;
            txt_name.Enabled = true;
            txt_name2.Enabled = true;
            txt_name3.Enabled = true;
            txt_name4.Enabled = true;
            txt_phone.Enabled = true;
            txt_mail.Enabled = true;
            txt_Address.Enabled = true;

            //BTN
            button3.Enabled = false;
            btn_cancel.Enabled = true;
            btn_save.Enabled = true;

            //CMB
            cmb_categories.Enabled = true;
            cmb_job.Enabled = true;

            if (cb_cat_search.SelectedItem.ToString() == "Sección Mecánica")
            {
                ShowToCmbCatWorks();
                cmb_categories.SelectedIndex = 0;
                ShowJob(cmb_categories.SelectedItem.ToString());
            }
            

            if (cb_cat_search.SelectedItem.ToString() == "Administración y Alto Mando")
            {
                ShowToCmbCatWorks2();
                cmb_categories.SelectedIndex = 0;
                ShowJob(cmb_categories.SelectedItem.ToString());
            }

            //RBTN
            rbtn_vac.Enabled = true;
            rbtn_fired.Enabled = true;
            rbtn_working.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //ACTIVATE
            button3.Enabled = true;
            dgv_employees.ClearSelection();
            cb_cat_search.Enabled = true;
            //DESACTIVATE

            //CB
            cb_job.Visible = false;
            btn_cancel.Enabled = false;

            //TXT
            txt_id.Enabled = false;
            txt_name.Enabled = false;
            txt_name2.Enabled = false;
            txt_name3.Enabled = false;
            txt_name4.Enabled = false;
            txt_phone.Enabled = false;
            txt_mail.Enabled = false;
            txt_Address.Enabled = false;


            

            //CMB
            cmb_categories.Enabled = false;
            cmb_job.Enabled = false;


            cmb_categories.Items.Clear();
            cmb_job.Items.Clear();

            //RBTN
            rbtn_working.Enabled = false;
            rbtn_vac.Enabled = false;
            rbtn_fired.Enabled = false;

            //BTN
            btn_save.Enabled = false;
            btn_modify.Enabled = false;

            btn_save.Text = "Guardar empleado";

            //CLEAN
            clean();

            

        }

        private void dgv_employees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_modify.Enabled = true;
        }

        private void cb_job_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_job.Checked)
            {
                modify_complete = true;
                cmb_categories.Enabled = true;
                cmb_job.Enabled = true;

                if (cb_cat_search.SelectedItem.ToString() == "Sección Mecánica")
                {
                    ShowToCmbCatWorks();
                    cmb_categories.SelectedIndex = 0;
                    ShowJob(cmb_categories.SelectedItem.ToString());
                }


                if (cb_cat_search.SelectedItem.ToString() == "Administración y Alto Mando")
                {
                    ShowToCmbCatWorks2();
                    cmb_categories.SelectedIndex = 0;
                    ShowJob(cmb_categories.SelectedItem.ToString());
                }

            }
            else
            {
                cmb_categories.Enabled = false;
                cmb_job.Enabled = false;
                cmb_categories.Items.Clear();
                cmb_job.Items.Clear();
                modify_complete = false;
            }
            
        }

        private void cb_cat_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cat_search.SelectedItem.ToString() == "Administración y Alto Mando")
            {
                this.dgv_employees.DataSource = MEmployeer.ShowEmployeerAd();
                
            }
            else
            {
                this.dgv_employees.DataSource = MEmployeer.ShowEmployeer();
                
            }
        }

        private void cmb_job_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
