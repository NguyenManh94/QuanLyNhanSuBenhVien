using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QlNhanSuBenhVien.LinqBiz;
using QlNhanSuBenhVien.Reports;
using System.Linq;
using System.Windows.Forms;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class B1_FrmBaoCaoHoSo : DevExpress.XtraEditors.XtraForm
    {
        public B1_FrmBaoCaoHoSo()
        {
            InitializeComponent();
        }

        private int _index;
        private void gvHoSoNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _index = e.FocusedRowHandle;
        }

        private void btnBaoCaoHoSo_Click(object sender, System.EventArgs e)
        {
            try
            {
                int maNhanVien = int.Parse(gvHoSoNhanVien.GetRowCellValue(_index, "MaNV").ToString());
                string tenNhanVien = gvHoSoNhanVien.GetRowCellValue(_index, "HoTen").ToString();
                DialogResult result = XtraMessageBox.Show("Bạn có muốn xuất báo cáo hồ sơ nhân viên: " + tenNhanVien + " ?"
                    , "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RptHoSoNhanVien rpt = new RptHoSoNhanVien();
                    rpt.FilterString = string.Format("[MaNV] = {0}", maNhanVien);
                    rpt.CreateDocument();
                    rpt.ShowPreviewDialog();
                }
            }
            catch { }
        }

        private void B1_FrmBaoCaoHoSo_Load(object sender, System.EventArgs e)
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

        private void barBtnXemChiTiet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có muốn xuất báo cáo toàn bộ hồ sơ nhân viên trong bệnh viện ?"
                   , "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RptHoSoNhanVien rpt = new RptHoSoNhanVien();
                rpt.CreateDocument();
                rpt.ShowPreviewDialog();
            }
        }

        private void barBtnLoadLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NapThongTinHoSo();
        }
    }
}