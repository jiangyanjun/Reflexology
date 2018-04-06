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
    public partial class Frm_Power : Form
    {
        public Frm_Power()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取权限名称
        /// </summary>
        public string RName;

        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();


        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            RName = null;
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
                bool c = false;
                //判断是添加还是修改
                if (RName == null)
                {
                    if (TB_Name.Text != "")
                    {
                        //判断权限名称是否存在
                        string sql = "select count(*) from tb_powertype where Pt_Name='" + TB_Name.Text.Trim() + "'";
                        int a = db.YZSql(sql);
                        if (a > 0)
                        {
                            MessageBox.Show("此权限名称存在");
                        }
                        else
                        {
                            string str_sql = "insert into tb_powertype values('" + TB_Name.Text.Trim() + "')";
                            db.ExecSQl(str_sql);
                            str_sql = "select Pt_ID from tb_powertype where Pt_Name='" + TB_Name.Text.Trim() + "'";
                            DataSet ds = db.GetDataFromSQL(str_sql);
                            int b = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());
                            //判断是否选中
                            int m;
                            //获取名称
                            string n;
                            for (int i = 0; i < treeView1.Nodes.Count; i++)
                            {

                                if (treeView1.Nodes[i].Checked == true)
                                {
                                    //选择返回0
                                    m = 0;
                                    n = treeView1.Nodes[i].Text;
                                }
                                else
                                {

                                    m = 1;
                                    n = treeView1.Nodes[i].Text;
                                }
                                str_sql = "insert into tb_power values('" + b + "','" + n + "','" + m + "') ";
                                c = db.ExecSQl(str_sql);
                            }
                            if (c)
                            {
                                MessageBox.Show("成功");
                                this.Close();

                                TB_Name.Text = "";
                                for (int i = 0; i < treeView1.Nodes.Count; i++)
                                {

                                    treeView1.Nodes[i].Checked = false;
                                }
                            }
                        }
                    }

                }
                else
                {
                    //获取权限类型编号
                    string str_sql = "select Pt_ID from tb_powertype where Pt_Name='" + TB_Name.Text.Trim() + "'";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    int b = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());
                    //判断是否选中
                    int m;
                    //获取名称
                    string n;
                    for (int i = 0; i < treeView1.Nodes.Count; i++)
                    {
                        if (treeView1.Nodes[i].Checked == true)
                        {
                            m = 0;
                            n = treeView1.Nodes[i].Text;
                        }
                        else
                        {

                            m = 1;
                            n = treeView1.Nodes[i].Text;
                        }
                        str_sql = "update tb_power set pope='" + m + "' where power_Name='" + n + "' and power_type='" + b + "'";
                        c = db.ExecSQl(str_sql);
                    }
                    if (c)
                    {
                        MessageBox.Show("修改成功");
                        this.Close();
                    }
                }
            }
            catch { }
        }

        private void Frm_Power_Load(object sender, EventArgs e)
        {
            try
            {
                if (RName == null)
                {
                    this.Text = "添加权限";
                    label1.Text = "新增权限名";
                }
                else
                {
                    this.Text = "修改权限";
                    label1.Text = "修改权限名";

                    TB_Name.Text = RName;
                    TB_Name.Enabled = false;

                    //获取权限类型编号
                    string str_sql = "select Pt_ID from tb_powertype where Pt_Name='" + RName + "'";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    int b = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString().Trim());
                    //获取名称
                    string n;
                    for (int i = 0; i < treeView1.Nodes.Count; i++)
                    {
                        n = treeView1.Nodes[i].Text;
                        str_sql = "select * from tb_power where power_type='" + b + "' and power_Name='" + n + "'";
                        ds = db.GetDataFromSQL(str_sql);
                        string a = ds.Tables[0].Rows[0]["pope"].ToString().Trim();
                        if (a == "0")
                        {
                            treeView1.Nodes[i].Checked = true;

                        }
                        else
                        {
                            treeView1.Nodes[i].Checked = false;
                        }
                    }

                }
            }
            catch { }

        }

        private void Frm_Power_FormClosing(object sender, FormClosingEventArgs e)
        {
            RName = null;
        }
    }
}
