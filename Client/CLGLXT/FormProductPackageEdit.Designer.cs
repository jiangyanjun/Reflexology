namespace Foot.Client
{
    partial class FormProductPackageEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRams = new System.Windows.Forms.TextBox();
            this.rdDefault = new System.Windows.Forms.RadioButton();
            this.rdNotDefault = new System.Windows.Forms.RadioButton();
            this.lblPriceSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgPackageList = new System.Windows.Forms.DataGridView();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPackageList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "套餐名称：";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(83, 6);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(274, 21);
            this.txtPackageName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "条码：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(725, 21);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "是否默认套餐";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "总价：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "备注：";
            // 
            // txtRams
            // 
            this.txtRams.Location = new System.Drawing.Point(83, 69);
            this.txtRams.Multiline = true;
            this.txtRams.Name = "txtRams";
            this.txtRams.Size = new System.Drawing.Size(376, 56);
            this.txtRams.TabIndex = 1;
            // 
            // rdDefault
            // 
            this.rdDefault.AutoSize = true;
            this.rdDefault.Location = new System.Drawing.Point(446, 8);
            this.rdDefault.Name = "rdDefault";
            this.rdDefault.Size = new System.Drawing.Size(35, 16);
            this.rdDefault.TabIndex = 2;
            this.rdDefault.TabStop = true;
            this.rdDefault.Text = "否";
            this.rdDefault.UseVisualStyleBackColor = true;
            // 
            // rdNotDefault
            // 
            this.rdNotDefault.AutoSize = true;
            this.rdNotDefault.Location = new System.Drawing.Point(487, 8);
            this.rdNotDefault.Name = "rdNotDefault";
            this.rdNotDefault.Size = new System.Drawing.Size(35, 16);
            this.rdNotDefault.TabIndex = 2;
            this.rdNotDefault.TabStop = true;
            this.rdNotDefault.Text = "是";
            this.rdNotDefault.UseVisualStyleBackColor = true;
            // 
            // lblPriceSum
            // 
            this.lblPriceSum.AutoSize = true;
            this.lblPriceSum.Location = new System.Drawing.Point(512, 105);
            this.lblPriceSum.Name = "lblPriceSum";
            this.lblPriceSum.Size = new System.Drawing.Size(53, 12);
            this.lblPriceSum.TabIndex = 0;
            this.lblPriceSum.Text = "套餐原价";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "售价：";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(632, 75);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductAdd.TabIndex = 3;
            this.btnProductAdd.Text = "添加商品";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(733, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtPackageName);
            this.panel1.Controls.Add(this.btnProductAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdNotDefault);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.rdDefault);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRams);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblPriceSum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 128);
            this.panel1.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(512, 78);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(105, 21);
            this.txtPrice.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgPackageList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 283);
            this.panel2.TabIndex = 5;
            // 
            // dgPackageList
            // 
            this.dgPackageList.AllowUserToAddRows = false;
            this.dgPackageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPackageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgPackageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPackageList.Location = new System.Drawing.Point(0, 0);
            this.dgPackageList.Name = "dgPackageList";
            this.dgPackageList.ReadOnly = true;
            this.dgPackageList.Size = new System.Drawing.Size(910, 283);
            this.dgPackageList.TabIndex = 1;
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
            // FormProductPackageEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormProductPackageEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品套餐维护";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPackageList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRams;
        private System.Windows.Forms.RadioButton rdDefault;
        private System.Windows.Forms.RadioButton rdNotDefault;
        private System.Windows.Forms.Label lblPriceSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dgPackageList;
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