namespace Foot.Client
{
    partial class Frm_Waitertype
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
            this.LV_info = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.gbJ = new System.Windows.Forms.GroupBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Id = new System.Windows.Forms.TextBox();
            this.lblETName = new System.Windows.Forms.Label();
            this.lblETId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_Del = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_xiugai = new System.Windows.Forms.Button();
            this.but_Add = new System.Windows.Forms.Button();
            this.gbJ.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_info
            // 
            this.LV_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.LV_info.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LV_info.FullRowSelect = true;
            this.LV_info.GridLines = true;
            this.LV_info.Location = new System.Drawing.Point(20, 20);
            this.LV_info.MultiSelect = false;
            this.LV_info.Name = "LV_info";
            this.LV_info.Size = new System.Drawing.Size(446, 230);
            this.LV_info.TabIndex = 21;
            this.LV_info.UseCompatibleStateImageBehavior = false;
            this.LV_info.View = System.Windows.Forms.View.Details;
            this.LV_info.Click += new System.EventHandler(this.lvEmployeeType_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "职位编号";
            this.columnHeader5.Width = 99;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "员工职位名称";
            this.columnHeader6.Width = 216;
            // 
            // gbJ
            // 
            this.gbJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbJ.Controls.Add(this.TB_Name);
            this.gbJ.Controls.Add(this.TB_Id);
            this.gbJ.Controls.Add(this.lblETName);
            this.gbJ.Controls.Add(this.lblETId);
            this.gbJ.Location = new System.Drawing.Point(26, 15);
            this.gbJ.Name = "gbJ";
            this.gbJ.Size = new System.Drawing.Size(493, 57);
            this.gbJ.TabIndex = 22;
            this.gbJ.TabStop = false;
            this.gbJ.Text = "员工类型设置";
            // 
            // TB_Name
            // 
            this.TB_Name.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Name.Location = new System.Drawing.Point(341, 22);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(89, 21);
            this.TB_Name.TabIndex = 0;
            this.TB_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Name_KeyPress);
            // 
            // TB_Id
            // 
            this.TB_Id.Enabled = false;
            this.TB_Id.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Id.Location = new System.Drawing.Point(102, 22);
            this.TB_Id.Name = "TB_Id";
            this.TB_Id.Size = new System.Drawing.Size(89, 21);
            this.TB_Id.TabIndex = 4;
            // 
            // lblETName
            // 
            this.lblETName.AutoSize = true;
            this.lblETName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblETName.Location = new System.Drawing.Point(276, 26);
            this.lblETName.Name = "lblETName";
            this.lblETName.Size = new System.Drawing.Size(59, 12);
            this.lblETName.TabIndex = 1;
            this.lblETName.Text = "职位名称:";
            // 
            // lblETId
            // 
            this.lblETId.AutoSize = true;
            this.lblETId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblETId.Location = new System.Drawing.Point(37, 26);
            this.lblETId.Name = "lblETId";
            this.lblETId.Size = new System.Drawing.Size(59, 12);
            this.lblETId.TabIndex = 1;
            this.lblETId.Text = "职位编号:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LV_info);
            this.groupBox1.Location = new System.Drawing.Point(26, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 259);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "所有职务";
            // 
            // but_Del
            // 
            this.but_Del.Location = new System.Drawing.Point(343, 19);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(75, 23);
            this.but_Del.TabIndex = 16;
            this.but_Del.Text = "删除";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new System.EventHandler(this.but_Del_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_Del);
            this.groupBox2.Controls.Add(this.but_xiugai);
            this.groupBox2.Controls.Add(this.but_Add);
            this.groupBox2.Location = new System.Drawing.Point(26, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(493, 60);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // but_xiugai
            // 
            this.but_xiugai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_xiugai.Location = new System.Drawing.Point(209, 19);
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
            this.but_Add.Location = new System.Drawing.Point(75, 19);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(75, 23);
            this.but_Add.TabIndex = 0;
            this.but_Add.Text = "新增类型";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // Frm_Waitertype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbJ);
            this.Name = "Frm_Waitertype";
            this.Size = new System.Drawing.Size(545, 420);
            this.Load += new System.EventHandler(this.Frm_Waitertype_Load);
            this.gbJ.ResumeLayout(false);
            this.gbJ.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV_info;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox gbJ;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label lblETName;
        private System.Windows.Forms.Label lblETId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_Del;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_xiugai;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.TextBox TB_Id;
    }
}
