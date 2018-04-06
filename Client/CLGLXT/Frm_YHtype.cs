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
    public partial class Frm_YHtype : UserControl
    {
        public Frm_YHtype()
        {
            InitializeComponent();
        }

        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        private void but_AddYH_Click(object sender, EventArgs e)
        {
            Frm_User F_user = new Frm_User();
            F_user.ShowDialog();
        }

        private void Frm_YHtype_Load(object sender, EventArgs e)
        {

            quanxian();

            dgv();
        }

        private void quanxian()
        {
            try
            {
                //查询权限名称
                string str_sql = "select Pt_Name from tb_powertype";
                DataSet ds = db.GetDataFromSQL(str_sql);

                LV_info.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i][0].ToString().Trim());
                    LV_info.Items.Add(lv);
                }
            }
            catch { }
        }
        //查询用户
        private void dgv()
        {
            try
            {
                string str_sql = "select a.User_Name,b.Pt_Name from tb_User a, tb_powertype b where a.power=b.Pt_ID";
                DataSet ds = db.GetDataFromSQL(str_sql);
                DGV_info.DataSource = ds.Tables[0];
            }
            catch { }
        }

        private void but_AddQX_Click(object sender, EventArgs e)
        {
            Frm_Power p = new Frm_Power();
            p.RName = null;
            p.ShowDialog();
            quanxian();
        }

        private void but_xiugai_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_info.SelectedItems.Count == 1)
                {
                    if (LV_info.SelectedItems[0].SubItems[0].Text.Trim() == "超级管理员")
                    {
                        MessageBox.Show("不能修改超级管理员");
                    }
                    else
                    {
                        Frm_Power p = new Frm_Power();
                        p.RName = LV_info.SelectedItems[0].SubItems[0].Text.Trim();
                        p.ShowDialog();
                        quanxian();

                    }
                }
                else
                {
                    MessageBox.Show("请选择要修改的权限");
                }
            }
            catch { }
        }

        private void but_xiugQX_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_info.SelectedRows.Count == 1)
                {
                    string yhqx = DGV_info.SelectedRows[0].Cells[1].Value.ToString().Trim();
                    if (yhqx == "超级管理员")
                    {
                        MessageBox.Show("不能修改超级管理员用户");
                    }
                    else
                    {
                        Frm_User u = new Frm_User();
                        u.Rname = DGV_info.SelectedRows[0].Cells[0].Value.ToString().Trim();
                        u.ShowDialog();
                        dgv();
                    }
                }
            }
            catch { }
        }

        private void but_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_info.SelectedRows.Count == 1)
                {
                    string yhqx = DGV_info.SelectedRows[0].Cells[1].Value.ToString().Trim();
                    if (yhqx == "超级管理员")
                    {
                        MessageBox.Show("不能删除超级管理员用户");
                    }
                    else
                    {
                        string str_sql = "delete from tb_User where User_Name='" + DGV_info.SelectedRows[0].Cells[0].Value.ToString().Trim() + "'";

                        if (MessageBox.Show("你确认要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                        {

                            if (db.ExecSQl(str_sql))
                            {
                                MessageBox.Show("删除成功");

                                dgv();
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择要删除的用户");
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_info.SelectedItems.Count == 1)
                {
                    if (LV_info.SelectedItems[0].SubItems[0].Text.Trim() == "超级管理员")
                    {
                        MessageBox.Show("不能删除超级管理员");
                        return;
                    }
                    if (MessageBox.Show("你确认要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        //获取权限类型编号
                        string str_sql = "select Pt_ID from tb_powertype where Pt_Name='" + LV_info.SelectedItems[0].SubItems[0].Text.Trim() + "'";
                        DataSet ds = db.GetDataFromSQL(str_sql);
                        int b = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());

                        str_sql = "delete from tb_power where power_type='" + b + "'";
                        if (db.ExecSQl(str_sql))
                        {
                            str_sql = "delete from tb_powertype where Pt_Name='" + LV_info.SelectedItems[0].SubItems[0].Text.Trim() + "'";
                            db.ExecSQl(str_sql);
                            MessageBox.Show("删除成功");
                            quanxian();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择要删除的信息");
                }
            }
            catch { }
        }
    }
}
