namespace Foot.Client
{
    partial class FrmProductMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductMaster));
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grdProductManagement = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductManagement)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(343, 16);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(133, 21);
            this.txtProductName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "商品类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "商品名称：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdProductManagement);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(4, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.groupBox3.Size = new System.Drawing.Size(936, 308);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "商品信息";
            // 
            // grdProductManagement
            // 
            this.grdProductManagement.AllowUserToAddRows = false;
            this.grdProductManagement.AllowUserToDeleteRows = false;
            this.grdProductManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProductManagement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdProductManagement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdProductManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdProductManagement.ColumnHeadersHeight = 20;
            this.grdProductManagement.ContextMenuStrip = this.contextMenuStrip1;
            this.grdProductManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProductManagement.Location = new System.Drawing.Point(5, 17);
            this.grdProductManagement.Name = "grdProductManagement";
            this.grdProductManagement.ReadOnly = true;
            this.grdProductManagement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdProductManagement.RowHeadersVisible = false;
            this.grdProductManagement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProductManagement.RowTemplate.Height = 23;
            this.grdProductManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductManagement.Size = new System.Drawing.Size(926, 286);
            this.grdProductManagement.TabIndex = 0;
            this.grdProductManagement.TabStop = false;
            this.grdProductManagement.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductManagement_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAdd,
            this.tlsUpdate,
            this.tlsDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // tlsAdd
            // 
            this.tlsAdd.Name = "tlsAdd";
            this.tlsAdd.Size = new System.Drawing.Size(152, 22);
            this.tlsAdd.Text = "增加";
            this.tlsAdd.ToolTipText = "增加";
            this.tlsAdd.Click += new System.EventHandler(this.tlsAdd_Click);
            // 
            // tlsUpdate
            // 
            this.tlsUpdate.Name = "tlsUpdate";
            this.tlsUpdate.Size = new System.Drawing.Size(152, 22);
            this.tlsUpdate.Text = "修改";
            this.tlsUpdate.Click += new System.EventHandler(this.tlsUpdate_Click);
            // 
            // tlsDelete
            // 
            this.tlsDelete.Name = "tlsDelete";
            this.tlsDelete.Size = new System.Drawing.Size(152, 22);
            this.tlsDelete.Text = "删除";
            this.tlsDelete.Click += new System.EventHandler(this.tlsDelete_Click);
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Items.AddRange(new object[] {
            "茶类",
            "点心类",
            "饮料类"});
            this.cmbProductType.Location = new System.Drawing.Point(160, 16);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(88, 20);
            this.cmbProductType.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbProductType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(4, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(698, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "删除商品";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(506, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(603, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "增加商品";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmProductMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 376);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductMaster";
            this.Padding = new System.Windows.Forms.Padding(4, 8, 4, 7);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品信息";
            this.Load += new System.EventHandler(this.FrmProductMaster_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductManagement)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlsAdd;
        private System.Windows.Forms.ToolStripMenuItem tlsUpdate;
        private System.Windows.Forms.ToolStripMenuItem tlsDelete;
        private System.Windows.Forms.DataGridView grdProductManagement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnQuery;
    }
}