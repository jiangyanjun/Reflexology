namespace Foot.Client
{
    partial class Frm_WaiterXG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_WaiterXG));
            this.but_Close = new System.Windows.Forms.Button();
            this.but_OK = new System.Windows.Forms.Button();
            this.TB_address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_IDcard = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_BZ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTP_Sbsj = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_Age = new System.Windows.Forms.TextBox();
            this.DTP_SR = new System.Windows.Forms.DateTimePicker();
            this.CB_ZW = new System.Windows.Forms.ComboBox();
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
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Close
            // 
            this.but_Close.Location = new System.Drawing.Point(292, 360);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(75, 23);
            this.but_Close.TabIndex = 11;
            this.but_Close.Text = "取消";
            this.but_Close.UseVisualStyleBackColor = true;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(98, 360);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 23);
            this.but_OK.TabIndex = 10;
            this.but_OK.Text = "确认";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // TB_address
            // 
            this.TB_address.Location = new System.Drawing.Point(98, 193);
            this.TB_address.Name = "TB_address";
            this.TB_address.Size = new System.Drawing.Size(100, 21);
            this.TB_address.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 31;
            this.label11.Text = "家庭地址：";
            // 
            // TB_IDcard
            // 
            this.TB_IDcard.Location = new System.Drawing.Point(98, 156);
            this.TB_IDcard.MaxLength = 18;
            this.TB_IDcard.Name = "TB_IDcard";
            this.TB_IDcard.Size = new System.Drawing.Size(100, 21);
            this.TB_IDcard.TabIndex = 5;
            this.TB_IDcard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_IDcard_KeyPress);
            this.TB_IDcard.Validating += new System.ComponentModel.CancelEventHandler(this.TB_IDcard_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "身份证号：";
            // 
            // TB_BZ
            // 
            this.TB_BZ.Location = new System.Drawing.Point(98, 232);
            this.TB_BZ.Multiline = true;
            this.TB_BZ.Name = "TB_BZ";
            this.TB_BZ.Size = new System.Drawing.Size(301, 108);
            this.TB_BZ.TabIndex = 9;
            this.TB_BZ.Text = "无";
            this.TB_BZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_BZ_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTP_Sbsj);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TB_Age);
            this.groupBox1.Controls.Add(this.but_Close);
            this.groupBox1.Controls.Add(this.but_OK);
            this.groupBox1.Controls.Add(this.TB_address);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TB_IDcard);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TB_BZ);
            this.groupBox1.Controls.Add(this.DTP_SR);
            this.groupBox1.Controls.Add(this.CB_ZW);
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
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加会员";
            // 
            // DTP_Sbsj
            // 
            this.DTP_Sbsj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Sbsj.Location = new System.Drawing.Point(292, 192);
            this.DTP_Sbsj.Name = "DTP_Sbsj";
            this.DTP_Sbsj.Size = new System.Drawing.Size(107, 21);
            this.DTP_Sbsj.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 36;
            this.label9.Text = "上班时间：";
            // 
            // TB_Age
            // 
            this.TB_Age.Location = new System.Drawing.Point(292, 117);
            this.TB_Age.MaxLength = 2;
            this.TB_Age.Name = "TB_Age";
            this.TB_Age.Size = new System.Drawing.Size(100, 21);
            this.TB_Age.TabIndex = 3;
            this.TB_Age.TextChanged += new System.EventHandler(this.TB_Age_TextChanged);
            this.TB_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Age_KeyPress);
            this.TB_Age.Leave += new System.EventHandler(this.TB_Age_Leave);
            // 
            // DTP_SR
            // 
            this.DTP_SR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_SR.Location = new System.Drawing.Point(292, 76);
            this.DTP_SR.Name = "DTP_SR";
            this.DTP_SR.Size = new System.Drawing.Size(107, 21);
            this.DTP_SR.TabIndex = 2;
            // 
            // CB_ZW
            // 
            this.CB_ZW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ZW.FormattingEnabled = true;
            this.CB_ZW.Location = new System.Drawing.Point(290, 156);
            this.CB_ZW.Name = "CB_ZW";
            this.CB_ZW.Size = new System.Drawing.Size(107, 20);
            this.CB_ZW.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "员工职务：";
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
            this.label6.Location = new System.Drawing.Point(236, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "年龄：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 238);
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
            this.TB_Tel.TabIndex = 4;
            this.TB_Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Tel_KeyPress);
            this.TB_Tel.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Tel_Validating);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(98, 76);
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
            this.label2.Text = "员工姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "员工编号：";
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
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Frm_WaiterXG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(435, 412);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_WaiterXG";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工修改/添加";
            this.Load += new System.EventHandler(this.Frm_WaiterXG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.TextBox TB_address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_IDcard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_BZ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DTP_SR;
        private System.Windows.Forms.ComboBox CB_ZW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_Sex;
        private System.Windows.Forms.TextBox TB_Tel;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.TextBox TB_Age;
        private System.Windows.Forms.DateTimePicker DTP_Sbsj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}