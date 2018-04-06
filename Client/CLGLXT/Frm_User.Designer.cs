namespace Foot.Client
{
    partial class Frm_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_User));
            this.but_BC = new System.Windows.Forms.Button();
            this.but_close = new System.Windows.Forms.Button();
            this.gbU = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TB_Pwd = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.gbU.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_BC
            // 
            this.but_BC.Location = new System.Drawing.Point(37, 207);
            this.but_BC.Name = "but_BC";
            this.but_BC.Size = new System.Drawing.Size(75, 23);
            this.but_BC.TabIndex = 3;
            this.but_BC.Text = "保存";
            this.but_BC.UseVisualStyleBackColor = true;
            this.but_BC.Click += new System.EventHandler(this.but_BC_Click);
            // 
            // but_close
            // 
            this.but_close.Location = new System.Drawing.Point(134, 207);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(75, 23);
            this.but_close.TabIndex = 4;
            this.but_close.Text = "取消";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // gbU
            // 
            this.gbU.Controls.Add(this.checkBox1);
            this.gbU.Controls.Add(this.TB_Pwd);
            this.gbU.Controls.Add(this.TB_Name);
            this.gbU.Controls.Add(this.label4);
            this.gbU.Controls.Add(this.label3);
            this.gbU.Controls.Add(this.label2);
            this.gbU.Controls.Add(this.CB_Type);
            this.gbU.Location = new System.Drawing.Point(12, 12);
            this.gbU.Name = "gbU";
            this.gbU.Size = new System.Drawing.Size(245, 176);
            this.gbU.TabIndex = 10;
            this.gbU.TabStop = false;
            this.gbU.Text = "用户信息";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "修改密码：";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TB_Pwd
            // 
            this.TB_Pwd.Location = new System.Drawing.Point(111, 79);
            this.TB_Pwd.MaxLength = 20;
            this.TB_Pwd.Name = "TB_Pwd";
            this.TB_Pwd.Size = new System.Drawing.Size(100, 21);
            this.TB_Pwd.TabIndex = 1;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(111, 34);
            this.TB_Name.MaxLength = 14;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 21);
            this.TB_Name.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "权  限:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "密  码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "用户名:";
            // 
            // CB_Type
            // 
            this.CB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Location = new System.Drawing.Point(111, 123);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(100, 20);
            this.CB_Type.TabIndex = 2;
            // 
            // Frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(279, 255);
            this.Controls.Add(this.but_BC);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.gbU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_User";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改/增加用户";
            this.Load += new System.EventHandler(this.Frm_User_Load);
            this.gbU.ResumeLayout(false);
            this.gbU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_BC;
        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.GroupBox gbU;
        private System.Windows.Forms.TextBox TB_Pwd;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}