using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using QlNhanSuBenhVien.Entity;
using QlNhanSuBenhVien.LinqBiz;
using System.Windows.Forms;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class U2_FrmCapNhatCaTruc : XtraForm
    {
        public U2_FrmCapNhatCaTruc() { InitializeComponent(); }

        private void U2_FrmCapNhatCaTruc_Load(object sender, System.EventArgs e)
        {
            try
            {
                NapHeThong();
                btnNapLai_Click(sender, e);
            }
            catch { }
        }

        private void barBtnLoadLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                btnNapLai.Enabled = barBtnLocNhanVien.Enabled = true;
                cbMaBangPhanCong.ReadOnly = false;
                btnNapLai_Click(sender, e);
                NapHeThong();
            }
            catch { }
        }

        private void NapHeThong()
        {
            var bvContext = new QlBenhVienDataContext();
            List<BangPhanCongCaTruc> lstBangPhanCong = bvContext.BangPhanCongCaTrucs.Select(bpc => bpc).ToList();
            gcBangPhanCong.DataSource = lstBangPhanCong;
            List<HoSoTemp> lstHoSoTemp = bvContext.HoSoNhanViens
                .Select(hs => new HoSoTemp { MaNV = hs.MaNV, HoTen = hs.HoTen }).ToList();
            gcNhanVien.DataSource = lstHoSoTemp;
        }


        private void btnNapLai_Click(object sender, System.EventArgs e)
        {
            try
            {
                cbMaBangPhanCong.Properties.Items.Clear();
                var bvContext = new QlBenhVienDataContext();
                var lstMaBangPhanCong = bvContext.BangPhanCongCaTrucs.Select(bpc => new { bpc.MaBPCCT });
                foreach (var item in lstMaBangPhanCong)
                {
                    cbMaBangPhanCong.Properties.Items.Add(item.MaBPCCT);
                }
                cbMaBangPhanCong.SelectedIndex = 0;
            }
            catch { }
        }

        private int _index;
        private void gvBangPhanCong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _index = e.FocusedRowHandle;
        }

        private void barBtnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var frm = new U21_FrmTSXCapNhatCaTruc();
                frm.Text = "Thêm Bảng Phân Công Ca Trực";
                frm.ShowDialog();
                //Nạp lại thông tin sau khi chỉnh sửa
                barBtnLoadLai_ItemClick(sender, e);
            }
            catch { }
        }

        private void btnSuaBangPhanCong_Click(object sender, System.EventArgs e)
        {
            try
            {
                string maBPCCT = gvBangPhanCong.GetRowCellValue(_index, "MaBPCCT").ToString();
                var result = XtraMessageBox.Show(new StringBuilder("Bạn có muốn sửa thông tin bảng phân công ca trực mã: ")
                    .Append(maBPCCT).Append(" ?").ToString(), "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var bangPhanCongCT = new BangPhanCongCaTruc
                    {
                        MaBPCCT = int.Parse(gvBangPhanCong.GetRowCellValue(_index, "MaBPCCT").ToString()),
                        Nam = Convert.ToDateTime(gvBangPhanCong.GetRowCellValue(_index, "Nam").ToString())
                    };
                    //Gọi sang form Sửa hồ sơ nhân viên
                    var frm = new U21_FrmTSXCapNhatCaTruc();
                    frm.Text = "Sửa Bảng Phân Công Ca Trực";
                    frm.bangPCTemp = bangPhanCongCT;
                    frm.ShowDialog();
                    //Nạp lại thông tin sau khi chỉnh sửa
                    NapHeThong();
                }
            }
            catch { }
        }

        private int _index2;
        private void gvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _index2 = e.FocusedRowHandle;
        }

        private void btnThemVaoCaTruc_Click(object sender, EventArgs e)
        {
            try
            {
                if (barBtnLocNhanVien.Enabled == true)
                {
                    XtraMessageBox.Show("Vui lòng kích lọc nhân viên thuộc ca trực để được thông tin chính xác nhất!"
                        , "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string strHoTen = gvNhanVien.GetRowCellValue(_index2, "HoTen").ToString();
                int maNV = int.Parse(gvNhanVien.GetRowCellValue(_index2, "MaNV").ToString());
                var result = XtraMessageBox.Show("Bạn có muốn thêm nhân viên: " + strHoTen + "- vào ca trực mã số: " + cbMaBangPhanCong.Text
                    , "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BangChiTietPhanCongCaTruc bctpct = new BangChiTietPhanCongCaTruc
                    {
                        MaBPCCT = int.Parse(cbMaBangPhanCong.Text),
                        MaNV = maNV
                    };
                    var bvContext = new QlBenhVienDataContext();
                    bvContext.BangChiTietPhanCongCaTrucs.InsertOnSubmit(bctpct);
                    bvContext.SubmitChanges();
                    gvNhanVien.DeleteRow(gvNhanVien.FocusedRowHandle);
                    lstbNhanVienThuocCaTruc.Items.Add(string.Format("NV mã: {0} -Họ Tên: {1}", maNV, strHoTen));
                }
            }
            catch { }
        }

        //Lọc ra những nhân viên chưa có trong danh sách của mã phân công đã chọn
        private void barBtnLocNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                var bvContext = new QlBenhVienDataContext();
                //Xây dựng list thông tin mã nhân viên thỏa mãn không nằm trong danh sách
                int maBangPCCT = Convert.ToInt32(cbMaBangPhanCong.Text);
                var lstMaBangPCCT = bvContext.BangChiTietPhanCongCaTrucs.Where(pc => pc.MaBPCCT == maBangPCCT)
                    .Select(bpc => new { bpc.MaNV }).ToList();
                var lstMaNV = bvContext.HoSoNhanViens.Select(hs => new { hs.MaNV }).ToList();
                for (int i = 0; i < lstMaNV.Count; i++)
                {
                    if (lstMaBangPCCT.Contains(lstMaNV[i]))
                    {
                        lstMaNV.RemoveAt(i);
                        i--;
                    }
                }
                var lstHoSoTemp = new List<HoSoTemp>();
                foreach (var item in lstMaNV)
                {
                    lstHoSoTemp.Add(new HoSoTemp { MaNV = item.MaNV, HoTen = "default" });
                }
                var lstTemp =
                    (from hstemp in lstHoSoTemp
                     join hs in bvContext.HoSoNhanViens on hstemp.MaNV equals hs.MaNV
                     select new HoSoTemp { MaNV = hs.MaNV, HoTen = hs.HoTen }).ToList();
                if (lstTemp.Count == 0)
                {
                    XtraMessageBox.Show("Ca trực này đã đăng ký đầy đủ tất cả các nhân viên! Vui lòng chọn cac trực khác"
                        , "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNapLai.Enabled = barBtnLocNhanVien.Enabled = true;
                    cbMaBangPhanCong.ReadOnly = false;
                    gcNhanVien.DataSource = null;
                    return;
                }
                else
                {
                    btnNapLai.Enabled = barBtnLocNhanVien.Enabled = false;
                    cbMaBangPhanCong.ReadOnly = true;
                    gcNhanVien.DataSource = lstTemp;
                }
            }
            catch { }
        }

        private void pictureNapLaiDanhSach_Click(object sender, EventArgs e)
        {
            btnNapLai.Enabled = barBtnLocNhanVien.Enabled = true;
            cbMaBangPhanCong.ReadOnly = false;
            lstbNhanVienThuocCaTruc.Items.Clear();
            NapHeThong();
        }
    }
}