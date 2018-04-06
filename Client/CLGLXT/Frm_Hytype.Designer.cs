namespace Foot.Client
{
    partial class Frm_Hytype
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
            this.TB_Zk = new System.Windows.Forms.TextBox();
            this.TB_jf = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LV_info = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_Del = new System.Windows.Forms.Button();
            this.but_xiugai = new System.Windows.Forms.Button();
            this.but_Add = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_Zk);
            this.groupBox2.Controls.Add(this.TB_jf);
            this.groupBox2.Controls.Add(this.TB_Name);
            this.groupBox2.Controls.Add(this.TB_ID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 279);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "会员类型";
            // 
            // TB_Zk
            // 
            this.TB_Zk.Location = new System.Drawing.Point(94, 186);
            this.TB_Zk.MaxLength = 9;
            this.TB_Zk.Name = "TB_Zk";
            this.TB_Zk.Size = new System.Drawing.Size(88, 21);
            this.TB_Zk.TabIndex = 7;
            this.TB_Zk.TextChanged += new System.EventHandler(this.TB_Zk_TextChanged);
            this.TB_Zk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Zk_KeyPress);
            // 
            // TB_jf
            // 
            this.TB_jf.Location = new System.Drawing.Point(94, 141);
            this.TB_jf.MaxLength = 9;
            this.TB_jf.Name = "TB_jf";
            this.TB_jf.Size = new System.Drawing.Size(88, 21);
            this.TB_jf.TabIndex = 6;
            this.TB_jf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_jf_KeyPress);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(94, 96);
            this.TB_Name.MaxLength = 19;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(88, 21);
            this.TB_Name.TabIndex = 5;
            // 
            // TB_ID
            // 
            this.TB_ID.Enabled = false;
            this.TB_ID.Location = new System.Drawing.Point(94, 51);
            this.TB_ID.MaxLength = 10;
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(88, 21);
            this.TB_ID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(33, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "折扣率：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "初始积分：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "类型名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型编号：";
            // 
            // LV_info
            // 
            this.LV_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LV_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_info.FullRowSelect = true;
            this.LV_info.GridLines = true;
            this.LV_info.Location = new System.Drawing.Point(3, 17);
            this.LV_info.Name = "LV_info";
            this.LV_info.Size = new System.Drawing.Size(298, 259);
            this.LV_info.TabIndex = 0;
            this.LV_info.UseCompatibleStateImageBehavior = false;
            this.LV_info.View = System.Windows.Forms.View.Details;
            this.LV_info.Click += new System.EventHandler(this.LV_info_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "类型编号";
            this.columnHeader1.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类型名称";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "初始积分";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "折扣率";
            this.columnHeader4.Width = 67;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LV_info);
            this.groupBox3.Location = new System.Drawing.Point(232, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 279);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "所有等级：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_Del);
            this.groupBox1.Controls.Add(this.but_xiugai);
            this.groupBox1.Controls.Add(this.but_Add);
            this.groupBox1.Location = new System.Drawing.Point(12, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(523, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // but_Del
            // 
            this.but_Del.Location = new System.Drawing.Point(358, 31);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(75, 23);
            this.but_Del.TabIndex = 16;
            this.but_Del.Text = "删除";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // but_xiugai
            // 
            this.but_xiugai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_xiugai.Location = new System.Drawing.Point(224, 31);
            this.but_xiugai.Name = "but_xiugai";
            this.but_xiugai.Size = new System.Drawing.Size(75, 23);
            this.but_xiugai.TabIndex = 1;
            this.but_xiugai.Text = "修改类型";
            this.but_xiugai.UseVisualStyleBackColor = true;
            this.but_xiugai.Click += new System.EventHandler(this.but_xiugai_Click);
            // 
            // but_Add
            // 
            this.but_Add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_Add.Location = new System.Drawing.Point(90, 31);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(75, 23);
            this.but_Add.TabIndex = 0;
            this.but_Add.Text = "新增类型";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // Frm_Hytype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Hytype";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(545, 420);
            this.Load += new System.EventHandler(this.Frm_Hytype_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_Zk;
        private System.Windows.Forms.TextBox TB_jf;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LV_info;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_xiugai;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Button but_Del;
    }
}
