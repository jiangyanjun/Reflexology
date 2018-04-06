using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kebue.Core.Util;

namespace Foot.Client
{
    public partial class Frm_Zttype : UserControl
    {
        public Frm_Zttype()
        {
            InitializeComponent();
        }
        DAL.DBConnection db=new Foot.Client.DAL.DBConnection();
        private void Frm_Zttype_Load(object sender, EventArgs e)
        {
            try
            {
                LV_info.Items.Clear();
                string str_sql = "select * from tb_DeskType";
                DataSet ds = db.GetDataFromSQL(str_sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i]["Id"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["DT_type"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["DT_Num"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["DT_number"].ToString().Trim());
                    lv.SubItems.Add(ds.Tables[0].Rows[i]["DT_ZDXF"].ToString().Trim());
                    LV_info.Items.Add(lv);

                    TB_ID.Text = "";
                    TB_Name.Text = "";
                    TB_sl.Text = "0";
                    TB_Num.Text = "0";
                    TB_ZDXF.Text = "0";
                }
            }
            catch { }
        }

        private void but_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_Name.Text != "" && TB_sl.Text.Trim() != "" && TB_Num.Text.Trim() != "" && TB_ZDXF.Text.Trim() != "")
                {
                    string str_sqll = "select count(*) from tb_DeskType where DT_type='" + TB_Name.Text.Trim() + "'";
                    int a = db.YZSql(str_sqll);
                    if (a > 0)
                    {
                        MessageBox.Show("此桌台类型存在");

                        TB_ID.Text = "";
                        TB_Name.Text = "";
                        TB_sl.Text = "0";
                        TB_Num.Text = "0";
                        TB_ZDXF.Text = "0";
                    }
                    else
                    {
                        //string s="";
                        //for(int i=0;i<TB_ID.Text.Length;i++)
                        //{
                        //    string n=TB_ID.Text.Substring(i,1);
                        //    string f="";
                        //}
                        //插入桌台类型
                        string str_sql = "insert into tb_DeskType values('" + TB_Name.Text.Trim() + "','" + TB_Num.Text.Trim() + "','" + TB_sl.Text.Trim() + "','" + TB_ZDXF.Text.Trim() + "')";

                        if (db.ExecSQl(str_sql))
                        {
                            bool fa = false;
                            //查询桌台类型编号
                            str_sql = "select Id from tb_DeskType where DT_type='" + TB_Name.Text.Trim() + "'";
                            int bh = Convert.ToInt32(db.GetDataFromSQL(str_sql).Tables[0].Rows[0][0].ToString().Trim());
                            //获取桌台类型的首字母 
                            string py = PinYinHelper.GetFirstPinyin(TB_Name.Text.Trim());
                            //插入桌台
                            for (int i = 0; i < Convert.ToInt32(TB_sl.Text.Trim()); i++)
                            {
                                str_sql = "insert into tb_Desk values('" + py.Substring(0, 1).ToString().Trim() + (i + 1) + "','" + bh + "','" + "可用" + "')";
                                fa = db.ExecSQl(str_sql);
                            }
                            if (fa)
                            {
                                MessageBox.Show("添加成功");
                                Frm_Zttype_Load(sender, e);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请填写完整");
                }
            }
            catch { }
        }

        private void but_xiugai_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_ZDXF.Text.Trim()!=""&&TB_Name.Text.Trim() != "" && TB_sl.Text.Trim() != "" && TB_Num.Text.Trim() != "")
                {
                    string str_sql = "select count(*) from tb_DeskType where DT_type='" + TB_Name.Text.Trim() + "'";
                    int a = db.YZSql(str_sql);
                    if (a > 0 && TB_Name.Text != LV_info.SelectedItems[0].SubItems[1].Text.Trim())
                    {
                        MessageBox.Show("此桌台类型在");

                        TB_ID.Text = "";
                        TB_Name.Text = "";
                        TB_sl.Text = "0";
                        TB_Num.Text = "0";
                        TB_ZDXF.Text = "0";
                    }
                    else
                    {

                        //判断是否改变了桌台类型
                        //if (TB_Name.Text.Trim!=LV_info.SelectedItems[0].SubItems[1].Text.Trim())
                        //{
                        // 获取桌台类型的首字母 
                        string py = PinYinHelper.GetFirstPinyin(TB_Name.Text.Trim());
                        //删除此桌台类型原有的桌台
                        str_sql = "delete from tb_Desk where Name='" + TB_ID.Text.Trim() + "'";
                        db.ExecSQl(str_sql);
                        //插入桌台
                        for (int i = 0; i < Convert.ToInt32(TB_sl.Text.Trim()); i++)
                        {
                            str_sql = "insert into tb_Desk values('" + py.Substring(0, 1).ToString().Trim() + (i + 1) + "','" + TB_ID.Text.Trim() + "','" + "可用" + "')";
                            db.ExecSQl(str_sql);
                        }
                        #region 
                        //if (fa)
                        //{
                        //    MessageBox.Show("添加成功");
                        //    _3_Load(sender, e);
                        //}
                        //}
                        //else
                        //{
                        //    //查询桌台数量
                        //str_sql = "select DT_number from tb_DeskType where Id='" + TB_ID.Text.Trim() + "'";
                        //string sl = db.GetDataFromSQL(str_sql).Tables[0].Rows[0][0].ToString().Trim();

                        //    //输入的桌台数量大于原有的数量   就添加
                        //    if (Convert.ToInt32(TB_sl.Text.Trim()) >= Convert.ToInt32(sl))
                        //    {
                        //        int zj = Convert.ToInt32(TB_sl.Text.Trim()) - Convert.ToInt32(sl);

                        //        for (int i = 0; i < zj; i++)
                        //        {
                        //            str_sql = "select max(desk_ID) from tb_Desk where Name='" + TB_ID.Text.Trim() + "'";
                        //            DataSet ds = db.GetDataFromSQL(str_sql);
                        //            string bianh = ds.Tables[0].Rows[0][0].ToString().Trim();
                        //            str_sql = "insert into tb_Desk values('" + bianh.Substring(0, 1) + (Convert.ToInt32(bianh.Substring(1)) + 1).ToString().Trim() + "','" + Convert.ToInt32(TB_ID.Text.Trim()) + "','" + "可用" + "')";
                        //            db.ExecSQl(str_sql);
                        //        }
                        //    }
                        //    //输入的桌台数量小于原有的数量   就删除
                        //    else
                        //    {
                        //        int zj = Convert.ToInt32(sl) - Convert.ToInt32(TB_sl.Text.Trim());
                        //        for (int i = 0; i < zj; i++)
                        //        {
                        //            str_sql = "select max(desk_ID) from tb_Desk where Name='" + TB_ID.Text.Trim() + "'";
                        //            DataSet ds = db.GetDataFromSQL(str_sql);
                        //            str_sql = "delete from tb_Desk where Name='" + TB_ID.Text.Trim() + "'and desk_ID='" + ds.Tables[0].Rows[0][0].ToString().Trim() + "'";
                        //            db.ExecSQl(str_sql);
                        //        }

                        //    }
                        //}
                        //修改桌台类型
                        #endregion
                        str_sql = "update tb_DeskType set DT_type='" + TB_Name.Text.Trim() + "',DT_Num='" + TB_Num.Text.Trim() + "',DT_number='" + TB_sl.Text.Trim() + "',DT_ZDXF='"+TB_ZDXF.Text.Trim()+ "' where Id='" + TB_ID.Text.Trim() + "'";

                        if (db.ExecSQl(str_sql))
                        {

                            MessageBox.Show("修改成功");

                            Frm_Zttype_Load(sender, e);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("请填写完整");
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
                    string bh = LV_info.SelectedItems[0].SubItems[0].Text.Trim();
                    if (MessageBox.Show("你确认要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        string str_sql = "select * from tb_Desk where Name='" + bh + "' and TypeId='使用' or TypeId='" + bh + "' and Desk_type='预定'";
                        DataSet ds = db.GetDataFromSQL(str_sql);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            string syzt = string.Empty;
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                syzt += ds.Tables[0].Rows[i]["Id"].ToString().Trim() + "桌台处于" + ds.Tables[0].Rows[i]["TypeId"].ToString().Trim() + "状态，无法删除\n";
                            }
                            if (syzt != "")
                            {
                                MessageBox.Show(syzt);
                            }
                        }
                        else
                        {
                            str_sql = "delete from tb_DeskType where  Id='" + bh + "'";
                            if (db.ExecSQl(str_sql))
                            {
                                str_sql = "delete from tb_Desk where Name='" + TB_ID.Text.Trim() + "'";
                                db.ExecSQl(str_sql);
                                MessageBox.Show("删除成功");
                                Frm_Zttype_Load(sender, e);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择要删除的桌台类型");
                }
            }
            catch { }
        }

        private void TB_sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 13)
            {
                but_Add_Click(sender,e);
            }
        }

        private void TB_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void LV_info_Click(object sender, EventArgs e)
        {
            try
            {
                if (LV_info.SelectedItems.Count == 1)
                {

                    TB_ID.Text = LV_info.SelectedItems[0].SubItems[0].Text.Trim();
                    TB_Name.Text = LV_info.SelectedItems[0].SubItems[1].Text.Trim();
                    TB_Num.Text = LV_info.SelectedItems[0].SubItems[2].Text.Trim();
                    TB_sl.Text = LV_info.SelectedItems[0].SubItems[3].Text.Trim();
                    TB_ZDXF.Text = LV_info.SelectedItems[0].SubItems[4].Text.Trim();
                }
            }
            catch { }
        }

        private void TB_ZDXF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar) && e.KeyChar != 46)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
            if (this.TB_ZDXF.Text.Contains("."))
            {
                if (e.KeyChar == 46)
                {
                    e.Handled = true;
                }
            }
        }

        private void TB_ZDXF_TextChanged(object sender, EventArgs e)
        {
            if (TB_ZDXF.Text.StartsWith("."))
            {
                TB_ZDXF.Text = "0.";
                TB_ZDXF.SelectionStart = 2;
            }
        }
    }
}
