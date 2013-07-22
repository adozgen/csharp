namespace WindowsFormsApplication2
{
    partial class makrapor2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(makrapor2));
            this.makinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MTSDataSet1 = new WindowsFormsApplication2.MTSDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.makinaTableAdapter = new WindowsFormsApplication2.MTSDataSet1TableAdapters.makinaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.makinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MTSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // makinaBindingSource
            // 
            this.makinaBindingSource.DataMember = "makina";
            this.makinaBindingSource.DataSource = this.MTSDataSet1;
            // 
            // MTSDataSet1
            // 
            this.MTSDataSet1.DataSetName = "MTSDataSet1";
            this.MTSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.makinaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1016, 348);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // makinaTableAdapter
            // 
            this.makinaTableAdapter.ClearBeforeFill = true;
            // 
            // makrapor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 348);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "makrapor2";
            this.Text = "makrapor2";
            this.Load += new System.EventHandler(this.makrapor2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.makinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MTSDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.BindingSource makinaBindingSource;
        public MTSDataSet1 MTSDataSet1;
        public MTSDataSet1TableAdapters.makinaTableAdapter makinaTableAdapter;

    }
}