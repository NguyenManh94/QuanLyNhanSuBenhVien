using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QlNhanSuBenhVien.LinqBiz;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class U42_FrmThietLapBangCC : DevExpress.XtraEditors.XtraForm
    {
        public U42_FrmThietLapBangCC()
        {
            InitializeComponent();
        }

        private void U42_FrmThietLapBangCC_Load(object sender, EventArgs e)
        {
            try
            {
                //Nạp dữ liệu combobox mã bảng chấm công
                cbMaBangChamCong.Properties.Items.Clear();
                cbMaNhanVien.Properties.Items.Clear();

                QlBenhVienDataContext bvContext = new QlBenhVienDataContext();
                var lstMaBangCC = bvContext.BangChamCongs.Select(bcc => new { bcc.MaBCC });
                foreach (var item in lstMaBangCC)
                {
                    cbMaBangChamCong.Properties.Items.Add(item.MaBCC);
                }
                cbMaBangChamCong.SelectedIndex = 0;


                //Nạp dữ liệu bombobox mã nhân viên
                var lstMaNV = bvContext.HoSoNhanViens.Select(nv => new { nv.MaNV });
                foreach (var item in lstMaNV)
                {
                    cbMaNhanVien.Properties.Items.Add(item.MaNV);
                }
                cbMaNhanVien.SelectedIndex = 0;
            }
            catch { }
        }

        private void barBtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                QlBenhVienDataContext bvContext = new QlBenhVienDataContext();
                BangChiTietChamCong bct = new BangChiTietChamCong
                {
                    MaBCC = int.Parse(cbMaBangChamCong.Text.Trim()),
                    MaNV = int.Parse(cbMaNhanVien.Text.Trim())
                };
                bvContext.BangChiTietChamCongs.InsertOnSubmit(bct);
                bvContext.SubmitChanges();
                XtraMessageBox.Show("Thêm mới nhân viên vào bảng chấm công thành công!", "Chú ý"
                   , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                XtraMessageBox.Show("Nhân viên này đã được thiết lâp trong bảng lương này!", "Chú ý"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}