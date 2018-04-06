namespace Foot.Client
{
    partial class Frm_Waiter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Waiter));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CB_ID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_zhiwu = new System.Windows.Forms.ComboBox();
            this.but_xianshi = new System.Windows.Forms.Button();
            this.DGV_info = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_Del = new System.Windows.Forms.Button();
            this.but_xiugai = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_info)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CB_ID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TB_Name);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.CB_zhiwu);
            this.groupBox3.Controls.Add(this.but_xianshi);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 76);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询";
            // 
            // CB_ID
            // 
            this.CB_ID.FormattingEnabled = true;
            this.CB_ID.Location = new System.Drawing.Point(77, 29);
            this.CB_ID.Name = "CB_ID";
            this.CB_ID.Size = new System.Drawing.Size(84, 20);
            this.CB_ID.TabIndex = 1;
            this.CB_ID.TextChanged += new System.EventHandler(this.CB_ID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "员工编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "员工职务：";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(246, 29);
            this.TB_Name.MaxLength = 26;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 21);
            this.TB_Name.TabIndex = 2;
            this.TB_Name.TextChanged += new System.EventHandler(this.TB_Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "员工姓名：";
            // 
            // CB_zhiwu
            // 
            this.CB_zhiwu.FormattingEnabled = true;
            this.CB_zhiwu.Location = new System.Drawing.Point(441, 31);
            this.CB_zhiwu.MaxLength = 3;
            this.CB_zhiwu.Name = "CB_zhiwu";
            this.CB_zhiwu.Size = new System.Drawing.Size(101, 20);
            this.CB_zhiwu.TabIndex = 3;
            this.CB_zhiwu.TextChanged += new System.EventHandler(this.CB_zhiwu_TextChanged);
            // 
            // but_xianshi
            // 
            this.but_xianshi.Location = new System.Drawing.Point(573, 29);
            this.but_xianshi.Name = "but_xianshi";
            this.but_xianshi.Size = new System.Drawing.Size(75, 23);
            this.but_xianshi.TabIndex = 2;
            this.but_xianshi.Text = "显示全部";
            this.but_xianshi.UseVisualStyleBackColor = true;
            this.but_xianshi.Click += new System.EventHandler(this.but_xianshi_Click);
            // 
            // DGV_info
            // 
            this.DGV_info.AllowUserToAddRows = false;
            this.DGV_info.AllowUserToDeleteRows = false;
            this.DGV_info.AllowUserToResizeRows = false;
            this.DGV_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_info.ColumnHeadersHeight = 20;
            this.DGV_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column10});
            this.DGV_info.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_info.Location = new System.Drawing.Point(3, 17);
            this.DGV_info.Name = "DGV_info";
            this.DGV_info.ReadOnly = true;
            this.DGV_info.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_info.RowHeadersVisible = false;
            this.DGV_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_info.RowTemplate.Height = 23;
            this.DGV_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_info.Size = new System.Drawing.Size(682, 187);
            this.DGV_info.TabIndex = 0;
            this.DGV_info.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Waiter_CellDoubleClick);
            this.DGV_info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DGV_info_MouseDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Waiter_ID";
            this.Column1.HeaderText = "员工编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Waiter_Nmae";
            this.Column2.HeaderText = "员工姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Waiter_Sex";
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Waiter_Age";
            this.Column4.HeaderText = "年龄";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Duty_Name";
            this.Column7.HeaderText = "职务";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Waiter_Phone";
            this.Column5.HeaderText = "员工电话";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Waiter_birthday";
            this.Column6.HeaderText = "员工生日";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Waiter_IDCard";
            this.Column8.HeaderText = "身份证号码";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Waiter_Address";
            this.Column9.HeaderText = "家庭住址";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 90;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Beizhu";
            this.Column10.HeaderText = "备注";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 90;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem1.Text = "增加";
            this.toolStripMenuItem1.ToolTipText = "增加";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem2.Text = "修改";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem3.Text = "删除";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_info);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_Del);
            this.groupBox2.Controls.Add(this.but_xiugai);
            this.groupBox2.Controls.Add(this.but_add);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 98);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // but_Del
            // 
            this.but_Del.Location = new System.Drawing.Point(441, 41);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(75, 23);
            this.but_Del.TabIndex = 2;
            this.but_Del.Text = "删除员工";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // but_xiugai
            // 
            this.but_xiugai.Location = new System.Drawing.Point(290, 41);
            this.but_xiugai.Name = "but_xiugai";
            this.but_xiugai.Size = new System.Drawing.Size(75, 23);
            this.but_xiugai.TabIndex = 1;
            this.but_xiugai.Text = "修改员工";
            this.but_xiugai.UseVisualStyleBackColor = true;
            this.but_xiugai.Click += new System.EventHandler(this.but_xiugai_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(139, 41);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 0;
            this.but_add.Text = "增加员工";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // Frm_Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(688, 384);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Waiter";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息";
            this.Activated += new System.EventHandler(this.Frm_Waiter_Activated);
            this.Load += new System.EventHandler(this.Frm_Waiter_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_info)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV_info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_xianshi;
        private System.Windows.Forms.ComboBox CB_zhiwu;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.Button but_xiugai;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ComboBox CB_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}