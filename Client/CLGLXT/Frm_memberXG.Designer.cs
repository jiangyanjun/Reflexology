namespace Foot.Client
{
    partial class Frm_memberXG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_memberXG));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTP_Djrq = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.but_Close = new System.Windows.Forms.Button();
            this.but_OK = new System.Windows.Forms.Button();
            this.TB_IDcard = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_BZ = new System.Windows.Forms.TextBox();
            this.TB_jifen = new System.Windows.Forms.TextBox();
            this.DTP_SR = new System.Windows.Forms.DateTimePicker();
            this.CB_grade = new System.Windows.Forms.ComboBox();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_Sex = new System.Windows.Forms.ComboBox();
            this.TB_Tel = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTP_Djrq);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.but_Close);
            this.groupBox1.Controls.Add(this.but_OK);
            this.groupBox1.Controls.Add(this.TB_IDcard);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TB_BZ);
            this.groupBox1.Controls.Add(this.TB_jifen);
            this.groupBox1.Controls.Add(this.DTP_SR);
            this.groupBox1.Controls.Add(this.CB_grade);
            this.groupBox1.Controls.Add(this.CB_Type);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CB_Sex);
            this.groupBox1.Controls.Add(this.TB_Tel);
            this.groupBox1.Controls.Add(this.TB_Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_ID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加会员";
            // 
            // DTP_Djrq
            // 
            this.DTP_Djrq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Djrq.Location = new System.Drawing.Point(292, 195);
            this.DTP_Djrq.Name = "DTP_Djrq";
            this.DTP_Djrq.Size = new System.Drawing.Size(107, 21);
            this.DTP_Djrq.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 35;
            this.label11.Text = "登记日期：";
            // 
            // but_Close
            // 
            this.but_Close.Location = new System.Drawing.Point(292, 360);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(75, 23);
            this.but_Close.TabIndex = 10;
            this.but_Close.Text = "取消";
            this.but_Close.UseVisualStyleBackColor = true;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(98, 360);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 23);
            this.but_OK.TabIndex = 9;
            this.but_OK.Text = "确认";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // TB_IDcard
            // 
            this.TB_IDcard.Location = new System.Drawing.Point(98, 196);
            this.TB_IDcard.MaxLength = 18;
            this.TB_IDcard.Name = "TB_IDcard";
            this.TB_IDcard.Size = new System.Drawing.Size(100, 21);
            this.TB_IDcard.TabIndex = 6;
            this.TB_IDcard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_IDcard_KeyPress);
            this.TB_IDcard.Validating += new System.ComponentModel.CancelEventHandler(this.TB_IDcard_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "身份证号：";
            // 
            // TB_BZ
            // 
            this.TB_BZ.Location = new System.Drawing.Point(98, 238);
            this.TB_BZ.MaxLength = 49;
            this.TB_BZ.Multiline = true;
            this.TB_BZ.Name = "TB_BZ";
            this.TB_BZ.Size = new System.Drawing.Size(301, 102);
            this.TB_BZ.TabIndex = 8;
            this.TB_BZ.Text = "无";
            this.TB_BZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_BZ_KeyPress);
            // 
            // TB_jifen
            // 
            this.TB_jifen.Location = new System.Drawing.Point(98, 156);
            this.TB_jifen.MaxLength = 24;
            this.TB_jifen.Name = "TB_jifen";
            this.TB_jifen.Size = new System.Drawing.Size(100, 21);
            this.TB_jifen.TabIndex = 27;
            this.TB_jifen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_jifen_KeyPress);
            // 
            // DTP_SR
            // 
            this.DTP_SR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_SR.Location = new System.Drawing.Point(292, 76);
            this.DTP_SR.Name = "DTP_SR";
            this.DTP_SR.Size = new System.Drawing.Size(107, 21);
            this.DTP_SR.TabIndex = 2;
            // 
            // CB_grade
            // 
            this.CB_grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_grade.FormattingEnabled = true;
            this.CB_grade.Location = new System.Drawing.Point(292, 117);
            this.CB_grade.Name = "CB_grade";
            this.CB_grade.Size = new System.Drawing.Size(107, 20);
            this.CB_grade.TabIndex = 4;
            this.CB_grade.TextChanged += new System.EventHandler(this.CB_grade_TextChanged);
            // 
            // CB_Type
            // 
            this.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Items.AddRange(new object[] {
            "可用",
            "停用"});
            this.CB_Type.Location = new System.Drawing.Point(292, 156);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(107, 20);
            this.CB_Type.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "积分：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "会员等级：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "出生年月：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "状态：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "备注：";
            // 
            // CB_Sex
            // 
            this.CB_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Sex.FormattingEnabled = true;
            this.CB_Sex.Items.AddRange(new object[] {
            "女",
            "男"});
            this.CB_Sex.Location = new System.Drawing.Point(292, 36);
            this.CB_Sex.Name = "CB_Sex";
            this.CB_Sex.Size = new System.Drawing.Size(107, 20);
            this.CB_Sex.TabIndex = 1;
            // 
            // TB_Tel
            // 
            this.TB_Tel.Location = new System.Drawing.Point(98, 117);
            this.TB_Tel.MaxLength = 12;
            this.TB_Tel.Name = "TB_Tel";
            this.TB_Tel.Size = new System.Drawing.Size(100, 21);
            this.TB_Tel.TabIndex = 3;
            this.TB_Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Tel_KeyPress);
            this.TB_Tel.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Tel_Validating);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(98, 76);
            this.TB_Name.MaxLength = 27;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 21);
            this.TB_Name.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "联系电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "会员姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "会员编号：";
            // 
            // TB_ID
            // 
            this.TB_ID.Enabled = false;
            this.TB_ID.Location = new System.Drawing.Point(98, 36);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(100, 21);
            this.TB_ID.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_memberXG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(435, 412);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_memberXG";
            this.Padding = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加/修改会员";
            this.Load += new System.EventHandler(this.Frm_memberXG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_Sex;
        private System.Windows.Forms.TextBox TB_Tel;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_jifen;
        private System.Windows.Forms.DateTimePicker DTP_SR;
        private System.Windows.Forms.ComboBox CB_grade;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.TextBox TB_BZ;
        private System.Windows.Forms.TextBox TB_IDcard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DTP_Djrq;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}