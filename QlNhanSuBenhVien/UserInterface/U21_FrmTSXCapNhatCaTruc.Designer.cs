namespace QlNhanSuBenhVien.UserInterface
{
    partial class U21_FrmTSXCapNhatCaTruc
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
            this.barManagerCapNhatHoSo = new DevExpress.XtraBars.BarManager();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barBtnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barListMessageChangePass = new DevExpress.XtraBars.BarListItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutQuanLyCaTruc = new DevExpress.XtraLayout.LayoutControl();
            this.dtThoiGianPhanCong = new DevExpress.XtraEditors.DateEdit();
            this.txtMaBPCCT = new DevExpress.XtraEditors.TextEdit();
            this.progressBarShowInfor = new DevExpress.XtraWaitForm.ProgressPanel();
            this.chkKiemTraHopLe = new System.Windows.Forms.CheckBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCapNhatHoSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutQuanLyCaTruc)).BeginInit();
            this.layoutQuanLyCaTruc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtThoiGianPhanCong.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtThoiGianPhanCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBPCCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerCapNhatHoSo
            // 
            this.barManagerCapNhatHoSo.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4,
            this.bar5});
            this.barManagerCapNhatHoSo.DockControls.Add(this.barDockControlTop);
            this.barManagerCapNhatHoSo.DockControls.Add(this.barDockControlBottom);
            this.barManagerCapNhatHoSo.DockControls.Add(this.barDockControlLeft);
            this.barManagerCapNhatHoSo.DockControls.Add(this.barDockControlRight);
            this.barManagerCapNhatHoSo.Form = this;
            this.barManagerCapNhatHoSo.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnTaiLai,
            this.barBtnLuu,
            this.barListMessageChangePass});
            this.barManagerCapNhatHoSo.MainMenu = this.bar4;
            this.barManagerCapNhatHoSo.MaxItemId = 4;
            this.barManagerCapNhatHoSo.StatusBar = this.bar5;
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
            this.barListMessageChangePass.Caption = "Quản Lý: Bảng Phân Công Ca Trực";
            this.barListMessageChangePass.Id = 3;
            this.barListMessageChangePass.Name = "barListMessageChangePass";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(562, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 116);
            this.barDockControlBottom.Size = new System.Drawing.Size(562, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 90);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(562, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 90);
            // 
            // layoutQuanLyCaTruc
            // 
            this.layoutQuanLyCaTruc.Controls.Add(this.dtThoiGianPhanCong);
            this.layoutQuanLyCaTruc.Controls.Add(this.txtMaBPCCT);
            this.layoutQuanLyCaTruc.Controls.Add(this.progressBarShowInfor);
            this.layoutQuanLyCaTruc.Controls.Add(this.chkKiemTraHopLe);
            this.layoutQuanLyCaTruc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutQuanLyCaTruc.Location = new System.Drawing.Point(0, 26);
            this.layoutQuanLyCaTruc.Name = "layoutQuanLyCaTruc";
            this.layoutQuanLyCaTruc.Root = this.Root;
            this.layoutQuanLyCaTruc.Size = new System.Drawing.Size(562, 90);
            this.layoutQuanLyCaTruc.TabIndex = 15;
            this.layoutQuanLyCaTruc.Text = "layoutControl1";
            // 
            // dtThoiGianPhanCong
            // 
            this.dtThoiGianPhanCong.EditValue = null;
            this.dtThoiGianPhanCong.Location = new System.Drawing.Point(423, 12);
            this.dtThoiGianPhanCong.MenuManager = this.barManagerCapNhatHoSo;
            this.dtThoiGianPhanCong.Name = "dtThoiGianPhanCong";
            this.dtThoiGianPhanCong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtThoiGianPhanCong.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtThoiGianPhanCong.Size = new System.Drawing.Size(127, 20);
            this.dtThoiGianPhanCong.StyleController = this.layoutQuanLyCaTruc;
            this.dtThoiGianPhanCong.TabIndex = 15;
            // 
            // txtMaBPCCT
            // 
            this.txtMaBPCCT.Location = new System.Drawing.Point(152, 12);
            this.txtMaBPCCT.Name = "txtMaBPCCT";
            this.txtMaBPCCT.Properties.ReadOnly = true;
            this.txtMaBPCCT.Size = new System.Drawing.Size(127, 20);
            this.txtMaBPCCT.StyleController = this.layoutQuanLyCaTruc;
            this.txtMaBPCCT.TabIndex = 14;
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
            this.progressBarShowInfor.Location = new System.Drawing.Point(12, 60);
            this.progressBarShowInfor.Name = "progressBarShowInfor";
            this.progressBarShowInfor.Size = new System.Drawing.Size(538, 16);
            this.progressBarShowInfor.StyleController = this.layoutQuanLyCaTruc;
            this.progressBarShowInfor.TabIndex = 9;
            this.progressBarShowInfor.Text = "progressPanel1";
            // 
            // chkKiemTraHopLe
            // 
            this.chkKiemTraHopLe.Location = new System.Drawing.Point(12, 36);
            this.chkKiemTraHopLe.Name = "chkKiemTraHopLe";
            this.chkKiemTraHopLe.Size = new System.Drawing.Size(538, 20);
            this.chkKiemTraHopLe.TabIndex = 9;
            this.chkKiemTraHopLe.Text = "Kiểm Tra Hợp Lệ";
            this.chkKiemTraHopLe.UseVisualStyleBackColor = true;
            this.chkKiemTraHopLe.CheckedChanged += new System.EventHandler(this.chkKiemTraHopLe_CheckedChanged);
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem2});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(562, 90);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkKiemTraHopLe;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(542, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.progressBarShowInfor;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(542, 22);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtMaBPCCT;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(271, 24);
            this.layoutControlItem7.Text = "Mã Bảng Phân Công Ca Trực";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(137, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtThoiGianPhanCong;
            this.layoutControlItem2.Location = new System.Drawing.Point(271, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(271, 24);
            this.layoutControlItem2.Text = "Thời Gian Phân Công";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(137, 13);
            // 
            // U21_FrmTSXCapNhatCaTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 142);
            this.Controls.Add(this.layoutQuanLyCaTruc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "U21_FrmTSXCapNhatCaTruc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng Phân Công Ca Trực";
            this.Load += new System.EventHandler(this.U2_FrmTSXCapNhatCaTruc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCapNhatHoSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutQuanLyCaTruc)).EndInit();
            this.layoutQuanLyCaTruc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtThoiGianPhanCong.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtThoiGianPhanCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBPCCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerCapNhatHoSo;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem barBtnLuu;
        private DevExpress.XtraBars.BarButtonItem barBtnTaiLai;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarListItem barListMessageChangePass;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutQuanLyCaTruc;
        private DevExpress.XtraEditors.DateEdit dtThoiGianPhanCong;
        private DevExpress.XtraEditors.TextEdit txtMaBPCCT;
        private DevExpress.XtraWaitForm.ProgressPanel progressBarShowInfor;
        private System.Windows.Forms.CheckBox chkKiemTraHopLe;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}