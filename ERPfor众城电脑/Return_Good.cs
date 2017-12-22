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
// 下载于www.51aspx.com
namespace ERPfor众城电脑
{
    public partial class Return_Good : Office2007Form
    {
        public Return_Good()
        {
            InitializeComponent();
        }

        private void textBoxX5_TextChanged(object sender, EventArgs e)
        {

        }

        public void Data_Bind()
        {
            string sql01 = "SELECT A.* FROM [ZCERP].[dbo].[ZH_GOOD_INFO] a WHERE A.GOOD_ID NOT IN (SELECT GOOD_ID FROM [ZCERP].[dbo].[ZH_SELL_SITUATION] b)   ORDER BY INPUT_TIME ASC";
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql01);
            dataGridViewX1.AutoGenerateColumns = false;
            string sql02 = "SELECT * FROM  [ZCERP].[dbo].[ZH_SELL_SITUATION] ";
            dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql02);
            dataGridViewX2.AutoGenerateColumns = false;
        }

        private void Return_Good_Load(object sender, EventArgs e)
        {

            textBoxX1.Enabled = false;
            textBoxX2.Enabled = false;
            textBoxX4.Enabled = false;
            textBoxX6.Enabled = false;
            textBoxX7.Enabled = false;
            textBoxX8.Enabled = false;
            textBoxX10.Enabled = false;
            textBoxX12.Enabled = false;
            this.ActiveControl = textBoxX3;
            textBoxX3.Focus();
            dateTimeInput1.Value = DateTime.Now;
            dateTimeInput2.Value = DateTime.Now;
            Data_Bind();

        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxX1.Text = this.dataGridViewX1[0, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX2.Text = this.dataGridViewX1[7, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX4.Text = this.dataGridViewX1[9, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            
        }

        private void dataGridViewX2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxX8.Text = this.dataGridViewX2[0, dataGridViewX2.CurrentCell.RowIndex].Value.ToString();
            textBoxX10.Text = this.dataGridViewX2[5, dataGridViewX2.CurrentCell.RowIndex].Value.ToString();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
          string sql_delete = " DELETE FROM [ZCERP].[dbo].[ZH_GOOD_INFO] WHERE GOOD_ID =' "+textBoxX4.Text+"'";
          string sql_insert = "  INSERT INTO [ZCERP].[dbo].[ZH_RETURN_SUPPLIER] (GOOD_ID,ORDER_ID,SUPPLIER_NAME,INPUT_DATE,INPUTER,GOOD_NAME,RETURN_MONEY) VALUES ('"+textBoxX2.Text+"','"+textBoxX4.Text+"','','"+dateTimeInput1.Text+"','"+textBoxX6.Text+"','"+textBoxX1.Text+"','"+textBoxX3.Text+"')";
          if ((MessageBoxEx.Show("是否真的要退货？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
          {
              if (textBoxX3.Text != "")
              {
                  CARDAL.DbHelp.GetExecuteNonQuery(sql_delete);
                  CARDAL.DbHelp.GetExecuteNonQuery(sql_insert);
                  MessageBoxEx.Show("退货成功！");
                  Data_Bind();
              }
              else
              {
                  MessageBoxEx.Show("退款金额不可以为空！");
                  return;
              }
          }
          else
          {
              return;
          }



        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            string sql_check = "SELECT *  FROM [ZCERP].[dbo].[ZH_RETURN_GUEST] WHERE GOOD_ID = '" + textBoxX8.Text + "'";
            DataTable da = CARDAL.DbHelp.GetDataTable(sql_check);
            int count = da.Rows.Count;
            string sql_insert = "INSERT INTO [ZCERP].[dbo].[ZH_RETURN_GUEST] (GOOD_ID,ORDER_ID,SUPPLIER_NAME,INPUT_DATE,INPUTER,GOOD_NAME,RETURN_MONEY) VALUES ('" + textBoxX8.Text + "','" + textBoxX10.Text + "','','" + dateTimeInput2.Text + "','" + textBoxX12.Text + "','" + textBoxX7.Text + "','" + textBoxX9.Text + "')";

            if ((MessageBoxEx.Show("是否真的要退货？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (textBoxX9.Text != "")
                {
                    if (count < 1)
                    {
                        CARDAL.DbHelp.GetExecuteNonQuery(sql_insert);
                        MessageBoxEx.Show("退货成功！");
                        Data_Bind();
                    }
                    else
                    {
                        MessageBoxEx.Show("此商品重复退货！");
                        return;
                    }
                   
                }
                else
                {
                    MessageBoxEx.Show("退款金额不可以为空！");
                    return;
                }
            }
            else
            {
                return;
            }

        }
    }
}
