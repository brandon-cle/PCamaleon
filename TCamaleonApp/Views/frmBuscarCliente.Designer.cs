﻿
namespace TCamaleonApp.Views
{
    partial class frmBuscarCliente
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dtCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(285, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 24);
            this.textBox1.TabIndex = 5;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(350, 279);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(145, 23);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dtCliente
            // 
            this.dtCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.dtCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCliente.Location = new System.Drawing.Point(63, 51);
            this.dtCliente.Name = "dtCliente";
            this.dtCliente.RowHeadersWidth = 51;
            this.dtCliente.Size = new System.Drawing.Size(675, 221);
            this.dtCliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese el dato a buscar";
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dtCliente);
            this.Name = "frmBuscarCliente";
            this.Text = "frmBuscarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSeleccionar;
        public System.Windows.Forms.DataGridView dtCliente;
        private System.Windows.Forms.Label label1;
    }
}