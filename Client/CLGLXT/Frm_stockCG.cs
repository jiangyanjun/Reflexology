using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Foot.Client
{
    public partial class Frm_stockCG : Form
    {
        public Frm_stockCG()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 判断点菜是否保存
        /// </summary>
        public bool flag = false;
        /// <summary>
        /// 获取商品名称
        /// </summary>
        public static string RName;
        /// <summary>
        /// 获取商品数量
        /// </summary>
        public static string Num;
        /// <summary>
        /// 获取商品进货单价
        /// </summary>
        public static string price; 

        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        private void Frm_stockCG_Load(object sender, EventArgs e)
        {
           
            try
            {
                //填充lv_spqd 控件
                lv_spqd.Items.Clear();
                string str_sql = "select * from tb_goods";
                DataSet ds = db.GetDataFromSQL(str_sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i]["goods_ID"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["goods_Name"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Goods_Jhprice"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Goods_num"].ToString().Trim());
                    lv_spqd.Items.Add(lv);
                }
                //TB_ID.Text = "";
                //TB_Name.Text = "";
                //设置采购编号
                ds = db.GetDataFromSQL("select max(CG_ID) from tb_goodsCG ");
                string bh= ds.Tables[0].Rows[0][0].ToString().Trim();
                if (bh == "")
                {
                    LB_jhdh.Text = "CG" + DateTime.Now.ToString("yyyyMMdd") + "01";
                }
                else
                {
                    string sj = bh.Substring(2, 8).ToString().Trim();
                    if (Convert.ToInt32( DateTime.Now.ToString("yyyyMMdd"))>Convert.ToInt32(sj))
                    {
                        LB_jhdh.Text = "CG" + DateTime.Now.ToString("yyyyMMdd") + "01";
                    }
                    else
                    {
                        string rq = bh.Substring(10, 2).ToString().Trim();
                        LB_jhdh.Text =( Convert.ToInt32(rq)+1).ToString("CG"+DateTime.Now.ToString("yyyyMMdd")+"00").Trim();
                    }
                }

                //查询采购员编号
                str_sql = "select a.Waiter_Nmae  from tb_Waiter a,tb_duty b where a.Waiter_duty=b.Duty_ID and b.Duty_Name='采购员' ";
                ds = db.GetDataFromSQL(str_sql);
                if (ds.Tables[0].Rows[0][0].ToString().Trim() != "")
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        CB_Name.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim());
                    }
                    CB_Name.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("没有采购员");
                }
                TB_Name.Text = "";
                TB_Num.Text = "1";
                TB_Price.Text = "";
                
            }
            catch { }
            
        }

        private void TB_Num_Validating(object sender, CancelEventArgs e)
        {
            Regex re = new Regex(@"^[0-9]*$");
            if (!re.IsMatch(TB_Num.Text.Trim()))
            {
                MessageBox.Show("请输入数字");
                TB_Num.Text = "";
                e.Cancel = true;

            }
        }

        private void TB_Price_Validating(object sender, CancelEventArgs e)
        {
            Regex re = new Regex(@"^[0-9]*$");
            if (!re.IsMatch(TB_Price.Text.Trim()))
            {
                MessageBox.Show("请输入数字");
                TB_Price.Text = "";
                e.Cancel = true;

            }
        }

        private void lv_spqd_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv_spqd.SelectedItems.Count == 1)
                {
                    flag = true;
                    TB_Price.Text = lv_spqd.SelectedItems[0].SubItems[2].Text.Trim();
                    TB_Name.Text = lv_spqd.SelectedItems[0].SubItems[1].Text.Trim();
                    flag = false;
                }
            }
            catch { }
        }

        private void lv_spqd_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lv_spqd.SelectedItems.Count == 1)
                {
                    if (LV_info.Items.Count == 0)
                    {
                        ListViewItem lv = new ListViewItem(lv_spqd.SelectedItems[0].SubItems[1].Text.Trim());
                        lv.SubItems.Add(lv_spqd.SelectedItems[0].SubItems[2].Text.Trim());
                        lv.SubItems.Add(TB_Num.Text.Trim());
                        lv.SubItems.Add((Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(TB_Price.Text.Trim())).ToString().Trim());
                        lv.SubItems.Add("无");
                        LV_info.Items.Add(lv);
                        TB_Money.Text = (Convert.ToDouble(TB_Money.Text.Trim()) + Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(TB_Price.Text.Trim())).ToString().Trim();
                    }
                    else
                    {
                        for (int i = 0; i < LV_info.Items.Count; i++)
                        {
                            if (LV_info.Items[i].SubItems[0].Text.Trim() == lv_spqd.SelectedItems[0].SubItems[1].Text.Trim())
                            {

                                ListViewItem lv = new ListViewItem(LV_info.Items[i].SubItems[0].Text.Trim());
                                lv.SubItems.Add(LV_info.Items[i].SubItems[1].Text.Trim());
                                lv.SubItems.Add((Convert.ToInt32(LV_info.Items[i].SubItems[2].Text.Trim()) + Convert.ToInt32(TB_Num.Text.Trim())).ToString().Trim());
                                lv.SubItems.Add((Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(TB_Price.Text.Trim()) + Convert.ToDouble(LV_info.Items[i].SubItems[3].Text.Trim())).ToString().Trim());
                                lv.SubItems.Add(LV_info.Items[i].SubItems[4].Text.Trim());
                                LV_info.Items.Add(lv);
                                LV_info.Items.RemoveAt(LV_info.Items[i].Index);
                                TB_Money.Text = (Convert.ToDouble(TB_Money.Text.Trim()) + Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(TB_Price.Text.Trim())).ToString().Trim();

                                return;
                            }
                        }

                        ListViewItem lv1 = new ListViewItem(lv_spqd.SelectedItems[0].SubItems[1].Text.Trim());
                        lv1.SubItems.Add(lv_spqd.SelectedItems[0].SubItems[2].Text.Trim());
                        lv1.SubItems.Add(TB_Num.Text.Trim());
                        lv1.SubItems.Add((Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(TB_Price.Text.Trim())).ToString().Trim());
                        lv1.SubItems.Add("无");
                        LV_info.Items.Add(lv1);
                        TB_Money.Text = (Convert.ToDouble(TB_Money.Text.Trim()) + Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(TB_Price.Text.Trim())).ToString().Trim();

                    }
                    TB_Name.Text = "";
                    TB_Num.Text = "1";
                    TB_Price.Text = "";

                }
                else
                {
                    MessageBox.Show("请选择要采购的商品");
                }
            }
            catch { }
        }



        private void but_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_info.SelectedItems.Count == 1)
                {
                    LV_info.Items.RemoveAt(LV_info.SelectedItems[0].Index);
                }
                else
                {
                    MessageBox.Show("请选择要删除的商品");
                }
            }
            catch { }
        }



        private void but_xiugai_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_info.SelectedItems.Count == 1)
                {
                    Frm_XGCG xg = new Frm_XGCG();
                    xg.Num = LV_info.SelectedItems[0].SubItems[2].Text.Trim();
                    xg.RName = LV_info.SelectedItems[0].SubItems[0].Text.Trim();
                    xg.price = LV_info.SelectedItems[0].SubItems[1].Text.Trim();
                    xg.ID = "";
                    xg.ShowDialog();
                }
                else
                {
                    MessageBox.Show("请选择要修改的商品");
                }
            }
            catch { }
        }

        private void Frm_stockCG_Activated(object sender, EventArgs e)
        {
            try
            {
                if (RName != null && price != null && Num != null)
                {
                    if (LV_info.SelectedItems.Count == 1)
                    {

                        ListViewItem lv = new ListViewItem(RName);
                        lv.SubItems.Add(price);
                        lv.SubItems.Add(Num);
                        lv.SubItems.Add((Convert.ToInt32(Num) * Convert.ToDouble(price)).ToString().Trim());
                        lv.SubItems.Add("无");
                        TB_Money.Text = (Convert.ToDouble(TB_Money.Text.Trim()) + Convert.ToInt32(Num) * Convert.ToDouble(price) - Convert.ToDouble(LV_info.SelectedItems[0].SubItems[3].Text.Trim())).ToString().Trim();
                        LV_info.Items.Add(lv);

                        LV_info.Items.RemoveAt(LV_info.SelectedItems[0].Index);
                    }
                }
            }
            catch { }
        }
        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
                bool pd = false;
                if (LV_info.Items.Count > 0)
                {
                    if (CB_Name.Text.Trim() == "")
                    {
                        MessageBox.Show("请选择采购员");
                    }
                    else if (CB_Ghs.Text.Trim() == "")
                    {

                        MessageBox.Show("请输入供货商");
                    }
                    else
                    {
                        if (MessageBox.Show("确认要采购吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                        {
                            //插入商品采购信息
                            string str_sql = "insert into tb_goodsCG values('" + LB_jhdh.Text.Trim() + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + CB_Ghs.Text.Trim() + "','" + CB_Name.Text.Trim() + "','" + TB_Money.Text.Trim() + "','" + TB_BZ.Text.Trim() + "')";
                            pd = db.ExecSQl(str_sql);
                            for (int i = 0; i < LV_info.Items.Count; i++)
                            {
                                //获取商品名称
                                string name = LV_info.Items[i].SubItems[0].Text.Trim();
                                //查询商品类型
                                string type = db.GetDataFromSQL("select Goods_type from tb_goods where goods_Name='" + name + "'").Tables[0].Rows[0][0].ToString().Trim();
                                //插入采购商品明细
                                string sql = "insert into tb_goodsMX values('" + LB_jhdh.Text.Trim() + "','" + name + "','" + type + "','" + LV_info.Items[i].SubItems[1].Text.Trim() + "','" + LV_info.Items[i].SubItems[2].Text.Trim() + "','" + LV_info.Items[i].SubItems[3].Text.Trim() + "','" + LV_info.Items[i].SubItems[4].Text.Trim() + "')";
                                pd = db.ExecSQl(sql);
                                //查询商品 原有 数量 和金额
                                str_sql = "select Goods_num,Goods_allprice from tb_goods where goods_Name='" + name + "'";
                                DataSet ds = db.GetDataFromSQL(str_sql);
                                sql = "update tb_goods set Goods_num='" + (Convert.ToInt32(LV_info.Items[i].SubItems[2].Text.Trim()) + Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim())).ToString().Trim() + "',"
                                    + "Goods_allprice='" + (Convert.ToInt32(LV_info.Items[i].SubItems[3].Text.Trim()) + Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString().Trim())).ToString().Trim() + "' where goods_Name='" + name + "'";
                                pd = db.ExecSQl(sql);
                            }
                            if (pd)
                            {
                                MessageBox.Show("采购成功");
                                LV_info.Items.Clear();
                                this.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择要采购的商品");
                }
            }
            catch { }
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            lv_spqd_DoubleClick(sender, e);
        }

        private void CMS_Add_Click(object sender, EventArgs e)
        {
            lv_spqd_DoubleClick(sender, e);
        }

        private void CMS_Del_Click(object sender, EventArgs e)
        {
            but_Del_Click(sender, e);
        }

        private void CMS_xiugai_Click(object sender, EventArgs e)
        {
            but_xiugai_Click(sender, e);
        }

        private void TB_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void TB_Name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TB_Name.Text.Trim() == "")
                {
                    //填充lv_spqd 控件
                    lv_spqd.Items.Clear();
                    string str_sql = "select * from tb_goods";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i]["goods_ID"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["goods_Name"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["Goods_Jhprice"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["Goods_num"].ToString().Trim());
                        lv_spqd.Items.Add(lv);
                    }
                }
                else if (flag)
                { }
                else
                {
                    //填充lv_spqd 控件
                    lv_spqd.Items.Clear();
                    string str_sql = "select * from tb_goods where goods_Name like '%" + TB_Name.Text.Trim() + "%'";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i]["goods_ID"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["goods_Name"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["Goods_Jhprice"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["Goods_num"].ToString().Trim());
                        lv_spqd.Items.Add(lv);
                    }
                }
            }
            catch { }
        }

        private void TB_Price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TB_Price.Text.StartsWith("."))
                {
                    TB_Price.Text = "0.";
                    TB_Price.SelectionStart = 2;
                }
            }
            catch { }
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
    }
}
