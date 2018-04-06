namespace Foot.Client
{
    partial class FrmProductEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductEdit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStockQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.txtQRode = new System.Windows.Forms.TextBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockQuantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStockQuantity);
            this.groupBox1.Controls.Add(this.cmbProductType);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.txtQRode);
            this.groupBox1.Controls.Add(this.txtCostPrice);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息";
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtStockQuantity.Location = new System.Drawing.Point(255, 120);
            this.txtStockQuantity.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(120, 21);
            this.txtStockQuantity.TabIndex = 5;
            this.txtStockQuantity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtStockQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockQuantity_KeyPress);
            // 
            // cmbProductType
            // 
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(88, 76);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(100, 20);
            this.cmbProductType.TabIndex = 2;
            // 
            // txtQRode
            // 
            this.txtQRode.Location = new System.Drawing.Point(88, 161);
            this.txtQRode.MaxLength = 5;
            this.txtQRode.Multiline = true;
            this.txtQRode.Name = "txtQRode";
            this.txtQRode.Size = new System.Drawing.Size(283, 40);
            this.txtQRode.TabIndex = 6;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(255, 76);
            this.txtCostPrice.MaxLength = 5;
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(116, 21);
            this.txtCostPrice.TabIndex = 3;
            this.txtCostPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostPrice_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(88, 120);
            this.txtPrice.MaxLength = 5;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostPrice_KeyPress);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(88, 39);
            this.txtProductName.MaxLength = 19;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(283, 21);
            this.txtProductName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "条码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "库存量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "成本价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "销售价：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClean);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(6, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 47);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(235, 16);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "取消";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(88, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "确认";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "备注";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(88, 223);
            this.txtRemarks.MaxLength = 5;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(283, 40);
            this.txtRemarks.TabIndex = 6;
            // 
            // FrmProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProductEdit";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加/修改商品";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockQuantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQRode;
        private System.Windows.Forms.NumericUpDown txtStockQuantity;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label5;
    }
}