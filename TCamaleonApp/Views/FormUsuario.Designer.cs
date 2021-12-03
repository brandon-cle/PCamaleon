﻿namespace TCamaleonApp.Views
{
    partial class FormUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_muser = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_user_searcher = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtn_off = new System.Windows.Forms.RadioButton();
            this.rbtn_on = new System.Windows.Forms.RadioButton();
            this.btn_suser = new System.Windows.Forms.Button();
            this.btn_nuser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ide = new System.Windows.Forms.TextBox();
            this.txt_password_confirmed = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dgv_users);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 660);
            this.panel1.TabIndex = 0;
            // 
            // dgv_users
            // 
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_users.Location = new System.Drawing.Point(0, 100);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.RowHeadersWidth = 51;
            this.dgv_users.RowTemplate.Height = 24;
            this.dgv_users.Size = new System.Drawing.Size(887, 460);
            this.dgv_users.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.btn_muser);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 560);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(887, 100);
            this.panel4.TabIndex = 2;
            // 
            // btn_muser
            // 
            this.btn_muser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_muser.Location = new System.Drawing.Point(21, 28);
            this.btn_muser.Name = "btn_muser";
            this.btn_muser.Size = new System.Drawing.Size(154, 46);
            this.btn_muser.TabIndex = 11;
            this.btn_muser.Text = "Modificar usuario";
            this.btn_muser.UseVisualStyleBackColor = true;
            this.btn_muser.Click += new System.EventHandler(this.btn_muser_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_user_searcher);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 100);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscador:";
            // 
            // txt_user_searcher
            // 
            this.txt_user_searcher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_user_searcher.Location = new System.Drawing.Point(12, 54);
            this.txt_user_searcher.Name = "txt_user_searcher";
            this.txt_user_searcher.Size = new System.Drawing.Size(248, 22);
            this.txt_user_searcher.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rbtn_off);
            this.panel2.Controls.Add(this.rbtn_on);
            this.panel2.Controls.Add(this.btn_suser);
            this.panel2.Controls.Add(this.btn_nuser);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_ide);
            this.panel2.Controls.Add(this.txt_password_confirmed);
            this.panel2.Controls.Add(this.txt_password);
            this.panel2.Controls.Add(this.txt_username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(887, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 660);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Actividad del usuario:";
            // 
            // rbtn_off
            // 
            this.rbtn_off.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbtn_off.AutoSize = true;
            this.rbtn_off.Location = new System.Drawing.Point(126, 401);
            this.rbtn_off.Name = "rbtn_off";
            this.rbtn_off.Size = new System.Drawing.Size(100, 20);
            this.rbtn_off.TabIndex = 12;
            this.rbtn_off.TabStop = true;
            this.rbtn_off.Text = "Deshabilitar";
            this.rbtn_off.UseVisualStyleBackColor = true;
            // 
            // rbtn_on
            // 
            this.rbtn_on.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbtn_on.AutoSize = true;
            this.rbtn_on.Location = new System.Drawing.Point(22, 401);
            this.rbtn_on.Name = "rbtn_on";
            this.rbtn_on.Size = new System.Drawing.Size(78, 20);
            this.rbtn_on.TabIndex = 11;
            this.rbtn_on.TabStop = true;
            this.rbtn_on.Text = "Habilitar";
            this.rbtn_on.UseVisualStyleBackColor = true;
            // 
            // btn_suser
            // 
            this.btn_suser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_suser.Location = new System.Drawing.Point(155, 471);
            this.btn_suser.Name = "btn_suser";
            this.btn_suser.Size = new System.Drawing.Size(105, 46);
            this.btn_suser.TabIndex = 10;
            this.btn_suser.Text = "Guardar usuario";
            this.btn_suser.UseVisualStyleBackColor = true;
            this.btn_suser.Click += new System.EventHandler(this.btn_suser_Click);
            // 
            // btn_nuser
            // 
            this.btn_nuser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_nuser.Location = new System.Drawing.Point(22, 471);
            this.btn_nuser.Name = "btn_nuser";
            this.btn_nuser.Size = new System.Drawing.Size(105, 46);
            this.btn_nuser.TabIndex = 9;
            this.btn_nuser.Text = "Nuevo usuario";
            this.btn_nuser.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID del empleado";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(169, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vuelva a introducir la contraseña:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de usuario:";
            // 
            // txt_ide
            // 
            this.txt_ide.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_ide.Location = new System.Drawing.Point(58, 141);
            this.txt_ide.Name = "txt_ide";
            this.txt_ide.Size = new System.Drawing.Size(104, 22);
            this.txt_ide.TabIndex = 3;
            // 
            // txt_password_confirmed
            // 
            this.txt_password_confirmed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_password_confirmed.Location = new System.Drawing.Point(22, 338);
            this.txt_password_confirmed.Name = "txt_password_confirmed";
            this.txt_password_confirmed.Size = new System.Drawing.Size(235, 22);
            this.txt_password_confirmed.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_password.Location = new System.Drawing.Point(22, 286);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(235, 22);
            this.txt_password.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_username.Location = new System.Drawing.Point(22, 231);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(235, 22);
            this.txt_username.TabIndex = 0;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 660);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_muser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_user_searcher;
        private System.Windows.Forms.Button btn_suser;
        private System.Windows.Forms.Button btn_nuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ide;
        private System.Windows.Forms.TextBox txt_password_confirmed;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtn_off;
        private System.Windows.Forms.RadioButton rbtn_on;
    }
}