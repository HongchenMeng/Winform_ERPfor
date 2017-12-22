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
    public partial class storageinfo : Office2007Form
    {
        public storageinfo()
        {
            InitializeComponent();
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxEx1.SelectedIndex == 0)
            {
                dateTimeInput1.Enabled = true;
                dateTimeInput2.Enabled = true;

            }
            else
            {
                dateTimeInput1.Enabled = false;
                dateTimeInput2.Enabled = false;
            
            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            
            switch (this.comboBoxEx1.SelectedIndex)
            { 
                case 0:
                    if (dateTimeInput2.Text == "")
                    {
                        MessageBoxEx.Show("检索关键字不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonX2.Enabled = false;
                        return;
                    }

                    if (dateTimeInput2.Value < dateTimeInput1.Value)
                    {
                        MessageBoxEx.Show("结束日期不能小于开始日期！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonX2.Enabled = false;
                        return;
                    }
                        buttonX2.Enabled = true;
                        string sql01 = "SELECT *  FROM [ZCERP].[dbo].[ZH_GOOD_INFO] WHERE INPUT_TIME >= '" + dateTimeInput1.Value + "' and INPUT_TIME <='" + dateTimeInput2.Value + "'";
                        this.dataGridViewX1.AutoGenerateColumns = false;
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql01);
                        break;
                case 1:
                    if (textBoxX1.Text == "")
                    {
                        MessageBoxEx.Show("检索关键字不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonX2.Enabled = false;
                        this.textBoxX1.Focus();
                        return;
                    }
                    buttonX2.Enabled = true;
                    string sql02 = "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO] WHERE GOOD_ID = '"+textBoxX1.Text+"'";
                    this.dataGridViewX1.AutoGenerateColumns = false;
                    dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql02);
                    break;
                case 2:
                    if (textBoxX1.Text == "")
                    {
                        MessageBoxEx.Show("检索关键字不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonX2.Enabled = false;
                        this.textBoxX1.Focus();
                        return;
                    }
                    buttonX2.Enabled = true ;
                    string sql03 = "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO] WHERE GOOD_NAME = '"+textBoxX1.Text+"'";
                    this.dataGridViewX1.AutoGenerateColumns = false;
                    dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql03);
                    break;
            
            }

        }

        private void storageinfo_Load(object sender, EventArgs e)
        {

            dateTimeInput1.Enabled = false;
            dateTimeInput2.Enabled = false;
            string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO]";
            this.dataGridViewX1.AutoGenerateColumns = false;
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
            


        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

            switch (comboBoxEx1.SelectedIndex)
            { 
                case 0:
                    int a = 3;
                    现有库存明细 st = new 现有库存明细(dateTimeInput1.Value,dateTimeInput2.Value,a);
                    st.StartPosition = FormStartPosition.CenterScreen;
                    st.ShowDialog();
                    break;
                case 1:
                    现有库存明细 stt = new 现有库存明细(textBoxX1.Text);
                    stt.StartPosition = FormStartPosition.CenterScreen;
                    stt.ShowDialog();
                    break;
                case 2:
                    int b = 1;
                    现有库存明细 sttt = new 现有库存明细(textBoxX1.Text,b);
                    sttt.StartPosition = FormStartPosition.CenterScreen;
                    sttt.ShowDialog();
                    break;
       
            }


        }

        private void buttonX3_Click(object sender, EventArgs e)
        {

            switch (this.comboBoxEx1.SelectedIndex)
            {
                case 0:
                    if (dateTimeInput2.Text == "" || dateTimeInput1.Text=="")
                    {
                        MessageBoxEx.Show("检索关键字不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonX4.Enabled = false;
                        return;
                    }

                    if (dateTimeInput2.Value < dateTimeInput1.Value)
                    {
                        MessageBoxEx.Show("结束日期不能小于开始日期！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonX4.Enabled = false;
                        return;
                    }
                    buttonX4.Enabled = true;
                    string sql01 = "SELECT *  FROM [ZCERP].[dbo].[ZH_GOOD_INFO_LOG] WHERE INPUT_TIME >= '" + dateTimeInput1.Value + "' and INPUT_TIME <='" + dateTimeInput2.Value + "'";
                    this.dataGridViewX1.AutoGenerateColumns = false;
                    dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql01);
                    break;
                case 1:
                    if (textBoxX1.Text == "")
                    {
                        MessageBoxEx.Show("检索关键字不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonX4.Enabled = false;
                        this.textBoxX1.Focus();
                        return;
                    }
                    buttonX4.Enabled = true;
                    string sql02 = "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO_LOG] WHERE GOOD_ID = '" + textBoxX1.Text + "'";
                    this.dataGridViewX1.AutoGenerateColumns = false;
                    dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql02);
                    break;
                case 2:
                    if (textBoxX1.Text == "")
                    {
                        MessageBoxEx.Show("检索关键字不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonX4.Enabled = false;
                        this.textBoxX1.Focus();
                        return;
                    }
                    buttonX4.Enabled = true;
                    string sql03 = "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO_LOG] WHERE GOOD_NAME = '" + textBoxX1.Text + "'";
                    this.dataGridViewX1.AutoGenerateColumns = false;
                    dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql03);
                    break;
            }

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {


            switch (comboBoxEx1.SelectedIndex)
            {
                case 0:
                    int a = 3;
                    历史库存报表 st = new 历史库存报表(dateTimeInput1.Value, dateTimeInput2.Value, a);
                    st.StartPosition = FormStartPosition.CenterScreen;
                    st.ShowDialog();
                    break;
                case 1:
                    历史库存报表 stt = new 历史库存报表(textBoxX1.Text);
                    stt.StartPosition = FormStartPosition.CenterScreen;
                    stt.ShowDialog();
                    break;
                case 2:
                    int b = 1;
                    历史库存报表 sttt = new 历史库存报表(textBoxX1.Text, b);
                    sttt.StartPosition = FormStartPosition.CenterScreen;
                    sttt.ShowDialog();
                    break;

            }

        }

    }
}
