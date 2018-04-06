namespace Foot.Client
{
    partial class Frm_memberXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_memberXF));
            this.DGV_info = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.but_cx = new System.Windows.Forms.Button();
            this.CB_Name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_ID = new System.Windows.Forms.ComboBox();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.LV_info = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_info)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_info
            // 
            this.DGV_info.AllowUserToAddRows = false;
            this.DGV_info.AllowUserToDeleteRows = false;
            this.DGV_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DGV_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_info.Location = new System.Drawing.Point(3, 17);
            this.DGV_info.Name = "DGV_info";
            this.DGV_info.ReadOnly = true;
            this.DGV_info.RowHeadersVisible = false;
            this.DGV_info.RowTemplate.Height = 23;
            this.DGV_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_info.Size = new System.Drawing.Size(682, 113);
            this.DGV_info.TabIndex = 0;
            this.DGV_info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_info_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HY_ID";
            this.Column1.HeaderText = "会员编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HY_Name";
            this.Column2.HeaderText = "会员姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "YH_Zdh";
            this.Column3.HeaderText = "账单号";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "YH_desk";
            this.Column4.HeaderText = "桌台号";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "YH_money";
            this.Column5.HeaderText = "消费金额";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "YH_sj";
            this.Column6.HeaderText = "消费时间";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 110;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Beizhu";
            this.Column7.HeaderText = "备注";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "备注";
            this.columnHeader6.Width = 108;
            // 
            // but_cx
            // 
            this.but_cx.Image = ((System.Drawing.Image)(resources.GetObject("but_cx.Image")));
            this.but_cx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_cx.Location = new System.Drawing.Point(463, 28);
            this.but_cx.Name = "but_cx";
            this.but_cx.Size = new System.Drawing.Size(75, 23);
            this.but_cx.TabIndex = 5;
            this.but_cx.Text = "显示全部";
            this.but_cx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_cx.UseVisualStyleBackColor = true;
            this.but_cx.Click += new System.EventHandler(this.but_cx_Click);
            // 
            // CB_Name
            // 
            this.CB_Name.FormattingEnabled = true;
            this.CB_Name.Location = new System.Drawing.Point(319, 29);
            this.CB_Name.Name = "CB_Name";
            this.CB_Name.Size = new System.Drawing.Size(116, 20);
            this.CB_Name.TabIndex = 4;
            this.CB_Name.TextChanged += new System.EventHandler(this.CB_Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "会员编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(243, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "会员姓名：";
            // 
            // CB_ID
            // 
            this.CB_ID.FormattingEnabled = true;
            this.CB_ID.Location = new System.Drawing.Point(110, 29);
            this.CB_ID.Name = "CB_ID";
            this.CB_ID.Size = new System.Drawing.Size(116, 20);
            this.CB_ID.TabIndex = 0;
            this.CB_ID.TextChanged += new System.EventHandler(this.CB_ID_TextChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "金额";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "消费数量";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "商品单价";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名称";
            this.columnHeader2.Width = 154;
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
            this.LV_info.Location = new System.Drawing.Point(3, 17);
            this.LV_info.Name = "LV_info";
            this.LV_info.Size = new System.Drawing.Size(682, 126);
            this.LV_info.TabIndex = 1;
            this.LV_info.UseCompatibleStateImageBehavior = false;
            this.LV_info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品类别";
            this.columnHeader1.Width = 122;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LV_info);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 146);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "消费明细";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_info);
            this.groupBox2.Location = new System.Drawing.Point(0, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 133);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消费信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CB_Name);
            this.groupBox3.Controls.Add(this.CB_ID);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.but_cx);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(25, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 64);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择会员";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip2.Location = new System.Drawing.Point(0, 212);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(688, 22);
            this.statusStrip2.TabIndex = 9;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(161, 17);
            this.toolStripStatusLabel1.Text = "                          ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel2.Text = "消费金额:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // Frm_memberXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Frm_memberXF";
            this.Size = new System.Drawing.Size(688, 402);
            this.Load += new System.EventHandler(this.Frm_memberXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_info)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_info;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button but_cx;
        private System.Windows.Forms.ComboBox CB_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_ID;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView LV_info;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}
