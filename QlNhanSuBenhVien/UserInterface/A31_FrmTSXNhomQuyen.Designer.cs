namespace QlNhanSuBenhVien.UserInterface
{
    partial class A31_FrmTSXNhomQuyen
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
            this.progressBarShowInfor = new DevExpress.XtraWaitForm.ProgressPanel();
            this.chkKiemTraHopLe = new System.Windows.Forms.CheckBox();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNhomQuyen = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlPassOld = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhomQuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPassOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
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
            this.barBtnTaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnTaiLai_ItemClick);
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barListMessageChangePass, true)});
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barListMessageChangePass
            // 
            this.barListMessageChangePass.Caption = "Quản Lý: Nhóm Quyền";
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 139);
            this.barDockControlBottom.Size = new System.Drawing.Size(512, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 113);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(512, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 113);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.progressBarShowInfor);
            this.layoutControl1.Controls.Add(this.chkKiemTraHopLe);
            this.layoutControl1.Controls.Add(this.txtGhiChu);
            this.layoutControl1.Controls.Add(this.txtTenNhomQuyen);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(512, 113);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
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
            this.progressBarShowInfor.Location = new System.Drawing.Point(12, 84);
            this.progressBarShowInfor.Name = "progressBarShowInfor";
            this.progressBarShowInfor.Size = new System.Drawing.Size(488, 16);
            this.progressBarShowInfor.StyleController = this.layoutControl1;
            this.progressBarShowInfor.TabIndex = 9;
            this.progressBarShowInfor.Text = "progressPanel1";
            // 
            // chkKiemTraHopLe
            // 
            this.chkKiemTraHopLe.Location = new System.Drawing.Point(12, 60);
            this.chkKiemTraHopLe.Name = "chkKiemTraHopLe";
            this.chkKiemTraHopLe.Size = new System.Drawing.Size(488, 20);
            this.chkKiemTraHopLe.TabIndex = 9;
            this.chkKiemTraHopLe.Text = "Kiểm Tra Hợp Lệ";
            this.chkKiemTraHopLe.UseVisualStyleBackColor = true;
            this.chkKiemTraHopLe.CheckedChanged += new System.EventHandler(this.chkKiemTraHopLe_CheckedChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(98, 36);
            this.txtGhiChu.MenuManager = this.barManager1;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(402, 20);
            this.txtGhiChu.StyleController = this.layoutControl1;
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtTenNhomQuyen
            // 
            this.txtTenNhomQuyen.Location = new System.Drawing.Point(98, 12);
            this.txtTenNhomQuyen.MenuManager = this.barManager1;
            this.txtTenNhomQuyen.Name = "txtTenNhomQuyen";
            this.txtTenNhomQuyen.Size = new System.Drawing.Size(402, 20);
            this.txtTenNhomQuyen.StyleController = this.layoutControl1;
            this.txtTenNhomQuyen.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlUserName,
            this.layoutControlPassOld,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(512, 113);
            this.Root.TextVisible = false;
            // 
            // layoutControlUserName
            // 
            this.layoutControlUserName.Control = this.txtTenNhomQuyen;
            this.layoutControlUserName.CustomizationFormText = "UserLogin";
            this.layoutControlUserName.Location = new System.Drawing.Point(0, 0);
            this.layoutControlUserName.Name = "layoutControlUserName";
            this.layoutControlUserName.Size = new System.Drawing.Size(492, 24);
            this.layoutControlUserName.Text = "Tên Nhóm Quyền";
            this.layoutControlUserName.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlPassOld
            // 
            this.layoutControlPassOld.Control = this.txtGhiChu;
            this.layoutControlPassOld.CustomizationFormText = "Password Old";
            this.layoutControlPassOld.Location = new System.Drawing.Point(0, 24);
            this.layoutControlPassOld.Name = "layoutControlPassOld";
            this.layoutControlPassOld.Size = new System.Drawing.Size(492, 24);
            this.layoutControlPassOld.Text = "Ghi Chú";
            this.layoutControlPassOld.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkKiemTraHopLe;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(492, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.progressBarShowInfor;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(492, 21);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // A31_FrmTSXNhomQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 165);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "A31_FrmTSXNhomQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Nhóm Quyền";
            this.Load += new System.EventHandler(this.A31_FrmThemMoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhomQuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlPassOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
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
        private DevExpress.XtraWaitForm.ProgressPanel progressBarShowInfor;
        private System.Windows.Forms.CheckBox chkKiemTraHopLe;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtTenNhomQuyen;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlUserName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlPassOld;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}