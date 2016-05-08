using System.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using QlNhanSuBenhVien.LinqBiz;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class A2_FrmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public A2_FrmTaiKhoan()
        {
            InitializeComponent();
        }

        public NguoiDung NguoiDungChiTiet { get; set; }
        private void A2_FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                txtTenDangNhap.ReadOnly = txtHomThuDienTu.ReadOnly = false;
                //Load Thông tin lên text
                txtUserName.Text = NguoiDungChiTiet.TenTaiKhoan;
                txtTenDangNhap.Text = NguoiDungChiTiet.TenDangNhap;
                txtHomThuDienTu.Text = NguoiDungChiTiet.Email;
                txtTrangThai.Text = NguoiDungChiTiet.TrangThai == true ? "Hoạt Đông" : "Ngừng Hoạt Động";
                dateEditDangNhapGanDay.EditValue = NguoiDungChiTiet.ThoiGianDangNhapGanNhat;

                barBtnSuaTaiKhoan.Visibility = BarItemVisibility.Always;
                barBtnLuu.Visibility = BarItemVisibility.Never;
                barBtnTaiLai.Visibility = BarItemVisibility.Never;
                txtTenDangNhap.ReadOnly = true;
                txtHomThuDienTu.ReadOnly = true;
            }
            catch { }
        }

        private void barBtnSuaTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenDangNhap.ReadOnly = false;
            txtHomThuDienTu.ReadOnly = false;
            //Khi sửa thành công thực hiện tác vụ này
            barBtnSuaTaiKhoan.Visibility = BarItemVisibility.Never;
            barBtnLuu.Visibility = BarItemVisibility.Always;
            barBtnTaiLai.Visibility = BarItemVisibility.Always;
        }

        private void barBtnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (chkKiemTraHopLe.CheckState == CheckState.Unchecked)
                {
                    XtraMessageBox.Show("Vui lòng kiểm tra hợp lệ trước khi lưu thông tin!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //đặt mật khẩu mặc định khi tạo người dùng là 123456
                var bvContext = new QlBenhVienDataContext();
                var nguoiDung = bvContext.NguoiDungs.SingleOrDefault(nd => nd.ID == NguoiDungChiTiet.ID);
                nguoiDung.TenDangNhap = txtTenDangNhap.Text;
                nguoiDung.Email = txtHomThuDienTu.Text;
                bvContext.SubmitChanges();
                XtraMessageBox.Show("Thay đổi thông tin tài khoản thành công! Đăng nhập lại để xem chi tiết"
                    , "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void chkKiemTraHopLe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKiemTraHopLe.Checked)
            {
                if (!Regex.IsMatch(txtHomThuDienTu.Text, @"\w+\.?\w+@\w{4,5}\.\w{2,3}$"))
                {
                    XtraMessageBox.Show("Định dạng Email không hợp lệ!", "Cảnh báo!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                if (txtUserName.Text.Length < 6 || txtTenDangNhap.Text.Length < 6)
                {
                    XtraMessageBox.Show("Tên tài khoản hoặc tên đăng nhập có độ dài từ 6 ký tự trở lên", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                if (Regex.IsMatch(txtUserName.Text, "\\W"))
                {
                    XtraMessageBox.Show("Tên tài khoản là ký tự số hoặc chữ và không chứa ký tự đặc biệt!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                XtraMessageBox.Show("Thông tin sử dụng hợp lệ!", "Thông báo!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDangNhap.ReadOnly = txtHomThuDienTu.ReadOnly = true;
            }
            else
            {
                txtTenDangNhap.ReadOnly = txtHomThuDienTu.ReadOnly = false;
            }
        }

        private void barBtnTaiLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            A2_FrmTaiKhoan_Load(sender, e);
        }
    }
}