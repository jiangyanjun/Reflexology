namespace Foot.Client
{
    partial class Frm_stockCX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_stockCX));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGV_info = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LV_info = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.but_OK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTP_close = new System.Windows.Forms.DateTimePicker();
            this.DTP_Kssj = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_info)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGV_info);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 184);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "消费信息";
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
            this.Column6});
            this.DGV_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_info.Location = new System.Drawing.Point(3, 17);
            this.DGV_info.Name = "DGV_info";
            this.DGV_info.ReadOnly = true;
            this.DGV_info.RowHeadersVisible = false;
            this.DGV_info.RowTemplate.Height = 23;
            this.DGV_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_info.Size = new System.Drawing.Size(553, 164);
            this.DGV_info.TabIndex = 0;
            this.DGV_info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_info_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CG_ID";
            this.Column1.HeaderText = "进货单号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CG_sj";
            this.Column2.HeaderText = "进货时间";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CG_ghs";
            this.Column3.HeaderText = "供应商";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CG_buyer";
            this.Column4.HeaderText = "采购员";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CG_Allprice";
            this.Column5.HeaderText = "金额";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CG_beizhu";
            this.Column6.HeaderText = "备注";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "备注";
            this.columnHeader6.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "金额";
            this.columnHeader5.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "数量";
            this.columnHeader4.Width = 55;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LV_info);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 171);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消费明细";
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
            this.LV_info.Size = new System.Drawing.Size(553, 151);
            this.LV_info.TabIndex = 1;
            this.LV_info.UseCompatibleStateImageBehavior = false;
            this.LV_info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品类别";
            this.columnHeader1.Width = 99;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "起始时间：";
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(443, 25);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(89, 23);
            this.but_OK.TabIndex = 1;
            this.but_OK.Text = "查询";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTP_close);
            this.groupBox1.Controls.Add(this.DTP_Kssj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.but_OK);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // DTP_close
            // 
            this.DTP_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTP_close.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_close.Location = new System.Drawing.Point(303, 25);
            this.DTP_close.Name = "DTP_close";
            this.DTP_close.Size = new System.Drawing.Size(110, 21);
            this.DTP_close.TabIndex = 4;
            // 
            // DTP_Kssj
            // 
            this.DTP_Kssj.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTP_Kssj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Kssj.Location = new System.Drawing.Point(102, 24);
            this.DTP_Kssj.Name = "DTP_Kssj";
            this.DTP_Kssj.Size = new System.Drawing.Size(110, 21);
            this.DTP_Kssj.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(227, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "截止时间：";
            // 
            // Frm_stockCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(559, 426);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_stockCX";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进货单查询";
            this.Load += new System.EventHandler(this.Frm_stockCX_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_info)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV_info;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LV_info;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DTP_close;
        private System.Windows.Forms.DateTimePicker DTP_Kssj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;

    }
}