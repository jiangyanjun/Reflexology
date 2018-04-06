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
    public partial class Frm_taking : Form
    {
        public Frm_taking()
        {
            InitializeComponent();
        }

        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        private void Frm_taking_Load(object sender, EventArgs e)
        {
            try
            {
                string str_sql = "select * from tb_XF";
                DGV_info.DataSource = db.GetDataFromSQL(str_sql).Tables[0];
                //总收入
                //string je = "0";
                str_sql = "select sum(convert(float,XF_Smoney)) from tb_XF";
                //for (int i = 0; i < DGV_info.SelectedRows.Count; i++)
                //{
                //   je =(Convert.ToDouble(je)+Convert.ToDouble( DGV_info.SelectedRows[i].Cells[4].Value.ToString().Trim())).ToString().Trim();
                //}
                lb_money.Text = db.GetDataFromSQL(str_sql).Tables[0].Rows[0][0].ToString().Trim();
            }
            catch { }
        }

        private void but_XS_Click(object sender, EventArgs e)
        {
            try
            {
                if (DTP_Kssj.Text.Trim() == "" || DTP_close.Text.Trim() == "")
                { }
                else
                {
                    string str_sql = "select * from tb_XF where XF_sj between '" + DTP_Kssj.Text.Trim() + "' and '" + DTP_close.Text.Trim() + "'";
                    DGV_info.DataSource = db.GetDataFromSQL(str_sql).Tables[0];
                    //总收入
                    str_sql = "select sum(convert(float,XF_Smoney)) from tb_XF where XF_sj between '" + DTP_Kssj.Text.Trim() + "' and '" + DTP_close.Text.Trim() + "'";
                    //string je = "";
                    //for (int i = 0; i < DGV_info.SelectedRows.Count; i++)
                    //{
                    //    je = (Convert.ToDouble(je) + Convert.ToDouble(DGV_info.SelectedRows[i].Cells[4].Value.ToString().Trim())).ToString().Trim();
                    //}
                    lb_money.Text = db.GetDataFromSQL(str_sql).Tables[0].Rows[0][0].ToString().Trim();
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
                    LV_info.Items.Clear();
                    string zd = DGV_info.SelectedRows[0].Cells[0].Value.ToString().Trim();
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
    }
}
