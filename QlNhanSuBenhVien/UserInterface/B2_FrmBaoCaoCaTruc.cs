using System.Linq;
using QlNhanSuBenhVien.LinqBiz;
using QlNhanSuBenhVien.Reports;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class B2_FrmBaoCaoCaTruc : DevExpress.XtraEditors.XtraForm
    {
        public B2_FrmBaoCaoCaTruc()
        {
            InitializeComponent();
        }

        private void labelControl24_Click(object sender, System.EventArgs e)
        {

        }

        private void rdThongKeTheoMaNV_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rdThongKeTheoMaNV.Checked)
            {
                gcThongKeTheoMaNV.Enabled = true;
                gcThongKeTheoMaTruc.Enabled = false;
            }
        }

        private void rdThongKeTheoMaCaTruc_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rdThongKeTheoMaCaTruc.Checked)
            {
                gcThongKeTheoMaNV.Enabled = false;
                gcThongKeTheoMaTruc.Enabled = true;
            }
        }

        private void B2_FrmBaoCaoCaTruc_Load(object sender, System.EventArgs e)
        {
            NapCombobox();
        }

        private void NapCombobox()
        {
            //Nap combo mã nhân viên
            cbMaNhanVien.Properties.Items.Clear();
            cbMaPhanCongCaTruc.Properties.Items.Clear();
            QlBenhVienDataContext bvContext = new QlBenhVienDataContext();
            var lstMaNhanVien = bvContext.HoSoNhanViens.Select(a => new { a.MaNV }).ToList();
            foreach (var item in lstMaNhanVien)
            {
                cbMaNhanVien.Properties.Items.Add(item.MaNV);
            }
            cbMaNhanVien.SelectedIndex = 0;
            var lstMaPhanCong = bvContext.BangPhanCongCaTrucs.Select(pc => new { pc.MaBPCCT }).ToList();
            foreach (var item in lstMaPhanCong)
            {
                cbMaPhanCongCaTruc.Properties.Items.Add(item.MaBPCCT);
            }
            cbMaPhanCongCaTruc.SelectedIndex = 0;
        }

        private void cbMaNhanVien_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!cbMaNhanVien.Text.Trim().Equals(""))
            {
                QlBenhVienDataContext bvContext = new QlBenhVienDataContext();
                var nhanVien = bvContext.HoSoNhanViens
                    .SingleOrDefault(hs => hs.MaNV == int.Parse(cbMaNhanVien.Text.Trim()));
                lblHoTen.Text = nhanVien.HoTen;
                lblNgaySinh.Text = nhanVien.NgaySinh.ToShortDateString();
                lblGioiTinh.Text = nhanVien.GioiTinh.ToString();
                lblQueQuan.Text = nhanVien.QueQuan;
                lblDiaChiHienTai.Text = nhanVien.DiaChiHienTai;
                lblTrinhDo.Text = nhanVien.TrinhDo;
                lblNgayVaoLam.Text = nhanVien.NgayVaoLam.Value.ToShortDateString();
                lblSoBHXH.Text = nhanVien.SoBHXH;
            }
        }

        private void cbMaPhanCongCaTruc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!cbMaPhanCongCaTruc.Text.Trim().Equals(""))
            {
                QlBenhVienDataContext bvContext = new QlBenhVienDataContext();
                var bangPhanCong = bvContext.BangPhanCongCaTrucs
                    .SingleOrDefault(pc => pc.MaBPCCT == int.Parse(cbMaPhanCongCaTruc.Text.Trim()));
                lblThoiGianPhanCong.Text = bangPhanCong.Nam.ToShortDateString();
            }
        }

        private void rdThongKeToanBo_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rdThongKeToanBo.Checked)
            {
                DialogResult result = XtraMessageBox.Show("Bạn có muốn xuất toàn bộ thông tin các ca trực!"
                    , "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RptBangPhanCongCaTruc rpt = new RptBangPhanCongCaTruc();
                    //rpt.FilterString = string.Format("[MaNV] = {0}", maNhanVien);
                    rpt.CreateDocument();
                    rpt.ShowPreviewDialog();
                }

            }
        }

        private void btnInDanhSachTheoMaNV_Click(object sender, System.EventArgs e)
        {
            if (rdThongKeTheoMaNV.Checked)
            {
                if (cbMaNhanVien.Text.Equals(""))
                {
                    XtraMessageBox.Show("Vui lòng chọn mã nhân viên trước khi thống kê!"
                   , "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return;
                }
                DialogResult result = XtraMessageBox.Show("Bạn có muốn xuất thông tin ca trực của nhân viên: " + lblHoTen.Text + " ?"
                    , "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RptBangPhanCongCaTruc rpt = new RptBangPhanCongCaTruc();
                    rpt.FilterString = string.Format("[MaNV] = {0}", int.Parse(cbMaNhanVien.Text));
                    rpt.CreateDocument();
                    rpt.ShowPreviewDialog();
                }
            }
        }

        private void btnInDsTheoMaPhanCongCaTruc_Click(object sender, System.EventArgs e)
        {
            if (rdThongKeTheoMaCaTruc.Checked)
            {
                if (cbMaPhanCongCaTruc.Text.Equals(""))
                {
                    XtraMessageBox.Show("Vui lòng chọn mã ca trực trước khi thống kê!"
                   , "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return;
                }
                DialogResult result = XtraMessageBox.Show("Bạn có muốn xuất thông tin ca trực với mốc thời gian: " + lblThoiGianPhanCong.Text + " ?"
                    , "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RptBangPhanCongCaTruc rpt = new RptBangPhanCongCaTruc();
                    rpt.FilterString = string.Format("[MaBPCCT] = {0}", int.Parse(cbMaPhanCongCaTruc.Text));
                    rpt.CreateDocument();
                    rpt.ShowPreviewDialog();
                }
            }
        }
    }
}