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
        bool modify_u = false;
        string IDglobalmodify_u = null;
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            dgv_users.AllowUserToAddRows = false;
            this.dgv_users.DataSource =  CUsuario.MostrarUsuarios();
        }

        private void btn_suser_Click(object sender, EventArgs e)
        {
            if (modify_u)
            {
                CUsuario.ActualizarUsuario(txt_username.Text, txt_password.Text, status_parameter_u(), IDglobalmodify_u);
                modify_u = false;
            }
            else
            {
                CUsuario.InsertarUsuario(txt_username.Text, txt_password.Text, txt_ide.Text);
            }
            
        }

        private void btn_muser_Click(object sender, EventArgs e)
        {
            modify_u = true;
            if (this.dgv_users.SelectedRows.Count == 1)
            {
                IDglobalmodify_u = Convert.ToString(this.dgv_users.CurrentRow.Cells["ID Usuario"].Value);
                this.txt_username.Text = Convert.ToString(this.dgv_users.CurrentRow.Cells["Nombre de Usuario"].Value);
                if (Convert.ToString(this.dgv_users.CurrentRow.Cells["Estado"].Value) == "Habilitado") rbtn_on.Checked = true;
                if (Convert.ToString(this.dgv_users.CurrentRow.Cells["Estado"].Value) == "Deshabilitado") rbtn_on.Checked = true;
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
        }
    }
}
