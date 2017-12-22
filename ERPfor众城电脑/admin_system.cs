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
    public partial class admin_system : Office2007Form
    {
        public string text = "";
        public string flag = "";
        public admin_system()
        {
            InitializeComponent();
        }

        private void admin_system_Load(object sender, EventArgs e)
        {
            DataBind();
            textBoxX1.Enabled = false;
            textBoxX2.Enabled  =false;
            textBoxX3.Enabled = false;
        
        }

        public void DataBind()
        {
            string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_USER_INFO]";
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
            dataGridViewX1.AutoGenerateColumns = false;      
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
         DataBind();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {     
            textBoxX1.Enabled = true;
            textBoxX2.Enabled  =true;
            textBoxX3.Enabled = true;
            textBoxX1.Text ="";
            textBoxX2.Text ="";
            textBoxX3.Text ="";
            buttonX4.Enabled = true;
            this.ActiveControl = textBoxX1;
            textBoxX1.Focus();
            flag = "editor";

        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {       
            textBoxX1.Text = this.dataGridViewX1[1, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX2.Text = this.dataGridViewX1[2, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX3.Text = this.dataGridViewX1[0, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (flag =="editor")
            {
            string sql = "INSERT INTO [ZCERP].[dbo].[ZH_USER_INFO] (USER_NAME,USER_ID,USER_PSW) VALUES ('" + textBoxX3.Text + "','" + textBoxX1.Text + "','" + textBoxX2.Text + "')";
            CARDAL.DbHelp.GetExecuteNonQuery(sql);
            DataBind();
            buttonX4.Enabled =  false;
            textBoxX1.Enabled = false;
            textBoxX2.Enabled = false;
            textBoxX3.Enabled = false;
            textBoxX1.Text = "";
            textBoxX2.Text = "";
            textBoxX3.Text = "";
            text = "";
            flag = "";
            return;
         }


            if (flag =="update")
            {       
                string sql = "UPDATE [ZCERP].[dbo].[ZH_USER_INFO] SET USER_NAME ='" + textBoxX3.Text + "',USER_ID = '" + textBoxX1.Text + "',USER_PSW = '" + textBoxX2.Text + "' WHERE  USER_ID ='" + text + "'";
                CARDAL.DbHelp.GetExecuteNonQuery(sql);
                DataBind();
                buttonX4.Enabled = false;
                textBoxX1.Enabled = false;
                textBoxX2.Enabled = false;
                textBoxX3.Enabled = false;
                textBoxX1.Text = "";
                textBoxX2.Text = "";
                textBoxX3.Text = "";
                text = "";
                flag = "";
                return;
            }

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text != "")
            {
                flag = "update";
                text = textBoxX1.Text;
                textBoxX1.Enabled = true;
                textBoxX2.Enabled = true;
                textBoxX3.Enabled = true;
               // textBoxX1.Text = "";
               // textBoxX2.Text = "";
               // textBoxX3.Text = "";
                buttonX4.Enabled = true;
                this.ActiveControl = textBoxX1;
                textBoxX1.Focus();


            }

        }



        private void buttonX3_Click(object sender, EventArgs e)
        {

            string sqll = "DELETE FROM [ZCERP].[dbo].[ZH_USER_INFO]  WHERE USER_ID ='" + textBoxX1.Text + "'";
            CARDAL.DbHelp.GetExecuteNonQuery(sqll);      
            buttonX4.Enabled = false;
            textBoxX1.Enabled = false;
            textBoxX2.Enabled = false;
            textBoxX3.Enabled = false;
            textBoxX1.Text = "";
            textBoxX2.Text = "";
            textBoxX3.Text = "";
            text = "";
            flag = "";
            DataBind();

        }



    }
}
