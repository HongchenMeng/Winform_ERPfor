namespace ERPfor众城电脑
{
    partial class 现有库存明细
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
            this.库存明细 = new ERPfor众城电脑.库存明细();
            this.ZH_GOOD_INFOTableAdapter = new ERPfor众城电脑.库存明细TableAdapters.ZH_GOOD_INFOTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ZH_GOOD_INFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.库存明细)).BeginInit();
            this.SuspendLayout();
            // 
            // ZH_GOOD_INFOBindingSource
            // 
            this.ZH_GOOD_INFOBindingSource.DataMember = "ZH_GOOD_INFO";
            this.ZH_GOOD_INFOBindingSource.DataSource = this.库存明细;
            // 
            // 库存明细
            // 
            this.库存明细.DataSetName = "库存明细";
            this.库存明细.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ZH_GOOD_INFOTableAdapter
            // 
            this.ZH_GOOD_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ZH_GOOD_INFOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.库存明细.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 24);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(948, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // 现有库存明细
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 530);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Name = "现有库存明细";
            this.Text = "现有库存明细";
            this.Load += new System.EventHandler(this.现有库存明细_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZH_GOOD_INFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.库存明细)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ZH_GOOD_INFOBindingSource;
        private 库存明细 库存明细;
        private 库存明细TableAdapters.ZH_GOOD_INFOTableAdapter ZH_GOOD_INFOTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}