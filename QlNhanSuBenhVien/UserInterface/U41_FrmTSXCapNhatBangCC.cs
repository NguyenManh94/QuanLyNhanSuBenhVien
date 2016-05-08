using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QlNhanSuBenhVien.Entity;
using QlNhanSuBenhVien.LinqBiz;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class U41_FrmTSXCapNhatBangCC : DevExpress.XtraEditors.XtraForm
    {
        public U41_FrmTSXCapNhatBangCC() { InitializeComponent(); }

        public BangChamCongTemp BangCC { get; set; }

        private void U41_FrmTSXCapNhatBangCC_Load(object sender, EventArgs e)
        {
            try
            {
                if (Text == "Sửa Bảng Chấm Công")
                {
                    txtMaBangCC.Text = BangCC.MaBCC.ToString();
                    cbThang.Text = BangCC.Thang.ToString();
                    txtSoBHXH.Text = BangCC.SoCongHuongBHXH.ToString();
                    txtSoCong.Text = BangCC.SoCong.ToString();
                }
                else
                {
                    txtMaBangCC.Text = txtSoBHXH.Text = txtSoCong.Text = "";
                }
            }
            catch { }
        }

        private void chkKiemTraHopLe_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkKiemTraHopLe.Checked)
                {
                    if (txtSoCong.Text.Length < 1)
                    {
                        XtraMessageBox.Show("Số công không thể để trống!", "Chú ý!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                        return;
                    }
                    int soCong;
                    bool checkSoCong = int.TryParse(txtSoCong.Text, out soCong);
                    if (checkSoCong == false)
                    {
                        XtraMessageBox.Show("Số công sai định dạng. Số công phải là kiểu số!", "Chú ý!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                        return;
                    }
                    XtraMessageBox.Show("Thông tin hợp lê!", "Chú ý!"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetReadOnly(true);
                }
                else
                    SetReadOnly(false);
            }
            catch { }
        }

        private void SetReadOnly(bool valueSet)
        {
            txtSoBHXH.ReadOnly = txtSoCong.ReadOnly = cbThang.ReadOnly = valueSet;
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
                if (Text == "Sửa Bảng Chấm Công")
                {
                    BangChamCong bccOld = bvContext.BangChamCongs.SingleOrDefault(bcc => bcc.MaBCC == int.Parse(txtMaBangCC.Text));
                    bccOld.Thang = Convert.ToInt16(cbThang.Text);
                    bccOld.SoCong = Convert.ToInt16(txtSoCong.Text.Trim());
                    bccOld.SoCongHuongBHXH = Convert.ToInt16(txtSoBHXH.Text.Trim());
                    bvContext.SubmitChanges();
                    XtraMessageBox.Show("Sửa thông tin thành công! Xem chi tiết dưới lưới hiển thị!"
                   , "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BangChamCong bcc = new BangChamCong
                    {
                        Thang = Convert.ToInt16(cbThang.Text),
                        SoCong = Convert.ToInt16(txtSoCong.Text.Trim()),
                        SoCongHuongBHXH = Convert.ToInt16(txtSoBHXH.Text.Trim())
                    };
                    bvContext.BangChamCongs.InsertOnSubmit(bcc);
                    bvContext.SubmitChanges();
                    XtraMessageBox.Show("Thêm thông tin thành công! Xem chi tiết dưới lưới hiển thị!"
                    , "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch { }
        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            U41_FrmTSXCapNhatBangCC_Load(sender, e);
        }
    }
}