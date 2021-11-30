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
            this.ContentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
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
            this.ContentPanel.Size = new System.Drawing.Size(1135, 617);
            this.ContentPanel.TabIndex = 0;
            // 
            // panel_painting
            // 
            this.panel_painting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_painting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_painting.Location = new System.Drawing.Point(265, 34);
            this.panel_painting.Name = "panel_painting";
            this.panel_painting.Size = new System.Drawing.Size(870, 583);
            this.panel_painting.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btn_employees);
            this.panel2.Controls.Add(this.btn_Service);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 583);
            this.panel2.TabIndex = 1;
            // 
            // btn_employees
            // 
            this.btn_employees.Location = new System.Drawing.Point(0, 269);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(265, 58);
            this.btn_employees.TabIndex = 1;
            this.btn_employees.Text = "Empleados";
            this.btn_employees.UseVisualStyleBackColor = true;
            // 
            // btn_Service
            // 
            this.btn_Service.Location = new System.Drawing.Point(0, 215);
            this.btn_Service.Name = "btn_Service";
            this.btn_Service.Size = new System.Drawing.Size(265, 58);
            this.btn_Service.TabIndex = 0;
            this.btn_Service.Text = "Servicio";
            this.btn_Service.UseVisualStyleBackColor = true;
            this.btn_Service.Click += new System.EventHandler(this.btn_Service_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 34);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Image = global::TCamaleonApp.Properties.Resources.close;
            this.btn_close.Location = new System.Drawing.Point(1102, 3);
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
            this.btn_minimize.Location = new System.Drawing.Point(1067, 4);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(29, 28);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 617);
            this.Controls.Add(this.ContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "0";
            this.ContentPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
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
    }
}