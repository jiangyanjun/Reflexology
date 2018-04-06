namespace Foot.Client
{
    partial class Frm_XGCG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_XGCG));
            this.but_OK = new System.Windows.Forms.Button();
            this.but_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(52, 215);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(75, 23);
            this.but_OK.TabIndex = 0;
            this.but_OK.Text = "确认";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // but_close
            // 
            this.but_close.Location = new System.Drawing.Point(163, 215);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(75, 23);
            this.but_close.TabIndex = 1;
            this.but_close.Text = "取消";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "商品编号：";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "商品名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "进价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "数量：";
            // 
            // TB_ID
            // 
            this.TB_ID.Enabled = false;
            this.TB_ID.Location = new System.Drawing.Point(112, 30);
            this.TB_ID.MaxLength = 10;
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(95, 21);
            this.TB_ID.TabIndex = 6;
            this.TB_ID.Visible = false;
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(112, 116);
            this.TB_Price.MaxLength = 9;
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(95, 21);
            this.TB_Price.TabIndex = 7;
            this.TB_Price.TextChanged += new System.EventHandler(this.TB_Price_TextChanged);
            this.TB_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Price_KeyPress);
            // 
            // TB_Name
            // 
            this.TB_Name.AcceptsReturn = true;
            this.TB_Name.Enabled = false;
            this.TB_Name.Location = new System.Drawing.Point(112, 73);
            this.TB_Name.MaxLength = 19;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(95, 21);
            this.TB_Name.TabIndex = 8;
            // 
            // TB_num
            // 
            this.TB_num.Location = new System.Drawing.Point(112, 159);
            this.TB_num.MaxLength = 10;
            this.TB_num.Name = "TB_num";
            this.TB_num.Size = new System.Drawing.Size(95, 21);
            this.TB_num.TabIndex = 9;
            this.TB_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_num_KeyPress);
            // 
            // Frm_XGCG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.TB_num);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.but_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_XGCG";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购修改";
            this.Load += new System.EventHandler(this.Frm_XGCG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_num;
    }
}