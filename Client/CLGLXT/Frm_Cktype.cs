using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Foot.Client
{
    public partial class Frm_Cktype : UserControl
    {
        public Frm_Cktype()
        {
            InitializeComponent();
        }

        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        private void Frm_Cktype_Load(object sender, EventArgs e)
        {
            try
            {
                //填充LV_info 控件
                LV_info.Items.Clear();
                string str_sql = "select * from tb_warehouse";
                DataSet ds = db.GetDataFromSQL(str_sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i]["CK_ID"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["CK_Name"].ToString().Trim());
                    LV_info.Items.Add(lv);
                }
                TB_ID.Text = "";
                TB_Name.Text = "";
            }
            catch { }
        }

        private void LV_info_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_info.SelectedItems.Count == 1)
                {

                    TB_ID.Text = LV_info.SelectedItems[0].SubItems[0].Text.Trim();
                    TB_Name.Text = LV_info.SelectedItems[0].SubItems[1].Text.Trim();
                }
            }
            catch { }
        
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_Name.Text != "")
                {
                    string str_sqll = "select count(*) from tb_warehouse where CK_Name='" + TB_Name.Text.Trim() + "'";
                    int a = db.YZSql(str_sqll);
                    if (a > 0)
                    {
                        MessageBox.Show("此仓库已存在");
                        TB_ID.Text = "";
                        TB_Name.Text = "";
                    }
                    else
                    {
                        string str_sql = "insert into tb_warehouse values('" + TB_Name.Text.Trim() + "')";
                        if (db.ExecSQl(str_sql))
                        {
                            MessageBox.Show("添加成功");
                            Frm_Cktype_Load(sender, e);
                        }
                    }
                }
            }
            catch { }
        }

        private void but_xiugai_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_Name.Text != "")
                {
                    string str_sqll = "select count(*) from tb_warehouse where CK_Name='" + TB_Name.Text.Trim() + "'";
                    int a = db.YZSql(str_sqll);
                    if (a > 0 && TB_Name.Text != LV_info.SelectedItems[0].SubItems[1].Text.Trim())
                    {
                        MessageBox.Show("此仓库已存在");
                        TB_ID.Text = "";
                        TB_Name.Text = "";

                    }
                    else
                    {
                        string str_sql = "update tb_warehouse set CK_Name='" + TB_Name.Text.Trim() + "' where CK_ID='" + TB_ID.Text.Trim() + "'";
                        if (db.ExecSQl(str_sql))
                        {
                            MessageBox.Show("修改成功");

                            Frm_Cktype_Load(sender, e);
                        }
                    }
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
                    string spbh = LV_info.SelectedItems[0].SubItems[0].Text.Trim();
                    if (MessageBox.Show("你确定要删除吗?", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //查询此仓库中有商品存在没？
                        string str_sql = "select count(*) from tb_goodsCF where CF_ID='"+spbh+"'";
                        int a = db.YZSql(str_sql);
                        if (a > 0)
                        {
                            MessageBox.Show("删除仓库前请把此仓库的商品转移");
                        }
                        else
                        {
                            str_sql = "delete from tb_warehouse where CK_ID='" + spbh + "'";
                            if (db.ExecSQl(str_sql))
                            {
                                MessageBox.Show("删除成功");
                                Frm_Cktype_Load(sender, e);
                            }
                        }
                    }
                }
            }
            catch { }
        }
    }
}
