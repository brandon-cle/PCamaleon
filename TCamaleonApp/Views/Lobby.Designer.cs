namespace TCamaleonApp.Views
{
    partial class Lobby
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.panel_painting = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_employees = new System.Windows.Forms.Button();
            this.btn_Service = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dl_username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dl_roluser = new System.Windows.Forms.Label();
            this.ContentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ContentPanel.Controls.Add(this.panel_painting);
            this.ContentPanel.Controls.Add(this.panel2);
            this.ContentPanel.Controls.Add(this.panel1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1155, 692);
            this.ContentPanel.TabIndex = 0;
            // 
            // panel_painting
            // 
            this.panel_painting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_painting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_painting.Location = new System.Drawing.Point(265, 34);
            this.panel_painting.Name = "panel_painting";
            this.panel_painting.Size = new System.Drawing.Size(890, 658);
            this.panel_painting.TabIndex = 2;
            this.panel_painting.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_painting_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.dl_roluser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dl_username);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_employees);
            this.panel2.Controls.Add(this.btn_Service);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 658);
            this.panel2.TabIndex = 1;
            // 
            // btn_employees
            // 
            this.btn_employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btn_employees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_employees.FlatAppearance.BorderSize = 0;
            this.btn_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.btn_employees.Location = new System.Drawing.Point(0, 438);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(265, 58);
            this.btn_employees.TabIndex = 1;
            this.btn_employees.Text = "Empleados";
            this.btn_employees.UseVisualStyleBackColor = false;
            this.btn_employees.Click += new System.EventHandler(this.btn_Empleado_Click);
            // 
            // btn_Service
            // 
            this.btn_Service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btn_Service.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Service.FlatAppearance.BorderSize = 0;
            this.btn_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Service.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.btn_Service.Location = new System.Drawing.Point(0, 246);
            this.btn_Service.Name = "btn_Service";
            this.btn_Service.Size = new System.Drawing.Size(265, 58);
            this.btn_Service.TabIndex = 0;
            this.btn_Service.Text = "Servicio";
            this.btn_Service.UseVisualStyleBackColor = false;
            this.btn_Service.Click += new System.EventHandler(this.btn_Service_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 34);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Image = global::TCamaleonApp.Properties.Resources.close;
            this.btn_close.Location = new System.Drawing.Point(1122, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 29);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_close.TabIndex = 0;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.Image = global::TCamaleonApp.Properties.Resources.minus;
            this.btn_minimize.Location = new System.Drawing.Point(1087, 4);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(29, 28);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.button1.Location = new System.Drawing.Point(0, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cliente";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.button2.Location = new System.Drawing.Point(0, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Usuario";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.button3.Location = new System.Drawing.Point(0, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 58);
            this.button3.TabIndex = 4;
            this.button3.Text = "Factura";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.button4.Location = new System.Drawing.Point(3, 600);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(265, 58);
            this.button4.TabIndex = 5;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 77);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(116, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de usuario:";
            // 
            // dl_username
            // 
            this.dl_username.AutoSize = true;
            this.dl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.dl_username.Location = new System.Drawing.Point(116, 52);
            this.dl_username.Name = "dl_username";
            this.dl_username.Size = new System.Drawing.Size(67, 16);
            this.dl_username.TabIndex = 8;
            this.dl_username.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(116, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo de cuenta:";
            // 
            // dl_roluser
            // 
            this.dl_roluser.AutoSize = true;
            this.dl_roluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.dl_roluser.Location = new System.Drawing.Point(116, 97);
            this.dl_roluser.Name = "dl_roluser";
            this.dl_roluser.Size = new System.Drawing.Size(48, 16);
            this.dl_roluser.TabIndex = 10;
            this.dl_roluser.Text = "roluser";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 692);
            this.Controls.Add(this.ContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "0";
            this.ContentPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel panel_painting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button btn_Service;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label dl_roluser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dl_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}