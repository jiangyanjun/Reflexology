using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Foot.Client
{
    public partial class Frm_XGCG : Form
    {
        public Frm_XGCG()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取商品名称
        /// </summary>
        public string RName;
        /// <summary>
        /// 获取商品数量
        /// </summary>
        public string Num;
        /// <summary>
        /// 获取商品进货单价
        /// </summary>
        public string price;
        /// <summary>
        /// 获取商品编号
        /// </summary>
        public string ID;
        private void Frm_XGCG_Load(object sender, EventArgs e)
        {
            TB_ID.Text = ID;
            TB_Name.Text = RName;
            TB_num.Text = Num;
            TB_Price.Text = price;
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Frm_stockCG.RName = null;
            Frm_stockCG.price = null;
            Frm_stockCG.Num = null;

            this.Close();

        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            if (TB_num.Text != "" && TB_Price.Text != "")
            {
                Frm_stockCG.RName = TB_Name.Text.Trim();
                 Frm_stockCG.price = TB_Price.Text.Trim();
                 Frm_stockCG.Num = TB_num.Text.Trim();
                this.Close();
            }
        }

        private void TB_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void TB_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar) && e.KeyChar != 46)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
            if (this.TB_Price.Text.Contains("."))
            {
                if (e.KeyChar == 46)
                {
                    e.Handled = true;
                }
            }
        }

        private void TB_Price_TextChanged(object sender, EventArgs e)
        {
            if (TB_Price.Text.StartsWith("."))
            {
                TB_Price.Text = "0.";
                TB_Price.SelectionStart = 2;
            }
        }
    }
}
