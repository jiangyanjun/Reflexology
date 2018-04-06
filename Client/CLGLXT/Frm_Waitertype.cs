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
    public partial class Frm_Waitertype : UserControl
    {
        public Frm_Waitertype()
        {
            InitializeComponent();
        }

        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();

        private void but_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_Name.Text != "")
                {
                    string str_sqll = "select count(*) from tb_duty where Duty_Name='" + TB_Name.Text.Trim() + "'";
                    int a=db.YZSql(str_sqll);
                    if (a > 0)
                    {
                        MessageBox.Show("此职位名称已存在");
                        TB_Id.Text = "";
                        TB_Name.Text = "";
                    }
                    else
                    {
                        string str_sql = "insert into tb_duty values('" + TB_Name.Text.Trim() + "')";
                        if (db.ExecSQl(str_sql))
                        {
                            MessageBox.Show("添加成功");
                            Frm_Waitertype_Load(sender, e);
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
                    string str_sqll = "select count(*) from tb_duty where Duty_Name='" + TB_Name.Text.Trim() + "'";
                    int a = db.YZSql(str_sqll);
                    if (a > 0 && TB_Name.Text != LV_info.SelectedItems[0].SubItems[1].Text.Trim())
                    {
                        MessageBox.Show("此职位名称已存在");
                        TB_Id.Text = "";
                        TB_Name.Text = "";

                    }
                    else
                    {
                        string str_sql = "update tb_duty set Duty_Name='" + TB_Name.Text.Trim() + "' where Duty_ID='" + TB_Id.Text.Trim() + "'";
                        if (db.ExecSQl(str_sql))
                        {
                            MessageBox.Show("修改成功");

                            Frm_Waitertype_Load(sender, e);
                        }
                    }
                }
            }
            catch { }
        }

        private void lvEmployeeType_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_info.SelectedItems.Count == 1)
                {

                    TB_Id.Text = LV_info.SelectedItems[0].SubItems[0].Text.Trim();
                    TB_Name.Text = LV_info.SelectedItems[0].SubItems[1].Text.Trim();
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
                    if (MessageBox.Show("你确认要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        string str_sql = "delete from tb_duty where Duty_ID='" + LV_info.SelectedItems[0].SubItems[0].Text.Trim() + "'";
                        if (db.ExecSQl(str_sql))
                        {
                            MessageBox.Show("删除成功");
                            Frm_Waitertype_Load(sender, e);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择要删除职位");
                }
            }
            catch { }
        }


        private void TB_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                but_Add_Click(sender,e);
            }
        }

        private void Frm_Waitertype_Load(object sender, EventArgs e)
        {
            try
            {
                LV_info.Items.Clear();
                string str_sql = "select * from tb_duty";
                DataSet ds = db.GetDataFromSQL(str_sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i]["Duty_ID"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Duty_Name"].ToString().Trim());
                    LV_info.Items.Add(lv);
                }
            }
            catch { }
        }
    }
}
