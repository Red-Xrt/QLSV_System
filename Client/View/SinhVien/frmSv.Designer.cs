namespace Client.View
{
    partial class frmSv
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.cboLocLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblDaChon = new System.Windows.Forms.Label();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnUnSellectAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopBar.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTopBar.Controls.Add(this.cboLocLop);
            this.pnlTopBar.Controls.Add(this.label5);
            this.pnlTopBar.Controls.Add(this.btnThem);
            this.pnlTopBar.Controls.Add(this.btnTimKiem);
            this.pnlTopBar.Controls.Add(this.txtTimKiem);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(786, 60);
            this.pnlTopBar.TabIndex = 1;
            // 
            // cboLocLop
            // 
            this.cboLocLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLocLop.Location = new System.Drawing.Point(385, 18);
            this.cboLocLop.Name = "cboLocLop";
            this.cboLocLop.Size = new System.Drawing.Size(150, 25);
            this.cboLocLop.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(320, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lọc Lớp:";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(680, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "+ Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(220, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 27);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(15, 18);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 25);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "Nhập mã hoặc tên SV...";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBottom.Controls.Add(this.lblDaChon);
            this.pnlBottom.Controls.Add(this.btnCheckAll);
            this.pnlBottom.Controls.Add(this.btnUnSellectAll);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 347);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(786, 50);
            this.pnlBottom.TabIndex = 2;
            // 
            // lblDaChon
            // 
            this.lblDaChon.AutoSize = true;
            this.lblDaChon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDaChon.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDaChon.Location = new System.Drawing.Point(15, 15);
            this.lblDaChon.Name = "lblDaChon";
            this.lblDaChon.Size = new System.Drawing.Size(149, 20);
            this.lblDaChon.TabIndex = 3;
            this.lblDaChon.Text = "Đã chọn: 0 sinh viên";
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckAll.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckAll.FlatAppearance.BorderSize = 0;
            this.btnCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckAll.ForeColor = System.Drawing.Color.White;
            this.btnCheckAll.Location = new System.Drawing.Point(540, 10);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(110, 30);
            this.btnCheckAll.TabIndex = 8;
            this.btnCheckAll.Text = "Chọn tất cả";
            this.btnCheckAll.UseVisualStyleBackColor = false;
            // 
            // btnUnSellectAll
            // 
            this.btnUnSellectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnSellectAll.BackColor = System.Drawing.Color.DimGray;
            this.btnUnSellectAll.FlatAppearance.BorderSize = 0;
            this.btnUnSellectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnSellectAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUnSellectAll.ForeColor = System.Drawing.Color.White;
            this.btnUnSellectAll.Location = new System.Drawing.Point(660, 10);
            this.btnUnSellectAll.Name = "btnUnSellectAll";
            this.btnUnSellectAll.Size = new System.Drawing.Size(110, 30);
            this.btnUnSellectAll.TabIndex = 9;
            this.btnUnSellectAll.Text = "Bỏ chọn tất cả";
            this.btnUnSellectAll.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected,
            this.ID,
            this.colName,
            this.Date,
            this.colLop});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // colSelected
            // 
            this.colSelected.HeaderText = "Chọn";
            this.colSelected.Name = "colSelected";
            this.colSelected.Width = 50;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "Mã Sinh Viên";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Tên Sinh Viên";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Ngày Sinh";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // colLop
            // 
            this.colLop.HeaderText = "Lớp";
            this.colLop.Name = "colLop";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaSinhViênToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // sửaSinhViênToolStripMenuItem
            // 
            this.sửaSinhViênToolStripMenuItem.Name = "sửaSinhViênToolStripMenuItem";
            this.sửaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sửaSinhViênToolStripMenuItem.Text = "Chỉnh Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // frmSv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTopBar);
            this.Name = "frmSv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sửaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboLocLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblDaChon;
        private System.Windows.Forms.Button btnUnSellectAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLop;
    }
}