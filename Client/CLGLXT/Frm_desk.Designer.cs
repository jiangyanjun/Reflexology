namespace Foot.Client
{
    partial class Frm_desk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_desk));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Type = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdMalfunction = new System.Windows.Forms.RadioButton();
            this.rdClean = new System.Windows.Forms.RadioButton();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.ptNormal = new System.Windows.Forms.PictureBox();
            this.ptClean = new System.Windows.Forms.PictureBox();
            this.ptMalfunction = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptMalfunction)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "所选桌台名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "桌台当前状态：";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(173, 29);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(83, 12);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "             ";
            // 
            // lb_Type
            // 
            this.lb_Type.AutoSize = true;
            this.lb_Type.Location = new System.Drawing.Point(164, 67);
            this.lb_Type.Name = "lb_Type";
            this.lb_Type.Size = new System.Drawing.Size(101, 12);
            this.lb_Type.TabIndex = 3;
            this.lb_Type.Text = "                ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptMalfunction);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.ptClean);
            this.groupBox1.Controls.Add(this.rdMalfunction);
            this.groupBox1.Controls.Add(this.ptNormal);
            this.groupBox1.Controls.Add(this.rdClean);
            this.groupBox1.Controls.Add(this.radNormal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "更改状态";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(166, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdMalfunction
            // 
            this.rdMalfunction.AutoSize = true;
            this.rdMalfunction.Location = new System.Drawing.Point(254, 100);
            this.rdMalfunction.Name = "rdMalfunction";
            this.rdMalfunction.Size = new System.Drawing.Size(59, 16);
            this.rdMalfunction.TabIndex = 12;
            this.rdMalfunction.TabStop = true;
            this.rdMalfunction.Text = "不可用";
            this.rdMalfunction.UseVisualStyleBackColor = true;
            this.rdMalfunction.CheckedChanged += new System.EventHandler(this.rdMalfunction_CheckedChanged);
            // 
            // rdClean
            // 
            this.rdClean.AutoSize = true;
            this.rdClean.Location = new System.Drawing.Point(160, 100);
            this.rdClean.Name = "rdClean";
            this.rdClean.Size = new System.Drawing.Size(71, 16);
            this.rdClean.TabIndex = 12;
            this.rdClean.TabStop = true;
            this.rdClean.Text = "卫生清洁";
            this.rdClean.UseVisualStyleBackColor = true;
            this.rdClean.CheckedChanged += new System.EventHandler(this.rdClean_CheckedChanged);
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(65, 100);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(59, 16);
            this.radNormal.TabIndex = 12;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "可使用";
            this.radNormal.UseVisualStyleBackColor = true;
            this.radNormal.CheckedChanged += new System.EventHandler(this.radNormal_CheckedChanged);
            // 
            // ptNormal
            // 
            this.ptNormal.Image = ((System.Drawing.Image)(resources.GetObject("ptNormal.Image")));
            this.ptNormal.Location = new System.Drawing.Point(65, 20);
            this.ptNormal.Name = "ptNormal";
            this.ptNormal.Size = new System.Drawing.Size(64, 64);
            this.ptNormal.TabIndex = 9;
            this.ptNormal.TabStop = false;
            this.ptNormal.Click += new System.EventHandler(this.ptNormal_Click);
            // 
            // ptClean
            // 
            this.ptClean.Image = ((System.Drawing.Image)(resources.GetObject("ptClean.Image")));
            this.ptClean.Location = new System.Drawing.Point(160, 20);
            this.ptClean.Name = "ptClean";
            this.ptClean.Size = new System.Drawing.Size(64, 64);
            this.ptClean.TabIndex = 9;
            this.ptClean.TabStop = false;
            this.ptClean.Click += new System.EventHandler(this.ptClean_Click);
            // 
            // ptMalfunction
            // 
            this.ptMalfunction.Image = ((System.Drawing.Image)(resources.GetObject("ptMalfunction.Image")));
            this.ptMalfunction.Location = new System.Drawing.Point(254, 20);
            this.ptMalfunction.Name = "ptMalfunction";
            this.ptMalfunction.Size = new System.Drawing.Size(64, 64);
            this.ptMalfunction.TabIndex = 9;
            this.ptMalfunction.TabStop = false;
            this.ptMalfunction.Click += new System.EventHandler(this.ptMalfunction_Click);
            // 
            // Frm_desk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(389, 280);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_Type);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_desk";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更改桌台状态";
            this.Load += new System.EventHandler(this.Frm_desk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptMalfunction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Type;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMalfunction;
        private System.Windows.Forms.RadioButton rdClean;
        private System.Windows.Forms.RadioButton radNormal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox ptMalfunction;
        private System.Windows.Forms.PictureBox ptClean;
        private System.Windows.Forms.PictureBox ptNormal;
    }
}