using QlNhanSuBenhVien.LinqBiz;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QlNhanSuBenhVien.UserInterface
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            var bvContext = new QlBenhVienDataContext();
            List<NhomQuyen> lstNhomQuyen = bvContext.NhomQuyens.Select(nq => nq).ToList();
            gridControl1.DataSource = lstNhomQuyen;
        }
    }
}