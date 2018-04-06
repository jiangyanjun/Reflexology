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
    public partial class Frm_Hytype : UserControl
    {
        public Frm_Hytype()
        {
            InitializeComponent();
        }
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();

        private void Frm_Hytype_Load(object sender, EventArgs e)
        {
            try
            {
                LV_info.Items.Clear();
                string str_sql = "select * from tb_membertype";
                DataSet ds = db.GetDataFromSQL(str_sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i]["Mt_ID"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Mt_Name"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Mt_csjf"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Mt_agio"].ToString().Trim());
                    LV_info.Items.Add(lv);

                    TB_ID.Text ="";
                    TB_Name.Text= "";
                    TB_jf.Text = "";
                    TB_Zk.Text = "";
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
                    string str_sql = "delete from tb_membertype where Mt_ID='" + LV_info.SelectedItems[0].SubItems[0].Text.Trim() + "'";
                    if (db.ExecSQl(str_sql))
                    {
                        MessageBox.Show("删除成功");
                        Frm_Hytype_Load(sender, e);
                    }
                }
            }
            catch { }
        }

        private void but_xiugai_Click(object sender, EventArgs e)
        {
            try
            {
             if (TB_Name.Text != "" && TB_Zk.Text.Trim() != "" && TB_jf.Text.Trim() != "")
                {
                    string str_sqll = "select count(*) from tb_membertype where Mt_Name='" + TB_Name.Text.Trim() + "'";
                    int a=db.YZSql(str_sqll);
                    if (a > 0 && TB_Name.Text != LV_info.SelectedItems[0].SubItems[1].Text.Trim())
                    {
                        MessageBox.Show("此权限名存在");

                        TB_ID.Text = "";
                        TB_Name.Text = "";
                        TB_jf.Text = "";
                        TB_Zk.Text = "";
                    }
                    else
                    {
                        string str_sql = "update tb_membertype set Mt_Name='" + TB_Name.Text.Trim() + "',Mt_csjf='" + TB_jf.Text.Trim() + "',Mt_agio='" + TB_Zk.Text.Trim() + "' where Mt_ID='" + TB_ID.Text.Trim() + "'";
                        if (db.ExecSQl(str_sql))
                        {
                            MessageBox.Show("修改成功");

                            Frm_Hytype_Load(sender, e);
                        }
                    }
                }
            }
            catch { }
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_Name.Text != "" && TB_Zk.Text.Trim() != "" && TB_jf.Text.Trim() != "")
                {
                    string str_sqll = "select count(*) from tb_membertype where Mt_Name='" + TB_Name.Text.Trim() + "'";
                    int a = db.YZSql(str_sqll);
                    if (a > 0)
                    {
                        MessageBox.Show("此会员等级存在");

                        TB_ID.Text = "";
                        TB_Name.Text = "";
                        TB_jf.Text = "";
                        TB_Zk.Text = "";
                    }
                    else
                    {
                        string str_sql = "insert into tb_membertype values('" + TB_Name.Text.Trim() + "','" + TB_jf.Text.Trim() + "','" + TB_Zk.Text.Trim() + "')";
                        if (db.ExecSQl(str_sql))
                        {
                            MessageBox.Show("添加成功");
                            Frm_Hytype_Load(sender, e);
                        }
                    }
                }
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
                    TB_jf.Text = LV_info.SelectedItems[0].SubItems[2].Text.Trim();
                    TB_Zk.Text = LV_info.SelectedItems[0].SubItems[3].Text.Trim();
                }
            }
            catch { }
        }

        private void TB_Zk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                but_Add_Click(sender, e);

            }

            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar) && e.KeyChar != 46)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
            if (this.TB_Zk.Text.Contains("."))
            {
                if (e.KeyChar == 46)
                {
                    e.Handled = true;
                }
            }
        }

        private void TB_jf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void TB_Zk_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TB_Zk.Text.StartsWith("."))
                {
                    TB_Zk.Text = "0.";
                    TB_Zk.SelectionStart = 2;
                }
            }
            catch { }
        }
    }
}
