namespace ERPfor众城电脑
{
    partial class 库存明细报表
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
            this.ZH_GOOD_INFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new ERPfor众城电脑.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ZH_GOOD_INFOTableAdapter = new ERPfor众城电脑.DataSet2TableAdapters.ZH_GOOD_INFOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ZH_GOOD_INFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // ZH_GOOD_INFOBindingSource
            // 
            this.ZH_GOOD_INFOBindingSource.DataMember = "ZH_GOOD_INFO";
            this.ZH_GOOD_INFOBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ZH_GOOD_INFOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1513, 639);
            this.reportViewer1.TabIndex = 0;
            // 
            // ZH_GOOD_INFOTableAdapter
            // 
            this.ZH_GOOD_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // 库存明细报表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 639);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Name = "库存明细报表";
            this.Text = "库存明细报表";
            this.Load += new System.EventHandler(this.库存明细报表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZH_GOOD_INFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ZH_GOOD_INFOBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.ZH_GOOD_INFOTableAdapter ZH_GOOD_INFOTableAdapter;
    }
}