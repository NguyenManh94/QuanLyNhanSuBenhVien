using DevExpress.XtraEditors;
using QlNhanSuBenhVien.LinqBiz;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class A31_FrmTSXNhomQuyen : DevExpress.XtraEditors.XtraForm
    {
        public A31_FrmTSXNhomQuyen() { InitializeComponent(); }

        public int _MaNhomQuyen { get; set; }
        public string _TenNhomQuyen { get; set; }
        public string _GhiChu { get; set; }

        private void A31_FrmThemMoi_Load(object sender, EventArgs e)
        {
            txtGhiChu.ReadOnly = false;
            txtTenNhomQuyen.ReadOnly = false;
            if (Text == "Sửa Nhóm Quyền")
            {
                txtTenNhomQuyen.Text = _TenNhomQuyen;
                txtGhiChu.Text = _GhiChu;
            }
        }

        private void chkKiemTraHopLe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKiemTraHopLe.Checked)
                if (txtTenNhomQuyen.Text.Length < 5 || txtGhiChu.Text.Length < 10)
                {
                    XtraMessageBox.Show("Tên nhóm quyền từ 5 ký tự trở lên và ghi chú phải lớn hơn 10 ký tự", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    txtGhiChu.ReadOnly = false;
                    txtTenNhomQuyen.ReadOnly = false;
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Thông tin hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGhiChu.ReadOnly = true;
                    txtTenNhomQuyen.ReadOnly = true;
                }
        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtGhiChu.Text = txtTenNhomQuyen.Text = "";
            txtGhiChu.ReadOnly = false;
            txtTenNhomQuyen.ReadOnly = false;
            chkKiemTraHopLe.CheckState = CheckState.Unchecked;
        }

        QlBenhVienDataContext _bvContext = new QlBenhVienDataContext();
        private void barBtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chkKiemTraHopLe.CheckState == CheckState.Unchecked)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra hợp lệ trước khi lưu thông tin!", "Chú ý!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Nếu là Thêm cho thêm
            if (Text == "Sửa Nhóm Quyền")
            {
                NhomQuyen nq = _bvContext.NhomQuyens.SingleOrDefault(n => n.MaNhomQuyen == _MaNhomQuyen);
                nq.TenNhomQuyen = txtTenNhomQuyen.Text;
                nq.GhiChu = txtGhiChu.Text;
                XtraMessageBox.Show("Sửa thông tin thành công!", "Chú ý!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NhomQuyen nq = new NhomQuyen { TenNhomQuyen = txtTenNhomQuyen.Text, GhiChu = txtGhiChu.Text };
                _bvContext.NhomQuyens.InsertOnSubmit(nq);
                _bvContext.SubmitChanges();
                XtraMessageBox.Show("Thêm mới thành công!", "Chú ý!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}