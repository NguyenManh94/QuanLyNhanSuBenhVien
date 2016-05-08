using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QlNhanSuBenhVien.LinqBiz;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class U21_FrmTSXCapNhatCaTruc : DevExpress.XtraEditors.XtraForm
    {
        public U21_FrmTSXCapNhatCaTruc() { InitializeComponent(); }
        public BangPhanCongCaTruc bangPCTemp { get; set; }

        private void U2_FrmTSXCapNhatCaTruc_Load(object sender, EventArgs e)
        {
            dtThoiGianPhanCong.ReadOnly = false;
            dtThoiGianPhanCong.Focus();
            if (Text == "Sửa Bảng Phân Công Ca Trực")
            {
                txtMaBPCCT.Text = bangPCTemp.MaBPCCT.ToString();
                dtThoiGianPhanCong.EditValue = bangPCTemp.Nam;
            }
            else
            {
                dtThoiGianPhanCong.EditValue = DateTime.Now.ToShortDateString();
            }
        }

        private void chkKiemTraHopLe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKiemTraHopLe.Checked)
            {
                //So sánh ngày trong năm
                if (Text != "Sửa Bảng Phân Công Ca Trực"
                    && Convert.ToDateTime(dtThoiGianPhanCong.EditValue).DayOfYear < DateTime.Now.DayOfYear)
                {
                    XtraMessageBox.Show("Thời gian đặt lịch phân công công việc mới không thể nhỏ hơn ngày hiện tại!"
                           , "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                if (Text != "Sửa Bảng Phân Công Ca Trực"
                    && Convert.ToDateTime(dtThoiGianPhanCong.EditValue).Year < DateTime.Now.Year)
                {
                    XtraMessageBox.Show("Thời gian đặt lịch phân công công việc mới không thể nhỏ hơn ngày hiện tại!"
                           , "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                XtraMessageBox.Show("Thông tin đặt bảng phân công hợp lệ!"
                       , "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtThoiGianPhanCong.ReadOnly = true;
            }
            else dtThoiGianPhanCong.ReadOnly = false;
        }


        private void barBtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (chkKiemTraHopLe.CheckState == CheckState.Unchecked)
                {
                    XtraMessageBox.Show("Vui lòng kiểm tra hợp lệ trước khi lưu thông tin!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var bvContext = new QlBenhVienDataContext();
                if (Text == "Sửa Bảng Phân Công Ca Trực")
                {
                    var bangPhanCongHienTai = bvContext.BangPhanCongCaTrucs
                        .SingleOrDefault(bpc => bpc.MaBPCCT == int.Parse(txtMaBPCCT.Text));
                    bangPhanCongHienTai.Nam = Convert.ToDateTime(dtThoiGianPhanCong.EditValue);
                    bvContext.SubmitChanges();
                    XtraMessageBox.Show("Sửa thông tin thành công!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BangPhanCongCaTruc bangPhanCongNew = new BangPhanCongCaTruc
                    {
                        Nam = Convert.ToDateTime(dtThoiGianPhanCong.EditValue)
                    };
                    bvContext.BangPhanCongCaTrucs.InsertOnSubmit(bangPhanCongNew);
                    bvContext.SubmitChanges();
                    XtraMessageBox.Show("Thêm thông tin mới thành công!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch { }
        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            U2_FrmTSXCapNhatCaTruc_Load(sender, e);
        }
    }
}