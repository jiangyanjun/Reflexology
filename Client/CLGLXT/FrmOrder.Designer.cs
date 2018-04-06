namespace Foot.Client
{
    partial class FrmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.but_OK = new System.Windows.Forms.Button();
            this.but_Close = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.LB_type = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomersNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelePhone = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomersNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F);
            this.label1.Location = new System.Drawing.Point(187, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "桌台类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F);
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "桌台名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F);
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "顾客人数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F);
            this.label5.Location = new System.Drawing.Point(43, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "备注：";
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(117, 269);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(70, 23);
            this.but_OK.TabIndex = 10;
            this.but_OK.Text = "确认";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // but_Close
            // 
            this.but_Close.Location = new System.Drawing.Point(221, 269);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(75, 23);
            this.but_Close.TabIndex = 11;
            this.but_Close.Text = "取消";
            this.but_Close.UseVisualStyleBackColor = true;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(101, 192);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(260, 58);
            this.txtRemarks.TabIndex = 12;
            // 
            // LB_type
            // 
            this.LB_type.AutoSize = true;
            this.LB_type.BackColor = System.Drawing.Color.Transparent;
            this.LB_type.Font = new System.Drawing.Font("宋体", 10.8F);
            this.LB_type.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LB_type.Location = new System.Drawing.Point(286, 38);
            this.LB_type.Name = "LB_type";
            this.LB_type.Size = new System.Drawing.Size(75, 15);
            this.LB_type.TabIndex = 15;
            this.LB_type.Text = "桌台类型 ";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.BackColor = System.Drawing.Color.Transparent;
            this.LB_Name.Font = new System.Drawing.Font("宋体", 10.8F);
            this.LB_Name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LB_Name.Location = new System.Drawing.Point(101, 38);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(52, 15);
            this.LB_Name.TabIndex = 18;
            this.LB_Name.Text = "桌台名";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelePhone);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMemberId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCustomersNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.but_Close);
            this.groupBox1.Controls.Add(this.but_OK);
            this.groupBox1.Controls.Add(this.LB_Name);
            this.groupBox1.Controls.Add(this.LB_type);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 304);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // txtCustomersNumber
            // 
            this.txtCustomersNumber.Location = new System.Drawing.Point(101, 160);
            this.txtCustomersNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCustomersNumber.Name = "txtCustomersNumber";
            this.txtCustomersNumber.Size = new System.Drawing.Size(86, 21);
            this.txtCustomersNumber.TabIndex = 19;
            this.txtCustomersNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCustomersNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomersNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F);
            this.label4.Location = new System.Drawing.Point(13, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "会员编号：";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(101, 64);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(260, 21);
            this.txtMemberId.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F);
            this.label6.Location = new System.Drawing.Point(13, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "顾客姓名：";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(101, 96);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(260, 21);
            this.txtCustomerName.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F);
            this.label7.Location = new System.Drawing.Point(13, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "顾客电话：";
            // 
            // txtTelePhone
            // 
            this.txtTelePhone.Location = new System.Drawing.Point(101, 128);
            this.txtTelePhone.Name = "txtTelePhone";
            this.txtTelePhone.Size = new System.Drawing.Size(260, 21);
            this.txtTelePhone.TabIndex = 20;
            this.txtTelePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelePhone_KeyPress);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 304);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmOrder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顾客开单";
            this.Load += new System.EventHandler(this.Frm_Open_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomersNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label LB_type;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtCustomersNumber;
        private System.Windows.Forms.TextBox txtTelePhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}