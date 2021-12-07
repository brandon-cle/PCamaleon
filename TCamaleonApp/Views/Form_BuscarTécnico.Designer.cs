
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
            this.txt_searcher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtMecanico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtMecanico)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_searcher
            // 
            this.txt_searcher.Location = new System.Drawing.Point(21, 46);
            this.txt_searcher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_searcher.Name = "txt_searcher";
            this.txt_searcher.Size = new System.Drawing.Size(226, 20);
            this.txt_searcher.TabIndex = 1;
            this.txt_searcher.TextChanged += new System.EventHandler(this.txt_searcher_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione al técnico automotriz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscador:";
            // 
            // dtMecanico
            // 
            this.dtMecanico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtMecanico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMecanico.Location = new System.Drawing.Point(22, 81);
            this.dtMecanico.Margin = new System.Windows.Forms.Padding(2);
            this.dtMecanico.Name = "dtMecanico";
            this.dtMecanico.RowHeadersWidth = 51;
            this.dtMecanico.RowTemplate.Height = 24;
            this.dtMecanico.Size = new System.Drawing.Size(549, 255);
            this.dtMecanico.TabIndex = 4;
            this.dtMecanico.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtMecanico_RowHeaderMouseDoubleClick);
            // 
            // Form_BuscarTécnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dtMecanico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_searcher);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_BuscarTécnico";
            this.Text = "Form_BuscarEmpleado";
            this.Load += new System.EventHandler(this.Form_BuscarTécnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMecanico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_searcher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtMecanico;
    }
}