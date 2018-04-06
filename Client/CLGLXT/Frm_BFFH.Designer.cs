namespace Foot.Client
{
    partial class Frm_BFFH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BFFH));
            this.but_HF = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.but_BF = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // but_HF
            // 
            this.but_HF.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_HF.Location = new System.Drawing.Point(179, 43);
            this.but_HF.Name = "but_HF";
            this.but_HF.Size = new System.Drawing.Size(136, 36);
            this.but_HF.TabIndex = 0;
            this.but_HF.Text = "数据恢复";
            this.but_HF.UseVisualStyleBackColor = true;
            this.but_HF.Click += new System.EventHandler(this.but_HF_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // but_BF
            // 
            this.but_BF.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_BF.Location = new System.Drawing.Point(22, 43);
            this.but_BF.Name = "but_BF";
            this.but_BF.Size = new System.Drawing.Size(136, 36);
            this.but_BF.TabIndex = 4;
            this.but_BF.Text = "数据备份";
            this.but_BF.UseVisualStyleBackColor = true;
            this.but_BF.Click += new System.EventHandler(this.but_BF_Click);
            // 
            // Frm_BFFH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(359, 128);
            this.Controls.Add(this.but_BF);
            this.Controls.Add(this.but_HF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_BFFH";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据备份/恢复";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_HF;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button but_BF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}