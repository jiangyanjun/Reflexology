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
    public partial class Frm_XTSZ : Form
    {
        public Frm_XTSZ()
        {
            InitializeComponent();
        }

        private void Frm_XTSZ_Load(object sender, EventArgs e)
        {
            try
            {
                Frm_Waitertype yg = new Frm_Waitertype();
                tabPage1.Controls.Add(yg);

                Frm_Hytype hy = new Frm_Hytype();
                tabPage2.Controls.Add(hy);

                Frm_Cktype ck = new Frm_Cktype();
                tabPage3.Controls.Add(ck);

                Frm_Zttype ct = new Frm_Zttype();
                tabPage4.Controls.Add(ct);

                Frm_YHtype yh = new Frm_YHtype();
                tabPage5.Controls.Add(yh);
            }
            catch { }
        }

        private void Frm_XTSZ_Activated(object sender, EventArgs e)
        {
            Frm_XTSZ_Load(sender,e);
        }
    }
}
