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
    public partial class Log_Form : Office2007Form
    {
         // this.StartPosition = FormStartPosition.CenterScreen;
        public Log_Form()
        {
            InitializeComponent();
        }

        //简单写写 省略防 SQL注入部分 
        private void buttonX1_Click(object sender, EventArgs e)
        {
            logging();
        }

        private void Log_Form_Load(object sender, EventArgs e)
        {
            int height = Screen.PrimaryScreen.WorkingArea.Height;
            int width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = new Point((width - this.Width) / 2, (height - this.Height) / 2);
            this.ActiveControl = textBoxX2;
            textBoxX2.Focus();
        }

    
        public void logging()
        {
            string user_id = textBoxX2.Text;
            string user_psw = textBoxX1.Text;
            string sql = "SELECT * FROM [ZCERP].[dbo].[ZH_USER_INFO] WHERE  USER_ID = '" + user_id + "' AND USER_PSW ='" + user_psw + "'";
            DataTable da = CARDAL.DbHelp.GetDataTable(sql);
            if (da.Rows.Count >= 1)
            {
                Main_Frame mf = new Main_Frame();
                mf.StartPosition = FormStartPosition.CenterScreen;
                mf.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBoxEx.Show("用户名或密码不正确！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void textBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                logging();          
            }

        }

    }
}
