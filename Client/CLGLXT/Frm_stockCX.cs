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
    public partial class Frm_stockCX : Form
    {
        public Frm_stockCX()
        {
            InitializeComponent();
        }
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();

        private void DGV_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_info.SelectedRows.Count == 1)
                {
                    LV_info.Items.Clear();
                    string bh = DGV_info.SelectedRows[0].Cells["Column1"].Value.ToString().Trim();
                    DataSet ds = db.GetDataFromSQL("select * from tb_goodsMX where  MX_CGID='" + bh + "'");
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem lv = new ListViewItem(ds.Tables[0].Rows[i]["Goods_type"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["MX_name"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["MX_price"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["MX_num"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["MX_allprice"].ToString().Trim());
                        lv.SubItems.Add(ds.Tables[0].Rows[i]["MX_beizhu"].ToString().Trim());
                        LV_info.Items.Add(lv);
                    }
                }
            }
            catch { }
        }

        private void Frm_stockCX_Load(object sender, EventArgs e)
        {
            try
            {
                string str_sql = "select * from tb_goodsCG";
                DataSet ds = db.GetDataFromSQL(str_sql);
                DGV_info.DataSource = ds.Tables[0];
            }
            catch { }
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (DTP_Kssj.Text.Trim() != "" && DTP_close.Text.Trim() != "")
                {
                    string str_sql = "select * from tb_goodsCG where CG_sj  between '" + DTP_Kssj.Text.Trim() + "' and '" + DTP_close.Text.Trim() + "'";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    DGV_info.DataSource = ds.Tables[0];
                }
            }
            catch { }
        }
    }
}
