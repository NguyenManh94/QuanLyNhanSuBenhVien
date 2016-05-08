using QlNhanSuBenhVien.LinqBiz;
using System.Linq;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class T2_FrmTimKiemCaTruc : DevExpress.XtraEditors.XtraForm
    {
        public T2_FrmTimKiemCaTruc() { InitializeComponent(); }

        private void T2_FrmTimKiemCaTruc_Load(object sender, System.EventArgs e)
        {
            NapDuLieu();
        }

        private void NapDuLieu()
        {
            try
            {
                var bvContext = new QlBenhVienDataContext();
                var lstThongTinCaTruc = bvContext.BangChiTietPhanCongCaTrucs
                    .Join(bvContext.HoSoNhanViens, bct => bct.MaNV, hs => hs.MaNV
                    , (bct, hs) => new { bct.MaBPCCT, bct.MaNV, hs.HoTen, hs.TrinhDo, hs.GioiTinh })
                    .Join(bvContext.BangPhanCongCaTrucs, bangNew => bangNew.MaBPCCT, bpc => bpc.MaBPCCT
                    , (bangNew, bpc) => new
                    {
                        bangNew.MaBPCCT,
                        bangNew.MaNV,
                        bpc.Nam,
                        bangNew.HoTen,
                        bangNew.TrinhDo,
                        bangNew.GioiTinh
                    }).ToList();
                grcCaTruc.DataSource = lstThongTinCaTruc;
                gvCaTruc.ExpandAllGroups();
            }
            catch { }
        }
    }
}