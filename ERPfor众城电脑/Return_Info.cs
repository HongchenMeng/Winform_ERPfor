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
    public partial class Return_Info : Office2007Form
    {
        public int s = 0;
        public Return_Info()
        {
            InitializeComponent();
        }

        private void Return_Info_Load(object sender, EventArgs e)
        {
             DataBind();
             DataBindd();

        }

        public void DataBind()
        {
            string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST]";
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
            dataGridViewX1.AutoGenerateColumns = false;
        }

        public void DataBindd()
        {
            string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_SUPPLIER]";
            dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
            dataGridViewX2.AutoGenerateColumns = false;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if(textBoxX1.Text ==""&& dateTimeInput1.Text ==""&&dateTimeInput2.Text=="")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST]";
                dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                dataGridViewX1.AutoGenerateColumns = false;
            }

            if(textBoxX1.Text ==""&&dateTimeInput1.Text ==""&&dateTimeInput2.Text !="")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE INPUT_DATE <='" + dateTimeInput2.Value + "'";
                dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                dataGridViewX1.AutoGenerateColumns = false;
            
            }

            if (textBoxX1.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE INPUT_DATE <='" + dateTimeInput2.Value + "' AND INPUT_DATE >='" + dateTimeInput1.Value + "'";
                dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                dataGridViewX1.AutoGenerateColumns = false;

            }

            if (textBoxX1.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE ORDER_ID ='" + textBoxX1.Text + "'";
                dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                dataGridViewX1.AutoGenerateColumns = false;
            }

            if (textBoxX1.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE INPUT_DATE <='" + dateTimeInput2.Value + "'AND  ORDER_ID ='" +textBoxX1.Text + "'";
                dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                dataGridViewX1.AutoGenerateColumns = false;

            }

            if (textBoxX1.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE INPUT_DATE <='" + dateTimeInput2.Value + "' AND INPUT_DATE >='" + dateTimeInput1.Value + "'AND  ORDER_ID ='" + textBoxX1.Text + "'";
                dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                dataGridViewX1.AutoGenerateColumns = false;

            }


        }




        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (textBoxX2.Text == "" && dateTimeInput3.Text == "" && dateTimeInput4.Text == "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_SUPPLIER]";
                dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                dataGridViewX2.AutoGenerateColumns = false;
            }

            if (textBoxX2.Text == "" && dateTimeInput3.Text == "" && dateTimeInput4.Text != "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_SUPPLIER] WHERE INPUT_DATE <='" + dateTimeInput4.Value + "'";
                dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                dataGridViewX2.AutoGenerateColumns = false;

            }

            if (textBoxX2.Text == "" && dateTimeInput3.Text != "" && dateTimeInput4.Text != "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_SUPPLIER] WHERE INPUT_DATE <='" + dateTimeInput4.Value + "' AND INPUT_DATE >='" + dateTimeInput3.Value + "'";
                dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                dataGridViewX2.AutoGenerateColumns = false;

            }

            if (textBoxX2.Text != "" && dateTimeInput3.Text == "" && dateTimeInput4.Text == "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_SUPPLIER] WHERE ORDER_ID ='" + textBoxX2.Text + "'";
                dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                dataGridViewX2.AutoGenerateColumns = false;
            }

            if (textBoxX2.Text != "" && dateTimeInput3.Text == "" && dateTimeInput4.Text != "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_SUPPLIER] WHERE INPUT_DATE <='" + dateTimeInput4.Value + "'AND  ORDER_ID ='" + textBoxX2.Text + "'";
                dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                dataGridViewX2.AutoGenerateColumns = false;

            }

            if (textBoxX2.Text != "" && dateTimeInput3.Text != "" && dateTimeInput4.Text != "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_SUPPLIER] WHERE INPUT_DATE <='" + dateTimeInput4.Value + "' AND INPUT_DATE >='" + dateTimeInput3.Value + "'AND  ORDER_ID ='" + textBoxX2.Text + "'";
                dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                dataGridViewX2.AutoGenerateColumns = false;

            }



        }




        private void buttonX2_Click(object sender, EventArgs e)
        {

            if (textBoxX1.Text == "" && dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST]";
                string sqll = "SELECT DISTINCT ORDER_ID  FROM [ZCERP].[dbo].[ZH_RETURN_GUEST]";
                DataTable  da = CARDAL.DbHelp.GetDataTable (sql);
                DataTable daa = CARDAL.DbHelp.GetDataTable(sqll);
                int i =0;
              //  int j =0;
                for (i=0;i<daa.Rows.Count;i++)
                {
                    string sql_p = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE ORDER_ID='" + daa.Rows[i]["ORDER_ID"] + "'";
                    DataTable daaa = CARDAL.DbHelp.GetDataTable(sql_p);
                    s=s+Convert.ToInt32(daaa.Rows[0]["RETURN_MONEY"]);
                
                }
                string a = Convert.ToString(s);
                Return_Report rr = new Return_Report( sql, a);
                rr.StartPosition = FormStartPosition.CenterScreen;
                rr.ShowDialog();
                s = 0;
                return;
            }



            if (textBoxX1.Text == "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE INPUT_DATE <='" + dateTimeInput2.Value + "'";
                string sqll = "SELECT DISTINCT ORDER_ID FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE INPUT_DATE <='" + dateTimeInput2.Value + "'";
                DataTable da = CARDAL.DbHelp.GetDataTable(sql);
                DataTable daa = CARDAL.DbHelp.GetDataTable(sqll);

                int i = 0;
               // int j = 0;
                for (i = 0; i < daa.Rows.Count; i++)
                {
                    string sql_p = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE ORDER_ID='" + daa.Rows[i]["ORDER_ID"] + "'";
                    DataTable daaa = CARDAL.DbHelp.GetDataTable(sql_p);
                    s = s + Convert.ToInt32(daaa.Rows[0]["RETURN_MONEY"]);

                }
                string a = Convert.ToString(s);
                Return_Report rr = new Return_Report(sql, a);
                rr.StartPosition = FormStartPosition.CenterScreen;
                rr.ShowDialog();
                s = 0;
                return;

            }



            if (textBoxX1.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
            {
                string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE INPUT_DATE <='" + dateTimeInput2.Value + "' AND INPUT_DATE >='" + dateTimeInput1.Value + "'";
                string sqll = "SELECT  DISTINCT ORDER_ID  FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE INPUT_DATE <='" + dateTimeInput2.Value + "' AND INPUT_DATE >='" + dateTimeInput1.Value + "'";
                DataTable da = CARDAL.DbHelp.GetDataTable(sql);
                DataTable daa = CARDAL.DbHelp.GetDataTable(sqll);
                int i = 0;
               // int j = 0;
                for (i = 0; i < daa.Rows.Count; i++)
                {
                    string sql_p = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE ORDER_ID='" + daa.Rows[i]["ORDER_ID"] + "'";
                    DataTable daaa = CARDAL.DbHelp.GetDataTable(sql_p);
                    s = s + Convert.ToInt32(daaa.Rows[0]["RETURN_MONEY"]);
                }
                string a = Convert.ToString(s);
                Return_Report rr = new Return_Report(sql, a);
                rr.StartPosition = FormStartPosition.CenterScreen;
                rr.ShowDialog();
                s = 0;
                return;

            }



            if (textBoxX1.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
            {
                string sql = "SELECT  * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE ORDER_ID ='" + textBoxX1.Text + "'";
                string sqll = "SELECT   DISTINCT ORDER_ID  FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE ORDER_ID ='" + textBoxX1.Text + "'";
                DataTable da = CARDAL.DbHelp.GetDataTable(sql);
                DataTable daa = CARDAL.DbHelp.GetDataTable(sqll);
                int i = 0;
               // int j = 0;
                for (i = 0; i < daa.Rows.Count; i++)
                {
                    string sql_p = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE ORDER_ID='" + daa.Rows[i]["ORDER_ID"] + "'";
                    DataTable daaa = CARDAL.DbHelp.GetDataTable(sql_p);
                    s = s + Convert.ToInt32(daaa.Rows[0]["RETURN_MONEY"]);
                }
                string a = Convert.ToString(s);
                Return_Report rr = new Return_Report(sql, a);
                rr.StartPosition = FormStartPosition.CenterScreen;
                rr.ShowDialog();
                s = 0;
                return;
            }



            if (textBoxX1.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
            {
                string sql = "SELECT   * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE INPUT_DATE <='" + dateTimeInput2.Value + "'AND  ORDER_ID ='" + textBoxX1.Text + "'";
                string sqll = "SELECT  DISTINCT ORDER_ID  FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE INPUT_DATE <='" + dateTimeInput2.Value + "'AND  ORDER_ID ='" + textBoxX1.Text + "'";
                DataTable da = CARDAL.DbHelp.GetDataTable(sql);
                DataTable daa = CARDAL.DbHelp.GetDataTable(sqll);
                int i = 0;
               // int j = 0;
                for (i = 0; i < daa.Rows.Count; i++)
                {
                    string sql_p = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE ORDER_ID='" + daa.Rows[i]["ORDER_ID"] + "'";
                    DataTable daaa = CARDAL.DbHelp.GetDataTable(sql_p);
                    s = s + Convert.ToInt32(daaa.Rows[0]["RETURN_MONEY"]);

                }
                string a = Convert.ToString(s);
                Return_Report rr = new Return_Report(sql, a);
                rr.StartPosition = FormStartPosition.CenterScreen;
                rr.ShowDialog();
                s = 0;
                return;

            }



            if (textBoxX1.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
            {
                string sql = "SELECT  * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE INPUT_DATE <='" + dateTimeInput2.Value + "' AND INPUT_DATE >='" + dateTimeInput1.Value + "'AND  ORDER_ID ='" + textBoxX1.Text + "'";
                string sqll = "SELECT  DISTINCT ORDER_ID  FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE INPUT_DATE <='" + dateTimeInput2.Value + "' AND INPUT_DATE >='" + dateTimeInput1.Value + "'AND  ORDER_ID ='" + textBoxX1.Text + "'";
                DataTable da = CARDAL.DbHelp.GetDataTable(sql);
                DataTable daa = CARDAL.DbHelp.GetDataTable(sqll);
                int i = 0;
               // int j = 0;
                for (i = 0; i < daa.Rows.Count; i++)
                {
                    string sql_p = "SELECT * FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE ORDER_ID='" + daa.Rows[i]["ORDER_ID"] + "'";
                    DataTable daaa = CARDAL.DbHelp.GetDataTable(sql_p);
                    s = s + Convert.ToInt32(daaa.Rows[0]["RETURN_MONEY"]);

                }
                string a = Convert.ToString(s);
                Return_Report rr = new Return_Report(sql, a);
                rr.StartPosition = FormStartPosition.CenterScreen;
                rr.ShowDialog();
                s = 0;
                return;
            }


        }

    }
}
