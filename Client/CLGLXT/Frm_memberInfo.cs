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
    public partial class Frm_memberInfo : UserControl
    {
        public Frm_memberInfo()
        {
            InitializeComponent();
        }
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        private void but_xianshi_Click(object sender, EventArgs e)
        {

            try
            {
                string str_sql = "select a.member_ID,a.member_Name,b.Mt_Name,a.member_Sex,a.Member_birthday,a.member_Phone,a.Member_djrq,a.member_JF,a.member_type,a.member_IDCard,a.beizhu  from tb_member a,tb_membertype  b where a.Member_DJ=b.Mt_ID";
                DataSet ds = db.GetDataFromSQL(str_sql);
                DGV_info.DataSource = ds.Tables[0];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    CB_ID.Items.Add(ds.Tables[0].Rows[i]["member_ID"].ToString().Trim());
                }

                CB_dengji.Text = "";
                CB_ID.Text = "";
                TB_Name.Text = "";
            }
            catch { }
        }

        private void Frm_member_Load(object sender, EventArgs e)
        {
            try
            {
                //查找会员等级名称
                string sql = "select Mt_Name from tb_membertype";
                DataSet ds1 = db.GetDataFromSQL(sql);
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    CB_dengji.Items.Add(ds1.Tables[0].Rows[i][0].ToString().Trim());
                }
                but_xianshi_Click(sender, e);


            }
            catch { }
        }
        private void chaxun()
        {
            try
            {
                string str_sql = "select a.member_ID,a.member_Name,b.Mt_Name,a.member_Sex,a.Member_birthday,a.member_Phone,a.Member_djrq,a.member_JF,a.member_type,a.member_IDCard,a.beizhu  from tb_member a,tb_membertype  b where a.Member_DJ=b.Mt_ID";

                if (TB_Name.Text.Trim() != "")
                {
                    str_sql += " and member_Name like '%" + TB_Name.Text.Trim() + "%'";
                }
                if (CB_dengji.Text.Trim() != "")
                {
                    str_sql += " and Mt_Name='" + CB_dengji.Text.Trim() + "'";
                }
                if (CB_ID.Text.Trim() != "")
                {
                    str_sql += " and member_ID='" + CB_ID.Text.Trim() + "'";
                }

                DataSet ds = db.GetDataFromSQL(str_sql);
                DGV_info.DataSource = ds.Tables[0];
            }
            catch { }
        }

        private void but_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_info.SelectedRows.Count == 1)
                {
                    string Bh = DGV_info.SelectedRows[0].Cells["Column1"].Value.ToString().Trim();
                    string str_sql = "delete from tb_member where member_ID='" + Bh + "'";
                    if (MessageBox.Show("你确定要删除吗?", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        db.ExecSQl(str_sql);
                        //if ()
                        //{
                        //    MessageBox.Show("成功");
                        //}
                        but_xianshi_Click(sender, e);
                    }

                }
                else
                {
                    MessageBox.Show("请选择会员");
                }
            }
            catch { }
        }

        private void TB_Name_TextChanged(object sender, EventArgs e)
        {
            chaxun();
        }

        private void CB_ID_SelectedValueChanged(object sender, EventArgs e)
        {
            chaxun();
        }

        private void CB_dengji_SelectedValueChanged(object sender, EventArgs e)
        {
            chaxun();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            hy.ShowDialog();
            but_xianshi_Click(sender, e);
        }

        Frm_memberXG hy = new Frm_memberXG();

        private void but_xiugai_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_info.SelectedRows.Count == 1)
                {
                    //获取会员编号
                    hy.ID = DGV_info.SelectedRows[0].Cells["Column1"].Value.ToString().Trim();
                    hy.ShowDialog();
                    but_xianshi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("请选择会员");
                }
            }
            catch { }
        }

        private void DGV_info_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            but_Del_Click(sender, e);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            but_add_Click(sender, e);
            but_xianshi_Click(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            but_xiugai_Click(sender, e);
            but_xianshi_Click(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            but_Del_Click(sender, e);
            but_xianshi_Click(sender, e);
        }
    }
}
