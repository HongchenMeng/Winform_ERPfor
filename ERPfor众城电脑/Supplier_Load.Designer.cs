namespace ERPfor众城电脑
{
    partial class Supplier_Load
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
            this.供应商欠款报表 = new ERPfor众城电脑.供应商欠款报表();
            this.ZH_PAY_SUPPLIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZH_PAY_SUPPLIERTableAdapter = new ERPfor众城电脑.供应商欠款报表TableAdapters.ZH_PAY_SUPPLIERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.供应商欠款报表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZH_PAY_SUPPLIERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ZH_PAY_SUPPLIERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.对供应商欠款报表.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(37, 19);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(897, 319);
            this.reportViewer1.TabIndex = 0;
            // 
            // 供应商欠款报表
            // 
            this.供应商欠款报表.DataSetName = "供应商欠款报表";
            this.供应商欠款报表.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ZH_PAY_SUPPLIERBindingSource
            // 
            this.ZH_PAY_SUPPLIERBindingSource.DataMember = "ZH_PAY_SUPPLIER";
            this.ZH_PAY_SUPPLIERBindingSource.DataSource = this.供应商欠款报表;
            // 
            // ZH_PAY_SUPPLIERTableAdapter
            // 
            this.ZH_PAY_SUPPLIERTableAdapter.ClearBeforeFill = true;
            // 
            // Supplier_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 350);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Name = "Supplier_Load";
            this.Text = "Supplier_Load";
            this.Load += new System.EventHandler(this.Supplier_Load_Load);
            ((System.ComponentModel.ISupportInitialize)(this.供应商欠款报表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZH_PAY_SUPPLIERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ZH_PAY_SUPPLIERBindingSource;
        private 供应商欠款报表 供应商欠款报表;
        private 供应商欠款报表TableAdapters.ZH_PAY_SUPPLIERTableAdapter ZH_PAY_SUPPLIERTableAdapter;
    }
}