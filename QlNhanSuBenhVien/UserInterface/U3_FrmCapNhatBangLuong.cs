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
    public partial class U3_FrmCapNhatBangLuong : DevExpress.XtraEditors.XtraForm
    {
        public U3_FrmCapNhatBangLuong() { InitializeComponent(); }

        private void U3_FrmCapNhatBangLuong_Load(object sender, System.EventArgs e)
        {
            NapHeThong();
        }

        private void barBtnLoadLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NapHeThong();
        }

        private void NapHeThong()
        {
            var _bvContext = new QlBenhVienDataContext();
            List<BangLuongTemp> lstBangLuong = _bvContext.BangLuongs.Select(bl => new BangLuongTemp
            {
                MaBL = bl.MaBL,
                HeSoCV = bl.HeSoCV,
                HeSoLuong = bl.HeSoLuong,
                PhuCapThamNien = string.Format("{0:0,0}", bl.PhuCapThamNien),
                CacKhoanDongGop = string.Format("{0:0,0}", bl.CacKhoanDongGop),
                TongLuong = string.Format("{0:0,0}", bl.TongLuong),
                ThucLinh = string.Format("{0:0,0}", bl.ThucLinh)
            }).ToList();
            grcBangLuong.DataSource = lstBangLuong;
            gvBangLuong.ExpandAllGroups();
        }

        private void barBtnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var frm = new U31_FrmTSXCapNhatBangLuong();
                frm.Text = "Thêm Bảng Lương";
                frm.ShowDialog();
                //Nạp lại thông tin sau khi chỉnh sửa
                barBtnLoadLai_ItemClick(sender, e);
            }
            catch { }

        }

        private void btnCapNhat_Click(object sender, System.EventArgs e)
        {
            try
            {
                string maBl = gvBangLuong.GetRowCellValue(_index, "MaBL").ToString();
                var result = XtraMessageBox.Show(new StringBuilder("Bạn có muốn sửa thông tin bảng lương mã: ")
                    .Append(maBl).Append(" ?").ToString(), "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var bl = new BangLuongTemp
                    {
                        MaBL = int.Parse(gvBangLuong.GetRowCellValue(_index, "MaBL").ToString()),
                        HeSoCV = Convert.ToDouble(gvBangLuong.GetRowCellValue(_index, "HeSoCV").ToString()),
                        HeSoLuong = Convert.ToDouble(gvBangLuong.GetRowCellValue(_index, "HeSoLuong").ToString()),
                        PhuCapThamNien = gvBangLuong.GetRowCellValue(_index, "PhuCapThamNien").ToString(),
                        CacKhoanDongGop = gvBangLuong.GetRowCellValue(_index, "CacKhoanDongGop").ToString(),
                        TongLuong = gvBangLuong.GetRowCellValue(_index, "TongLuong").ToString(),
                        ThucLinh = gvBangLuong.GetRowCellValue(_index, "ThucLinh").ToString(),
                    };
                    //Gọi sang form Sửa hồ sơ nhân viên
                    var frm = new U31_FrmTSXCapNhatBangLuong();
                    frm.Text = "Sửa Bảng Lương";
                    frm.BlTemp = bl;
                    frm.ShowDialog();
                    //Nạp lại thông tin sau khi chỉnh sửa
                    NapHeThong();
                }
            }
            catch { }
        }

        private int _index;
        private void gvBangLuong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _index = e.FocusedRowHandle;
        }
    }
}