using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QlNhanSuBenhVien.LinqBiz;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class U11_FrmTSXCapNhatHoSo : XtraForm
    {
        public U11_FrmTSXCapNhatHoSo() { InitializeComponent(); }

        public HoSoNhanVien HsTemp { get; set; }

        private void U11_FrmTSXCapNhatHoSo_Load(object sender, EventArgs e)
        {
            NapDuLieuCombobox();
            if (Text == "Sửa Hồ Sơ")
            {
                txtMaNhanVien.Text = HsTemp.MaNV.ToString();
                txtHoTen.Text = HsTemp.HoTen;
                dtNgaySinh.EditValue = HsTemp.NgaySinh.ToShortDateString();
                cbGioiTinh.Text = HsTemp.GioiTinh;
                txtQueQuan.Text = HsTemp.QueQuan;
                txtDiaChiHienTai.Text = HsTemp.DiaChiHienTai;
                cbTrinhDo.Text = HsTemp.TrinhDo;
                txtSoBaoHiemXH.Text = HsTemp.SoBHXH;
                dtNgayVaoLam.EditValue = HsTemp.NgayVaoLam.Value.ToShortDateString();
                cbMaBangLuong.Text = HsTemp.MaBL.ToString();
                cbMaKhoa.Text = HsTemp.MaKhoa.ToString();
                cbMaChucVu.Text = HsTemp.MaCV.ToString();
            }
            else
            {
                txtHoTen.Text = txtQueQuan.Text = txtDiaChiHienTai.Text = "";
                dtNgaySinh.EditValue = dtNgayVaoLam.EditValue = DateTime.Now.ToShortDateString();
            }
        }

        QlBenhVienDataContext _bvContext = new QlBenhVienDataContext();
        private void NapDuLieuCombobox()
        {
            try
            {
                cbMaBangLuong.Properties.Items.Clear();
                cbMaKhoa.Properties.Items.Clear();
                cbMaChucVu.Properties.Items.Clear();

                //Nạp dữ liệu combobox Mã Bảng Lương
                var lstMaBangLuong = _bvContext.BangLuongs
                    .Select(nq => new { nq.MaBL }).ToList();
                foreach (var item in lstMaBangLuong)
                {
                    cbMaBangLuong.Properties.Items.Add(item.MaBL);
                }
                cbMaBangLuong.SelectedIndex = 0;

                //Nạp dữ liệu combobox Mã Khoa
                var lstMaKhoa = _bvContext.Khoas
                    .Select(nq => new { nq.MaKhoa }).ToList();
                foreach (var item in lstMaKhoa)
                {
                    cbMaKhoa.Properties.Items.Add(item.MaKhoa);
                }
                cbMaKhoa.SelectedIndex = 0;

                //Nạp dữ liệu combobox Mã Chức Vụ
                var lstMaChucVu = _bvContext.ChucVus
                    .Select(nq => new { nq.MaCV }).ToList();
                foreach (var item in lstMaChucVu)
                {
                    cbMaChucVu.Properties.Items.Add(item.MaCV);
                }
                cbMaChucVu.SelectedIndex = 0;//
            }
            catch { return; }
        }

        private void chkKiemTraHopLe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKiemTraHopLe.CheckState == CheckState.Checked)
            {
                if (Convert.ToDateTime(dtNgaySinh.EditValue).Year > DateTime.Now.Year - 18)
                {
                    XtraMessageBox.Show("Nhân viên bắt buộc phải có độ tuổi từ 18 tuổi trở lên!", "Chú ý"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                if (Convert.ToDateTime(dtNgayVaoLam.EditValue) >= DateTime.Now)
                {
                    XtraMessageBox.Show("Ngày vào làm không thể lớn hơn ngày hiện tại!", "Chú ý"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                if (txtHoTen.Text.Length < 7 || txtDiaChiHienTai.Text.Length < 7 || txtQueQuan.Text.Length < 7)
                {
                    XtraMessageBox.Show("Họ tên, Địa chỉ và Quê quán không thể để chống- Độ dài phải từ 7 ký tự trở lên!", "Chú ý"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                //Nếu chưa có số bảo hiểm xã hội thì vẫn cho cập nhật nhưng cảnh báo cần được sủa đổi ngay khi có thể 
                if (txtSoBaoHiemXH.Text.Length < 4)
                {
                    XtraMessageBox.Show("Cảnh báo số bảo hiểm xã hội cần cập nhật ngay khi được cấp!", "Chú ý"
                            , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                XtraMessageBox.Show("Các thông tin nhập vào hợp lệ!", "Chú ý"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetReadOnly(true);
            }
            else
            {
                SetReadOnly(false);
            }
        }

        private void barBtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chkKiemTraHopLe.CheckState == CheckState.Unchecked)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra hợp lệ trước khi lưu thông tin!", "Chú ý!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var bvContext = new QlBenhVienDataContext();
            try
            {
                if (Text == "Sửa Hồ Sơ")
                {
                    //Sửa hồ sơ 1 nhân viên
                    HoSoNhanVien hsNV = bvContext.HoSoNhanViens.SingleOrDefault(nv => nv.MaNV == HsTemp.MaNV);
                    hsNV.HoTen = txtHoTen.Text;
                    hsNV.NgaySinh = Convert.ToDateTime(dtNgaySinh.EditValue);
                    hsNV.GioiTinh = cbGioiTinh.Text;
                    hsNV.QueQuan = txtQueQuan.Text;
                    hsNV.DiaChiHienTai = txtDiaChiHienTai.Text;
                    hsNV.TrinhDo = cbTrinhDo.Text;
                    hsNV.NgayVaoLam = Convert.ToDateTime(dtNgayVaoLam.EditValue);
                    hsNV.SoBHXH = txtSoBaoHiemXH.Text;
                    hsNV.MaBL = int.Parse(cbMaBangLuong.Text);
                    hsNV.MaKhoa = int.Parse(cbMaKhoa.Text);
                    hsNV.MaCV = int.Parse(cbMaChucVu.Text);
                    bvContext.SubmitChanges();
                    XtraMessageBox.Show("Sửa thông tin thành công! Xem chi tiết dưới lưới hiển thị!"
                        , "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Thêm 1 nhân viên mới
                    HoSoNhanVien hsNV = new HoSoNhanVien();
                    hsNV.HoTen = txtHoTen.Text;
                    hsNV.NgaySinh = Convert.ToDateTime(dtNgaySinh.EditValue);
                    hsNV.GioiTinh = cbGioiTinh.Text;
                    hsNV.QueQuan = txtQueQuan.Text;
                    hsNV.DiaChiHienTai = txtDiaChiHienTai.Text;
                    hsNV.TrinhDo = cbTrinhDo.Text;
                    hsNV.NgayVaoLam = Convert.ToDateTime(dtNgayVaoLam.EditValue);
                    hsNV.SoBHXH = txtSoBaoHiemXH.Text;
                    hsNV.MaBL = int.Parse(cbMaBangLuong.Text);
                    hsNV.MaKhoa = int.Parse(cbMaKhoa.Text);
                    hsNV.MaCV = int.Parse(cbMaChucVu.Text);
                    bvContext.HoSoNhanViens.InsertOnSubmit(hsNV);
                    bvContext.SubmitChanges();
                    XtraMessageBox.Show("Thêm thông tin thành công! Xem chi tiết dưới lưới hiển thị!"
                        , "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception) { }
        }

        private void SetReadOnly(bool setCondition)
        {
            txtHoTen.ReadOnly = dtNgaySinh.ReadOnly = cbGioiTinh.ReadOnly = setCondition;
            txtQueQuan.ReadOnly = txtDiaChiHienTai.ReadOnly = cbTrinhDo.ReadOnly = txtSoBaoHiemXH.ReadOnly = setCondition;
            dtNgayVaoLam.ReadOnly = cbMaBangLuong.ReadOnly = cbMaKhoa.ReadOnly = cbMaChucVu.ReadOnly = setCondition;
        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetReadOnly(false);
        }
    }
}