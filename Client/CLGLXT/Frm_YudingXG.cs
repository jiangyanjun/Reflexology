using Foot.EntityLayers;
using Foot.Proxy;
using Kebue.Core.Util;
using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Foot.Client
{
    public partial class Frm_YudingXG : Form
    {
        public Frm_YudingXG()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取是添加还是修改预定信息
        /// </summary>
        public static string strbianhao;
        /// <summary>
        /// 获取桌台编号
        /// </summary>
        public string RName;
        private void Frm_YudingXG_Load(object sender, EventArgs e)
        {
            try
            {
                //加载桌台类型
                ClientServicesProxy proxys = new ClientServicesProxy();
                tb_DeskType p = new tb_DeskType();
                var result = proxys.Find(p);
                cbmBookedDeskTypeId.DataSource = result;
                cbmBookedDeskTypeId.DisplayMember = "DT_type";
                cbmBookedDeskTypeId.ValueMember = "Id";
                if (strbianhao == "0")
                {
                    this.Text = "添加预定";
                    cbmBookedDeskTypeId.SelectedIndex = 0;
                    txtRemarks.Text = "无";
                }
                else if (strbianhao == "2")
                {
                    this.Text = "添加预定";
                    //p.DT_Num = RName;
                    //p.DT_number = this.Text;
                    //result = proxys.Find(p);
                    //cbmBookedDeskTypeId.Text = result.FirstOrDefault().DT_type;
                    //cbmBookedDeskId.Text = p.DT_Num;
                    txtRemarks.Text = "无";
                }
                else if (strbianhao == "1")
                {
                    this.Text = "修改预定";
                    var parameter = new tb_Booked { BookedDeskId = RName };
                    var bookedInfo = proxys.Find(parameter).FirstOrDefault();
                    txtRemarks.Text = bookedInfo.Remarks;
                    txtGuestName.Text = bookedInfo.GuestName;
                    txtGuestTelePhone.Text = bookedInfo.GuestTelePhone;
                    cbmBookedDeskTypeId.Text = bookedInfo.BookedDeskTypeId;
                    cbmBookedDeskId.Text = bookedInfo.BookedDeskId;
                    dtpBookedDateTime.Text = bookedInfo.BookedDateTime.ToString();
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }
        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            RName = null;
            cbmBookedDeskTypeId.SelectedIndex = 0;
            txtRemarks.Text = "无";
            txtGuestName.Text = "";
            txtGuestTelePhone.Text = "";
            dtpBookedDateTime.Text = "";
        }
        void Operation(string type)
        {
            #region 非空验证
            if (txtGuestName.Text.Trim().IsNotNull())
            {
                errorProvider1.SetError(txtGuestName, "宾客姓名不可为空");
                return;
            }
            if (cbmBookedDeskTypeId.Text.Trim().IsNotNull())
            {
                errorProvider1.SetError(cbmBookedDeskTypeId, "T台类型不可为空");
                return;
            }
            if (cbmBookedDeskId.Text.Trim().IsNotNull())
            {
                errorProvider1.SetError(cbmBookedDeskId, "T台编号不可为空");
                return;
            }
            if (txtGuestTelePhone.Text.Trim().IsNotNull())
            {
                errorProvider1.SetError(txtGuestTelePhone, "宾客电话不可为空");
                return;
            }
            if (dtpBookedDateTime.Text.Trim().IsNotNull())
            {
                errorProvider1.SetError(dtpBookedDateTime, "预定时间不可为空");
                return;
            }
            #endregion
            var p = new tb_Booked
            {
                Id = lblBookedId.Text,
                GuestName = txtGuestName.Text.Trim(),
                GuestTelePhone = txtGuestTelePhone.Text.Trim(),
                BookedDeskTypeId = cbmBookedDeskTypeId.Text.Trim(),
                BookedDeskId = cbmBookedDeskId.Text.Trim(),
                Remarks = txtRemarks.Text.Trim(),
                BookedDateTime = Convert.ToDateTime(dtpBookedDateTime.Text.Trim()),
                LastOperationUserId = App.CertificationUser.Id,
                LastOperationTime = StaticStr.dateTime
            };
            ClientServicesProxy proxys = new ClientServicesProxy();
            var res = -1;
            switch (type)
            {
                case "add":
                    p.CreateUserId = p.LastOperationUserId;
                    p.CreateTime = p.LastOperationTime;
                    res = proxys.Add(p);
                    if (res > 0)
                    {
                        tb_Desk desk = new tb_Desk { TypeId = "预定", Id = p.BookedDeskId };
                        res = proxys.Update(desk);
                    }
                    break;
                case "update":
                    res = proxys.Update(p);
                    if (res > 0)
                    {
                        tb_Desk desk = new tb_Desk { TypeId = "预定", Id = p.BookedDeskId };
                        res = proxys.Update(desk);
                    }
                    break;
                case "delete":
                    res = proxys.Delete(p);
                    break;
            }
            if (res >= 0)
            {
                if (res > 0)
                {
                    Msg.ShowOkMsg("保存成功");
                    but_Close_Click(null, null);
                }
                else
                {
                    Msg.ShowOkMsg("保存失败");
                }
            }
        }
        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
                //为空时添加
                if (strbianhao.IsEquals("0") || strbianhao.IsEquals("2"))
                {
                    Operation("add");
                }
                else if (strbianhao == "1")
                {
                    Operation("update");
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }
        private void TB_Tel_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //验证电话号码
                Regex reg = new Regex(@"(\d{11})|^((\d{7,8})|(\d{4}|\d{3})-(\d{7,8})|(\d{4}|\d{3})-(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1})|(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1}))$");
                if (!reg.IsMatch(this.txtGuestTelePhone.Text))
                {
                    this.errorProvider1.SetError(this.txtGuestTelePhone, "请输入正确的电话号码");
                    e.Cancel = true;
                }
                else
                {
                    this.errorProvider1.SetError(this.txtGuestTelePhone, "");
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }
        private void CB_Type_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //查询桌台类型编号
                ClientServicesProxy proxys = new ClientServicesProxy();
                tb_DeskType p = new tb_DeskType { Id = cbmBookedDeskTypeId.Text.Trim() };
                var result = proxys.Find(p);
                if (result.IsNotNull())
                {
                    tb_Desk desk = new tb_Desk { Name = result.FirstOrDefault().Id.ToString(), DeskStatus =StatusEnum.Normal.ToString() };
                    var deskresults = proxys.Find(p);
                    cbmBookedDeskId.Items.Clear();
                    foreach (var item in deskresults)
                    {
                        cbmBookedDeskId.DataSource = deskresults;
                        cbmBookedDeskId.DisplayMember = "Name";
                        cbmBookedDeskId.ValueMember = "Id";
                    }
                    cbmBookedDeskId.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }
    }
}
