namespace Foot.Client
{
    partial class Frm_login
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_Login = new System.Windows.Forms.Button();
            this.but_Exit = new System.Windows.Forms.Button();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.TB_Pwd = new System.Windows.Forms.TextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            // 
            // but_Login
            // 
            this.but_Login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_Login.Location = new System.Drawing.Point(39, 127);
            this.but_Login.Name = "but_Login";
            this.but_Login.Size = new System.Drawing.Size(75, 23);
            this.but_Login.TabIndex = 3;
            this.but_Login.Text = "登录";
            this.but_Login.UseVisualStyleBackColor = true;
            this.but_Login.Click += new System.EventHandler(this.but_Login_Click);
            // 
            // but_Exit
            // 
            this.but_Exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_Exit.Location = new System.Drawing.Point(154, 127);
            this.but_Exit.Name = "but_Exit";
            this.but_Exit.Size = new System.Drawing.Size(75, 23);
            this.but_Exit.TabIndex = 4;
            this.but_Exit.Text = "取消";
            this.but_Exit.UseVisualStyleBackColor = true;
            this.but_Exit.Click += new System.EventHandler(this.but_Exit_Click);
            // 
            // TB_name
            // 
            this.TB_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_name.Location = new System.Drawing.Point(97, 29);
            this.TB_name.MaxLength = 15;
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(134, 26);
            this.TB_name.TabIndex = 1;
            this.TB_name.Text = "admin";
            // 
            // TB_Pwd
            // 
            this.TB_Pwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TB_Pwd.Location = new System.Drawing.Point(97, 76);
            this.TB_Pwd.MaxLength = 20;
            this.TB_Pwd.Name = "TB_Pwd";
            this.TB_Pwd.PasswordChar = '*';
            this.TB_Pwd.Size = new System.Drawing.Size(134, 26);
            this.TB_Pwd.TabIndex = 2;
            this.TB_Pwd.Text = "admin";
            this.TB_Pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Pwd_KeyPress);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_login
            // 
            this.AcceptButton = this.but_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(248, 160);
            this.Controls.Add(this.TB_Pwd);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.but_Exit);
            this.Controls.Add(this.but_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_Login;
        private System.Windows.Forms.Button but_Exit;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.TextBox TB_Pwd;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

