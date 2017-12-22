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
    public partial class Pay_Supplier : Office2007Form
    {
        public string order_id = "";

        public Pay_Supplier()
        {
            InitializeComponent();
        }

        public Pay_Supplier(string a,string b,string c)
        {
            InitializeComponent();
            textBoxX1.Text = a;
            textBoxX4.Text = b;
            comboBoxEx1.Text =c;
        }

        private void Pay_Supplier_Load(object sender, EventArgs e)
        {

           // textBoxX1.Enabled = false;
            textBoxX4.Enabled = false;
            comboBoxEx1.Enabled = false;
            Data_Bind();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        
        {
            if (textBoxX1.Text == "")
            {
                MessageBoxEx.Show("提示信息：订单号不能为空！");
                return;
            }
            string p_sql = "INSERT INTO ZH_PAY_SUPPLIER (ORDER_ID,OD_PAY_ALL_M,PAY_MUCH,GOOD_SUPPLIER,Input_Date,INPUTER,INSPECT_MUCH,SHOW_PAY) VALUES ('" + textBoxX1.Text + "','" + comboBoxEx1.Text + "','" + textBoxX2.Text + "','" + textBoxX4.Text + "','','','','" + textBoxX3.Text + "')";
            CARDAL.DbHelp.GetExecuteNonQuery(p_sql);
            MessageBoxEx.Show("提示信息：付款信息添加成功！");
           // textBoxX1.Text = "";
           // textBoxX4.Text = "";
            //textBoxX2.Text = "";
            Data_Bind();
            this.Close();
        }

        public  void Data_Bind ()
        {
         string  sql = "SELECT * FROM ZH_PAY_SUPPLIER";
         dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
         dataGridViewX1.AutoGenerateColumns = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Data_Bind();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("是否要删除此付款信息？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string d_sql = "DELETE FROM ZH_PAY_SUPPLIER WHERE ORDER_ID ='" + order_id + "'";
                CARDAL.DbHelp.GetExecuteNonQuery(d_sql);
                MessageBoxEx.Show("提示信息：已删除订单号 " + textBoxX1.Text);
                Data_Bind();
            }

        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            order_id = this.dataGridViewX1[0, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();

        }

    }
}
