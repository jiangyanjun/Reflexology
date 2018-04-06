namespace Foot.Client
{
    partial class FormProductList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.dvCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvShopId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvProductTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvStockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvQRode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvCreateUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvLastOperationUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvLastOperationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 31);
            this.panel2.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(277, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 316);
            this.panel1.TabIndex = 2;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvCheck,
            this.dvId,
            this.dvShopId,
            this.dvProductTypeId,
            this.dvProductName,
            this.dvCostPrice,
            this.dvPrice,
            this.dvStockQuantity,
            this.dvInventory,
            this.dvStatus,
            this.dvQRode,
            this.dvCreateUserId,
            this.dvCreateTime,
            this.dvLastOperationUserId,
            this.dvLastOperationTime,
            this.dvRemarks});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(716, 316);
            this.dgvList.TabIndex = 0;
            // 
            // dvCheck
            // 
            this.dvCheck.HeaderText = "请选择";
            this.dvCheck.Name = "dvCheck";
            // 
            // dvId
            // 
            this.dvId.DataPropertyName = "Id";
            this.dvId.HeaderText = "产品编号";
            this.dvId.Name = "dvId";
            this.dvId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dvShopId
            // 
            this.dvShopId.DataPropertyName = "ShopId";
            this.dvShopId.HeaderText = "店铺编号";
            this.dvShopId.Name = "dvShopId";
            // 
            // dvProductTypeId
            // 
            this.dvProductTypeId.DataPropertyName = "ProductTypeId";
            this.dvProductTypeId.HeaderText = "产品类型编号";
            this.dvProductTypeId.Name = "dvProductTypeId";
            // 
            // dvProductName
            // 
            this.dvProductName.DataPropertyName = "ProductName";
            this.dvProductName.HeaderText = "产品名称";
            this.dvProductName.Name = "dvProductName";
            // 
            // dvCostPrice
            // 
            this.dvCostPrice.DataPropertyName = "CostPrice";
            this.dvCostPrice.HeaderText = "成本价格";
            this.dvCostPrice.Name = "dvCostPrice";
            // 
            // dvPrice
            // 
            this.dvPrice.DataPropertyName = "Price";
            this.dvPrice.HeaderText = "售价";
            this.dvPrice.Name = "dvPrice";
            // 
            // dvStockQuantity
            // 
            this.dvStockQuantity.DataPropertyName = "StockQuantity";
            this.dvStockQuantity.HeaderText = "总库存";
            this.dvStockQuantity.Name = "dvStockQuantity";
            // 
            // dvInventory
            // 
            this.dvInventory.DataPropertyName = "Inventory";
            this.dvInventory.HeaderText = "已销售";
            this.dvInventory.Name = "dvInventory";
            // 
            // dvStatus
            // 
            this.dvStatus.DataPropertyName = "Status";
            this.dvStatus.HeaderText = "状态";
            this.dvStatus.Name = "dvStatus";
            // 
            // dvQRode
            // 
            this.dvQRode.DataPropertyName = "QRode";
            this.dvQRode.HeaderText = "条码";
            this.dvQRode.Name = "dvQRode";
            // 
            // dvCreateUserId
            // 
            this.dvCreateUserId.DataPropertyName = "CreateUserId";
            this.dvCreateUserId.HeaderText = "新建人";
            this.dvCreateUserId.Name = "dvCreateUserId";
            // 
            // dvCreateTime
            // 
            this.dvCreateTime.DataPropertyName = "CreateTime";
            this.dvCreateTime.HeaderText = "新建时间";
            this.dvCreateTime.Name = "dvCreateTime";
            // 
            // dvLastOperationUserId
            // 
            this.dvLastOperationUserId.DataPropertyName = "LastOperationUserId";
            this.dvLastOperationUserId.HeaderText = "最近修改人";
            this.dvLastOperationUserId.Name = "dvLastOperationUserId";
            // 
            // dvLastOperationTime
            // 
            this.dvLastOperationTime.DataPropertyName = "LastOperationTime";
            this.dvLastOperationTime.HeaderText = "最近修改时间";
            this.dvLastOperationTime.Name = "dvLastOperationTime";
            // 
            // dvRemarks
            // 
            this.dvRemarks.DataPropertyName = "Remarks";
            this.dvRemarks.HeaderText = "备注";
            this.dvRemarks.Name = "dvRemarks";
            this.dvRemarks.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvRemarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品列表";
            this.Load += new System.EventHandler(this.FormProductList_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dvCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvShopId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvProductTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvStockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvQRode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvCreateUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvCreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvLastOperationUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvLastOperationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvRemarks;
    }
}