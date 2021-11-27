
namespace TCamaleonApp.Views
{
    partial class EmployeeSearcher
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
            this.dgv_employees = new System.Windows.Forms.DataGridView();
            this.txt_employeeS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_employees
            // 
            this.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employees.Location = new System.Drawing.Point(32, 99);
            this.dgv_employees.Name = "dgv_employees";
            this.dgv_employees.Size = new System.Drawing.Size(636, 217);
            this.dgv_employees.TabIndex = 0;
            // 
            // txt_employeeS
            // 
            this.txt_employeeS.Location = new System.Drawing.Point(32, 58);
            this.txt_employeeS.Name = "txt_employeeS";
            this.txt_employeeS.Size = new System.Drawing.Size(232, 20);
            this.txt_employeeS.TabIndex = 1;
            this.txt_employeeS.TextChanged += new System.EventHandler(this.txt_employeeS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduzca dato a buscar:";
            // 
            // EmployeeSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_employeeS);
            this.Controls.Add(this.dgv_employees);
            this.Name = "EmployeeSearcher";
            this.Text = "EmployeeSearcher";
            this.Load += new System.EventHandler(this.EmployeeSearcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_employees;
        private System.Windows.Forms.TextBox txt_employeeS;
        private System.Windows.Forms.Label label1;
    }
}