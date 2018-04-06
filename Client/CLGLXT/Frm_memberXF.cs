using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Foot.Client
{
    public partial class Frm_memberXF : UserControl
    {
        public Frm_memberXF()
        {
            InitializeComponent();
        }

        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        private void but_cx_Click(object sender, EventArgs e)
        {
            try
            {
                DGV_info.DataSource = db.GetDataFromSQL("select * from tb_memberXF").Tables[0];
                CB_ID.Text = "";
                CB_Name.Text = "";
                //计算消费金额
                string str_sqlt = "select sum(YH_money) from tb_memberXF";
                DataSet ds = db.GetDataFromSQL(str_sqlt);
                if (ds.Tables[0].Rows[0][0].ToString().Trim() != "")
                {
                    toolStripStatusLabel3.Text = Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString().Trim()).ToString("C").Trim(); ;
                }
            }
            catch { }
        }

        private void DGV_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_info.SelectedRows.Count == 1)
                {

                    //获取账单号
                    LV_info.Items.Clear();
                    string zd = DGV_info.SelectedRows[0].Cells[2].Value.ToString().Trim();
                    string str_sql = "select * from tb_XFMX where MX_XFID='" + zd + "'";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i][2].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i][1].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i][3].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i][4].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i][5].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i][6].ToString().Trim());
                        LV_info.Items.Add(lv);
                    }

                }
            }
            catch { }
        }
        /// <summary>
        /// 查询会员消费情况
        /// </summary>
        private void chaxun()
        {
            try
            {
                string str_sqlt = "select sum(YH_money) from tb_memberXF where 1=1";
                string str_sql = "select * from tb_memberXF where 1=1";
                if (CB_ID.Text.Trim() != "")
                {
                    str_sql += " and HY_ID='" + CB_ID.Text.Trim() + "'";
                    str_sqlt += " and HY_ID='" + CB_ID.Text.Trim() + "'";
                }
                if (CB_Name.Text.Trim() != "")
                {
                    str_sql += "and HY_Name='" + CB_Name.Text.Trim() + "'";
                    str_sqlt += "and HY_Name='" + CB_Name.Text.Trim() + "'";
                }
                //计算消费金额
                DGV_info.DataSource = db.GetDataFromSQL(str_sql).Tables[0];
                DataSet ds = db.GetDataFromSQL(str_sqlt);
                if (ds.Tables[0].Rows[0][0].ToString().Trim() != "")
                {
                    toolStripStatusLabel3.Text = Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString().Trim()).ToString("C").Trim(); ;
                }
            }
            catch { }
        }

        private void CB_ID_TextChanged(object sender, EventArgs e)
        {
            chaxun();
        }

        private void CB_Name_TextChanged(object sender, EventArgs e)
        {
            chaxun();
        }

        private void Frm_memberXF_Load(object sender, EventArgs e)
        {
            try
            {
                string str_sql = "select member_ID,member_Name from tb_member";
                DataSet ds = db.GetDataFromSQL(str_sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    CB_ID.Items.Add(ds.Tables[0].Rows[i]["member_ID"].ToString().Trim());
                    CB_Name.Items.Add(ds.Tables[0].Rows[i]["member_Name"].ToString().Trim());
                }
                but_cx_Click(sender, e);
            }
            catch { }
        }

    }
}
