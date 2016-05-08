using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QlNhanSuBenhVien.Reports
{
    public partial class RptBangPhanCongCaTruc : DevExpress.XtraReports.UI.XtraReport
    {
        public RptBangPhanCongCaTruc()
        {
            InitializeComponent();
        }

        private int i = 0;
        private void lblSoThuTu_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblSoThuTu.Text = (++i).ToString();
        }

        public string TenNhanVien { get; set; }
        private void RptBangPhanCongCaTruc_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrlblHoTen.Text = TenNhanVien;
        }
    }
}
