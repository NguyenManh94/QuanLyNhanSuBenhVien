using DevExpress.XtraEditors;
using QlNhanSuBenhVien.LinqBiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class A3_FrmNhomQuyen : DevExpress.XtraEditors.XtraForm
    {
        public A3_FrmNhomQuyen() { InitializeComponent(); }

        QlBenhVienDataContext _bvContext = new QlBenhVienDataContext();

        private void FrmNhomQuyen_Load(object sender, EventArgs e)
        {
            try
            {
                List<NhomQuyen> lstNhomQuyen = _bvContext.NhomQuyens.Select(nq => nq).ToList();
                grcNhomQuyen.DataSource = lstNhomQuyen;
            }
            catch
            {
                XtraMessageBox.Show("Mất kết nối cơ sở dữ liệu!", "Cảnh báo!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void barBtnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            A31_FrmTSXNhomQuyen frm = new A31_FrmTSXNhomQuyen();
            frm.Text = "Thêm Nhóm Quyền";
            frm.ShowDialog();
            //Nạp lại thông tin sau khi thêm
            FrmNhomQuyen_Load(sender, e);
        }

        private void BtnCapNhatDuLieu_Click(object sender, EventArgs e)
        {
            A31_FrmTSXNhomQuyen frm = new A31_FrmTSXNhomQuyen();
            frm.Text = "Sửa Nhóm Quyền";
            //TODO tẹo sửa lại
            frm._MaNhomQuyen = (int)gvNhomQuyen.GetRowCellValue(_index, "MaNhomQuyen");
            frm._TenNhomQuyen = gvNhomQuyen.GetRowCellValue(_index, "TenNhomQuyen").ToString().Trim();
            frm._GhiChu = gvNhomQuyen.GetRowCellValue(_index, "GhiChu").ToString().Trim();
            frm.ShowDialog();
            //Nạp lại thông tin sau khi sửa
            FrmNhomQuyen_Load(sender, e);
        }

        private int _index;
        private void barBtnLoadLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<NhomQuyen> lstNhomQuyen = _bvContext.NhomQuyens.Select(nq => nq).ToList();
            grcNhomQuyen.DataSource = lstNhomQuyen;
        }

        private void gvNhomQuyen_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _index = e.FocusedRowHandle;
        }
    }
}