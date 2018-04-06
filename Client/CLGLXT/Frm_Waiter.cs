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
    public partial class Frm_Waiter : Form
    {
        public Frm_Waiter()
        {
            InitializeComponent();
        }
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();

        private void DGV_Waiter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            but_xiugai_Click(sender,e);
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            Frm_WaiterXG xg = new Frm_WaiterXG();
            xg.ShowDialog();
        }

        private void but_xiugai_Click(object sender, EventArgs e)
        {
            try
            {
                //判断是否选择了一行
                if (DGV_info.SelectedRows.Count == 1)
                {
                    Frm_WaiterXG xg = new Frm_WaiterXG();
                    xg.ID = DGV_info.SelectedRows[0].Cells["Column1"].Value.ToString().Trim();
                    xg.ShowDialog();
                }
                else
                {
                    MessageBox.Show("请选择要修改的员工信息");
                }
            }
            catch { }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_info.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("你确认要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        string str_sql = "delete from tb_Waiter where Waiter_ID='" + DGV_info.SelectedRows[0].Cells["Column1"].Value.ToString().Trim() + "'";
                        if (db.ExecSQl(str_sql))
                        {
                            MessageBox.Show("删除成功"); 
                            but_xianshi_Click(sender, e);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择要删除的员工信息"); 
                }
            }
            catch { }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            but_add_Click(sender ,e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (DGV_info.SelectedRows.Count == 1)
            {
                but_xiugai_Click(sender, e);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (DGV_info.SelectedRows.Count == 1)
            {
                but_Del_Click(sender, e);
            }
        }



        private void CB_zhiwu_TextChanged(object sender, EventArgs e)
        {
            chaxun();
        }

        private void chaxun()
        {
            try
            {
                string str_sql = "select a.Waiter_ID,a.Waiter_Nmae,a.Waiter_Sex,a.Waiter_Age,b.Duty_Name,a.Waiter_Phone,a.Waiter_birthday,a.Waiter_IDCard,a.Waiter_Address,a.Beizhu   from tb_Waiter as a,tb_duty as b where Waiter_duty=Duty_ID";
                if (TB_Name.Text.Trim() != "")
                {
                    str_sql += " and Waiter_Nmae like '%" + TB_Name.Text.Trim() + "%'";
                }
                if (CB_zhiwu.Text.Trim() != "")
                {
                    // 查询职务编号
                    string zw = "select Duty_ID from tb_duty where Duty_Name='" + CB_zhiwu.Text.Trim() + "'";
                    DataSet ds1 = db.GetDataFromSQL(zw);
                    int zwid = Convert.ToInt32(ds1.Tables[0].Rows[0][0].ToString().Trim());

                    str_sql += " and Waiter_duty='" + zwid + "'";
                }
                if (CB_ID.Text.Trim() != "")
                {
                    str_sql += " and Waiter_ID like '%" + CB_ID.Text.Trim() + "%'";
                }

                DataSet ds = db.GetDataFromSQL(str_sql);
                DGV_info.DataSource = ds.Tables[0];
            }
            catch { }
        }

        private void but_xianshi_Click(object sender, EventArgs e)
        {
            try
            {
                string str_sql = "select a.Waiter_ID,a.Waiter_Nmae,a.Waiter_Sex,a.Waiter_Age,b.Duty_Name,a.Waiter_Phone,a.Waiter_birthday,a.Waiter_IDCard,a.Waiter_Address,a.Beizhu   from tb_Waiter as a,tb_duty as b where Waiter_duty=Duty_ID";
                DataSet ds = db.GetDataFromSQL(str_sql);
                DGV_info.DataSource = ds.Tables[0];

                CB_zhiwu.Text = "";
                TB_Name.Text = "";
                CB_ID.Text = "";
                CB_ID.Focus();
            }
            catch { }
        }

        private void TB_Name_TextChanged(object sender, EventArgs e)
        {
            chaxun();
        }

        private void CB_ID_TextChanged(object sender, EventArgs e)
        {
            chaxun();
        }

        private void Frm_Waiter_Load(object sender, EventArgs e)
        {
            try
            {
                string str_sql = "select a.Waiter_ID,a.Waiter_Nmae,a.Waiter_Sex,a.Waiter_Age,b.Duty_Name,a.Waiter_Phone,a.Waiter_birthday,a.Waiter_IDCard,a.Waiter_Address,a.Beizhu   from tb_Waiter as a,tb_duty as b where Waiter_duty=Duty_ID";
                DataSet ds = db.GetDataFromSQL(str_sql);
                DGV_info.DataSource = ds.Tables[0];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    CB_ID.Items.Add(ds.Tables[0].Rows[i]["Waiter_ID"].ToString().Trim());
                }

                // 查询员工职务名称

                string zw = "select Duty_Name from tb_duty";
                ds = db.GetDataFromSQL(zw);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    CB_zhiwu.Items.Add(ds.Tables[0].Rows[i]["Duty_Name"].ToString().Trim());
                }

                CB_ID.Focus ();
            }
            catch { }

        }

        private void DGV_info_MouseDown(object sender, MouseEventArgs e)
        {
            //if (DGV_info.SelectedRows[0].Cells[0].Value.ToString().Trim() != "")
            //{
            //    toolStripMenuItem1.Enabled = true;
            //    toolStripMenuItem2.Enabled = true;
            //    toolStripMenuItem3.Enabled = true;
            //}
            //else
            //{
            //    toolStripMenuItem1.Enabled = true;
            //    toolStripMenuItem2.Enabled = false;
            //    toolStripMenuItem3.Enabled = false;
            //}
        }

        private void Frm_Waiter_Activated(object sender, EventArgs e)
        {
            but_xianshi_Click(sender,e);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
