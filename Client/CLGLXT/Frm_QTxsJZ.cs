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
    public partial class Frm_QTxsJZ : Form
    {
        public Frm_QTxsJZ()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 茶楼名称
        /// </summary>
        public static string clmc = string.Empty;
        /// <summary>
        /// 获取账单号
        /// </summary>
        public string ID;
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        private void Frm_QTxsJZ_Load(object sender, EventArgs e)
        {
            try
            {
                LB_ZDH.Text = ID;
                string str_sql = "select sum(QT_Allprice) from tb_qtxs where QT_ID='" + ID + "'";
                LB_money.Text = Convert.ToDouble(db.GetDataFromSQL(str_sql).Tables[0].Rows[0][0].ToString().Trim()).ToString("C").Trim();

                fangfa();
            }
            catch { }
        }

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
            //string str_sql = "select a.member_Name,a.Member_JF,b.Mt_Name,b.Mt_agio from tb_membertype b,tb_member a  where a.Member_DJ=b.Mt_ID";
            //DataSet ds = db.GetDataFromSQL(str_sql);
            ////CB_ID.Text = "普通顾客";
            //LB_Name.Text = ds.Tables[0].Rows[0]["member_Name"].ToString().Trim();
            //LB_JF.Text = ds.Tables[0].Rows[0]["Member_JF"].ToString().Trim();
            //LB_DJ.Text = ds.Tables[0].Rows[0]["Mt_Name"].ToString().Trim();
            //  LB_ZK.Text = ds.Tables[0].Rows[0]["Mt_agio"].ToString().Trim();
            //LB_Ymoney.Text = LB_money.Text;
            //LB_Smoney.Text = LB_money.Text;
            //LB_ZL.Text = "0.00";

        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            //结账后把前台销售表中的ID数据删除
            db.ExecSQl("delete from tb_qtxs where QT_ID='" + ID + "'");

            Frm_QTXS.flag = false;
            this.Close();
        }
        private void fangfa()
        {
            try
            {
                TB_money.Focus();
                but_PT.Visible = false;    //  隐藏普通按钮
                but_HY.Visible = true;     //显示会员按钮
                CB_ID.DropDownStyle = ComboBoxStyle.Simple;   //隐藏下拉框
                CB_ID.Enabled = false;

                CB_ID.Text = "普通顾客";
                LB_Name.Text = "普通顾客";
                LB_JF.Text = "0";
                LB_DJ.Text = "0";
                LB_ZK.Text = "0";
                LB_Ymoney.Text = LB_money.Text;
            }
            catch { }
            //LB_Smoney.Text = LB_money.Text;
            //LB_ZL.Text = "0.00";
        }

        private void CB_ID_TextChanged(object sender, EventArgs e)
        {
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
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
                    if (LB_Name.Text != "普通顾客")
                    {
                        //插入会员消费信息
                        string str_sql1 = "insert into tb_memberXF values('" + CB_ID.Text.Trim() + "','" + LB_Name.Text.Trim() + "','" + LB_ZDH.Text.Trim() + "','前台销售','" + LB_Smoney.Text.Trim().Remove(0, 1) + "','" + DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss) + "','无')";
                        db.ExecSQl(str_sql1);
                        //增加会员积分
                        str_sql1 = "update tb_member set Member_JF=convert(int,Member_JF)+'" + Convert.ToInt32(Convert.ToDouble(LB_Smoney.Text.Trim().Remove(0, 1)) / 10) + "' where member_ID='" + CB_ID.Text.Trim() + "'";
                        db.ExecSQl(str_sql1);
                    }
                    //插入消费记录
                    string sql = "insert into tb_XF values('" + LB_ZDH.Text.Trim() + "','前台销售','" + LB_Ymoney.Text.Trim().Remove(0, 1) + "','" + LB_ZK.Text.Trim() + "','" + LB_Smoney.Text.Trim().Remove(0, 1) + "','" + DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss) + "','前台销售','无')";
                    db.ExecSQl(sql);

                    //插入消费详细信息
                    sql = "insert into tb_XFMX select * from tb_qtxs where  QT_ID='" + LB_ZDH.Text.Trim() + "'";
                    db.ExecSQl(sql);

                    //结账后把前台销售表中的ID数据删除
                    db.ExecSQl("delete from tb_qtxs where QT_ID='" + ID + "'");

                    //添加成功 返回 true
                    Frm_QTXS.flag = true;

                    this.Close();

                    this.printPreviewDialog1.Document = this.printDocument1;
                    this.printPreviewDialog1.ShowDialog();


                }
            }
            catch { }
        }

        private void but_PT_Click(object sender, EventArgs e)
        {
            fangfa();

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
                LB_ZL.Text = a.ToString("C").Trim();
            }
            catch { }
        }

        private void TB_money_Validating(object sender, CancelEventArgs e)
        {

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

        private void CB_ID_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_ID.Text.Trim() != "普通顾客")
                {
                    string str_sql = "select a.member_Name,a.Member_JF,b.Mt_Name,b.Mt_agio from tb_membertype b,tb_member a  where a.Member_DJ=b.Mt_ID and a.member_ID='" + CB_ID.Text.Trim() + "'";
                    DataSet ds = db.GetDataFromSQL(str_sql);
                    LB_Name.Text = ds.Tables[0].Rows[0]["member_Name"].ToString().Trim();
                    LB_JF.Text = ds.Tables[0].Rows[0]["Member_JF"].ToString().Trim();
                    LB_DJ.Text = ds.Tables[0].Rows[0]["Mt_Name"].ToString().Trim();
                    LB_ZK.Text = ds.Tables[0].Rows[0]["Mt_agio"].ToString().Trim();
                    LB_Ymoney.Text = LB_money.Text;

                }
            }
            catch { }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int wz = 0;

                string str_sql = "select MX_Goods,MX_dj,MX_Num,MX_Allprice from tb_XFMX where MX_XFID='" + LB_ZDH.Text.Trim() + "'";
                DataSet ds = db.GetDataFromSQL(str_sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    e.Graphics.DrawString(clmc, new System.Drawing.Font("宋体", 35), Brushes.Black, 300, 10);
                    e.Graphics.DrawString("账单号:", new System.Drawing.Font("宋体", 22), Brushes.Black, 150, 60);
                    e.Graphics.DrawString(LB_ZDH.Text.Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 260, 60);
                    e.Graphics.DrawString("商品名称", new System.Drawing.Font("宋体", 22), Brushes.Black, 130, 100);
                    e.Graphics.DrawString("单价", new System.Drawing.Font("宋体", 22), Brushes.Black, 350, 100);
                    e.Graphics.DrawString("数量", new System.Drawing.Font("宋体", 22), Brushes.Black, 440, 100);
                    e.Graphics.DrawString("总价", new System.Drawing.Font("宋体", 22), Brushes.Black, 530, 100);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        e.Graphics.DrawString(ds.Tables[0].Rows[i]["MX_Goods"].ToString().Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 130, 150 + (50 * i));
                        e.Graphics.DrawString(ds.Tables[0].Rows[i]["MX_dj"].ToString().Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 350, 150 + (50 * i));
                        e.Graphics.DrawString(ds.Tables[0].Rows[i]["MX_Num"].ToString().Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 440, 150 + (50 * i));
                        e.Graphics.DrawString(ds.Tables[0].Rows[i]["MX_Allprice"].ToString().Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 530, 150 + (50 * i));
                        wz = 150 + (50 * i);
                    }
                    e.Graphics.DrawLine(new Pen(Color.Black), 100, wz + 40, 700, wz + 40);
                    e.Graphics.DrawString("总计:", new System.Drawing.Font("宋体", 22), Brushes.Black, 150, wz + 50);
                    e.Graphics.DrawString(LB_Smoney.Text.Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 240, wz + 50);

                    e.Graphics.DrawString("服务员:", new System.Drawing.Font("宋体", 22), Brushes.Black, 390, wz + 50);
                    e.Graphics.DrawString("1", new System.Drawing.Font("宋体", 22), Brushes.Black, 500, wz + 50);

                    e.Graphics.DrawString("收费时间:", new System.Drawing.Font("宋体", 22), Brushes.Black, 150, wz + 100);
                    e.Graphics.DrawString(DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss).Trim(), new System.Drawing.Font("宋体", 22), Brushes.Black, 300, wz + 100);


                }
            }
            catch { }

        }
    }
}
