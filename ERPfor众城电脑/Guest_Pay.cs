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
    public partial class Guest_Pay : Office2007Form
    {
        public Guest_Pay()
        {
            InitializeComponent();
        }

        public Guest_Pay(string a, string b, string c,string d)
        {
            InitializeComponent();
            textBoxX1.Text = a;
            textBoxX3.Text = b;
            comboBoxEx1.Text = c;
            textBoxX6.Text = d;
        }

        private void Guest_Pay_Load(object sender, EventArgs e)
        {
            textBoxX1.Enabled = false;
            textBoxX3.Enabled = false;
            comboBoxEx1.Enabled = false;
            textBoxX6.Enabled = false;
            Data_Bind();

        }

        public void Data_Bind()
        {
            string g_sql = "SELECT * FROM [ZCERP].[dbo].[ZH_LOADER]  ORDER BY LOAD_DATE ASC";
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(g_sql);
            dataGridViewX1.AutoGenerateColumns = false;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Data_Bind();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text != "" && textBoxX2.Text != "" && textBoxX5.Text != "")
            {
                string[] a_aray = textBoxX1.Text.Split(',');
                string[] a_aaray = textBoxX6.Text.Split(',');
                int count = a_aray.Count() - 1;
                int i = 0;
                for (i = 0; i < count; i++)
                {
                    string a = a_aray[i];
                    string b = a_aaray[i];
                    DateTime time = DateTime.Now;
                    string s_sql = "INSERT INTO [ZCERP].[dbo].[ZH_LOADER] (LOAD_PERSON,LOAD_MUCH,HAVE_PAY,GOOD_ID,LOAD_DATE,GOOD_NAME,ORDER_ID,DO_PAY_ALL,INSPECT_PAY,OPERATER) VALUES ('" + textBoxX4.Text + "','" + textBoxX5.Text + "','" + textBoxX2.Text + "','" + a + "','" + time + "','" + b + "','" + textBoxX3.Text + "','" + "0','','')";
                    CARDAL.DbHelp.GetExecuteNonQuery(s_sql);
                    /* if (textBoxX1.Text != "" && textBoxX2.Text != "" && textBoxX5.Text != "")
                     {
                         DateTime time = DateTime.Now;
                         string s_sql = "INSERT INTO [ZCERP].[dbo].[ZH_LOADER] (LOAD_PERSON,LOAD_MUCH,HAVE_PAY,GOOD_ID,LOAD_DATE) VALUES ('" + textBoxX4.Text + "','" + textBoxX5.Text + "','" + textBoxX2.Text + "','" + textBoxX1.Text + "','" + time + "')";
                         CARDAL.DbHelp.GetExecuteNonQuery(s_sql);
                         MessageBoxEx.Show("客户欠款信息保存成功！","提示信息");
                         Data_Bind();*/
                }
                MessageBoxEx.Show("客户欠款信息保存成功！", "提示信息");
                Data_Bind();
            }
            else
            {
                MessageBoxEx.Show("商品编号 且 已付金额 且 尚欠金额 均不可为空！");
                return;
            }

        }



        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxX1.Text = this.dataGridViewX1[3, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX2.Text = this.dataGridViewX1[2, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX4.Text = this.dataGridViewX1[0, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX5.Text = this.dataGridViewX1[1, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text != "")
            {
                if (MessageBoxEx.Show("欠款客户是否已将欠款还清？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {   string se_sql = "SELECT * FROM [ZCERP].[dbo].[ZH_LOADER] WHERE GOOD_ID ='" + textBoxX1.Text + "'";
                    string  s_sql = "SELECT * FROM [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE GOOD_ID ='" + textBoxX1.Text + "'";
                    string d_sql = "DELETE FROM [ZCERP].[dbo].[ZH_LOADER] WHERE GOOD_ID ='" + textBoxX1.Text + "'";
                    DataTable du = CARDAL.DbHelp.GetDataTable(s_sql);
                    DataTable dd = CARDAL.DbHelp.GetDataTable(se_sql);
                    string u_sql = "UPDATE [ZCERP].[dbo].[ZH_SELL_SITUATION] SET PAY_MUCH ='" + du.Rows[0]["PAY_MUCH"] + "','" + dd.Rows[0]["LOAD_MUCH"] + "','" + " WHERE GOOD_ID = '" + textBoxX1.Text + "'";
                    CARDAL.DbHelp.GetExecuteNonQuery(d_sql);
                    MessageBoxEx.Show("欠款客户信息已删除！", "提示信息");
                    Data_Bind();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBoxEx.Show("商品编号不得为空！", "提示信息");
                return;
            
            }
        }
    }
}
