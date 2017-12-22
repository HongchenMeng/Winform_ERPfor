namespace ERPfor众城电脑
{
    partial class Return_Report
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
            this.对客户退货 = new ERPfor众城电脑.对客户退货();
            this.ZH_RETURN_GUESTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZH_RETURN_GUESTTableAdapter = new ERPfor众城电脑.对客户退货TableAdapters.ZH_RETURN_GUESTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.对客户退货)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZH_RETURN_GUESTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ZH_RETURN_GUESTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.对客户退款报表.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1044, 421);
            this.reportViewer1.TabIndex = 0;
            // 
            // 对客户退货
            // 
            this.对客户退货.DataSetName = "对客户退货";
            this.对客户退货.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ZH_RETURN_GUESTBindingSource
            // 
            this.ZH_RETURN_GUESTBindingSource.DataMember = "ZH_RETURN_GUEST";
            this.ZH_RETURN_GUESTBindingSource.DataSource = this.对客户退货;
            // 
            // ZH_RETURN_GUESTTableAdapter
            // 
            this.ZH_RETURN_GUESTTableAdapter.ClearBeforeFill = true;
            // 
            // Return_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 445);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Name = "Return_Report";
            this.Text = "Return_Report";
            this.Load += new System.EventHandler(this.Return_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.对客户退货)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZH_RETURN_GUESTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ZH_RETURN_GUESTBindingSource;
        private 对客户退货 对客户退货;
        private 对客户退货TableAdapters.ZH_RETURN_GUESTTableAdapter ZH_RETURN_GUESTTableAdapter;
    }
}