namespace Foot.Client
{
    partial class Frm_XF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_XF));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_spinfo = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LV_xfinfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.顾客退菜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but_OK = new System.Windows.Forms.Button();
            this.but_Del = new System.Windows.Forms.Button();
            this.but_Close = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbMenus = new System.Windows.Forms.GroupBox();
            this.lblMName = new System.Windows.Forms.Label();
            this.but_Add = new System.Windows.Forms.Button();
            this.lblMNum = new System.Windows.Forms.Label();
            this.TB_Num = new System.Windows.Forms.TextBox();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_spinfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜品信息";
            // 
            // lv_spinfo
            // 
            this.lv_spinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lv_spinfo.ContextMenuStrip = this.contextMenuStrip2;
            this.lv_spinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_spinfo.FullRowSelect = true;
            this.lv_spinfo.GridLines = true;
            this.lv_spinfo.Location = new System.Drawing.Point(3, 17);
            this.lv_spinfo.Name = "lv_spinfo";
            this.lv_spinfo.Size = new System.Drawing.Size(264, 316);
            this.lv_spinfo.TabIndex = 0;
            this.lv_spinfo.UseCompatibleStateImageBehavior = false;
            this.lv_spinfo.View = System.Windows.Forms.View.Details;
            this.lv_spinfo.Click += new System.EventHandler(this.lv_spinfo_Click);
            this.lv_spinfo.DoubleClick += new System.EventHandler(this.lv_spinfo_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "编号";
            this.columnHeader6.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "菜品名称";
            this.columnHeader7.Width = 114;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "单价";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 45;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "库存";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 45;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(101, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem1.Text = "增加";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LV_xfinfo);
            this.groupBox2.Location = new System.Drawing.Point(309, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 325);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // LV_xfinfo
            // 
            this.LV_xfinfo.AllowColumnReorder = true;
            this.LV_xfinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LV_xfinfo.ContextMenuStrip = this.contextMenuStrip1;
            this.LV_xfinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_xfinfo.FullRowSelect = true;
            this.LV_xfinfo.GridLines = true;
            this.LV_xfinfo.Location = new System.Drawing.Point(3, 17);
            this.LV_xfinfo.Name = "LV_xfinfo";
            this.LV_xfinfo.Size = new System.Drawing.Size(369, 305);
            this.LV_xfinfo.TabIndex = 0;
            this.LV_xfinfo.UseCompatibleStateImageBehavior = false;
            this.LV_xfinfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名称";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "单价";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "数量";
            this.columnHeader3.Width = 47;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "总金额";
            this.columnHeader4.Width = 58;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "消费时间";
            this.columnHeader5.Width = 110;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顾客退菜ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 顾客退菜ToolStripMenuItem
            // 
            this.顾客退菜ToolStripMenuItem.Name = "顾客退菜ToolStripMenuItem";
            this.顾客退菜ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.顾客退菜ToolStripMenuItem.Text = "顾客退菜";
            this.顾客退菜ToolStripMenuItem.ToolTipText = "\r\n";
            this.顾客退菜ToolStripMenuItem.Click += new System.EventHandler(this.顾客退菜ToolStripMenuItem_Click);
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(42, 21);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 23);
            this.but_OK.TabIndex = 1;
            this.but_OK.Text = "确认";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // but_Del
            // 
            this.but_Del.Location = new System.Drawing.Point(150, 21);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(75, 23);
            this.but_Del.TabIndex = 2;
            this.but_Del.Text = "退菜";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // but_Close
            // 
            this.but_Close.Location = new System.Drawing.Point(258, 21);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(75, 23);
            this.but_Close.TabIndex = 3;
            this.but_Close.Text = "退出";
            this.but_Close.UseVisualStyleBackColor = true;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.but_OK);
            this.groupBox3.Controls.Add(this.but_Close);
            this.groupBox3.Controls.Add(this.but_Del);
            this.groupBox3.Location = new System.Drawing.Point(309, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 64);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // gbMenus
            // 
            this.gbMenus.Controls.Add(this.lblMName);
            this.gbMenus.Controls.Add(this.but_Add);
            this.gbMenus.Controls.Add(this.lblMNum);
            this.gbMenus.Controls.Add(this.TB_Num);
            this.gbMenus.Controls.Add(this.TB_name);
            this.gbMenus.Location = new System.Drawing.Point(12, 12);
            this.gbMenus.Name = "gbMenus";
            this.gbMenus.Size = new System.Drawing.Size(267, 92);
            this.gbMenus.TabIndex = 5;
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
            this.TB_Num.MaxLength = 11;
            this.TB_Num.Name = "TB_Num";
            this.TB_Num.Size = new System.Drawing.Size(75, 21);
            this.TB_Num.TabIndex = 3;
            this.TB_Num.Text = "1";
            this.TB_Num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Num_KeyPress);
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(89, 22);
            this.TB_name.MaxLength = 19;
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(75, 21);
            this.TB_name.TabIndex = 0;
            this.TB_name.TextChanged += new System.EventHandler(this.TB_name_TextChanged);
            // 
            // Frm_XF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(711, 461);
            this.Controls.Add(this.gbMenus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_XF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "消费";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_XF_FormClosing);
            this.Load += new System.EventHandler(this.Frm_XF_Load);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbMenus.ResumeLayout(false);
            this.gbMenus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LV_xfinfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lv_spinfo;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox gbMenus;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Label lblMNum;
        private System.Windows.Forms.TextBox TB_Num;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 顾客退菜ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}