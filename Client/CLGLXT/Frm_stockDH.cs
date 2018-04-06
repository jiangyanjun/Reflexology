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
    public partial class Frm_stockDH : Form
    {
        public Frm_stockDH()
        {
            InitializeComponent();
        }
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
 

        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (CB_Name.Text.Trim() != "")
                {
                    if (LV_dbinfo.Items.Count > 0)
                    {
                        bool a = false;
                        string str_sql = "select CK_ID from tb_warehouse where CK_Name='" + CB_Name.Text.Trim() + "'";
                        int ckbh = Convert.ToInt32(db.GetDataFromSQL(str_sql).Tables[0].Rows[0][0].ToString().Trim());
                        for (int i = 0; i < LV_dbinfo.Items.Count; i++)
                        {
                            str_sql = "update tb_goods set Goods_CKID='" + ckbh + "' where goods_ID='" + LV_dbinfo.Items[i].SubItems[0].Text.Trim() + "'";
                            a = db.ExecSQl(str_sql);
                        }
                        if (a)
                        {
                            MessageBox.Show("调换成功");
                            Frm_stockDH_Load(sender, e);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择仓库");
                }
            }
            catch { }
        }
        private void LV_spinfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            add();
             
        }

        private void add()
        {
            try
            {

                if (LV_spinfo.SelectedItems.Count == 1)
                {
                    if (LV_dbinfo.Items.Count == 0)
                    {
                        ListViewItem lv = new ListViewItem(LV_spinfo.SelectedItems[0].SubItems[0].Text.Trim());
                        lv.SubItems.Add(LV_spinfo.SelectedItems[0].SubItems[1].Text.Trim());
                        LV_dbinfo.Items.Add(lv);
                    }
                    else
                    {
                        for (int i = 0; i < LV_dbinfo.Items.Count; i++)
                        {
                            if (LV_dbinfo.Items[i].SubItems[0].Text.Trim() == LV_spinfo.SelectedItems[0].SubItems[0].Text.Trim())
                            {
                                //MessageBox.Show("");
                                return;
                            }
                        }

                        ListViewItem lv = new ListViewItem(LV_spinfo.SelectedItems[0].SubItems[0].Text.Trim());
                        lv.SubItems.Add(LV_spinfo.SelectedItems[0].SubItems[1].Text.Trim());
                        LV_dbinfo.Items.Add(lv);
                    }
                }
            }
            catch { }
        }

        private void Frm_stockDH_Load(object sender, EventArgs e)
        {
            try
            {
                //查询商品所在仓库信息
                LV_spinfo.Items.Clear();
                string str_sql = "select a.goods_ID,a.goods_Name,b.CK_Name from tb_warehouse b,tb_goods a where b.CK_ID=a.Goods_CKID";
                DataSet ds = db.GetDataFromSQL(str_sql);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i][0].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i][1].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i][2].ToString().Trim());
                        LV_spinfo.Items.Add(lv);
                    }
                }
                //添加仓库名称
                ds = db.GetDataFromSQL("select CK_Name from tb_warehouse");
                CB_Name.Items.Clear();
                if (ds.Tables[0].Rows.Count != 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        CB_Name.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim());
                    }
                    CB_Name.SelectedIndex = 0;
                }
            }
            catch { }
        }

        private void CMS_Add_Click(object sender, EventArgs e)
        {
            add();
        }

        private void CMS_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_dbinfo.SelectedItems.Count == 1)
                {
                    LV_dbinfo.Items.RemoveAt(LV_dbinfo.SelectedItems[0].Index);
                }
            }
            catch { }
        }

        private void TB_Name_KeyPress(object sender, KeyPressEventArgs e)
        {

            ////查询商品所在仓库信息
            //LV_spinfo.Items.Clear();
            //string str_sql = "select a.goods_ID,a.goods_Name,b.CK_Name from tb_warehouse b,tb_goods a where b.CK_ID=a.Goods_CKID and a.goods_Name like '%"+TB_Name.Text.Trim()+"%'";
            //DataSet ds = db.GetDataFromSQL(str_sql);
            //if (ds.Tables[0].Rows.Count != 0)
            //{
            //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //    {
            //        ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i][0].ToString().Trim());
            //        lv.SubItems.Add(ds.Tables[0].Rows[i][1].ToString().Trim());
            //        lv.SubItems.Add(ds.Tables[0].Rows[i][2].ToString().Trim());
            //        LV_spinfo.Items.Add(lv);
            //    }
            //}
        }

        private void TB_Name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //查询商品所在仓库信息
                LV_spinfo.Items.Clear();
                string str_sql = "select a.goods_ID,a.goods_Name,b.CK_Name from tb_warehouse b,tb_goods a where b.CK_ID=a.Goods_CKID and a.goods_Name like '%" + TB_Name.Text.Trim() + "%'";
                DataSet ds = db.GetDataFromSQL(str_sql);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i][0].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i][1].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i][2].ToString().Trim());
                        LV_spinfo.Items.Add(lv);
                    }
                }
            }
            catch { }
        }
    }
}
