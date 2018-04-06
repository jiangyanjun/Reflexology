namespace Foot.Client
{
    partial class Frm_stockCG
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_stockCG));
            this.CMS_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMenus = new System.Windows.Forms.GroupBox();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.but_Add = new System.Windows.Forms.Button();
            this.lblMNum = new System.Windows.Forms.Label();
            this.TB_Num = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.lv_spqd = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbAllm = new System.Windows.Forms.GroupBox();
            this.CMS_xiugai = new System.Windows.Forms.ToolStripMenuItem();
            this.gpMenus = new System.Windows.Forms.GroupBox();
            this.but_Del = new System.Windows.Forms.Button();
            this.but_xiugai = new System.Windows.Forms.Button();
            this.but_OK = new System.Windows.Forms.Button();
            this.CMS_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSRemark = new System.Windows.Forms.Label();
            this.TB_Money = new System.Windows.Forms.TextBox();
            this.TB_BZ = new System.Windows.Forms.TextBox();
            this.gbPay = new System.Windows.Forms.GroupBox();
            this.CB_Name = new System.Windows.Forms.ComboBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblSMoney = new System.Windows.Forms.Label();
            this.CB_Ghs = new System.Windows.Forms.ComboBox();
            this.lblFS = new System.Windows.Forms.Label();
            this.LB_jhdh = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_info = new System.Windows.Forms.ListView();
            this.gbSBL = new System.Windows.Forms.GroupBox();
            this.gbMenus.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gbAllm.SuspendLayout();
            this.gpMenus.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.gbPay.SuspendLayout();
            this.gbSBL.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMS_Add
            // 
            this.CMS_Add.Name = "CMS_Add";
            this.CMS_Add.Size = new System.Drawing.Size(124, 22);
            this.CMS_Add.Text = "增加商品";
            this.CMS_Add.Click += new System.EventHandler(this.CMS_Add_Click);
            // 
            // gbMenus
            // 
            this.gbMenus.Controls.Add(this.TB_Price);
            this.gbMenus.Controls.Add(this.lblMP);
            this.gbMenus.Controls.Add(this.lblMName);
            this.gbMenus.Controls.Add(this.but_Add);
            this.gbMenus.Controls.Add(this.lblMNum);
            this.gbMenus.Controls.Add(this.TB_Num);
            this.gbMenus.Controls.Add(this.TB_Name);
            this.gbMenus.Location = new System.Drawing.Point(12, 12);
            this.gbMenus.Name = "gbMenus";
            this.gbMenus.Size = new System.Drawing.Size(344, 137);
            this.gbMenus.TabIndex = 17;
            this.gbMenus.TabStop = false;
            this.gbMenus.Text = "商品信息";
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(83, 60);
            this.TB_Price.MaxLength = 9;
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(145, 21);
            this.TB_Price.TabIndex = 6;
            this.TB_Price.TextChanged += new System.EventHandler(this.TB_Price_TextChanged);
            this.TB_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            this.TB_Price.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Price_Validating);
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Location = new System.Drawing.Point(18, 64);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(59, 12);
            this.lblMP.TabIndex = 5;
            this.lblMP.Text = "商品进价:";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(18, 31);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(59, 12);
            this.lblMName.TabIndex = 0;
            this.lblMName.Text = "商品名称:";
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(254, 96);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(52, 23);
            this.but_Add.TabIndex = 4;
            this.but_Add.Text = "增加";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // lblMNum
            // 
            this.lblMNum.AutoSize = true;
            this.lblMNum.Location = new System.Drawing.Point(18, 100);
            this.lblMNum.Name = "lblMNum";
            this.lblMNum.Size = new System.Drawing.Size(59, 12);
            this.lblMNum.TabIndex = 1;
            this.lblMNum.Text = "进货数量:";
            // 
            // TB_Num
            // 
            this.TB_Num.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Num.Location = new System.Drawing.Point(83, 96);
            this.TB_Num.MaxLength = 10;
            this.TB_Num.Name = "TB_Num";
            this.TB_Num.Size = new System.Drawing.Size(75, 21);
            this.TB_Num.TabIndex = 3;
            this.TB_Num.Text = "1";
            this.TB_Num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Num_KeyPress);
            this.TB_Num.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Num_Validating);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(83, 27);
            this.TB_Name.MaxLength = 19;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(223, 21);
            this.TB_Name.TabIndex = 0;
            this.TB_Name.TextChanged += new System.EventHandler(this.TB_Name_TextChanged);
            // 
            // lv_spqd
            // 
            this.lv_spqd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_spqd.ContextMenuStrip = this.contextMenuStrip1;
            this.lv_spqd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_spqd.FullRowSelect = true;
            this.lv_spqd.GridLines = true;
            this.lv_spqd.Location = new System.Drawing.Point(3, 17);
            this.lv_spqd.Name = "lv_spqd";
            this.lv_spqd.Size = new System.Drawing.Size(338, 420);
            this.lv_spqd.TabIndex = 2;
            this.lv_spqd.UseCompatibleStateImageBehavior = false;
            this.lv_spqd.View = System.Windows.Forms.View.Details;
            this.lv_spqd.Click += new System.EventHandler(this.lv_spqd_Click);
            this.lv_spqd.DoubleClick += new System.EventHandler(this.lv_spqd_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名称";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "进价";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "当前库存";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 78;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_Add});
            this.contextMenuStrip1.Name = "cmsMenus";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // gbAllm
            // 
            this.gbAllm.Controls.Add(this.lv_spqd);
            this.gbAllm.Location = new System.Drawing.Point(12, 158);
            this.gbAllm.Name = "gbAllm";
            this.gbAllm.Size = new System.Drawing.Size(344, 440);
            this.gbAllm.TabIndex = 20;
            this.gbAllm.TabStop = false;
            this.gbAllm.Text = "商品清单";
            // 
            // CMS_xiugai
            // 
            this.CMS_xiugai.Name = "CMS_xiugai";
            this.CMS_xiugai.Size = new System.Drawing.Size(124, 22);
            this.CMS_xiugai.Text = "修改商品";
            this.CMS_xiugai.Click += new System.EventHandler(this.CMS_xiugai_Click);
            // 
            // gpMenus
            // 
            this.gpMenus.Controls.Add(this.but_Del);
            this.gpMenus.Controls.Add(this.but_xiugai);
            this.gpMenus.Controls.Add(this.but_OK);
            this.gpMenus.Location = new System.Drawing.Point(401, 514);
            this.gpMenus.Name = "gpMenus";
            this.gpMenus.Size = new System.Drawing.Size(469, 69);
            this.gpMenus.TabIndex = 21;
            this.gpMenus.TabStop = false;
            this.gpMenus.Text = "菜　单";
            // 
            // but_Del
            // 
            this.but_Del.Location = new System.Drawing.Point(306, 31);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(75, 23);
            this.but_Del.TabIndex = 2;
            this.but_Del.Text = "删除";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // but_xiugai
            // 
            this.but_xiugai.Location = new System.Drawing.Point(180, 31);
            this.but_xiugai.Name = "but_xiugai";
            this.but_xiugai.Size = new System.Drawing.Size(75, 23);
            this.but_xiugai.TabIndex = 1;
            this.but_xiugai.Text = "修改";
            this.but_xiugai.UseVisualStyleBackColor = true;
            this.but_xiugai.Click += new System.EventHandler(this.but_xiugai_Click);
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(42, 31);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 23);
            this.but_OK.TabIndex = 0;
            this.but_OK.Text = "确认";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // CMS_Del
            // 
            this.CMS_Del.Name = "CMS_Del";
            this.CMS_Del.Size = new System.Drawing.Size(124, 22);
            this.CMS_Del.Text = "删除商品";
            this.CMS_Del.Click += new System.EventHandler(this.CMS_Del_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_Del,
            this.CMS_xiugai});
            this.contextMenuStrip2.Name = "cmsBillLists";
            this.contextMenuStrip2.Size = new System.Drawing.Size(125, 48);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "备注";
            this.columnHeader9.Width = 160;
            // 
            // lblSRemark
            // 
            this.lblSRemark.AutoSize = true;
            this.lblSRemark.Location = new System.Drawing.Point(28, 100);
            this.lblSRemark.Name = "lblSRemark";
            this.lblSRemark.Size = new System.Drawing.Size(59, 12);
            this.lblSRemark.TabIndex = 16;
            this.lblSRemark.Text = "进货备注:";
            // 
            // TB_Money
            // 
            this.TB_Money.Enabled = false;
            this.TB_Money.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Money.Location = new System.Drawing.Point(338, 60);
            this.TB_Money.Name = "TB_Money";
            this.TB_Money.Size = new System.Drawing.Size(88, 21);
            this.TB_Money.TabIndex = 15;
            this.TB_Money.Text = "0";
            // 
            // TB_BZ
            // 
            this.TB_BZ.Location = new System.Drawing.Point(93, 97);
            this.TB_BZ.Name = "TB_BZ";
            this.TB_BZ.Size = new System.Drawing.Size(397, 21);
            this.TB_BZ.TabIndex = 17;
            this.TB_BZ.Text = "无";
            // 
            // gbPay
            // 
            this.gbPay.Controls.Add(this.TB_BZ);
            this.gbPay.Controls.Add(this.lblSRemark);
            this.gbPay.Controls.Add(this.TB_Money);
            this.gbPay.Controls.Add(this.CB_Name);
            this.gbPay.Controls.Add(this.lblE);
            this.gbPay.Controls.Add(this.lblSMoney);
            this.gbPay.Controls.Add(this.CB_Ghs);
            this.gbPay.Controls.Add(this.lblFS);
            this.gbPay.Controls.Add(this.LB_jhdh);
            this.gbPay.Controls.Add(this.lblS);
            this.gbPay.Location = new System.Drawing.Point(388, 12);
            this.gbPay.Name = "gbPay";
            this.gbPay.Size = new System.Drawing.Size(502, 137);
            this.gbPay.TabIndex = 18;
            this.gbPay.TabStop = false;
            this.gbPay.Text = "采购进货单";
            // 
            // CB_Name
            // 
            this.CB_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Name.FormattingEnabled = true;
            this.CB_Name.Location = new System.Drawing.Point(93, 60);
            this.CB_Name.Name = "CB_Name";
            this.CB_Name.Size = new System.Drawing.Size(88, 20);
            this.CB_Name.TabIndex = 14;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(28, 64);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(59, 12);
            this.lblE.TabIndex = 13;
            this.lblE.Text = "采 购 员:";
            // 
            // lblSMoney
            // 
            this.lblSMoney.AutoSize = true;
            this.lblSMoney.Location = new System.Drawing.Point(269, 64);
            this.lblSMoney.Name = "lblSMoney";
            this.lblSMoney.Size = new System.Drawing.Size(59, 12);
            this.lblSMoney.TabIndex = 12;
            this.lblSMoney.Text = "进货金额:";
            // 
            // CB_Ghs
            // 
            this.CB_Ghs.FormattingEnabled = true;
            this.CB_Ghs.Items.AddRange(new object[] {
            "PIT"});
            this.CB_Ghs.Location = new System.Drawing.Point(338, 24);
            this.CB_Ghs.Name = "CB_Ghs";
            this.CB_Ghs.Size = new System.Drawing.Size(152, 20);
            this.CB_Ghs.TabIndex = 11;
            // 
            // lblFS
            // 
            this.lblFS.AutoSize = true;
            this.lblFS.Location = new System.Drawing.Point(269, 28);
            this.lblFS.Name = "lblFS";
            this.lblFS.Size = new System.Drawing.Size(59, 12);
            this.lblFS.TabIndex = 6;
            this.lblFS.Text = "供 货 商:";
            // 
            // LB_jhdh
            // 
            this.LB_jhdh.AutoSize = true;
            this.LB_jhdh.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_jhdh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LB_jhdh.Location = new System.Drawing.Point(93, 25);
            this.LB_jhdh.Name = "LB_jhdh";
            this.LB_jhdh.Size = new System.Drawing.Size(75, 19);
            this.LB_jhdh.TabIndex = 5;
            this.LB_jhdh.Text = "lblSId";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(28, 28);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(59, 12);
            this.lblS.TabIndex = 4;
            this.lblS.Text = "进货单号:";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "进货商品";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "进价";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "数量";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "金额";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 70;
            // 
            // LV_info
            // 
            this.LV_info.AllowDrop = true;
            this.LV_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.LV_info.ContextMenuStrip = this.contextMenuStrip2;
            this.LV_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_info.FullRowSelect = true;
            this.LV_info.GridLines = true;
            this.LV_info.Location = new System.Drawing.Point(3, 17);
            this.LV_info.MultiSelect = false;
            this.LV_info.Name = "LV_info";
            this.LV_info.Size = new System.Drawing.Size(499, 318);
            this.LV_info.TabIndex = 6;
            this.LV_info.UseCompatibleStateImageBehavior = false;
            this.LV_info.View = System.Windows.Forms.View.Details;
            // 
            // gbSBL
            // 
            this.gbSBL.Controls.Add(this.LV_info);
            this.gbSBL.Location = new System.Drawing.Point(401, 155);
            this.gbSBL.Name = "gbSBL";
            this.gbSBL.Size = new System.Drawing.Size(505, 338);
            this.gbSBL.TabIndex = 19;
            this.gbSBL.TabStop = false;
            this.gbSBL.Text = "采购进货明细";
            // 
            // Frm_stockCG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(920, 610);
            this.Controls.Add(this.gbMenus);
            this.Controls.Add(this.gbPay);
            this.Controls.Add(this.gbSBL);
            this.Controls.Add(this.gbAllm);
            this.Controls.Add(this.gpMenus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_stockCG";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购信息";
            this.Activated += new System.EventHandler(this.Frm_stockCG_Activated);
            this.Load += new System.EventHandler(this.Frm_stockCG_Load);
            this.gbMenus.ResumeLayout(false);
            this.gbMenus.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbAllm.ResumeLayout(false);
            this.gpMenus.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.gbPay.ResumeLayout(false);
            this.gbPay.PerformLayout();
            this.gbSBL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem CMS_Add;
        private System.Windows.Forms.GroupBox gbMenus;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Label lblMNum;
        private System.Windows.Forms.TextBox TB_Num;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.ListView lv_spqd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gbAllm;
        private System.Windows.Forms.ToolStripMenuItem CMS_xiugai;
        private System.Windows.Forms.GroupBox gpMenus;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.Button but_xiugai;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.ToolStripMenuItem CMS_Del;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label lblSRemark;
        private System.Windows.Forms.TextBox TB_Money;
        private System.Windows.Forms.TextBox TB_BZ;
        private System.Windows.Forms.GroupBox gbPay;
        private System.Windows.Forms.ComboBox CB_Name;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblSMoney;
        private System.Windows.Forms.ComboBox CB_Ghs;
        private System.Windows.Forms.Label lblFS;
        private System.Windows.Forms.Label LB_jhdh;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView LV_info;
        private System.Windows.Forms.GroupBox gbSBL;

    }
}