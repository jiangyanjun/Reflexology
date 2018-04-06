namespace Foot.Client
{
    partial class Frm_Yuding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Yuding));
            this.but_chaxun = new System.Windows.Forms.Button();
            this.TB_Id = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.lblTName = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.but_Open = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_xiugai = new System.Windows.Forms.Button();
            this.but_Add = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.开单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LV_info = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_chaxun
            // 
            this.but_chaxun.Image = ((System.Drawing.Image)(resources.GetObject("but_chaxun.Image")));
            this.but_chaxun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_chaxun.Location = new System.Drawing.Point(431, 20);
            this.but_chaxun.Name = "but_chaxun";
            this.but_chaxun.Size = new System.Drawing.Size(56, 25);
            this.but_chaxun.TabIndex = 4;
            this.but_chaxun.Text = "刷新";
            this.but_chaxun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_chaxun.UseVisualStyleBackColor = true;
            this.but_chaxun.Click += new System.EventHandler(this.but_chaxun_Click);
            // 
            // TB_Id
            // 
            this.TB_Id.Location = new System.Drawing.Point(331, 20);
            this.TB_Id.Name = "TB_Id";
            this.TB_Id.Size = new System.Drawing.Size(66, 21);
            this.TB_Id.TabIndex = 3;
            this.TB_Id.TextChanged += new System.EventHandler(this.TB_Id_TextChanged);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(129, 20);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 21);
            this.TB_Name.TabIndex = 0;
            this.TB_Name.TextChanged += new System.EventHandler(this.TB_Name_TextChanged);
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.Location = new System.Drawing.Point(266, 24);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(59, 12);
            this.lblTName.TabIndex = 1;
            this.lblTName.Text = "T台编号:";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(64, 24);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(59, 12);
            this.lblCName.TabIndex = 0;
            this.lblCName.Text = "宾客姓名:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_Name);
            this.groupBox1.Controls.Add(this.lblCName);
            this.groupBox1.Controls.Add(this.but_chaxun);
            this.groupBox1.Controls.Add(this.lblTName);
            this.groupBox1.Controls.Add(this.TB_Id);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速查询";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.but_Open);
            this.groupBox3.Controls.Add(this.but_del);
            this.groupBox3.Controls.Add(this.but_xiugai);
            this.groupBox3.Controls.Add(this.but_Add);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(20, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 61);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // but_Open
            // 
            this.but_Open.Location = new System.Drawing.Point(407, 19);
            this.but_Open.Name = "but_Open";
            this.but_Open.Size = new System.Drawing.Size(63, 23);
            this.but_Open.TabIndex = 8;
            this.but_Open.Text = "预定开单";
            this.but_Open.UseVisualStyleBackColor = true;
            this.but_Open.Click += new System.EventHandler(this.but_Open_Click);
            // 
            // but_del
            // 
            this.but_del.Location = new System.Drawing.Point(285, 19);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(63, 23);
            this.but_del.TabIndex = 7;
            this.but_del.Text = "删除预定";
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // but_xiugai
            // 
            this.but_xiugai.Location = new System.Drawing.Point(163, 19);
            this.but_xiugai.Name = "but_xiugai";
            this.but_xiugai.Size = new System.Drawing.Size(63, 23);
            this.but_xiugai.TabIndex = 6;
            this.but_xiugai.Text = "修改预定";
            this.but_xiugai.UseVisualStyleBackColor = true;
            this.but_xiugai.Click += new System.EventHandler(this.but_xiugai_Click);
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(41, 19);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(63, 23);
            this.but_Add.TabIndex = 5;
            this.but_Add.Text = "增加预定";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开单ToolStripMenuItem,
            this.增加ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 92);
            // 
            // 开单ToolStripMenuItem
            // 
            this.开单ToolStripMenuItem.Name = "开单ToolStripMenuItem";
            this.开单ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.开单ToolStripMenuItem.Text = "开单";
            this.开单ToolStripMenuItem.ToolTipText = "开单";
            this.开单ToolStripMenuItem.Click += new System.EventHandler(this.开单ToolStripMenuItem_Click);
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.增加ToolStripMenuItem.Text = "增加";
            this.增加ToolStripMenuItem.ToolTipText = "增加";
            this.增加ToolStripMenuItem.Click += new System.EventHandler(this.增加ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.ToolTipText = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.ToolTipText = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // LV_info
            // 
            this.LV_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LV_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_info.FullRowSelect = true;
            this.LV_info.GridLines = true;
            this.LV_info.Location = new System.Drawing.Point(20, 76);
            this.LV_info.MultiSelect = false;
            this.LV_info.Name = "LV_info";
            this.LV_info.Size = new System.Drawing.Size(512, 296);
            this.LV_info.TabIndex = 10;
            this.LV_info.UseCompatibleStateImageBehavior = false;
            this.LV_info.View = System.Windows.Forms.View.Details;
            this.LV_info.DoubleClick += new System.EventHandler(this.LV_info_DoubleClick);
            this.LV_info.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LV_info_MouseDoubleClick_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "宾客姓名";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "联系电话";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "T台类型";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "T台名称";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "预抵时间";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "备注";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 80;
            // 
            // Frm_Yuding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(552, 453);
            this.Controls.Add(this.LV_info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Yuding";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预定信息管理";
            this.Activated += new System.EventHandler(this.Frm_Yuding_Activated);
            this.Load += new System.EventHandler(this.Frm_Yuding_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_chaxun;
        private System.Windows.Forms.TextBox TB_Id;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label lblTName;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button but_Open;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_xiugai;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ListView LV_info;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}