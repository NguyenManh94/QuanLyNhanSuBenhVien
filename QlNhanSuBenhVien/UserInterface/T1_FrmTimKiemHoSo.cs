using QlNhanSuBenhVien.Entity;
using QlNhanSuBenhVien.LinqBiz;
using System;
using System.Linq;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class T1_FrmTimKiemHoSo : DevExpress.XtraEditors.XtraForm
    {
        public T1_FrmTimKiemHoSo()
        {
            InitializeComponent();
        }

        private void T1_FrmTimKiemHoSo_Load(object sender, System.EventArgs e)
        {
            NapThongTinHoSo();
        }

        private void NapThongTinHoSo()
        {
            try
            {
                var _bvContextTemp = new QlBenhVienDataContext();
                var lstHoSoNhanVien = _bvContextTemp.HoSoNhanViens.Select(a => a).ToList();
                grcHoSoNhanVien.DataSource = lstHoSoNhanVien;
                gvHoSoNhanVien.ExpandAllGroups();
            }
            catch { }
        }

        private void barBtnLoadLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NapThongTinHoSo();
        }

        private void btnXemChiTiet_Click(object sender, System.EventArgs e)
        {
            try
            {
                T11_FrmXemChiTiet frm = new T11_FrmXemChiTiet();
                HoSoNhanVien nd = new HoSoNhanVien
                {
                    MaNV = int.Parse(gvHoSoNhanVien.GetRowCellValue(_index, "MaNV").ToString()),
                    HoTen = gvHoSoNhanVien.GetRowCellValue(_index, "HoTen").ToString(),
                    NgaySinh = Convert.ToDateTime(gvHoSoNhanVien.GetRowCellValue(_index, "NgaySinh").ToString()),
                    GioiTinh = gvHoSoNhanVien.GetRowCellValue(_index, "GioiTinh").ToString(),
                    QueQuan = gvHoSoNhanVien.GetRowCellValue(_index, "QueQuan").ToString(),
                    DiaChiHienTai = gvHoSoNhanVien.GetRowCellValue(_index, "DiaChiHienTai").ToString(),
                    TrinhDo = gvHoSoNhanVien.GetRowCellValue(_index, "TrinhDo").ToString(),
                    NgayVaoLam = Convert.ToDateTime(gvHoSoNhanVien.GetRowCellValue(_index, "NgayVaoLam").ToString()),
                    SoBHXH = gvHoSoNhanVien.GetRowCellValue(_index, "SoBHXH").ToString(),
                    MaBL = int.Parse(gvHoSoNhanVien.GetRowCellValue(_index, "MaBL").ToString()),
                    MaKhoa = int.Parse(gvHoSoNhanVien.GetRowCellValue(_index, "MaKhoa").ToString()),
                    MaCV = int.Parse(gvHoSoNhanVien.GetRowCellValue(_index, "MaCV").ToString())
                };
                frm.HoSoTemp = nd;
                frm.ShowDialog();
            }
            catch { }
        }

        private int _index;
        private void gvHoSoNhanVien_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _index = e.FocusedRowHandle;
        }
    }
}