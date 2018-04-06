namespace Foot.Client
{
    partial class Frm_taking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_taking));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LV_info = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DGV_info = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTP_close = new System.Windows.Forms.DateTimePicker();
            this.DTP_Kssj = new System.Windows.Forms.DateTimePicker();
            this.but_XS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_money = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_info)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品类别";
            this.columnHeader1.Width = 99;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LV_info);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(8, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(699, 184);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "消费明细";
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
            this.LV_info.Size = new System.Drawing.Size(693, 164);
            this.LV_info.TabIndex = 1;
            this.LV_info.UseCompatibleStateImageBehavior = false;
            this.LV_info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名称";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "单价";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "数量";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "金额";
            this.columnHeader5.Width = 55;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "备注";
            this.columnHeader6.Width = 122;
            // 
            // DGV_info
            // 
            this.DGV_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGV_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_info.ColumnHeadersHeight = 20;
            this.DGV_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DGV_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_info.Location = new System.Drawing.Point(3, 17);
            this.DGV_info.Name = "DGV_info";
            this.DGV_info.ReadOnly = true;
            this.DGV_info.RowHeadersVisible = false;
            this.DGV_info.RowTemplate.Height = 23;
            this.DGV_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_info.Size = new System.Drawing.Size(693, 151);
            this.DGV_info.TabIndex = 0;
            this.DGV_info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_info_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "XF_ID";
            this.Column1.HeaderText = "帐单号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "XF_desk";
            this.Column2.HeaderText = "T厅号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "XF_Ymoney";
            this.Column3.HeaderText = "应收金额";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "XF_ZK";
            this.Column4.HeaderText = "折扣率";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "XF_Smoney";
            this.Column5.HeaderText = "实收金额";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "XF_sj";
            this.Column6.HeaderText = "消费时间";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "XF_waiter";
            this.Column7.HeaderText = "服务员";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "beizhu";
            this.Column8.HeaderText = "备注";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // DTP_close
            // 
            this.DTP_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTP_close.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_close.Location = new System.Drawing.Point(313, 25);
            this.DTP_close.Name = "DTP_close";
            this.DTP_close.Size = new System.Drawing.Size(110, 21);
            this.DTP_close.TabIndex = 4;
            // 
            // DTP_Kssj
            // 
            this.DTP_Kssj.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTP_Kssj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Kssj.Location = new System.Drawing.Point(121, 24);
            this.DTP_Kssj.Name = "DTP_Kssj";
            this.DTP_Kssj.Size = new System.Drawing.Size(110, 21);
            this.DTP_Kssj.TabIndex = 1;
            // 
            // but_XS
            // 
            this.but_XS.Location = new System.Drawing.Point(438, 25);
            this.but_XS.Name = "but_XS";
            this.but_XS.Size = new System.Drawing.Size(89, 23);
            this.but_XS.TabIndex = 1;
            this.but_XS.Text = "查询";
            this.but_XS.UseVisualStyleBackColor = true;
            this.but_XS.Click += new System.EventHandler(this.but_XS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "起始时间：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_info);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(8, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 171);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消费信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_money);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DTP_close);
            this.groupBox1.Controls.Add(this.DTP_Kssj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.but_XS);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_money.ForeColor = System.Drawing.Color.Red;
            this.lb_money.Location = new System.Drawing.Point(614, 33);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(47, 12);
            this.lb_money.TabIndex = 6;
            this.lb_money.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(546, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "总收入：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(237, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "截止时间：";
            // 
            // Frm_taking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(715, 444);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_taking";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "营业查询";
            this.Load += new System.EventHandler(this.Frm_taking_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_info)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV_info;
        private System.Windows.Forms.ListView LV_info;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DateTimePicker DTP_close;
        private System.Windows.Forms.DateTimePicker DTP_Kssj;
        private System.Windows.Forms.Button but_XS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_money;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;

    }
}