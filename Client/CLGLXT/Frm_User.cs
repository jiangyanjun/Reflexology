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
    public partial class Frm_User : Form
    {
        public Frm_User()
        {
            InitializeComponent();
        }
        public string Rname;
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        
        private void Frm_User_Load(object sender, EventArgs e)
        {

            try
            {
                //查询权限名称
                string str_sql = "select Pt_Name from tb_powertype where Pt_Name !='超级管理员'";
                DataSet ds = db.GetDataFromSQL(str_sql);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    CB_Type.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim());
                }

                CB_Type.SelectedIndex = 0;
                if (Rname == null)
                {
                    this.Text = "添加用户";
                    checkBox1.Visible = false;
                    label3.Visible = true;
                }
                else
                {
                    this.Text = "修改用户";
                    str_sql = "select a.User_Pwd,b.Pt_Name from tb_User  a, tb_powertype  b   where a.power=b.Pt_ID and a.User_Name='" + Rname + "'";
                    ds = db.GetDataFromSQL(str_sql);
                    TB_Name.Text = Rname;
                    TB_Pwd.Text = ds.Tables[0].Rows[0]["User_Pwd"].ToString().Trim();
                    CB_Type.Text = ds.Tables[0].Rows[0]["Pt_Name"].ToString().Trim();
                    TB_Name.Enabled = false;
                    checkBox1.Visible = true;
                    label3.Visible = false;
                    TB_Pwd.Enabled = false;
                }
            }
            catch { }
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void but_BC_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_Name.Text.Trim() == "" || TB_Pwd.Text.Trim() == "" || CB_Type.Text.Trim() == "")
                {
                    MessageBox.Show("请填写完整");
                }
                else
                {
                    if (Rname == null)
                    {
                        //判断用户名存不存在
                        string sql = "select count(*) from tb_User where User_Name='" + TB_Name.Text.Trim() + "'";
                        int a = db.YZSql(sql);
                        if (a > 0)
                        {
                            MessageBox.Show("此用户名存在");
                        }
                        else
                        {
                            //查询权限编号
                            sql = "select Pt_ID from tb_powertype where Pt_Name='" + CB_Type.Text.Trim() + "'";
                            DataSet ds = db.GetDataFromSQL(sql);
                            int q = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());

                            string str_sql = "insert into tb_User values('" + TB_Name.Text.Trim() + "','" + TB_Pwd.Text.Trim() + "','" + q + "')";
                            if (db.ExecSQl(str_sql))
                            {
                                MessageBox.Show("添加用户成功");
                                TB_Name.Text = "";
                                TB_Pwd.Text = "";
                                CB_Type.SelectedIndex = 0;
                            }
                        }
                    }
                    else
                    {

                        //查询权限编号
                        string str_sql = "select Pt_ID from tb_powertype where Pt_Name='" + CB_Type.Text.Trim() + "'";
                        DataSet ds = db.GetDataFromSQL(str_sql);
                        int q = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());

                        str_sql = "update tb_User set User_Pwd='" + TB_Pwd.Text.Trim() + "',  power='" + q + "' where User_Name='" + Rname + "'";
                        if (db.ExecSQl(str_sql))
                        {
                            MessageBox.Show("修改成功");
                            TB_Name.Text = "";
                            TB_Pwd.Text = "";
                            CB_Type.SelectedIndex = 0;
                            this.Close();
                        }
                    }
                }
            }
            catch { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TB_Pwd.Enabled = true;
            }
            else
            {
                TB_Pwd.Enabled = false;
            }
        }
    }
}
