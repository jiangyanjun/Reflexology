using Foot.EntityLayers;
using Foot.Proxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kebue.Core.Util;

namespace Foot.Client
{
    public partial class FormProductPackageEdit : Form
    {
        public FormProductPackageEdit()
        {
            InitializeComponent();
            //ResultList = new ClientServicesProxy().Find(new Product());
            //dgPackageList.DataSource = ResultList;
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            using (FormProductList frm = new FormProductList())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ProductList = dgPackageList.DataSource as List<Product>;
                    if (ProductList.IsNull())
                    {
                        ProductList = new List<Product>();
                    }
                    ProductList.AddRange(frm.CheckResultList);
                    BindData();
                }
            }
        }
        List<Product> ProductList;
        void BindData()
        {
            dgPackageList.DataSource = null;
            dgPackageList.DataSource = ProductList;
            dgPackageList.Refresh();
            ProductList = dgPackageList.DataSource as List<Product>;
            lblPriceSum.Text = ProductList.Sum(n => n.Price).ToString();
        }
    }
}
