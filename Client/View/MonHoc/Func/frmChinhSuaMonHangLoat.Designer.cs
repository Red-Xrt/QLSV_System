namespace Client.View.MonHoc.Func
{
    partial class frmChinhSuaMonHangLoat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpThaoTac = new System.Windows.Forms.GroupBox();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.cboThu = new System.Windows.Forms.ComboBox();
            this.chkDoiLich = new System.Windows.Forms.CheckBox();
            this.txtGiangVien = new System.Windows.Forms.TextBox();
            this.chkDoiGiangVien = new System.Windows.Forms.CheckBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.chkDoiPhong = new System.Windows.Forms.CheckBox();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lstMonHoc = new System.Windows.Forms.ListBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpThaoTac.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(720, 56);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTitle.Text = "CHỈNH SỬA NHIỀU MÔN";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.lstMonHoc);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Location = new System.Drawing.Point(12, 12);
            this.grpDanhSach.Size = new System.Drawing.Size(300, 361);
            this.grpDanhSach.Text = "Môn đã chọn";
            // 
            // lstMonHoc
            // 
            this.lstMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMonHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            // 
            // grpThaoTac
            // 
            this.grpThaoTac.Controls.Add(this.dtpGioKetThuc);
            this.grpThaoTac.Controls.Add(this.dtpGioBatDau);
            this.grpThaoTac.Controls.Add(this.cboThu);
            this.grpThaoTac.Controls.Add(this.chkDoiLich);
            this.grpThaoTac.Controls.Add(this.txtGiangVien);
            this.grpThaoTac.Controls.Add(this.chkDoiGiangVien);
            this.grpThaoTac.Controls.Add(this.txtPhong);
            this.grpThaoTac.Controls.Add(this.chkDoiPhong);
            this.grpThaoTac.Controls.Add(this.lblHuongDan);
            this.grpThaoTac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThaoTac.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThaoTac.Location = new System.Drawing.Point(312, 12);
            this.grpThaoTac.Size = new System.Drawing.Size(396, 361);
            this.grpThaoTac.Text = "Cập nhật chung";
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHuongDan.ForeColor = System.Drawing.Color.DimGray;
            this.lblHuongDan.Location = new System.Drawing.Point(16, 28);
            this.lblHuongDan.Size = new System.Drawing.Size(360, 60);
            this.lblHuongDan.Text = "Tick mục cần đổi. Tên môn, tín chỉ: mở Chi tiết (1 môn). Lịch áp chung cho tất cả môn đã chọn.";
            // 
            // chkDoiPhong
            // 
            this.chkDoiPhong.Location = new System.Drawing.Point(16, 98);
            this.chkDoiPhong.Text = "Đổi phòng học";
            this.chkDoiPhong.CheckedChanged += new System.EventHandler(this.ChkDoiPhong_CheckedChanged);
            // 
            // txtPhong
            // 
            this.txtPhong.Enabled = false;
            this.txtPhong.Location = new System.Drawing.Point(16, 128);
            this.txtPhong.Size = new System.Drawing.Size(150, 27);
            // 
            // chkDoiGiangVien
            // 
            this.chkDoiGiangVien.Location = new System.Drawing.Point(16, 168);
            this.chkDoiGiangVien.Text = "Đổi giảng viên";
            this.chkDoiGiangVien.CheckedChanged += new System.EventHandler(this.ChkDoiGiangVien_CheckedChanged);
            // 
            // txtGiangVien
            // 
            this.txtGiangVien.Enabled = false;
            this.txtGiangVien.Location = new System.Drawing.Point(16, 198);
            this.txtGiangVien.Size = new System.Drawing.Size(340, 27);
            // 
            // chkDoiLich
            // 
            this.chkDoiLich.Location = new System.Drawing.Point(16, 238);
            this.chkDoiLich.Text = "Đổi lịch (thứ + giờ)";
            this.chkDoiLich.CheckedChanged += new System.EventHandler(this.ChkDoiLich_CheckedChanged);
            // 
            // cboThu
            // 
            this.cboThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThu.Enabled = false;
            this.cboThu.Location = new System.Drawing.Point(16, 268);
            this.cboThu.Size = new System.Drawing.Size(150, 28);
            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.Enabled = false;
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Location = new System.Drawing.Point(180, 268);
            this.dtpGioBatDau.Size = new System.Drawing.Size(90, 27);
            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.Enabled = false;
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(280, 268);
            this.dtpGioKetThuc.Size = new System.Drawing.Size(90, 27);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grpThaoTac);
            this.pnlMain.Controls.Add(this.grpDanhSach);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMain.Location = new System.Drawing.Point(0, 56);
            this.pnlMain.Size = new System.Drawing.Size(720, 385);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBottom.Controls.Add(this.btnHuy);
            this.pnlBottom.Controls.Add(this.btnLuu);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Size = new System.Drawing.Size(720, 56);
            // 
            // btnLuu / btnHuy
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(468, 10);
            this.btnLuu.Size = new System.Drawing.Size(110, 36);
            this.btnLuu.Text = "Lưu";
            this.btnHuy.BackColor = System.Drawing.Color.DimGray;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(590, 10);
            this.btnHuy.Size = new System.Drawing.Size(100, 36);
            this.btnHuy.Text = "Đóng";
            // 
            // frmChinhSuaMonHangLoat
            // 
            this.ClientSize = new System.Drawing.Size(720, 497);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chỉnh sửa nhiều môn học";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grpThaoTac.ResumeLayout(false);
            this.grpThaoTac.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.ListBox lstMonHoc;
        private System.Windows.Forms.GroupBox grpThaoTac;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.CheckBox chkDoiPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.CheckBox chkDoiGiangVien;
        private System.Windows.Forms.TextBox txtGiangVien;
        private System.Windows.Forms.CheckBox chkDoiLich;
        private System.Windows.Forms.ComboBox cboThu;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}
