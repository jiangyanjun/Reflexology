using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Foot.Client
{
    public partial class Frm_WaiterXG : Form
    {
        public Frm_WaiterXG()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 员工编号
        /// </summary>
        public string ID;
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
                // 查询职务编号
                string zw = "select Duty_ID from tb_duty where Duty_Name='" + CB_ZW.Text.Trim() + "'";
                DataSet ds = db.GetDataFromSQL(zw);
                int zwid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());

                string str_sql = string.Empty;
                if (ID == null)
                {
                    if (TB_Name.Text == "" || TB_Age.Text == "" || TB_IDcard.Text == "")
                    {
                        MessageBox.Show("请填写完整");
                    }
                    else
                    {
                        str_sql = "select count(*) from tb_Waiter where Waiter_IDCard='" + TB_IDcard.Text.Trim() + "'";
                        int fh = db.YZSql(str_sql);
                        if (fh > 0)
                        {
                            MessageBox.Show("此身份证号码已存在");
                        }
                        else
                        {
                            str_sql = "insert into tb_Waiter(Waiter_ID,Waiter_Nmae,Waiter_Sex,Waiter_Age,Waiter_Phone,Waiter_duty,Waiter_birthday,Waiter_IDCard,Waiter_Stime,Waiter_Address,Beizhu) values ('" + TB_ID.Text.Trim() + "','" + TB_Name.Text.Trim() + "','" + CB_Sex.Text.Trim() + "'"
                            + ",'" + TB_Age.Text.Trim() + "','" + TB_Tel.Text.Trim() + "','" + zwid + "'"
                               + ",'" + DTP_SR.Text.Trim() + "','" + TB_IDcard.Text.Trim() + "','" + DTP_Sbsj.Text.Trim() + "','" + TB_address.Text.Trim() + "','" + TB_BZ.Text.Trim() + "')";

                            if (db.ExecSQl(str_sql))
                            {
                                MessageBox.Show("增加员工成功！");
                                bianhao();
                                TB_Name.Text = "";
                                DTP_SR.Text = "";
                                TB_Age.Text = "";
                                TB_address.Text = "";
                                TB_IDcard.Text = "";
                                TB_Tel.Text = "";
                                CB_ZW.SelectedIndex = 0;
                                TB_BZ.Text = "无";
                                DTP_Sbsj.Text = "";
                                CB_Sex.SelectedIndex = 1;
                            }
                        }
                    }
                }
                else
                {
                    if (TB_Name.Text == "" || TB_Age.Text == "" || TB_IDcard.Text == "")
                    {
                        MessageBox.Show("请填写完整");
                    }
                    else
                    {
                        //查询此身份证数据库中存在没
                        str_sql = "select Waiter_IDCard from tb_Waiter where Waiter_IDCard='" + TB_IDcard.Text.Trim() + "'";
                        ds  = db.GetDataFromSQL(str_sql);

                        str_sql = "select Waiter_IDCard from tb_Waiter where Waiter_ID='" + ID + "'";
                        string sfz = db.GetDataFromSQL(str_sql).Tables[0].Rows[0][0].ToString().Trim();
                        if (ds.Tables[0].Rows.Count>0 && sfz != ds.Tables[0].Rows[0][0].ToString().Trim())
                        {
                            MessageBox.Show("此身份证号码已存在");
                        }
                        else
                        {
                            str_sql = "update tb_Waiter set Waiter_Nmae='" + TB_Name.Text.Trim() + "',Waiter_Sex='" + CB_Sex.Text.Trim() + "', Waiter_birthday='" + DTP_SR.Text.Trim() + "',"
                            + "Waiter_Age='" + TB_Age.Text.Trim() + "', Waiter_IDCard='" + TB_IDcard.Text.Trim() + "',"
                            + "Waiter_Phone='" + TB_Tel.Text.Trim() + "', Waiter_duty='" + zwid + "',Waiter_Stime='" + DTP_Sbsj.Text.Trim() + "',Waiter_Address='" + TB_address.Text.Trim() + "',Beizhu='" + TB_BZ.Text.Trim() + "'"
                            + "where Waiter_ID='" + TB_ID.Text.Trim() + "'";

                            if (db.ExecSQl(str_sql))
                            {
                                MessageBox.Show("成功！");
                                this.Close();
                            }
                        }
                    }
                }


            }
            catch { }
        }

        private void Frm_WaiterXG_Load(object sender, EventArgs e)
        {
            try
            {
                //查 职务名称到 cb_zw 里显示
                string str_sql = "select * from tb_duty";
                DataSet ds = db.GetDataFromSQL(str_sql);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    CB_ZW.Items.Add(ds.Tables[0].Rows[i]["Duty_Name"].ToString().Trim());
                }
                CB_ZW.SelectedIndex = 0;

                if (ID == null)
                {
                    this.Text = "添加员工";
                    CB_Sex.SelectedIndex = 1;
                    bianhao();
                }
                else
                {
                    this.Text = "修改员工";
                    string str_sql1 = "select * from tb_Waiter where Waiter_ID='" + ID + "'";
                    DataSet dst = db.GetDataFromSQL(str_sql1);
                    TB_ID.Text = ID;
                    TB_Name.Text = dst.Tables[0].Rows[0]["Waiter_Nmae"].ToString().Trim();
                    CB_Sex.Text = dst.Tables[0].Rows[0]["Waiter_Sex"].ToString().Trim();
                    DTP_SR.Text = dst.Tables[0].Rows[0]["Waiter_birthday"].ToString().Trim();
                    TB_Age.Text = dst.Tables[0].Rows[0]["Waiter_Age"].ToString().Trim();
                    TB_address.Text = dst.Tables[0].Rows[0]["Waiter_Address"].ToString().Trim();
                    TB_IDcard.Text = dst.Tables[0].Rows[0]["Waiter_IDCard"].ToString().Trim();
                    TB_Tel.Text = dst.Tables[0].Rows[0]["Waiter_Phone"].ToString().Trim();
                    TB_BZ.Text = dst.Tables[0].Rows[0]["Beizhu"].ToString().Trim();
                    DTP_Sbsj.Text = dst.Tables[0].Rows[0]["Waiter_Stime"].ToString().Trim();



                    // 查询当前员工职务名称
                    string z = dst.Tables[0].Rows[0]["Waiter_duty"].ToString().Trim();
                    string zw = "select Duty_Name from tb_duty where Duty_ID='" + z + "'";
                    ds = db.GetDataFromSQL(zw);
                    CB_ZW.Text = ds.Tables[0].Rows[0][0].ToString().Trim();
                }
            }
            catch { }
        }
        /// <summary>
        /// 生成编号方法
        /// </summary>
        private void  bianhao()
        {
            try
            {
                string str_sql = "select max(Waiter_ID) from tb_Waiter";
                DataSet ds = db.GetDataFromSQL(str_sql);
                string bh = ds.Tables[0].Rows[0][0].ToString().Trim();
                if (bh == "")
                {
                    TB_ID.Text = "YG001";
                }
                else
                {
                    TB_ID.Text = (Convert.ToInt32(bh.Substring(2, 3)) + 1).ToString("YG000");
                }
            }
            catch { }
        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB_BZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                but_OK_Click(sender,e);
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

        private void TB_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
           
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

        private void TB_Tel_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //验证电话号码
                Regex reg = new Regex("^((\\(\\d{3}\\))|(\\d{3}\\-))?13[0-9]\\d{8}|15[126089]\\d{8}");
                if (!reg.IsMatch(this.TB_Tel.Text.Trim()))
                {
                    this.errorProvider2.SetError(this.TB_Tel, "请输入正确的电话号码");
                    e.Cancel = true;
                }
                else
                {
                    this.errorProvider2.SetError(this.TB_Tel, "");
                }
            }
            catch { }
        }

        private void TB_Age_TextChanged(object sender, EventArgs e)
        {
        }

        private void TB_Age_Leave(object sender, EventArgs e)
        {
            if (TB_Age.Text.Trim() == "")
            { 
            }
            else
            {
                if (Convert.ToInt32(TB_Age.Text.Trim()) < 16 || Convert.ToInt32(TB_Age.Text.Trim()) > 65)
                {
                    MessageBox.Show("年龄只能输入16-65之间");
                    TB_Age.Focus();
                    TB_Age.SelectAll();
                }
            }
        }


    }
}
