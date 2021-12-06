using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCamaleonApp.Controller;

namespace TCamaleonApp.Views
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_minus_l_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cancel_l_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            this.txt_username.Focus();
        }

        private void pnlTop_lobby_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            


                DataTable dato;
                dato = CUsuario.ValidarAcceso(this.txt_username.Text, this.txt_password.Text);
                if (dato == null)
                {
                    MessageBox.Show("No hay Conexión al Servidor", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                 if (dato.Rows.Count > 0)
                {

                if (dato.Rows[0][0].ToString() == "Green flag")
                {
                    Lobby lobby = new Lobby();
                    lobby.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La contraseña o el nombre de usuario no coinciden", "Aviso de tu buen mecánico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_username.Text = string.Empty;
                    this.txt_password.Text = string.Empty;
                    this.txt_username.Focus();

                }

            }
        }
    }
}
