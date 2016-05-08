using QlNhanSuBenhVien.LinqBiz;
using System.Linq;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class T4_FrmTimKiemBangCC : DevExpress.XtraEditors.XtraForm
    {
        public T4_FrmTimKiemBangCC()
        {
            InitializeComponent();
        }

        private void T4_FrmTimKiemBangCC_Load(object sender, System.EventArgs e)
        {
            try
            {
                QlBenhVienDataContext bvContext = new QlBenhVienDataContext();
                var lstThongTinChamCong = (from bct in bvContext.BangChiTietChamCongs
                                           join bcc in bvContext.BangChamCongs
                                           on bct.MaBCC equals bcc.MaBCC
                                           join hs in bvContext.HoSoNhanViens
                                           on bct.MaNV equals hs.MaNV
                                           select new
                                           {
                                               bcc.MaBCC,
                                               bcc.Thang,
                                               bcc.SoCong,
                                               bcc.SoCongHuongBHXH,
                                               hs.MaNV,
                                               hs.HoTen
                                           }).ToList();
                grcBangChamCong.DataSource = lstThongTinChamCong;
                gvBangChamCong.ExpandAllGroups();
            }
            catch { }
        }
    }
}