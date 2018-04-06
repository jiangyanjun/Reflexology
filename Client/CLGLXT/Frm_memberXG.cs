using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Foot.Proxy;
using Foot.EntityLayers;
using Kebue.Core.Util;

namespace Foot.Client
{
    public partial class Frm_memberXG : Form
    {
        public Frm_memberXG()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 会员编号
        /// </summary>
        public string ID;

        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        private void Frm_memberXG_Load(object sender, EventArgs e)
        {
            try
            {
                //查找会员等级名称
                ClientServicesProxy proxys = new ClientServicesProxy();
                tb_membertype p = new tb_membertype();
                var result = proxys.Find(p);
                foreach (var item in result)
                {
                    CB_grade.Items.Add(item.Mt_Name);
                }
                //判断是添加还是修改
                if (ID == null)
                {

                    this.Text = "添加会员";
                    bianhao();
                    TB_BZ.Text = "无";
                    TB_IDcard.Text = "";
                    TB_Name.Text = "";
                    TB_Tel.Text = "";
                    CB_grade.SelectedIndex = 0;
                    CB_Sex.SelectedIndex = 1;
                    CB_Type.SelectedIndex = 0;
                    TB_jifen.Enabled = false;
                    //根据会员等级显示新会员初始积分
                    p.Mt_Name = CB_grade.Text.Trim();
                    result = proxys.Find(p);
                    if (result.IsNotNull())
                    {
                        TB_jifen.Text = result.FirstOrDefault().Mt_csjf;
                    }
                }
                else
                {
                    this.Text = "修改会员";
                    string str_sql1 = "select a.member_ID,a.member_Name, b.Mt_Name,a.member_Sex,a.Member_birthday,a.Member_Phone,a.Member_DJRQ,"
                        + "a.Member_JF,a.Member_type,a.member_IDCard,a.Beizhu from tb_member a,tb_membertype b where a.Member_DJ=b.Mt_ID and a.member_ID='" + ID + "'";
                    DataSet dst = db.GetDataFromSQL(str_sql1);
                    TB_ID.Text = ID;
                    TB_Name.Text = dst.Tables[0].Rows[0]["member_Name"].ToString().Trim();
                    CB_Sex.Text = dst.Tables[0].Rows[0]["member_Sex"].ToString().Trim();
                    DTP_SR.Text = dst.Tables[0].Rows[0]["Member_birthday"].ToString().Trim();
                    TB_jifen.Text = dst.Tables[0].Rows[0]["Member_JF"].ToString().Trim();
                    TB_IDcard.Text = dst.Tables[0].Rows[0]["member_IDCard"].ToString().Trim();
                    TB_Tel.Text = dst.Tables[0].Rows[0]["Member_Phone"].ToString().Trim();
                    CB_grade.Text = dst.Tables[0].Rows[0]["Mt_Name"].ToString().Trim();
                    CB_Type.Text = dst.Tables[0].Rows[0]["Member_type"].ToString().Trim();
                    TB_BZ.Text = dst.Tables[0].Rows[0]["Beizhu"].ToString().Trim();
                    DTP_Djrq.Text = dst.Tables[0].Rows[0]["Member_DJRQ"].ToString().Trim();
                }
            }
            catch { }
        }

        private void bianhao()
        {
            try
            {
                string str_sql = "select max(member_ID) from tb_member";
                DataSet ds = db.GetDataFromSQL(str_sql);
                string bh = ds.Tables[0].Rows[0][0].ToString().Trim();
                if (bh == "")
                {
                    TB_ID.Text = "HY001";
                }
                else
                {
                    TB_ID.Text = (Convert.ToInt32(bh.Substring(2, 3)) + 1).ToString("HY000");
                }
            }
            catch { }
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
                // 查询会员等级编号
                string zw = "select Mt_ID from tb_membertype where Mt_Name='" + CB_grade.Text.Trim() + "'";
                DataSet ds = db.GetDataFromSQL(zw);
                int djid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());

                string str_sql = string.Empty;
                //判断是添加还是修改
                if (ID == null)
                {
                    if (TB_jifen.Text.Trim() == "" || TB_Name.Text.Trim() == "" || TB_IDcard.Text.Trim() == "")
                    { }
                    else
                    {
                        str_sql = "select count(*) from tb_member where member_IDCard='" + TB_IDcard.Text.Trim() + "'";
                        int fh = db.YZSql(str_sql);
                        if (fh > 0)
                        {
                            MessageBox.Show("此身份证号码已存在");
                        }
                        else
                        {
                            str_sql = "insert into tb_member values ('" + TB_ID.Text.Trim() + "','" + TB_Name.Text.Trim() + "','" + djid + "','" + CB_Sex.Text.Trim() + "',"
                            + "'" + DTP_SR.Text.Trim() + "','" + TB_Tel.Text.Trim() + "','" + DTP_Djrq.Text.Trim() + "','" + TB_jifen.Text.Trim() + "',"
                               + "'" + CB_Type.Text.Trim() + "','" + TB_IDcard.Text.Trim() + "','" + TB_BZ.Text.Trim() + "')";
                            if (db.ExecSQl(str_sql))
                            {
                                MessageBox.Show("添加成功");
                                // bianhao();
                                TB_IDcard.Text = "";
                                TB_Name.Text = "";
                                TB_Tel.Text = "";
                                TB_ID.Text = "";
                                TB_BZ.Text = "无";
                                CB_grade.SelectedIndex = 0;
                                CB_Sex.SelectedIndex = 0;
                                CB_Type.SelectedIndex = 0;
                                but_Close_Click(sender, e);
                            }
                        }
                    }
                }
                else
                {
                    if (TB_jifen.Text.Trim() == "" || TB_Name.Text.Trim() == "" || TB_IDcard.Text.Trim() == "")
                    { }
                    else
                    {
                        str_sql = "select member_IDCard from tb_member where member_IDCard='" + TB_IDcard.Text.Trim() + "'";
                        ds = db.GetDataFromSQL(str_sql);
                        string sfz = "";
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            sfz = ds.Tables[0].Rows[0][0].ToString().Trim();
                        }
                        str_sql = "select member_IDCard from tb_member where member_ID='" + ID + "'";
                        ds = db.GetDataFromSQL(str_sql);
                        if (sfz != "" && sfz != ds.Tables[0].Rows[0][0].ToString().Trim())
                        {
                            MessageBox.Show("此身份证号码已存在");
                        }
                        else
                        {

                            str_sql = "update tb_member set member_Name='" + TB_Name.Text.Trim() + "',member_Sex='" + CB_Sex.Text.Trim() + "', Member_birthday='" + DTP_SR.Text.Trim() + "',"
                            + "Member_JF='" + TB_jifen.Text.Trim() + "', Member_DJRQ='" + DTP_Djrq.Text.Trim() + "', member_IDCard='" + TB_IDcard.Text.Trim() + "',"
                            + "Member_Phone='" + TB_Tel.Text.Trim() + "', Member_DJ='" + djid + "', Member_type='" + CB_Type.Text.Trim() + "',Beizhu='" + TB_BZ.Text.Trim() + "'"
                            + "where member_ID='" + TB_ID.Text.Trim() + "'";
                            if (db.ExecSQl(str_sql))
                            {
                                MessageBox.Show("修改成功");
                                but_Close_Click(sender, e);
                            }
                        }
                    }
                }

                Frm_memberXG_Load(sender, e);
            }
            catch { }

        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            //TB_IDcard.Text = "";
            //TB_Name.Text = "";
            //TB_Tel.Text = "";
            //TB_ID.Text = "";
            //TB_BZ.Text = "无";
            //CB_grade.SelectedIndex = 0;
            //CB_Sex.SelectedIndex = 0;
            //CB_Type.SelectedIndex = 0;
            ID = null;
            this.Close();

        }

        /// <summary>
        /// 通过等级查积分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_grade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ID == null)
                {
                    string str_sql = "select Mt_csjf from tb_membertype where Mt_Name='" + CB_grade.Text.Trim() + "'";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    TB_jifen.Text = ds.Tables[0].Rows[0][0].ToString().Trim();
                }
            }
            catch { }
        }

        private void TB_BZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                but_OK_Click(sender, e);
            }
        }

        private void TB_IDcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 13)
            //{
            //    MessageBox.Show("请输入数字!");
            //    e.Handled = true;
            //}
        }

        private void TB_Tel_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 13)
            //{
            //    MessageBox.Show("请输入数字!");
            //    e.Handled = true;
            //}
        }

        private void TB_jifen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void TB_Tel_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //验证电话号码
                Regex reg = new Regex("^((\\(\\d{3}\\))|(\\d{3}\\-))?13[0-9]\\d{8}|15[126089]\\d{8}");
                if (!reg.IsMatch(this.TB_Tel.Text))
                {
                    this.errorProvider1.SetError(this.TB_Tel, "请输入正确的电话号码");
                    e.Cancel = true;
                }
                else
                {
                    this.errorProvider1.SetError(this.TB_Tel, "");
                }
            }
            catch { }
        }

        private void TB_IDcard_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //验证身份证
                Regex reg = new Regex(@"^\d{15}|\d{18}$");
                if (!reg.IsMatch(this.TB_IDcard.Text))
                {
                    this.errorProvider1.SetError(this.TB_IDcard, "请输入正确的身份证号码");
                    e.Cancel = true;
                }
                else
                {
                    this.errorProvider1.SetError(this.TB_IDcard, "");
                }
            }
            catch { }
        }

    }
}
