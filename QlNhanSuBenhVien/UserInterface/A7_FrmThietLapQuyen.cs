using DevExpress.XtraEditors;
using QlNhanSuBenhVien.LinqBiz;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using QlNhanSuBenhVien.Entity;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class A7_FrmThietLapQuyen : DevExpress.XtraEditors.XtraForm
    {
        public A7_FrmThietLapQuyen() { InitializeComponent(); }

        private void A7_FrmThietLapQuyen_Load(object sender, EventArgs e)
        {
            NapComboChucNang();
            NapHeThong();
            cbEditChucNang.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        private void pictureTroGiup_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(@"Để xem chi tiết quyền chức năng vui lòng chọn danh mục 
                    'Thiết Lập Quyền'- Chức năng :Nhóm Quyền ", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbEditChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbEditChucNang.Text != "")
                {
                    foreach (var item in _lstNhomQuyenTemp)
                    {
                        if (item.TenNhomQuyen.Equals(cbEditChucNang.Text))
                        {
                            txtIdQuyenHide.Text = item.MaNhomQuyen.ToString();
                            break;
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private int _index;
        private void gvTenHienThiTrongMenu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _index = e.FocusedRowHandle;
        }

        private void btnThemChucNang_Click(object sender, EventArgs e)
        {
            if (cbEditChucNang.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Vui lòng chọn nhóm quyền cần thiết lập trước khi thêm chức năng!", "Chú ý!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var strThongBao = string.Format("Bạn có muốn thêm chức năng: {0} vào Nhóm Quyền: {1}",
                gvTenHienThiTrongMenu.GetRowCellValue(_index, "TenChucNang").ToString(), cbEditChucNang.Text);
            var result = XtraMessageBox.Show(strThongBao, "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ChiTietNhomQuyen ctnq = new ChiTietNhomQuyen
                {
                    MaNhomQuyen = int.Parse(txtIdQuyenHide.Text),
                    MaChucNang = int.Parse(gvTenHienThiTrongMenu.GetRowCellValue(_index, "MaChucNang").ToString())
                };
                var bvContext = new QlBenhVienDataContext();
                bvContext.ChiTietNhomQuyens.InsertOnSubmit(ctnq);
                bvContext.SubmitChanges();
                XtraMessageBox.Show("Thêm chức năng mới thành công!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gvTenHienThiTrongMenu.DeleteRow(gvTenHienThiTrongMenu.FocusedRowHandle);
                #region Load Lại Lưới Hiển Thị Quyền
                var lstThongTinQuyen = bvContext.ChiTietNhomQuyens
                        .Join(bvContext.NhomQuyens, ct => ct.MaNhomQuyen, nq => nq.MaNhomQuyen
                        , (ct, nq) => new { ct.MaNhomQuyen, ct.MaChucNang, nq.TenNhomQuyen })
                        .Join(bvContext.ChucNangs, ct => ct.MaChucNang, cn => cn.MaChucNang
                        , (ct, cn) => new { ct.MaNhomQuyen, ct.TenNhomQuyen, cn.TenHienThiTrongMenu, cn.GhiChu });
                gcQuyenThietLap.DataSource = lstThongTinQuyen;
                gvQuyenThietLap.ExpandAllGroups();
                #endregion
            }
        }

        //Nạp dữ liệu hệ thống và nạp dữ liệu combo Chức năng
        private void NapHeThong()
        {
            try
            {
                var bvContext = new QlBenhVienDataContext();
                LocChucNang();
                var lstThongTinQuyen = bvContext.ChiTietNhomQuyens
                    .Join(bvContext.NhomQuyens, ct => ct.MaNhomQuyen, nq => nq.MaNhomQuyen
                    , (ct, nq) => new { ct.MaNhomQuyen, ct.MaChucNang, nq.TenNhomQuyen })
                    .Join(bvContext.ChucNangs, ct => ct.MaChucNang, cn => cn.MaChucNang
                    , (ct, cn) => new { ct.MaNhomQuyen, cn.MaChucNang, ct.TenNhomQuyen, cn.TenHienThiTrongMenu, cn.GhiChu });
                gcQuyenThietLap.DataSource = lstThongTinQuyen;
                gvQuyenThietLap.ExpandAllGroups();
            }
            catch (Exception)
            {
            }
        }
        //List lưu trữ danh sách thông tin Nhóm Quyền Tạm
        private List<NhomQuyenTemp> _lstNhomQuyenTemp = new List<NhomQuyenTemp>();
        private void NapComboChucNang()
        {
            try
            {
                //Nạp Combobox Nhóm Quyền
                var bvContext = new QlBenhVienDataContext();
                _lstNhomQuyenTemp = bvContext.NhomQuyens.Select(nq => new NhomQuyenTemp
                {
                    MaNhomQuyen = nq.MaNhomQuyen,
                    TenNhomQuyen = nq.TenNhomQuyen
                }).ToList();
                foreach (var item in _lstNhomQuyenTemp)
                {
                    cbEditChucNang.Properties.Items.Add(item.TenNhomQuyen);
                }
                cbEditChucNang.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }

        //Lọc dữ liệu các chức năng chưa được thiết lập cho nhóm quyền
        private void LocChucNang()
        {
            #region TestDition
            //try
            //{
            //    var bvContext = new QlBenhVienDataContext();
            //    var lstThongTinQuyenTemp = bvContext.ChiTietNhomQuyens
            //        .Where(nqNew => nqNew.MaNhomQuyen == int.Parse(txtIdQuyenHide.Text))
            //        .Join(bvContext.NhomQuyens, ct => ct.MaNhomQuyen, nq => nq.MaNhomQuyen
            //        , (ct, nq) => new { ct.MaNhomQuyen, ct.MaChucNang })
            //        .Join(bvContext.ChucNangs, ct => ct.MaChucNang, cn => cn.MaChucNang
            //        , (ct, cn) => new { cn.MaChucNang, cn.TenChucNang, cn.TenHienThiTrongMenu, cn.GhiChu }).ToList();
            //    gcTenHienThiTrongMenu.DataSource = lstThongTinQuyenTemp;
            //}
            //catch { } 
            #endregion
            try
            {
                var bvContext = new QlBenhVienDataContext();
                //Xây dựng list thông tin mã nhân viên thỏa mãn không nằm trong danh sách
                int maNq = Convert.ToInt32(txtIdQuyenHide.Text);
                var lstMaChiTietNq = bvContext.ChiTietNhomQuyens.Where(pc => pc.MaNhomQuyen == maNq)
                    .Select(bpc => new { bpc.MaChucNang }).ToList();
                var lstMaCn = bvContext.ChucNangs.Select(cn => new { cn.MaChucNang }).ToList();
                for (int i = 0; i < lstMaCn.Count; i++)
                {
                    if (lstMaChiTietNq.Contains(lstMaCn[i]))
                    {
                        lstMaCn.RemoveAt(i);
                        i--;
                    }
                }
                var lstHoSoTemp = new List<NhanVienX>();
                foreach (var item in lstMaCn)
                {
                    lstHoSoTemp.Add(new NhanVienX { MaChucNang = item.MaChucNang });
                }
                var lstTemp =
                    (from hstemp in lstHoSoTemp
                     join cn in bvContext.ChucNangs on hstemp.MaChucNang equals cn.MaChucNang
                     select new ChucNangTemp
                     {
                         MaChucNang = cn.MaChucNang,
                         TenChucNang = cn.TenChucNang,
                         TenHienThiTrongMenu = cn.TenHienThiTrongMenu,
                         GhiChu = cn.GhiChu
                     }).ToList();
                if (lstTemp.Count == 0)
                {
                    XtraMessageBox.Show("Nhóm quyền này đã thiết lập đầy đủ tất cả các chức năng!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gcTenHienThiTrongMenu.DataSource = null;
                    return;
                }
                else
                {
                    gcTenHienThiTrongMenu.DataSource = lstTemp;
                }
            }
            catch { }
        }

        private void barBtnLoadLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            A7_FrmThietLapQuyen_Load(sender, e);
        }

        private void txtIdQuyenHide_EditValueChanged(object sender, EventArgs e)
        {
            if (txtIdQuyenHide.Text.Trim().Length != 0)
            {
                LocChucNang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var strThongBao = string.Format("Bạn có muốn xóa chức năng: {0} khỏi Nhóm Quyền: {1}",
                   gvQuyenThietLap.GetRowCellValue(_index2, "GhiChu").ToString(),
                   gvQuyenThietLap.GetRowCellValue(_index2, "TenNhomQuyen").ToString());
                var result = XtraMessageBox.Show(strThongBao, "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var bvContext = new QlBenhVienDataContext();
                    int maNhomQuyen = int.Parse(gvQuyenThietLap.GetRowCellValue(_index2, "MaNhomQuyen").ToString());
                    int maChucNang = int.Parse(gvQuyenThietLap.GetRowCellValue(_index2, "MaChucNang").ToString());
                    ChiTietNhomQuyen ctnq = bvContext.ChiTietNhomQuyens.SingleOrDefault(nq =>
                            nq.MaNhomQuyen == maNhomQuyen && nq.MaChucNang == maChucNang);
                    bvContext.ChiTietNhomQuyens.DeleteOnSubmit(ctnq);
                    bvContext.SubmitChanges();
                    gvQuyenThietLap.DeleteRow(gvQuyenThietLap.FocusedRowHandle);
                }
            }
            catch { }
        }

        private int _index2;
        private void gvQuyenThietLap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _index2 = e.FocusedRowHandle;
        }
    }
}