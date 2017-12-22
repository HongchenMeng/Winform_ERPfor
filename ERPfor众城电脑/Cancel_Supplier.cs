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
    public partial class Cancel_Supplier : Office2007Form
    {
        public Cancel_Supplier()
        {
            InitializeComponent();
        }

        public void Data_Bind()
        {
            string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_PAY_SUPPLIER] ORDER BY OD_PAY_ALL_M ASC ";
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
            dataGridViewX1.AutoGenerateColumns = false;
        
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Data_Bind();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Cancel_Supplier_Load(object sender, EventArgs e)
        {
            textBoxX1.Enabled = false;
            textBoxX2.Enabled = false;
            textBoxX3.Enabled = false;
            textBoxX4.Enabled = false;
            textBoxX6.Enabled = false;
            dateTimeInput1.Enabled = false;
            dateTimeInput1.Value = DateTime.Now;
            Data_Bind();

        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxX1.Text = this.dataGridViewX1[0, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX4.Text = this.dataGridViewX1[1, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX2.Text = this.dataGridViewX1[3, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
          //  dateTimeInput1.Text = this.dataGridViewX1[0, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX6.Text = this.dataGridViewX1[5, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX3.Enabled = true;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (textBoxX3.Text != "")
            {
                string sql_check = "SELECT * FROM [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE ORDER_ID = '" + textBoxX1.Text + "'";
                DataTable da = CARDAL.DbHelp.GetDataTable(sql_check);
                if (da.Rows[0]["SHOW_PAY"].ToString() != textBoxX3.Text)
                {
                    if(MessageBoxEx.Show("应再付款金额为："+da.Rows[0]["SHOW_PAY"]+"与当前付款金额不同，是否继续？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                    return;
                    }
                }    
                    string sql01 = " UPDATE [ZCERP].[dbo].[ZH_PAY_SUPPLIER] SET OD_PAY_ALL_M ='是',Input_Date =' " + dateTimeInput1.Text + "',INSPECT_MUCH ='" + textBoxX3.Text + "' WHERE ORDER_ID ='" + textBoxX1.Text + "'";
                    CARDAL.DbHelp.GetExecuteNonQuery(sql01);
                    MessageBoxEx.Show("成功销账！ 销账金额：" + textBoxX3.Text);
                    Data_Bind();
            }
            else
            {
                return;
            
            }
        }

    }
}
