namespace TCamaleonApp.Views
{
    partial class Form_sEmployeerAd
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
            this.dgv_employeesS = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeesS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_employeesS
            // 
            this.dgv_employeesS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_employeesS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employeesS.Location = new System.Drawing.Point(28, 70);
            this.dgv_employeesS.Name = "dgv_employeesS";
            this.dgv_employeesS.RowHeadersWidth = 51;
            this.dgv_employeesS.RowTemplate.Height = 24;
            this.dgv_employeesS.Size = new System.Drawing.Size(968, 353);
            this.dgv_employeesS.TabIndex = 1;
            this.dgv_employeesS.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_employeesS_RowHeaderMouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona la fila del empleado a registar";
            // 
            // Form_sEmployeerAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_employeesS);
            this.Name = "Form_sEmployeerAd";
            this.Text = "Form_sEmployeerAd";
            this.Load += new System.EventHandler(this.Form_sEmployeerAd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employeesS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_employeesS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}