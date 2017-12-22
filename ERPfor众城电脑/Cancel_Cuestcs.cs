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
    public partial class Cancel_Cuestcs : Office2007Form
    {
        public string  ORDER_ID = "";
        public string  money = "";
        public Cancel_Cuestcs()
        {
            InitializeComponent();
        }

        public void Data_Bind ()
        {
            string l_sql = "SELECT * FROM [ZCERP].[dbo].[ZH_LOADER] ORDER BY LOAD_DATE ASC";
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(l_sql);
            dataGridViewX1.AutoGenerateColumns = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Data_Bind();
        }

        private void Cancel_Cuestcs_Load(object sender, EventArgs e)
        {
            textBoxX1.Enabled = false;
            textBoxX2.Enabled = false;
            textBoxX5.Enabled = false;
           // textBoxX6.Enabled = false;
            textBoxX7.Enabled = false;
            Data_Bind();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void dataGridViewX1_Click(object sender, EventArgs e)
        {  
            int i =0;
            string good_name = "";
            string good_id = "";
            string order_id = this.dataGridViewX1[6, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_LOADER] WHERE ORDER_ID ='" + order_id + "'";
            DataTable da = CARDAL.DbHelp.GetDataTable(sql);
            for (i = 0; i < da.Rows.Count;i++ )
            {
                money = da.Rows[i]["LOAD_MUCH"].ToString();
                good_name += da.Rows[i]["GOOD_NAME"];
                good_name +=","; 
                good_id+=da.Rows[i]["GOOD_ID"];
                good_id += ",";
            }

            textBoxX1.Text = good_id;
            textBoxX2.Text = this.dataGridViewX1[0, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX4.Text = good_name;
            textBoxX5.Text = this.dataGridViewX1[4, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            ORDER_ID = this.dataGridViewX1[6, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            dateTimeInput1.Text = DateTime.Now.ToString();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (textBoxX3.Text != "")
            {
                if (money != textBoxX3.Text)
                {
                    if ((MessageBoxEx.Show("客户付款金额与应该付款金额不同，是否确定清算？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string a = this.dataGridViewX1[4, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
                        string u_sql = "UPDATE [ZCERP].[dbo].[ZH_LOADER] SET INSPECT_PAY ='" + textBoxX3.Text + "',DO_PAY_ALL='1' WHERE ORDER_ID ='" + ORDER_ID + "'";
                        CARDAL.DbHelp.GetExecuteNonQuery(u_sql);
                        MessageBoxEx.Show("保存成功！客户余款已经付清！");
                        Data_Bind();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    string a = this.dataGridViewX1[4, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
                    string u_sql = "UPDATE [ZCERP].[dbo].[ZH_LOADER] SET INSPECT_PAY ='" + textBoxX3.Text + "',DO_PAY_ALL='1' WHERE ORDER_ID ='" + ORDER_ID + "'";
                    CARDAL.DbHelp.GetExecuteNonQuery(u_sql);
                    MessageBoxEx.Show("保存成功！客户余款已经付清！");
                    Data_Bind();
                
                }
            }
            else
            {
                MessageBoxEx.Show("付款金额不可为空！");
                return;            
            }
        }

    }
}
