namespace TCamaleonApp.Views
{
    partial class FormBaseEmployees
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
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_openForm = new System.Windows.Forms.Panel();
            this.btn_E_Insert = new System.Windows.Forms.Button();
            this.btn_E_searcher = new System.Windows.Forms.Button();
            this.pnl_Content.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Content
            // 
            this.pnl_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Content.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Content.Controls.Add(this.pnl_openForm);
            this.pnl_Content.Controls.Add(this.panel1);
            this.pnl_Content.Location = new System.Drawing.Point(9, 8);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(902, 535);
            this.pnl_Content.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btn_E_searcher);
            this.panel1.Controls.Add(this.btn_E_Insert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(684, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 535);
            this.panel1.TabIndex = 0;
            // 
            // pnl_openForm
            // 
            this.pnl_openForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_openForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_openForm.Location = new System.Drawing.Point(3, 4);
            this.pnl_openForm.Name = "pnl_openForm";
            this.pnl_openForm.Size = new System.Drawing.Size(673, 526);
            this.pnl_openForm.TabIndex = 1;
            // 
            // btn_E_Insert
            // 
            this.btn_E_Insert.Location = new System.Drawing.Point(18, 56);
            this.btn_E_Insert.Name = "btn_E_Insert";
            this.btn_E_Insert.Size = new System.Drawing.Size(180, 49);
            this.btn_E_Insert.TabIndex = 0;
            this.btn_E_Insert.Text = "Nuevo empleado";
            this.btn_E_Insert.UseVisualStyleBackColor = true;
            this.btn_E_Insert.Click += new System.EventHandler(this.btn_E_Insert_Click);
            // 
            // btn_E_searcher
            // 
            this.btn_E_searcher.Location = new System.Drawing.Point(18, 138);
            this.btn_E_searcher.Name = "btn_E_searcher";
            this.btn_E_searcher.Size = new System.Drawing.Size(180, 47);
            this.btn_E_searcher.TabIndex = 1;
            this.btn_E_searcher.Text = "Buscar empleado";
            this.btn_E_searcher.UseVisualStyleBackColor = true;
            this.btn_E_searcher.Click += new System.EventHandler(this.btn_E_Searcher_Click);
            // 
            // FormBaseEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 551);
            this.Controls.Add(this.pnl_Content);
            this.Name = "FormBaseEmployees";
            this.Text = "FormBaseEmployees";
            this.pnl_Content.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Panel pnl_openForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_E_searcher;
        private System.Windows.Forms.Button btn_E_Insert;
    }
}