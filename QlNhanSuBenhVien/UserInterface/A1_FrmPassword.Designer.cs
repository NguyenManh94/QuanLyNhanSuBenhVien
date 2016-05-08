namespace QlNhanSuBenhVien.UserInterface
{
    partial class A1_FrmPassword
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barBtnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barListMessageChangePass = new DevExpress.XtraBars.BarListItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarShowInfor = new DevExpress.XtraWaitForm.ProgressPanel();
            this.chkKiemTraHopLe = new System.Windows.Forms.CheckBox();
            this.txtNhapLaiMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhauMoi = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhauCu = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlPassOld = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlPassNew = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlEnterRePass = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPassOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPassNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlEnterRePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4,
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnTaiLai,
            this.barBtnLuu,
            this.barListMessageChangePass});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnLuu, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnTaiLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // barBtnLuu
            // 
            this.barBtnLuu.Caption = "Lưu";
            this.barBtnLuu.Glyph = global::QlNhanSuBenhVien.Properties.Resources.save;
            this.barBtnLuu.Id = 1;
            this.barBtnLuu.Name = "barBtnLuu";
            this.barBtnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLuu_ItemClick);
            // 
            // barBtnTaiLai
            // 
            this.barBtnTaiLai.Caption = "Tải Lại";
            this.barBtnTaiLai.Glyph = global::QlNhanSuBenhVien.Properties.Resources.reload;
            this.barBtnTaiLai.Id = 0;
            this.barBtnTaiLai.Name = "barBtnTaiLai";
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barListMessageChangePass)});
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barListMessageChangePass
            // 
            this.barListMessageChangePass.Caption = "Bảo Mật: Thay Đổi Mật Khẩu";
            this.barListMessageChangePass.Id = 3;
            this.barListMessageChangePass.Name = "barListMessageChangePass";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(512, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 186);
            this.barDockControlBottom.Size = new System.Drawing.Size(512, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 160);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(512, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 160);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.pictureBox1);
            this.layoutControl1.Controls.Add(this.progressBarShowInfor);
            this.layoutControl1.Controls.Add(this.chkKiemTraHopLe);
            this.layoutControl1.Controls.Add(this.txtNhapLaiMatKhau);
            this.layoutControl1.Controls.Add(this.txtMatKhauMoi);
            this.layoutControl1.Controls.Add(this.txtMatKhauCu);
            this.layoutControl1.Controls.Add(this.txtTenTaiKhoan);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(512, 160);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QlNhanSuBenhVien.Properties.Resources.keepassx;
            this.pictureBox1.Location = new System.Drawing.Point(366, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // progressBarShowInfor
            // 
            this.progressBarShowInfor.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressBarShowInfor.Appearance.Options.UseBackColor = true;
            this.progressBarShowInfor.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressBarShowInfor.AppearanceCaption.Options.UseFont = true;
            this.progressBarShowInfor.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressBarShowInfor.AppearanceDescription.Options.UseFont = true;
            this.progressBarShowInfor.Caption = "Benh Vien HoaiDuc";
            this.progressBarShowInfor.Location = new System.Drawing.Point(12, 132);
            this.progressBarShowInfor.Name = "progressBarShowInfor";
            this.progressBarShowInfor.Size = new System.Drawing.Size(488, 16);
            this.progressBarShowInfor.StyleController = this.layoutControl1;
            this.progressBarShowInfor.TabIndex = 9;
            this.progressBarShowInfor.Text = "progressPanel1";
            // 
            // chkKiemTraHopLe
            // 
            this.chkKiemTraHopLe.Location = new System.Drawing.Point(12, 108);
            this.chkKiemTraHopLe.Name = "chkKiemTraHopLe";
            this.chkKiemTraHopLe.Size = new System.Drawing.Size(350, 20);
            this.chkKiemTraHopLe.TabIndex = 9;
            this.chkKiemTraHopLe.Text = "Kiểm Tra Hợp Lệ";
            this.chkKiemTraHopLe.UseVisualStyleBackColor = true;
            this.chkKiemTraHopLe.CheckedChanged += new System.EventHandler(this.chkKiemTraHopLe_CheckedChanged);
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(104, 84);
            this.txtNhapLaiMatKhau.MenuManager = this.barManager1;
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Properties.PasswordChar = '*';
            this.txtNhapLaiMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(258, 20);
            this.txtNhapLaiMatKhau.StyleController = this.layoutControl1;
            this.txtNhapLaiMatKhau.TabIndex = 8;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(104, 60);
            this.txtMatKhauMoi.MenuManager = this.barManager1;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Properties.PasswordChar = '*';
            this.txtMatKhauMoi.Properties.UseSystemPasswordChar = true;
            this.txtMatKhauMoi.Size = new System.Drawing.Size(258, 20);
            this.txtMatKhauMoi.StyleController = this.layoutControl1;
            this.txtMatKhauMoi.TabIndex = 7;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(104, 36);
            this.txtMatKhauCu.MenuManager = this.barManager1;
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Properties.PasswordChar = '*';
            this.txtMatKhauCu.Properties.UseSystemPasswordChar = true;
            this.txtMatKhauCu.Size = new System.Drawing.Size(258, 20);
            this.txtMatKhauCu.StyleController = this.layoutControl1;
            this.txtMatKhauCu.TabIndex = 5;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(104, 12);
            this.txtTenTaiKhoan.MenuManager = this.barManager1;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Properties.ReadOnly = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(396, 20);
            this.txtTenTaiKhoan.StyleController = this.layoutControl1;
            this.txtTenTaiKhoan.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlUserName,
            this.layoutControlPassOld,
            this.layoutControlPassNew,
            this.layoutControlEnterRePass,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem2});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(512, 160);
            this.Root.TextVisible = false;
            // 
            // layoutControlUserName
            // 
            this.layoutControlUserName.Control = this.txtTenTaiKhoan;
            this.layoutControlUserName.CustomizationFormText = "UserLogin";
            this.layoutControlUserName.Location = new System.Drawing.Point(0, 0);
            this.layoutControlUserName.Name = "layoutControlUserName";
            this.layoutControlUserName.Size = new System.Drawing.Size(492, 24);
            this.layoutControlUserName.Text = "Tên Tài Khoản";
            this.layoutControlUserName.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlPassOld
            // 
            this.layoutControlPassOld.Control = this.txtMatKhauCu;
            this.layoutControlPassOld.CustomizationFormText = "Password Old";
            this.layoutControlPassOld.Location = new System.Drawing.Point(0, 24);
            this.layoutControlPassOld.Name = "layoutControlPassOld";
            this.layoutControlPassOld.Size = new System.Drawing.Size(354, 24);
            this.layoutControlPassOld.Text = "Mật Khẩu Cũ";
            this.layoutControlPassOld.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlPassNew
            // 
            this.layoutControlPassNew.Control = this.txtMatKhauMoi;
            this.layoutControlPassNew.CustomizationFormText = "Password New";
            this.layoutControlPassNew.Location = new System.Drawing.Point(0, 48);
            this.layoutControlPassNew.Name = "layoutControlPassNew";
            this.layoutControlPassNew.Size = new System.Drawing.Size(354, 24);
            this.layoutControlPassNew.Text = "Mật Khẩu Mới";
            this.layoutControlPassNew.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlEnterRePass
            // 
            this.layoutControlEnterRePass.Control = this.txtNhapLaiMatKhau;
            this.layoutControlEnterRePass.CustomizationFormText = "Enter the password";
            this.layoutControlEnterRePass.Location = new System.Drawing.Point(0, 72);
            this.layoutControlEnterRePass.Name = "layoutControlEnterRePass";
            this.layoutControlEnterRePass.Size = new System.Drawing.Size(354, 24);
            this.layoutControlEnterRePass.Text = "Nhập Lại Mật Khẩu";
            this.layoutControlEnterRePass.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkKiemTraHopLe;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(354, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.progressBarShowInfor;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(492, 20);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pictureBox1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(354, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(138, 96);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // A1_FrmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 212);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "A1_FrmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thay Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.A1_FrmPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPassOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPassNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlEnterRePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem barBtnLuu;
        private DevExpress.XtraBars.BarButtonItem barBtnTaiLai;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarListItem barListMessageChangePass;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraWaitForm.ProgressPanel progressBarShowInfor;
        private System.Windows.Forms.CheckBox chkKiemTraHopLe;
        private DevExpress.XtraEditors.TextEdit txtNhapLaiMatKhau;
        private DevExpress.XtraEditors.TextEdit txtMatKhauMoi;
        private DevExpress.XtraEditors.TextEdit txtMatKhauCu;
        private DevExpress.XtraEditors.TextEdit txtTenTaiKhoan;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlUserName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlPassOld;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlPassNew;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlEnterRePass;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}