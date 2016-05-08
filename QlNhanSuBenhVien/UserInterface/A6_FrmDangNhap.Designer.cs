namespace QlNhanSuBenhVien.UserInterface
{
    partial class A6_FrmDangNhap
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
            this.grbLoginInformation = new DevExpress.XtraEditors.GroupControl();
            this.lblChayChu = new DevExpress.XtraEditors.LabelControl();
            this.lblHoursDynamic = new System.Windows.Forms.Label();
            this.lblDayDynamic = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.pbImageLogin = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new DevExpress.XtraEditors.CheckButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnThoat = new DevExpress.XtraEditors.CheckButton();
            this.btnReset = new DevExpress.XtraEditors.CheckButton();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.timerChayThoiGian = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grbLoginInformation)).BeginInit();
            this.grbLoginInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLoginInformation
            // 
            this.grbLoginInformation.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.grbLoginInformation.Controls.Add(this.lblChayChu);
            this.grbLoginInformation.Controls.Add(this.lblHoursDynamic);
            this.grbLoginInformation.Controls.Add(this.lblDayDynamic);
            this.grbLoginInformation.Controls.Add(this.lblHours);
            this.grbLoginInformation.Controls.Add(this.lblDay);
            this.grbLoginInformation.Controls.Add(this.pbImageLogin);
            this.grbLoginInformation.Controls.Add(this.btnDangNhap);
            this.grbLoginInformation.Controls.Add(this.txtPassword);
            this.grbLoginInformation.Controls.Add(this.btnThoat);
            this.grbLoginInformation.Controls.Add(this.btnReset);
            this.grbLoginInformation.Controls.Add(this.lblPassword);
            this.grbLoginInformation.Controls.Add(this.lblUserName);
            this.grbLoginInformation.Controls.Add(this.txtUserName);
            this.grbLoginInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbLoginInformation.Location = new System.Drawing.Point(0, 0);
            this.grbLoginInformation.Name = "grbLoginInformation";
            this.grbLoginInformation.Size = new System.Drawing.Size(367, 166);
            this.grbLoginInformation.TabIndex = 5;
            this.grbLoginInformation.Text = "Thông Tin Đăng Nhập";
            // 
            // lblChayChu
            // 
            this.lblChayChu.Appearance.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChayChu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblChayChu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblChayChu.Location = new System.Drawing.Point(2, 150);
            this.lblChayChu.Name = "lblChayChu";
            this.lblChayChu.Size = new System.Drawing.Size(721, 14);
            this.lblChayChu.TabIndex = 34;
            this.lblChayChu.Text = "                     Bệnh Viện Đa Khoa Hoài Đức- Đức Giang- Hoài Đức- Tp.Hà Nội!." +
    "..2016                ";
            // 
            // lblHoursDynamic
            // 
            this.lblHoursDynamic.AutoSize = true;
            this.lblHoursDynamic.ForeColor = System.Drawing.Color.Purple;
            this.lblHoursDynamic.Location = new System.Drawing.Point(199, 87);
            this.lblHoursDynamic.Name = "lblHoursDynamic";
            this.lblHoursDynamic.Size = new System.Drawing.Size(23, 13);
            this.lblHoursDynamic.TabIndex = 33;
            this.lblHoursDynamic.Text = "....";
            // 
            // lblDayDynamic
            // 
            this.lblDayDynamic.AutoSize = true;
            this.lblDayDynamic.ForeColor = System.Drawing.Color.Purple;
            this.lblDayDynamic.Location = new System.Drawing.Point(75, 87);
            this.lblDayDynamic.Name = "lblDayDynamic";
            this.lblDayDynamic.Size = new System.Drawing.Size(23, 13);
            this.lblDayDynamic.TabIndex = 32;
            this.lblDayDynamic.Text = "....";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.ForeColor = System.Drawing.Color.Purple;
            this.lblHours.Location = new System.Drawing.Point(177, 87);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(29, 13);
            this.lblHours.TabIndex = 31;
            this.lblHours.Text = "Giờ: ";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.ForeColor = System.Drawing.Color.Purple;
            this.lblDay.Location = new System.Drawing.Point(43, 87);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(36, 13);
            this.lblDay.TabIndex = 30;
            this.lblDay.Text = "Ngày:";
            // 
            // pbImageLogin
            // 
            this.pbImageLogin.Image = global::QlNhanSuBenhVien.Properties.Resources.DangNhapHeTHong;
            this.pbImageLogin.Location = new System.Drawing.Point(281, 21);
            this.pbImageLogin.Name = "pbImageLogin";
            this.pbImageLogin.Size = new System.Drawing.Size(58, 65);
            this.pbImageLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageLogin.TabIndex = 29;
            this.pbImageLogin.TabStop = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Location = new System.Drawing.Point(9, 114);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(88, 25);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.CheckedChanged += new System.EventHandler(this.btnDangNhap_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(172, 21);
            this.txtPassword.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(263, 114);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 25);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.CheckedChanged += new System.EventHandler(this.btnThoat_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.Location = new System.Drawing.Point(136, 114);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 25);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.CheckedChanged += new System.EventHandler(this.btnReset_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(22, 62);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(49, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Mật Khẩu:";
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(22, 34);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(72, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Tên Tài Khoản:";
            // 
            // txtUserName
            // 
            this.txtUserName.EnterMoveNextControl = true;
            this.txtUserName.Location = new System.Drawing.Point(100, 31);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(172, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // timerChayThoiGian
            // 
            this.timerChayThoiGian.Enabled = true;
            this.timerChayThoiGian.Tick += new System.EventHandler(this.timerChayThoiGian_Tick);
            // 
            // A6_FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 166);
            this.Controls.Add(this.grbLoginInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A6_FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "A6_FrmDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.A6_FrmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.A6_FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbLoginInformation)).EndInit();
            this.grbLoginInformation.ResumeLayout(false);
            this.grbLoginInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbLoginInformation;
        private System.Windows.Forms.Label lblHoursDynamic;
        private System.Windows.Forms.Label lblDayDynamic;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.PictureBox pbImageLogin;
        private DevExpress.XtraEditors.CheckButton btnDangNhap;
        private System.Windows.Forms.TextBox txtPassword;
        private DevExpress.XtraEditors.CheckButton btnThoat;
        private DevExpress.XtraEditors.CheckButton btnReset;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private System.Windows.Forms.Timer timerChayThoiGian;
        private DevExpress.XtraEditors.LabelControl lblChayChu;
    }
}