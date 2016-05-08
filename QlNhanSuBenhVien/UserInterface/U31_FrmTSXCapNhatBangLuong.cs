using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QlNhanSuBenhVien.Entity;
using QlNhanSuBenhVien.LinqBiz;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class U31_FrmTSXCapNhatBangLuong : XtraForm
    {
        public U31_FrmTSXCapNhatBangLuong() { InitializeComponent(); }

        public BangLuongTemp BlTemp { get; set; }

        private void U31_FrmTSXCapNhatBangLuong_Load(object sender, EventArgs e)
        {
            try
            {
                if (Text == "Sửa Bảng Lương")
                {
                    SetReadOnly(false);
                    txtMaBL.Text = BlTemp.MaBL.ToString();
                    txtHeSoCV.Text = BlTemp.HeSoCV.ToString();
                    txtHeSoLuong.Text = BlTemp.HeSoLuong.ToString();
                    txtPhuCapThamNien.Text = BlTemp.PhuCapThamNien.ToString();
                    txtCacKhoanDongGop.Text = BlTemp.CacKhoanDongGop.ToString();
                    cbTongLuong.Text = BlTemp.TongLuong.ToString();
                    txtThucLinh.Text = BlTemp.ThucLinh.ToString();
                }
                else
                {
                    SetReadOnly(false);
                    txtHeSoCV.Text = txtHeSoLuong.Text = txtPhuCapThamNien.Text = txtCacKhoanDongGop.Text = "";
                }
            }
            catch { }
        }

        private double _LuongThucLinh;
        private void chkKiemTraHopLe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKiemTraHopLe.Checked)
            {
                #region Kiểm tra điều kiện hợp lệ
                if (txtHeSoCV.Text.Trim().Length < 1 || txtHeSoLuong.Text.Trim().Length < 1)
                {
                    XtraMessageBox.Show("Hệ số chức vụ và hệ số lương không thể để trống!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                #region Kiểm tra hợp lệ kiểu dữ liêu đầu vào
                double heSoCv, heSoLuong, phuCap, cacKhoanDongGop;
                var chkHeSoCv = double.TryParse(txtHeSoCV.Text, out heSoCv);
                var chkHeSoLuong = double.TryParse(txtHeSoLuong.Text, out heSoLuong);
                var chkPhuCap = double.TryParse(txtPhuCapThamNien.Text, out phuCap);
                var chkCacKhoanDongGop = double.TryParse(txtCacKhoanDongGop.Text, out cacKhoanDongGop);
                #endregion
                if (chkHeSoCv == false || chkHeSoLuong == false)
                {
                    XtraMessageBox.Show("Hệ số chức vụ và hệ số lương không đúng định dạng- phải là kiểu số!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                    return;
                }
                if (txtPhuCapThamNien.Text.Trim().Length > 0)
                {
                    if (chkPhuCap == false)
                    {
                        XtraMessageBox.Show("Phụ cấp thâm niên không đúng định dạng- phải là kiểu số!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                        return;
                    }
                }
                if (txtCacKhoanDongGop.Text.Trim().Length > 0)
                {
                    if (chkCacKhoanDongGop == false)
                    {
                        XtraMessageBox.Show("Các khoản đóng góp không đúng định dạng- phải là kiểu số!", "Chú ý!"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        chkKiemTraHopLe.CheckState = CheckState.Unchecked;
                        return;
                    }
                }
                #endregion
                SetReadOnly(true);
                XtraMessageBox.Show("Các thông tin đầu vào hợp lệ!", "Chú ý!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Tính toán số tiền tri phí cho đầu vào -
                double luongKhoiDiem = Convert.ToDouble(cbTongLuong.Text.Trim().Replace(".", "").Replace(",", ""));
                _LuongThucLinh = luongKhoiDiem * heSoLuong + 0.35 * luongKhoiDiem * heSoLuong + phuCap - cacKhoanDongGop;
                txtThucLinh.Text = _LuongThucLinh.ToString();
            }
            else
            {
                SetReadOnly(false);
            }
        }

        private void SetReadOnly(bool valueSet)
        {
            txtHeSoCV.ReadOnly = txtHeSoLuong.ReadOnly = txtPhuCapThamNien.ReadOnly
                = txtCacKhoanDongGop.ReadOnly = valueSet;
        }

        private void barBtnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            U31_FrmTSXCapNhatBangLuong_Load(sender, e);
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
                if (Text == "Sửa Bảng Lương")
                {
                    BangLuong blOld = bvContext.BangLuongs.SingleOrDefault(l => l.MaBL == int.Parse(txtMaBL.Text));
                    blOld.HeSoCV = Convert.ToDouble(txtHeSoCV.Text);
                    blOld.HeSoLuong = Convert.ToDouble(txtHeSoLuong.Text.Trim());
                    blOld.PhuCapThamNien = Convert.ToDouble(txtPhuCapThamNien.Text.Trim());
                    blOld.CacKhoanDongGop = Convert.ToDouble(txtCacKhoanDongGop.Text.Trim());
                    blOld.TongLuong = Convert.ToDouble(cbTongLuong.Text.Trim().Replace(".", "").Replace(",", ""));
                    blOld.ThucLinh = Convert.ToDouble(txtThucLinh.Text.Trim());
                    bvContext.SubmitChanges();
                    XtraMessageBox.Show("Sửa thông tin thành công! Xem chi tiết dưới lưới hiển thị!"
                   , "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BangLuong bl = new BangLuong
                    {
                        HeSoCV = Convert.ToDouble(txtHeSoCV.Text),
                        HeSoLuong = Convert.ToDouble(txtHeSoLuong.Text.Trim()),
                        PhuCapThamNien = Convert.ToDouble(txtPhuCapThamNien.Text.Trim()),
                        CacKhoanDongGop = Convert.ToDouble(txtCacKhoanDongGop.Text.Trim()),
                        TongLuong = Convert.ToDouble(cbTongLuong.Text.Trim().Replace(".", "").Replace(",", "")),
                        ThucLinh = Convert.ToDouble(txtThucLinh.Text.Trim()),
                    };
                    bvContext.BangLuongs.InsertOnSubmit(bl);
                    bvContext.SubmitChanges();
                    XtraMessageBox.Show("Thêm thông tin thành công! Xem chi tiết dưới lưới hiển thị!"
                    , "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch { }
        }
    }
}