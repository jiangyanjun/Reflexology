namespace Foot.Client
{
    partial class Frm_Zttype
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_ZDXF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.TB_sl = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.TB_Num = new System.Windows.Forms.TextBox();
            this.lblMN = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.lblTTName = new System.Windows.Forms.Label();
            this.gbU = new System.Windows.Forms.GroupBox();
            this.LV_info = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.but_Del = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_Add = new System.Windows.Forms.Button();
            this.but_xiugai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbU.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_ZDXF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_ID);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.TB_sl);
            this.groupBox1.Controls.Add(this.lblA);
            this.groupBox1.Controls.Add(this.TB_Num);
            this.groupBox1.Controls.Add(this.lblMN);
            this.groupBox1.Controls.Add(this.TB_Name);
            this.groupBox1.Controls.Add(this.lblTTName);
            this.groupBox1.Location = new System.Drawing.Point(11, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 303);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类型信息";
            // 
            // TB_ZDXF
            // 
            this.TB_ZDXF.Location = new System.Drawing.Point(89, 243);
            this.TB_ZDXF.MaxLength = 9;
            this.TB_ZDXF.Name = "TB_ZDXF";
            this.TB_ZDXF.Size = new System.Drawing.Size(89, 21);
            this.TB_ZDXF.TabIndex = 10;
            this.TB_ZDXF.Text = "0";
            this.TB_ZDXF.TextChanged += new System.EventHandler(this.TB_ZDXF_TextChanged);
            this.TB_ZDXF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ZDXF_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "最低消费：";
            // 
            // TB_ID
            // 
            this.TB_ID.Enabled = false;
            this.TB_ID.Location = new System.Drawing.Point(89, 39);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(89, 21);
            this.TB_ID.TabIndex = 8;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Location = new System.Drawing.Point(38, 43);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(41, 12);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "编号：";
            // 
            // TB_sl
            // 
            this.TB_sl.Location = new System.Drawing.Point(89, 192);
            this.TB_sl.MaxLength = 9;
            this.TB_sl.Name = "TB_sl";
            this.TB_sl.Size = new System.Drawing.Size(89, 21);
            this.TB_sl.TabIndex = 3;
            this.TB_sl.Text = "0";
            this.TB_sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_sl_KeyPress);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.Location = new System.Drawing.Point(14, 196);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(65, 12);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "T台数量：";
            // 
            // TB_Num
            // 
            this.TB_Num.Location = new System.Drawing.Point(89, 141);
            this.TB_Num.MaxLength = 2;
            this.TB_Num.Name = "TB_Num";
            this.TB_Num.Size = new System.Drawing.Size(89, 21);
            this.TB_Num.TabIndex = 2;
            this.TB_Num.Text = "0";
            this.TB_Num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Num_KeyPress);
            // 
            // lblMN
            // 
            this.lblMN.AutoSize = true;
            this.lblMN.BackColor = System.Drawing.Color.Transparent;
            this.lblMN.Location = new System.Drawing.Point(14, 145);
            this.lblMN.Name = "lblMN";
            this.lblMN.Size = new System.Drawing.Size(65, 12);
            this.lblMN.TabIndex = 6;
            this.lblMN.Text = "接待人数：";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(89, 90);
            this.TB_Name.MaxLength = 18;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(89, 21);
            this.TB_Name.TabIndex = 0;
            // 
            // lblTTName
            // 
            this.lblTTName.AutoSize = true;
            this.lblTTName.BackColor = System.Drawing.Color.Transparent;
            this.lblTTName.Location = new System.Drawing.Point(14, 94);
            this.lblTTName.Name = "lblTTName";
            this.lblTTName.Size = new System.Drawing.Size(65, 12);
            this.lblTTName.TabIndex = 4;
            this.lblTTName.Text = "类型名称：";
            // 
            // gbU
            // 
            this.gbU.Controls.Add(this.LV_info);
            this.gbU.Location = new System.Drawing.Point(213, 9);
            this.gbU.Name = "gbU";
            this.gbU.Size = new System.Drawing.Size(325, 302);
            this.gbU.TabIndex = 18;
            this.gbU.TabStop = false;
            this.gbU.Text = "所有T台类型";
            // 
            // LV_info
            // 
            this.LV_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LV_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_info.FullRowSelect = true;
            this.LV_info.GridLines = true;
            this.LV_info.Location = new System.Drawing.Point(3, 17);
            this.LV_info.MultiSelect = false;
            this.LV_info.Name = "LV_info";
            this.LV_info.Size = new System.Drawing.Size(319, 282);
            this.LV_info.TabIndex = 0;
            this.LV_info.UseCompatibleStateImageBehavior = false;
            this.LV_info.View = System.Windows.Forms.View.Details;
            this.LV_info.Click += new System.EventHandler(this.LV_info_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类型名称";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "接待人数";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "T台数量";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "最低消费";
            this.columnHeader5.Width = 76;
            // 
            // but_Del
            // 
            this.but_Del.Location = new System.Drawing.Point(386, 26);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(75, 23);
            this.but_Del.TabIndex = 15;
            this.but_Del.Text = "删除";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_Del);
            this.groupBox2.Controls.Add(this.but_Add);
            this.groupBox2.Controls.Add(this.but_xiugai);
            this.groupBox2.Location = new System.Drawing.Point(11, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 67);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(66, 26);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(75, 23);
            this.but_Add.TabIndex = 13;
            this.but_Add.Text = "增加";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // but_xiugai
            // 
            this.but_xiugai.Location = new System.Drawing.Point(226, 26);
            this.but_xiugai.Name = "but_xiugai";
            this.but_xiugai.Size = new System.Drawing.Size(75, 23);
            this.but_xiugai.TabIndex = 14;
            this.but_xiugai.Text = "修改";
            this.but_xiugai.UseVisualStyleBackColor = true;
            this.but_xiugai.Click += new System.EventHandler(this.but_xiugai_Click);
            // 
            // Frm_Zttype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbU);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Zttype";
            this.Size = new System.Drawing.Size(545, 420);
            this.Load += new System.EventHandler(this.Frm_Zttype_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbU.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox TB_sl;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox TB_Num;
        private System.Windows.Forms.Label lblMN;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label lblTTName;
        private System.Windows.Forms.GroupBox gbU;
        private System.Windows.Forms.ListView LV_info;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Button but_xiugai;
        private System.Windows.Forms.TextBox TB_ZDXF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
