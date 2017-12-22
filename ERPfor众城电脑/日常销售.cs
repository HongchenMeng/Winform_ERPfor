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
    public partial class 日常销售 : Office2007Form
    {
        public string sqll = "";
        public  string sql = "";
        public int b = 0;
        public string a = "";
        public 日常销售()
        {
            InitializeComponent();
        }


        public 日常销售(string SQL,string SQLL)
        {
            InitializeComponent();
            sql = SQL;
            sqll = SQLL;
        }
         
        private void 日常销售_Load(object sender, EventArgs e)
        {

            int i = 0;
            int j = 0;
           // string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO_LOG] WHERE GOOD_ID = '" + good_id + "'";
            // this.reportViewer1.LocalReport.ReportEmbeddedResource = "ERPfor众城电脑.历史库存记录.rdlc";
            DataTable da = CARDAL.DbHelp.GetDataTable(sql);
            DataTable daa = CARDAL.DbHelp.GetDataTable(sqll);
            j = daa.Rows.Count;
            for (i = 0; i < j;i++ )
            {
                string  sql_p = "SELECT * FROM [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE SELL_ID ='"+daa.Rows[i]["SELL_ID"]+"'";
                DataTable daaa = CARDAL.DbHelp.GetDataTable(sql_p);
                b= b+ Convert .ToInt32(daaa.Rows[0]["PAY_MUCH"]);
            }
            a = Convert.ToString(b);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CARDAL.DbHelp.GetDataTable(sql).DefaultView));
            Microsoft.Reporting.WinForms.ReportParameter mParameter = new Microsoft.Reporting.WinForms.ReportParameter("S", a);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { mParameter });
            this.reportViewer1.RefreshReport();

            // TODO: 这行代码将数据加载到表“销售报表.ZH_SELL_SITUATION”中。您可以根据需要移动或删除它。
           // this.ZH_SELL_SITUATIONTableAdapter.Fill(this.销售报表.ZH_SELL_SITUATION);
            //string  a = "1000";
           // Microsoft.Reporting.WinForms.ReportParameter mParameter = new Microsoft.Reporting.WinForms.ReportParameter("S", a);
          //  this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { mParameter });
          //  this.reportViewer1.RefreshReport();
        }
    }
}
