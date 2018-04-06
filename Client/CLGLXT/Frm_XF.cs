using Kebue.Core.Util;
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
    public partial class Frm_XF : Form
    {
        public Frm_XF()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 判断点菜是否保存
        /// </summary>
        public bool flag = false;
        /// <summary>
        /// 获取桌台名称
        /// </summary>
        public string Rname;
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        private void Frm_XF_Load(object sender, EventArgs e)
        {
            groupBox2.Text = Rname + "桌台消费清单";
            xianshisp();

            //cx();
        }
        /// <summary>
        /// 显示商品信息
        /// </summary>
        private void xianshisp()
        {
            try
            {
                lv_spinfo.Items.Clear();
                string str_sql = "select goods_ID,goods_Name,Goods_Xsprice,Goods_num from tb_goods";
                DataSet ds = db.GetDataFromSQL(str_sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i][0].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i][1].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i][2].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i][3].ToString().Trim());
                    lv_spinfo.Items.Add(lv);
                }
                TB_name.Text = "";
                TB_Num.Text = "1";
            }
            catch { }
        }
        /// <summary>
        /// 查询此桌台已消费的商品
        /// </summary>

        //private void cx()
        //{
        //    LV_xfinfo.Items.Clear();
        //    string str_sql = "select XS_goodsName,XS_dj,XS_Sum,XS_allprice,XS_sj from tb_DeskXS where XS_DeskName='" + Rname + "'";
        //    DataSet ds = db.GetDataFromSQL(str_sql);
        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i][0].ToString().Trim());
        //        lv.SubItems.Add(ds.Tables[0].Rows[i][1].ToString().Trim());
        //        lv.SubItems.Add(ds.Tables[0].Rows[i][2].ToString().Trim());
        //        lv.SubItems.Add(ds.Tables[0].Rows[i][3].ToString().Trim());
        //        lv.SubItems.Add(ds.Tables[0].Rows[i][4].ToString().Trim());
        //        LV_xfinfo.Items.Add(lv);
        //    }
        //}

        private void ff()
        {
            try
            {
                if (TB_name.Text.Trim() == "")
                {
                    MessageBox.Show("请选择商品");
                }
                else if (TB_Num.Text.Trim() == "")
                {
                    MessageBox.Show("请输入商品消费数量");
                }
                else
                {
                    //查询商品销售价格，数量，进货单价
                    string str_sql = "select Goods_num,Goods_Xsprice,Goods_Jhprice from tb_goods where goods_Name='" + TB_name.Text.Trim() + "'";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    string sl = ds.Tables[0].Rows[0][0].ToString().Trim();
                    string dj = ds.Tables[0].Rows[0][1].ToString().Trim();
                    string jhjg = ds.Tables[0].Rows[0][2].ToString().Trim();

                    if (Convert.ToInt32(sl) > 0 && Convert.ToInt32(sl) > Convert.ToInt32(TB_Num.Text.Trim()))
                    {
                        if (LV_xfinfo.Items.Count == 0)
                        {
                            ListViewItem lv = new ListViewItem(TB_name.Text.Trim());
                            lv.SubItems.Add(dj);
                            lv.SubItems.Add(TB_Num.Text.Trim());
                            lv.SubItems.Add((Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(dj)).ToString().Trim());
                            lv.SubItems.Add(DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss).Trim());
                            LV_xfinfo.Items.Add(lv);
                        }
                        else
                        {
                            for (int i = 0; i < LV_xfinfo.Items.Count; i++)
                            {
                                if (LV_xfinfo.Items[i].SubItems[0].Text.Trim() == TB_name.Text.Trim())
                                {

                                    ListViewItem lv = new ListViewItem(TB_name.Text.Trim());
                                    lv.SubItems.Add(dj);
                                    lv.SubItems.Add((Convert.ToInt32(dj) + Convert.ToInt32(TB_Num.Text.Trim())).ToString().Trim());
                                    lv.SubItems.Add((Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(dj) + Convert.ToDouble(LV_xfinfo.Items[i].SubItems[3].Text.Trim())).ToString().Trim());
                                    lv.SubItems.Add(DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss).Trim());
                                    LV_xfinfo.Items.Add(lv);
                                    LV_xfinfo.Items.RemoveAt(LV_xfinfo.Items[i].Index);

                                    str_sql = "update tb_goods set Goods_num='" + (Convert.ToInt32(sl) - Convert.ToInt32(TB_Num.Text.Trim())).ToString().Trim() + "',"
                                        + "Goods_allprice=convert(decimal,goods_allprice)-" + (Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(jhjg)) + " where goods_Name='" + TB_name.Text.Trim() + "'";
                                    db.ExecSQl(str_sql);


                                    return;
                                }
                            }

                            ListViewItem lv1 = new ListViewItem(TB_name.Text.Trim());
                            lv1.SubItems.Add(dj);
                            lv1.SubItems.Add(TB_Num.Text.Trim());
                            lv1.SubItems.Add((Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(dj)).ToString().Trim());
                            lv1.SubItems.Add(DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss).Trim());
                            LV_xfinfo.Items.Add(lv1);
                        }
                        string sql = "update tb_goods set Goods_num='" + (Convert.ToInt32(sl) - Convert.ToInt32(TB_Num.Text.Trim())).ToString().Trim() + "'"
                            + ",Goods_allprice=convert(decimal,goods_allprice)-" + (Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(jhjg)) + " where goods_Name='" + TB_name.Text.Trim() + "'";
                        db.ExecSQl(sql);
                    }

                    else
                    {
                        MessageBox.Show("库存不足");
                    }
                }
            }
            catch { }

        }
        private void fangfa()
        {
            try
            {
                string a = string.Empty;
                if (lv_spinfo.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < lv_spinfo.SelectedItems.Count; i++)
                    {
                        if (Convert.ToInt32(lv_spinfo.SelectedItems[i].SubItems[3].Text.Trim()) > 0 && Convert.ToInt32(TB_Num.Text.Trim()) <= Convert.ToInt32(lv_spinfo.SelectedItems[i].SubItems[3].Text.Trim()))
                        {
                            //查询商品进货价格
                            string str_sql = "select Goods_Jhprice from tb_Goods where goods_Name='" + lv_spinfo.SelectedItems[i].SubItems[1].Text.Trim() + "'";
                            DataSet ds = db.GetDataFromSQL(str_sql);
                            string jhjg = ds.Tables[0].Rows[0][0].ToString().Trim();

                            if (LV_xfinfo.Items.Count == 0)
                            {

                                ListViewItem lv = new ListViewItem(lv_spinfo.SelectedItems[i].SubItems[1].Text.Trim());
                                lv.SubItems.Add(lv_spinfo.SelectedItems[i].SubItems[2].Text.Trim());
                                lv.SubItems.Add(TB_Num.Text.Trim());
                                lv.SubItems.Add((Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(lv_spinfo.SelectedItems[i].SubItems[2].Text.Trim())).ToString().Trim());
                                lv.SubItems.Add(DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss).Trim());
                                LV_xfinfo.Items.Add(lv);
                                // TB_Money.Text = (Convert.ToDouble(TB_Money.Text.Trim()) + Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(TB_Price.Text.Trim())).ToString().Trim();

                            }
                            else
                            {

                                for (int j = 0; j < LV_xfinfo.Items.Count; j++)
                                {
                                    if (LV_xfinfo.Items[j].SubItems[0].Text.Trim() == lv_spinfo.SelectedItems[i].SubItems[1].Text.Trim())
                                    {

                                        ListViewItem lv = new ListViewItem(lv_spinfo.SelectedItems[i].SubItems[1].Text.Trim());
                                        lv.SubItems.Add(lv_spinfo.SelectedItems[i].SubItems[2].Text.Trim());
                                        lv.SubItems.Add((Convert.ToInt32(LV_xfinfo.Items[j].SubItems[2].Text.Trim()) + Convert.ToInt32(TB_Num.Text.Trim())).ToString().Trim());
                                        lv.SubItems.Add((Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(lv_spinfo.SelectedItems[i].SubItems[2].Text.Trim()) + Convert.ToDouble(LV_xfinfo.Items[j].SubItems[3].Text.Trim())).ToString().Trim());
                                        lv.SubItems.Add(DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss).Trim());
                                        LV_xfinfo.Items.Add(lv);
                                        LV_xfinfo.Items.RemoveAt(LV_xfinfo.Items[j].Index);

                                        str_sql = "update tb_goods set Goods_num='" + (Convert.ToInt32(lv_spinfo.SelectedItems[i].SubItems[3].Text.Trim()) - Convert.ToInt32(TB_Num.Text.Trim())).ToString().Trim() + "'"
                                           + ",Goods_allprice=convert(decimal,goods_allprice)-" + (Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(jhjg)) + ""
                                           + " where goods_Name='" + lv_spinfo.SelectedItems[i].SubItems[1].Text.Trim() + "'";
                                        db.ExecSQl(str_sql);


                                        return;
                                    }

                                }

                                ListViewItem lv1 = new ListViewItem(lv_spinfo.SelectedItems[i].SubItems[1].Text.Trim());
                                lv1.SubItems.Add(lv_spinfo.SelectedItems[i].SubItems[2].Text.Trim());
                                lv1.SubItems.Add(TB_Num.Text.Trim());
                                lv1.SubItems.Add((Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(lv_spinfo.SelectedItems[i].SubItems[2].Text.Trim())).ToString().Trim());
                                lv1.SubItems.Add(DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss).Trim());
                                LV_xfinfo.Items.Add(lv1);

                            }
                            string sql = "update tb_goods set Goods_num='" + (Convert.ToInt32(lv_spinfo.SelectedItems[i].SubItems[3].Text.Trim()) - Convert.ToInt32(TB_Num.Text.Trim())).ToString().Trim() + "'"
                                + ",Goods_allprice=convert(decimal,goods_allprice)-" + (Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(jhjg)) + " where goods_Name='" + lv_spinfo.SelectedItems[i].SubItems[1].Text.Trim() + "'";
                            db.ExecSQl(sql);

                        }
                        else
                        {
                            a = lv_spinfo.SelectedItems[i].SubItems[1].Text.Trim() + "库存不足\n";
                        }
                    }
                    if (a != "")
                    {
                        MessageBox.Show(a);
                    }
                }
            }
            catch { }
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_xfinfo.Items.Count > 0)
                {
                    for (int i = 0; i < LV_xfinfo.Items.Count; i++)
                    {

                        //插入桌台消费记录
                        string str_sql = "insert into tb_DeskXS values('" + this.Rname + "','" + LV_xfinfo.Items[i].SubItems[0].Text.Trim() + "',"
                            + "'" + LV_xfinfo.Items[i].SubItems[1].Text.Trim() + "','" + LV_xfinfo.Items[i].SubItems[2].Text.Trim() + "',"
                            + "'" + LV_xfinfo.Items[i].SubItems[3].Text.Trim() + "','" + LV_xfinfo.Items[i].SubItems[4].Text.Trim() + "','无')";
                        db.ExecSQl(str_sql);


                    }
                    flag = true;
                    but_Close_Click(sender, e);
                }
            }
            catch { }
        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_xfinfo.SelectedItems.Count == 1)
                {
                    //查询商品进货价格
                    string str_sql = "select Goods_Jhprice from tb_Goods where goods_Name='" + LV_xfinfo.SelectedItems[0].SubItems[0].Text.Trim() + "'";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    string jhjg = ds.Tables[0].Rows[0][0].ToString().Trim();

                    int spsl = Convert.ToInt32(LV_xfinfo.SelectedItems[0].SubItems[2].Text.Trim());
                    string spmc = LV_xfinfo.SelectedItems[0].SubItems[0].Text.Trim();
                    double zj = Convert.ToDouble(jhjg) * spsl;
                    str_sql = "update tb_goods set Goods_num=convert(int,Goods_num)+" + spsl + ",Goods_allprice=convert(decimal,goods_allprice)+" + zj + " where goods_Name='" + spmc + "'";
                    if (MessageBox.Show("你确认要退菜吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {

                        if (db.ExecSQl(str_sql))
                        {

                            LV_xfinfo.Items.RemoveAt(LV_xfinfo.SelectedItems[0].Index);
                            xianshisp();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选中退菜的菜品");
                }
            }
            catch { }
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            ff();
            xianshisp();
        }

        private void TB_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void TB_name_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (TB_name.Text.Trim() == "")
                {
                    //填充lv_spqd 控件
                    lv_spinfo.Items.Clear();
                    string str_sql = "select * from tb_goods";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i]["goods_ID"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["goods_Name"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["Goods_Xsprice"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["Goods_num"].ToString().Trim());
                        lv_spinfo.Items.Add(lv);
                    }
                }
                else if (flag)
                { }
                else
                {
                    //填充lv_spqd 控件
                    lv_spinfo.Items.Clear();
                    string str_sql = "select * from tb_goods where goods_Name like '%" + TB_name.Text.Trim() + "%'";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i]["goods_ID"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["goods_Name"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["Goods_Xsprice"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["Goods_num"].ToString().Trim());
                        lv_spinfo.Items.Add(lv);
                    }
                }
            }
            catch { }
        }

        private void lv_spinfo_Click(object sender, EventArgs e)
        {

            if (lv_spinfo.SelectedItems.Count == 1)
            {
                flag = true;
                TB_name.Text = lv_spinfo.SelectedItems[0].SubItems[1].Text.Trim();
                flag = false;
                // TB_Num.Text = lv_spinfo.SelectedItems[0].SubItems[2].Text.Trim();
            }
        }

        private void tuichu()
        {
            try
            {
                if (!flag)
                {
                    if (LV_xfinfo.Items.Count != 0)
                    {

                        if (MessageBox.Show("你刚刚新增了菜品还没保存\n你确认要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                        {
                            this.Rname = "";
                            string str_sql = "";
                            //如果没有消费  则把商品数量加回去
                            for (int i = 0; i < LV_xfinfo.Items.Count; i++)
                            {
                                //查询商品进货价格
                                str_sql = "select Goods_Jhprice from tb_Goods where goods_Name='" + LV_xfinfo.Items[i].SubItems[0].Text.Trim() + "'";
                                DataSet ds = db.GetDataFromSQL(str_sql);
                                string jhjg = ds.Tables[0].Rows[0][0].ToString().Trim();

                                int spsl = Convert.ToInt32(LV_xfinfo.Items[i].SubItems[2].Text.Trim());
                                str_sql = "update tb_goods set Goods_num=convert(int,Goods_num)+" + spsl + ","
                                    + "Goods_allprice=convert(decimal,goods_allprice)+" + (Convert.ToDouble(jhjg) * spsl) + " where goods_Name='" + LV_xfinfo.Items[i].SubItems[0].Text.Trim() + "'";
                                db.ExecSQl(str_sql);
                            }
                        }
                        //    //查询桌台消费表的记录
                        //    str_sql = "select XS_goodsName,XS_Sum,XS_allprice from tb_DeskXS where XS_DeskName='" + Rname + "'";
                        //    DataSet ds1 = db.GetDataFromSQL(str_sql);
                        //    for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                        //    {
                        //        //查询商品进货价格
                        //        str_sql = "select Goods_Jhprice from tb_Goods where goods_Name='" + LV_xfinfo.Items[i].SubItems[0].Text.Trim() + "'";
                        //        DataSet dst = db.GetDataFromSQL(str_sql);
                        //        string jhjg = dst.Tables[0].Rows[0][0].ToString().Trim();
                        //        //减去桌台消费表的记录
                        //        str_sql = "update tb_goods set Goods_num=convert(int,Goods_num)-" + Convert.ToInt32(ds1.Tables[0].Rows[i]["XS_Sum"].ToString().Trim()) + ","
                        //            + "Goods_allprice=convert(decimal,goods_allprice)-" + (Convert.ToInt32(ds1.Tables[0].Rows[i]["XS_Sum"].ToString().Trim()) * Convert.ToDouble(jhjg)) + ""
                        //            +"  where  goods_Name='" + ds1.Tables[0].Rows[i]["XS_goodsName"].ToString().Trim() + "'";
                        //        db.ExecSQl(str_sql);
                        //    }

                        //else
                        //{
                        //    this.Activate();
                        //}
                    }
                }
            }
            catch { }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fangfa();
            xianshisp();
        }

        private void lv_spinfo_DoubleClick(object sender, EventArgs e)
        {

            fangfa();
            xianshisp();
            flag = false;
        }

        private void 顾客退菜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_xfinfo.SelectedItems.Count == 1)
                {
                    int spsl = Convert.ToInt32(LV_xfinfo.SelectedItems[0].SubItems[2].Text.Trim());
                    string spmc = LV_xfinfo.SelectedItems[0].SubItems[0].Text.Trim();
                    double zj = Convert.ToDouble(LV_xfinfo.SelectedItems[0].SubItems[3].Text.Trim());
                    string str_sql = "update tb_goods set Goods_num=convert(int,Goods_num)+" + spsl + ",Goods_allprice=convert(decimal,goods_allprice)+" + zj + " where goods_Name='" + spmc + "'";
                    if (MessageBox.Show("你确认要退菜吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {

                        if (db.ExecSQl(str_sql))
                        {

                            LV_xfinfo.Items.RemoveAt(LV_xfinfo.SelectedItems[0].Index);
                            xianshisp();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选中退菜的菜品");
                }
            }
            catch { }
        }

        private void Frm_XF_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!flag)
                {
                    if (LV_xfinfo.Items.Count != 0)
                    {

                        if (MessageBox.Show("你刚刚新增了菜品还没保存\n你确认要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                        {
                            this.Rname = "";
                            string str_sql = "";
                            //如果没有消费  则把商品数量加回去
                            for (int i = 0; i < LV_xfinfo.Items.Count; i++)
                            {
                                //查询商品进货价格
                                str_sql = "select Goods_Jhprice from tb_Goods where goods_Name='" + LV_xfinfo.Items[i].SubItems[0].Text.Trim() + "'";
                                DataSet ds = db.GetDataFromSQL(str_sql);
                                string jhjg = ds.Tables[0].Rows[0][0].ToString().Trim();

                                int spsl = Convert.ToInt32(LV_xfinfo.Items[i].SubItems[2].Text.Trim());
                                str_sql = "update tb_goods set Goods_num=convert(int,Goods_num)+" + spsl + ","
                                    + "Goods_allprice=convert(decimal,goods_allprice)+" + (Convert.ToDouble(jhjg) * spsl) + " where goods_Name='" + LV_xfinfo.Items[i].SubItems[0].Text.Trim() + "'";
                                db.ExecSQl(str_sql);

                            }
                        }
                        else
                        {
                            e.Cancel = true;
                        }

                    }
                }
            }
            catch { }
        }
    }
}
