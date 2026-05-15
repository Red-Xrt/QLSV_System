namespace Client
{
    partial class frmLogin
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
            this.text1 = new System.Windows.Forms.Label();
            this.txtboxUserName = new System.Windows.Forms.TextBox();
            this.txtboxPass = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textError = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblTitle.Location = new System.Drawing.Point(120, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 32);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "ĐĂNG NHẬP";

            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.text1.ForeColor = System.Drawing.Color.DimGray;
            this.text1.Location = new System.Drawing.Point(46, 90);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(102, 19);
            this.text1.TabIndex = 0;
            this.text1.Text = "Tên đăng nhập";

            // 
            // txtboxUserName
            // 
            this.txtboxUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtboxUserName.Location = new System.Drawing.Point(50, 115);
            this.txtboxUserName.Name = "txtboxUserName";
            this.txtboxUserName.Size = new System.Drawing.Size(300, 29);
            this.txtboxUserName.TabIndex = 1;

            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.text2.ForeColor = System.Drawing.Color.DimGray;
            this.text2.Location = new System.Drawing.Point(46, 160);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(68, 19);
            this.text2.TabIndex = 2;
            this.text2.Text = "Mật khẩu";

            // 
            // txtboxPass
            // 
            this.txtboxPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtboxPass.Location = new System.Drawing.Point(50, 185);
            this.txtboxPass.Name = "txtboxPass";
            this.txtboxPass.PasswordChar = '•';
            this.txtboxPass.Size = new System.Drawing.Size(300, 29);
            this.txtboxPass.TabIndex = 3;

            // 
            // textError
            // 
            this.textError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textError.ForeColor = System.Drawing.Color.IndianRed;
            this.textError.Location = new System.Drawing.Point(50, 220);
            this.textError.Name = "textError";
            this.textError.Size = new System.Drawing.Size(300, 20);
            this.textError.TabIndex = 6;
            this.textError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(50, 250);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 45);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;

            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(210, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;

            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 330);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textError);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtboxPass);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.txtboxUserName);
            this.Controls.Add(this.text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.TextBox txtboxUserName;
        private System.Windows.Forms.TextBox txtboxPass;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label textError;
        private System.Windows.Forms.Label lblTitle;
    }
}