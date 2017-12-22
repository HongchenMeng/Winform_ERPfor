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
    public partial class Load_Info : Office2007Form
    {
        public Load_Info()
        {
            InitializeComponent();
        }

        private void Load_Info_Load(object sender, EventArgs e)
        {
            DataBind();
            DataBindd();
        }

        public void DataBind()
        {
            string sql = " SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER]";
            dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
            dataGridViewX1.AutoGenerateColumns = false;
        }

        public void DataBindd()
        {
            string sql = " SELECT * FROM  [ZCERP].[dbo].[ZH_PAY_SUPPLIER]";
            dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
            dataGridViewX2.AutoGenerateColumns = false;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            switch (comboBoxEx1.SelectedIndex)
            {
                case 0:
                    if (dateTimeInput1.Text ==""&&dateTimeInput2.Text =="")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='1'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='1' AND LOAD_DATE >='"+dateTimeInput1.Value+"'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='1' AND LOAD_DATE >='" + dateTimeInput1.Value + "' AND LOAD_DATE <='" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }


                    if (dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='1' AND LOAD_DATE <='" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }
                    break;

                case 1:

                      if (dateTimeInput1.Text ==""&&dateTimeInput2.Text =="")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='0'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='0' AND LOAD_DATE >='"+dateTimeInput1.Value+"'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    if (dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='0' AND LOAD_DATE >='" + dateTimeInput1.Value + "' AND LOAD_DATE <='" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }


                    if (dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='0' AND LOAD_DATE <='" + dateTimeInput2.Value + "'";
                        dataGridViewX1.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX1.AutoGenerateColumns = false;
                        return;
                    }

                    break;
            
            }

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {

            switch (comboBoxEx2.SelectedIndex)
            {
                case 0:
                    if (dateTimeInput3.Text == "" && dateTimeInput4.Text == "")
                    {
                        string sql = "SELECT * FROM   [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='是'";
                        dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX2.AutoGenerateColumns = false;
                        return;
                    }

                    if (dateTimeInput3.Text != "" && dateTimeInput4.Text == "")
                    {
                        string sql = "SELECT * FROM   [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='是' AND Input_Date >='" + dateTimeInput3.Value + "'";
                        dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX2.AutoGenerateColumns = false;
                        return;
                    }

                    if (dateTimeInput3.Text != "" && dateTimeInput4.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='是' AND Input_Date >='" + dateTimeInput3.Value + "' AND Input_Date <='" + dateTimeInput4.Value + "'";
                        dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX2.AutoGenerateColumns = false;
                        return;
                    }


                    if (dateTimeInput3.Text == "" && dateTimeInput4.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='是' AND Input_Date <='" + dateTimeInput4.Value + "'";
                        dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX2.AutoGenerateColumns = false;
                        return;
                    }
                    break;

                case 1:

                    if (dateTimeInput3.Text == "" && dateTimeInput4.Text == "")
                    {
                        string sql = "SELECT * FROM   [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='否'";
                        dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX2.AutoGenerateColumns = false;
                        return;
                    }

                    if (dateTimeInput3.Text != "" && dateTimeInput4.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='否' AND Input_Date >='" + dateTimeInput3.Value + "'";
                        dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX2.AutoGenerateColumns = false;
                        return;
                    }

                    if (dateTimeInput3.Text != "" && dateTimeInput4.Text != "")
                    {
                        string sql = "SELECT * FROM   [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='否' AND Input_Date >='" + dateTimeInput3.Value + "' AND Input_Date <='" + dateTimeInput4.Value + "'";
                        dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX2.AutoGenerateColumns = false;
                        return;
                    }


                    if (dateTimeInput3.Text == "" && dateTimeInput4.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M  ='否' AND Input_Date  <='" + dateTimeInput4.Value + "'";
                        dataGridViewX2.DataSource = CARDAL.DbHelp.GetDataTable(sql);
                        dataGridViewX2.AutoGenerateColumns = false;
                        return;
                    }

                    break;
            }

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

            switch (comboBoxEx1.SelectedIndex)
            {
                case 0:
                    if (dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='1'";
                        Guest_Load gl = new Guest_Load(sql);
                        gl.StartPosition = FormStartPosition.CenterScreen;
                        gl.ShowDialog();
                        return;
                    }

                    if (dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='1' AND LOAD_DATE >='" + dateTimeInput1.Value + "'";
                        Guest_Load gl = new Guest_Load(sql);
                        gl.StartPosition = FormStartPosition.CenterScreen;
                        gl.ShowDialog();
                        return;
                    }

                    if (dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='1' AND LOAD_DATE >='" + dateTimeInput1.Value + "' AND LOAD_DATE <='" + dateTimeInput2.Value + "'";
                        Guest_Load gl = new Guest_Load(sql);
                        gl.StartPosition = FormStartPosition.CenterScreen;
                        gl.ShowDialog();
                        return;
                    }


                    if (dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='1' AND LOAD_DATE <='" + dateTimeInput2.Value + "'";
                        Guest_Load gl = new Guest_Load(sql);
                        gl.StartPosition = FormStartPosition.CenterScreen;
                        gl.ShowDialog();
                        return;
                    }
                    break;

                case 1:

                    if (dateTimeInput1.Text == "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='0'";
                        Guest_Load gl = new Guest_Load(sql);
                        gl.StartPosition = FormStartPosition.CenterScreen;
                        gl.ShowDialog();
                        return;
                    }

                    if (dateTimeInput1.Text != "" && dateTimeInput2.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='0' AND LOAD_DATE >='" + dateTimeInput1.Value + "'";
                        Guest_Load gl = new Guest_Load(sql);
                        gl.StartPosition = FormStartPosition.CenterScreen;
                        gl.ShowDialog();
                        return;
                    }

                    if (dateTimeInput1.Text != "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='0' AND LOAD_DATE >='" + dateTimeInput1.Value + "' AND LOAD_DATE <='" + dateTimeInput2.Value + "'";
                        Guest_Load gl = new Guest_Load(sql);
                        gl.StartPosition = FormStartPosition.CenterScreen;
                        gl.ShowDialog();
                        return;
                    }


                    if (dateTimeInput1.Text == "" && dateTimeInput2.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_LOADER] WHERE DO_PAY_ALL ='0' AND LOAD_DATE <='" + dateTimeInput2.Value + "'";
                        Guest_Load gl = new Guest_Load(sql);
                        gl.StartPosition = FormStartPosition.CenterScreen;
                        gl.ShowDialog();
                        return;
                    }
                    break;
            }

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {

            switch (comboBoxEx2.SelectedIndex)
            {
                case 0:
                    if (dateTimeInput3.Text == "" && dateTimeInput4.Text == "")
                    {
                        string sql = "SELECT * FROM   [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='是'";
                        Supplier_Load sl = new Supplier_Load (sql);
                        sl.StartPosition = FormStartPosition.CenterScreen;
                        sl.ShowDialog();
                        return;
                    }

                    if (dateTimeInput3.Text != "" && dateTimeInput4.Text == "")
                    {
                        string sql = "SELECT * FROM   [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='是' AND Input_Date >='" + dateTimeInput3.Value + "'";
                        Supplier_Load sl = new Supplier_Load(sql);
                        sl.StartPosition = FormStartPosition.CenterScreen;
                        sl.ShowDialog();
                        return;
                    }

                    if (dateTimeInput3.Text != "" && dateTimeInput4.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='是' AND Input_Date >='" + dateTimeInput3.Value + "' AND Input_Date <='" + dateTimeInput4.Value + "'";
                        Supplier_Load sl = new Supplier_Load(sql);
                        sl.StartPosition = FormStartPosition.CenterScreen;
                        sl.ShowDialog();
                        return;
                    }


                    if (dateTimeInput3.Text == "" && dateTimeInput4.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='是' AND Input_Date <='" + dateTimeInput4.Value + "'";
                        Supplier_Load sl = new Supplier_Load(sql);
                        sl.StartPosition = FormStartPosition.CenterScreen;
                        sl.ShowDialog();
                        return;
                    }
                    break;

                case 1:

                    if (dateTimeInput3.Text == "" && dateTimeInput4.Text == "")
                    {
                        string sql = "SELECT * FROM   [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='否'";
                        Supplier_Load sl = new Supplier_Load(sql);
                        sl.StartPosition = FormStartPosition.CenterScreen;
                        sl.ShowDialog();
                        return;
                    }

                    if (dateTimeInput3.Text != "" && dateTimeInput4.Text == "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='否' AND Input_Date >='" + dateTimeInput3.Value + "'";
                        Supplier_Load sl = new Supplier_Load(sql);
                        sl.StartPosition = FormStartPosition.CenterScreen;
                        sl.ShowDialog();
                        return;
                    }

                    if (dateTimeInput3.Text != "" && dateTimeInput4.Text != "")
                    {
                        string sql = "SELECT * FROM   [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M ='否' AND Input_Date >='" + dateTimeInput3.Value + "' AND Input_Date <='" + dateTimeInput4.Value + "'";
                        Supplier_Load sl = new Supplier_Load(sql);
                        sl.StartPosition = FormStartPosition.CenterScreen;
                        sl.ShowDialog();
                        return;
                    }


                    if (dateTimeInput3.Text == "" && dateTimeInput4.Text != "")
                    {
                        string sql = "SELECT * FROM  [ZCERP].[dbo].[ZH_PAY_SUPPLIER] WHERE OD_PAY_ALL_M  ='否' AND Input_Date  <='" + dateTimeInput4.Value + "'";
                        Supplier_Load sl = new Supplier_Load(sql);
                        sl.StartPosition = FormStartPosition.CenterScreen;
                        sl.ShowDialog();
                        return;
                    }
                    break;
            }

        }

     
    }
}
