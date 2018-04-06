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
    public partial class FormProductList : Form
    {
        public FormProductList()
        {
            InitializeComponent();
        }
        List<Product> ResultList { get; set; }
        public List<Product> CheckResultList { get; set; }
        private void FormProductList_Load(object sender, EventArgs e)
        {
            ResultList = new ClientServicesProxy().Find(new Product());
            dgvList.DataSource = ResultList;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ResultList.IsNotNull())
            {
                List<string> list = new List<string>();
                dgvList.EndEdit();
                foreach (DataGridViewRow dr in dgvList.Rows)
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dr.Cells["dvCheck"];
                    if (Convert.ToBoolean(checkCell.Value) == true)
                    {
                        list.Add(dr.Cells["dvId"].Value.ToString());
                    }
                }
                CheckResultList = ResultList.FindAll(n => list.Exists(x => n.Id.IsEquals(x)));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }
    }
}
