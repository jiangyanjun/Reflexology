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
    public partial class Frm_member : Form
    {
        public Frm_member()
        {
            InitializeComponent();
        }

        private void Frm_member_Load(object sender, EventArgs e)
        {
            try
            {//添加会员基本信息控件
                Frm_memberInfo frmmemberinfo = new Frm_memberInfo();
                tabPage1.Controls.Add(frmmemberinfo);
                //添加会员消费信息控件
                Frm_memberXF frmmemberxf = new Frm_memberXF();
                tabPage2.Controls.Add(frmmemberxf);
            }
            catch { }
        }
    }
}
