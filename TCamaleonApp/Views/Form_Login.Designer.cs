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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTop_lobby = new System.Windows.Forms.Panel();
            this.btn_cancel_l = new System.Windows.Forms.PictureBox();
            this.btn_minus_l = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel_l)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minus_l)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_username.Location = new System.Drawing.Point(162, 352);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(255, 22);
            this.txt_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(223, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de usuario";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_password.Location = new System.Drawing.Point(162, 447);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(255, 22);
            this.txt_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(242, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // pnlTop_lobby
            // 
            this.pnlTop_lobby.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop_lobby.Location = new System.Drawing.Point(0, 0);
            this.pnlTop_lobby.Name = "pnlTop_lobby";
            this.pnlTop_lobby.Size = new System.Drawing.Size(566, 40);
            this.pnlTop_lobby.TabIndex = 7;
            this.pnlTop_lobby.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_lobby_Paint);
            this.pnlTop_lobby.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_lobby_MouseMove);
            // 
            // btn_cancel_l
            // 
            this.btn_cancel_l.Image = global::TCamaleonApp.Properties.Resources._2791696;
            this.btn_cancel_l.Location = new System.Drawing.Point(523, 4);
            this.btn_cancel_l.Name = "btn_cancel_l";
            this.btn_cancel_l.Size = new System.Drawing.Size(40, 32);
            this.btn_cancel_l.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cancel_l.TabIndex = 6;
            this.btn_cancel_l.TabStop = false;
            this.btn_cancel_l.Click += new System.EventHandler(this.btn_cancel_l_Click);
            // 
            // btn_minus_l
            // 
            this.btn_minus_l.Image = global::TCamaleonApp.Properties.Resources.negative;
            this.btn_minus_l.Location = new System.Drawing.Point(488, 4);
            this.btn_minus_l.Name = "btn_minus_l";
            this.btn_minus_l.Size = new System.Drawing.Size(29, 32);
            this.btn_minus_l.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minus_l.TabIndex = 5;
            this.btn_minus_l.TabStop = false;
            this.btn_minus_l.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCamaleonApp.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(108, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(566, 615);
            this.Controls.Add(this.btn_cancel_l);
            this.Controls.Add(this.btn_minus_l);
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel_l)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minus_l)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_minus_l;
        private System.Windows.Forms.PictureBox btn_cancel_l;
        private System.Windows.Forms.Panel pnlTop_lobby;
    }
}