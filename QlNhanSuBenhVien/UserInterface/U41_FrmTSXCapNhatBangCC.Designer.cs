namespace QlNhanSuBenhVien.UserInterface
{
    partial class U41_FrmTSXCapNhatBangCC
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
            this.barManagerBangChamCong = new DevExpress.XtraBars.BarManager(this.components);
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
            this.cbThang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSoBHXH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaBangCC = new DevExpress.XtraEditors.TextEdit();
            this.txtSoCong = new DevExpress.XtraEditors.TextEdit();
            this.progressBarShowInfor = new DevExpress.XtraWaitForm.ProgressPanel();
            this.chkKiemTraHopLe = new System.Windows.Forms.CheckBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerBangChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbThang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoBHXH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBangCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerBangChamCong
            // 
            this.barManagerBangChamCong.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4,
            this.bar5});
            this.barManagerBangChamCong.DockControls.Add(this.barDockControlTop);
            this.barManagerBangChamCong.DockControls.Add(this.barDockControlBottom);
            this.barManagerBangChamCong.DockControls.Add(this.barDockControlLeft);
            this.barManagerBangChamCong.DockControls.Add(this.barDockControlRight);
            this.barManagerBangChamCong.Form = this;
            this.barManagerBangChamCong.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnTaiLai,
            this.barBtnLuu,
            this.barListMessageChangePass});
            this.barManagerBangChamCong.MainMenu = this.bar4;
            this.barManagerBangChamCong.MaxItemId = 4;
            this.barManagerBangChamCong.StatusBar = this.bar5;
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
            this.barListMessageChangePass.Caption = "Quản Lý: Bảng Chấm Công";
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 140);
            this.barDockControlBottom.Size = new System.Drawing.Size(562, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 114);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(562, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 114);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbThang);
            this.layoutControl1.Controls.Add(this.txtSoBHXH);
            this.layoutControl1.Controls.Add(this.txtMaBangCC);
            this.layoutControl1.Controls.Add(this.txtSoCong);
            this.layoutControl1.Controls.Add(this.progressBarShowInfor);
            this.layoutControl1.Controls.Add(this.chkKiemTraHopLe);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 26);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(562, 114);
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbThang
            // 
            this.cbThang.EditValue = "1";
            this.cbThang.Location = new System.Drawing.Point(114, 36);
            this.cbThang.MenuManager = this.barManagerBangChamCong;
            this.cbThang.Name = "cbThang";
            this.cbThang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.Properties.Appearance.Options.UseFont = true;
            this.cbThang.Properties.Appearance.Options.UseTextOptions = true;
            this.cbThang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cbThang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbThang.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbThang.Size = new System.Drawing.Size(50, 20);
            this.cbThang.StyleController = this.layoutControl1;
            this.cbThang.TabIndex = 24;
            // 
            // txtSoBHXH
            // 
            this.txtSoBHXH.Location = new System.Drawing.Point(457, 36);
            this.txtSoBHXH.Name = "txtSoBHXH";
            this.txtSoBHXH.Size = new System.Drawing.Size(93, 20);
            this.txtSoBHXH.StyleController = this.layoutControl1;
            this.txtSoBHXH.TabIndex = 23;
            // 
            // txtMaBangCC
            // 
            this.txtMaBangCC.Location = new System.Drawing.Point(114, 12);
            this.txtMaBangCC.Name = "txtMaBangCC";
            this.txtMaBangCC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBangCC.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMaBangCC.Properties.Appearance.Options.UseFont = true;
            this.txtMaBangCC.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaBangCC.Properties.ReadOnly = true;
            this.txtMaBangCC.Size = new System.Drawing.Size(436, 20);
            this.txtMaBangCC.StyleController = this.layoutControl1;
            this.txtMaBangCC.TabIndex = 14;
            // 
            // txtSoCong
            // 
            this.txtSoCong.Location = new System.Drawing.Point(270, 36);
            this.txtSoCong.Name = "txtSoCong";
            this.txtSoCong.Size = new System.Drawing.Size(81, 20);
            this.txtSoCong.StyleController = this.layoutControl1;
            this.txtSoCong.TabIndex = 11;
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
            this.progressBarShowInfor.Size = new System.Drawing.Size(538, 16);
            this.progressBarShowInfor.StyleController = this.layoutControl1;
            this.progressBarShowInfor.TabIndex = 9;
            this.progressBarShowInfor.Text = "progressPanel1";
            // 
            // chkKiemTraHopLe
            // 
            this.chkKiemTraHopLe.Location = new System.Drawing.Point(12, 60);
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
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(562, 114);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkKiemTraHopLe;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(542, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.progressBarShowInfor;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(542, 22);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtMaBangCC;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(542, 24);
            this.layoutControlItem7.Text = "Mã Bảng Chấm Công";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSoCong;
            this.layoutControlItem2.Location = new System.Drawing.Point(156, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(187, 24);
            this.layoutControlItem2.Text = "Số Công";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbThang;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(156, 24);
            this.layoutControlItem4.Text = "Tháng";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtSoBHXH;
            this.layoutControlItem3.Location = new System.Drawing.Point(343, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(199, 24);
            this.layoutControlItem3.Text = "Số Bảo Hiểm Xã Hội";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(99, 13);
            // 
            // U41_FrmTSXCapNhatBangCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 166);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "U41_FrmTSXCapNhatBangCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập Nhật Bảng Chấm Công";
            this.Load += new System.EventHandler(this.U41_FrmTSXCapNhatBangCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerBangChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbThang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoBHXH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBangCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerBangChamCong;
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
        private DevExpress.XtraEditors.TextEdit txtSoBHXH;
        private DevExpress.XtraEditors.TextEdit txtMaBangCC;
        private DevExpress.XtraEditors.TextEdit txtSoCong;
        private DevExpress.XtraWaitForm.ProgressPanel progressBarShowInfor;
        private System.Windows.Forms.CheckBox chkKiemTraHopLe;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ComboBoxEdit cbThang;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}