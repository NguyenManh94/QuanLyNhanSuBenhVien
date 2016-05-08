using System;

namespace QlNhanSuBenhVien.Entity
{
    public class NguoiDungTemp
    {
        public int ID { get; set; }
        public int MaNhomQuyen { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenTaiKhoan { get; set; }
        public string Email { get; set; }
        public string TrangThai { get; set; }
        public DateTime? ThoiGianDangNhapGanNhat { get; set; }
    }
}