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
    public partial class Sell_Situation : Office2007Form
    {
        public string sql = "";
        public string a = "";
        public Sell_Situation()
        {
            InitializeComponent();
        }

        private void Sell_Situation_Load(object sender, EventArgs e)
        {
            //dateTimeInput1.Enabled = false;
           // dateTimeInput2.Enabled = false;
           // buttonX2.Enabled = false;
            DataBind();

        }

        public void DataBind()
        {
            string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] ORDER BY SELL_DATE DESC";
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
            dataGridViewX1.AutoGenerateColumns = false;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            switch (comboBoxEx1.SelectedIndex)
            {
                case 0:
                    if (textBoxX4.Text !="" && dateTimeInput1.Text ==""&&dateTimeInput2.Text =="")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }
                    if (textBoxX4.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (textBoxX4.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;

                    }

                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;

                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;

                    }


                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;

                    }
                    break;


                case 1:
                      if (textBoxX4.Text !="" && dateTimeInput1.Text ==""&&dateTimeInput2.Text =="")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }
                    if (textBoxX4.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (textBoxX4.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;

                    }

                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;

                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;

                    }


                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;

                    }
                    break;
                case 2:
                      if (textBoxX4.Text !="" && dateTimeInput1.Text ==""&&dateTimeInput2.Text =="")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }
                    if (textBoxX4.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (textBoxX4.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;

                    }

                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;

                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] ";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  SELL_DATE > '" + dateTimeInput1.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;

                    }


                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  SELL_DATE <'" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;

                    }
                    break;

            }

        }





        private void buttonX2_Click(object sender, EventArgs e)
        {
           
           // 日常销售 day = new 日常销售();
           // day.StartPosition = FormStartPosition.CenterScreen;
           // day.ShowDialog();

            switch (comboBoxEx1.SelectedIndex)
            {
                case 0:
                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "'";
                        string sqll = "SELECT DISTINCT SELL_ID FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "'";
                       // DataTable da = CARDAL.DbHelp.GetDataTable(sqll);
                       // string sql_p = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE SELL_ID = '"+da.Rows[][]
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;
                    }
                    if (textBoxX4.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        string sqll = "SELECT  DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;
                    }

                    if (textBoxX4.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        string sqll = "SELECT  DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;

                    }

                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        string sqll = "SELECT  DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;

                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1'";
                        string sqll = "SELECT  DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;
                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        string sqll = "SELECT  DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;
                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        string sqll = "SELECT DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;

                    }


                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        string sqll = "SELECT DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='1' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;

                    }
                    break;


                case 1:
                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "'";
                        string sqll = "SELECT DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;
                    }
                    if (textBoxX4.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        string sqll = "SELECT DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;
                    }

                    if (textBoxX4.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        string sqll = "SELECT  DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;

                    }

                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        string sqll = "SELECT  DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;

                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0'";
                        string sqll = "SELECT  DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;
                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        string sqll = "SELECT  DISTINCT SELL_ID FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;
                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        string sqll = "SELECT  DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;

                    }


                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        string sqll = "SELECT DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE DO_PAY ='0' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;

                    }
                    break;
                case 2:
                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "'";
                        string sqll = "SELECT  DISTINCT SELL_ID FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;
                    }
                    if (textBoxX4.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        string sqll = "SELECT DISTINCT SELL_ID FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;
                    }

                    if (textBoxX4.Text != "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        string sqll = "SELECT DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;

                    }

                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        string sqll = "SELECT DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  GOOD_NAME ='" + textBoxX4.Text + "' OR GOOD_ID ='" + textBoxX4.Text + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;

                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] ";
                        string sqll = "SELECT  DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] ";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;
                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  SELL_DATE > '" + dateTimeInput1.Value + "'";
                        string sqll = "SELECT  DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  SELL_DATE > '" + dateTimeInput1.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;
                    }

                    if (textBoxX4.Text == "" && dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        string sqll = "SELECT  DISTINCT SELL_ID   FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  SELL_DATE > '" + dateTimeInput1.Value + "' AND SELL_DATE <'" + dateTimeInput2.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;

                    }


                    if (textBoxX4.Text != "" && dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  SELL_DATE <'" + dateTimeInput2.Value + "'";
                        string sqll = "SELECT DISTINCT SELL_ID  FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE  SELL_DATE <'" + dateTimeInput2.Value + "'";
                        日常销售 day = new 日常销售(sql, sqll);
                        day.StartPosition = FormStartPosition.CenterScreen;
                        day.ShowDialog();
                        return;

                    }
                    break;
            }


        }

    }
}
