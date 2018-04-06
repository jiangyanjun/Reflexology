using Foot.EntityLayers;
using Foot.Proxy;
using Kebue.Core.Util;
using System;
using System.Windows.Forms;

namespace Foot.Client
{
    public partial class Frm_desk : Form
    {
        public Frm_desk()
        {
            InitializeComponent();
        }
        internal tb_Desk deskResult;
        private void Frm_desk_Load(object sender, EventArgs e)
        {
            try
            {
                lb_Name.Text = deskResult.Name;
                lb_Type.Text = StaticStr.GetStatusEnum(deskResult.DeskStatus).ToEnumDescription();
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }
        private void radNormal_CheckedChanged(object sender, EventArgs e)
        {
            deskResult.DeskStatus = StatusEnum.Normal.ToString();
        }
        private void rdClean_CheckedChanged(object sender, EventArgs e)
        {
            deskResult.DeskStatus = StatusEnum.Clean.ToString();
        }
        private void rdMalfunction_CheckedChanged(object sender, EventArgs e)
        {
            deskResult.DeskStatus = StatusEnum.Malfunction.ToString();
        }
        private void ptNormal_Click(object sender, EventArgs e)
        {
            radNormal.Checked = true;
            radNormal_CheckedChanged(sender, e);
        }
        private void ptClean_Click(object sender, EventArgs e)
        {
            rdClean.Checked = true;
            rdClean_CheckedChanged(sender, e);
        }
        private void ptMalfunction_Click(object sender, EventArgs e)
        {
            rdMalfunction.Checked = true;
            rdMalfunction_CheckedChanged(sender, e);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            deskResult.LastOperationTime = StaticStr.dateTime;
            deskResult.LastOperationUserId = App.CertificationUser.Id;
            if (new ClientServicesProxy().Update(deskResult) > 0)
            {
                if (Frm_Main.RefreshsAction.IsNotNull())
                {
                    this.Close();
                    Frm_Main.RefreshsAction();
                }
            }
            else
            {
                Msg.ShowOkMsg("保存失败");
            }
        }
    }
}
