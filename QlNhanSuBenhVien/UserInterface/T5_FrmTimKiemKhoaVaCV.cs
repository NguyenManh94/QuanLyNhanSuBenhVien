using System;
using System.Collections.Generic;
using System.Linq;
using QlNhanSuBenhVien.LinqBiz;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class T5_FrmTimKiemKhoaVaCV : DevExpress.XtraEditors.XtraForm
    {
        public T5_FrmTimKiemKhoaVaCV()
        {
            InitializeComponent();
        }

        private void T5_FrmTimKiemKhoaVaCV_Load(object sender, EventArgs e)
        {
            try
            {
                var bvContext = new QlBenhVienDataContext();
                List<Khoa> lstKhoa = bvContext.Khoas.Select(k => k).ToList();
                List<ChucVu> lstChucVu = bvContext.ChucVus.Select(cv => cv).ToList();
                grcChucVu.DataSource = lstChucVu;
                grcKhoa.DataSource = lstKhoa;
            }
            catch { }
        }
    }
}