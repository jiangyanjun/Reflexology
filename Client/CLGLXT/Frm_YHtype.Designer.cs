namespace Foot.Client
{
    partial class Frm_YHtype
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LV_info = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.DGV_info = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_xiugQX = new System.Windows.Forms.Button();
            this.but_Del = new System.Windows.Forms.Button();
            this.but_AddYH = new System.Windows.Forms.Button();
            this.but_xiugai = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.but_AddQX = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_info)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LV_info);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox2.Size = new System.Drawing.Size(235, 322);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "权限信息";
            // 
            // LV_info
            // 
            this.LV_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LV_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_info.FullRowSelect = true;
            this.LV_info.GridLines = true;
            this.LV_info.Location = new System.Drawing.Point(9, 23);
            this.LV_info.Name = "LV_info";
            this.LV_info.Size = new System.Drawing.Size(217, 290);
            this.LV_info.TabIndex = 0;
            this.LV_info.UseCompatibleStateImageBehavior = false;
            this.LV_info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "           权限";
            this.columnHeader1.Width = 214;
            // 
            // DGV_info
            // 
            this.DGV_info.AllowUserToAddRows = false;
            this.DGV_info.AllowUserToDeleteRows = false;
            this.DGV_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DGV_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_info.Location = new System.Drawing.Point(9, 23);
            this.DGV_info.MultiSelect = false;
            this.DGV_info.Name = "DGV_info";
            this.DGV_info.ReadOnly = true;
            this.DGV_info.RowHeadersVisible = false;
            this.DGV_info.RowTemplate.Height = 23;
            this.DGV_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_info.Size = new System.Drawing.Size(225, 290);
            this.DGV_info.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "User_Name";
            this.Column1.HeaderText = "用户账号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 111;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Pt_Name";
            this.Column2.HeaderText = "用户权限";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 111;
            // 
            // but_xiugQX
            // 
            this.but_xiugQX.Location = new System.Drawing.Point(348, 22);
            this.but_xiugQX.Name = "but_xiugQX";
            this.but_xiugQX.Size = new System.Drawing.Size(66, 27);
            this.but_xiugQX.TabIndex = 4;
            this.but_xiugQX.Text = "修改用户";
            this.but_xiugQX.UseVisualStyleBackColor = true;
            this.but_xiugQX.Click += new System.EventHandler(this.but_xiugQX_Click);
            // 
            // but_Del
            // 
            this.but_Del.Location = new System.Drawing.Point(430, 22);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(66, 27);
            this.but_Del.TabIndex = 3;
            this.but_Del.Text = "删除用户";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // but_AddYH
            // 
            this.but_AddYH.Location = new System.Drawing.Point(267, 22);
            this.but_AddYH.Name = "but_AddYH";
            this.but_AddYH.Size = new System.Drawing.Size(66, 27);
            this.but_AddYH.TabIndex = 2;
            this.but_AddYH.Text = "增加用户";
            this.but_AddYH.UseVisualStyleBackColor = true;
            this.but_AddYH.Click += new System.EventHandler(this.but_AddYH_Click);
            // 
            // but_xiugai
            // 
            this.but_xiugai.Location = new System.Drawing.Point(105, 22);
            this.but_xiugai.Name = "but_xiugai";
            this.but_xiugai.Size = new System.Drawing.Size(66, 27);
            this.but_xiugai.TabIndex = 1;
            this.but_xiugai.Text = "修改权限";
            this.but_xiugai.UseVisualStyleBackColor = true;
            this.but_xiugai.Click += new System.EventHandler(this.but_xiugai_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGV_info);
            this.groupBox3.Location = new System.Drawing.Point(289, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox3.Size = new System.Drawing.Size(243, 322);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用户信息";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.but_xiugQX);
            this.groupBox1.Controls.Add(this.but_Del);
            this.groupBox1.Controls.Add(this.but_AddYH);
            this.groupBox1.Controls.Add(this.but_xiugai);
            this.groupBox1.Controls.Add(this.but_AddQX);
            this.groupBox1.Location = new System.Drawing.Point(12, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "删除权限";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_AddQX
            // 
            this.but_AddQX.Location = new System.Drawing.Point(24, 22);
            this.but_AddQX.Name = "but_AddQX";
            this.but_AddQX.Size = new System.Drawing.Size(66, 27);
            this.but_AddQX.TabIndex = 0;
            this.but_AddQX.Text = "增加权限";
            this.but_AddQX.UseVisualStyleBackColor = true;
            this.but_AddQX.Click += new System.EventHandler(this.but_AddQX_Click);
            // 
            // Frm_YHtype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Frm_YHtype";
            this.Size = new System.Drawing.Size(545, 420);
            this.Load += new System.EventHandler(this.Frm_YHtype_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_info)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LV_info;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DataGridView DGV_info;
        private System.Windows.Forms.Button but_xiugQX;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.Button but_AddYH;
        private System.Windows.Forms.Button but_xiugai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_AddQX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
    }
}
