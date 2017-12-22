namespace ERPfor众城电脑
{
    partial class Guest_Load
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
            this.欠款信息 = new ERPfor众城电脑.欠款信息();
            this.ZH_LOADERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZH_LOADERTableAdapter = new ERPfor众城电脑.欠款信息TableAdapters.ZH_LOADERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.欠款信息)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZH_LOADERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ZH_LOADERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.欠款报表.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(993, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // 欠款信息
            // 
            this.欠款信息.DataSetName = "欠款信息";
            this.欠款信息.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ZH_LOADERBindingSource
            // 
            this.ZH_LOADERBindingSource.DataMember = "ZH_LOADER";
            this.ZH_LOADERBindingSource.DataSource = this.欠款信息;
            // 
            // ZH_LOADERTableAdapter
            // 
            this.ZH_LOADERTableAdapter.ClearBeforeFill = true;
            // 
            // Guest_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 416);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Name = "Guest_Load";
            this.Text = "Guest_Load";
            this.Load += new System.EventHandler(this.Guest_Load_Load);
            ((System.ComponentModel.ISupportInitialize)(this.欠款信息)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZH_LOADERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ZH_LOADERBindingSource;
        private 欠款信息 欠款信息;
        private 欠款信息TableAdapters.ZH_LOADERTableAdapter ZH_LOADERTableAdapter;
    }
}