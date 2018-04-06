using Foot.EntityLayers;
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
    public partial class Frm_Yuding : Form
    {
        internal tb_Desk deskResult;
        public Frm_Yuding()
        {
            InitializeComponent();
        }
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();

        private void but_Add_Click(object sender, EventArgs e)
        {
            Frm_YudingXG yd = new Frm_YudingXG();
            //添加
            Frm_YudingXG.strbianhao = "0";
            yd.ShowDialog();
        }

        private void but_xiugai_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_info.SelectedItems.Count == 1)
                {
                    Frm_YudingXG yd = new Frm_YudingXG();
                    //修改
                    Frm_YudingXG.strbianhao = "1";
                    yd.RName = LV_info.SelectedItems[0].SubItems[3].Text.Trim();
                    yd.ShowDialog();
                }
                else
                {
                    MessageBox.Show("请选择要修改信息");
                }
            }
            catch { }
        }

        private void but_Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_info.SelectedItems.Count == 1)
                {
                    FrmOrder k = new FrmOrder();
                    //k.re = LV_info.SelectedItems[0].SubItems[3].Text.Trim();
                    k.ShowDialog();
                }
            }
            catch { }
        }

        private void 开单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            but_Open_Click(sender, e);
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            but_Add_Click(sender, e);
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            but_xiugai_Click(sender, e);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            but_del_Click(sender, e);
        }


        private void but_del_Click(object sender, EventArgs e)
        {

            try
            {
                if (LV_info.SelectedItems.Count == 1)
                {

                    string ztmc = LV_info.SelectedItems[0].SubItems[3].Text.Trim();
                    if (MessageBox.Show("你确认要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        string str_sql = "delete from tb_Booked where Yd_deskName='" + ztmc + "'";
                        if (db.ExecSQl(str_sql))
                        {
                            //更改桌台状态
                            str_sql = "update tb_Desk set TypeId='可用' where Id='" + ztmc + "'";
                            db.ExecSQl(str_sql);

                            MessageBox.Show("删除成功");
                            Frm_Yuding_Activated(sender, e);
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

        private void Frm_Yuding_Load(object sender, EventArgs e)
        {

            but_chaxun_Click(sender, e);
        }

        private void Frm_Yuding_Activated(object sender, EventArgs e)
        {
            but_chaxun_Click(sender, e);

        }

        private void TB_Name_TextChanged(object sender, EventArgs e)
        {
            chaxun();

        }
        /// <summary>
        /// 查询
        /// </summary>
        private void chaxun()
        {
            try
            {

                LV_info.Items.Clear();
                string str_sql = "select Yd_Name,Yd_Tel,Yd_desktype,Yd_deskName,Yd_rqtime+Yd_time as YD_SJ,Beizhu  from tb_Booked where 1=1";
                if (TB_Id.Text.Trim() != "")
                {
                    str_sql += " and Yd_deskName like '%" + TB_Id.Text.Trim() + "%'";
                }
                if (TB_Name.Text.Trim() != "")
                {
                    str_sql += " and Yd_Name like '%" + TB_Name.Text.Trim() + "%'";
                }
                DataSet ds = db.GetDataFromSQL(str_sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i]["Yd_Name"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Yd_Tel"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Yd_desktype"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Yd_deskName"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["YD_SJ"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Beizhu"].ToString().Trim());
                    LV_info.Items.Add(lv);
                }
            }
            catch { }
        }

        private void but_chaxun_Click(object sender, EventArgs e)
        {
            try
            {
                LV_info.Items.Clear();
                string str_sql = "select Yd_Name,Yd_Tel,Yd_desktype,Yd_deskName,Yd_rqtime+Yd_time as YD_SJ,Beizhu from tb_Booked";
                DataSet ds = db.GetDataFromSQL(str_sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i]["Yd_Name"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Yd_Tel"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Yd_desktype"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Yd_deskName"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["YD_SJ"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["Beizhu"].ToString().Trim());
                    LV_info.Items.Add(lv);
                }
            }
            catch { }
        }

        private void LV_info_DoubleClick(object sender, EventArgs e)
        {
            but_Open_Click(sender, e);
        }

        private void LV_info_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            but_Open_Click(sender, e);
        }

        private void TB_Id_TextChanged(object sender, EventArgs e)
        {

            chaxun();
        }

    }
}
