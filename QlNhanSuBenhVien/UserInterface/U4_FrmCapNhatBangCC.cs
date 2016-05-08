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
    public partial class U4_FrmCapNhatBangCC : DevExpress.XtraEditors.XtraForm
    {
        public U4_FrmCapNhatBangCC() { InitializeComponent(); }

        private void U4_FrmCapNhatBangCC_Load(object sender, System.EventArgs e)
        {
            NapHeThong();
        }

        private void barBtnLoadLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NapHeThong();
        }

        private void NapHeThong()
        {
            var bvContext = new QlBenhVienDataContext();
            List<BangChamCong> lstBangChamCong = bvContext.BangChamCongs.Select(bcc => bcc).ToList();
            grcBangChamCong.DataSource = lstBangChamCong;
            gvBangChamCong.ExpandAllGroups();
        }

        private void barBtnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var frm = new U41_FrmTSXCapNhatBangCC();
                frm.Text = "Thêm Bảng Chấm Công";
                frm.ShowDialog();
                //Nạp lại thông tin sau khi chỉnh sửa
                barBtnLoadLai_ItemClick(sender, e);
            }
            catch { }
        }

        private int _index;


        private void btnCapNhat_Click(object sender, System.EventArgs e)
        {
            try
            {
                string maBCC = gvBangChamCong.GetRowCellValue(_index, "MaBCC").ToString();
                var result = XtraMessageBox.Show(new StringBuilder("Bạn có muốn sửa thông tin bảng chấm công mã: ")
                    .Append(maBCC).Append(" ?").ToString(), "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var bcc = new BangChamCongTemp
                    {
                        MaBCC = int.Parse(gvBangChamCong.GetRowCellValue(_index, "MaBCC").ToString()),
                        Thang = Convert.ToInt16(gvBangChamCong.GetRowCellValue(_index, "Thang").ToString()),
                        SoCong = Convert.ToInt16(gvBangChamCong.GetRowCellValue(_index, "SoCong").ToString()),
                        SoCongHuongBHXH = Convert.ToInt16(gvBangChamCong.GetRowCellValue(_index, "SoCongHuongBHXH").ToString())
                    };
                    //Gọi sang form Sửa Bảng Chấm Công
                    var frm = new U41_FrmTSXCapNhatBangCC();
                    frm.Text = "Sửa Bảng Chấm Công";
                    frm.BangCC = bcc;
                    frm.ShowDialog();
                    //Nạp lại thông tin sau khi chỉnh sửa
                    NapHeThong();
                }
            }
            catch { }
        }

        private void gvBangChamCong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _index = e.FocusedRowHandle;
        }

        private void barBtnThietLapBangCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            U42_FrmThietLapBangCC frm = new U42_FrmThietLapBangCC();
            frm.ShowDialog();
        }
    }
}