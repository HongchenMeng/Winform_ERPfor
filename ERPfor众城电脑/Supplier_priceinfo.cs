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
    public partial class Supplier_priceinfo :Office2007Form
    {
        public string flag = "";
        public string pubtext = "";
        public Supplier_priceinfo()
        {
            InitializeComponent();
        }

        public Supplier_priceinfo(string a)
        {
            InitializeComponent();
            textBoxX5.Text = a;
        }

        private void Supplier_priceinfo_Load(object sender, EventArgs e)
        {
            textBoxX1.Enabled = false;
            textBoxX2.Enabled = false;
            textBoxX3.Enabled = false;
            textBoxX4.Enabled = false;
            textBoxX5.Enabled = false;
            textBoxX6.Enabled = false;
            comboBoxEx1.Enabled = false;
            comboBoxEx2.Enabled = false;
            comboBoxEx3.Enabled = false;
            dateTimeInput1.Enabled = false;
            dateTimeInput1.Value = DateTime.Now;
            textBoxX1.Text = GoodsID("ZC");
            textBoxX5.Text = GoodsID("OD");
            string sql = " SELECT * FROM [ZCERP].[dbo].[ZH_SUPPLIER_INFO] ";
            string sql02 = "SELECT * FROM [ZCERP].[dbo].[ZH_USER_INFO]";

            DataTable da = CARDAL.DbHelp.GetDataTable(sql02);
            textBoxX2.Text = da.Rows[0]["USER_NAME"].ToString();
            comboBoxEx1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
            comboBoxEx1.DisplayMember = "S_NAME";
            comboBoxEx1.ValueMember = "S_NAME";
            DataBind();



        }


        public void DataBind()
        {
            string sql = "SELECT * FROM ZH_GOOD_INFO GG";
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
            dataGridViewX1.AutoGenerateColumns = false;      
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

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxX1.Enabled = false;
            textBoxX2.Enabled = false;
            textBoxX3.Enabled = false;
            textBoxX4.Enabled = false;
            textBoxX6.Enabled = false;
            comboBoxEx1.Enabled = false;
            comboBoxEx2.Enabled = false;
            comboBoxEx3.Enabled = false;
            dateTimeInput1.Enabled = false;
            textBoxX3.Text = this.dataGridViewX1[0, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX1.Text = this.dataGridViewX1[7, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX2.Text = this.dataGridViewX1[8, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX4.Text = this.dataGridViewX1[1, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            textBoxX6.Text = this.dataGridViewX1[5, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
           // textBoxX5.Text = this.dataGridViewX1[9, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();
            comboBoxEx1.Text = this.dataGridViewX1[3, dataGridViewX1.CurrentCell.RowIndex].Value.ToString();

            if (this.dataGridViewX1[4, dataGridViewX1.CurrentCell.RowIndex].Value.ToString() !="")
            {
                dateTimeInput1.Value = (DateTime)this.dataGridViewX1[4, dataGridViewX1.CurrentCell.RowIndex].Value;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)//新增
        {

            textBoxX1.Enabled = false;
            textBoxX2.Enabled = false;
            textBoxX3.Enabled = true;
            textBoxX4.Enabled = true;
            textBoxX6.Enabled = true;
            comboBoxEx1.Enabled = true;
            comboBoxEx2.Enabled = true;
            comboBoxEx3.Enabled = true;
            dateTimeInput1.Enabled = true;
            flag = "add";
            //textBoxX1.Text = "";
           // textBoxX2.Text = "";
            textBoxX3.Text = "";
            textBoxX4.Text = "";
            textBoxX6.Text = "";
            comboBoxEx1.Text = "";
            comboBoxEx2.Text = "";
            comboBoxEx3.Text = "";
            dateTimeInput1.Value = DateTime.Now;
            textBoxX1.Text =  GoodsID("ZC");
            this.ActiveControl = textBoxX3;
            textBoxX3.Focus();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)//保存
        {


            if (flag == "add")
            {
                string p_sql = "SELECT * FROM ZH_PAY_SUPPLIER WHERE ORDER_ID ='"+textBoxX5.Text+"'";
                DataTable dp =CARDAL.DbHelp.GetDataTable(p_sql);
                if(textBoxX3.Text =="" || textBoxX4.Text =="" || comboBoxEx2.Text =="")
                {
                    MessageBoxEx.Show("物品名称+物品价格+采购数量 均不可为空！");
                    return;
                }

              if(dp.Rows.Count < 1)
              { 
                 if (MessageBoxEx.Show("此商品是否已对供应商付款？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //string c_sql = "INSERT INTO [ZH_SELL_SITUATION] (GOOD_ID,DO_PAY,DO_CELL_PAY,ORDER_ID) VALUES ('" + textBoxX1.Text + "','" + "1','"+ "2','"+textBoxX5.Text+"')";
                  //  CARDAL.DbHelp.GetExecuteNonQuery(c_sql);
                    string c = "是";
                    comboBoxEx1.Enabled = false;
                    Pay_Supplier ps = new Pay_Supplier(textBoxX5.Text, comboBoxEx1.Text,c);
                    ps.StartPosition = FormStartPosition.CenterScreen;
                    ps.ShowDialog();      
                  
                }
                else
                {
                   // string c_sql = "INSERT INTO [ZH_SELL_SITUATION] (GOOD_ID,DO_PAY,DO_CELL_PAY) VALUES ('" + textBoxX1.Text + "','" + "0','" + "2')";
                   // CARDAL.DbHelp.GetExecuteNonQuery(c_sql);
                    comboBoxEx1.Enabled = false;
                    string c = "否";
                    Pay_Supplier ps = new Pay_Supplier(textBoxX5.Text, comboBoxEx1.Text, c);
                    ps.StartPosition = FormStartPosition.CenterScreen;
                    ps.ShowDialog();            

                }
                  }
                string sql01 = "INSERT INTO  [ZCERP].[dbo].[ZH_GOOD_INFO] (GOOD_NAME,GOOD_PRICE,GOOD_UNITE,GOOD_SUPPLIER,INPUT_TIME,GOOD_CONTENT,GOOD_NUMBER,GOOD_ID,INPUTER,ORDER_ID) VALUES ('" + textBoxX3.Text + "','" + textBoxX4.Text + "','" + comboBoxEx3.Text + "','" + comboBoxEx1.Text + "','" + dateTimeInput1.Text + "','" + textBoxX6.Text + "','" + comboBoxEx2.Text + "','" + textBoxX1.Text + "','" + textBoxX2.Text + "','"+textBoxX5.Text+"')";
                CARDAL.DbHelp.GetExecuteNonQuery(sql01);
                string sql02 = "INSERT INTO  [ZCERP].[dbo].[ZH_GOOD_INFO_LOG] (GOOD_NAME,GOOD_PRICE,GOOD_UNITE,GOOD_SUPPLIER,INPUT_TIME,GOOD_CONTENT,GOOD_NUMBER,GOOD_ID,INPUTER,ORDER_ID) VALUES ('" + textBoxX3.Text + "','" + textBoxX4.Text + "','" + comboBoxEx3.Text + "','" + comboBoxEx1.Text + "','" + dateTimeInput1.Text + "','" + textBoxX6.Text + "','" + comboBoxEx2.Text + "','" + textBoxX1.Text + "','" + textBoxX2.Text + "','" + textBoxX5.Text + "')";
                CARDAL.DbHelp.GetExecuteNonQuery(sql02);
               // MessageBoxEx.Show("提示信息：采购物品信息添加成功!");
                DataBind();
                //textBoxX1.Text = "";
                // textBoxX2.Text = "";
                textBoxX3.Text = "";
                textBoxX4.Text = "";
                textBoxX6.Text = "";
                // comboBoxEx1.Text = "";
                comboBoxEx2.Text = "";
                comboBoxEx3.Text = "";
                //dateTimeInput1.Text = "";
                GoodsID("ZC");
                if ((MessageBoxEx.Show("是否继续对此订单追加商品？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                {
                    this.Close();
                }
                else
                {
                   // textBoxX5.Text = GoodsID("OD");
                    textBoxX1.Enabled = false;
                    textBoxX2.Enabled = false;
                    textBoxX3.Enabled = false;
                    textBoxX4.Enabled = false;
                    textBoxX6.Enabled = false;
                    comboBoxEx1.Enabled = false;
                    comboBoxEx2.Enabled = false;
                    comboBoxEx3.Enabled = false;
                    dateTimeInput1.Enabled = false;

                }

            }

            if (flag == "EDITOR")
            {
                string sql04 = "UPDATE [ZCERP].[dbo].[ZH_GOOD_INFO] SET GOOD_NAME='" + textBoxX3.Text + "',GOOD_PRICE='" + textBoxX4.Text + "',GOOD_UNITE='" + comboBoxEx2.Text + "',GOOD_SUPPLIER='" + comboBoxEx1.Text + "',GOOD_CONTENT='" +textBoxX6.Text + "',GOOD_NUMBER='"+comboBoxEx2.Text+"' WHERE GOOD_ID ='" + pubtext + "'";

                if (MessageBoxEx.Show("确定修改此条物品信息！ ", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    CARDAL.DbHelp.GetExecuteNonQuery(sql04);
                    MessageBoxEx.Show("提示信息：物品" + pubtext + "已修改！");
                    DataBind();

                }
                textBoxX1.Enabled = false;
                textBoxX2.Enabled = false;
                textBoxX3.Enabled = false;
                textBoxX4.Enabled = false;
                textBoxX6.Enabled = false;
                comboBoxEx1.Enabled = false;
                comboBoxEx2.Enabled = false;
                comboBoxEx3.Enabled = false;
                dateTimeInput1.Enabled = false;
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)//编辑
        {
            if (textBoxX3.Text != "")
            {
                comboBoxEx2.Enabled = true;
                comboBoxEx3.Enabled = true;
               // dateTimeInput1.Enabled = true;
                textBoxX6.Enabled = true;
                textBoxX3.Enabled = true;
                textBoxX4.Enabled = true;

                flag = "EDITOR";
                pubtext = textBoxX1.Text.Trim();

            }
            else
            {
                return;

            }



        }

        private void toolStripButton3_Click(object sender, EventArgs e)//删除
        {
            string del = textBoxX1.Text;
            string q_sql = "SELECT * FROM ZH_PAY_SUPPLIER WHERE ORDER_ID = '" + textBoxX5.Text + "'";
            string s_sele= "SELECT * FROM [ZCERP].[dbo].[ZH_SELL_SITUATION] WHERE GOOD_ID ='" + del + "'";
            string sql03 = "DELETE FROM [ZCERP].[dbo].[ZH_GOOD_INFO] WHERE GOOD_ID ='" + del + "'";
            DataTable das = CARDAL.DbHelp.GetDataTable(s_sele);
            DataTable dq = CARDAL.DbHelp.GetDataTable(q_sql);

            if (dq.Rows.Count < 1)
            {

                if (MessageBoxEx.Show("确定删除此条物品信息！ ", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (das.Rows.Count < 1)
                    {
                        CARDAL.DbHelp.GetExecuteNonQuery(sql03);
                        MessageBoxEx.Show("提示信息：物品" + del + "已删除！");
                        DataBind();
                    }
                    else
                    {
                        MessageBoxEx.Show("此订货单无法删除，因为已有出售记录！");
                        return;
                    }
                }

            }
            else
            {
                MessageBoxEx.Show("无法删除此条信息！请先删除供应商付款！");
            
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)//刷新
        {

            DataBind();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)//退出
        {

            this.Close();

        }// end if 

    }
}
