namespace Foot.Client
{
    partial class Frm_Cktype
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
            this.gbAll = new System.Windows.Forms.GroupBox();
            this.LV_info = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbJ = new System.Windows.Forms.GroupBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.lblSTName = new System.Windows.Forms.Label();
            this.lblSTId = new System.Windows.Forms.Label();
            this.but_Add = new System.Windows.Forms.Button();
            this.but_xiugai = new System.Windows.Forms.Button();
            this.but_Del = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAll.SuspendLayout();
            this.gbJ.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAll
            // 
            this.gbAll.Controls.Add(this.LV_info);
            this.gbAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbAll.Location = new System.Drawing.Point(0, 115);
            this.gbAll.Name = "gbAll";
            this.gbAll.Size = new System.Drawing.Size(545, 305);
            this.gbAll.TabIndex = 11;
            this.gbAll.TabStop = false;
            this.gbAll.Text = "所有仓库";
            // 
            // LV_info
            // 
            this.LV_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LV_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_info.FullRowSelect = true;
            this.LV_info.GridLines = true;
            this.LV_info.Location = new System.Drawing.Point(3, 17);
            this.LV_info.MultiSelect = false;
            this.LV_info.Name = "LV_info";
            this.LV_info.Size = new System.Drawing.Size(539, 285);
            this.LV_info.TabIndex = 0;
            this.LV_info.UseCompatibleStateImageBehavior = false;
            this.LV_info.View = System.Windows.Forms.View.Details;
            this.LV_info.Click += new System.EventHandler(this.LV_info_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "仓库编号";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "仓库名称";
            this.columnHeader2.Width = 120;
            // 
            // gbJ
            // 
            this.gbJ.Controls.Add(this.TB_Name);
            this.gbJ.Controls.Add(this.TB_ID);
            this.gbJ.Controls.Add(this.lblSTName);
            this.gbJ.Controls.Add(this.lblSTId);
            this.gbJ.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbJ.Location = new System.Drawing.Point(0, 0);
            this.gbJ.Name = "gbJ";
            this.gbJ.Size = new System.Drawing.Size(545, 60);
            this.gbJ.TabIndex = 10;
            this.gbJ.TabStop = false;
            this.gbJ.Text = "仓库设置";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(304, 25);
            this.TB_Name.MaxLength = 29;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(89, 21);
            this.TB_Name.TabIndex = 0;
            // 
            // TB_ID
            // 
            this.TB_ID.Enabled = false;
            this.TB_ID.Location = new System.Drawing.Point(127, 25);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(89, 21);
            this.TB_ID.TabIndex = 4;
            // 
            // lblSTName
            // 
            this.lblSTName.AutoSize = true;
            this.lblSTName.Location = new System.Drawing.Point(239, 29);
            this.lblSTName.Name = "lblSTName";
            this.lblSTName.Size = new System.Drawing.Size(59, 12);
            this.lblSTName.TabIndex = 1;
            this.lblSTName.Text = "仓库名称:";
            // 
            // lblSTId
            // 
            this.lblSTId.AutoSize = true;
            this.lblSTId.Location = new System.Drawing.Point(62, 29);
            this.lblSTId.Name = "lblSTId";
            this.lblSTId.Size = new System.Drawing.Size(59, 12);
            this.lblSTId.TabIndex = 1;
            this.lblSTId.Text = "仓库编号:";
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(127, 15);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(75, 23);
            this.but_Add.TabIndex = 13;
            this.but_Add.Text = "增加";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // but_xiugai
            // 
            this.but_xiugai.Location = new System.Drawing.Point(222, 15);
            this.but_xiugai.Name = "but_xiugai";
            this.but_xiugai.Size = new System.Drawing.Size(75, 23);
            this.but_xiugai.TabIndex = 14;
            this.but_xiugai.Text = "修改";
            this.but_xiugai.UseVisualStyleBackColor = true;
            this.but_xiugai.Click += new System.EventHandler(this.but_xiugai_Click);
            // 
            // but_Del
            // 
            this.but_Del.Location = new System.Drawing.Point(317, 15);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(75, 23);
            this.but_Del.TabIndex = 15;
            this.but_Del.Text = "删除";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_Del);
            this.groupBox1.Controls.Add(this.but_Add);
            this.groupBox1.Controls.Add(this.but_xiugai);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 55);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // Frm_Cktype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAll);
            this.Controls.Add(this.gbJ);
            this.Name = "Frm_Cktype";
            this.Size = new System.Drawing.Size(545, 420);
            this.Load += new System.EventHandler(this.Frm_Cktype_Load);
            this.gbAll.ResumeLayout(false);
            this.gbJ.ResumeLayout(false);
            this.gbJ.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAll;
        private System.Windows.Forms.ListView LV_info;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox gbJ;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Label lblSTName;
        private System.Windows.Forms.Label lblSTId;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Button but_xiugai;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
