using Kebue.Core.Util;

namespace Foot.Client
{
    partial class Frm_YudingXG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_YudingXG));
            this.but_OK = new System.Windows.Forms.Button();
            this.but_Close = new System.Windows.Forms.Button();
            this.gbAddD = new System.Windows.Forms.GroupBox();
            this.dtpBookedDateTime = new System.Windows.Forms.DateTimePicker();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbmBookedDeskId = new System.Windows.Forms.ComboBox();
            this.cbmBookedDeskTypeId = new System.Windows.Forms.ComboBox();
            this.lblTName = new System.Windows.Forms.Label();
            this.lblTType = new System.Windows.Forms.Label();
            this.txtGuestTelePhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblCName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblBookedId = new System.Windows.Forms.Label();
            this.gbAddD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(29, 242);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 23);
            this.but_OK.TabIndex = 6;
            this.but_OK.Text = "确定";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // but_Close
            // 
            this.but_Close.Location = new System.Drawing.Point(208, 242);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(75, 23);
            this.but_Close.TabIndex = 7;
            this.but_Close.Text = "取消";
            this.but_Close.UseVisualStyleBackColor = true;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // gbAddD
            // 
            this.gbAddD.Controls.Add(this.dtpBookedDateTime);
            this.gbAddD.Controls.Add(this.txtRemarks);
            this.gbAddD.Controls.Add(this.lblRemark);
            this.gbAddD.Controls.Add(this.lblTime);
            this.gbAddD.Controls.Add(this.cbmBookedDeskId);
            this.gbAddD.Controls.Add(this.cbmBookedDeskTypeId);
            this.gbAddD.Controls.Add(this.lblTName);
            this.gbAddD.Controls.Add(this.lblTType);
            this.gbAddD.Controls.Add(this.txtGuestTelePhone);
            this.gbAddD.Controls.Add(this.lblPhone);
            this.gbAddD.Controls.Add(this.txtGuestName);
            this.gbAddD.Controls.Add(this.lblBookedId);
            this.gbAddD.Controls.Add(this.lblCName);
            this.gbAddD.Location = new System.Drawing.Point(12, 12);
            this.gbAddD.Name = "gbAddD";
            this.gbAddD.Size = new System.Drawing.Size(345, 206);
            this.gbAddD.TabIndex = 9;
            this.gbAddD.TabStop = false;
            this.gbAddD.Text = "预订信息";
            // 
            // dtpBookedDateTime
            // 
            this.dtpBookedDateTime.CustomFormat = StaticStr.yyyy_MM_dd_HH_mm_ss;
            this.dtpBookedDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookedDateTime.Location = new System.Drawing.Point(89, 167);
            this.dtpBookedDateTime.Name = "dtpBookedDateTime";
            this.dtpBookedDateTime.Size = new System.Drawing.Size(227, 21);
            this.dtpBookedDateTime.TabIndex = 4;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(207, 55);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(109, 95);
            this.txtRemarks.TabIndex = 13;
            this.txtRemarks.Text = "无";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(205, 31);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(35, 12);
            this.lblRemark.TabIndex = 12;
            this.lblRemark.Text = "备注:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(24, 171);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 12);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "预抵时间:";
            // 
            // cbmBookedDeskId
            // 
            this.cbmBookedDeskId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmBookedDeskId.FormattingEnabled = true;
            this.cbmBookedDeskId.Location = new System.Drawing.Point(89, 132);
            this.cbmBookedDeskId.Name = "cbmBookedDeskId";
            this.cbmBookedDeskId.Size = new System.Drawing.Size(100, 20);
            this.cbmBookedDeskId.TabIndex = 3;
            // 
            // cbmBookedDeskTypeId
            // 
            this.cbmBookedDeskTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmBookedDeskTypeId.FormattingEnabled = true;
            this.cbmBookedDeskTypeId.Location = new System.Drawing.Point(89, 97);
            this.cbmBookedDeskTypeId.Name = "cbmBookedDeskTypeId";
            this.cbmBookedDeskTypeId.Size = new System.Drawing.Size(100, 20);
            this.cbmBookedDeskTypeId.TabIndex = 2;
            this.cbmBookedDeskTypeId.SelectedValueChanged += new System.EventHandler(this.CB_Type_SelectedValueChanged);
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.Location = new System.Drawing.Point(24, 136);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(53, 12);
            this.lblTName.TabIndex = 7;
            this.lblTName.Text = "T台编号:";
            // 
            // lblTType
            // 
            this.lblTType.AutoSize = true;
            this.lblTType.Location = new System.Drawing.Point(24, 101);
            this.lblTType.Name = "lblTType";
            this.lblTType.Size = new System.Drawing.Size(53, 12);
            this.lblTType.TabIndex = 5;
            this.lblTType.Text = "T台类型:";
            // 
            // txtGuestTelePhone
            // 
            this.txtGuestTelePhone.Location = new System.Drawing.Point(89, 62);
            this.txtGuestTelePhone.MaxLength = 14;
            this.txtGuestTelePhone.Name = "txtGuestTelePhone";
            this.txtGuestTelePhone.Size = new System.Drawing.Size(100, 21);
            this.txtGuestTelePhone.TabIndex = 1;
            this.txtGuestTelePhone.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Tel_Validating);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(24, 66);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 12);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "联系电话:";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(89, 27);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(100, 21);
            this.txtGuestName.TabIndex = 0;
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(24, 31);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(59, 12);
            this.lblCName.TabIndex = 1;
            this.lblCName.Text = "宾客姓名:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblBookedId
            // 
            this.lblBookedId.AutoSize = true;
            this.lblBookedId.Location = new System.Drawing.Point(212, 194);
            this.lblBookedId.Name = "lblBookedId";
            this.lblBookedId.Size = new System.Drawing.Size(59, 12);
            this.lblBookedId.TabIndex = 1;
            this.lblBookedId.Text = "宾客姓名:";
            // 
            // Frm_YudingXG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 295);
            this.Controls.Add(this.but_OK);
            this.Controls.Add(this.but_Close);
            this.Controls.Add(this.gbAddD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_YudingXG";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加/修改预定信息";
            this.Load += new System.EventHandler(this.Frm_YudingXG_Load);
            this.gbAddD.ResumeLayout(false);
            this.gbAddD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.GroupBox gbAddD;
        private System.Windows.Forms.DateTimePicker dtpBookedDateTime;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbmBookedDeskId;
        private System.Windows.Forms.ComboBox cbmBookedDeskTypeId;
        private System.Windows.Forms.Label lblTName;
        private System.Windows.Forms.Label lblTType;
        private System.Windows.Forms.TextBox txtGuestTelePhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblBookedId;
    }
}