namespace TCamaleonApp.Views
{
    partial class FormBase_Servicios
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
            this.btn_S_search = new System.Windows.Forms.Button();
            this.btn_S_Insert = new System.Windows.Forms.Button();
            this.pnl_openForm = new System.Windows.Forms.Panel();
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
            this.pnl_Content.Location = new System.Drawing.Point(-59, -43);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(965, 572);
            this.pnl_Content.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btn_S_search);
            this.panel1.Controls.Add(this.btn_S_Insert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(747, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 572);
            this.panel1.TabIndex = 0;
            // 
            // btn_S_search
            // 
            this.btn_S_search.Location = new System.Drawing.Point(18, 138);
            this.btn_S_search.Name = "btn_S_search";
            this.btn_S_search.Size = new System.Drawing.Size(180, 47);
            this.btn_S_search.TabIndex = 1;
            this.btn_S_search.Text = "Buscar Servicio";
            this.btn_S_search.UseVisualStyleBackColor = true;
            // 
            // btn_S_Insert
            // 
            this.btn_S_Insert.Location = new System.Drawing.Point(18, 56);
            this.btn_S_Insert.Name = "btn_S_Insert";
            this.btn_S_Insert.Size = new System.Drawing.Size(180, 49);
            this.btn_S_Insert.TabIndex = 0;
            this.btn_S_Insert.Text = "Nuevo servicio";
            this.btn_S_Insert.UseVisualStyleBackColor = true;
            // 
            // pnl_openForm
            // 
            this.pnl_openForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_openForm.Location = new System.Drawing.Point(64, 55);
            this.pnl_openForm.Name = "pnl_openForm";
            this.pnl_openForm.Size = new System.Drawing.Size(677, 514);
            this.pnl_openForm.TabIndex = 2;
            // 
            // FormBase_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 541);
            this.Controls.Add(this.pnl_Content);
            this.Name = "FormBase_Servicios";
            this.Text = "FormBase_Servicios";
            this.pnl_Content.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Content;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_S_search;
        private System.Windows.Forms.Button btn_S_Insert;
        private System.Windows.Forms.Panel pnl_openForm;
    }
}