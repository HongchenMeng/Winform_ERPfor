using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CARDAL;
using DevComponents.DotNetBar;

namespace ERPfor众城电脑
{
    public partial class 历史库存报表 : Office2007Form
    {
        public string good_id = "";
        public string good_name = "";
        public DateTime start_time;
        public DateTime end_time;
        public int a = 0;
        public 历史库存报表()
        {
            InitializeComponent();
        }

          public 历史库存报表(string GOOD_ID)
        {
            InitializeComponent();
            good_id = GOOD_ID;
        }

        public 历史库存报表(string GOOD_NAME,int A)
        {
            InitializeComponent();
            good_name = GOOD_NAME;
            a = A;
        }

        public 历史库存报表(DateTime START_TIME, DateTime END_TIME, int A)
        {
            InitializeComponent();
            start_time = START_TIME;
            end_time = END_TIME;
            a = A;
        }

        private void 历史库存报表_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“历史库存记录.ZH_GOOD_INFO_LOG”中。您可以根据需要移动或删除它。
            int B = a;
            switch (B)
            {
                case 0:
                    string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO_LOG] WHERE GOOD_ID = '" + good_id + "'";
                   // this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.历史库存记录.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CARDAL.DbHelp.GetDataTable(sql).DefaultView));
                    this.reportViewer1.RefreshReport();
                    break;
                case 1:
                    string sqll = "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO_LOG] WHERE GOOD_NAME = '" + good_name + "'";
                    //this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.历史库存记录.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CARDAL.DbHelp.GetDataTable(sqll).DefaultView));
                    this.reportViewer1.RefreshReport();
                    break;
                case 3:

                    string sql01 = "SELECT *  FROM [ZCERP].[dbo].[ZH_GOOD_INFO_LOG] WHERE INPUT_TIME >= '" + start_time + "' and INPUT_TIME <='" + end_time + "'";
                   // this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.历史库存记录.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CARDAL.DbHelp.GetDataTable(sql01).DefaultView));
                    this.reportViewer1.RefreshReport();
                    break;
            }           
                    
            this.ZH_GOOD_INFO_LOGTableAdapter.Fill(this.历史库存记录.ZH_GOOD_INFO_LOG);
            this.reportViewer1.RefreshReport();
        }
    }
}
