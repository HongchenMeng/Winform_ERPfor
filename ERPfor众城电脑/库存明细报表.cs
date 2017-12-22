using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;


namespace ERPfor众城电脑
{
    public partial class 库存明细报表 : Office2007Form
    {
        public 库存明细报表()
        {
            InitializeComponent();
        }

        private void 库存明细报表_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“DataSet2.ZH_GOOD_INFO”中。您可以根据需要移动或删除它。
            this.ZH_GOOD_INFOTableAdapter.Fill(this.DataSet2.ZH_GOOD_INFO);

          //this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //缩放模式为百分比,以100%方式显示
          //this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
          // this.reportViewer1.ZoomPercent = 100;
           

            Microsoft.Reporting.WinForms.ReportParameter mParameter = new Microsoft.Reporting.WinForms.ReportParameter("P", "张三");
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { mParameter });
            this.reportViewer1.RefreshReport();


        }
    }
}
