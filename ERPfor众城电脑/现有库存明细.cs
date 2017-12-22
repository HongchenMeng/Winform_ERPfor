using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using CARDAL;

namespace ERPfor众城电脑
{
    public partial class 现有库存明细 : Office2007Form
    {
        public string good_id = "";
        public string good_name = "";
        public DateTime start_time;
        public DateTime end_time;
        public int a = 0;
        public 现有库存明细()
        {
            InitializeComponent();
        }

        public 现有库存明细(string GOOD_ID)
        {
            InitializeComponent();
            good_id = GOOD_ID;
        }

        public 现有库存明细(string GOOD_NAME,int A)
        {
            InitializeComponent();
            good_name = GOOD_NAME;
            a = A;
        }

        public 现有库存明细(DateTime START_TIME,DateTime END_TIME,int A)
        {
            InitializeComponent();
            start_time = START_TIME;
            end_time = END_TIME;
            a = A;
        }

        private void 现有库存明细_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“库存明细.ZH_GOOD_INFO”中。您可以根据需要移动或删除它。
            int B = a;
            switch (B)
            {
                case 0:
                    string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO] WHERE GOOD_ID = '" + good_id + "'";
                   // this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.库存明细.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CARDAL.DbHelp.GetDataTable(sql).DefaultView));
                    this.reportViewer1.RefreshReport();
                    break;
                case 1:
                    string sqll= "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO] WHERE GOOD_NAME = '" + good_name + "'";
                   // this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.库存明细.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CARDAL.DbHelp.GetDataTable(sqll).DefaultView));
                    this.reportViewer1.RefreshReport();
                    break;
                case 3:

                    string sql01 = "SELECT *  FROM [ZCERP].[dbo].[ZH_GOOD_INFO] WHERE INPUT_TIME >= '" + start_time + "' and INPUT_TIME <='" + end_time + "'";
                   // this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.库存明细.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CARDAL.DbHelp.GetDataTable(sql01).DefaultView));
                    this.reportViewer1.RefreshReport();
                    break;
            }

           this.ZH_GOOD_INFOTableAdapter.Fill(this.库存明细.ZH_GOOD_INFO);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
