namespace Foot.Client
{
    partial class Frm_QTXS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QTXS));
            this.ssBillList = new System.Windows.Forms.StatusStrip();
            this.tslblBlank3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblMoney = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbPay = new System.Windows.Forms.GroupBox();
            this.LB_ZDH = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.but_JZ = new System.Windows.Forms.Button();
            this.but_Close = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.LV_xfinfo = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.tslblBlank1 = new System.Windows.Forms.ToolStripLabel();
            this.tslblMenu = new System.Windows.Forms.ToolStripLabel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_spinfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMenus = new System.Windows.Forms.GroupBox();
            this.lblMName = new System.Windows.Forms.Label();
            this.but_Add = new System.Windows.Forms.Button();
            this.lblMNum = new System.Windows.Forms.Label();
            this.TB_Num = new System.Windows.Forms.TextBox();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.imgTvMenu = new System.Windows.Forms.ImageList(this.components);
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.tslblBlank2 = new System.Windows.Forms.ToolStripLabel();
            this.tslblBillList = new System.Windows.Forms.ToolStripLabel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ssBillList.SuspendLayout();
            this.gbPay.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gbMenus.SuspendLayout();
            this.tsTop.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssBillList
            // 
            this.ssBillList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblBlank3,
            this.tsslblNum,
            this.tsslblMoney});
            this.ssBillList.Location = new System.Drawing.Point(0, 324);
            this.ssBillList.Name = "ssBillList";
            this.ssBillList.Size = new System.Drawing.Size(415, 22);
            this.ssBillList.TabIndex = 4;
            this.ssBillList.Text = "statusStrip1";
            // 
            // tslblBlank3
            // 
            this.tslblBlank3.Name = "tslblBlank3";
            this.tslblBlank3.Size = new System.Drawing.Size(276, 17);
            this.tslblBlank3.Text = "                                                                   ";
            // 
            // tsslblNum
            // 
            this.tsslblNum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslblNum.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslblNum.ForeColor = System.Drawing.Color.Red;
            this.tsslblNum.Name = "tsslblNum";
            this.tsslblNum.Size = new System.Drawing.Size(14, 17);
            this.tsslblNum.Text = "0";
            // 
            // tsslblMoney
            // 
            this.tsslblMoney.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslblMoney.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslblMoney.ForeColor = System.Drawing.Color.Red;
            this.tsslblMoney.Name = "tsslblMoney";
            this.tsslblMoney.Size = new System.Drawing.Size(31, 17);
            this.tsslblMoney.Text = "0.00";
            // 
            // gbPay
            // 
            this.gbPay.Controls.Add(this.LB_ZDH);
            this.gbPay.Controls.Add(this.lblT);
            this.gbPay.Controls.Add(this.but_JZ);
            this.gbPay.Controls.Add(this.but_Close);
            this.gbPay.Location = new System.Drawing.Point(18, 12);
            this.gbPay.Name = "gbPay";
            this.gbPay.Size = new System.Drawing.Size(391, 92);
            this.gbPay.TabIndex = 6;
            this.gbPay.TabStop = false;
            this.gbPay.Text = "宾客结账";
            // 
            // LB_ZDH
            // 
            this.LB_ZDH.AutoSize = true;
            this.LB_ZDH.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_ZDH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LB_ZDH.Location = new System.Drawing.Point(144, 22);
            this.LB_ZDH.Name = "LB_ZDH";
            this.LB_ZDH.Size = new System.Drawing.Size(75, 19);
            this.LB_ZDH.TabIndex = 5;
            this.LB_ZDH.Text = "lblTId";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(66, 26);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(59, 12);
            this.lblT.TabIndex = 4;
            this.lblT.Text = "销售单号:";
            // 
            // but_JZ
            // 
            this.but_JZ.Location = new System.Drawing.Point(50, 60);
            this.but_JZ.Name = "but_JZ";
            this.but_JZ.Size = new System.Drawing.Size(75, 23);
            this.but_JZ.TabIndex = 3;
            this.but_JZ.Text = "结账";
            this.but_JZ.UseVisualStyleBackColor = true;
            this.but_JZ.Click += new System.EventHandler(this.but_JZ_Click);
            // 
            // but_Close
            // 
            this.but_Close.Location = new System.Drawing.Point(206, 60);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(75, 23);
            this.but_Close.TabIndex = 2;
            this.but_Close.Text = "取消";
            this.but_Close.UseVisualStyleBackColor = true;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBottom.Controls.Add(this.ssBillList);
            this.pnlBottom.Controls.Add(this.LV_xfinfo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 134);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(419, 350);
            this.pnlBottom.TabIndex = 5;
            // 
            // LV_xfinfo
            // 
            this.LV_xfinfo.AllowDrop = true;
            this.LV_xfinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.LV_xfinfo.ContextMenuStrip = this.contextMenuStrip2;
            this.LV_xfinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_xfinfo.FullRowSelect = true;
            this.LV_xfinfo.GridLines = true;
            this.LV_xfinfo.Location = new System.Drawing.Point(0, 0);
            this.LV_xfinfo.MultiSelect = false;
            this.LV_xfinfo.Name = "LV_xfinfo";
            this.LV_xfinfo.Size = new System.Drawing.Size(415, 346);
            this.LV_xfinfo.TabIndex = 6;
            this.LV_xfinfo.UseCompatibleStateImageBehavior = false;
            this.LV_xfinfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "消费商品";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "单价";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "数量";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "金额";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "消费时间";
            this.columnHeader8.Width = 135;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_Del});
            this.contextMenuStrip2.Name = "cmsBillLists";
            this.contextMenuStrip2.Size = new System.Drawing.Size(125, 26);
            // 
            // CMS_Del
            // 
            this.CMS_Del.Name = "CMS_Del";
            this.CMS_Del.Size = new System.Drawing.Size(124, 22);
            this.CMS_Del.Text = "删除菜品";
            this.CMS_Del.Click += new System.EventHandler(this.CMS_Del_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRight.Controls.Add(this.gbPay);
            this.pnlRight.Controls.Add(this.pnlBottom);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(309, 25);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(423, 488);
            this.pnlRight.TabIndex = 11;
            // 
            // tslblBlank1
            // 
            this.tslblBlank1.Name = "tslblBlank1";
            this.tslblBlank1.Size = new System.Drawing.Size(112, 22);
            this.tslblBlank1.Text = "   　　                ";
            // 
            // tslblMenu
            // 
            this.tslblMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblMenu.Name = "tslblMenu";
            this.tslblMenu.Size = new System.Drawing.Size(40, 22);
            this.tslblMenu.Text = "菜单";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLeft.Controls.Add(this.groupBox1);
            this.pnlLeft.Controls.Add(this.gbMenus);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 25);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(309, 488);
            this.pnlLeft.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_spinfo);
            this.groupBox1.Location = new System.Drawing.Point(10, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品信息";
            // 
            // lv_spinfo
            // 
            this.lv_spinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9});
            this.lv_spinfo.ContextMenuStrip = this.contextMenuStrip1;
            this.lv_spinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_spinfo.FullRowSelect = true;
            this.lv_spinfo.GridLines = true;
            this.lv_spinfo.Location = new System.Drawing.Point(3, 17);
            this.lv_spinfo.Name = "lv_spinfo";
            this.lv_spinfo.Size = new System.Drawing.Size(285, 320);
            this.lv_spinfo.TabIndex = 0;
            this.lv_spinfo.UseCompatibleStateImageBehavior = false;
            this.lv_spinfo.View = System.Windows.Forms.View.Details;
            this.lv_spinfo.Click += new System.EventHandler(this.lv_spinfo_Click);
            this.lv_spinfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_spinfo_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "菜品名称";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "单价";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 45;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "库存";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 51;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_Add});
            this.contextMenuStrip1.Name = "cmsMenus";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // CMS_Add
            // 
            this.CMS_Add.Name = "CMS_Add";
            this.CMS_Add.Size = new System.Drawing.Size(124, 22);
            this.CMS_Add.Text = "增加菜品";
            this.CMS_Add.Click += new System.EventHandler(this.CMS_Add_Click);
            // 
            // gbMenus
            // 
            this.gbMenus.Controls.Add(this.lblMName);
            this.gbMenus.Controls.Add(this.but_Add);
            this.gbMenus.Controls.Add(this.lblMNum);
            this.gbMenus.Controls.Add(this.TB_Num);
            this.gbMenus.Controls.Add(this.TB_name);
            this.gbMenus.Location = new System.Drawing.Point(21, 12);
            this.gbMenus.Name = "gbMenus";
            this.gbMenus.Size = new System.Drawing.Size(264, 92);
            this.gbMenus.TabIndex = 0;
            this.gbMenus.TabStop = false;
            this.gbMenus.Text = "增加菜品";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(24, 26);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(59, 12);
            this.lblMName.TabIndex = 0;
            this.lblMName.Text = "消费菜品:";
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(187, 54);
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
            this.lblMNum.Location = new System.Drawing.Point(24, 60);
            this.lblMNum.Name = "lblMNum";
            this.lblMNum.Size = new System.Drawing.Size(59, 12);
            this.lblMNum.TabIndex = 1;
            this.lblMNum.Text = "消费数量:";
            // 
            // TB_Num
            // 
            this.TB_Num.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TB_Num.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Num.Location = new System.Drawing.Point(89, 56);
            this.TB_Num.MaxLength = 3;
            this.TB_Num.Name = "TB_Num";
            this.TB_Num.Size = new System.Drawing.Size(75, 21);
            this.TB_Num.TabIndex = 3;
            this.TB_Num.Text = "1";
            this.TB_Num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Num_KeyPress);
            this.TB_Num.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Num_Validating);
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(89, 22);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(75, 21);
            this.TB_name.TabIndex = 0;
            this.TB_name.TextChanged += new System.EventHandler(this.TB_name_TextChanged);
            // 
            // imgTvMenu
            // 
            this.imgTvMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTvMenu.ImageStream")));
            this.imgTvMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTvMenu.Images.SetKeyName(0, "g2.jpg");
            this.imgTvMenu.Images.SetKeyName(1, "g1.jpg");
            // 
            // tsTop
            // 
            this.tsTop.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tsTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblBlank1,
            this.tslblMenu,
            this.tslblBlank2,
            this.tslblBillList});
            this.tsTop.Location = new System.Drawing.Point(0, 0);
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(732, 25);
            this.tsTop.TabIndex = 0;
            this.tsTop.Text = "toolStrip1";
            // 
            // tslblBlank2
            // 
            this.tslblBlank2.Name = "tslblBlank2";
            this.tslblBlank2.Size = new System.Drawing.Size(354, 22);
            this.tslblBlank2.Text = "   　　　　　                                                                  ";
            // 
            // tslblBillList
            // 
            this.tslblBillList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslblBillList.Name = "tslblBillList";
            this.tslblBillList.Size = new System.Drawing.Size(72, 22);
            this.tslblBillList.Text = "消费明细";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.tsTop);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(732, 25);
            this.pnlTop.TabIndex = 9;
            // 
            // Frm_QTXS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(732, 513);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_QTXS";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "前台销售";
            this.Activated += new System.EventHandler(this.Frm_QTXS_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_QTXS_FormClosing);
            this.Load += new System.EventHandler(this.Frm_QTXS_Load);
            this.ssBillList.ResumeLayout(false);
            this.ssBillList.PerformLayout();
            this.gbPay.ResumeLayout(false);
            this.gbPay.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbMenus.ResumeLayout(false);
            this.gbMenus.PerformLayout();
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssBillList;
        private System.Windows.Forms.ToolStripStatusLabel tslblBlank3;
        private System.Windows.Forms.ToolStripStatusLabel tsslblNum;
        private System.Windows.Forms.ToolStripStatusLabel tsslblMoney;
        private System.Windows.Forms.GroupBox gbPay;
        private System.Windows.Forms.Label LB_ZDH;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Button but_JZ;
        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.Panel pnlBottom;
        public  System.Windows.Forms.ListView LV_xfinfo;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem CMS_Del;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.ToolStripLabel tslblBlank1;
        private System.Windows.Forms.ToolStripLabel tslblMenu;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.GroupBox gbMenus;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Label lblMNum;
        private System.Windows.Forms.TextBox TB_Num;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.ListView lv_spinfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CMS_Add;
        private System.Windows.Forms.ImageList imgTvMenu;
        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.ToolStripLabel tslblBlank2;
        private System.Windows.Forms.ToolStripLabel tslblBillList;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}