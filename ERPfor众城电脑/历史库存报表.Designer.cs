namespace ERPfor众城电脑
{
    partial class 历史库存报表
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
            this.ZH_GOOD_INFO_LOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.历史库存记录 = new ERPfor众城电脑.历史库存记录();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ZH_GOOD_INFO_LOGTableAdapter = new ERPfor众城电脑.历史库存记录TableAdapters.ZH_GOOD_INFO_LOGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ZH_GOOD_INFO_LOGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.历史库存记录)).BeginInit();
            this.SuspendLayout();
            // 
            // ZH_GOOD_INFO_LOGBindingSource
            // 
            this.ZH_GOOD_INFO_LOGBindingSource.DataMember = "ZH_GOOD_INFO_LOG";
            this.ZH_GOOD_INFO_LOGBindingSource.DataSource = this.历史库存记录;
            // 
            // 历史库存记录
            // 
            this.历史库存记录.DataSetName = "历史库存记录";
            this.历史库存记录.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ZH_GOOD_INFO_LOGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.历史库存记录.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(927, 372);
            this.reportViewer1.TabIndex = 0;
            // 
            // ZH_GOOD_INFO_LOGTableAdapter
            // 
            this.ZH_GOOD_INFO_LOGTableAdapter.ClearBeforeFill = true;
            // 
            // 历史库存报表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 412);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Name = "历史库存报表";
            this.Text = "历史库存报表";
            this.Load += new System.EventHandler(this.历史库存报表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZH_GOOD_INFO_LOGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.历史库存记录)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ZH_GOOD_INFO_LOGBindingSource;
        private 历史库存记录 历史库存记录;
        private 历史库存记录TableAdapters.ZH_GOOD_INFO_LOGTableAdapter ZH_GOOD_INFO_LOGTableAdapter;
    }
}