using System;
using QlNhanSuBenhVien.LinqBiz;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class T11_FrmXemChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public T11_FrmXemChiTiet() { InitializeComponent(); }

        public HoSoNhanVien HoSoTemp { get; set; }
        private void T11_FrmXemChiTiet_Load(object sender, EventArgs e)
        {
            try
            {
                txtMaNhanVien.Text = HoSoTemp.MaNV.ToString();
                txtHoTen.Text = HoSoTemp.HoTen.ToString();
                dtNgaySinh.EditValue = HoSoTemp.NgaySinh.ToString();
                cbGioiTinh.Text = HoSoTemp.GioiTinh.ToString();
                txtQueQuan.Text = HoSoTemp.QueQuan.ToString();
                txtDiaChiHienTai.Text = HoSoTemp.DiaChiHienTai.ToString();
                cbTrinhDo.Text = HoSoTemp.TrinhDo.ToString();
                dtNgayVaoLam.EditValue = HoSoTemp.NgayVaoLam.ToString();
                txtSoBaoHiemXH.Text = HoSoTemp.SoBHXH.ToString();
                cbMaBangLuong.Text = HoSoTemp.MaBL.ToString();
                cbMaKhoa.Text = HoSoTemp.MaKhoa.ToString();
                cbMaChucVu.Text = HoSoTemp.MaCV.ToString();
            }
            catch { }
        }
    }
}