using DevExpress.XtraEditors;
using QlNhanSuBenhVien.LinqBiz;
using System;
using System.Windows.Forms;
using System.Linq;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class A6_FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public A6_FrmDangNhap()
        {
            InitializeComponent();
        }

        private void A6_FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Text = txtPassword.Text = "";
            txtUserName.Focus();
        }

        private void SetAppExit()
        {
            var result = XtraMessageBox.Show("Bạn có thực sự muốn thoát chương trình", "Chú ý!"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThoat_CheckedChanged(object sender, EventArgs e)
        {
            SetAppExit();
        }

        public static string _TenTaiKhoan;
        private void btnDangNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim().Length == 0
                || txtUserName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Tên tài khoản hoặc mật khẩu không được phép để chống!", "Chú ý!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var bvContext = new QlBenhVienDataContext();

                // Mã hóa mật khẩu từ ban đầu
                var strMaHoaMatKhau = new MaHoaMatKhau().MaHoaTongHop(txtPassword.Text);
                var taiKhoan = bvContext.NguoiDungs
                    .SingleOrDefault(nd => nd.TenDangNhap.Equals(txtUserName.Text.ToLower())
                                          && nd.MatKhau.Equals(strMaHoaMatKhau));
                if (null == taiKhoan)
                {
                    XtraMessageBox.Show("Tên tài khoản hoặc tên đăng nhập không chính xác! Vui lòng kiểm tra lại!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (taiKhoan.TrangThai == false)
                {
                    XtraMessageBox.Show("Tài khoản hết hạn sử dụng! Vui lòng liên hệ Admin để biết thêm chi tiết!", "Cảnh báo!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Lưu lại thời gian đăng nhập khi ms vào đăng nhập
                taiKhoan.ThoiGianDangNhapGanNhat = DateTime.Now;
                bvContext.SubmitChanges();
                _TenTaiKhoan = taiKhoan.TenTaiKhoan;
                XtraMessageBox.Show(string.Format("Xin chào {0} chúc bạn 1 ngày làm việc vui vẻ", taiKhoan.TenTaiKhoan)
                    , "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //
                Close();
                FrmChinh.Thietlap.ThongTinNguoiDung = taiKhoan;
                FrmChinh.Thietlap.ThietLapQuyen(taiKhoan.MaNhomQuyen);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Chú ý!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A6_FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void timerChayThoiGian_Tick(object sender, EventArgs e)
        {
            try
            {
                lblDayDynamic.Text = DateTime.Now.ToShortDateString();
                lblHoursDynamic.Text = DateTime.Now.ToLongTimeString();
                string s = lblChayChu.Text; lblChayChu.Text = s.Substring(1, s.Length - 1) + s[0];
            }
            catch { }
        }
    }
}