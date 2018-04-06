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
    public partial class Frm_Pwd : Form
    {
        public Frm_Pwd()
        {
            InitializeComponent();
        }
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        /// <summary>
        /// 用户名
        /// </summary>
        public string RName;
        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_Pwd1.Text.Trim() == "")
                {
                    MessageBox.Show("请输入新密码");
                }
                else if (TB_Pwd2.Text.Trim() == "")
                {
                    MessageBox.Show("请输入确认密码");
                }
                else if (TB_Pwd2.Text.Trim() == TB_Pwd1.Text.Trim())
                {
                    string str_sql = "update set ='" + TB_Pwd1.Text.Trim() + "' where ='" + RName + "'";
                    if (db.ExecSQl(str_sql))
                    {
                        MessageBox.Show("修改密码成功");
                    }
                }
            }
            catch { }
        }

        private void Frm_Pwd_Load(object sender, EventArgs e)
        {

        }
    }
}
