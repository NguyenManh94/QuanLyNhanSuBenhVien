namespace QlNhanSuBenhVien.UserInterface
{
    partial class U3_FrmCapNhatBangLuong
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.grcBangLuong = new DevExpress.XtraGrid.GridControl();
            this.gvBangLuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCapNhat = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barManagerBangLuong = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLoadLai = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnInBaoCao = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.grcBangLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapNhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Chọn nhóm quyền thiết lập để thêm chức năng mới";
            this.barStaticItem1.Id = 6;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // grcBangLuong
            // 
            this.grcBangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcBangLuong.Location = new System.Drawing.Point(0, 26);
            this.grcBangLuong.MainView = this.gvBangLuong;
            this.grcBangLuong.MenuManager = this.barManagerBangLuong;
            this.grcBangLuong.Name = "grcBangLuong";
            this.grcBangLuong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnCapNhat});
            this.grcBangLuong.Size = new System.Drawing.Size(1154, 515);
            this.grcBangLuong.TabIndex = 8;
            this.grcBangLuong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBangLuong});
            // 
            // gvBangLuong
            // 
            this.gvBangLuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24});
            this.gvBangLuong.GridControl = this.grcBangLuong;
            this.gvBangLuong.GroupCount = 1;
            this.gvBangLuong.Name = "gvBangLuong";
            this.gvBangLuong.OptionsBehavior.ReadOnly = true;
            this.gvBangLuong.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn22, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvBangLuong.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvBangLuong_FocusedRowChanged);
            // 
            // gridColumn17
            // 
            this.gridColumn17.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn17.Caption = "Mã Bảng Lương";
            this.gridColumn17.FieldName = "MaBL";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 0;
            this.gridColumn17.Width = 97;
            // 
            // gridColumn18
            // 
            this.gridColumn18.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn18.Caption = "Hệ Số Chức Vụ";
            this.gridColumn18.FieldName = "HeSoCV";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 1;
            this.gridColumn18.Width = 121;
            // 
            // gridColumn19
            // 
            this.gridColumn19.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn19.Caption = "Hệ Số Lương";
            this.gridColumn19.FieldName = "HeSoLuong";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 2;
            this.gridColumn19.Width = 99;
            // 
            // gridColumn20
            // 
            this.gridColumn20.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn20.Caption = "Phụ Cấp Thâm Niên (VNĐ)";
            this.gridColumn20.FieldName = "PhuCapThamNien";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 3;
            this.gridColumn20.Width = 174;
            // 
            // gridColumn21
            // 
            this.gridColumn21.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn21.Caption = "Các Khoản Đóng Góp (VNĐ)";
            this.gridColumn21.FieldName = "CacKhoanDongGop";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 4;
            this.gridColumn21.Width = 199;
            // 
            // gridColumn22
            // 
            this.gridColumn22.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn22.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn22.Caption = "Lương Khởi Điểm (VNĐ)";
            this.gridColumn22.FieldName = "TongLuong";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 5;
            this.gridColumn22.Width = 176;
            // 
            // gridColumn23
            // 
            this.gridColumn23.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn23.Caption = "Thực Lĩnh (VNĐ)";
            this.gridColumn23.FieldName = "ThucLinh";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 5;
            this.gridColumn23.Width = 166;
            // 
            // gridColumn24
            // 
            this.gridColumn24.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn24.Caption = "Sửa Thông Tin";
            this.gridColumn24.ColumnEdit = this.btnCapNhat;
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 6;
            this.gridColumn24.Width = 101;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoHeight = false;
            this.btnCapNhat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::QlNhanSuBenhVien.Properties.Resources.sua1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // barManagerBangLuong
            // 
            this.barManagerBangLuong.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManagerBangLuong.DockControls.Add(this.barDockControlTop);
            this.barManagerBangLuong.DockControls.Add(this.barDockControlBottom);
            this.barManagerBangLuong.DockControls.Add(this.barDockControlLeft);
            this.barManagerBangLuong.DockControls.Add(this.barDockControlRight);
            this.barManagerBangLuong.Form = this;
            this.barManagerBangLuong.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnThemMoi,
            this.barBtnLoadLai,
            this.btnInBaoCao});
            this.barManagerBangLuong.MainMenu = this.bar1;
            this.barManagerBangLuong.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThemMoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnLoadLai, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barBtnThemMoi
            // 
            this.barBtnThemMoi.Caption = "Thêm Mới";
            this.barBtnThemMoi.Glyph = global::QlNhanSuBenhVien.Properties.Resources.them1;
            this.barBtnThemMoi.Id = 0;
            this.barBtnThemMoi.Name = "barBtnThemMoi";
            this.barBtnThemMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThemMoi_ItemClick);
            // 
            // barBtnLoadLai
            // 
            this.barBtnLoadLai.Caption = "Load Lại";
            this.barBtnLoadLai.Glyph = global::QlNhanSuBenhVien.Properties.Resources.reload;
            this.barBtnLoadLai.Id = 3;
            this.barBtnLoadLai.Name = "barBtnLoadLai";
            this.barBtnLoadLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLoadLai_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1154, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 541);
            this.barDockControlBottom.Size = new System.Drawing.Size(1154, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 515);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1154, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 515);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Caption = "In Báo Cáo";
            this.btnInBaoCao.Id = 4;
            this.btnInBaoCao.Name = "btnInBaoCao";
            // 
            // U3_FrmCapNhatBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 541);
            this.Controls.Add(this.grcBangLuong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "U3_FrmCapNhatBangLuong";
            this.Text = "Cập Nhật Bảng Lương";
            this.Load += new System.EventHandler(this.U3_FrmCapNhatBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcBangLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapNhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerBangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraGrid.GridControl grcBangLuong;
        private DevExpress.XtraBars.BarManager barManagerBangLuong;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnThemMoi;
        private DevExpress.XtraBars.BarButtonItem barBtnLoadLai;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnInBaoCao;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnCapNhat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
    }
}