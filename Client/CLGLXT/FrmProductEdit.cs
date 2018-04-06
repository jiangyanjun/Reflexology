using Foot.EntityLayers;
using Foot.Proxy;
using Kebue.Core.Util;
using System;
using System.Windows.Forms;

namespace Foot.Client
{
    public partial class FrmProductEdit : Form
    {
        public FrmProductEdit()
        {
            InitializeComponent();
            cmbProductType.DataSource = new ClientServicesProxy().Find(new ProductType());
            cmbProductType.ValueMember = "Id";
            cmbProductType.DisplayMember = "Name";
            btnSave.Text = "增加";
        }
        Product p { get; set; }
        public FrmProductEdit(Product parameter)
        {
            InitializeComponent();
            cmbProductType.DataSource = new ClientServicesProxy().Find(new ProductType());
            cmbProductType.ValueMember = "Id";
            cmbProductType.DisplayMember = "Name";
            btnSave.Text = "增加";
            p = parameter;
            cmbProductType.SelectedValue = p.ProductTypeId;
            cmbProductType.Enabled = false;
            txtProductName.Text = p.ProductName;
            txtPrice.Text = p.Price.ToString();
            txtCostPrice.Text = p.CostPrice.ToString();
            txtQRode.Text = p.Remarks;
            txtStockQuantity.Value = p.StockQuantity.ToDecimal();
            btnSave.Text = "更新";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            #region 增加
            if (btnSave.Text.IsEquals("增加"))
            {
                p = new Product();
                p.Id = App.GetGuid;
                p.ProductName = txtProductName.Text;
                p.ProductTypeId = cmbProductType.SelectedValue.ToString();
                p.Price = txtPrice.Text.ToDecimal();
                p.CostPrice = txtCostPrice.Text.ToDecimal();
                p.Remarks = txtRemarks.Text;
                p.StockQuantity = txtStockQuantity.Value.ToInt();
                p.Inventory = 0;
                p.CreateTime = App.GetDateTime;
                p.LastOperationTime = p.CreateTime;
                p.CreateUserId = App.CertificationUser.Id;
                p.LastOperationUserId = p.CreateUserId;
                p.ShopId = App.CertificationUser.ShopId;
                p.Inventory = 0;
                p.QRode = txtQRode.Text;
                if (new ClientServicesProxy().Add(p) > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    Msg.ShowOkMsg("添加失败");
                }
            }
            #endregion
            #region 修改
            else
            {
                p.ProductName = txtProductName.Text;
                p.ProductTypeId = cmbProductType.SelectedValue.ToString();
                p.Price = txtPrice.Text.ToDecimal();
                p.CostPrice = txtCostPrice.Text.ToDecimal();
                p.StockQuantity = txtStockQuantity.Value.ToInt();
                p.Remarks = txtRemarks.Text;
                p.QRode = txtQRode.Text;
                p.LastOperationTime = App.GetDateTime;
                p.LastOperationUserId = App.CertificationUser.Id;
                if (new ClientServicesProxy().Update(p) > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    Msg.ShowOkMsg("更新失败");
                }
            }
            #endregion
            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar) && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtStockQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !char.IsDigit(e.KeyChar) && p.IsNotNull())
            {
                var stock = txtStockQuantity.Value.ToInt();
                if (stock < p.Inventory)
                {
                    txtStockQuantity.Value = p.Inventory.ToDecimal();
                    Msg.ShowErrorMsg("您的库存调整不能小于已销售数量");
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
