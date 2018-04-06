namespace Foot.Client
{
    partial class Frm_stockDH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_stockDH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMName = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.lblToSH = new System.Windows.Forms.Label();
            this.CB_Name = new System.Windows.Forms.ComboBox();
            this.gbAllM = new System.Windows.Forms.GroupBox();
            this.LV_spinfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.gbS = new System.Windows.Forms.GroupBox();
            this.LV_dbinfo = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.but_Close = new System.Windows.Forms.Button();
            this.but_OK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbAllM.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gbS.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblMName);
            this.panel1.Controls.Add(this.TB_Name);
            this.panel1.Controls.Add(this.lblToSH);
            this.panel1.Controls.Add(this.CB_Name);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 49);
            this.panel1.TabIndex = 25;
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(18, 17);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(59, 12);
            this.lblMName.TabIndex = 15;
            this.lblMName.Text = "商品名称:";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(83, 13);
            this.TB_Name.MaxLength = 19;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(75, 21);
            this.TB_Name.TabIndex = 12;
            this.TB_Name.TextChanged += new System.EventHandler(this.TB_Name_TextChanged);
            this.TB_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Name_KeyPress);
            // 
            // lblToSH
            // 
            this.lblToSH.AutoSize = true;
            this.lblToSH.Location = new System.Drawing.Point(257, 17);
            this.lblToSH.Name = "lblToSH";
            this.lblToSH.Size = new System.Drawing.Size(35, 12);
            this.lblToSH.TabIndex = 16;
            this.lblToSH.Text = "调入:";
            // 
            // CB_Name
            // 
            this.CB_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Name.FormattingEnabled = true;
            this.CB_Name.Location = new System.Drawing.Point(298, 14);
            this.CB_Name.Name = "CB_Name";
            this.CB_Name.Size = new System.Drawing.Size(89, 20);
            this.CB_Name.TabIndex = 17;
            // 
            // gbAllM
            // 
            this.gbAllM.Controls.Add(this.LV_spinfo);
            this.gbAllM.Location = new System.Drawing.Point(9, 65);
            this.gbAllM.Name = "gbAllM";
            this.gbAllM.Size = new System.Drawing.Size(240, 319);
            this.gbAllM.TabIndex = 21;
            this.gbAllM.TabStop = false;
            this.gbAllM.Text = "商品信息";
            // 
            // LV_spinfo
            // 
            this.LV_spinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LV_spinfo.ContextMenuStrip = this.contextMenuStrip1;
            this.LV_spinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_spinfo.FullRowSelect = true;
            this.LV_spinfo.GridLines = true;
            this.LV_spinfo.Location = new System.Drawing.Point(3, 17);
            this.LV_spinfo.MultiSelect = false;
            this.LV_spinfo.Name = "LV_spinfo";
            this.LV_spinfo.Size = new System.Drawing.Size(234, 299);
            this.LV_spinfo.TabIndex = 4;
            this.LV_spinfo.UseCompatibleStateImageBehavior = false;
            this.LV_spinfo.View = System.Windows.Forms.View.Details;
            this.LV_spinfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LV_spinfo_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名称";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "所在仓库";
            this.columnHeader3.Width = 70;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_Add});
            this.contextMenuStrip1.Name = "cmsMenus";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // CMS_Add
            // 
            this.CMS_Add.Name = "CMS_Add";
            this.CMS_Add.Size = new System.Drawing.Size(100, 22);
            this.CMS_Add.Text = "增加";
            this.CMS_Add.Click += new System.EventHandler(this.CMS_Add_Click);
            // 
            // gbS
            // 
            this.gbS.Controls.Add(this.LV_dbinfo);
            this.gbS.Location = new System.Drawing.Point(269, 65);
            this.gbS.Name = "gbS";
            this.gbS.Size = new System.Drawing.Size(166, 319);
            this.gbS.TabIndex = 22;
            this.gbS.TabStop = false;
            this.gbS.Text = "调拨商品";
            // 
            // LV_dbinfo
            // 
            this.LV_dbinfo.AllowDrop = true;
            this.LV_dbinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.LV_dbinfo.ContextMenuStrip = this.contextMenuStrip2;
            this.LV_dbinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_dbinfo.FullRowSelect = true;
            this.LV_dbinfo.GridLines = true;
            this.LV_dbinfo.Location = new System.Drawing.Point(3, 17);
            this.LV_dbinfo.MultiSelect = false;
            this.LV_dbinfo.Name = "LV_dbinfo";
            this.LV_dbinfo.Size = new System.Drawing.Size(160, 299);
            this.LV_dbinfo.TabIndex = 0;
            this.LV_dbinfo.UseCompatibleStateImageBehavior = false;
            this.LV_dbinfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "编号";
            this.columnHeader4.Width = 39;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "商品名称";
            this.columnHeader5.Width = 106;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_Del});
            this.contextMenuStrip2.Name = "cmsMenus";
            this.contextMenuStrip2.Size = new System.Drawing.Size(101, 26);
            // 
            // CMS_Del
            // 
            this.CMS_Del.Name = "CMS_Del";
            this.CMS_Del.Size = new System.Drawing.Size(100, 22);
            this.CMS_Del.Text = "删除";
            this.CMS_Del.Click += new System.EventHandler(this.CMS_Del_Click);
            // 
            // but_Close
            // 
            this.but_Close.Location = new System.Drawing.Point(273, 400);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(74, 23);
            this.but_Close.TabIndex = 24;
            this.but_Close.Text = "取消";
            this.but_Close.UseVisualStyleBackColor = true;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(77, 400);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(70, 23);
            this.but_OK.TabIndex = 23;
            this.but_OK.Text = "确定";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // Frm_stockDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(447, 439);
            this.Controls.Add(this.gbAllM);
            this.Controls.Add(this.but_Close);
            this.Controls.Add(this.gbS);
            this.Controls.Add(this.but_OK);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_stockDH";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存调换";
            this.Load += new System.EventHandler(this.Frm_stockDH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAllM.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbS.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label lblToSH;
        private System.Windows.Forms.ComboBox CB_Name;
        private System.Windows.Forms.GroupBox gbAllM;
        private System.Windows.Forms.ListView LV_spinfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CMS_Add;
        private System.Windows.Forms.GroupBox gbS;
        private System.Windows.Forms.ListView LV_dbinfo;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem CMS_Del;
        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.Button but_OK;
    }
}