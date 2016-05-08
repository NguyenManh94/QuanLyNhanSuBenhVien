using DevExpress.XtraEditors;
using QlNhanSuBenhVien.Entity;
using QlNhanSuBenhVien.LinqBiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class A5_FrmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public A5_FrmNguoiDung() { InitializeComponent(); }

        QlBenhVienDataContext _bvContext = new QlBenhVienDataContext();
        private void A5_FrmNguoiDung_Load(object sender, EventArgs e)
        {
            NapThongTinNguoiDung();
        }

        private void NapThongTinNguoiDung()
        {
            QlBenhVienDataContext _bvContext2 = new QlBenhVienDataContext();
            List<NguoiDungTemp> lstNguoiDung = _bvContext2.NguoiDungs.Select(nd =>
                        new NguoiDungTemp
                        {
                            ID = nd.ID,
                            MaNhomQuyen = nd.MaNhomQuyen,
                            TenDangNhap = nd.TenDangNhap,
                            TenTaiKhoan = nd.TenTaiKhoan,
                            Email = nd.Email,
                            TrangThai = nd.TrangThai == true ? "Kích hoạt" : "Ngừng kích hoạt",
                            ThoiGianDangNhapGanNhat = nd.ThoiGianDangNhapGanNhat
                        }).ToList();
            grcNguoiDung.DataSource = lstNguoiDung;
            gvNguoiDung.ExpandAllGroups();
        }

        private void barBtnLoadLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            A5_FrmNguoiDung_Load(sender, e);
        }

        private void barBtnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            A51_FrmTSXNguoiDung frm = new A51_FrmTSXNguoiDung();
            frm.Text = "Thêm Người Dùng";
            frm.ShowDialog();
            NapThongTinNguoiDung();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gvNguoiDung.GetRowCellValue(_index, "ID"));
            string trangthai = gvNguoiDung.GetRowCellValue(_index, "TrangThai").ToString();
            string tenTaiKhoan = gvNguoiDung.GetRowCellValue(_index, "TenTaiKhoan").ToString();
            if (trangthai.Equals("Kích hoạt"))
            {
                DialogResult result = XtraMessageBox.Show("Bạn có muốn ngừng kích hoạt tài khoản: " + tenTaiKhoan
                    , "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    NguoiDung nd = _bvContext.NguoiDungs.SingleOrDefault(n => n.ID == id);
                    nd.TrangThai = false;
                    _bvContext.SubmitChanges();
                    XtraMessageBox.Show("Ngừng kích hoạt tài khoản: " + tenTaiKhoan + " thành công!"
                                    , "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Bạn có muốn kích hoạt tài khoản: " + tenTaiKhoan
                                    , "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    NguoiDung nd = _bvContext.NguoiDungs.SingleOrDefault(n => n.ID == id);
                    nd.TrangThai = true;
                    _bvContext.SubmitChanges();
                    XtraMessageBox.Show("Kích hoạt tài khoản: " + tenTaiKhoan + " thành công!"
                                    , "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
            }
            NapThongTinNguoiDung();
        }

        private int _index;
        private void gvNhomQuyen_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _index = e.FocusedRowHandle;
        }
    }
}