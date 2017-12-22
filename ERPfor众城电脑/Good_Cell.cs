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
    public partial class Good_Cell : Office2007Form
    {
        public string pub_text = "";
        public string text = "";
        public string goog_name = "";
        public string name = "";
        public string good_id = "";
        public string id = "";
        public Good_Cell()
        {
            InitializeComponent();
        }

        private void Good_Cell_Load(object sender, EventArgs e)
        {
            //string sql01 = "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO] ";
            string sql02 = " SELECT DISTINCT GOOD_NAME FROM [ZCERP].[dbo].[ZH_GOOD_INFO] GROUP BY GOOD_NAME";
            //textBoxX3.Enabled = false;
            this.ActiveControl = textBoxX1;
            textBoxX4.Enabled = true;
            textBoxX6.Enabled = true;
            textBoxX1.Enabled = true;
            textBoxX3.Enabled = false;
           // textBoxDropDown1.Enabled = false;
            dateTimeInput1.Value = DateTime.Now;
            comboBoxEx1.DataSource = CARDAL.DbHelp.GetDataTable(sql02);
            comboBoxEx1.DisplayMember = "GOOD_NAME";
            comboBoxEx1.ValueMember = "GOOD_NAME";
           // comboBoxEx2.DataSource = CARDAL.DbHelp.GetDataTable(sql01);
            //comboBoxEx2.DisplayMember = "GOOD_ID";
           // comboBoxEx2.ValueMember = "GOOD_ID";
            textBoxX3.Text = GoodsID("SD");
            Data_Bind();
            textBoxX1.Focus();
          
        }

        public void Data_Bind ()
        {
            string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO]  ";
            dataGridViewX1.AutoGenerateColumns = false;
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);     
           // dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
           // dataGridViewX1.AutoGenerateColumns = false;
        }

        public string GoodsID(string Letters)
        {
            #region 生成物品ID
            int intYear = DateTime.Now.Year;
            int intMonth = DateTime.Now.Month;
            int intDate = DateTime.Now.Day;
            int intHour = DateTime.Now.Hour;
            int intSecond = DateTime.Now.Second;
            int intMinute = DateTime.Now.Minute;
            string strTime = null;
            strTime = intYear.ToString();
            if (intMonth < 10)
            {
                strTime += "0" + intMonth.ToString();
            }
            else
            {
                strTime += intMonth.ToString();
            }
            if (intDate < 10)
            {
                strTime += "0" + intDate.ToString();
            }
            else
            {
                strTime += intDate.ToString();
            }
            if (intHour < 10)
            {
                strTime += "0" + intHour.ToString();
            }
            else
            {
                strTime += intHour.ToString();
            }
            if (intMinute < 10)
            {

                strTime += "0" + intMinute.ToString();
            }
            else
            {
                strTime += intMinute.ToString();
            }
            if (intSecond < 10)
            {

                strTime += "0" + intSecond.ToString();
            }
            else
            {
                strTime += intSecond.ToString();
            }

            return ((Letters.ToString() + "-") + strTime);
            #endregion
        }

      /*  private void comboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c_text = comboBoxEx2.Text;
            if (c_text != "" && c_text != "System.Data.DataRowView")
            {
                string c_sql = "SELECT * FROM ZH_GOOD_INFO WHERE GOOD_ID ='" + c_text + "'";
               // comboBoxEx1.DataSource = CARDAL.DbHelp.GetDataTable(c_sql);
               // comboBoxEx1.DisplayMember = "GOOD_NAME";
               // comboBoxEx1.ValueMember = "GOOD_NAME";
                DataTable da = CARDAL.DbHelp.GetDataTable(c_sql);
                textBoxX4.Text = Convert.ToString(da.Rows[0]["GOOD_SUPPLIER"]);
                labelX7.Text ="你选编号对应的物品名称："+ Convert.ToString(da.Rows[0]["GOOD_NAME"]);
                dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(c_sql);
                dataGridViewX1.AutoGenerateColumns = false;
            }
        }*/

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c_text01 = comboBoxEx1.Text;
            string c_sql01 = "SELECT * FROM ZH_GOOD_INFO WHERE GOOD_NAME ='" + c_text01 + "'";
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(c_sql01);
            dataGridViewX1.AutoGenerateColumns = false;
           // dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(c_sql01);
            //dataGridViewX1.AutoGenerateColumns = false;
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // comboBoxEx2.SelectedText = this.dataGridViewX1[1, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();

           // string abc = this.dataGridViewX1[7, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            comboBoxEx1.Text = this.dataGridViewX1[0,dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX1.Text = this.dataGridViewX1[7, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX4.Text = this.dataGridViewX1[3,dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            labelX7.Text = "你选择编号对应的物品名称：" + textBoxX1.Text;            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            string sql02 = "SELECT * FROM [ZCERP].[dbo].[ZH_GOOD_INFO]";
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql02);
            dataGridViewX1.AutoGenerateColumns = false;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            string t_text = textBoxX1.Text;
            string t_sql = "SELECT * FROM ZH_GOOD_INFO WHERE GOOD_ID ='" + t_text + "'";
           // string cc_sql = "SELECT * FROM [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE GOOD_ID ='"+t_text+"'";
           // string ccc_sql = "SELECT * FROM [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE GOOD_ID ='" + t_text + "'"+"AND DO_CELL_PAY ='2'";
            DataTable da = CARDAL.DbHelp.GetDataTable(t_sql);
          //  DataTable dc = CARDAL.DbHelp.GetDataTable(cc_sql);
           // DataTable dcc = CARDAL.DbHelp.GetDataTable(ccc_sql);
           // string order_id = da.Rows[0]["ORDER_ID"].ToString();
            int count = da.Rows.Count;
           // int countt = dc.Rows.Count;

            if(t_text == "")
            {
                MessageBoxEx.Show("商品编号不能为空！");
            return;
            
            }
            if (count < 1)
            {
                textBoxX1.Text = "提示信息：没有此库存信息  " + t_text;
                return;
            }
            //付款处理
            if (textBoxX2.Text != "")
            {
                pub_text = textBoxX1.Text + "," + comboBoxEx1.Text + "," + textBoxX2.Text + ";";
                text += pub_text;
                goog_name = comboBoxEx1.Text + ",";
                name += goog_name;
                good_id = textBoxX1.Text + ",";
                id += good_id;
                textBoxX5.Text = text;
                textBoxX2.Text = "";
               /* if ((MessageBoxEx.Show("是否继续销售商品？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                {

                    if (MessageBoxEx.Show("  买家是否已付全款？             ", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string c_sql = "INSERT INTO [ZH_SELL_SITUATION] (GOOD_ID,DO_PAY,DO_CELL_PAY,PAY_MUCH,ORDER_ID) VALUES ('" + textBoxX1.Text + "',''," + "'1','" + textBoxX2.Text + "','" + order_id + "')";
                        CARDAL.DbHelp.GetExecuteNonQuery(c_sql);
                    }
                    else
                    {
                        string c_sql = "INSERT INTO [ZH_SELL_SITUATION] (GOOD_ID,DO_PAY,DO_CELL_PAY,PAY_MUCH,ORDER_ID) VALUES ('" + textBoxX1.Text + "',''," + "'0','" + textBoxX2.Text + "','" + order_id + "')";
                        CARDAL.DbHelp.GetExecuteNonQuery(c_sql);
                        string c = "否";
                        Guest_Pay gp = new Guest_Pay(textBoxX1.Text,textBoxX3.Text,c,comboBoxEx1.Text);
                        gp.ShowDialog();
                        MessageBoxEx.Show("请注意此客人未付全款！");
                    }
                }
                else
                {
                    return;
                }*/
            }
            else
            {
                MessageBoxEx.Show("销售价格不可为空值！此客人未付款！-->>请继续填单,做好记录！");
                return;
            }

            //
            if (Convert.ToInt32(da.Rows[0]["GOOD_NUMBER"]) > 1)
            {
                int GOOD_NUMBER = Convert.ToInt32(da.Rows[0]["GOOD_NUMBER"]) - 1;
                string n_sql = "UPDATE ZH_GOOD_INFO SET GOOD_NUMBER ='" + GOOD_NUMBER + "' WHERE GOOD_ID ='" + t_text + "'";
                CARDAL.DbHelp.GetExecuteNonQuery(n_sql);
                //MessageBoxEx.Show("提示信息：成功将商品 " + t_text + " 销售一比！ 剩余" + GOOD_NUMBER + "比！");
            }
            else
            {
                string n_sql = "DELETE FROM ZH_GOOD_INFO WHERE GOOD_ID ='" + t_text + "'";
                CARDAL.DbHelp.GetExecuteNonQuery(n_sql);
                //MessageBoxEx.Show("提示信息：成功将商品 " + t_text + " 销售一比！ 剩余 0 比！");
            }

            //string i_sql = "INSERT INTO [ZCERP].[dbo].[ZH_GOOD_CELL] (GOOD_NAME,GOOD_ID,GOOD_NUMBER,GOOD_SUPPLIER,GOOD_SELL_PRICE,GOOD_SELL_DATE,SELLER) VALUES ('"+comboBoxEx1.Text+"','"+textBoxX1.Text+"','"+"1','"+textBoxX4.Text+"','"+textBoxX2.Text+"','"+dateTimeInput1.Value+"','"+textBoxX6.Text+"')";
           // CARDAL.DbHelp.GetExecuteNonQuery(i_sql);
            Data_Bind();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            if((MessageBoxEx.Show("买家是否已付全款？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
            int i = 0;
            //int k = 0;
           // int n = 0;
            string [] a_array = textBoxX5.Text.Split(';');
            int j = a_array.Count() - 1;
            for (i = 0; i < j; i++)
            {
                string[] a_arrayy = a_array[i].Split(',');
                string a = a_arrayy[0];
                string b = a_arrayy[1];
                string c = a_arrayy[2];
                string i_sql = "INSERT INTO [ZCERP].[dbo].[ZH_SELL_SITUATION] (GOOD_ID,DO_PAY,DO_CELL_PAY,PAY_MUCH,ORDER_ID,SELL_ID,GOOD_NAME,SELL_DATE) VALUES ('" + a + "','" + "1','" + "1','" + c + "','" + "','" + textBoxX3.Text + "','" + b + "','" + dateTimeInput1.Text + "')";
                CARDAL.DbHelp.GetExecuteNonQuery(i_sql);
            }
            this.Enabled = false;
            MessageBoxEx.Show("销售成功！", "提示信息");
            this.Close();
            }
            else
            {
                int i = 0;
                //int k = 0;
                // int n = 0;
                string[] a_array = textBoxX5.Text.Split(';');
                int j = a_array.Count() - 1;
                for (i = 0; i < j; i++)
                {
                    string[] a_arrayy = a_array[i].Split(',');
                    string a = a_arrayy[0];
                    string b = a_arrayy[1];
                    string c = a_arrayy[2];
                    string i_sql = "INSERT INTO [ZCERP].[dbo].[ZH_SELL_SITUATION] (GOOD_ID,DO_PAY,DO_CELL_PAY,PAY_MUCH,ORDER_ID,SELL_ID,GOOD_NAME,SELL_DATE) VALUES ('" + a + "','" + "0','" + "0','" + c + "','" + "','" + textBoxX3.Text + "','" + b + "','" + dateTimeInput1.Text + "')";
                    CARDAL.DbHelp.GetExecuteNonQuery(i_sql);
                }                  
                string ys = "否";
                Guest_Pay gy = new Guest_Pay(id,textBoxX3.Text,ys,name);
                this.Enabled = false;
                gy.StartPosition = FormStartPosition.CenterScreen;
                gy.ShowDialog();
                this.Close();
            }
        }

    /*    private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            string t_text = textBoxX1.Text;
            string t_sql = "SELECT * FROM ZH_GOOD_INFO WHERE GOOD_ID ='" + t_text + "'";
            DataTable da = CARDAL.DbHelp.GetDataTable(t_sql);
            int count = da.Rows.Count;
            if ( count < 1)
            {
                textBoxX1.Text = "提示信息：没有此库存信息  " + t_text;
            
            }
            
        }*/

    }
}
