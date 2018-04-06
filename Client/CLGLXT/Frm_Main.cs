using Foot.EntityLayers;
using Foot.Proxy;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foot.Client
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "MSN.ssk";
            RefreshsAction = Refreshs;
        }
        /// <summary>
        /// 判断退出
        /// </summary>
        public bool pd = false;
        /// <summary>
        /// 获取当前用户名
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            //jiazai();
            //显示当前用户
            toolStripStatusLabel3.Text = App.CertificationUser.User_Name;
            //调用用户权限方法
            PermissionInitialization();
            ClientServicesProxy proxys = new ClientServicesProxy();
            tb_XFMX p = new tb_XFMX { Beizhu = "GetHotProducts" };
            GetHotProducts = proxys.Find(p);
            lv_info.Items.Clear();
            panel11.Visible = false;
            toolStripButton18.Visible = false;
            Frm_JZ.clmc = this.Text.Trim().Remove(this.Text.Length - 4);
            Frm_QTxsJZ.clmc = this.Text.Trim().Remove(this.Text.Length - 4);
        }
        /// <summary>
        /// 根据当前用户判断权限
        /// </summary>
        private void PermissionInitialization()
        {
            Msg.RunInBackground(
              delegate (object obj, DoWorkEventArgs ce)
              {
                  ClientServicesProxy proxys = new ClientServicesProxy();
                  ce.Result = proxys.Find(new tb_power { power_type = App.CertificationUser.power });
              },
              delegate (object obj, RunWorkerCompletedEventArgs rce)
              {
                  var powerInfoResult = rce.Result as List<tb_power>;
                  if (powerInfoResult.IsNotNull())
                  {
                      var item = powerInfoResult.FirstOrDefault();
                      if (item.power_Name.IsEquals("顾客开单"))
                      {
                          顾客开单ToolStripMenuItem.Enabled = true;
                          //右键
                          顾客开单ToolStripMenuItem1.Enabled = true;
                      }
                      else if (item.power_Name.IsEquals("顾客点菜"))
                      {
                          顾客点菜ToolStripMenuItem.Enabled = true;
                          //右键
                          顾客点菜ToolStripMenuItem1.Enabled = true;
                      }
                      else if (item.power_Name.IsEquals("顾客结账"))
                      {
                          顾客结账ToolStripMenuItem.Enabled = true;
                          //右键
                          顾客点菜ToolStripMenuItem1.Enabled = true;
                      }
                      else if (item.power_Name.IsEquals("前台销售"))
                      {
                          前台销售ToolStripMenuItem.Enabled = true;
                      }
                      else if (item.power_Name.IsEquals("预定管理"))
                      {
                          预定管理ToolStripMenuItem.Enabled = true;
                      }
                      else if (item.power_Name.IsEquals("营业查询"))
                      {
                          营业查询ToolStripMenuItem.Enabled = true;
                      }
                      else if (item.power_Name.IsEquals("员工管理"))
                      {
                          员工管理ToolStripMenuItem.Enabled = true;
                      }
                      else if (item.power_Name.IsEquals("商品管理"))
                      {
                          tsmProductManagement.Enabled = true;
                      }
                      else if (item.power_Name.IsEquals("会员管理"))
                      {
                          会员管理ToolStripMenuItem.Enabled = true;
                      }
                      else if (item.power_Name.IsEquals("重新登录"))
                      {
                          重新登录ToolStripMenuItem.Enabled = true;
                      }
                      else if (item.power_Name.IsEquals("系统设置"))
                      {
                          系统设置ToolStripMenuItem.Enabled = true;
                      }
                      else if (item.power_Name.IsEquals("数据备份/恢复"))
                      {
                          数据备份恢复ToolStripMenuItem.Enabled = true;
                      }
                  }
              });
        }
        /// <summary>
        /// 根据桌台使用情况，来插入不同的图片
        /// </summary>
        /// <param name="rzt">表示桌台号</param>
        /// <param name="sy">表示桌台使用情况</param>
        private void AddItems(string key, string value, string DeskStatus)
        {
            var em = StaticStr.GetStatusEnum(DeskStatus);
            lv_desk.Items.Add(key, value, em.GetHashCode() - 3);
        }
        void TypeValidation(string typeName)
        {
            try
            {
                if (lv_desk.SelectedItems.Count == 1)
                {
                    ClientServicesProxy proxys = new ClientServicesProxy();
                    tb_Desk deskInfoResult = proxys.Find(new tb_Desk { Id = lv_desk.SelectedItems[0].SubItems[0].Name.Trim() }).FirstOrDefault();
                    if (deskInfoResult.IsNotNull())
                    {
                        if (deskInfoResult.DeskStatus.IsEquals(StatusEnum.Using))
                        {
                            MessageBox.Show(string.Format("此桌台{0}!无法开台", StatusEnum.Using.ToEnumDescription()));
                        }
                        else if (deskInfoResult.DeskStatus.IsEquals(StatusEnum.Malfunction))
                        {
                            MessageBox.Show(string.Format("此桌台{0}!无法开台", StatusEnum.Malfunction.ToEnumDescription()));
                        }
                        else if (deskInfoResult.DeskStatus.IsEquals(StatusEnum.Clean))
                        {
                            MessageBox.Show(string.Format("此桌台{0}!无法开台", StatusEnum.Clean.ToEnumDescription()));
                        }
                        else
                        {
                            if (typeName.IsEquals("顾客开单"))
                            {
                                ///查询桌台类型
                                FrmOrder frmopen = new FrmOrder();
                                //frmopen = lv_desk.SelectedItems[0].SubItems[0].Name.Trim();
                                //deskInfoResult.TypeId = "GetDTType";
                                //deskInfoResult = proxys.Find(deskInfoResult).FirstOrDefault();
                                //frmopen.type = deskInfoResult.TypeId;
                                frmopen.ShowDialog();
                            }
                            else if (typeName.IsEquals("顾客点菜"))
                            {
                                if (frmxf == null || frmxf.IsDisposed)
                                {
                                    frmxf = new Frm_XF();
                                    frmxf.Rname = lv_desk.SelectedItems[0].SubItems[0].Name.Trim();
                                    frmxf.ShowDialog();
                                }
                                else
                                {
                                    frmxf.ShowDialog();
                                }
                            }
                            else if (typeName.IsEquals("顾客结账"))
                            {
                                Frm_JZ frmjz = new Frm_JZ();
                                frmjz.Rname = lv_desk.SelectedItems[0].SubItems[0].Name.Trim();
                                frmjz.ShowDialog();
                            }
                        }
                    }
                }
                else
                {
                    Msg.ShowErrorMsg("请选择桌台");
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }
        //显示界面左边
        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel2.Visible = true;

        }
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Pwd pwd = new Frm_Pwd();
            pwd.RName = App.CertificationUser.User_Name;
            pwd.ShowDialog();
        }
        private void 数据备份恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BFFH fb = new Frm_BFFH();
            fb.ShowDialog();
        }
        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_BZ bz = new Frm_BZ();
            bz.ShowDialog();
        }
        private void 锁定系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SDXT sdxt = new Frm_SDXT();
            sdxt.ShowDialog();
        }

        #region 菜单栏
        private void 顾客开单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeValidation("顾客开单");
        }
        Frm_XF frmxf;
        private void 顾客点菜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeValidation("顾客点菜");
        }
        private void 顾客结账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeValidation("顾客结账");
        }
        Frm_QTXS frmqtxs;
        private void 前台销售ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmqtxs == null || frmqtxs.IsDisposed)
            {
                frmqtxs = new Frm_QTXS();
                frmqtxs.ShowDialog();
            }
            else
            {
                frmqtxs.ShowDialog();
            }
        }
        Frm_Yuding frmyuding;
        private void 预定管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmyuding == null || frmyuding.IsDisposed)
            {
                frmyuding = new Frm_Yuding();
                frmyuding.ShowDialog();
            }
            else
            {
                frmyuding.ShowDialog();
            }
        }
        Frm_taking frmtaking;
        private void 营业查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmtaking == null || frmtaking.IsDisposed)
            {
                frmtaking = new Frm_taking();
                frmtaking.ShowDialog();
            }
            else
            {
                frmtaking.ShowDialog();
            }
        }
        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Waiter frmwaiter = new Frm_Waiter();
            frmwaiter.ShowDialog();
        }
        private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmProductMaster frmstock = new FrmProductMaster();
            frmstock.ShowDialog();
        }
        Frm_member frmmember;
        private void 会员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmmember == null || frmmember.IsDisposed)
            {
                frmmember = new Frm_member();
                frmmember.ShowDialog();
            }
            else
            {
                frmmember.ShowDialog();
            }

        }
        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_XTSZ frmxtsz = new Frm_XTSZ();
            frmxtsz.Show();
        }
        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确认要重新登录吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                pd = true;
                Frm_login.pd = true;
                Application.Restart();
            }
        }
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GYCLGLXT gy = new Frm_GYCLGLXT();
            gy.ShowDialog();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            前台销售ToolStripMenuItem_Click(sender, e);
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            营业查询ToolStripMenuItem_Click(sender, e);
        }
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            员工管理ToolStripMenuItem_Click(sender, e);
        }
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            系统设置ToolStripMenuItem_Click(sender, e);
        }
        #endregion
        #region 右键菜单
        private void 顾客开单ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            顾客开单ToolStripMenuItem_Click(sender, e);
        }
        private void 顾客点菜ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            顾客点菜ToolStripMenuItem_Click(sender, e);
        }
        private void 顾客结账ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            顾客结账ToolStripMenuItem_Click(sender, e);
        }
        private void 桌台状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv_desk.SelectedItems.Count == 1)
                {
                    Frm_desk zt = new Frm_desk();
                    //zt.RName = lv_desk.SelectedItems[0].SubItems[0].Name.Trim();
                    zt.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }

        #endregion
        #region 单击鼠标右键时
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (lv_desk.SelectedItems.Count == 1)
                {
                    桌台状态ToolStripMenuItem.Enabled = true;
                    顾客结账ToolStripMenuItem1.Enabled = true;
                    顾客点菜ToolStripMenuItem1.Enabled = true;
                    顾客开单ToolStripMenuItem1.Enabled = true;

                    ClientServicesProxy proxys = new ClientServicesProxy();
                    var result = proxys.Find(new tb_Desk { Id = lv_desk.SelectedItems[0].SubItems[0].Name.Trim() }).FirstOrDefault();
                    if (result.IsNotNull() && result.DeskStatus.IsEquals(StatusEnum.Using))
                    {
                        桌台状态ToolStripMenuItem.Enabled = false;
                        顾客结账ToolStripMenuItem1.Enabled = true;
                        顾客点菜ToolStripMenuItem1.Enabled = true;
                        顾客开单ToolStripMenuItem1.Enabled = false;
                    }
                    else
                    {
                        桌台状态ToolStripMenuItem.Enabled = true;
                        顾客结账ToolStripMenuItem1.Enabled = true;
                        顾客点菜ToolStripMenuItem1.Enabled = true;
                        顾客开单ToolStripMenuItem1.Enabled = true;

                    }
                }
                else
                {
                    桌台状态ToolStripMenuItem.Enabled = false;
                    顾客结账ToolStripMenuItem1.Enabled = false;
                    顾客点菜ToolStripMenuItem1.Enabled = false;
                    顾客开单ToolStripMenuItem1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }
        #endregion
        List<tb_Desk> deskResultList;
        List<tb_DeskType> _deskTypeResultList;
        List<tb_DeskType> deskTypeResultList
        {
            get
            {
                if (_deskTypeResultList.IsNull())
                {
                    _deskTypeResultList = new ClientServicesProxy().Find(new tb_DeskType());
                }
                return _deskTypeResultList;
            }
            set
            {
                value = _deskTypeResultList;
            }
        }
        List<tb_DeskXS> _deskXSResultList;
        List<tb_DeskXS> deskXSResultList
        {
            get
            {
                if (_deskXSResultList.IsNull())
                {
                    _deskXSResultList = new ClientServicesProxy().Find(new tb_DeskXS());
                }
                return _deskXSResultList;
            }
            set
            {
                value = _deskXSResultList;
            }
        }
        List<tb_Open> _openResultList;
        List<tb_Open> openResultList
        {
            get
            {
                if (_openResultList.IsNull())
                {
                    _openResultList = new ClientServicesProxy().Find(new tb_Open());
                }
                return _openResultList;
            }
            set
            {
                value = _openResultList;
            }
        }
        List<tb_XFMX> GetHotProducts { get; set; }


        #region 单击桌台时
        private void lv_desk_Click(object sender, EventArgs e)
        {
            if (lv_desk.SelectedItems.Count == 1)
            {
                string deskId = lv_desk.SelectedItems[0].SubItems[0].Name.Trim();
                var deskResult = deskResultList.Find(n => n.Id.IsEquals(deskId));
                var deskTypeResult = deskTypeResultList.Find(n => n.Id.IsEquals(deskResult.TypeId));
                switch (StaticStr.GetStatusEnum(deskResult.DeskStatus))
                {
                    case StatusEnum.Normal:
                        FrmOrder frm = new FrmOrder();
                        frm.deskResult = deskResult;
                        frm.deskTypeResult = deskTypeResult;
                        frm.ShowDialog();
                        break;
                    case StatusEnum.Reserved:
                        Frm_Yuding reserved = new Frm_Yuding();
                        reserved.deskResult = deskResult;
                        reserved.ShowDialog();
                        break;
                    case StatusEnum.Using:
                        Frm_JZ usings = new Frm_JZ();
                        usings.deskResult = deskResult;
                        usings.ShowDialog();
                        break;
                    case StatusEnum.Clean:
                        Frm_desk clean = new Frm_desk();
                        clean.deskResult = deskResult;
                        clean.ShowDialog();
                        break;
                    case StatusEnum.Malfunction:
                        Frm_desk malfunction = new Frm_desk();
                        malfunction.deskResult = deskResult;
                        malfunction.ShowDialog();
                        break;
                    case StatusEnum.Unknown:
                        Frm_desk unknown = new Frm_desk();
                        unknown.deskResult = deskResult;
                        unknown.ShowDialog();
                        break;
                }
                //查询桌台消费信息
                lv_info.Items.Clear();
                toolStripLabel3.Text = deskResult.Name;
                var deskXSList = deskXSResultList.FindAll(n => n.XS_DeskName.IsEquals(deskId));
                foreach (tb_DeskXS item in deskXSList)
                {
                    ListViewItem lv = new ListViewItem(item.XS_goodsName);
                    lv.SubItems.Add(item.XS_dj);
                    lv.SubItems.Add(item.XS_Sum);
                    lv.SubItems.Add(item.XS_allprice.ToString());
                    lv.SubItems.Add(item.XS_sj.ToString());
                    lv.SubItems.Add(item.Open_Waiter);
                    lv.SubItems.Add(item.beizhu);
                    lv_info.Items.Add(lv);
                }
                if (deskResult.IsNotNull() && deskResult.DeskStatus.IsEquals(StatusEnum.Using))
                {
                    //显示时间
                    var operResult = openResultList.Find(n => n.DeskId.IsEquals(deskId));
                    if (operResult.IsNotNull())
                    {
                        LB_ktsj.Text = operResult.CreateTime.ToString(StaticStr.MM_dd_HH_mm);
                        LB_YCNum.Text = operResult.CustomersNumber.ToString();
                    }
                    var deskXSList2 = deskXSList.FindAll(n => n.XS_DeskName.IsEquals(deskId));
                    if (deskXSList2.IsNotNull())
                    {
                        LB_money.Text = "￥" + deskXSList2.Sum(n => n.XS_allprice);
                    }
                    else
                    {
                        LB_money.Text = "￥0.00";
                    }
                }
                else
                {
                    LB_YCNum.Text = "0";
                    LB_ktsj.Text = "—";
                    LB_yysj.Text = "—";
                    LB_money.Text = "￥0.00";
                }
            }
        }
        #endregion
        #region 窗体加载时
        private void Form1_Activated(object sender, EventArgs e)
        {
            Refreshs();
        }
        #endregion
        #region 双击桌台时
        private void lv_desk_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lv_desk.SelectedItems.Count == 1)
                {
                    ScheduledReminders();
                    ClientServicesProxy proxys = new ClientServicesProxy();
                    tb_Desk p = new tb_Desk { Id = lv_desk.SelectedItems[0].SubItems[0].Name.Trim() };
                    var deskResult = proxys.Find(p).FirstOrDefault();
                    if (deskResult.IsNotNull())
                    {
                        if (deskResult.DeskStatus.IsEquals(StatusEnum.Normal) || deskResult.DeskStatus.IsEquals(StatusEnum.Reserved))
                        {
                            顾客开单ToolStripMenuItem_Click(sender, e);
                        }
                        else if (deskResult.DeskStatus.IsEquals(StatusEnum.Using))
                        {
                            顾客点菜ToolStripMenuItem_Click(sender, e);
                        }
                        else
                        {
                            桌台状态ToolStripMenuItem_Click(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }
        #endregion
        #region 计算器
        private void but_JSQ_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
        #endregion
        #region 记事本
        private void but_JSB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }
        #endregion
        #region 扫雷
        private void but_SL_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winmine.exe");
        }
        #endregion
        #region 纸牌
        private void but_ZP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("sol.exe");
        }
        #endregion
        #region 红心大战
        private void but_HXDZ_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mshearts.exe");
        }
        #endregion
        #region 单击隐藏桌台消费明细信息
        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            panel12.Visible = false;
            toolStripButton18.Visible = true;
            toolStripButton16.Visible = false;
        }
        #endregion
        #region 单击显示桌台消费明细信息
        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            panel12.Visible = true;
            toolStripButton18.Visible = false;
            toolStripButton16.Visible = true;
        }
        #endregion
        #region 显示全部桌台
        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            Form1_Activated(sender, e);
            LB_wz.Focus();
        }
        #endregion
        #region 显示可用桌台
        private void 显示可供ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BigImageView(StatusEnum.Normal);
        }
        private void 显示预定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BigImageView(StatusEnum.Reserved);
        }
        private void 显示占用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BigImageView(StatusEnum.Using);
        }
        private void 显示脏桌ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BigImageView(StatusEnum.Clean);
        }
        private void 显示停用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BigImageView(StatusEnum.Malfunction);
        }
        #endregion
        #region 隐藏界面左边
        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
            panel2.Visible = false;

        }
        #endregion
        #region 关闭窗体
        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!pd && Msg.ShowConfirmMsg("你确定要退出吗?") != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Frm_login.pd = true;
                System.Environment.Exit(0);
            }
        }
        #endregion
        #region 回车键查询
        private void txtDeskQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BigImageView(null, txtDeskQuery.Text.Trim());
            }
        }
        #endregion
        #region 预定时间提醒
        void ScheduledReminders()
        {
            if (lv_desk.SelectedItems.IsNotNull() && lv_desk.SelectedItems.Count > 0 && lv_desk.SelectedItems[0].SubItems.IsNotNull() && lv_desk.SelectedItems[0].SubItems[0].IsNotNull())
            {
                var desk = lv_desk.SelectedItems[0].SubItems[0].Name.Trim();
                Task.Factory.StartNew(() =>
                {
                    ClientServicesProxy proxys = new ClientServicesProxy();
                    tb_Booked p = new tb_Booked { BookedDeskId = desk };
                    var result = proxys.Find(p);
                    StringBuilder sb = new StringBuilder();
                    foreach (tb_Booked item in result)
                    {
                        TimeSpan ts = item.BookedDateTime - Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        //把时间转换成秒
                        int a = ts.Hours * 3600 + ts.Minutes * 60 + ts.Seconds;
                        if (a == 600)
                        {
                            sb.AppendFormat("{0}预定{1}桌台时间还有10分钟就到预定时间了", item.GuestName, item.BookedDeskId);
                        }
                    }
                    if (sb.Length > 1)
                    {
                        MessageBox.Show(sb.ToString());
                    }
                });
            }
        }
        #endregion
        #region 查询热卖产品 滚动播放

        private void timHotProducts_Tick(object sender, EventArgs e)
        {
            try
            {
                StringBuilder str = new StringBuilder();
                string mc = string.Empty;
                LB_wz.Text = mc;
                if (lv_desk.SelectedItems.Count == 1)
                {
                    var id = lv_desk.SelectedItems[0].SubItems[0].Name.Trim();
                    DateTime endDate;
                    if (id.IsNotNull() && LB_ktsj.Text.IsNotNull() && DateTime.TryParse(LB_ktsj.Text.Trim(), out endDate))
                    {
                        Task.Factory.StartNew(() =>
                        {
                            ClientServicesProxy proxys = new ClientServicesProxy();
                            tb_Desk p = new tb_Desk { Id = id };
                            var result = proxys.Find(p).FirstOrDefault();
                            if (result.DeskStatus.IsEquals(StatusEnum.Using))
                            {
                                Action<string> action = (data) => { LB_yysj.Text = data; }; Invoke(action, (Convert.ToDateTime(DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss)) - endDate).ToString().Trim());
                            }
                        });
                    }
                }
                Task.Factory.StartNew(() =>
                {
                    if (GetHotProducts.IsNotNull())
                    {
                        foreach (tb_XFMX item in GetHotProducts)
                        {
                            str.AppendFormat("{0},", item.MX_Goods);
                        }
                        mc = str.ToString();
                        if (LB_wz.Left < panel14.Width)
                        {
                            Action<int> action = (data) => { LB_wz.Left += data; }; Invoke(action, 2);
                        }
                        else
                        {
                            Action<int> action = (data) => { LB_wz.Left = data; }; Invoke(action, 14);
                        }
                        if (mc.IsNotNull())
                        {
                            Action<string> action = (data) => { LB_wz.Text = data; }; Invoke(action, "今日热卖产品:" + mc.Remove(mc.Length - 1));
                        }
                        Action<string> actionTime = (data) => { toolStripLabel7.Text = data; }; Invoke(actionTime, DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss));
                        actionTime = (data) => { toolStripStatusLabel5.Text = data; }; Invoke(actionTime, DateTime.Now.ToString(StaticStr.yyyy_MM_dd_HH_mm_ss));
                    }
                });
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex, "查询热卖产品");
            }
        }
        #endregion
        #region 设置视图为详细信息
        private void tlsdetails_Click(object sender, EventArgs e)
        {
            ViewDetails();
        }
        private void tlsBigImageView_Click(object sender, EventArgs e)
        {
            BigImageView(null);
        }

        private void ViewDetails()
        {
            try
            {
                ColumnHeader clh;
                lv_desk.Clear();
                lv_desk.View = View.Details;//设置视图为详细信息
                clh = new ColumnHeader();
                clh.Text = "图标";
                clh.Width = 120;
                clh.TextAlign = HorizontalAlignment.Center;
                lv_desk.Columns.Add(clh);
                clh = new ColumnHeader();
                clh.Text = "桌台名称";
                clh.Width = 200;
                clh.TextAlign = HorizontalAlignment.Center;
                lv_desk.Columns.Add(clh);
                clh = new ColumnHeader();
                clh.Text = "桌台状态";
                clh.Width = 100;
                clh.TextAlign = HorizontalAlignment.Center;
                lv_desk.Columns.Add(clh);
                //clh = new ColumnHeader();
                //clh.Text = "开台时间";
                //clh.Width = 200;
                //clh.TextAlign = HorizontalAlignment.Center;
                //lv_desk.Columns.Add(clh);
                //clh = new ColumnHeader();
                //clh.Text = "顾客人数";
                //clh.Width = 100;
                //clh.TextAlign = HorizontalAlignment.Center;
                //lv_desk.Columns.Add(clh);
                //clh = new ColumnHeader();
                //clh.Text = "服务员";
                //clh.Width = 100;
                //clh.TextAlign = HorizontalAlignment.Center;
                //lv_desk.Columns.Add(clh);
                clh = new ColumnHeader();
                clh.Text = "备注";
                clh.Width = 200;
                clh.TextAlign = HorizontalAlignment.Center;
                lv_desk.Columns.Add(clh);
                ClientServicesProxy proxys = new ClientServicesProxy();
                deskResultList = proxys.Find(new tb_Desk());
                var deskTypeList = proxys.Find(new tb_DeskType());
                if (deskResultList.IsNotNull() && deskTypeList.IsNotNull())
                {

                    var query = from d in deskResultList
                                join t in deskTypeList on d.TypeId equals t.Id.ToString()
                                select new
                                {
                                    d.Id,
                                    d.Name,
                                    d.Status,
                                    d.ShopId,
                                    d.DeskStatus,
                                    d.Remarks,
                                };
                    foreach (var item in query)
                    {
                        ListViewItem lv = new ListViewItem(item.Id);
                        var em = StaticStr.GetStatusEnum(item.DeskStatus);
                        lv.ImageIndex = em.GetHashCode() - 3;
                        lv.SubItems.Add(item.Name);
                        lv.SubItems.Add(em.ToEnumDescription());
                        lv.SubItems.Add(item.Remarks);
                        lv_desk.Items.Add(lv);
                    }
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }
        private void BigImageView(StatusEnum? DeskStatus, string queryStr = null)
        {
            try
            {
                lv_desk.View = View.LargeIcon;
                lv_desk.Items.Clear();
                ClientServicesProxy proxys = new ClientServicesProxy();
                tb_Desk p = new tb_Desk();
                if (DeskStatus.IsNotNull())
                {
                    p.DeskStatus = DeskStatus.ToString();
                }
                deskResultList = proxys.Find(p);
                if (deskResultList.IsNotNull())
                {
                    if (queryStr.IsNotNull())
                    {
                        deskResultList = deskResultList.FindAll(n => n.Id.IsContains(queryStr) || n.Name.IsContains(queryStr) || n.ShopId.IsContains(queryStr));
                    }
                    foreach (var item in deskResultList)
                    {
                        AddItems(item.Id, item.Name, item.DeskStatus);
                    }
                    if (DeskStatus.IsNull() || queryStr.IsNotNull())
                    {
                        //查询各类状态桌台的数量
                        LB_sum.Text = deskResultList.Count.ToString();
                        LB_ky.Text = deskResultList.FindAll(n => n.DeskStatus.IsEquals(StatusEnum.Normal.ToString())).Count().ToString();
                        LB_sy.Text = deskResultList.FindAll(n => n.DeskStatus.IsEquals(StatusEnum.Using.ToString())).Count().ToString();
                        LB_yd.Text = deskResultList.FindAll(n => n.DeskStatus.IsEquals(StatusEnum.Reserved.ToString())).Count().ToString();
                        LB_ty.Text = deskResultList.FindAll(n => n.DeskStatus.IsEquals(StatusEnum.Clean.ToString())).Count().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }
        void Refreshs()
        {
            BigImageView(null);
        }
        public static Action RefreshsAction;
        #endregion

        private void tsmProductPackage_Click(object sender, EventArgs e)
        {
            FormProductPackageEdit frm = new FormProductPackageEdit();
            frm.ShowDialog();
        }
    }
}
