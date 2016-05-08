namespace QlNhanSuBenhVien.UserInterface
{
    partial class A3_FrmNhomQuyen
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
            this.barManagerNhomQuyen = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLoadLai = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnInBaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.grcNhomQuyen = new DevExpress.XtraGrid.GridControl();
            this.gvNhomQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnCapNhatDuLieu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerNhomQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCapNhatDuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerNhomQuyen
            // 
            this.barManagerNhomQuyen.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManagerNhomQuyen.DockControls.Add(this.barDockControlTop);
            this.barManagerNhomQuyen.DockControls.Add(this.barDockControlBottom);
            this.barManagerNhomQuyen.DockControls.Add(this.barDockControlLeft);
            this.barManagerNhomQuyen.DockControls.Add(this.barDockControlRight);
            this.barManagerNhomQuyen.Form = this;
            this.barManagerNhomQuyen.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnThemMoi,
            this.barBtnXoa,
            this.barBtnLoadLai,
            this.btnInBaoCao});
            this.barManagerNhomQuyen.MainMenu = this.bar1;
            this.barManagerNhomQuyen.MaxItemId = 5;
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
            // barBtnXoa
            // 
            this.barBtnXoa.Caption = "Xóa";
            this.barBtnXoa.Glyph = global::QlNhanSuBenhVien.Properties.Resources.xoa1;
            this.barBtnXoa.Id = 2;
            this.barBtnXoa.Name = "barBtnXoa";
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Caption = "In Báo Cáo";
            this.btnInBaoCao.Id = 4;
            this.btnInBaoCao.Name = "btnInBaoCao";
            // 
            // grcNhomQuyen
            // 
            this.grcNhomQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNhomQuyen.Location = new System.Drawing.Point(0, 26);
            this.grcNhomQuyen.MainView = this.gvNhomQuyen;
            this.grcNhomQuyen.MenuManager = this.barManagerNhomQuyen;
            this.grcNhomQuyen.Name = "grcNhomQuyen";
            this.grcNhomQuyen.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BtnCapNhatDuLieu});
            this.grcNhomQuyen.Size = new System.Drawing.Size(1154, 515);
            this.grcNhomQuyen.TabIndex = 4;
            this.grcNhomQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomQuyen});
            // 
            // gvNhomQuyen
            // 
            this.gvNhomQuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvNhomQuyen.GridControl = this.grcNhomQuyen;
            this.gvNhomQuyen.Name = "gvNhomQuyen";
            this.gvNhomQuyen.OptionsBehavior.ReadOnly = true;
            this.gvNhomQuyen.OptionsFind.AlwaysVisible = true;
            this.gvNhomQuyen.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvNhomQuyen_FocusedRowChanged_1);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Mã Nhóm Quyền";
            this.gridColumn1.FieldName = "MaNhomQuyen";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 114;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Tên Nhóm Quyền";
            this.gridColumn2.FieldName = "TenNhomQuyen";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 188;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Ghi Chú";
            this.gridColumn3.FieldName = "GhiChu";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 705;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Sửa Thông Tin";
            this.gridColumn4.ColumnEdit = this.BtnCapNhatDuLieu;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 126;
            // 
            // BtnCapNhatDuLieu
            // 
            this.BtnCapNhatDuLieu.AutoHeight = false;
            this.BtnCapNhatDuLieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::QlNhanSuBenhVien.Properties.Resources.sua1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.BtnCapNhatDuLieu.Name = "BtnCapNhatDuLieu";
            this.BtnCapNhatDuLieu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.BtnCapNhatDuLieu.Click += new System.EventHandler(this.BtnCapNhatDuLieu_Click);
            // 
            // A3_FrmNhomQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 541);
            this.Controls.Add(this.grcNhomQuyen);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "A3_FrmNhomQuyen";
            this.Text = "Nhóm Quyền";
            this.Load += new System.EventHandler(this.FrmNhomQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerNhomQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCapNhatDuLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerNhomQuyen;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnThemMoi;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
        private DevExpress.XtraBars.BarButtonItem barBtnLoadLai;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grcNhomQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraBars.BarButtonItem btnInBaoCao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnCapNhatDuLieu;
    }
}