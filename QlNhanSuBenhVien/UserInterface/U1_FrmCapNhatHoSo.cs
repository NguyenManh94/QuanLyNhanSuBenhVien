using DevExpress.XtraEditors;
using QlNhanSuBenhVien.LinqBiz;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class U1_FrmCapNhatHoSo : DevExpress.XtraEditors.XtraForm
    {
        public U1_FrmCapNhatHoSo() { InitializeComponent(); }

        QlBenhVienDataContext _bvContext = new QlBenhVienDataContext();
        private void U1_FrmCapNhatHoSo_Load(object sender, EventArgs e)
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

        private void barBtnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var frm = new U11_FrmTSXCapNhatHoSo();
                frm.Text = "Thêm Hồ Sơ";
                frm.ShowDialog();
                //Nạp lại thông tin sau khi chỉnh sửa
                NapThongTinHoSo();
            }
            catch { }
        }

        private void barBtnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string hoTen = gvHoSoNhanVien.GetRowCellValue(_index, "HoTen").ToString();
                var result = XtraMessageBox.Show(new StringBuilder("Bạn có muốn sửa thông tin hồ sơ của nhân viên: ")
                    .Append(hoTen).Append(" ?").ToString(), "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var hs = new HoSoNhanVien
                    {
                        MaNV = int.Parse(gvHoSoNhanVien.GetRowCellValue(_index, "MaNV").ToString()),
                        HoTen = hoTen,
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
                    //Gọi sang form Sửa hồ sơ nhân viên
                    var frm = new U11_FrmTSXCapNhatHoSo();
                    frm.Text = "Sửa Hồ Sơ";
                    frm.HsTemp = hs;
                    frm.ShowDialog();
                    //Nạp lại thông tin sau khi chỉnh sửa
                    NapThongTinHoSo();
                }
            }
            catch { }
        }

        private int _index;
        private void gvHoSoNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _index = e.FocusedRowHandle;
        }
    }
}