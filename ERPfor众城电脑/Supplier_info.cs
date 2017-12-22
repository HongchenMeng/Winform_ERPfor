using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using CARDAL;

namespace ERPfor众城电脑
{
    public partial class Supplier_info :Office2007Form

    {

        public string flag = "";
        public string pubtext = "";
        public Supplier_info()
        {
            InitializeComponent();
            
        }

        private void Supplier_info_Load(object sender, EventArgs e)
        {

            textBoxX1.Enabled = false;
            textBoxX2.Enabled = false;
            textBoxX3.Enabled = false;
            textBoxX4.Enabled = false;
            textBoxX5.Enabled = false;
            string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_SUPPLIER_INFO]";
            DataBind(sql);

        }
        public void  DataBind (string SQL)
       {
           this.dataGridViewX1.AutoGenerateColumns = false;
           this.dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(SQL);       
       }

        private void toolStripButton1_Click(object sender, EventArgs e)//新增
        {
            textBoxX1.Enabled = true;
            textBoxX2.Enabled = true;
            textBoxX3.Enabled = true;
            textBoxX4.Enabled = true;
            textBoxX5.Enabled = true;
            flag = "add";
            textBoxX1.Text = "";
            textBoxX2.Text = "";
            textBoxX3.Text = "";
            textBoxX4.Text = "";
            textBoxX5.Text = "";


        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxX1.Enabled = false;
            textBoxX2.Enabled = false;
            textBoxX3.Enabled = false;
            textBoxX4.Enabled = false;
            textBoxX5.Enabled = false;
            textBoxX1.Text = this.dataGridViewX1[0, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX2.Text = this.dataGridViewX1[4, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX3.Text = this.dataGridViewX1[2, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX4.Text = this.dataGridViewX1[3, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX5.Text = this.dataGridViewX1[1, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)//保存
        {
            int i = 0;
            string   text = textBoxX1.Text;
            string sql02 = "SELECT * FROM [ZCERP].[dbo].[ZH_SUPPLIER_INFO]";
            DataTable  checkta = CARDAL.DbHelp.GetDataTable(sql02);

    
            if (flag=="add")
            {
                for (i = 0; i < checkta.Rows.Count; i++)
                {
                    if (Convert.ToString(checkta.Rows[i]["S_NAME"]) == text)
                    {
                        MessageBoxEx.Show("提示信息：供应商信息已存在,新增失败!");
                        return;
                    }
                }

            string sql01 = "INSERT INTO  [ZCERP].[dbo].[ZH_SUPPLIER_INFO] (S_NAME,S_PERSON,S_ADD,S_PHONE,S_CONTENT) VALUES ('" + textBoxX1.Text + "','" + textBoxX3.Text + "','" + textBoxX2.Text + "','" + textBoxX4.Text + "','" + textBoxX5.Text + "')";
            CARDAL.DbHelp.GetExecuteNonQuery(sql01);
            MessageBoxEx.Show("提示信息：供应商信息添加成功!");
            DataBind(sql02);
            }

            if (flag == "EDITOR")
            {
                string sql04 = "UPDATE [ZCERP].[dbo].[ZH_SUPPLIER_INFO] SET S_NAME='" + textBoxX1.Text + "',S_PERSON='" + textBoxX3.Text + "',S_ADD='" + textBoxX2.Text + "',S_PHONE='" + textBoxX4.Text + "',S_CONTENT='" + textBoxX5.Text + "'  WHERE S_NAME ='"+pubtext+"'";

                if (MessageBoxEx.Show("确定修改此条供应商信息！ ", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    CARDAL.DbHelp.GetExecuteNonQuery(sql04);
                    MessageBoxEx.Show("提示信息：供应商" + text + "已修改！");
                    DataBind("SELECT * FROM [ZCERP].[dbo].[ZH_SUPPLIER_INFO]");

                }
            
            }


        }

        private void toolStripButton3_Click(object sender, EventArgs e)//删除
        {

            string del = textBoxX1.Text;

            string sql03 = "DELETE FROM [ZCERP].[dbo].[ZH_SUPPLIER_INFO] WHERE S_NAME ='" + del + "'";


            if (MessageBoxEx.Show("确定删除此条供应商信息！ ", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                CARDAL.DbHelp.GetExecuteNonQuery(sql03);
                MessageBox.Show("提示信息：供应商" + del + "已删除！");
                DataBind("SELECT * FROM [ZCERP].[dbo].[ZH_SUPPLIER_INFO]");

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//编辑
        {
            if (textBoxX1.Text != "")
            {
                textBoxX1.Enabled = true;
                textBoxX2.Enabled = true;
                textBoxX3.Enabled = true;
                textBoxX4.Enabled = true;
                textBoxX5.Enabled = true;

                flag = "EDITOR";
                pubtext = textBoxX1.Text.Trim();

            }
            else
            {
                return;
            
            }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DataBind("SELECT * FROM [ZCERP].[dbo].[ZH_SUPPLIER_INFO]");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}
