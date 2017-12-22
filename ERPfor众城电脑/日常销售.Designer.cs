namespace ERPfor众城电脑
{
    partial class 日常销售
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
            this.销售报表 = new ERPfor众城电脑.销售报表();
            this.ZH_SELL_SITUATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZH_SELL_SITUATIONTableAdapter = new ERPfor众城电脑.销售报表TableAdapters.ZH_SELL_SITUATIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.销售报表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZH_SELL_SITUATIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ZH_SELL_SITUATIONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.销售报表.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(915, 404);
            this.reportViewer1.TabIndex = 0;
            // 
            // 销售报表
            // 
            this.销售报表.DataSetName = "销售报表";
            this.销售报表.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ZH_SELL_SITUATIONBindingSource
            // 
            this.ZH_SELL_SITUATIONBindingSource.DataMember = "ZH_SELL_SITUATION";
            this.ZH_SELL_SITUATIONBindingSource.DataSource = this.销售报表;
            // 
            // ZH_SELL_SITUATIONTableAdapter
            // 
            this.ZH_SELL_SITUATIONTableAdapter.ClearBeforeFill = true;
            // 
            // 日常销售
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 428);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Name = "日常销售";
            this.Text = "日常销售";
            this.Load += new System.EventHandler(this.日常销售_Load);
            ((System.ComponentModel.ISupportInitialize)(this.销售报表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZH_SELL_SITUATIONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ZH_SELL_SITUATIONBindingSource;
        private 销售报表 销售报表;
        private 销售报表TableAdapters.ZH_SELL_SITUATIONTableAdapter ZH_SELL_SITUATIONTableAdapter;
    }
}