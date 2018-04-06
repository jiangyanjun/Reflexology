using Foot.EntityLayers;
using Foot.Proxy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Kebue.Core.Util;

namespace Foot.Client
{
    public partial class FrmProductMaster : Form
    {
        public FrmProductMaster()
        {
            InitializeComponent();
        }
        DAL.DBConnection db = new Foot.Client.DAL.DBConnection();
        private void but_xianshi_Click(object sender, EventArgs e)
        {
            try
            {
                string str_sql = "select a.goods_ID, a.goods_Name, a.Goods_Jhprice, a.Goods_num, a.Goods_allprice, a.Beizhu,b.CK_Name from tb_goods a,tb_warehouse b where a.Goods_CKID=b.CK_ID";
                DataSet ds = db.GetDataFromSQL(str_sql);
                grdProductManagement.DataSource = ds.Tables[0];
            }
            catch { }
        }

        private void but_jhdCx_Click(object sender, EventArgs e)
        {
            Frm_stockCX cx = new Frm_stockCX();
            cx.ShowDialog();
        }
        private void but_DH_Click(object sender, EventArgs e)
        {
            Frm_stockDH dh = new Frm_stockDH();
            dh.ShowDialog();
        }

        private void but_CG_Click(object sender, EventArgs e)
        {
            Frm_stockCG cg = new Frm_stockCG();
            cg.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmProductEdit frm = new FrmProductEdit();
            frm.ShowDialog();
        }
        List<Product> ProductList { get; set; }
        void Query()
        {
            string typeId = cmbProductType.SelectedValue.ToString();
            string ProductName = txtProductName.Text;
            ProductList = new ClientServicesProxy().Find(new Product { ProductTypeId = typeId == "All" ? null : typeId, ProductName = ProductName });
            grdProductManagement.DataSource = ProductList;
        }
        private void FrmProductMaster_Load(object sender, EventArgs e)
        {
            var productTypeList = new ClientServicesProxy().Find(new ProductType());
            productTypeList.Add(new ProductType { Id = "All", Name = "全部" });
            cmbProductType.DataSource = productTypeList;
            cmbProductType.ValueMember = "Id";
            cmbProductType.DisplayMember = "Name";

            Query();
            grdProductManagement.AutoGenerateColumns = false;
            grdProductManagement.Columns[0].HeaderText = "编号";
            grdProductManagement.Columns[0].DataPropertyName = "Id";
            grdProductManagement.Columns[0].Visible = false;

            grdProductManagement.Columns[1].HeaderText = "店铺编号";
            grdProductManagement.Columns[1].DataPropertyName = "ShopId";
            grdProductManagement.Columns[1].Visible = false;

            grdProductManagement.Columns[2].HeaderText = "产品类型";
            grdProductManagement.Columns[2].DataPropertyName = "ProductTypeId";
            grdProductManagement.Columns[2].Visible = false;

            grdProductManagement.Columns[3].HeaderText = "商品名称";
            grdProductManagement.Columns[3].DataPropertyName = "ProductName";
            grdProductManagement.Columns[3].Visible = true;

            grdProductManagement.Columns[4].HeaderText = "成本价格";
            grdProductManagement.Columns[4].DataPropertyName = "CostPrice";
            grdProductManagement.Columns[4].Visible = true;

            grdProductManagement.Columns[5].HeaderText = "销售价";
            grdProductManagement.Columns[5].DataPropertyName = "Price";
            grdProductManagement.Columns[5].Visible = true;

            grdProductManagement.Columns[6].HeaderText = "总库存量";
            grdProductManagement.Columns[6].DataPropertyName = "StockQuantity";
            grdProductManagement.Columns[6].Visible = true;

            grdProductManagement.Columns[7].HeaderText = "已销售量";
            grdProductManagement.Columns[7].DataPropertyName = "Inventory";
            grdProductManagement.Columns[7].Visible = true;

            grdProductManagement.Columns[8].HeaderText = "备注";
            grdProductManagement.Columns[8].DataPropertyName = "Remarks";
            grdProductManagement.Columns[8].Visible = true;

            grdProductManagement.Columns[9].HeaderText = "总库存量";
            grdProductManagement.Columns[9].DataPropertyName = "StockQuantity";
            grdProductManagement.Columns[9].Visible = true;

            grdProductManagement.Columns[10].HeaderText = "创建时间";
            grdProductManagement.Columns[10].DataPropertyName = "CreateTime";
            grdProductManagement.Columns[10].Visible = true;

            grdProductManagement.Columns[11].HeaderText = "最近操作时间";
            grdProductManagement.Columns[11].DataPropertyName = "LastOperationTime";
            grdProductManagement.Columns[11].Visible = true;

            grdProductManagement.Columns[12].HeaderText = "创建人";
            grdProductManagement.Columns[12].DataPropertyName = "CreateUserId";
            grdProductManagement.Columns[12].Visible = true;

            grdProductManagement.Columns[13].HeaderText = "最近操作人";
            grdProductManagement.Columns[13].DataPropertyName = "LastOperationUserId";
            grdProductManagement.Columns[13].Visible = true;

            grdProductManagement.Columns[14].HeaderText = "最近操作人";
            grdProductManagement.Columns[14].DataPropertyName = "LastOperationUserId";
            grdProductManagement.Columns[14].Visible = true;

            grdProductManagement.Columns[15].HeaderText = "状态";
            grdProductManagement.Columns[15].DataPropertyName = "Status";
            grdProductManagement.Columns[15].Visible = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void grdProductManagement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = grdProductManagement[0, e.RowIndex].Value.ToString();
                var res = ProductList.Find(n => n.Id.IsEquals(id));
                using (FrmProductEdit frm = new FrmProductEdit(res))
                {
                    if (DialogResult.OK == frm.ShowDialog())
                    {
                        Query();
                    }
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdProductManagement.CurrentRow.IsNotNull())
                {
                    if (Msg.ShowConfirmMsg(string.Format("请确认是否删除商品 [ {0} ] ?，删除后将永久删除无法恢复", grdProductManagement.CurrentRow.Cells[3].Value.ToString())) == DialogResult.Yes)
                    {
                        string id = grdProductManagement.CurrentRow.Cells[0].Value.ToString();
                        if (new ClientServicesProxy().Delete(new Product() { Id = id }) > 0)
                        {
                            Query();
                            Msg.ShowOkMsg("删除成功");
                        }
                        else
                        {
                            Msg.ShowErrorMsg("删除失败");
                        }
                    }
                }
                else
                {
                    Msg.ShowErrorMsg("请先选择要删除的数据");
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmProductEdit frm = new FrmProductEdit())
                {
                    if (DialogResult.OK == frm.ShowDialog())
                    {
                        Query();
                    }
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }

        private void tlsDelete_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void tlsAdd_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void tlsUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdProductManagement.CurrentRow.IsNotNull())
                {
                    string id = grdProductManagement.CurrentRow.Cells[0].Value.ToString();
                    var res = ProductList.Find(n => n.Id.IsEquals(id));
                    using (FrmProductEdit frm = new FrmProductEdit(res))
                    {
                        if (DialogResult.OK == frm.ShowDialog())
                        {
                            Query();
                        }
                    }
                }
                else
                {
                    Msg.ShowErrorMsg("请先选择要删除的数据");
                }
            }
            catch (Exception ex)
            {
                Msg.ShowErrorMsg(ex);
            }
        }
    }
}
