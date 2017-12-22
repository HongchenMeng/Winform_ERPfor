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
    public partial class Return_Report : Office2007Form
    {
        public string sql = "";
        public string s = "";
        public Return_Report()
        {
            InitializeComponent();
        }

        public Return_Report(string SQL,string S)
        {
            InitializeComponent();
            sql = SQL;
            s = S;
        }

        private void Return_Report_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CARDAL.DbHelp.GetDataTable(sql).DefaultView));
            Microsoft.Reporting.WinForms.ReportParameter mParameter = new Microsoft.Reporting.WinForms.ReportParameter("S", s);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { mParameter });
            this.reportViewer1.RefreshReport();

            // TODO: 这行代码将数据加载到表“对客户退货.ZH_RETURN_GUEST”中。您可以根据需要移动或删除它。
            //this.ZH_RETURN_GUESTTableAdapter.Fill(this.对客户退货.ZH_RETURN_GUEST);

           // this.reportViewer1.RefreshReport();
        }
    }
}
