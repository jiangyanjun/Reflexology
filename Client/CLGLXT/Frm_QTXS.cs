using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Kebue.Core.Util;

namespace Foot.Client
{
    public partial class Frm_QTXS : Form
    {
        public static bool flag = false;
        public Frm_QTXS()
        {
            InitializeComponent();
        }
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        private void Frm_QTXS_Load(object sender, EventArgs e)
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
                ZDH();
                TB_name.Text = "";
                TB_Num.Text = "1";
                // LB_ZDH.Text = "QT" + DateTime.Now.ToString("yyyyMMdd").Trim() + "001";
            }
            catch { }
        }

        private void ZDH()
        {
            try
            {
                //设置销售账单号
                string str_sql = "select max(XF_ID) from tb_XF where substring(XF_ID,1,2)='QT' and substring(XF_ID,3,8)='" + DateTime.Now.ToString("yyyyMMdd").Trim() + "'";
                DataSet ds = db.GetDataFromSQL(str_sql);
                string zd = ds.Tables[0].Rows[0][0].ToString().Trim();
                if (zd == "")
                {
                    LB_ZDH.Text = "QT" + DateTime.Now.ToString("yyyyMMdd") + "001";
                }
                else
                {
                    LB_ZDH.Text = (Convert.ToInt64(zd.Substring(2, 11).ToString().Trim()) + 1).ToString("QT00000000000").Trim();
                }
            }
            catch { }
        }

        private void lv_spinfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            tianjia();
            Frm_QTXS_Load(sender,e);
            flag = false; ;
        
        }

        private void tianjia()
        {
            try
            {
                if (lv_spinfo.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < lv_spinfo.SelectedItems.Count; i++)
                    {
                        if (Convert.ToInt32(lv_spinfo.SelectedItems[i].SubItems[3].Text.Trim()) > 0 && Convert.ToInt32(TB_Num.Text.Trim()) <= Convert.ToInt32(lv_spinfo.SelectedItems[i].SubItems[3].Text.Trim()))
                        {
                            //查询商品进货价格
                            string str_sql = "select Goods_Jhprice from tb_Goods where goods_Name='" + lv_spinfo.SelectedItems[i].SubItems[1].Text.Trim() + "'";
                            string jhjg = db.GetDataFromSQL(str_sql).Tables[0].Rows[0][0].ToString().Trim();
                            if (LV_xfinfo.Items.Count == 0)
                            {
                                ListViewItem lv = new ListViewItem(lv_spinfo.SelectedItems[i].SubItems[1].Text.Trim());
                                lv.SubItems.Add(lv_spinfo.SelectedItems[i].SubItems[2].Text.Trim());
                                lv.SubItems.Add(TB_Num.Text.Trim());
                                lv.SubItems.Add((Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(lv_spinfo.SelectedItems[i].SubItems[2].Text.Trim())).ToString().Trim());
                                lv.SubItems.Add(DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss).Trim());
                                LV_xfinfo.Items.Add(lv);
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

                                        string sql = "update tb_goods set Goods_num=convert(int,Goods_num)-" + Convert.ToInt32(TB_Num.Text.Trim()) + ","
                                            + "Goods_allprice=convert(decimal,goods_allprice)-" + (Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(jhjg)) + " "
                                            + "where goods_Name='" + lv_spinfo.SelectedItems[i].SubItems[1].Text.Trim() + "'";
                                        db.ExecSQl(sql);
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
                            //减去商品数量和金额

                            string sql1 = "update tb_goods set Goods_num=convert(int,Goods_num)-" + Convert.ToInt32(TB_Num.Text.Trim()) + ""
                            + ", Goods_allprice=convert(decimal,goods_allprice)-" + (Convert.ToInt32(TB_Num.Text.Trim()) * Convert.ToDouble(jhjg)) + ""
                                + " where goods_Name='" + lv_spinfo.SelectedItems[i].SubItems[1].Text.Trim() + "'";
                            db.ExecSQl(sql1);
                        }
                        else
                        {
                            MessageBox.Show("库存不足");
                        }
                    }
                }
            }
            catch { }
        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            
             this.Close();
        }

        private void but_JZ_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_xfinfo.Items.Count > 0)
                {
                    for (int i = 0; i < LV_xfinfo.Items.Count; i++)
                    {
                        string str_sql = "select Goods_type,Beizhu from  tb_goods where goods_Name='" + LV_xfinfo.Items[i].SubItems[0].Text.Trim() + "'";
                        DataSet ds = db.GetDataFromSQL(str_sql);
                        str_sql = "insert into  tb_qtxs  values('" + LB_ZDH.Text.Trim() + "','" + LV_xfinfo.Items[i].SubItems[0].Text.Trim() + "','" + ds.Tables[0].Rows[0][0].ToString().Trim() + "','" + LV_xfinfo.Items[i].SubItems[1].Text.Trim() + "','" + LV_xfinfo.Items[i].SubItems[2].Text.Trim() + "','" + LV_xfinfo.Items[i].SubItems[3].Text.Trim() + "','" + ds.Tables[0].Rows[0][1].ToString().Trim() + "')";
                        db.ExecSQl(str_sql);
                    }


                    Frm_QTxsJZ jz = new Frm_QTxsJZ();
                    jz.ID = LB_ZDH.Text.Trim();
                    jz.ShowDialog();
                }
                else
                {
                    MessageBox.Show("请选择消费商品");
                }
            }
            catch { }
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            tianjia();
            Frm_QTXS_Load(sender, e);
        }

        private void TB_Num_Validating(object sender, CancelEventArgs e)
        {
            Regex re = new Regex(@"^[0-9]*$");
            if (!re.IsMatch(TB_Num.Text.Trim()))
            {
                MessageBox.Show("请输入数字");
                TB_Num.Text = "1";
                e.Cancel = true;

            }
        }

        private void Frm_QTXS_Activated(object sender, EventArgs e)
        {           
            //Frm_QTXS_Load(sender,e);
            if (flag)
            {
                LV_xfinfo.Items.Clear();
            }
        }

        private void CMS_Add_Click(object sender, EventArgs e)
        {
            tianjia();
            Frm_QTXS_Load(sender, e);
        }

        private void CMS_Del_Click(object sender, EventArgs e)
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
                    str_sql = "update tb_goods set Goods_num=convert(int,Goods_num)+" + spsl + ","
                       + "Goods_allprice=convert(decimal,goods_allprice)+" + (Convert.ToDouble(jhjg) * spsl) + " where goods_Name='" + LV_xfinfo.SelectedItems[0].SubItems[0].Text.Trim() + "'";
                    if (MessageBox.Show("你确认要退菜吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        db.ExecSQl(str_sql);
                        Frm_QTXS_Load(sender, e);
                        LV_xfinfo.Items.RemoveAt(LV_xfinfo.SelectedItems[0].Index);
                    }
                }
            }
            catch { }
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
            try
            {
                if (lv_spinfo.SelectedItems.Count == 1)
                {
                    flag = true;
                    TB_name.Text = lv_spinfo.SelectedItems[0].SubItems[1].Text.Trim();
                    flag = false;
                    //TB_Num.Text = lv_spinfo.SelectedItems[0].SubItems[2].Text.Trim();
                }
            }
            catch { }
        }

        private void Frm_QTXS_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!flag)
                {
                    if (LV_xfinfo.Items.Count != 0)
                    {
                        if (MessageBox.Show("你刚刚新增了菜品还没保存\n你确认要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                        {

                            //如果没有消费  则把商品数量加回去
                            for (int i = 0; i < LV_xfinfo.Items.Count; i++)
                            {
                                //查询商品进货价格
                                string str_sql = "select Goods_Jhprice from tb_Goods where goods_Name='" + LV_xfinfo.Items[i].SubItems[0].Text.Trim() + "'";
                                DataSet ds = db.GetDataFromSQL(str_sql);
                                string jhjg = ds.Tables[0].Rows[0][0].ToString().Trim();
                                int spsl = Convert.ToInt32(LV_xfinfo.Items[i].SubItems[2].Text.Trim());

                                str_sql = "update tb_goods set Goods_num=convert(int,Goods_num)+" + spsl + ","
                                   + "Goods_allprice=convert(decimal,goods_allprice)+" + (Convert.ToDouble(jhjg) * spsl) + ""
                                   + " where goods_Name='" + LV_xfinfo.Items[i].SubItems[0].Text.Trim() + "'";
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

