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
    public partial class Frm_SDXT : Form
    {
        public Frm_SDXT()
        {
            InitializeComponent();
        }

        public static string pass;
        private void but_OK_Click(object sender, EventArgs e)
        {
            if (TB_pwd.Text.Trim() == pass)
            {
                //MessageBox.Show("解锁成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误");
            }
        }
    }
}
