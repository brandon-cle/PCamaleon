namespace TCamaleonApp.Views
{
    partial class frmBuscarRepuesto
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dtRepuesto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtRepuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ingrese el dato a buscar";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(336, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 24);
            this.textBox1.TabIndex = 15;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(361, 306);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(145, 23);
            this.btnSeleccionar.TabIndex = 18;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dtRepuesto
            // 
            this.dtRepuesto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.dtRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRepuesto.Location = new System.Drawing.Point(74, 78);
            this.dtRepuesto.Name = "dtRepuesto";
            this.dtRepuesto.RowHeadersWidth = 51;
            this.dtRepuesto.Size = new System.Drawing.Size(675, 221);
            this.dtRepuesto.TabIndex = 17;
            // 
            // frmBuscarRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dtRepuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmBuscarRepuesto";
            this.Text = "frmBuscarRepuesto";
            ((System.ComponentModel.ISupportInitialize)(this.dtRepuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSeleccionar;
        public System.Windows.Forms.DataGridView dtRepuesto;
    }
}