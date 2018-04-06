namespace Foot.Client
{
    partial class Frm_Power
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("顾客开单");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("顾客点菜");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("顾客结账");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("前台销售");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("预定管理");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("营业查询");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("员工管理");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("商品管理");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("会员管理");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("重新登录");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("系统设置");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("数据备份/恢复");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Power));
            this.but_Close = new System.Windows.Forms.Button();
            this.but_OK = new System.Windows.Forms.Button();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Close
            // 
            this.but_Close.Location = new System.Drawing.Point(158, 327);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(75, 23);
            this.but_Close.TabIndex = 9;
            this.but_Close.Text = "取消";
            this.but_Close.UseVisualStyleBackColor = true;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(49, 327);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 23);
            this.but_OK.TabIndex = 8;
            this.but_OK.Text = "确认";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(118, 32);
            this.TB_Name.MaxLength = 19;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 21);
            this.TB_Name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "新增权限：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(42, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(216, 248);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "权限设置";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 19);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "顾客开单";
            treeNode2.Name = "节点1";
            treeNode2.Text = "顾客点菜";
            treeNode3.Name = "节点2";
            treeNode3.Text = "顾客结账";
            treeNode4.Name = "节点10";
            treeNode4.Text = "前台销售";
            treeNode5.Name = "节点7";
            treeNode5.Text = "预定管理";
            treeNode6.Name = "节点5";
            treeNode6.Text = "营业查询";
            treeNode7.Name = "节点11";
            treeNode7.Text = "员工管理";
            treeNode8.Name = "节点3";
            treeNode8.Text = "商品管理";
            treeNode9.Name = "节点4";
            treeNode9.Text = "会员管理";
            treeNode10.Name = "节点9";
            treeNode10.Text = "重新登录";
            treeNode11.Name = "节点6";
            treeNode11.Text = "系统设置";
            treeNode12.Name = "节点0";
            treeNode12.Text = "数据备份/恢复";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(210, 226);
            this.treeView1.TabIndex = 0;
            // 
            // Frm_Power
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(287, 381);
            this.Controls.Add(this.but_Close);
            this.Controls.Add(this.but_OK);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Power";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Power";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Power_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Power_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}