using DevExpress.XtraEditors;
using QlNhanSuBenhVien.LinqBiz;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class A51_FrmTSXNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public A51_FrmTSXNguoiDung()
        {
            InitializeComponent();
        }

        QlBenhVienDataContext _bvContext = new QlBenhVienDataContext();

        private void chkKiemTraHopLe_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkKiemTraHopLe.CheckState == CheckState.Checked)
                {
                    if (!Regex.IsMatch(txtEmail.Text, @"\w+\.?\w+@\w{4,5}\.\w{2,3}$"))
                    {
                        XtraMessageBox.Show("Định dạng Email không hợp lệ!", "Cảnh báo!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                        return;
                    }
                    if (txtTenTaiKhoan.Text.Length < 6 || txtTenDangNhap.Text.Length < 6)
                    {
                        XtraMessageBox.Show("Tên tài khoản hoặc tên đăng nhập có độ dài từ 6 ký tự trở lên", "Chú ý!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                        return;
                    }
                    if (Regex.IsMatch(txtTenTaiKhoan.Text, "\\W"))
                    {
                        XtraMessageBox.Show("Tên tài khoản là ký tự số hoặc chữ và không chứa ký tự đặc biệt!", "Chú ý!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                        return;
                    }
                    XtraMessageBox.Show("Thông tin sử dụng hợp lệ!", "Thông báo!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setReadOnly(true);
                }
                else
                {
                    setReadOnly(false);
                }
            }
            catch { }
        }

        private void setReadOnly(bool setCondition)
        {
            cbMaNhomQuyen.ReadOnly = setCondition;
            txtTenDangNhap.ReadOnly = setCondition;
            txtTenTaiKhoan.ReadOnly = setCondition;
            txtEmail.ReadOnly = setCondition;
            cbTrangThai.ReadOnly = setCondition;
        }

        private void A51_FrmTSXNguoiDung_Load(object sender, EventArgs e)
        {
            dtDangNhapGanDay.EditValue = DateTime.Now.ToShortDateString();
            NapDuLieuCombo();
            cbTrangThai.SelectedIndex = 0;
            chkKiemTraHopLe.CheckState = CheckState.Unchecked;
            setReadOnly(false);
        }

        private void NapDuLieuCombo()
        {
            try
            {
                cbMaNhomQuyen.Properties.Items.Clear();
                var lstNhomQuyen = _bvContext.NhomQuyens
                    .Select(nq => new { nq.MaNhomQuyen }).ToList();
                foreach (var item in lstNhomQuyen)
                {
                    cbMaNhomQuyen.Properties.Items.Add(item.MaNhomQuyen);
                }
                cbMaNhomQuyen.SelectedIndex = 0;
            }
            catch { }
        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NapDuLieuCombo();
            cbTrangThai.SelectedIndex = 0;
            txtEmail.Text = txtTenDangNhap.Text = txtTenTaiKhoan.Text = "";
            chkKiemTraHopLe.CheckState = CheckState.Unchecked;
            setReadOnly(false);
        }

        private void barBtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chkKiemTraHopLe.CheckState == CheckState.Unchecked)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra hợp lệ trước khi lưu thông tin!", "Chú ý!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //đặt mật khẩu mặc định khi tạo người dùng là 123456
            NguoiDung nd = new NguoiDung
            {
                MaNhomQuyen = int.Parse(cbMaNhomQuyen.Text),
                TenDangNhap = txtTenDangNhap.Text,
                MatKhau = new MaHoaMatKhau().MaHoaTongHop("123456"),
                TenTaiKhoan = txtTenTaiKhoan.Text,
                Email = txtEmail.Text,
                TrangThai = cbTrangThai.Text.Trim() == "Kích Hoạt" ? true : false,
                ThoiGianDangNhapGanNhat = Convert.ToDateTime(dtDangNhapGanDay.EditValue)
            };
            _bvContext.NguoiDungs.InsertOnSubmit(nd);
            _bvContext.SubmitChanges();
            XtraMessageBox.Show("Thêm mới người dùng thành công! Vui lòng Tải lại danh sách để xem chi tiết"
                , "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}