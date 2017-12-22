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
    public partial class Supplier_Load : Office2007Form
    {
        public string sql = "";

        public Supplier_Load()
        {
            InitializeComponent();
        }

        public Supplier_Load(string SQL)
        {
            InitializeComponent();
            sql = SQL;
        }

        private void Supplier_Load_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“供应商欠款报表.ZH_PAY_SUPPLIER”中。您可以根据需要移动或删除它。
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CARDAL.DbHelp.GetDataTable(sql).DefaultView));
            this.reportViewer1.RefreshReport();
        }
    }
}
