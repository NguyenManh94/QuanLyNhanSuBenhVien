using DevExpress.XtraEditors;
using QlNhanSuBenhVien.Entity;
using QlNhanSuBenhVien.LinqBiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class A4_FrmChucNang : DevExpress.XtraEditors.XtraForm
    {
        public A4_FrmChucNang() { InitializeComponent(); }

        QlBenhVienDataContext _bvContext = new QlBenhVienDataContext();

        private void A4_FrmChucNang_Load(object sender, EventArgs e)
        {
            List<ChucNangTemp> lstChucNang = _bvContext.ChucNangs
                .Select(cn =>
                new ChucNangTemp
                {
                    MaChucNang = cn.MaChucNang,
                    TenChucNang = cn.TenChucNang.Substring(6, cn.TenChucNang.Length - 6),
                    TenHienThiTrongMenu = cn.TenHienThiTrongMenu,
                    GhiChu = cn.GhiChu
                }).ToList();
            grcChucNang.DataSource = lstChucNang;
        }

        private void barBtnLoadLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            A4_FrmChucNang_Load(sender, e);
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                string maChucNang = gvChucNang.GetRowCellValue(_index, "MaChucNang").ToString().Trim();
                string tenChucNang = gvChucNang.GetRowCellValue(_index, "TenChucNang").ToString().Trim();
                string tenHienThiMenu = gvChucNang.GetRowCellValue(_index, "TenHienThiTrongMenu").ToString().Trim();
                string ghiChu = gvChucNang.GetRowCellValue(_index, "GhiChu").ToString().Trim();
                StringBuilder sbd = new StringBuilder();
                sbd.Append("Thông tin chi tiết chức năng:\n   Mã Chức Năng: ").Append(maChucNang)
                    .Append("\n   ").Append("Tên Chức Năng: ").Append(tenChucNang)
                    .Append("\n   ").Append("Tên Hiển Thị Trong Menu: ").Append(tenHienThiMenu)
                    .Append("\n   ").Append("Ghi Chú: ").Append(ghiChu).ToString();
                XtraMessageBox.Show(sbd.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private int _index;
        private void gvChucNang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _index = e.FocusedRowHandle;
        }
    }
}