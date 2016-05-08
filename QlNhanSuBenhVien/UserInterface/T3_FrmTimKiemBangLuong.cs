using QlNhanSuBenhVien.LinqBiz;
using System.Collections.Generic;
using System.Linq;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class T3_FrmTimKiemBangLuong : DevExpress.XtraEditors.XtraForm
    {
        public T3_FrmTimKiemBangLuong()
        {
            InitializeComponent();
        }

        private void T3_FrmTimKiemBangLuong_Load(object sender, System.EventArgs e)
        {
            try
            {
                var bvContext = new QlBenhVienDataContext();
                List<BangLuong> lstBangLuong = bvContext.BangLuongs.Select(bl => bl).ToList();
                grcBangLuong.DataSource = lstBangLuong;
            }
            catch { }
        }
    }
}