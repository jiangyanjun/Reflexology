using Foot.EntityLayers;
using Foot.Proxy;
using IBatisNet.Common.Transaction;
using Kebue.Core.Util;
using System;
using System.Windows.Forms;

namespace Foot.Client
{
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }
        internal tb_Desk deskResult;
        internal tb_DeskType deskTypeResult;
        private void Frm_Open_Load(object sender, EventArgs e)
        {
            try
            {
                LB_Name.Text = deskResult.Name;
                LB_type.Text = deskTypeResult.Name;
                txtRemarks.Text = deskResult.Remarks;
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
                Orders order = new Orders();
                order.Id = App.GetGuid;
                order.ShopId = App.CertificationUser.ShopId;
                order.CreateTime = App.GetDateTime;
                order.LastOperationTime = order.CreateTime;
                order.CreateUserId = App.CertificationUser.Id;
                order.LastOperationUserId = order.CreateUserId;
                order.MemberId = txtMemberId.Text;
                order.DeskId = deskResult.Id;
                order.TypeId = deskTypeResult.Id;
                order.Status = StatusEnum.True.ToString();
                order.Remarks = txtRemarks.Text;
                order.CustomerName = txtCustomerName.Text;
                order.TelePhone = txtTelePhone.Text;
                order.CustomerNumber = txtCustomersNumber.Text.ToInt();
                order.FlowStatus = StatusEnum.Using.ToString();
                if (new ClientServicesProxy().Add(order) > 0)
                {
                    if (Frm_Main.RefreshsAction.IsNotNull())
                    { //scope.Complete();
                        this.Close();
                        Frm_Main.RefreshsAction();
                    }
                }
                else
                {
                    Msg.ShowOkMsg("保存失败");
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
        }

        private void txtTelePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' '))//不输入输入除了数字之外的所有非法字符的判断
            {
                e.Handled = true;
            }
        }

        private void txtCustomersNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
