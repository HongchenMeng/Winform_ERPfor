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
    public partial class Main_Frame : Office2007Form
    {
        public Main_Frame()
        {
            InitializeComponent();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Frame_Load(object sender, EventArgs e)
        {

            WorkFlow wf = new WorkFlow();
            wf.TopLevel = false;
            this.panelEx2.Controls.Add(wf);
            wf.Show();
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            Supplier_info sp = new Supplier_info();
            sp.ShowDialog();
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            Supplier_info sp = new Supplier_info();
            sp.StartPosition = FormStartPosition.CenterScreen;
            sp.ShowDialog();

        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            Supplier_priceinfo spp = new Supplier_priceinfo();
            spp.StartPosition = FormStartPosition.CenterScreen;
            spp.ShowDialog();
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            Supplier_priceinfo spp = new Supplier_priceinfo();
            spp.StartPosition = FormStartPosition.CenterScreen;
            spp.ShowDialog();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            Good_Cell gc = new Good_Cell();
            gc.StartPosition = FormStartPosition.CenterScreen;
            gc.ShowDialog();

        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            Good_Cell gc = new Good_Cell();
            gc.StartPosition = FormStartPosition.CenterScreen;
            gc.ShowDialog();
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            storageinfo sf = new storageinfo();
            sf.StartPosition = FormStartPosition.CenterScreen;
            sf.ShowDialog();
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            storageinfo sf = new storageinfo();
            sf.StartPosition = FormStartPosition.CenterScreen;
            sf.ShowDialog();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            Cancel_Cuestcs cc = new Cancel_Cuestcs();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            Cancel_Cuestcs cc = new Cancel_Cuestcs();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            Cancel_Supplier cc = new Cancel_Supplier();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            Cancel_Supplier cc = new Cancel_Supplier();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem28_Click(object sender, EventArgs e)
        {
            Return_Good cc = new Return_Good();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem29_Click(object sender, EventArgs e)
        {
            Return_Good cc = new Return_Good();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {
            storageinfo cc = new storageinfo();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {
            storageinfo cc = new storageinfo();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem25_Click(object sender, EventArgs e)
        {
            Sell_Situation cc = new Sell_Situation();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();

        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            Load_Info cc = new Load_Info();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem30_Click(object sender, EventArgs e)
        {
            storageinfo cc = new storageinfo();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem31_Click(object sender, EventArgs e)
        {
            Sell_Situation cc = new Sell_Situation();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem32_Click(object sender, EventArgs e)
        {
            Load_Info cc = new Load_Info();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }


        private void buttonItem27_Click(object sender, EventArgs e)
        {
            Return_Info cc = new Return_Info();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();

        }

        private void buttonItem33_Click(object sender, EventArgs e)
        {
            Return_Info cc = new Return_Info();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();

        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            admin_system cc = new admin_system();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            admin_system cc = new admin_system();
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.ShowDialog();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
