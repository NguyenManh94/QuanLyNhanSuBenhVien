using QlNhanSuBenhVien.UserInterface;

namespace QlNhanSuBenhVien.Reports
{
    public partial class RptBangChamCong : DevExpress.XtraReports.UI.XtraReport
    {
        public RptBangChamCong()
        {
            InitializeComponent();
        }

        private void RptBangChamCong_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlblHoTen.Text = A6_FrmDangNhap._TenTaiKhoan;
        }

        private int i = 0;
        private void lblSoThuTu_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblSoThuTu.Text = (++i).ToString();
        }
    }
}
