using Foot.EntityLayers;
using Kebue.Core.Util;
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
    public partial class Frm_JZ : Form
    {
        public Frm_JZ()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 茶楼名称
        /// </summary>
       public static string clmc = string.Empty;
        /// <summary>
        /// 获取桌台名称
        /// </summary>
        public string Rname;
        internal tb_Desk deskResult;
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();

        private void but_HY_Click(object sender, EventArgs e)
        {
            try
            {
                but_HY.Visible = false;    //隐藏会员按钮
                but_PT.Visible = true;    //显示普通按钮
                CB_ID.DropDownStyle = ComboBoxStyle.DropDownList;  //显示下拉框
                CB_ID.Enabled = true;
                CB_ID.Focus();

                //获取会员编号
                CB_ID.Items.Clear();
                string str_sql = "select member_ID from tb_member";
                DataSet ds = db.GetDataFromSQL(str_sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    CB_ID.Items.Add(ds.Tables[0].Rows[i][0].ToString().Trim());
                }
                CB_ID.SelectedIndex = 0;
            }
            catch { }            
        }

        private void but_PT_Click(object sender, EventArgs e)
        {
            fangfa();
            
        }
        /// <summary>
        /// 显示会员按钮
        /// </summary>
        private void fangfa()
        {
            try
            {
                but_PT.Visible = false;    //  隐藏普通按钮
                but_HY.Visible = true;     //显示会员按钮
                CB_ID.DropDownStyle = ComboBoxStyle.Simple;   //隐藏下拉框
                CB_ID.Text = "普通顾客";
                CB_ID.Enabled = false;
                TB_money.Focus();
                LB_Name.Text = "普通顾客";
                LB_JF.Text = "0";
                LB_DJ.Text = "0";
                LB_ZK.Text = "0";
                LB_Ymoney.Text = LB_money.Text;
            }
            catch { }
            //LB_Smoney.Text = LB_money.Text;
            //LB_ZL.Text = "找零：0.00";
        }

        /// <summary>
        /// 服务员
        /// </summary>
        private string fwy = string.Empty;
        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
                bool pd = false;
                if (TB_money.Text.Trim() == "")
                {
                    MessageBox.Show("输入金钱");
                }
                else if (Convert.ToDouble(LB_ZL.Text.Trim().Remove(0, 1)) < 0)
                {
                    MessageBox.Show("您支付的金额不够");
                }
                else
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        //插入消费明细信息
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            string str_sql = "select Goods_type,Beizhu from  tb_goods where goods_Name='" + dataGridView1.Rows[i].Cells[0].Value.ToString().Trim() + "'";
                            DataSet ds = db.GetDataFromSQL(str_sql);
                            str_sql = "insert into  tb_XFMX  values('" + LB_ZDH.Text.Trim() + "','" + dataGridView1.Rows[i].Cells[0].Value.ToString().Trim() + "',"
                                      + "'" + ds.Tables[0].Rows[0][0].ToString().Trim() + "','" + dataGridView1.Rows[i].Cells[1].Value.ToString().Trim() + "',"
                                      + "'" + dataGridView1.Rows[i].Cells[2].Value.ToString().Trim() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString().Trim() + "'"
                                      + ",'" + ds.Tables[0].Rows[0][1].ToString().Trim() + "')";
                            pd = db.ExecSQl(str_sql);
                        }
                        if (LB_Name.Text != "普通顾客")
                        {
                            //插入会员消费信息               
                            string str_sql1 = "insert into tb_memberXF values('" + CB_ID.Text.Trim() + "','" + LB_Name.Text.Trim() + "','" + LB_ZDH.Text.Trim() + "','" + LB_ZTH.Text.Trim() + "',"
                                           + "'" + LB_Smoney.Text.Trim().Remove(0, 1) + "','" + dataGridView1.Rows[0].Cells[4].Value.ToString().Trim().Remove(10) + "','" + TB_BZ.Text.Trim() + "')";
                            pd = db.ExecSQl(str_sql1);

                            //修改会员积分
                            str_sql1 = "update tb_member set Member_JF=convert(int,Member_JF)+'" + Convert.ToInt32(Convert.ToDouble(LB_Smoney.Text.Trim().Remove(0, 1)) / 10) + "' where member_ID='" + CB_ID.Text.Trim() + "'";
                            db.ExecSQl(str_sql1);
                        }
                        //查询服务员
                        DataSet ds1 = db.GetDataFromSQL("select Open_Waiter from tb_Open where Open_Name='" + Rname + "'");
                        fwy = ds1.Tables[0].Rows[0][0].ToString().Trim();

                        //插入消费信息
                        string sql = "insert into tb_XF values('" + LB_ZDH.Text.Trim() + "','" + LB_ZTH.Text.Trim() + "','" + LB_Ymoney.Text.Trim().Remove(0, 1) + "','" + LB_ZK.Text.Trim() + "',"
                                     + "'" + LB_Smoney.Text.Trim().Remove(0, 1) + "','" + dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim().Remove(10) + "','" + fwy + "','" + TB_BZ.Text.Trim() + "')";
                        pd = db.ExecSQl(sql);

                        //删除桌台销售信息
                        pd = db.ExecSQl("delete from tb_DeskXS where XS_DeskName='" + Rname + "'");
                        //删除桌台开台信息
                        pd = db.ExecSQl("delete from tb_Open where Open_Name='" + Rname + "'");
                        //更改桌台状态
                        pd = db.ExecSQl("update tb_Desk set TypeId='脏台' where Id='" + Rname + "'");

                        if (pd)
                        {
                            MessageBox.Show("结账成功");

                            this.Close();
                            this.printPreviewDialog1.Document = this.printDocument1;
                            this.printPreviewDialog1.ShowDialog();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("你还没有消费的！！确认要结账吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                        {
                            //删除桌台开台信息
                            pd = db.ExecSQl("delete from tb_Open where Open_Name='" + Rname + "'");
                            //更改桌台状态
                            pd = db.ExecSQl("update tb_Desk set TypeId='可用' where Id='" + Rname + "'");
                            this.Close();

                        }
                        else
                        {
                            Frm_XF xf = new Frm_XF();
                            xf.ShowDialog();
                        }
                    }
                }
            }
            catch { }
        }

        private void Frm_JZ_Load(object sender, EventArgs e)
        {
            try
            {
                string str_sql = "select XS_goodsName,XS_dj,XS_Sum,XS_allprice,XS_sj from tb_DeskXS where XS_DeskName='" + Rname + "'";
                dataGridView1.DataSource = db.GetDataFromSQL(str_sql).Tables[0];
                //查询此桌台的类型编号
                str_sql = "select a.DT_ZDXF from tb_DeskType a,tb_Desk b where b.Name=a.Id and Id='" + Rname+"'";
                DataSet ds = db.GetDataFromSQL(str_sql);
                double zdxf=0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                     zdxf =Convert.ToDouble( ds.Tables[0].Rows[0][0].ToString().Trim());
                }
                 ds = db.GetDataFromSQL("select sum(convert(float,XS_allprice)) from tb_DeskXS where XS_DeskName='" + Rname + "'");
                 if (ds.Tables[0].Rows[0][0].ToString().Trim() == "")
                 {
                     LB_money.Text = zdxf.ToString("C");
                 }
                 else
                 {
                     if (Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString().Trim()) < zdxf)
                     {
                         LB_money.Text = zdxf.ToString("C");
                     }
                     else
                     {
                         LB_money.Text = Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString().Trim()).ToString("C").Trim();
                     }
                 }
                LB_ZTH.Text = Rname;


                fangfa();

                //获取账单号
                str_sql = "select max(XF_ID) from tb_XF where substring(XF_ID,1,2)='ZD' and substring(XF_ID,3,8)='" + DateTime.Now.ToString("yyyyMMdd").Trim() + "'";
                ds = db.GetDataFromSQL(str_sql);
                string zd = ds.Tables[0].Rows[0][0].ToString().Trim();
                if (zd == "")
                {
                    LB_ZDH.Text = "ZD" + DateTime.Now.ToString("yyyyMMdd") + "001";
                }
                else
                {
                    LB_ZDH.Text = (Convert.ToInt64(zd.Substring(2, 11).ToString().Trim()) + 1).ToString("ZD00000000000").Trim();
                }
                TB_money.Focus();
            }
            catch { }
        }

        private void TB_money_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TB_money.Text.StartsWith("."))
                {
                    TB_money.Text = "0.";
                    TB_money.SelectionStart = 2;
                }
                double a;
                if (TB_money.Text.Trim() == "")
                {
                    a = 0;
                }
                else
                {
                    a = Convert.ToDouble(TB_money.Text.Trim()) - Convert.ToDouble(LB_Smoney.Text.Trim().Remove(0, 1));
                }
                LB_ZL.Text = a.ToString("C");
            }
            catch { }
        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CB_ID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CB_ID_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_ID.Text.Trim() != "普通顾客")
                {
                    string str_sql = "select a.member_Name,a.Member_JF,b.Mt_Name,b.Mt_agio from tb_membertype b,tb_member a  where a.Member_DJ=b.Mt_ID and a.member_ID='" + CB_ID.Text.Trim() + "'";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    //       CB_ID.Text = "普通顾客";
                    LB_Name.Text = ds.Tables[0].Rows[0]["member_Name"].ToString().Trim();
                    LB_JF.Text = ds.Tables[0].Rows[0]["Member_JF"].ToString().Trim();
                    LB_DJ.Text = ds.Tables[0].Rows[0]["Mt_Name"].ToString().Trim();
                    LB_ZK.Text = ds.Tables[0].Rows[0]["Mt_agio"].ToString().Trim();
                    LB_Ymoney.Text = LB_money.Text;
                    LB_Smoney.Text = LB_money.Text;
                    //  LB_ZL.Text = "找零：￥0.00";
                }
            }
            catch { }
        }

        private void LB_ZK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LB_ZK.Text.Trim() != "0")
                {
                    LB_Smoney.Text = (Convert.ToDouble(LB_money.Text.Trim().Remove(0, 1)) * Convert.ToDouble(LB_ZK.Text.Trim())).ToString("C").Trim();
                }
                else
                {
                    LB_Smoney.Text = LB_money.Text.Trim();
                }
            }
            catch { }
        }

        private void TB_money_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar) && e.KeyChar != 46)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
            if (this.TB_money.Text.Contains("."))
            {
                if (e.KeyChar == 46)
                {
                    e.Handled = true;
                }
            }
        }

        private void TB_money_Validating(object sender, CancelEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int wz = 0;

                //string str_sql = "select RoomName,RoomWZ,RoomType,RoomZT,RoomJC,RoomBJF,ID from tb_Room";
                //DataSet ds = db.GetDataFromSQL(str_sql);

                if (dataGridView1.Rows.Count > 0)
                {
                    e.Graphics.DrawString(clmc, new System.Drawing.Font("宋体", 35), Brushes.Black, 300, 10);
                    e.Graphics.DrawString("账单号:", new System.Drawing.Font("宋体", 22), Brushes.Black, 150, 60);
                    e.Graphics.DrawString(LB_ZDH.Text.Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 260, 60);
                    e.Graphics.DrawString("商品名称", new System.Drawing.Font("宋体", 22), Brushes.Black, 130, 100);
                    e.Graphics.DrawString("单价", new System.Drawing.Font("宋体", 22), Brushes.Black, 350, 100);
                    e.Graphics.DrawString("数量", new System.Drawing.Font("宋体", 22), Brushes.Black, 440, 100);
                    e.Graphics.DrawString("总价", new System.Drawing.Font("宋体", 22), Brushes.Black, 530, 100);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString().Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 130, 150 + (50 * i));
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString().Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 350, 150 + (50 * i));
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString().Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 440, 150 + (50 * i));
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString().Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 530, 150 + (50 * i));
                        wz = 150 + (50 * i);
                    }
                    e.Graphics.DrawLine(new Pen(Color.Black), 100, wz + 40, 700, wz + 40);

                    e.Graphics.DrawString("总计:", new System.Drawing.Font("宋体", 22), Brushes.Black, 150, wz + 50);
                    e.Graphics.DrawString(LB_Smoney.Text.Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 240, wz + 50);

                    e.Graphics.DrawString("服务员:", new System.Drawing.Font("宋体", 22), Brushes.Black, 390, wz + 50);
                    e.Graphics.DrawString(fwy, new System.Drawing.Font("宋体", 22), Brushes.Black, 500, wz + 50);

                    e.Graphics.DrawString("收费时间:", new System.Drawing.Font("宋体", 22), Brushes.Black, 150, wz + 100);
                    e.Graphics.DrawString(DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss).Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 300, wz + 100);
                }
            }
            catch { }
        }






    }
}
