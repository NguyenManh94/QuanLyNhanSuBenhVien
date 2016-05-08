using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QlNhanSuBenhVien.UserInterface;

namespace QlNhanSuBenhVien.Reports
{
    public partial class RptHoSoNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public RptHoSoNhanVien()
        {
            InitializeComponent();
        }

        private void RptHoSoNhanVien_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlblHoTen.Text = A6_FrmDangNhap._TenTaiKhoan;
        }
    }
}
