using Foot.EntityLayers;
using Foot.Proxy;
using Kebue.Core.Util;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Foot.Client
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "MSN.ssk";
        }
        public static bool pd = false;
        private void TB_Pwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                but_Login_Click(sender, e);
            }
        }
        private void but_Login_Click(object sender, EventArgs e)
        {
            try
            {
                but_Login.Enabled = false;
                Msg.RunInBackground(
                  delegate (object obj, DoWorkEventArgs ce)
                  {
                      if (TB_name.Text.Trim() == "")
                      {
                          string msg = "用户名不能为空";
                          errorProvider1.SetError(TB_name, msg);
                          Msg.ShowErrorMsg(msg);
                          TB_name.Focus();
                          return;
                      }
                      else if (TB_Pwd.Text.Trim() == "")
                      {
                          string msg = "密码不能为空";
                          errorProvider1.SetError(TB_Pwd, msg);
                          Msg.ShowErrorMsg(msg);
                          TB_Pwd.Focus();
                          return;
                      }
                      ClientServicesProxy proxys = new ClientServicesProxy();
                      tb_User p = new tb_User { User_Name = TB_name.Text.Trim(), User_Pwd = TB_Pwd.Text.Trim() };
                      ce.Result = proxys.Find(p).FirstOrDefault();
                  },
                  delegate (object obj, RunWorkerCompletedEventArgs rce)
                  {
                      var result = rce.Result as tb_User;
                      if (result.IsNotNull() && result.User_Name.IsNotNull() && result.User_Pwd.IsNotNull() && result.User_Name.IsEquals(TB_name.Text.Trim()) && result.User_Pwd.IsEquals(TB_Pwd.Text.Trim()))
                      {
                          App.CertificationUser = result;
                          Frm_Main main = new Frm_Main();
                          Frm_SDXT.pass = TB_Pwd.Text.Trim();
                          main.Show();
                          this.Hide();
                      }
                      else
                      {
                          string msg = "用户名或密码错误";
                          errorProvider1.SetError(TB_Pwd, msg);
                          Msg.ShowErrorMsg(msg);
                          TB_Pwd.Focus();
                          TB_name.Focus();
                      }
                  });
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
            finally
            {
                but_Login.Enabled = true;
            }
        }
        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!pd && Msg.ShowConfirmMsg("你确定要退出吗?") != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Frm_login.pd = true;
                System.Environment.Exit(0);
            }
        }
    }
}
