namespace reportes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.pr_obtenerPaisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DUADataSet = new reportes.DUADataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pr_obtenerPaisesTableAdapter = new reportes.DUADataSetTableAdapters.pr_obtenerPaisesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pr_obtenerPaisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DUADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pr_obtenerPaisesBindingSource
            // 
            this.pr_obtenerPaisesBindingSource.DataMember = "pr_obtenerPaises";
            this.pr_obtenerPaisesBindingSource.DataSource = this.DUADataSet;
            // 
            // DUADataSet
            // 
            this.DUADataSet.DataSetName = "DUADataSet";
            this.DUADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPaises";
            reportDataSource1.Value = this.pr_obtenerPaisesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(917, 386);
            this.reportViewer1.TabIndex = 0;
            // 
            // pr_obtenerPaisesTableAdapter
            // 
            this.pr_obtenerPaisesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 386);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pr_obtenerPaisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DUADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pr_obtenerPaisesBindingSource;
        private DUADataSet DUADataSet;
        private DUADataSetTableAdapters.pr_obtenerPaisesTableAdapter pr_obtenerPaisesTableAdapter;
    }
}

