using DevExpress.XtraEditors;
using QlNhanSuBenhVien.LinqBiz;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraScheduler.Outlook.Interop;
using System;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class A1_FrmPassword : DevExpress.XtraEditors.XtraForm
    {
        public A1_FrmPassword()
        {
            InitializeComponent();
        }
        public string TenTaiKhoan { get; set; }
        public string MatKhauHienTai { get; set; }
        public int MaNguoiDung { get; set; }

        private void A1_FrmPassword_Load(object sender, System.EventArgs e)
        {
            txtTenTaiKhoan.Text = TenTaiKhoan;
        }

        private void barBtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (chkKiemTraHopLe.CheckState == CheckState.Unchecked)
                {
                    XtraMessageBox.Show("Vui lòng kiểm tra hợp lệ trước khi lưu thông tin!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var bvContext = new QlBenhVienDataContext();
                NguoiDung nd = bvContext.NguoiDungs.SingleOrDefault(ndt => ndt.ID == MaNguoiDung);
                string matKhauMoi = new MaHoaMatKhau().MaHoaTongHop(txtMatKhauMoi.Text);
                nd.MatKhau = matKhauMoi;
                bvContext.SubmitChanges();
                XtraMessageBox.Show("Đổi mật khẩu thành công!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void chkKiemTraHopLe_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkKiemTraHopLe.Checked)
            {
                string matKhauCu = new MaHoaMatKhau().MaHoaTongHop(txtMatKhauCu.Text);
                if (!matKhauCu.Equals(MatKhauHienTai))
                {
                    XtraMessageBox.Show("Mật khẩu cũ nhập không khớp! Vui lòng kiểm tra lại!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                if (txtMatKhauMoi.Text.Trim().Length < 6 || !Regex.IsMatch(txtMatKhauMoi.Text.Trim(), "\\d"))
                {
                    XtraMessageBox.Show("Mật khẩu phải từ 6 ký tự trở lên và chứa ký tự số!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                if (!txtMatKhauMoi.Text.Trim().Equals(txtNhapLaiMatKhau.Text.Trim()))
                {
                    XtraMessageBox.Show("Mật khẩu nhập lại không khớp! Vui lòng kiểm tra lại!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                XtraMessageBox.Show("Thông tin đầu vào hợp lệ!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhauCu.ReadOnly = txtMatKhauMoi.ReadOnly = txtNhapLaiMatKhau.ReadOnly = true;
            }
            else
            {
                txtMatKhauCu.ReadOnly = txtMatKhauMoi.ReadOnly = txtNhapLaiMatKhau.ReadOnly = false;
            }
        }
    }
}