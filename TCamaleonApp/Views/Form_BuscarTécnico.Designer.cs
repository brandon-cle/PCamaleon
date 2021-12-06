
namespace TCamaleonApp.Views
{
    partial class Form_BuscarTécnico
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
            this.dgv_técnico = new System.Windows.Forms.DataGridView();
            this.txt_searcher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_técnico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_técnico
            // 
            this.dgv_técnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_técnico.Location = new System.Drawing.Point(28, 89);
            this.dgv_técnico.Name = "dgv_técnico";
            this.dgv_técnico.RowHeadersWidth = 51;
            this.dgv_técnico.RowTemplate.Height = 24;
            this.dgv_técnico.Size = new System.Drawing.Size(745, 334);
            this.dgv_técnico.TabIndex = 0;
            this.dgv_técnico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_técnico.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_técnico_RowHeaderMouseDoubleClick);
            // 
            // txt_searcher
            // 
            this.txt_searcher.Location = new System.Drawing.Point(28, 56);
            this.txt_searcher.Name = "txt_searcher";
            this.txt_searcher.Size = new System.Drawing.Size(300, 22);
            this.txt_searcher.TabIndex = 1;
            this.txt_searcher.TextChanged += new System.EventHandler(this.txt_searcher_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione al técnico automotriz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscador:";
            // 
            // Form_BuscarTécnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_searcher);
            this.Controls.Add(this.dgv_técnico);
            this.Name = "Form_BuscarTécnico";
            this.Text = "Form_BuscarEmpleado";
            this.Load += new System.EventHandler(this.Form_BuscarTécnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_técnico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_técnico;
        private System.Windows.Forms.TextBox txt_searcher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}