namespace ReportePrestamos.Reportes
{
    partial class ReporteForm1
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
            this.prestamoDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoDBDataSet = new ReportePrestamos.PrestamoDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // prestamoDBDataSetBindingSource
            // 
            this.prestamoDBDataSetBindingSource.DataSource = this.prestamoDBDataSet;
            this.prestamoDBDataSetBindingSource.Position = 0;
            // 
            // prestamoDBDataSet
            // 
            this.prestamoDBDataSet.DataSetName = "PrestamoDBDataSet";
            this.prestamoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.prestamoDBDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportePrestamos.Reportes.reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReporteForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteForm1";
            this.Text = "ReporteForm1";
            this.Load += new System.EventHandler(this.ReporteForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PrestamoDBDataSet prestamoDBDataSet;
        private System.Windows.Forms.BindingSource prestamoDBDataSetBindingSource;
    }
}