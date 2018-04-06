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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DAL.DBConnection db = new DAL.DBConnection();
        private void Form1_Load(object sender, EventArgs e)
        {
            //str_sql = "select a.ID,b.Name,a.Puw,a.gongzileixing,a.Gongzi,a.Remark from TB_gongzi a,TB_yuangong b where a.NameID=b.ID";
            //DataSet ds = db.GetDataFromSqL(str_sql);
            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void chaxun()
        {
            string str_sql = "";
            if (CB_CX.Text.Trim() != "")
            { }
            if (TB_tj.Text.Trim() != "")
            { }

        }
    }
}
