namespace QlNhanSuBenhVien.UserInterface
{
    partial class U4_FrmCapNhatBangCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(U4_FrmCapNhatBangCC));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnInBaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barBtnLoadLai = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerBangChamCong = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnThietLapBangCC = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCapNhat = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grcBangChamCong = new DevExpress.XtraGrid.GridControl();
            this.gvBangChamCong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerBangChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapNhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcBangChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Caption = "In Báo Cáo";
            this.btnInBaoCao.Id = 4;
            this.btnInBaoCao.Name = "btnInBaoCao";
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 515);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 541);
            this.barDockControlBottom.Size = new System.Drawing.Size(1154, 0);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1154, 26);
            // 
            // barBtnLoadLai
            // 
            this.barBtnLoadLai.Caption = "Load Lại";
            this.barBtnLoadLai.Glyph = global::QlNhanSuBenhVien.Properties.Resources.reload;
            this.barBtnLoadLai.Id = 3;
            this.barBtnLoadLai.Name = "barBtnLoadLai";
            this.barBtnLoadLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLoadLai_ItemClick);
            // 
            // barBtnThemMoi
            // 
            this.barBtnThemMoi.Caption = "Thêm Mới";
            this.barBtnThemMoi.Glyph = global::QlNhanSuBenhVien.Properties.Resources.them1;
            this.barBtnThemMoi.Id = 0;
            this.barBtnThemMoi.Name = "barBtnThemMoi";
            this.barBtnThemMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThemMoi_ItemClick);
            // 
            // barManagerBangChamCong
            // 
            this.barManagerBangChamCong.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManagerBangChamCong.DockControls.Add(this.barDockControlTop);
            this.barManagerBangChamCong.DockControls.Add(this.barDockControlBottom);
            this.barManagerBangChamCong.DockControls.Add(this.barDockControlLeft);
            this.barManagerBangChamCong.DockControls.Add(this.barDockControlRight);
            this.barManagerBangChamCong.Form = this;
            this.barManagerBangChamCong.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnThemMoi,
            this.barBtnLoadLai,
            this.btnInBaoCao,
            this.barBtnThietLapBangCC});
            this.barManagerBangChamCong.MainMenu = this.bar1;
            this.barManagerBangChamCong.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThemMoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnLoadLai, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThietLapBangCC, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barBtnThietLapBangCC
            // 
            this.barBtnThietLapBangCC.Caption = "Thiết Lập Bảng Chấm Công";
            this.barBtnThietLapBangCC.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnThietLapBangCC.Glyph")));
            this.barBtnThietLapBangCC.Id = 7;
            this.barBtnThietLapBangCC.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnThietLapBangCC.LargeGlyph")));
            this.barBtnThietLapBangCC.Name = "barBtnThietLapBangCC";
            this.barBtnThietLapBangCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThietLapBangCC_ItemClick);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1154, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 515);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoHeight = false;
            this.btnCapNhat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::QlNhanSuBenhVien.Properties.Resources.sua1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // grcBangChamCong
            // 
            this.grcBangChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcBangChamCong.Location = new System.Drawing.Point(0, 26);
            this.grcBangChamCong.MainView = this.gvBangChamCong;
            this.grcBangChamCong.MenuManager = this.barManagerBangChamCong;
            this.grcBangChamCong.Name = "grcBangChamCong";
            this.grcBangChamCong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnCapNhat});
            this.grcBangChamCong.Size = new System.Drawing.Size(1154, 515);
            this.grcBangChamCong.TabIndex = 9;
            this.grcBangChamCong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBangChamCong});
            // 
            // gvBangChamCong
            // 
            this.gvBangChamCong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.gvBangChamCong.GridControl = this.grcBangChamCong;
            this.gvBangChamCong.GroupCount = 1;
            this.gvBangChamCong.Name = "gvBangChamCong";
            this.gvBangChamCong.OptionsBehavior.ReadOnly = true;
            this.gvBangChamCong.OptionsFind.AlwaysVisible = true;
            this.gvBangChamCong.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn12, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvBangChamCong.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvBangChamCong_FocusedRowChanged);
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.Caption = "Mã Bảng Chấm Công";
            this.gridColumn11.FieldName = "MaBCC";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 149;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Tháng";
            this.gridColumn12.FieldName = "Thang";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 165;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.Caption = "Số Công";
            this.gridColumn13.FieldName = "SoCong";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            this.gridColumn13.Width = 289;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.Caption = "Số Công Hưởng BHXH";
            this.gridColumn14.FieldName = "SoCongHuongBHXH";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 2;
            this.gridColumn14.Width = 339;
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn15.Caption = "Sửa Thông Tin";
            this.gridColumn15.ColumnEdit = this.btnCapNhat;
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 3;
            this.gridColumn15.Width = 356;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Chọn nhóm quyền thiết lập để thêm chức năng mới";
            this.barStaticItem1.Id = 6;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // U4_FrmCapNhatBangCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 541);
            this.Controls.Add(this.grcBangChamCong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "U4_FrmCapNhatBangCC";
            this.Text = "Cập Nhật Bảng Chấm Công";
            this.Load += new System.EventHandler(this.U4_FrmCapNhatBangCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerBangChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCapNhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcBangChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem btnInBaoCao;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarButtonItem barBtnLoadLai;
        private DevExpress.XtraBars.BarButtonItem barBtnThemMoi;
        private DevExpress.XtraBars.BarManager barManagerBangChamCong;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grcBangChamCong;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnCapNhat;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangChamCong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraBars.BarButtonItem barBtnThietLapBangCC;
    }
}