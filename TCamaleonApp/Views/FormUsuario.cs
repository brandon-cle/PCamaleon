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
    public partial class FormUsuario : Form
    {

        public static string globalID_toChange = null;
        bool modify_u = false;
        string IDglobalmodify_u = null;
        public FormUsuario()
        {
            InitializeComponent();
            this.btn_suser_mod.Visible = false;
            this.checkBox1.Visible = false;
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            dgv_users.AllowUserToAddRows = false;
            this.dgv_users.DataSource = CUsuario.MostrarUsuarios();
        }

        private void btn_suser_Click(object sender, EventArgs e)
        {
            if (modify_u && txt_password_confirmed.Text == txt_password.Text)
            {
                CUsuario.ActualizarUsuario(txt_username.Text, txt_password.Text, status_parameter_u(), IDglobalmodify_u);
                this.dgv_users.DataSource = CUsuario.MostrarUsuarios();
                Clean();

                txt_ide.Enabled = false;
                txt_username.Enabled = false;
                txt_password.Enabled = false;
                txt_password_confirmed.Enabled = false;
                rbtn_on.Enabled = false;
                rbtn_off.Enabled = false;
                btn_suser.Enabled = false;
                btn_nuser.Enabled = true;
                modify_u = false;
              
            }
            else
            {
                if(txt_password.Text == txt_password_confirmed.Text)
                {
                    CUsuario.InsertarUsuario(txt_username.Text, txt_password.Text, txt_ide.Text);
                    Clean();
                    this.dgv_users.DataSource = CUsuario.MostrarUsuarios();
                    txt_ide.Enabled = false;
                    txt_username.Enabled = false;
                    txt_password.Enabled = false;
                    txt_password_confirmed.Enabled = false;
                    rbtn_on.Enabled = false;
                    rbtn_off.Enabled = false;
                    btn_suser.Enabled = false;
                    modify_u = false;
                    return;
                }
                {
                    MessageBox.Show("Verifique que haya escrito bien la contraseña en la confirmación de esta", "Su buen mecánico le informa", MessageBoxButtons.OK);
                    return;
                }

                
                MessageBox.Show("Verifique que haya escrito bien la contraseña en la confirmación de esta", "Su buen mecánico le informa", MessageBoxButtons.OK);
                return;
                
            }

        }

        private void btn_muser_Click(object sender, EventArgs e)
        {
            modify_u = true;
            btn_cancel.Enabled = true;
            if (this.dgv_users.SelectedRows.Count == 1)
            {
                btn_muser.Enabled = false;
                IDglobalmodify_u = Convert.ToString(this.dgv_users.CurrentRow.Cells["ID Usuario"].Value);
                //txt_ide.Enabled = true;
                txt_ide.Text = IDglobalmodify_u;
                txt_ide.Enabled = false;
                ////////////////////////////////////////////////
                txt_username.Enabled = true;
                rbtn_on.Enabled = true;
                rbtn_off.Enabled = true;
                btn_suser.Enabled = true;
                btn_suser_mod.Visible = true;
                btn_suser_mod.Enabled = true;
                checkBox1.Visible = true;
                

                this.txt_username.Text = Convert.ToString(this.dgv_users.CurrentRow.Cells["Nombre de Usuario"].Value);

                if (Convert.ToString(this.dgv_users.CurrentRow.Cells["Estado"].Value) == "Habilitado") rbtn_on.Checked = true;
                if (Convert.ToString(this.dgv_users.CurrentRow.Cells["Estado"].Value) == "Deshabilitado") rbtn_on.Checked = true;
            }
            else
            {
                MessageBox.Show("Seleccione solo una fila para el procedimiento", "Su buen mecánico le dice", MessageBoxButtons.OK);
                dgv_users.ClearSelection();
            }
        }

        public string status_parameter_u()
        {
            string status = null;
            if (rbtn_on.Checked) status = "Habilitado";
            if (rbtn_off.Checked) status = "Deshabilitado";
            return status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_sEmployeerAd frm_sEmployeerAd = new Form_sEmployeerAd();
            frm_sEmployeerAd.ShowDialog();
            if(globalID_toChange != null)
            {
                txt_ide.Text = globalID_toChange;
            }
            else
            {
                return;
            }
            
        }

        private void btn_nuser_Click(object sender, EventArgs e)
        {
            Clean();
            btn_nuser.Enabled = false;
            bool modify_u = false;
            txt_ide.Enabled = false;
            txt_username.Enabled = true;
            txt_password.Enabled = true;
            txt_password_confirmed.Enabled = true;
            rbtn_on.Enabled = true;
            rbtn_off.Enabled = true;
            btn_suser.Enabled = true;
            btn_cancel.Enabled = true;
            button1.Enabled = true;
        }


        public void Clean()
        {
            txt_ide.Text = null;
            txt_username.Text = null;
            txt_password.Text = null;
            txt_password_confirmed.Text = null;
        }

        private void dgv_users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dgv_users.SelectedRows.Count == 1)
            {
                btn_muser.Enabled = true;
            }
            else
            {
                btn_muser.Enabled = false;
            }
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            modify_u = false;
            Clean();
            txt_ide.Enabled = false;
            txt_username.Enabled = false;
            txt_password.Enabled = false;
            txt_password_confirmed.Enabled = false;
            rbtn_on.Enabled = false;
            rbtn_off.Enabled = false;
            btn_suser.Enabled = false;
            IDglobalmodify_u = null;
            globalID_toChange = null;
            btn_suser_mod.Visible = false;
            btn_nuser.Enabled = true;
            this.checkBox1.Visible = false;
            globalID_toChange = null;
        }

        private void btn_suser_mod_Click(object sender, EventArgs e)
        {

            if (modify_u && txt_password_confirmed.Text == txt_password.Text)
            {
                CUsuario.ActualizarUsuario(txt_username.Text, txt_password.Text, status_parameter_u(), IDglobalmodify_u);
                this.dgv_users.DataSource = CUsuario.MostrarUsuarios();

                Clean();
                txt_ide.Enabled = false;
                txt_username.Enabled = false;
                txt_password.Enabled = false;
                txt_password_confirmed.Enabled = false;
                rbtn_on.Enabled = false;
                rbtn_off.Enabled = false;
                btn_suser.Enabled = false;
                modify_u = false;
                btn_suser_mod.Visible = false;
                btn_nuser.Enabled = true;
                this.checkBox1.Visible = false;
            }
            else
            {
                if (txt_password == txt_password_confirmed)
                {
                    CUsuario.InsertarUsuario(txt_username.Text, txt_password.Text, txt_ide.Text);
                    this.dgv_users.DataSource = CUsuario.MostrarUsuarios();
                    return;
                }
                {
                    MessageBox.Show("Verifique que haya escrito bien la contraseña en la confirmación de esta", "Su buen mecánico le informa", MessageBoxButtons.OK);

                }


                MessageBox.Show("Verifique que haya escrito bien la contraseña en la confirmación de esta", "Su buen mecánico le informa", MessageBoxButtons.OK);
                return;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_password.Enabled = true;
                txt_password_confirmed.Enabled = true;
            }
            else
            {
                if(txt_password.Text != null && txt_password_confirmed.Text != null)
                {
                    txt_password.Text = null;
                    txt_password_confirmed.Text = null;
                }
                txt_password.Enabled = false;
                txt_password_confirmed.Enabled = false;
            }
        }

        private void txt_user_searcher_TextChanged(object sender, EventArgs e)
        {
            this.dgv_users.DataSource = CUsuario.BuscarUsuarios(this.txt_user_searcher.Text);
        }
    }
}
