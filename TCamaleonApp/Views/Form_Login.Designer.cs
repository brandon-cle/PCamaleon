
namespace TCamaleonApp.Views
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTop_lobby = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancel_l = new System.Windows.Forms.PictureBox();
            this.btn_minus_l = new System.Windows.Forms.PictureBox();
            this.pnlTop_lobby.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel_l)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minus_l)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(164, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_password.Location = new System.Drawing.Point(104, 352);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(192, 20);
            this.txt_password.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(149, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre de usuario";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_username.Location = new System.Drawing.Point(104, 275);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(192, 20);
            this.txt_username.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlTop_lobby
            // 
            this.pnlTop_lobby.Controls.Add(this.btn_cancel_l);
            this.pnlTop_lobby.Controls.Add(this.btn_minus_l);
            this.pnlTop_lobby.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop_lobby.Location = new System.Drawing.Point(0, 0);
            this.pnlTop_lobby.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop_lobby.Name = "pnlTop_lobby";
            this.pnlTop_lobby.Size = new System.Drawing.Size(408, 32);
            this.pnlTop_lobby.TabIndex = 15;
            this.pnlTop_lobby.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_lobby_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancel_l
            // 
            this.btn_cancel_l.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel_l.Image")));
            this.btn_cancel_l.Location = new System.Drawing.Point(378, 4);
            this.btn_cancel_l.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel_l.Name = "btn_cancel_l";
            this.btn_cancel_l.Size = new System.Drawing.Size(30, 26);
            this.btn_cancel_l.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cancel_l.TabIndex = 15;
            this.btn_cancel_l.TabStop = false;
            this.btn_cancel_l.Click += new System.EventHandler(this.btn_cancel_l_Click);
            // 
            // btn_minus_l
            // 
            this.btn_minus_l.Image = ((System.Drawing.Image)(resources.GetObject("btn_minus_l.Image")));
            this.btn_minus_l.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_minus_l.InitialImage")));
            this.btn_minus_l.Location = new System.Drawing.Point(352, 4);
            this.btn_minus_l.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minus_l.Name = "btn_minus_l";
            this.btn_minus_l.Size = new System.Drawing.Size(22, 26);
            this.btn_minus_l.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minus_l.TabIndex = 14;
            this.btn_minus_l.TabStop = false;
            this.btn_minus_l.Click += new System.EventHandler(this.btn_minus_l_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(408, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlTop_lobby);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.pnlTop_lobby.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel_l)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minus_l)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_minus_l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTop_lobby;
        private System.Windows.Forms.PictureBox btn_cancel_l;
    }
}