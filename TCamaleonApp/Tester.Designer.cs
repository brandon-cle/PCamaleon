
namespace TCamaleonApp
{
    partial class Tester
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PuestosTable = new TCamaleonApp.PuestosTable();
            this.PuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PuestoTableAdapter = new TCamaleonApp.PuestosTableTableAdapters.PuestoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PuestosTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataPuestos";
            reportDataSource1.Value = this.PuestoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TCamaleonApp.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(112, 74);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(610, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // PuestosTable
            // 
            this.PuestosTable.DataSetName = "PuestosTable";
            this.PuestosTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PuestoBindingSource
            // 
            this.PuestoBindingSource.DataMember = "Puesto";
            this.PuestoBindingSource.DataSource = this.PuestosTable;
            // 
            // PuestoTableAdapter
            // 
            this.PuestoTableAdapter.ClearBeforeFill = true;
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Tester";
            this.Text = "Tester";
            this.Load += new System.EventHandler(this.Tester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PuestosTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuestoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PuestoBindingSource;
        private PuestosTable PuestosTable;
        private PuestosTableTableAdapters.PuestoTableAdapter PuestoTableAdapter;
    }
}