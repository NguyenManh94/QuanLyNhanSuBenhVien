using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using QlNhanSuBenhVien.LinqBiz;
using QlNhanSuBenhVien.Reports;
using QlNhanSuBenhVien.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QlNhanSuBenhVien
{
    public partial class FrmChinh : RibbonForm
    {
        #region Khơi tạo chương trình
        public FrmChinh()
        {
            Thietlap = this;
            InitializeComponent();
            InitSkinGallery();
        }
        void InitSkinGallery() { SkinHelper.InitSkinGallery(rgbiSkins, true); }

        //Thiết lập quyền đăng nhập
        /*Thiết lập cho việc phân quyền Đăng Nhập*/
        public static FrmChinh Thietlap = null;
        public NguoiDung ThongTinNguoiDung { get; set; }
        public void ThietLapQuyen(int maNhomQuyen)
        {
            try
            {
                //Lấy ra danh sách Tên chức năng thuộc nhóm quyền
                var bvContext = new QlBenhVienDataContext();
                var lstChucNang = bvContext.ChiTietNhomQuyens.Where(ctnq => ctnq.MaNhomQuyen == maNhomQuyen)
                    .Join(bvContext.ChucNangs, ctnq => ctnq.MaChucNang, cn => cn.MaChucNang
                    , (ctnq, cn) => new { cn.TenChucNang }).ToList();
                List<string> lstChucNangNew = new List<string>();
                foreach (var item in lstChucNang)
                {
                    lstChucNangNew.Add(item.TenChucNang);
                }

                #region Đặt ẩn hiện cho các nút
                //Khởi tạo danh sách các nút button
                List<BarButtonItem> lstBarButton = new List<BarButtonItem>
                {
                    barBtnCapNhatHoSo,barBtnCapNhatCaTruc,barBtnCapNhatBangLuong
                    ,barBtnCapNhatBangChamCong,
                    barBtnTimKiemHoSo,barBtnTimKiemCaTruc,barBtnTimKiemBangLuong
                    ,barBtnTimKiemBangChamCong,barBtnTimKiemKhoavaChucVu,
                    barBtnBaoCaoHoSo,barBtnBaoCaoCaTruc,barBtnBaoCaoBangLuong,barBtnBaoCaoBangChamCong
                };

                //Kiểm tra nếu caption của 1 nút có chứa trong danh sách lstChucNangNew thì cho nó mở lên
                foreach (var barButtonItem in lstBarButton)
                {
                    if (lstChucNangNew.Contains(barButtonItem.Name))
                        barButtonItem.Enabled = true;
                    else barButtonItem.Enabled = false;
                }
                if (maNhomQuyen == 1)
                {
                    barBtnNhomQuyen.Enabled = barBtnChucNang.Enabled =
                        barBtnThietLapQuyen.Enabled = barBtnNguoiDung.Enabled = true;
                }
                else
                {
                    barBtnNhomQuyen.Enabled = barBtnChucNang.Enabled =
                        barBtnThietLapQuyen.Enabled = barBtnNguoiDung.Enabled = false;
                }
                barBtnDangNhap.Enabled = false;
                barBtnDangXuat.Enabled = true;
                barBtnChangePass.Enabled = true;
                barBtnTaiKhoan.Enabled = true;
                #endregion

                siTaiKhoan.Caption = "Tài Khoản: " + ThongTinNguoiDung.TenTaiKhoan;
                siTrangThai.Caption = ThongTinNguoiDung.TrangThai == true ?
                    "Trạng Thái: Kích Hoạt" : "Trạng Thái: Ngừng Kích Hoạt";
                siNhomQuyen.Caption = "Nhóm Quyền: " + ThongTinNguoiDung.NhomQuyen.TenNhomQuyen;
            }
            catch { }
        }
        #endregion

        /*Đặt ẩn hết các nút*/
        private void SetEnalbleButton()
        {

        }
        private void FrmChinh_Load(object sender, EventArgs e)
        {
            SetEnableButtonMacDinh(false);
            Localizer.Active = new ThongBaoViet("&Hủy bỏ", "&Hủy", "&Bỏ qua", "&Không", "&Chấp Nhận", "&Thử lại", "&Có");
            A6_FrmDangNhap frm = new A6_FrmDangNhap();
            frm.ShowDialog();
        }
        private void iAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show(new StringBuilder("Quản Lý Nhân Sự Bệnh Viện Việt Đức Version 1.1!")
                .Append(Environment.NewLine).Append("    Sở hữu: Hoàng Việt Đức")
                .Append(Environment.NewLine).Append("    Địa chỉ: ducviethoang.net@gmail.com")
                .Append(Environment.NewLine).Append("    Phone: 0972010044")
                .Append(Environment.NewLine).Append("    Cảm ơn quý khách đã sử dụng chương trình!").ToString(), "Thông báo!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barBtnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = XtraMessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Chú ý!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void barBtnRestart_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = XtraMessageBox.Show("Bạn có muốn khởi động lại chương trình?", "Chú ý!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void barBtnTroGiup_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show(new StringBuilder("Quản Lý Nhân Sự Bệnh Viện Việt Đức Version 1.1!")
            .Append(Environment.NewLine).Append("    Sở hữu: Hoàng Việt Đức")
            .Append(Environment.NewLine).Append("    Địa chỉ: ducviethoang.net@gmail.com")
            .Append(Environment.NewLine).Append("    Phone: 0972010044")
            .Append(Environment.NewLine).Append("    Cảm ơn quý khách đã sử dụng chương trình!").ToString(), "Thông báo!",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barBtnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show(new StringBuilder("Quản Lý Nhân Sự Bệnh Viện Việt Đức Version 1.1!")
            .Append(Environment.NewLine).Append("    Được phát triển bởi sinh viên Hoàng Việt Đức lớp KTPMCLC-K7")
            .Append(Environment.NewLine).Append("    Hệ thống phát triển đáp ứng nhu cầu quản lý nhân sự tại bệnh viện")
            .Append(Environment.NewLine).Append("    Việt Đức Hà Nội!")
            .Append(Environment.NewLine).Append("    Mọi chi tiết và phản hồi vui lòng liên hệ về hòm thư!")
            .Append(Environment.NewLine).Append("    Email: ducviethoang.net@gmail.com hoặc phone: 0972010044 !")
            .Append(Environment.NewLine).Append("Thân cảm ơn quý khách đã sử dụng chương trình!").ToString()
            , "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barBtnBaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show(new StringBuilder("Phần mục báo cáo. Thống kê chi tiết báo cáo của của hệ thống!")
                .ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barBtnTimKiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show(new StringBuilder("Phần mục tìm kiếm. Tìm kiếm thông tin chi tiết của các danh mục!")
                .ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barBtnCapNhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show(new StringBuilder("Phần mục cập nhật. Cập nhật thông tin chi tiết của các danh mục!")
                .ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barBtnChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmPassword = new A1_FrmPassword();
            frmPassword.TenTaiKhoan = ThongTinNguoiDung.TenTaiKhoan;
            frmPassword.MatKhauHienTai = ThongTinNguoiDung.MatKhau;
            frmPassword.MaNguoiDung = ThongTinNguoiDung.ID;
            frmPassword.ShowDialog();
        }

        private void barBtnTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmTaiKhoan = new A2_FrmTaiKhoan();
            frmTaiKhoan.NguoiDungChiTiet = ThongTinNguoiDung;
            frmTaiKhoan.ShowDialog();
        }

        private void barBtnNhomQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
                  , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp dữ liệu -Nhóm Quyền-", null);

            var frm = CheckFormExists(typeof(A3_FrmNhomQuyen));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new A3_FrmNhomQuyen { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private Form CheckFormExists(Type fType)
        {
            return MdiChildren.FirstOrDefault(f => f.GetType() == fType);
        }

        private void barBtnChucNang_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
                  , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp dữ liệu các -Chức Năng-", null);
            var frm = CheckFormExists(typeof(A4_FrmChucNang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new A4_FrmChucNang { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnThietLapQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
                  , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp các dữ liệu liên quan!", null);
            var frm = CheckFormExists(typeof(A7_FrmThietLapQuyen));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new A7_FrmThietLapQuyen { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
                  , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp các dữ liệu -Người Dùng-", null);
            var frm = CheckFormExists(typeof(A5_FrmNguoiDung));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new A5_FrmNguoiDung { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnCapNhatHoSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
                , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp các dữ liệu -Hồ Sơ-", null);
            var frm = CheckFormExists(typeof(U1_FrmCapNhatHoSo));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new U1_FrmCapNhatHoSo { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnCapNhatCaTruc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = CheckFormExists(typeof(U2_FrmCapNhatCaTruc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new U2_FrmCapNhatCaTruc { MdiParent = this };
                f.Show();
            }
        }

        private void barBtnCapNhatBangLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
               , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp các dữ liệu -Bảng Lương-", null);
            var frm = CheckFormExists(typeof(U3_FrmCapNhatBangLuong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new U3_FrmCapNhatBangLuong { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnCapNhatBangChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
               , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp các dữ liệu -Bảng Chấm Công-", null);
            var frm = CheckFormExists(typeof(U4_FrmCapNhatBangCC));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new U4_FrmCapNhatBangCC { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnTimKiemHoSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
               , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp các dữ liệu -Hồ Sơ Nhân Viên-", null);
            var frm = CheckFormExists(typeof(T1_FrmTimKiemHoSo));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new T1_FrmTimKiemHoSo { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnTimKiemCaTruc_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
               , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp các dữ liệu -Thông tin Ca Trực-", null);
            var frm = CheckFormExists(typeof(T2_FrmTimKiemCaTruc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new T2_FrmTimKiemCaTruc { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnTimKiemBangLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
               , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp các dữ liệu -Thông Tin Bảng Lương-", null);
            var frm = CheckFormExists(typeof(T3_FrmTimKiemBangLuong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new T3_FrmTimKiemBangLuong { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnTimKiemBangChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
                , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp các dữ liệu -Bảng Chấm Công-", null);
            var frm = CheckFormExists(typeof(T4_FrmTimKiemBangCC));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new T4_FrmTimKiemBangCC { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new A6_FrmDangNhap();
            f.ShowDialog();
        }

        /// <summary>
        ///     [EN] ShowWaitForm
        ///     Create By: DucHV -Date:02/25/2016
        ///     Descripton: ShowWaitForm
        /// </summary>
        /// <param name="frmWaitForm">Form Used</param>
        /// <param name="strCaption">
        ///     Title WaitForm:
        ///     if strCaption = null => Value = Please Wait
        ///     else => Value = strCaption
        /// </param>
        /// <param name="strDescription">Description WaitForm</param>
        /// <returns>SplashScreenManager Type</returns>
        public static SplashScreenManager ShowWaitForm(Form frmWaitForm, string strCaption
            , string strDescription)
        {
            var splashScreenManager = new SplashScreenManager(frmWaitForm
                , typeof(WaitFormPlease), true, true);
            splashScreenManager.ShowWaitForm();
            if (strCaption == null)
                splashScreenManager.SetWaitFormCaption("Vui lòng chờ đợi trong giây lát");
            else splashScreenManager.SetWaitFormCaption(strCaption);
            // Nếu Null thì dùng strDescription không thì  Set_Loading
            splashScreenManager.SetWaitFormDescription(strDescription ?? "Nạp dữ liệu chương trình ...");
            return splashScreenManager;
        }

        private void barBtnCapNhatKhoavaChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = XtraMessageBox.Show("Bạn có muốn đăng xuất tài khoản khỏi hệ thống!", "Chú ý!"
               , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //SetEnable het cac nut
                //Khởi tạo danh sách các nút button
                SetEnableButtonMacDinh(false);
                barBtnDangNhap.Enabled = true;
                barBtnDangXuat.Enabled = false;
                siNhomQuyen.Caption = "Nhóm Quyền: --*--";
                siTaiKhoan.Caption = "Tài Khoản: --*--";
                siTrangThai.Caption = "Trạng Thái: --*--";
                //Đóng hết toàn bộ các form con lại
                foreach (var f in MdiChildren)
                {
                    f.Close();
                }
                var frm = new A6_FrmDangNhap();
                frm.ShowDialog();
            }
        }

        private void SetEnableButtonMacDinh(bool valueSet)
        {
            List<BarButtonItem> lstBarButton = new List<BarButtonItem>
                {
                    barBtnCapNhatHoSo,barBtnCapNhatCaTruc,barBtnCapNhatBangLuong
                    ,barBtnCapNhatBangChamCong,
                    barBtnTimKiemHoSo,barBtnTimKiemCaTruc,barBtnTimKiemBangLuong
                    ,barBtnTimKiemBangChamCong,barBtnTimKiemKhoavaChucVu,
                    barBtnBaoCaoHoSo,barBtnBaoCaoCaTruc,barBtnBaoCaoBangLuong,barBtnBaoCaoBangChamCong,
                    barBtnNhomQuyen,barBtnChucNang,barBtnThietLapQuyen,barBtnNguoiDung,
                    barBtnChangePass,barBtnTaiKhoan
                };
            foreach (var item in lstBarButton)
            {
                item.Enabled = valueSet;
            }
        }

        private void barBtnTimKiemKhoavaChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
               , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp các dữ liệu -Chức Vụ và Khoa-", null);
            var frm = CheckFormExists(typeof(T5_FrmTimKiemKhoaVaCV));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new T5_FrmTimKiemKhoaVaCV { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnBaoCaoHoSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
               , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp các dữ liệu -Hồ sơ nhân viên-", null);
            var frm = CheckFormExists(typeof(B1_FrmBaoCaoHoSo));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new B1_FrmBaoCaoHoSo { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnBaoCaoCaTruc_ItemClick(object sender, ItemClickEventArgs e)
        {
            //
            SplashScreenManager splashScreenManagerCheckConnect = new SplashScreenManager(this
               , typeof(WaitFormPlease), true, true);
            var splashScreenManager = ShowWaitForm(this, "Vui lòng chờ đợi trong lúc nạp các dữ liệu -Ca Trực-"
                , null);
            var frm = CheckFormExists(typeof(B2_FrmBaoCaoCaTruc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                var f = new B2_FrmBaoCaoCaTruc { MdiParent = this };
                f.Show();
            }
            splashScreenManager.CloseWaitForm();
        }

        private void barBtnBaoCaoBangChamCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                RptBangChamCong rpt = new RptBangChamCong();
                rpt.CreateDocument();
                rpt.ShowPreviewDialog();
            }
            catch
            {

            }
        }
    }
}