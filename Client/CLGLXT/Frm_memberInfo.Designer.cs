namespace Foot.Client
{
    partial class Frm_memberInfo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_memberInfo));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_info = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.but_Del = new System.Windows.Forms.Button();
            this.but_xiugai = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.CB_ID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_dengji = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_xianshi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_info)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_info);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 227);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "会员信息";
            // 
            // DGV_info
            // 
            this.DGV_info.AllowUserToAddRows = false;
            this.DGV_info.AllowUserToDeleteRows = false;
            this.DGV_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DGV_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_info.ColumnHeadersHeight = 20;
            this.DGV_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column11,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
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
            this.DGV_info.Size = new System.Drawing.Size(682, 207);
            this.DGV_info.TabIndex = 0;
            this.DGV_info.TabStop = false;
            this.DGV_info.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_info_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "member_ID";
            this.Column1.HeaderText = "会员编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "member_Name";
            this.Column2.HeaderText = "会员姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "member_Sex";
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Mt_Name";
            this.Column4.HeaderText = "会员等级";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Member_djrq";
            this.Column9.HeaderText = "开通时间";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 70;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "member_type";
            this.Column11.HeaderText = "状态";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "member_Phone";
            this.Column5.HeaderText = "会员电话";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Member_birthday";
            this.Column6.HeaderText = "会员生日";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "member_JF";
            this.Column7.HeaderText = "积分";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "member_IDCard";
            this.Column8.HeaderText = "身份证号码";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Beizhu";
            this.Column10.HeaderText = "备注";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItem1.Text = "增加";
            this.toolStripMenuItem1.ToolTipText = "增加";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItem2.Text = "修改";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItem3.Text = "删除";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // but_Del
            // 
            this.but_Del.Location = new System.Drawing.Point(387, 31);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(75, 23);
            this.but_Del.TabIndex = 7;
            this.but_Del.Text = "删除会员";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // but_xiugai
            // 
            this.but_xiugai.Location = new System.Drawing.Point(236, 31);
            this.but_xiugai.Name = "but_xiugai";
            this.but_xiugai.Size = new System.Drawing.Size(75, 23);
            this.but_xiugai.TabIndex = 6;
            this.but_xiugai.Text = "修改会员";
            this.but_xiugai.UseVisualStyleBackColor = true;
            this.but_xiugai.Click += new System.EventHandler(this.but_xiugai_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(85, 31);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 5;
            this.but_add.Text = "增加会员";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "会员等级：";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(255, 31);
            this.TB_Name.MaxLength = 29;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(78, 21);
            this.TB_Name.TabIndex = 1;
            this.TB_Name.TextChanged += new System.EventHandler(this.TB_Name_TextChanged);
            // 
            // CB_ID
            // 
            this.CB_ID.FormattingEnabled = true;
            this.CB_ID.Location = new System.Drawing.Point(93, 31);
            this.CB_ID.MaxLength = 10;
            this.CB_ID.Name = "CB_ID";
            this.CB_ID.Size = new System.Drawing.Size(94, 20);
            this.CB_ID.TabIndex = 0;
            this.CB_ID.SelectedValueChanged += new System.EventHandler(this.CB_ID_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "会员编号：";
            // 
            // CB_dengji
            // 
            this.CB_dengji.FormattingEnabled = true;
            this.CB_dengji.Location = new System.Drawing.Point(414, 31);
            this.CB_dengji.MaxLength = 19;
            this.CB_dengji.Name = "CB_dengji";
            this.CB_dengji.Size = new System.Drawing.Size(106, 20);
            this.CB_dengji.TabIndex = 2;
            this.CB_dengji.SelectedValueChanged += new System.EventHandler(this.CB_dengji_SelectedValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CB_ID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TB_Name);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.CB_dengji);
            this.groupBox3.Controls.Add(this.but_xianshi);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "会员姓名：";
            // 
            // but_xianshi
            // 
            this.but_xianshi.Image = ((System.Drawing.Image)(resources.GetObject("but_xianshi.Image")));
            this.but_xianshi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_xianshi.Location = new System.Drawing.Point(544, 30);
            this.but_xianshi.Name = "but_xianshi";
            this.but_xianshi.Size = new System.Drawing.Size(75, 23);
            this.but_xianshi.TabIndex = 4;
            this.but_xianshi.Text = "显示全部";
            this.but_xianshi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_xianshi.UseVisualStyleBackColor = true;
            this.but_xianshi.Click += new System.EventHandler(this.but_xianshi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_Del);
            this.groupBox1.Controls.Add(this.but_add);
            this.groupBox1.Controls.Add(this.but_xiugai);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Frm_memberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Frm_memberInfo";
            this.Size = new System.Drawing.Size(688, 402);
            this.Load += new System.EventHandler(this.Frm_member_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_info)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.Button but_xiugai;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox CB_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox CB_dengji;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_xianshi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView DGV_info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
