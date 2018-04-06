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
    public partial class Frm_BFFH : Form
    {
        public Frm_BFFH()
        {
            InitializeComponent();
        }
        DAL.DBConnection db = new DAL.DBConnection();
        private void but_HF_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string str = "use master restore database db_MrCy from Disk='" + openFileDialog1.FileName + "' with replace ";
                    db.ExecSQl(str);
                    if (MessageBox.Show("恢复成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void but_BF_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    string strg = saveFileDialog1.FileName;

                    string sqltxt = @"BACKUP DATABASE db_MrCy TO Disk='" + strg + ".bak'";

                    bool flag = db.ExecSQl(sqltxt);
                    if (MessageBox.Show("备份成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }
    }
}
